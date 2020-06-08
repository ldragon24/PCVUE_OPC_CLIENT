Public Class frmALARM
    Dim T_ALARM As System.Threading.Thread
    'Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Byte, ByVal dwExtraInfo As Byte)
    'Private Const VK_RETURN As Byte = &HD
    'Private Const KEYEVENTF_KEYDOWN As Byte = &H0
    'Private Const KEYEVENTF_KEYUP As Byte = &H2
    Private END_OPROS As Boolean = False
    Private lstVW As ListView
    ' Private Const CP_NOCLOSE_BUTTON As Integer = &H200

    'Protected Overrides ReadOnly Property CreateParams As System.Windows.Forms.CreateParams
    '    Get
    '        Dim myCP As CreateParams = MyBase.CreateParams
    '        myCP.ClassStyle = myCP.ClassStyle Or CP_NOCLOSE_BUTTON

    '        Return myCP
    '    End Get

    'End Property

    Private Sub frmTMP_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        T_ALARM.Abort()
        m_server.CancelSubscription(group_Alarmt)
        SALARM = False


    End Sub

    Private Sub frmTMP_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        LV_REPORT_ALARM.Columns.Add("Дата\Время", 150, HorizontalAlignment.Left)
        'LV_REPORT_ALARM.Columns.Add("Событие", 300, HorizontalAlignment.Left)
        LV_REPORT_ALARM.Columns.Add("Описание", 300, HorizontalAlignment.Left)
        LV_REPORT_ALARM.Columns.Add("Наименование", 300, HorizontalAlignment.Left)

        ResList(LV_REPORT_ALARM)

        System.Windows.Forms.Application.DoEvents()

        Select Case btnRp10V1.Text

            Case "Старт"

                btnRp10V1.Text = "Стоп"
                T_ALARM = New System.Threading.Thread(AddressOf Ti_ALARM_START)
                T_ALARM.Start()

            Case "Стоп"

                btnRp10V1.Text = "Старт"
                m_server.CancelSubscription(group_Alarmt)
                T_ALARM.Abort()

        End Select

    End Sub

    Private Sub btnRp10V1_Click(sender As System.Object, e As System.EventArgs) Handles btnRp10V1.Click

        Select Case btnRp10V1.Text

            Case "Старт"

                btnRp10V1.Text = "Стоп"
                T_ALARM = New System.Threading.Thread(AddressOf Ti_ALARM_START)
                T_ALARM.Start()

            Case "Стоп"

                btnRp10V1.Text = "Старт"
                m_server.CancelSubscription(group_Alarmt)
                T_ALARM.Abort()

        End Select


    End Sub

    Sub Ti_ALARM_START()

        Dim sSQL As String
        Dim cmd As OleDbCommand
        Dim rs As OleDbDataReader

        'sSQL = "SELECT count(*) as t_n FROM dbo.[Vars] where Label like '%Ава%'and label not like 'Квитирование%' or Label like 'неиспр%' or Label like 'Потеря%' or Label like '%не в норме%' or Label like '%низ%' or Label like '%отказ%' or Label like '%повыш%' or Label like '%сбой%' or Label like '%сраб%' or Label like '%отключение%' or Label like '%пере%' or Label like '%неопред%' or Label like '%пониж%'"
        sSQL = "SELECT count(*) as t_n FROM Vars"
        'Д. обр. воды отоп. после насос. не в норме
        ' cmd = New OleDbCommand(sSQL, DBASUE)
        cmd = New OleDbCommand(sSQL, DB7)
        rs = cmd.ExecuteReader

        Dim sCOUNT As Integer

        While rs.Read

            sCOUNT = rs.Item("t_n")

        End While

        rs.Close()
        rs = Nothing

        Dim sOpisanie(sCOUNT) As String


        SALARM = False
        Try
