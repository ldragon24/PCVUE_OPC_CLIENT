Imports System.IO

Module MOD_SYSTEM

    Public PrPath As String = Directory.GetParent(System.Windows.Forms.Application.ExecutablePath).ToString & "\"
    Public DBASUE As OleDbConnection
    Public DBASKUER As OleDbConnection
    Public stmpDATE_MIN As Date

    Public SRV1 As Boolean = False
    Public SRV2 As Boolean = False
    Private m_SortingColumn As ColumnHeader
    Dim LNGIniFile As New IniFile(PrPath & "config.ini")

    Public ipSRV1 As String = LNGIniFile.GetString("General", "IPS1", "192.168.6.11")
    Public ipSRV2 As String = LNGIniFile.GetString("General", "IPS2", "192.168.6.12")

    Public SQL_SERVER_ASUE As String = LNGIniFile.GetString("General", "SQLASUE", "192.168.6.13\EMCSSQL")
    Public SQL_SERVER_ASKUER As String = LNGIniFile.GetString("General", "SQLASKUER", "192.168.6.13\HDSEMCS")
    Public SQL_USER_ASUE As String = LNGIniFile.GetString("General", "SQLASUEUSER", "sa")
    Public SQL_USER_ASKUER As String = LNGIniFile.GetString("General", "SQLASKUERUSER", "sa")
    Public SQL_PWD_ASUE As String = LNGIniFile.GetString("General", "SQLASUEPWD", "abc")
    Public SQL_PWD_ASKUER As String = LNGIniFile.GetString("General", "SQLASKUERPWD", "abc")
    Public SQL_DB_ASUE As String = LNGIniFile.GetString("General", "SQLASUEDB", "EMCSDB")
    Public SQL_DB_ASKUER As String = LNGIniFile.GetString("General", "SQLASKUERDB", "TI2_Lukoyanovskaya")
    Public TSPEED As Integer = LNGIniFile.GetString("General", "TSPEED", "500")
    Public MSPEED As Integer = LNGIniFile.GetString("General", "MSPEED", "1000")
    Public TDOT As Integer = LNGIniFile.GetString("General", "TDOT", "6000")


    Public sTartI As String = LNGIniFile.GetString("General", "Start", "САУ-В")
    Public tmpALARM As Boolean = LNGIniFile.GetString("General", "ALARM", "true")

    Public m_subscription As Subscription = Nothing
    Public m_items As Item() = Nothing
    Public m_values As ItemValue() = Nothing
    Public m_results As Opc.ItemIdentifier() = Nothing
    Public m_request As IRequest = Nothing
    Public m_handle As Integer = 0
    Public m_server As Opc.Da.Server = Nothing
    Public m_serverStatus As Opc.Da.ServerStatus = Nothing
    Public m_url As New Global.Opc.URL

    Public fact As New OpcCom.Factory()

    '###########################################################################
    Public groupSAUT As Global.Opc.Da.Subscription
    Public groupStateSAUT As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public groupSAUV As Global.Opc.Da.Subscription
    Public groupStateSAUV As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public groupASTUE As Global.Opc.Da.Subscription
    Public groupStateASTUE As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public groupSTATUS As Global.Opc.Da.Subscription
    Public groupStateSTATUS As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public groupRP10 As Global.Opc.Da.Subscription
    Public groupStateRP10 As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public groupRP10S1 As Global.Opc.Da.Subscription
    Public groupStateRP10S1 As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public groupRP10S2 As Global.Opc.Da.Subscription
    Public groupStateRP10S2 As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public groupKTP_EB As Global.Opc.Da.Subscription
    Public groupStateKTP_EB As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public groupKTP_EB_D As Global.Opc.Da.Subscription
    Public groupStateKTP_EB_D As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public groupKTP_REB As Global.Opc.Da.Subscription
    Public groupStateKTP_REB As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public groupASKUER As Global.Opc.Da.Subscription
    Public groupStateASKUER As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public groupKTP_REB_D As Global.Opc.Da.Subscription
    Public groupStateKTP_REB_D As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public groupKTP_AVO As Global.Opc.Da.Subscription
    Public groupStateKTP_AVO As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public group_Alarmt As Global.Opc.Da.Subscription
    Public groupState_Alarmt As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public group_SAUTh As Global.Opc.Da.Subscription
    Public groupState_SAUTh As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public group_SAUKOS As Global.Opc.Da.Subscription
    Public groupState_SAUKOS As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public group_OCHU As Global.Opc.Da.Subscription
    Public groupState_OCHU As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public group_CHGP As Global.Opc.Da.Subscription
    Public groupState_CHGP As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public group_2BTP As Global.Opc.Da.Subscription
    Public groupState_2BTP As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public group_CHPT As Global.Opc.Da.Subscription
    Public groupState_CHPT As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public group_VOD As Global.Opc.Da.Subscription
    Public groupState_VOD As New Global.Opc.Da.SubscriptionState()
    '###########################################################################

    Public group_VOD1Izm As Global.Opc.Da.Subscription
    Public groupState_VOD1Izm As New Global.Opc.Da.SubscriptionState()

    Public group_VOD2Izm As Global.Opc.Da.Subscription
    Public groupState_VOD2Izm As New Global.Opc.Da.SubscriptionState()

    Public group_F3Izm As Global.Opc.Da.Subscription
    Public groupState_F3Izm As New Global.Opc.Da.SubscriptionState()

    Public group_F4Izm As Global.Opc.Da.Subscription
    Public groupState_F4Izm As New Global.Opc.Da.SubscriptionState()

    Public group_F5Izm As Global.Opc.Da.Subscription
    Public groupState_F5Izm As New Global.Opc.Da.SubscriptionState()

    Public group_F6Izm As Global.Opc.Da.Subscription
    Public groupState_F6Izm As New Global.Opc.Da.SubscriptionState()

    Public group_F7Izm As Global.Opc.Da.Subscription
    Public groupState_F7Izm As New Global.Opc.Da.SubscriptionState()

    Public group_F8Izm As Global.Opc.Da.Subscription
    Public groupState_F8Izm As New Global.Opc.Da.SubscriptionState()

    Public group_F9Izm As Global.Opc.Da.Subscription
    Public groupState_F9Izm As New Global.Opc.Da.SubscriptionState()

    Public group_F2Izm As Global.Opc.Da.Subscription
    Public groupState_F2Izm As New Global.Opc.Da.SubscriptionState()

    Public group_F12Izm As Global.Opc.Da.Subscription
    Public groupState_F12Izm As New Global.Opc.Da.SubscriptionState()

    Public group_F13Izm As Global.Opc.Da.Subscription
    Public groupState_F13Izm As New Global.Opc.Da.SubscriptionState()

    Public group_F14Izm As Global.Opc.Da.Subscription
    Public groupState_F14Izm As New Global.Opc.Da.SubscriptionState()

    Public group_F15Izm As Global.Opc.Da.Subscription
    Public groupState_F15Izm As New Global.Opc.Da.SubscriptionState()

    Public group_F16Izm As Global.Opc.Da.Subscription
    Public groupState_F16Izm As New Global.Opc.Da.SubscriptionState()

    Public group_F17Izm As Global.Opc.Da.Subscription
    Public groupState_F17Izm As New Global.Opc.Da.SubscriptionState()


    Public group_IBP_1 As Global.Opc.Da.Subscription
    Public groupState_IBP_1 As New Global.Opc.Da.SubscriptionState()

    Public group_IBP_2 As Global.Opc.Da.Subscription
    Public groupState_IBP_2 As New Global.Opc.Da.SubscriptionState()

    Public group_IBP_3 As Global.Opc.Da.Subscription
    Public groupState_IBP_3 As New Global.Opc.Da.SubscriptionState()

    Public group_IBP_4 As Global.Opc.Da.Subscription
    Public groupState_IBP_4 As New Global.Opc.Da.SubscriptionState()

    Public group_IBP_5 As Global.Opc.Da.Subscription
    Public groupState_IBP_5 As New Global.Opc.Da.SubscriptionState()

    Public group_EBv1Izm As Global.Opc.Da.Subscription
    Public groupState_EBv1Izm As New Global.Opc.Da.SubscriptionState()

    Public group_EBv2Izm As Global.Opc.Da.Subscription
    Public groupState_EBv2Izm As New Global.Opc.Da.SubscriptionState()

    Public group_REBv1Izm As Global.Opc.Da.Subscription
    Public groupState_REBv1Izm As New Global.Opc.Da.SubscriptionState()

    Public group_REBv2Izm As Global.Opc.Da.Subscription
    Public groupState_REBv2Izm As New Global.Opc.Da.SubscriptionState()

    Public group_AVOv1Izm As Global.Opc.Da.Subscription
    Public groupState_AVOv1Izm As New Global.Opc.Da.SubscriptionState()

    Public group_AVOv2Izm As Global.Opc.Da.Subscription
    Public groupState_AVOv2Izm As New Global.Opc.Da.SubscriptionState()

    Public group_EBavIzm As Global.Opc.Da.Subscription
    Public groupState_EBavIzm As New Global.Opc.Da.SubscriptionState()

    Public group_REBavIzm As Global.Opc.Da.Subscription
    Public groupState_rEBavIzm As New Global.Opc.Da.SubscriptionState()

    'group_F3Izm

    Public groupTrends As Global.Opc.Da.Subscription
    Public groupStateTrends As New Global.Opc.Da.SubscriptionState()
    '###########################################################################
    Public groupTagRead As Global.Opc.Da.Subscription
    Public groupStateTagRead As New Global.Opc.Da.SubscriptionState()
    '###########################################################################


    '###########################################################################
    Public groupSAUT_A As Global.Opc.Da.Subscription
    Public groupStateSAUT_A As New Global.Opc.Da.SubscriptionState()


    Public group_PLC_1 As Global.Opc.Da.Subscription
    Public groupState_PLC_1 As New Global.Opc.Da.SubscriptionState()

    Public group_PLC_2 As Global.Opc.Da.Subscription
    Public groupState_PLC_2 As New Global.Opc.Da.SubscriptionState()

    Public group_PLC_3 As Global.Opc.Da.Subscription
    Public groupState_PLC_3 As New Global.Opc.Da.SubscriptionState()


    'Trends
    Public T_ALARM As System.Threading.Thread
    Public SALARM As Boolean = False
    Public DB7 As OleDbConnection


    Public Declare Function sndPlaySound Lib "winmm.dll" Alias "sndPlaySoundA" (ByVal lpszName As String, ByVal dwFlags As Long) As Long
    Const snd_sync = &H0
    Const snd_async = &H1
    Const snd_nodefault = &H2
    Const snd_memory = &H4
    Const snd_loop = &H8
    Const snd_nostop = &H10

    Sub T_ALARM_START()

        Try

            Do
                Select Case SALARM

                    Case True

                        frmStatus.Invoke(Sub() sndPlaySound(PrPath & "beep.wav", snd_async))

                    Case False

                End Select

                Threading.Thread.Sleep(2000)
            Loop

        Catch ex As Exception

            '  T_ALARM.Abort()

        End Try

    End Sub

    Public Sub LOADDATABASE_ASUE()
        On Error GoTo err_
        Dim ConNect As String

        ConNect = "Provider=SQLOLEDB;Data Source=" & SQL_SERVER_ASUE & "; initial Catalog=" & SQL_DB_ASUE & "; User id=" & SQL_USER_ASUE & "; Password=" & SQL_PWD_ASUE & ";"
        'ConNect = "Provider=SQLOLEDB;Data Source=192.168.6.13\EMCSSQL; initial Catalog=EMCSDB; User id=sa; Password=abc;"
        DBASUE = New OleDbConnection(ConNect)
        DBASUE.Open()
