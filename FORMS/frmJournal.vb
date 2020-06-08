Public Class frmJournal
    Delegate Sub InvokeDelegate()
    Private m_SortingColumn As ColumnHeader

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.BeginInvoke(New MethodInvoker(AddressOf LOAD_JOURNAL))
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        LV_REPORT.BeginInvoke(New InvokeDelegate(AddressOf LOAD_ARHIV))
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim sTXT As String = "Журнал архивных событий АСУЭ"

        ExportListViewToExcel(LV_REPORT, sTXT)
    End Sub

    Public Sub LOAD_JOURNAL()

        Cursor = Cursors.WaitCursor

        LV_REPORT.Sorting = SortOrder.None
        LV_REPORT.ListViewItemSorter = Nothing
        LV_REPORT.Items.Clear()

        Dim sSQL As String
        Dim cmd As OleDbCommand
        Dim rs As OleDbDataReader

        sSQL = "SELECT count(*) as t_n FROM dbo.[vw_ShowLogNormal]"

        cmd = New OleDbCommand(sSQL, DBASUE)
        rs = cmd.ExecuteReader

        Dim sCOUNT As Integer

        While rs.Read

            sCOUNT = rs.Item("t_n")

        End While

        rs.Close()
        rs = Nothing

        If sCOUNT = 0 Then Exit Sub

        sSQL = "SELECT TOP 4000 [Дата] as D_T,[Заголовок] as TextAttr03 , [Статус] as Description, [Событие] as EvtTitle FROM dbo.[vw_ShowLogNormal] ORDER BY [Дата] DESC"

        cmd = New OleDbCommand(sSQL, DBASUE)
        rs = cmd.ExecuteReader

        '  [Дата]()
        ',[Событие]
        ',[Статус]
        ',[Уровень]
        ',[Заголовок]


        Dim intCount As Decimal = 0

        While rs.Read

            LV_REPORT.Items.Add(rs.Item("D_T"))

            If Not IsDBNull(rs.Item("EvtTitle")) Then
                LV_REPORT.Items(CInt(intCount)).SubItems.Add(rs.Item("EvtTitle"))
            Else
                LV_REPORT.Items(CInt(intCount)).SubItems.Add("")
            End If
            If Not IsDBNull(rs.Item("Description")) Then
                LV_REPORT.Items(CInt(intCount)).SubItems.Add(rs.Item("Description"))
            Else
                LV_REPORT.Items(CInt(intCount)).SubItems.Add("")
            End If
            If Not IsDBNull(rs.Item("TextAttr03")) Then
                LV_REPORT.Items(CInt(intCount)).SubItems.Add(rs.Item("TextAttr03"))
            Else
                LV_REPORT.Items(CInt(intCount)).SubItems.Add("")
            End If

            intCount = intCount + 1

        End While

        rs.Close()
        rs = Nothing

        ResList(LV_REPORT)

        Cursor = Cursors.Default

    End Sub

    Public Sub LOAD_ARHIV()
        Cursor = Cursors.WaitCursor

        LV_REPORT.Sorting = SortOrder.None
        LV_REPORT.ListViewItemSorter = Nothing
        LV_REPORT.Items.Clear()

        'If Len(ComboBox2.Text) = 0 Then
        '    MsgBox("Не заданы параметры", MsgBoxStyle.Information,Text)
        '    Exit Sub
        'End If

        Dim D1, d2 As String
        D1 = DateTime.Now.Year & "-" & DateTime.Today.Day & "-" & Date.Now.Month & " 00:00:00"
        d2 = DateTime.Now.Year & "-" & DateTime.Now.Day & "-" & DateTime.Now.Month & " " & DateTime.Now.Hour & ":" & DateTime.Now.Minute & ":" & DateTime.Now.Second

        Dim sSQL As String

        Dim cmd As OleDbCommand
        Dim rs As OleDbDataReader

        If Len(ComboBox2.Text) = 0 Then

            sSQL = "SELECT count(*) as t_n FROM dbo.[vw_ShowLogNormal] Where [Дата] BETWEEN '" & D1 & "' AND '" & d2 & "'"

        Else

            sSQL = "SELECT count(*) as t_n FROM dbo.[vw_ShowLogNormal] Where [Дата] BETWEEN '" & D1 & "' AND '" & d2 & "' AND [Событие] ='" & ComboBox2.Text & "'"

        End If

        cmd = New OleDbCommand(sSQL, DBASUE)
        rs = cmd.ExecuteReader
        Dim sCOUNT As Integer

        While rs.Read

            sCOUNT = rs.Item("t_n")

        End While

        rs.Close()
        rs = Nothing

        If sCOUNT = 0 Then
            MsgBox("Данные по заданным параметрам не обнаружены", MsgBoxStyle.Information, Text)
            Cursor = Cursors.Default
            Exit Sub
        End If

        '  [Дата]()
        ',[Событие]
        ',[Статус]
        ',[Уровень]
        ',[Заголовок]

        If Len(ComboBox2.Text) = 0 Then

            If sCOUNT > 10000 Then

                sCOUNT = sCOUNT / 10

                sSQL = "SELECT TOP " & sCOUNT & " [Дата] as D_T,[Заголовок] as TextAttr03 , [Статус] as Description, [Событие] as EvtTitle FROM dbo.[vw_ShowLogNormal] Where [Дата] BETWEEN '" & D1 & "' AND '" & d2 & "' ORDER BY [Дата] DESC"

            Else

                sSQL = "SELECT [Дата] as D_T,[Заголовок] as TextAttr03 , [Статус] as Description, [Событие] as EvtTitle FROM dbo.[vw_ShowLogNormal] Where [Дата] BETWEEN '" & D1 & "' AND '" & d2 & "' ORDER BY [Дата] DESC"

            End If

        Else

            sSQL = "SELECT [Дата] as D_T,[Заголовок] as TextAttr03 , [Статус] as Description, [Событие] as EvtTitle FROM dbo.[vw_ShowLogNormal] Where [Дата] BETWEEN '" & D1 & "' AND '" & d2 & "' AND [Событие] ='" & ComboBox2.Text & "' ORDER BY [Дата] DESC"

        End If

        cmd = New OleDbCommand(sSQL, DBASUE)
        rs = cmd.ExecuteReader

        Dim intCount As Decimal = 0

        While rs.Read

            LV_REPORT.Items.Add(rs.Item("D_T"))

            If Not IsDBNull(rs.Item("EvtTitle")) Then
                LV_REPORT.Items(CInt(intCount)).SubItems.Add(rs.Item("EvtTitle"))
            Else
                LV_REPORT.Items(CInt(intCount)).SubItems.Add("")
            End If
            If Not IsDBNull(rs.Item("Description")) Then
                LV_REPORT.Items(CInt(intCount)).SubItems.Add(rs.Item("Description"))
            Else
                LV_REPORT.Items(CInt(intCount)).SubItems.Add("")
            End If
            If Not IsDBNull(rs.Item("TextAttr03")) Then
                LV_REPORT.Items(CInt(intCount)).SubItems.Add(rs.Item("TextAttr03"))
            Else
                LV_REPORT.Items(CInt(intCount)).SubItems.Add("")
            End If

            intCount = intCount + 1

        End While

        rs.Close()
        rs = Nothing

        ResList(LV_REPORT)

        Cursor = Cursors.Default

    End Sub

    Private Sub frmJournal_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Call MIN_CHRONO_LOG()

        DTP_R_K.Value = Date.Today
        DTP_R_N.Value = DTP_R_K.Value.AddDays(-1)
        DTP_R_N.MinDate = stmpDATE_MIN
        DTP_R_K.MinDate = stmpDATE_MIN


        Dim cmd As OleDbCommand
        Dim rs As OleDbDataReader

        cmd = New OleDbCommand("SELECT Событие FROM [dbo].[vw_ShowLogNormal] GROUP BY Событие", DBASUE)
        rs = cmd.ExecuteReader

        While rs.Read

            ComboBox2.Items.Add(rs.Item("Событие"))

        End While
        rs.Close()
        rs = Nothing


        LV_REPORT.Columns.Add("Дата\Время", 150, HorizontalAlignment.Left)
        LV_REPORT.Columns.Add("Событие", 300, HorizontalAlignment.Left)
        LV_REPORT.Columns.Add("Описание", 300, HorizontalAlignment.Left)
        LV_REPORT.Columns.Add("Наименование", 300, HorizontalAlignment.Left)


        Me.BeginInvoke(New MethodInvoker(AddressOf LOAD_DATA_START))


    End Sub

    Private Sub LOAD_DATA_START()

        Cursor = Cursors.WaitCursor

        LV_REPORT.Sorting = SortOrder.None
        LV_REPORT.ListViewItemSorter = Nothing
        LV_REPORT.Items.Clear()

        'If Len(ComboBox2.Text) = 0 Then
        '    MsgBox("Не заданы параметры", MsgBoxStyle.Information,Text)
        '    Exit Sub
        'End If

        Dim D1, d2 As String
        D1 = DateTime.Now.Year & "-" & DateTime.Today.Day & "-" & Date.Now.Month & " 00:00:00"
        d2 = DateTime.Now.Year & "-" & DateTime.Now.Day & "-" & DateTime.Now.Month & " " & DateTime.Now.Hour & ":" & DateTime.Now.Minute & ":" & DateTime.Now.Second

        Dim sSQL As String

        Dim cmd As OleDbCommand
        Dim rs As OleDbDataReader
        ' [Дата] as D_T,[Заголовок] as TextAttr03 , [Статус] as Description, [Событие] as EvtTitle FROM dbo.[vw_ShowLogNormal]

        sSQL = "SELECT count(*) as t_n FROM dbo.[vw_ShowLogNormal] Where [Дата] BETWEEN '" & D1 & "' AND '" & d2 & "'"

        cmd = New OleDbCommand(sSQL, DBASUE)
        rs = cmd.ExecuteReader
        Dim sCOUNT As Integer

        While rs.Read

            sCOUNT = rs.Item("t_n")

        End While

        rs.Close()
        rs = Nothing

        If sCOUNT = 0 Then
            MsgBox("Данные по заданным параметрам не обнаружены", MsgBoxStyle.Information, Text)
            Cursor = Cursors.Default
            Exit Sub
        End If


        sSQL = "SELECT [Дата] as D_T,[Заголовок] as TextAttr03 , [Статус] as Description, [Событие] as EvtTitle FROM dbo.[vw_ShowLogNormal] Where [Дата] BETWEEN '" & D1 & "' AND '" & d2 & "' ORDER BY [Дата] DESC"

        cmd = New OleDbCommand(sSQL, DBASUE)
        rs = cmd.ExecuteReader

        Dim intCount As Decimal = 0

        While rs.Read

            LV_REPORT.Items.Add(rs.Item("D_T"))

            If Not IsDBNull(rs.Item("EvtTitle")) Then
                LV_REPORT.Items(CInt(intCount)).SubItems.Add(rs.Item("EvtTitle"))
            Else
                LV_REPORT.Items(CInt(intCount)).SubItems.Add("")
            End If
            If Not IsDBNull(rs.Item("Description")) Then
                LV_REPORT.Items(CInt(intCount)).SubItems.Add(rs.Item("Description"))
            Else
                LV_REPORT.Items(CInt(intCount)).SubItems.Add("")
            End If
            If Not IsDBNull(rs.Item("TextAttr03")) Then
                LV_REPORT.Items(CInt(intCount)).SubItems.Add(rs.Item("TextAttr03"))
            Else
                LV_REPORT.Items(CInt(intCount)).SubItems.Add("")
            End If

            intCount = intCount + 1

        End While

        rs.Close()
        rs = Nothing

        ResList(LV_REPORT)

        Cursor = Cursors.Default


    End Sub

    Public Sub MIN_CHRONO_LOG()
        On Error GoTo err_

        Dim sSQL As String

        ' [Дата] as D_T,[Заголовок] as TextAttr03 , [Статус] as Description, [Событие] as EvtTitle FROM dbo.[vw_ShowLogNormal]

        sSQL = "SELECT TOP 1 max(Chrono) as f_s, min(Chrono) as f_d FROM dbo.[LOG]"

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

        sSQL = "SELECT TOP 1 dbo.fn_ChronoToDateTime('" & sMax & "') as f_s, dbo.fn_ChronoToDateTime('" & sMin & "') as f_d FROM dbo.[LOG]"

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
        sMin = Date.Today.AddDays(-3)
        stmpDATE_MIN = sMin
    End Sub

    Private Sub LV_REPORT_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles LV_REPORT.ColumnClick

        SORTING_LV(LV_REPORT, e)

    End Sub

    Private Sub frmJournal_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Call FONT_SIZE(Me)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.BeginInvoke(New MethodInvoker(AddressOf LOAD_DATA_START))
    End Sub
End Class