ARG:
            groupState_Alarmt.Name = "ALARMs"
            groupState_Alarmt.Active = True
            groupState_Alarmt.UpdateRate = MSPEED

            group_Alarmt = DirectCast(m_server.CreateSubscription(groupState_Alarmt), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(sCOUNT - 1) {}

            'sSQL = "SELECT Name FROM dbo.[Vars] where Label like '%Ава%'and label not like 'Квитирование%' or Label like 'неиспр%' or Label like 'Потеря%' or Label like '%не в норме%' or Label like '%низ%' or Label like '%отказ%' or Label like '%повыш%' or Label like '%сбой%' or Label like '%сраб%' or Label like '%отключение%' or Label like '%пере%' or Label like '%неопред%' or Label like '%пониж%'"
            sSQL = "SELECT * FROM Vars"
            'cmd = New OleDbCommand(sSQL, DBASUE)
            cmd = New OleDbCommand(sSQL, DB7)
            rs = cmd.ExecuteReader

            Dim intCount2 As Decimal = 0
            While rs.Read


                'If Len(rs.Item("Name")) > 0 Then
                items(intCount2) = New Global.Opc.Da.Item()
                items(intCount2).ItemName = rs.Item("Name")
                sOpisanie(intCount2) = rs.Item("Label")

                intCount2 = intCount2 + 1
                ' Else
                'End If
            End While

            rs.Close()
            rs = Nothing

            items = group_Alarmt.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_Alarmt.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                Me.Invoke(Sub() LV_REPORT_ALARM.Sorting = SortOrder.None)
                Me.Invoke(Sub() LV_REPORT_ALARM.ListViewItemSorter = Nothing)
                Me.Invoke(Sub() LV_REPORT_ALARM.Items.Clear())
                Dim intCount As Decimal = 0

                For i As Integer = 0 To results.Length - 1

                    Select Case results(i).Value

                        Case True

                            'Дата\Время
                            Me.Invoke(Sub() LV_REPORT_ALARM.Items.Add(results(i).Timestamp))

                            Me.Invoke(Sub() LV_REPORT_ALARM.Items(CInt(intCount)).SubItems.Add(sOpisanie(i)))

                            Select Case sOpisanie(i)
                                Case "Авария"

                                    Me.Invoke(Sub() LV_REPORT_ALARM.Items(CInt(intCount)).BackColor = Color.Red)

                                Case "Неисправность"
                                    Me.Invoke(Sub() LV_REPORT_ALARM.Items(CInt(intCount)).BackColor = Color.LawnGreen)

                                Case "Потеря связи"
                                    Me.Invoke(Sub() LV_REPORT_ALARM.Items(CInt(intCount)).BackColor = Color.Tan)

                                Case "Неизвестное положение"
                                    Me.Invoke(Sub() LV_REPORT_ALARM.Items(CInt(intCount)).BackColor = Color.LightPink)

                                Case Else
                                    'Me.Invoke(Sub() LV_REPORT_ALARM.Items(CInt(intCount)).BackColor = Color.LightSeaGreen)
                                    ' Me.Invoke(Sub() LV_REPORT_ALARM.Items(CInt(intCount)).BackColor = Color.LightSeaGreen
                            End Select

                            ''Событие
                            ''Me.Invoke(Sub() LV_REPORT_ALARM.Items(CInt(intCount)).SubItems.Add("Появление"))
                            ''Описание
                            ''sSQL = "SELECT label FROM dbo.[Vars] where name='" & results(i).ItemName.ToString & "'"

                            'sSQL = "SELECT label FROM Vars where name='" & results(i).ItemName.ToString & "'"

                            '' cmd = New OleDbCommand(sSQL, DBASUE)

                            'cmd = New OleDbCommand(sSQL, DB7)
                            'rs = cmd.ExecuteReader

                            'While rs.Read

                            '    If Not IsDBNull(rs.Item("label")) Then

                            '        Me.Invoke(Sub() LV_REPORT_ALARM.Items(CInt(intCount)).SubItems.Add(rs.Item("label")))

                            '        Select Case rs.Item("label")
                            '            Case "Авария"

                            '                Me.Invoke(Sub() LV_REPORT_ALARM.Items(CInt(intCount)).BackColor = Color.Red)

                            '            Case "Неисправность"
                            '                Me.Invoke(Sub() LV_REPORT_ALARM.Items(CInt(intCount)).BackColor = Color.LawnGreen)

                            '            Case Else
                            '                Me.Invoke(Sub() LV_REPORT_ALARM.Items(CInt(intCount)).BackColor = Color.LightSeaGreen)

                            '        End Select
                            '    Else

                            '        Me.Invoke(Sub() LV_REPORT_ALARM.Items(CInt(intCount)).SubItems.Add(""))
                            '        'Me.Invoke(Sub() LV_REPORT_ALARM.Items(CInt(intCount)).SubItems(1).BackColor = Color.White)
                            '    End If

                            'End While
                            'rs.Close()
                            'rs = Nothing

                            'Наименование
                            Me.Invoke(Sub() LV_REPORT_ALARM.Items(CInt(intCount)).SubItems.Add(results(i).ItemName.ToString))

                            'Me.Invoke(Sub() LV_REPORT_ALARM.Items(CInt(intCount)).SubItems.Add(results(i).ItemName))
                            intCount = intCount + 1
                        Case False

                    End Select

                Next

                Me.Invoke(Sub() ResList(LV_REPORT_ALARM))

                If intCount = 0 Then

                    Me.Invoke(Sub() Me.Visible = False)
                    Me.Invoke(Sub() SALARM = False)
                    '   Me.Invoke(Sub() frmIndexer.btnAlarm.BackColor = frmIndexer.ToolStripButton7.BackColor)
                Else
                    Me.Invoke(Sub() Me.Visible = True)
                    'Me.Show()
                    Me.Invoke(Sub() SALARM = True)
                    '  Me.Invoke(Sub() frmIndexer.btnAlarm.BackColor = Color.Red)

                End If

                Threading.Thread.Sleep(50000)

            Loop

        Catch ex As Exception
            'GoTo ARG
            'Print(Err.Description)
            'Me.Invoke(Sub() Print(ex.Message))
        End Try

    End Sub

    Private Sub LV_REPORT_ALARM_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles LV_REPORT_ALARM.ColumnClick

        SORTING_LV(LV_REPORT_ALARM, e)

    End Sub

    Private Sub frmALARM_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Call FONT_SIZE(Me)
    End Sub
End Class