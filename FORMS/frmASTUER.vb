Public Class frmASTUER
    Private ProfileId As Integer = 0
    Private interval As Integer = 60

    'Private Sub SpliterButton1_ClickItem(seder As Object, e As System.EventArgs) Handles SpliterButton1.ClickItem
    '    ProfileId = 14
    '    interval = 60

    '    Select Case SpliterButton1.Text

    '        Case "САУ КОС"

    '            If Len(cmbKOS.Text) = 0 Then Exit Sub
    '            '  gbKos.Text = "САУ КОС"
    '            Call LOAD_ASKUER_WITH_PARAM(303)

    '        Case "АртСкважина № 1"
    '            If Len(cmbKOS.Text) = 0 Then Exit Sub
    '            ' gbKos.Text = "АртСкважина № 1"
    '            Call LOAD_ASKUER_WITH_PARAM(295)
    '        Case "АртСкважина № 2"
    '            If Len(cmbKOS.Text) = 0 Then Exit Sub
    '            '  gbKos.Text = "АртСкважина № 2"
    '            Call LOAD_ASKUER_WITH_PARAM(296)
    '        Case "Насосная станция II подъёма"
    '            If Len(cmbKOS.Text) = 0 Then Exit Sub
    '            ' gbKos.Text = "Насосная Станция II Подъёма"
    '            Call LOAD_ASKUER_WITH_PARAM(294)
    '        Case "Подпитка тепловая сеть"
    '            If Len(cmbKOS.Text) = 0 Then Exit Sub
    '            '  gbKos.Text = "Подпитка Тепловая Сеть"
    '            Call LOAD_ASKUER_WITH_PARAM(318)
    '        Case "РЭБ - Расхдмер ЭРСВ-510Л"
    '            If Len(cmbKOS.Text) = 0 Then Exit Sub
    '            '  gbKos.Text = "РЭБ - Расхдмер ЭРСВ-510Л"
    '            Call LOAD_ASKUER_WITH_PARAM(283)
    '        Case "Энергоблок РСЛ-212"
    '            If Len(cmbKOS.Text) = 0 Then Exit Sub
    '            '   gbKos.Text = "Энергоблок РСЛ-212"
    '            Call LOAD_ASKUER_WITH_PARAM(306)

    '        Case "ГПА№1 Ввод 1"
    '            If Len(cmbKOS.Text) = 0 Then Exit Sub

    '            ProfileId = 1
    '            interval = 30
    '            Call LOAD_ASKUER_WITH_PARAM(247)

    '        Case "ГПА№1 Ввод 2"
    '            If Len(cmbKOS.Text) = 0 Then Exit Sub

    '            ProfileId = 1
    '            interval = 30
    '            Call LOAD_ASKUER_WITH_PARAM(255)
    '        Case "ГПА№2 Ввод 1"
    '            If Len(cmbKOS.Text) = 0 Then Exit Sub

    '            ProfileId = 1
    '            interval = 30
    '            Call LOAD_ASKUER_WITH_PARAM(251)
    '        Case "ГПА№2 Ввод 2"
    '            If Len(cmbKOS.Text) = 0 Then Exit Sub

    '            ProfileId = 1
    '            interval = 30
    '            Call LOAD_ASKUER_WITH_PARAM(256)
    '        Case "ГПА№3 Ввод 1"
    '            If Len(cmbKOS.Text) = 0 Then Exit Sub

    '            ProfileId = 1
    '            interval = 30
    '            Call LOAD_ASKUER_WITH_PARAM(252)
    '        Case "ГПА№3 Ввод 2"
    '            If Len(cmbKOS.Text) = 0 Then Exit Sub

    '            ProfileId = 1
    '            interval = 30
    '            Call LOAD_ASKUER_WITH_PARAM(257)
    '        Case "ГПА№4 Ввод 1"
    '            If Len(cmbKOS.Text) = 0 Then Exit Sub

    '            ProfileId = 1
    '            interval = 30
    '            Call LOAD_ASKUER_WITH_PARAM(258)
    '        Case "ГПА№4 Ввод 2"
    '            If Len(cmbKOS.Text) = 0 Then Exit Sub

    '            ProfileId = 1
    '            interval = 30
    '            Call LOAD_ASKUER_WITH_PARAM(253)
    '        Case "ГПА№5 Ввод 1"
    '            If Len(cmbKOS.Text) = 0 Then Exit Sub

    '            ProfileId = 1
    '            interval = 30
    '            Call LOAD_ASKUER_WITH_PARAM(259)
    '        Case "ГПА№5 Ввод 2"
    '            If Len(cmbKOS.Text) = 0 Then Exit Sub

    '            ProfileId = 1
    '            interval = 30
    '            Call LOAD_ASKUER_WITH_PARAM(254)

    '    End Select
    'End Sub

    Public Sub LOAD_ASKUER_WITH_PARAM(ByVal sPar As Integer)

        lvKos.Items.Clear()

        ' Dim DB9 As OleDbConnection
        ' DB9 = New OleDbConnection("Provider=SQLOLEDB;Data Source=192.168.6.13\HDSEMCS; initial Catalog=TI2_Lukoyanovskaya; User id=sa; Password=abc;")
        'DB9.Open()

        Dim D1, d2 As String
        D1 = dtKOS_N.Value.Year & "-" & dtKOS_N.Value.Month & "-" & dtKOS_N.Value.Day
        d2 = dtKOS_K.Value.Year & "-" & dtKOS_K.Value.Month & "-" & dtKOS_K.Value.Day

        Dim sSQL As String = ""
        Dim cmd As OleDbCommand
        Dim rs As OleDbDataReader
        Dim intCount As Decimal = 0

        Select Case cmbKOS.Text

            Case "Полчаса"

                sSQL = "SELECT MAX(DateTime) AS [dtStandart], MAX(CASE WHEN 60>0 THEN dbo.StandartToLocal(DateTime, IsSummer) ELSE DateTime END) AS [dtLocal], MIN(CAST(Valid AS INT)) AS [Valid],MIN(CAST(Complete AS INT)) AS [Complete],SUM(CASE WHEN ObjectId=" & sPar & " AND ProfileId=" & ProfileId & " THEN Value ELSE NULL END) AS [V_C] FROM IData INNER JOIN ICells ON IData.CellId=ICells.CellId WHERE (ObjectId=" & sPar & "  OR ((NOT (" & sPar & " IS NULL)) AND ObjectId=" & sPar & ")) AND DateTime  BETWEEN '" & D1 & "' AND '" & d2 & "' AND interval=" & interval & " GROUP BY dbo.SnapToEnd(DateTime, 30) order by dtstandart "

            Case "Час"

                sSQL = "SELECT MAX(DateTime) AS [dtStandart], MAX(CASE WHEN 60>0 THEN dbo.StandartToLocal(DateTime, IsSummer) ELSE DateTime END) AS [dtLocal], MIN(CAST(Valid AS INT)) AS [Valid],MIN(CAST(Complete AS INT)) AS [Complete],SUM(CASE WHEN ObjectId=" & sPar & " AND ProfileId=" & ProfileId & " THEN Value ELSE NULL END) AS [V_C] FROM IData INNER JOIN ICells ON IData.CellId=ICells.CellId WHERE (ObjectId=" & sPar & "  OR ((NOT (" & sPar & " IS NULL)) AND ObjectId=" & sPar & ")) AND DateTime  BETWEEN '" & D1 & "' AND '" & d2 & "' AND interval=" & interval & " GROUP BY dbo.SnapToEnd(DateTime, 60) order by dtstandart "
                'AND DateTime  BETWEEN '" & d1 & "' AND '" & d2 & "'

            Case "Сутки"

                sSQL = "SELECT MAX(DateTime) AS [dtStandart], MAX(CASE WHEN -1>0 THEN dbo.StandartToLocal(DateTime, IsSummer) ELSE DateTime END) AS [dtLocal], MIN(CAST(Valid AS INT)) AS [Valid],MIN(CAST(Complete AS INT)) AS [Complete],SUM(CASE WHEN ObjectId=" & sPar & "  AND ProfileId=" & ProfileId & " THEN Value ELSE NULL END) AS [V_C] FROM IData INNER JOIN ICells ON IData.CellId=ICells.CellId WHERE (ObjectId=" & sPar & "  OR ((NOT (" & sPar & " IS NULL)) AND ObjectId=" & sPar & "))AND DateTime  BETWEEN '" & D1 & "' AND '" & d2 & "' AND interval=" & interval & " GROUP BY dbo.SnapToEnd(DateTime, -1) order by dtstandart "
                'AND DateTime  BETWEEN '2014-01-01' AND '2014-04-01'

            Case "Месяц"

                Dim stmpYear As String

                stmpYear = dtKOS_N.Value.Year
                Dim stmpMonth As String
                Dim sTmp As String = ""
                Dim stmpITOGO As String = ""


                'BETWEEN '" & D1 & "' AND '" & d2 & "'

                For i = 1 To 12

                    D1 = stmpYear & "-" & i & "-01"
                    d2 = stmpYear & "-" & i + 1 & "-01"

                    Select Case i

                        Case 1
                            stmpMonth = i + 1
                            sTmp = "Январь"
                        Case 2
                            stmpMonth = i + 1
                            sTmp = "Февраль"
                        Case 3
                            stmpMonth = i + 1
                            sTmp = "Март"
                        Case 4
                            stmpMonth = i + 1
                            sTmp = "Апрель"
                        Case 5
                            stmpMonth = i + 1
                            sTmp = "Май"
                        Case 6
                            stmpMonth = i + 1
                            sTmp = "Июнь"
                        Case 7
                            stmpMonth = i + 1
                            sTmp = "Июль"
                        Case 8
                            stmpMonth = i + 1
                            sTmp = "Август"
                        Case 9
                            stmpMonth = i + 1
                            sTmp = "Сентябрь"
                        Case 10
                            stmpMonth = i + 1
                            sTmp = "Октябрь"
                        Case 11
                            stmpMonth = i + 1
                            sTmp = "Ноябрь"
                        Case 12
                            stmpMonth = 1
                            sTmp = "Декабрь"
                            d2 = stmpYear + 1 & "-" & 1 & "-01"
                    End Select

                    sSQL = "SELECT sum(idata.Value) as v_c FROM IData INNER JOIN ICells ON IData.CellId=ICells.CellId WHERE ObjectId=" & sPar & "  AND DateTime  BETWEEN '" & D1 & "' AND '" & d2 & "' AND interval=" & interval & "  and profileid=" & ProfileId
                    'SELECT sum(idata.Value) as v_c FROM [TI2_Lukoyanovskaya].[dbo].IData INNER JOIN [TI2_Lukoyanovskaya].[dbo].ICells ON IData.CellId=ICells.CellId WHERE ObjectId=247  AND DateTime  BETWEEN '2015-1-01' AND '2015-2-01' AND interval=30 and profileid=1



                    cmd = New OleDbCommand(sSQL, DBASKUER)
                    rs = cmd.ExecuteReader

                    While rs.Read
                        lvKos.Items.Add(sTmp)
                        If Not IsDBNull(rs.Item("V_C")) Then
                            lvKos.Items(CInt(intCount)).SubItems.Add(Math.Round(rs.Item("V_C"), 4))

                            If Len(stmpITOGO) = 0 Then
                                stmpITOGO = Math.Round(rs.Item("V_C"), 4)
                            Else
                                stmpITOGO = stmpITOGO + Math.Round(rs.Item("V_C"), 4)
                            End If

                        Else
                            lvKos.Items(CInt(intCount)).SubItems.Add("0")
                        End If
                        intCount = intCount + 1
                    End While
                    rs.Close()
                    rs = Nothing

                    Select Case i

                        Case 12

                            lvKos.Items.Add("Итого за год:")
                            lvKos.Items(CInt(intCount)).SubItems.Add(stmpITOGO)

                    End Select

                Next

                ' DBASKUER.Close()
                Exit Sub
        End Select

        cmd = New OleDbCommand(sSQL, DBASKUER)
        rs = cmd.ExecuteReader

        While rs.Read

            lvKos.Items.Add(rs.Item("dtStandart"))

            If Not IsDBNull(rs.Item("V_C")) Then

                lvKos.Items(CInt(intCount)).SubItems.Add(Math.Round(rs.Item("V_C"), 4))

            Else
                lvKos.Items(CInt(intCount)).SubItems.Add("0")
            End If

            intCount = intCount + 1

        End While

        rs.Close()
        rs = Nothing
        ' DBASKUER.Close()

    End Sub

    Private Sub frmASKUER_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        lvKos.Columns.Add("Дата\Время", 150, HorizontalAlignment.Left)
        lvKos.Columns.Add("Данные", 300, HorizontalAlignment.Left)

    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Dim sTXT As String = cmbASK.Text & vbNewLine & "интервал-" & cmbKOS.Text '& " и " & ComboBox2.Text
        ExportListViewToExcel(lvKos, sTXT)
    End Sub

    Private Sub Load_ASKUER()
        ProfileId = 14
        interval = 60

        Select Case cmbASK.Text

            Case "АртСкважина № 1"
                If Len(cmbKOS.Text) = 0 Then Exit Sub
                ' gbKos.Text = "АртСкважина № 1"
                Call LOAD_ASKUER_WITH_PARAM(295)
            Case "АртСкважина № 2"
                If Len(cmbKOS.Text) = 0 Then Exit Sub
                '  gbKos.Text = "АртСкважина № 2"
                Call LOAD_ASKUER_WITH_PARAM(296)
            Case "Насосная станция II подъёма"
                If Len(cmbKOS.Text) = 0 Then Exit Sub
                ' gbKos.Text = "Насосная Станция II Подъёма"
                Call LOAD_ASKUER_WITH_PARAM(294)
            Case "Подпитка тепловая сеть"
                If Len(cmbKOS.Text) = 0 Then Exit Sub
                '  gbKos.Text = "Подпитка Тепловая Сеть"
                Call LOAD_ASKUER_WITH_PARAM(314)
            Case "РЭБ - Расхдмер ЭРСВ-510Л"
                If Len(cmbKOS.Text) = 0 Then Exit Sub
                '  gbKos.Text = "РЭБ - Расхдмер ЭРСВ-510Л"
                Call LOAD_ASKUER_WITH_PARAM(283)
            Case "Энергоблок РСЛ-212"
                If Len(cmbKOS.Text) = 0 Then Exit Sub
                '   gbKos.Text = "Энергоблок РСЛ-212"
                Call LOAD_ASKUER_WITH_PARAM(306)

            Case "ГПА№1 Ввод 1"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                ProfileId = 1
                interval = 30
                Call LOAD_ASKUER_WITH_PARAM(247)

            Case "ГПА№1 Ввод 2"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                ProfileId = 1
                interval = 30
                Call LOAD_ASKUER_WITH_PARAM(255)
            Case "ГПА№2 Ввод 1"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                ProfileId = 1
                interval = 30
                Call LOAD_ASKUER_WITH_PARAM(251)
            Case "ГПА№2 Ввод 2"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                ProfileId = 1
                interval = 30
                Call LOAD_ASKUER_WITH_PARAM(256)
            Case "ГПА№3 Ввод 1"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                ProfileId = 1
                interval = 30
                Call LOAD_ASKUER_WITH_PARAM(252)
            Case "ГПА№3 Ввод 2"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                ProfileId = 1
                interval = 30
                Call LOAD_ASKUER_WITH_PARAM(257)
            Case "ГПА№4 Ввод 1"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                ProfileId = 1
                interval = 30
                Call LOAD_ASKUER_WITH_PARAM(258)
            Case "ГПА№4 Ввод 2"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                ProfileId = 1
                interval = 30
                Call LOAD_ASKUER_WITH_PARAM(253)
            Case "ГПА№5 Ввод 1"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                ProfileId = 1
                interval = 30
                Call LOAD_ASKUER_WITH_PARAM(259)
            Case "ГПА№5 Ввод 2"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                ProfileId = 1
                interval = 30
                Call LOAD_ASKUER_WITH_PARAM(254)

            Case "Столовая"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                Call LOAD_ASKUER_WITH_PARAM(285)

                'Case "Столовая Трубопровод #3"
                '    If Len(cmbKOS.Text) = 0 Then Exit Sub

                '    Call LOAD_ASKUER_WITH_PARAM(286)

            Case "Подача тепловая сеть"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                Call LOAD_ASKUER_WITH_PARAM(312)

            Case "Обратный тепловая сеть"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                Call LOAD_ASKUER_WITH_PARAM(313)

            Case "Мойка машин"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                Call LOAD_ASKUER_WITH_PARAM(288)

            Case "Проходная"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                Call LOAD_ASKUER_WITH_PARAM(289)

            Case "Гараж"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                Call LOAD_ASKUER_WITH_PARAM(286)

                'Гараж

            Case "Очистные сооружения дождевых стоков РСЛ-212 (1)"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                Call LOAD_ASKUER_WITH_PARAM(302)

            Case "Очистные сооружения дождевых стоков РСЛ-212 (2)"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                Call LOAD_ASKUER_WITH_PARAM(301)

            Case "САУ КОС РСЛ-212"

                If Len(cmbKOS.Text) = 0 Then Exit Sub
                '  gbKos.Text = "САУ КОС"
                Call LOAD_ASKUER_WITH_PARAM(303)


            Case "Обратный ГВС"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                Call LOAD_ASKUER_WITH_PARAM(316)

            Case "Подача ГВС"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                Call LOAD_ASKUER_WITH_PARAM(315)

            Case "Сырая вода (общая)"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                Call LOAD_ASKUER_WITH_PARAM(318)

            Case "Котельная - Сеть ГВС"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                ProfileId = 18
                Call LOAD_ASKUER_WITH_PARAM(310)

            Case "Котельная - Тепловая сеть"
                If Len(cmbKOS.Text) = 0 Then Exit Sub

                ProfileId = 18
                interval = 60
                Call LOAD_ASKUER_WITH_PARAM(309)

                'Котельная - Тепловая сеть

        End Select
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Call Load_ASKUER()

    End Sub

    Private Sub cmbASK_Click(sender As Object, e As System.EventArgs) Handles cmbASK.Click
        Call Load_ASKUER()
    End Sub

    Private Sub cmbASK_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbASK.SelectedIndexChanged
        Call Load_ASKUER()
    End Sub

    Private Sub cmbKOS_Click(sender As Object, e As System.EventArgs) Handles cmbKOS.Click
        Call Load_ASKUER()
    End Sub

    Private Sub cmbKOS_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbKOS.SelectedIndexChanged
        Call Load_ASKUER()
    End Sub

    Private Sub frmASTUER_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Call FONT_SIZE(Me)
    End Sub
End Class