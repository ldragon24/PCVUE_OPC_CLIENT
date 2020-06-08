Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.IO
Imports System.Net
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security
Imports System.Security.Permissions
Imports System.Reflection
Imports System.Threading
Imports System.Runtime.InteropServices
Imports Opc
Imports Opc.Da
Imports Opc.Cpx
Imports System.Net.Mail

'Imports Opc.Dx
'Imports Opc.SampleClient

Public Class frmIndexer

    ' Dim T_STATUS_SERV As System.Threading.Thread
    ' Dim T_FRMALARM As System.Threading.Thread
    Dim T_H1 As System.Threading.Thread

    Public Sub LOAD_SERVER()
        On Error GoTo err_

        Dim LNGIniFile As New IniFile(PrPath & "config.ini")
        Dim uname As String

        Dim net As New Net.NetworkInformation.Ping

        Select Case net.Send(ipSRV1, 20).Status

            Case System.Net.NetworkInformation.IPStatus.Success

                uname = LNGIniFile.GetString("General", "OPCA", "opcda://192.168.6.11/SV.OPCDAServer.1")

                If Len(uname) = 0 Then

                    m_url = New Global.Opc.URL("opcda://192.168.6.11/SV.OPCDAServer.1")

                Else

                    m_url = New Global.Opc.URL(uname)

                End If

            Case Else

                Select Case net.Send(ipSRV2, 20).Status

                    Case System.Net.NetworkInformation.IPStatus.Success

                        uname = LNGIniFile.GetString("General", "OPCR", "opcda://192.168.6.12/SV.OPCDAServer.1")

                        If Len(uname) = 0 Then

                            m_url = New Global.Opc.URL("opcda://192.168.6.12/SV.OPCDAServer.1")

                        Else

                            m_url = New Global.Opc.URL(uname)

                        End If

                    Case Else

                        MsgBox("Не найдено ни одного работающего сервера," & vbNewLine & "обратитесь к системному администратору", MsgBoxStyle.Exclamation, Application.ProductName)

                End Select

        End Select
        'Select Case My.Computer.Network.Ping(.Fields("IPDev").Value)


        Select Case ToolStripStatusLabel3.Text

            Case "---"

                m_server = New Global.Opc.Da.Server(fact, Nothing)
                m_server.Connect(m_url, New Opc.ConnectData(New System.Net.NetworkCredential()))
                m_serverStatus = m_server.GetStatus
                ToolStripStatusLabel1.Text = "Статус сервера: " & m_serverStatus.StatusInfo
                ToolStripStatusLabel3.Text = m_server.Name


                'Проверяем активный сервер
                Call T_STATUS_SERV_START()


                Select Case SRV1
                    'подключаемся к активному серверу

                    Case True
                        m_server.Disconnect()
                        ToolStripStatusLabel1.Text = "Статус сервера: ---"
                        ToolStripStatusLabel3.Text = "---"
                        m_url = New Global.Opc.URL(LNGIniFile.GetString("General", "OPCA", "opcda://192.168.6.11/SV.OPCDAServer"))

                        m_server = New Global.Opc.Da.Server(fact, Nothing)
                        m_server.Connect(m_url, New Opc.ConnectData(New System.Net.NetworkCredential()))
                        m_serverStatus = m_server.GetStatus
                        ToolStripStatusLabel1.Text = "Статус сервера: " & m_serverStatus.StatusInfo
                        ToolStripStatusLabel3.Text = m_server.Name

                    Case False
                        m_server.Disconnect()
                        ToolStripStatusLabel1.Text = "Статус сервера: ---"
                        ToolStripStatusLabel3.Text = "---"
                        m_url = New Global.Opc.URL(LNGIniFile.GetString("General", "OPCR", "opcda://192.168.6.12/SV.OPCDAServer"))

                        m_server = New Global.Opc.Da.Server(fact, Nothing)
                        m_server.Connect(m_url, New Opc.ConnectData(New System.Net.NetworkCredential()))
                        m_serverStatus = m_server.GetStatus
                        ToolStripStatusLabel1.Text = "Статус сервера: " & m_serverStatus.StatusInfo
                        ToolStripStatusLabel3.Text = m_server.Name

                End Select

            Case Else

        End Select

        Exit Sub