err_:
    End Sub

    Public Sub LOADDATABASE_ASKUER()
        On Error GoTo err_
        Dim ConNect As String

        ConNect = "Provider=SQLOLEDB;Data Source=" & SQL_SERVER_ASKUER & "; initial Catalog=" & SQL_DB_ASKUER & "; User id=" & SQL_USER_ASKUER & "; Password=" & SQL_PWD_ASKUER & ";"
        'ConNect = "Provider=SQLOLEDB;Data Source=192.168.6.13\EMCSSQL; initial Catalog=EMCSDB; User id=sa; Password=abc;"
        DBASKUER = New OleDbConnection(ConNect)
        DBASKUER.Open()
err_:

    End Sub

    Public Sub LOAD_DATABASE_ACCESS_ALERT()
        On Error GoTo err_

        DB7 = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & PrPath & "ASUE_OPER.mdb;User Id=admin;Password=;")
        DB7.Open()

err_:
    End Sub

    Public Sub UNLOADDATABASE()
        On Error GoTo err_

        DBASUE.Close()
        DBASUE = Nothing

        DBASKUER.Close()
        DBASKUER = Nothing

        DB7.Close()
        DB7 = Nothing

err_:
    End Sub

    Public Sub FillComboNET(ByVal pCombo As ComboBox, ByVal pField As String, ByVal pTable As String,
                         Optional ByVal WHEREClause As String = "", Optional ByVal AddBlank As Boolean = False,
                         Optional ByVal ClearFirst As Boolean = True, Optional ByVal PreserveValue As Boolean = True)
        'On Error Resume Next
        On Error GoTo err_

        pCombo.Items.Clear()

        Dim cmd As OleDbCommand
        Dim rs As OleDbDataReader

        cmd = New OleDbCommand("SELECT count(*) as t_n FROM " & pTable & " WHERE " & pField & "<>''", DBASUE)
        rs = cmd.ExecuteReader

        Dim COUnT As String = ""

        While rs.Read

            COUnT = rs.Item("t_n")

        End While
        rs.Close()
        rs = Nothing

        Select Case COUnT

            Case 0

            Case Else

                cmd = New OleDbCommand("SELECT " & pField & " FROM " & pTable & " WHERE " & pField & "<>'' ORDER BY " & pField, DBASUE)
                rs = cmd.ExecuteReader

                While rs.Read

                    If Not IsDBNull(rs.Item(pField)) Then pCombo.Items.Add(rs.Item(pField))

                End While

                rs.Close()
                rs = Nothing

        End Select

        Exit Sub
