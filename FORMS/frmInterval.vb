Public Class frmInterval

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor

        On Error GoTo err_

        lvASUE.Sorting = SortOrder.None
        lvASUE.ListViewItemSorter = Nothing

        lvASUE.Items.Clear()

        If Len(ComboBox1.Text) = 0 Then
            MsgBox("Не заданы параметры", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        lvASUE.Columns.Clear()
        lvASUE.Columns.Add("Период", 150, HorizontalAlignment.Left)
        lvASUE.Columns.Add(ComboBox1.Text, 300, HorizontalAlignment.Left)
        ' lvASUE.Columns.Add(ComboBox2.Text, 300, HorizontalAlignment.Left)

        Dim stmpInt As Integer

        Select Case ComboBox4.Text

            Case "Абсолютные значения"
                stmpInt = 0
            Case "Разница между последним и предпоследним значением"
                stmpInt = 1
        End Select

        Dim D1, d2 As String
        D1 = DateTimePicker1.Value.Year & "-" & DateTimePicker1.Value.Month & "-" & DateTimePicker1.Value.Day & " 00:00:00"
        d2 = DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-" & DateTimePicker2.Value.Day & " 00:00:00"

        Dim sSQL As String '= "Select t1.period as period,t1.value as value1,t2.value as value2 from dbo.fn_RepTable(CONVERT(datetime, '" & D1 & "',20),CONVERT(datetime, '" & d2 & "',20),1800, '" & ComboBox1.Text & "',0) t1,dbo.fn_RepTable(CONVERT(datetime, '" & D1 & "',20),CONVERT(datetime, '" & d2 & "',20),1800, '" & ComboBox2.Text & "',0) t2 where t1.period = t2.period"
        sSQL = "Select t1.period as period,t1.value as value1 from dbo.fn_RepTable(CONVERT(datetime, '" & D1 & "',20),CONVERT(datetime, '" & d2 & "',20)," & NumericUpDown1.Value * 60 & ", '" & ComboBox1.Text & "'," & stmpInt & ") t1 "

        Dim intCount As Decimal = 0
        Dim cmd As OleDbCommand
        Dim rs As OleDbDataReader

        cmd = New OleDbCommand(sSQL, DBASUE)
        rs = cmd.ExecuteReader

        While rs.Read
            lvASUE.Items.Add(rs.Item("period"))
            lvASUE.Items(CInt(intCount)).SubItems.Add(rs.Item("value1"))
            'lvASUE.Items(CInt(intCount)).SubItems.Add(rs.Item("value2"))
            intCount = intCount + 1
        End While
        rs.Close()
        rs = Nothing

        ResList(lvASUE)

        Me.Cursor = Cursors.Default
        Exit Sub
err_:
        MsgBox(Err.Description, MsgBoxStyle.Critical, Me.Text)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frmInterval_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        lvASUE.Columns.Add("Период", 100, HorizontalAlignment.Left)
        lvASUE.Columns.Add("Ввод 1", 500, HorizontalAlignment.Left)
        lvASUE.Columns.Add("Ввод2", 500, HorizontalAlignment.Left)

        FillComboNET(ComboBox1, "Name", "Trends", "", False, True)


        Call MIN_CHRONO_TRD()

        DateTimePicker2.Value = Date.Today

        DateTimePicker1.Value = DateTimePicker2.Value.AddDays(-2)
        DateTimePicker1.MinDate = stmpDATE_MIN
        DateTimePicker2.MinDate = stmpDATE_MIN

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim sTXT As String = "Данные с " & DateTimePicker1.Value & " по " & DateTimePicker2.Value & vbNewLine & "параметры " & ComboBox1.Text '& " и " & ComboBox2.Text

        ExportListViewToExcel(lvASUE, sTXT)
    End Sub

    Private Sub lvASUE_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles lvASUE.ColumnClick
        SORTING_LV(lvASUE, e)
    End Sub


    Private Sub frmInterval_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Call FONT_SIZE(Me)
    End Sub
End Class