err_:
        MsgBox(Err.Description)
        ' m_url = New Global.Opc.URL(LNGIniFile.GetString("General", "OPCR", "opcda://192.168.6.12/SV.OPCDAServer"))
        '  Call LOAD_SERVER()
    End Sub

    'Private Sub frmAlarmOpen()
    '    'Проверка не закрыта ли форма с аварийными сигналами.
    '    'Если закрыта то открывается снова.

    '    Dim intj As Integer = 0
    '    Try
    '        Do
    '            intj = 0

    '            For i = System.Windows.Forms.Application.OpenForms.Count - 1 To 1 Step -1
    '                Dim form As Form = System.Windows.Forms.Application.OpenForms(i)

    '                If form.Name = "frmALARM" Then

    '                    Me.Invoke(Sub() intj = 1)

    '                End If

    '            Next i

    '            If intj = 0 Then
    '                Me.Invoke(Sub() frmALARM.MdiParent = Me)
    '                Me.Invoke(Sub() frmALARM.Show())
    '            Else

    '            End If

    '            Threading.Thread.Sleep(5000)
    '        Loop

    '    Catch ex As Exception

    '        ' Me.Invoke(Sub() Me.Close())

    '    End Try

    'End Sub

    Public Sub UNLOAD_SERVER()

        Select Case ToolStripStatusLabel3.Text

            Case "---"

            Case Else

                m_server.Disconnect()
                ToolStripStatusLabel1.Text = "Статус сервера: ---"
                ToolStripStatusLabel3.Text = "---"
                ' ToolStripStatusLabel5.Text = "---"

        End Select

    End Sub

    Private Sub frmIndexer_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Call UNLOAD_SERVER()
        Call UNLOADDATABASE()

        Select Case tmpALARM
            Case False
                T_ALARM.Resume()
                T_ALARM.Abort()
            Case True
                T_ALARM.Abort()
        End Select

        ' T_FRMALARM.Abort()

        End

    End Sub

    'Private sASTUE_OPER As Boolean = False
    'Private sKTP_EB As Boolean = False
    'Private sRP10 As Boolean = False
    'Private sRP10S1 As Boolean = False
    'Private sRP10S2 As Boolean = False
    'Private sSAUT As Boolean = False
    'Private sSAUV As Boolean = False
    'Private sStatus As Boolean = False
    'Private sTrends As Boolean = False

    'Private Sub CloseForms()

    '    For Each form As Form In My.Application.OpenForms

    '        If Not InvokeRequired Then

    '            Select Case form.Name

    '                Case "frmASTUE_OPER"
    '                    sASTUE_OPER = True
    '                Case "frmKTP_EB"
    '                    sKTP_EB = True
    '                Case "frmRP10"
    '                    sRP10 = True
    '                Case "frmRP10S1"
    '                    sRP10S1 = True
    '                Case "frmRP10S2"
    '                    sRP10S2 = True
    '                Case "frmSAUT"
    '                    sSAUT = True
    '                Case "frmSauV"
    '                    sSAUV = True
    '                Case "frmStatus"
    '                    sStatus = True
    '            End Select

    '        End If

    '    Next



    '    Try

    '        For i = System.Windows.Forms.Application.OpenForms.Count - 1 To 1 Step -1
    '            Dim form As Form = System.Windows.Forms.Application.OpenForms(i)

    '            If Not InvokeRequired Then
    '                If form.Name <> "frmIndexer" Then form.Close()
    '            End If
    '        Next i

    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Private Sub OPen_Forms()

    '    If sASTUE_OPER = True Then
    '        frmASTUE_OPER.MdiParent = Me
    '        frmASTUE_OPER.Show()
    '        frmASTUE_OPER.Focus()
    '    End If

    '    If sKTP_EB = True Then
    '        frmKTP_EB.MdiParent = Me
    '        frmKTP_EB.Show()
    '        frmKTP_EB.Focus()
    '    End If

    '    If sRP10 = True Then
    '        frmRP10.MdiParent = Me
    '        frmRP10.Show()
    '        frmRP10.Focus()
    '    End If

    '    If sRP10S1 = True Then
    '        frmRP10S1.MdiParent = Me
    '        frmRP10S1.Show()
    '        frmRP10S1.Focus()
    '    End If

    '    If sRP10S2 = True Then
    '        frmRP10S2.MdiParent = Me
    '        frmRP10S2.Show()
    '        frmRP10S2.Focus()
    '    End If


    '    If sSAUT = True Then
    '        Me.Invoke(Sub() frmSAUT.MdiParent = Me)
    '        Me.Invoke(Sub() frmSAUT.Show())
    '        Me.Invoke(Sub() frmSAUT.Focus())
    '    End If

    '    If sSAUV = True Then
    '        frmSauV.MdiParent = Me
    '        frmSauV.Show()
    '        frmSauV.Focus()
    '    End If

    '    If sStatus = True Then
    '        frmStatus.MdiParent = Me
    '        frmStatus.Show()
    '        frmStatus.Focus()
    '    End If

    '    sASTUE_OPER = False
    '    sKTP_EB = False
    '    sRP10 = False
    '    sRP10S1 = False
    '    sRP10S2 = False
    '    sSAUT = False
    '    sSAUV = False
    '    sStatus = False
    '    sTrends = False

    'End Sub

    Sub T_STATUS_SERV_START()

        Dim net As New Net.NetworkInformation.Ping
        Dim LNGIniFile As New IniFile(PrPath & "config.ini")

                Try

                    groupStateSTATUS.Name = "SERVER"
                    groupStateSTATUS.Active = True
            groupStateSTATUS.UpdateRate = MSPEED

                    groupSTATUS = DirectCast(m_server.CreateSubscription(groupStateSTATUS), Opc.Da.Subscription)

                    Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(1) {}

                    items(0) = New Global.Opc.Da.Item()
                    items(0).ItemName = "ДИАГН.СЕРВ1.ACT_SRV1"

                    items(1) = New Global.Opc.Da.Item()
                    items(1).ItemName = "ДИАГН.СЕРВ2.ACT_SRV2"

                    '  Do
                    Dim results As ItemValueResult() = Nothing
                    results = groupSTATUS.Read(items)
                    For Each item As Item In items
                        item.ClientHandle = item.ItemName
                    Next

                    results = m_server.Read(items)

                    For i As Integer = 0 To results.Length - 1

                        Select Case results(0).Value

                            Case True
                                SRV1 = True

                            Case False
                                SRV1 = False
                        End Select

                        Select Case results(1).Value

                            Case True
                                SRV2 = True
                            Case False
                                SRV2 = False
                        End Select


            Next

            'Threading.Thread.Sleep(MSPEED)

                    '  Loop

                Catch ex As Exception



                End Try

    End Sub

    Private Sub frmIndexer_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Call LOADDATABASE_ASUE()
        Call LOADDATABASE_ASKUER()
        Call LOAD_DATABASE_ACCESS_ALERT()

        Call LOAD_SERVER()

        ' T_FRMALARM = New System.Threading.Thread(AddressOf frmAlarmOpen)
        ' T_FRMALARM.Start()

        ' frmALARM.MdiParent = Me
        '  frmALARM.Show()

        Application.DoEvents()

        Select Case sTartI

            Case "Контроль системы"

                frmStatus.MdiParent = Me
                frmStatus.Show()
                frmStatus.Focus()

            Case "САУ-В"

                frmSauV.MdiParent = Me
                frmSauV.Show()
                frmSauV.Focus()

            Case "САУ-Т"

                frmSAUT.MdiParent = Me
                frmSAUT.Show()
                frmSAUT.Focus()

            Case "РП-10кВ"

                frmRP10.MdiParent = Me
                frmRP10.Show()
                frmRP10.Focus()

            Case "КТП ЭБ"

                frmKTP_EB.MdiParent = Me
                frmKTP_EB.Show()
                frmKTP_EB.Focus()

            Case "КТП РЭБ"

                frmKTP_REB.MdiParent = Me
                frmKTP_REB.Show()
                frmKTP_REB.Focus()


            Case "КТП АВО"

                frmKTP_AVO.MdiParent = Me
                frmKTP_AVO.Show()
                frmKTP_AVO.Focus()

            Case "ОЩСУ"

                frmOHCU.MdiParent = Me
                frmOHCU.Show()
                frmOHCU.Focus()

            Case "ЩГП"

                frm_CHGP.MdiParent = Me
                frm_CHGP.Show()
                frm_CHGP.Focus()

            Case "ЩПТ"

                frmChpt.MdiParent = Me
                frmChpt.Show()
                frmChpt.Focus()

            Case "Водозабор"

                frmVodozabor.MdiParent = Me
                frmVodozabor.Show()
                frmVodozabor.Focus()


        End Select

        ' Me.WindowState = FormWindowState.Maximized
        ' Me.WindowState = FormWindowState.Normal

        Select Case tmpALARM

            Case False

                lblAlarm.Text = "Звуковая сигнализация выключена"
                lblAlarm.ForeColor = Color.Red

                T_ALARM = New System.Threading.Thread(AddressOf T_ALARM_START)
                T_ALARM.Start()
                T_ALARM.Suspend()

            Case True

                lblAlarm.Text = "Звуковая сигнализация включена"
                lblAlarm.ForeColor = Color.Green

                T_ALARM = New System.Threading.Thread(AddressOf T_ALARM_START)
                T_ALARM.Start()

        End Select


        ' T_H1 = New System.Threading.Thread(AddressOf T_H)
        'T_H1.Start()

    End Sub

    'Private Sub T_H()
    '    'Бегущая строка, зачем не знаю, что бы была...

    '    Dim a As String = "АСУЭ Оперативные данные для участка ЭТВС КС 01 Лукояновская - OPC клиент системы АСУЭ" : Static st As Integer = 1
    '    Dim b As String
    '    Try

    '        Do

    '            Me.Invoke(Sub() Me.Text = a.Substring(0, st))
    '            b = a.Substring(0, st)
    '            st += 1
    '            If st = a.Length + 1 Then
    '                st = 0
    '            End If
    '            If b = a Then
    '                Me.Invoke(Sub() Me.Text = "")
    '            End If

    '            Threading.Thread.Sleep(300)
    '        Loop

    '    Catch ex As Exception

    '    End Try

    'End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click

        frmSauV.MdiParent = Me
        frmSauV.Show()
        frmSauV.Focus()

    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click

        frmSAUT.MdiParent = Me
        frmSAUT.Show()
        frmSAUT.Focus()

    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        frmASTUER.MdiParent = Me
        frmASTUER.Show()
        frmASTUER.Focus()
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click

        frmJournal.MdiParent = Me
        frmJournal.Show()
        frmJournal.Focus()
        'frmJournal
    End Sub

    Private Sub ToolStripButton7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton7.Click
        frmInterval.MdiParent = Me
        frmInterval.Show()
        frmInterval.Focus()
    End Sub

    Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
        'frmTrends
        frmTrends.MdiParent = Me
        frmTrends.Show()
        frmTrends.Focus()
    End Sub

    Private Sub НастройкиToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles НастройкиToolStripMenuItem.Click
        frmSetup.MdiParent = Me
        frmSetup.Show()
        frmSetup.Focus()
    End Sub

    Private Sub ToolStripButton5_ButtonClick(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.ButtonClick
        frmRP10.MdiParent = Me
        frmRP10.Show()
        frmRP10.Focus()
    End Sub

    Private Sub Секция1ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Секция1ToolStripMenuItem.Click
        frmRP10S1.MdiParent = Me
        frmRP10S1.Show()
        frmRP10S1.Focus()
    End Sub

    Private Sub Секция2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Секция2ToolStripMenuItem.Click
        frmRP10S2.MdiParent = Me
        frmRP10S2.Show()
        frmRP10S2.Focus()
    End Sub

    Private Sub КТПЭБToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles КТПЭБToolStripMenuItem.Click

        frmKTP_EB.MdiParent = Me
        frmKTP_EB.Show()
        frmKTP_EB.Focus()

    End Sub

    Private Sub ToolStripSplitButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripSplitButton1.Click
        frmASTUE_OPER.MdiParent = Me
        frmASTUE_OPER.Show()
        frmASTUE_OPER.Focus()
    End Sub

    Private Sub ToolStripButton8_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton8.Click
        frmASKUE.MdiParent = Me
        frmASKUE.Show()
        frmASKUE.Focus()
    End Sub

    Private Sub КТПАВОToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles КТПАВОToolStripMenuItem.Click
        frmKTP_AVO.MdiParent = Me
        frmKTP_AVO.Show()
        frmKTP_AVO.Focus()
    End Sub

    Private Sub ОПрограммеToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ОПрограммеToolStripMenuItem.Click
        frmAbout.ShowDialog(Me)
    End Sub

    Private Sub ТемператураToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ТемператураToolStripMenuItem.Click
        frmThemperature.Show()
    End Sub

    Private Sub ToolStripButton9_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton9.Click
        frmSAUKOS.MdiParent = Me
        frmSAUKOS.Show()
        frmSAUKOS.Focus()
    End Sub

    Private Sub ToolStripButton10_Click(sender As System.Object, e As System.EventArgs) Handles btnAlarm.Click
        frmStatus.MdiParent = Me
        frmStatus.Show()
        frmStatus.Focus()
    End Sub

    Private Sub ОЩСУToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ОЩСУToolStripMenuItem.Click
        'frmOHCU
        frmOHCU.MdiParent = Me
        frmOHCU.Show()
        frmOHCU.Focus()
    End Sub

    Private Sub ЩГПЭБToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ЩГПЭБToolStripMenuItem.Click
        'frm_CHGP
        frm_CHGP.MdiParent = Me
        frm_CHGP.Show()
        frm_CHGP.Focus()
    End Sub

    Private Sub ЩГПРЭБToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ЩГПРЭБToolStripMenuItem.Click
        frm_CHGP.MdiParent = Me
        frm_CHGP.Show()
        frm_CHGP.Focus()
    End Sub

    Private Sub СостояниеСистемыToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles СостояниеСистемыToolStripMenuItem.Click
        frmStatus.MdiParent = Me
        frmStatus.Show()
        frmStatus.Focus()
    End Sub

    Private Sub ToolStripButton10_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripButton10.Click
        frmKTP_REB.MdiParent = Me
        frmKTP_REB.Show()
        frmKTP_REB.Focus()
    End Sub

    Private Sub БТПToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles БТПToolStripMenuItem.Click

        frm2BTP.MdiParent = Me
        frm2BTP.Show()
        frm2BTP.Focus()

    End Sub

    Private Sub ЩПТ220ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ЩПТ220ToolStripMenuItem.Click
        'frmChpt

        frmChpt.MdiParent = Me
        frmChpt.Show()
        frmChpt.Focus()

    End Sub

    Private Sub ToolStripButton11_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton11.Click
        frmChpt.MdiParent = Me
        frmChpt.Show()
        frmChpt.Focus()
    End Sub

    Private Sub ToolStripButton12_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton12.Click
        frmVodozabor.MdiParent = Me
        frmVodozabor.Show()
        frmVodozabor.Focus()
    End Sub

    Private Sub ПомощьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ПомощьToolStripMenuItem.Click
        frmTMP.Show()
        frmTMP.Focus()
    End Sub
End Class