err_:
        MsgBox(Err.Description, MsgBoxStyle.Critical, "")
    End Sub

    Public Sub ExportListViewToExcel(ByVal MyListView As ListView, ByVal sTXT As String)

        Const MAX_COLUMS As Int16 = 254

        Dim i As Integer

        Dim New_Item As ListViewItem

        Dim TempColum As Int16

        Dim ColumLetter As String = ""

        Dim TempRow As Int16

        Dim TempColum2 As Int16

        Dim AddedColours As Int16 = 1

        Dim MyColours As Hashtable = New Hashtable

        Dim AddNewBackColour As Boolean = True

        Dim AddNewFrontColour As Boolean = True

        '##########################

        Dim chartRange As Excel.Range

        '##########################

        Dim ExcelReport As Excel.Application

        'ExcelReport = New Excel.ApplicationClass

        ExcelReport = New Excel.Application

        ExcelReport.Visible = True

        ExcelReport.Workbooks.Add()

        i = 0

        Do Until i = MyListView.Columns.Count

            If i > MAX_COLUMS Then

                MsgBox("Too many Colums added")

                Exit Do

            End If

            TempColum = i

            TempColum2 = 0

            Do While TempColum > 25

                TempColum -= 26

                TempColum2 += 1

            Loop

            ColumLetter = Chr(97 + TempColum)

            If TempColum2 > 0 Then ColumLetter = Chr(96 + TempColum2) & ColumLetter

            ExcelReport.Range(ColumLetter & 5).Value = MyListView.Columns(i).Text

            ExcelReport.Range(ColumLetter & 5).Font.Bold = True

            chartRange = ExcelReport.Range(ColumLetter & 5)

            chartRange.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic)

            i += 1

        Loop

        '###############################################

        'Вставляем заголовок

        '###############################################

        'Устанавливаем диапазон ячеек

        chartRange = ExcelReport.Range("A1", ColumLetter & 3)

        'Объединяем ячейки

        chartRange.Merge()

        'Вставляем текст

        chartRange.FormulaR1C1 = sTXT

        'Выравниваем по центру

        chartRange.HorizontalAlignment = 6

        chartRange.VerticalAlignment = 2

        ''Устанавливаем шрифт

        'ExcelReport.Range("A1").Font.Name = MyListView.Font.Name

        ''Увеличиваем шрифт

        'ExcelReport.Range("A1").Font.Size = MyListView.Font.Size + 4

        ''Делаем шрифт жирным

        'ExcelReport.Range("A1").Font.Bold = True

        '###############################################

        '###############################################


        TempRow = 6

        For Each New_Item In MyListView.Items

            i = 0

            Do Until i = New_Item.SubItems.Count

                If i > MAX_COLUMS Then

                    MsgBox("Too many Colums added")

                    Exit Do

                End If

                TempColum = i

                TempColum2 = 0

                Do While TempColum > 25

                    TempColum -= 26

                    TempColum2 += 1

                Loop

                ColumLetter = Chr(97 + TempColum)

                If TempColum2 > 0 Then ColumLetter = Chr(96 + TempColum2) & ColumLetter

                ExcelReport.Range(ColumLetter & TempRow).Value = New_Item.SubItems(i).Text

                chartRange = ExcelReport.Range(ColumLetter & TempRow)

                chartRange.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic)


                i += 1

            Loop

            TempRow += 1

        Next


        ExcelReport.Cells.Select()

        ExcelReport.Cells.EntireColumn.AutoFit()

        ExcelReport.Cells.Range("A1").Select()

    End Sub

    Public Sub ResList(ByVal resizingListView As ListView)

        'resizingListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize)
        'resizingListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)

        Dim columnIndex As Integer

        'If resizingListView.Items.Count = 0 Then

        For columnIndex = 1 To resizingListView.Columns.Count - 1
            resizingListView.AutoResizeColumn(columnIndex, ColumnHeaderAutoResizeStyle.ColumnContent)
        Next

        'Else

        '    For columnIndex = 1 To resizingListView.Columns.Count - 1
        '        resizingListView.AutoResizeColumn(columnIndex, ColumnHeaderAutoResizeStyle.ColumnContent)
        '    Next

        'End If
    End Sub

    Public Sub SORTING_LV(ByVal LV As ListView, e As System.Windows.Forms.ColumnClickEventArgs)

        Dim new_sorting_column As ColumnHeader =
              LV.Columns(e.Column)
        Dim sort_order As SortOrder
        If m_SortingColumn Is Nothing Then
            sort_order = SortOrder.Ascending
        Else
            If new_sorting_column.Equals(m_SortingColumn) Then
                If m_SortingColumn.Text.StartsWith("> ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                sort_order = SortOrder.Ascending
            End If

            m_SortingColumn.Text = m_SortingColumn.Text.Substring(2)
        End If

        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "> " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "< " & m_SortingColumn.Text
        End If

        LV.ListViewItemSorter = New ListViewComparer(e.Column, sort_order)

        LV.Sort()

    End Sub

    Public Sub MIN_CHRONO_TRD()

        On Error GoTo err_

        Dim sSQL As String

        sSQL = "SELECT TOP 1 max(Chrono) as f_s, min(Chrono) as f_d FROM dbo.[TRD]"

        Dim cmd As OleDbCommand
        Dim rs As OleDbDataReader

        cmd = New OleDbCommand(sSQL, DBASUE)
        rs = cmd.ExecuteReader
        Dim sMax As String = ""
        Dim sMin As String = ""

        While rs.Read

            sMax = rs.Item("f_s")
            sMin = rs.Item("f_d")

        End While
        rs.Close()
        rs = Nothing

        sSQL = "SELECT TOP 1 dbo.fn_ChronoToDateTime('" & sMax & "') as f_s, dbo.fn_ChronoToDateTime('" & sMin & "') as f_d FROM dbo.[TRD]"

        cmd = New OleDbCommand(sSQL, DBASUE)
        rs = cmd.ExecuteReader
        While rs.Read

            sMax = rs.Item("f_s")
            sMin = rs.Item("f_d")

        End While
        rs.Close()
        rs = Nothing

        stmpDATE_MIN = sMin

        Exit Sub
err_:

        sMax = Date.Today
        sMin = Date.Today.AddDays(-7)
        stmpDATE_MIN = sMin

    End Sub

    Public Sub FONT_SIZE(ByVal ControlContainer As Object)

        Dim W1 As Integer = ((frmIndexer.Width + frmIndexer.Height) / 200)

        If W1 > 14 Then W1 = 13
        If W1 < 6 Then W1 = 6

        For Each Ctl As Object In ControlContainer.Controls
            Try
                If Not Ctl.Controls Is Nothing Then
                    FONT_SIZE(Ctl)

                    If TypeOf Ctl Is System.Windows.Forms.Label Then Ctl.Font = New System.Drawing.Font("Microsoft Sans Serif", W1, 0, 3, True)
                    If TypeOf Ctl Is System.Windows.Forms.ComboBox Then Ctl.Font = New System.Drawing.Font("Microsoft Sans Serif", W1, 0, 3, True)
                    If TypeOf Ctl Is System.Windows.Forms.ListView Then Ctl.Font = New System.Drawing.Font("Microsoft Sans Serif", W1, 0, 3, True)
                    If TypeOf Ctl Is System.Windows.Forms.Button Then Ctl.Font = New System.Drawing.Font("Microsoft Sans Serif", W1, 0, 3, True)
                    If TypeOf Ctl Is System.Windows.Forms.DateTimePicker Then Ctl.Font = New System.Drawing.Font("Microsoft Sans Serif", W1, 0, 3, True)
                    If TypeOf Ctl Is System.Windows.Forms.NumericUpDown Then Ctl.Font = New System.Drawing.Font("Microsoft Sans Serif", W1, 0, 3, True)
                    If TypeOf Ctl Is System.Windows.Forms.TextBox Then Ctl.Font = New System.Drawing.Font("Microsoft Sans Serif", W1, 0, 3, True)
                    'If TypeOf Ctl Is System.Windows.Forms.ToolStrip Then Ctl.Font = New System.Drawing.Font("Microsoft Sans Serif", W1, 0, 3, True)
                    ' If TypeOf Ctl Is System.Windows.Forms.StatusStrip Then Ctl.Font = New System.Drawing.Font("Microsoft Sans Serif", W1 + 1, 0, 3, True)
                    'If TypeOf Ctl Is System.Windows.Forms.MenuStrip Then Ctl.Font = New System.Drawing.Font("Microsoft Sans Serif", W1 + 1, 0, 3, True)
                    If TypeOf Ctl Is System.Windows.Forms.GroupBox Then Ctl.Font = New System.Drawing.Font("Microsoft Sans Serif", W1 + 1, 0, 3, True)

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub

    Public Sub LineColor(ByVal Color As String, ByVal line As PowerPacks.LineShape)

        Select Case Color
            Case "0"
                line.BorderColor = System.Drawing.Color.Black
            Case "1"
                line.BorderColor = System.Drawing.Color.Gray
            Case "2"
                line.BorderColor = System.Drawing.Color.Blue
            Case "4"
                line.BorderColor = System.Drawing.Color.Blue
            Case "8"
                line.BorderColor = System.Drawing.Color.DeepSkyBlue

            Case "32"
                line.BorderColor = System.Drawing.Color.Yellow

            Case "40"
                line.BorderColor = System.Drawing.Color.Yellow

            Case Else
                line.BorderColor = System.Drawing.Color.Pink

        End Select

    End Sub



End Module
