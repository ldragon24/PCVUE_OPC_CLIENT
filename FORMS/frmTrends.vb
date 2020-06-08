Imports ZedGraph
Imports System.Threading

Public Class frmTrends
    'Dim PAR1, PAR2, PAR3, PAR4 As String

    Dim ThG1 As System.Threading.Thread

    Private zgc = New ZedGraphControl

    Private alist = New PointPairList()
    Private blist = New PointPairList()
    Private clist = New PointPairList()
    Private dlist = New PointPairList()
    Dim Th As System.Threading.Thread
    Dim thStart1 As String
    Dim thStart2 As String
    Private inhibit_scroll As Boolean = False
    Dim sPAR(4) As String
    Dim sCOMBOTEXT As String
    Dim sCtr As Integer = 0


    Public Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        AddHandler zg1.ContextMenuBuilder, AddressOf zg1_ContextMenuBuilder

        '  PrepareGraph()

    End Sub

    Private Sub frmTrends_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Try
            ThG1.Abort()
            m_server.CancelSubscription(groupStateTrends)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub frmTrends_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Graph_n(zg1)

        Call LOAD_TREND_CMB()

        Call MIN_CHRONO_TRD()

        DTP_DATE.Value = Date.Today.AddDays(-1)
        DTP_DATE.MinDate = stmpDATE_MIN
        DTP_TIME.Value = DateTime.Now
        DTP_DATE_K.Value = Date.Today
        DTP_DATE_K.MinDate = stmpDATE_MIN
        DTP_TIME_K.Value = DateTime.Now.AddMinutes(-1)


    End Sub

    Private Sub Graph_n(ByVal zgc As ZedGraphControl)

        Dim myPane As GraphPane = zgc.GraphPane

        myPane.YAxis.Scale.MinAuto = True
        myPane.XAxis.Scale.MinAuto = True
        myPane.YAxis.Scale.MaxAuto = True
        myPane.XAxis.Scale.MaxAuto = True
        myPane.IsBoundedRanges = True

        myPane.CurveList.Clear()
        myPane.GraphObjList.Clear()
        ' Me.Invoke(Sub() zg1.Refresh())


        Me.Invoke(Sub() myPane.Title.Text = "")

        myPane.XAxis.Title.Text = "Время"
        myPane.YAxis.Title.Text = "Данные"
        myPane.XAxis.Type = AxisType.Date

        myPane.Title.FontSpec.Size = 20
        myPane.XAxis.Title.FontSpec.Size = 10
        myPane.YAxis.Title.FontSpec.Size = 10

        myPane.XAxis.MajorGrid.IsVisible = True
        myPane.XAxis.MajorGrid.DashOn = 10
        myPane.XAxis.MajorGrid.DashOff = 5

        myPane.YAxis.MajorGrid.IsVisible = True
        myPane.YAxis.MajorGrid.DashOn = 10
        myPane.YAxis.MajorGrid.DashOff = 5
        ' myPane.

        myPane.XAxis.MinorGrid.IsVisible = True
        myPane.XAxis.MinorGrid.DashOn = 1
        myPane.XAxis.MinorGrid.DashOff = 2

        myPane.YAxis.MinorGrid.IsVisible = True
        myPane.YAxis.MinorGrid.DashOn = 1
        myPane.YAxis.MinorGrid.DashOff = 2


        'myPane.XAxis.Scale.MinorUnit = DateUnit.Second
        'myPane.XAxis.Scale.MajorUnit = DateUnit.Second
        'myPane.XAxis.Scale.Format = "dd/MM/yyyy" & vbCrLf & "HH:mm:ss"


        myPane.YAxis.MinorGrid.Color = Color.Gray
        myPane.XAxis.MinorGrid.Color = Color.Gray
        myPane.Chart.Fill = New Fill(Color.LightYellow, Color.Gray)

        myPane.IsFontsScaled = False
        myPane.YAxis.Scale.MinAuto = True
        myPane.XAxis.Scale.MinAuto = True
        myPane.YAxis.Scale.MaxAuto = True
        myPane.XAxis.Scale.MaxAuto = True
        myPane.IsBoundedRanges = True

        alist.clear()
        blist.clear()
        clist.clear()

        zgc.AxisChange()
        zgc.Invalidate()


    End Sub

    Public Sub LOAD_TREND(ByVal zgc As ZedGraphControl)

        Me.Cursor = Cursors.WaitCursor

        On Error GoTo err_

        Dim sSQL As String
        Dim cmd As OleDbCommand
        Dim rs As OleDbDataReader

        sSQL = "SELECT count(*) as t_n FROM Trends where Name='" & ComboBox3.Text & "'"
        cmd = New OleDbCommand(sSQL, DB7)
        rs = cmd.ExecuteReader

        While rs.Read

            sCtr = rs.Item("t_n")

        End While

        rs.Close()
        rs = Nothing

        If sCtr = 0 Then Exit Sub

        ' Dim sPAR(sCOUNT) As String

        Dim intj As Integer = 0
        sSQL = "SELECT TEG FROM Trends where Name='" & ComboBox3.Text & "'"
        cmd = New OleDbCommand(sSQL, DB7)
        rs = cmd.ExecuteReader

        While rs.Read

            sPAR(intj) = rs.Item("TEG")

            intj = intj + 1

        End While

        rs.Close()
        rs = Nothing

        Dim myPane As GraphPane = zgc.GraphPane

        myPane.YAxis.Scale.MinAuto = True
        myPane.XAxis.Scale.MinAuto = True
        myPane.YAxis.Scale.MaxAuto = True
        myPane.XAxis.Scale.MaxAuto = True

        myPane.CurveList.Clear()
        myPane.GraphObjList.Clear()
        zgc.Refresh()

        ' Make up some data points from the Sine function

        System.Windows.Forms.Application.DoEvents()

        Dim sTPAR As String

        Dim stINDEX As Integer = 0

        Dim sTMP As String
        Dim sL1 As Integer

PARAMETRY:

        If Len(sPAR(0)) = 0 Then

            MsgBox("Не заданы параметры", MsgBoxStyle.Information, Me.Text)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If


        Dim D1, d2, D3, D4 As String
        D1 = Me.DTP_DATE.Value.Year & "-" & Me.DTP_DATE.Value.Month & "-" & Me.DTP_DATE.Value.Day
        d2 = Me.DTP_TIME.Value.Hour & ":" & Me.DTP_TIME.Value.Minute & ":" & Me.DTP_TIME.Value.Second

        D4 = Me.DTP_DATE_K.Value.Year & "-" & Me.DTP_DATE_K.Value.Month & "-" & Me.DTP_DATE_K.Value.Day & " " & Me.DTP_TIME_K.Value.Hour & ":" & Me.DTP_TIME_K.Value.Minute & ":" & Me.DTP_TIME_K.Value.Second

        D1 = D1 & " " & d2

        D3 = Date.Today.Year & "-" & Date.Today.Month & "-" & Date.Today.Day & " " & Date.Today.Hour & ":" & Date.Today.Minute & ":" & Date.Today.Second

        Select Case sCtr

            Case 1
                sSQL = "SELECT count(*) as t_n FROM dbo.[TRD] Where dbo.fn_ChronoToDateTime(Chrono) BETWEEN '" & D1 & "' AND '" & D4 & "' AND Name = '" & sPAR(0) & "'"

            Case 2
                sSQL = "SELECT count(*) as t_n FROM dbo.[TRD] Where dbo.fn_ChronoToDateTime(Chrono) BETWEEN' " & D1 & "' AND '" & D4 & "' AND Name in ('" & sPAR(0) & "','" & sPAR(1) & "')"

            Case 3
                sSQL = "SELECT count(*) as t_n FROM dbo.[TRD] Where dbo.fn_ChronoToDateTime(Chrono) BETWEEN' " & D1 & "' AND '" & D4 & "' AND Name in ('" & sPAR(0) & "','" & sPAR(1) & "','" & sPAR(2) & "')"

            Case 4
                sSQL = "SELECT count(*) as t_n FROM dbo.[TRD] Where dbo.fn_ChronoToDateTime(Chrono) BETWEEN' " & D1 & "' AND '" & D4 & "' AND Name in ('" & sPAR(0) & "','" & sPAR(1) & "','" & sPAR(2) & "','" & sPAR(3) & "')"

        End Select

        cmd = New OleDbCommand(sSQL, DBASUE)
        rs = cmd.ExecuteReader

        Dim sCount As Integer = 0

        While rs.Read

            sCount = rs.Item("t_n")

        End While

        rs.Close()
        rs = Nothing

        If sCount = 0 Then
            MsgBox("Данные по заданным параметрам не обнаружены", MsgBoxStyle.Information, Me.Text)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        Dim intCount As Decimal = 0



        Select Case sCtr

            Case 1
                sSQL = "SELECT dbo.fn_ChronoToDateTime(Chrono) AS Дата, Name AS Имя, Value AS Значение FROM dbo.[TRD] Where Quality=192 AND dbo.fn_ChronoToDateTime(Chrono) BETWEEN '" & D1 & "' AND '" & D4 & "' AND Name = '" & sPAR(0) & "'"

            Case 2
                sSQL = "SELECT dbo.fn_ChronoToDateTime(Chrono) AS Дата, Name AS Имя, Value AS Значение FROM dbo.[TRD] Where Quality=192 AND  dbo.fn_ChronoToDateTime(Chrono) BETWEEN' " & D1 & "' AND '" & D4 & "' AND Name in ('" & sPAR(0) & "','" & sPAR(1) & "')"

            Case 3
                sSQL = "SELECT dbo.fn_ChronoToDateTime(Chrono) AS Дата, Name AS Имя, Value AS Значение FROM dbo.[TRD] Where Quality=192 AND  dbo.fn_ChronoToDateTime(Chrono) BETWEEN' " & D1 & "' AND '" & D4 & "' AND Name in ('" & sPAR(0) & "','" & sPAR(1) & "','" & sPAR(2) & "')"

            Case 4
                sSQL = "SELECT dbo.fn_ChronoToDateTime(Chrono) AS Дата, Name AS Имя, Value AS Значение FROM dbo.[TRD] Where Quality=192 AND  dbo.fn_ChronoToDateTime(Chrono) BETWEEN' " & D1 & "' AND '" & D4 & "' AND Name in ('" & sPAR(0) & "','" & sPAR(1) & "','" & sPAR(2) & "','" & sPAR(3) & "')"

        End Select

        cmd = New OleDbCommand(sSQL, DBASUE)
        rs = cmd.ExecuteReader

        'Dim stb As Decimal

        ' Dim timestamp As Double
        Dim now As DateTime

        Dim tPar1, tPar2, tPar3, tPar4 As Double
        '   Dim tDar1, tDar2, tDar3, tDar4 As DateTime

        ' Dim xlist As Double() = New Double(sCount - 1) {}
        '  Dim ylist As Double() = New Double(sCount - 1) {}

        intj = 0
        While rs.Read

            Select Case rs.Item("Имя")

                Case sPAR(0)

                    Select Case intj

                        Case 0
                            now = rs.Item("Дата")
                            Dim timestamp As Double = CDbl(New XDate(now))
                            alist.Add(timestamp, rs.Item("Значение"))

                            tPar1 = rs.Item("Значение")
                            '  tDar1 = rs.Item("Дата")

                            ' xlist(intj) = timestamp
                            '  ylist(intj) = tPar1


                        Case Else

                            now = rs.Item("Дата")
                            Dim timestamp As Double = CDbl(New XDate(now))
                            alist.Add(timestamp, tPar1)

                            now = rs.Item("Дата")
                            timestamp = CDbl(New XDate(now))
                            alist.Add(timestamp, rs.Item("Значение"))
                            tPar1 = rs.Item("Значение")
                            '  tDar1 = rs.Item("Дата")

                            '  xlist(intj) = timestamp
                            '  ylist(intj) = tPar1

                    End Select

                Case sPAR(1)

                    Select Case intj

                        Case 0
                            now = rs.Item("Дата")
                            Dim timestamp As Double = CDbl(New XDate(now))
                            blist.Add(timestamp, rs.Item("Значение"))
                            tPar2 = rs.Item("Значение")
                            '  tDar2 = rs.Item("Дата")

                        Case Else

                            now = rs.Item("Дата")
                            Dim timestamp As Double = CDbl(New XDate(now))

                            If tPar2 = 0 Then
                                tPar2 = rs.Item("Значение")
                            End If

                            blist.Add(timestamp, tPar2)

                            now = rs.Item("Дата")
                            timestamp = CDbl(New XDate(now))
                            blist.Add(timestamp, rs.Item("Значение"))
                            tPar2 = rs.Item("Значение")
                            ' tDar2 = rs.Item("Дата")
                    End Select

                Case sPAR(2)

                    If Len(sPAR(2)) <> 0 Then

                        Select Case intj

                            Case 0
                                now = rs.Item("Дата")
                                Dim timestamp As Double = CDbl(New XDate(now))
                                clist.Add(timestamp, rs.Item("Значение"))
                                tPar3 = rs.Item("Значение")
                                '    tDar3 = rs.Item("Дата")

                            Case Else

                                now = rs.Item("Дата")
                                Dim timestamp As Double = CDbl(New XDate(now))
                                If tPar3 = 0 Then
                                    tPar3 = rs.Item("Значение")
                                End If

                                clist.Add(timestamp, tPar3)

                                now = rs.Item("Дата")
                                timestamp = CDbl(New XDate(now))
                                clist.Add(timestamp, rs.Item("Значение"))
                                tPar3 = rs.Item("Значение")
                                '   tDar3 = rs.Item("Дата")
                        End Select

                    End If

                Case sPAR(3)

                    Select Case intj

                        Case 0
                            now = rs.Item("Дата")
                            Dim timestamp As Double = CDbl(New XDate(now))
                            dlist.Add(timestamp, rs.Item("Значение"))
                            tPar4 = rs.Item("Значение")
                            '  tDar4 = rs.Item("Дата")

                        Case Else

                            now = rs.Item("Дата")
                            Dim timestamp As Double = CDbl(New XDate(now))

                            If tPar3 = 0 Then
                                tPar3 = rs.Item("Значение")
                            End If

                            dlist.Add(timestamp, tPar3)

                            now = rs.Item("Дата")
                            timestamp = CDbl(New XDate(now))
                            dlist.Add(timestamp, rs.Item("Значение"))
                            tPar4 = rs.Item("Значение")
                            '  tDar4 = rs.Item("Дата")
                    End Select

            End Select

            intj = intj + 1

        End While
        rs.Close()
        rs = Nothing

        Select Case sCtr

            Case 1

                sSQL = "SELECT max(Value) as f_s, min(Value) as f_d FROM dbo.[TRD] Where Quality=192 AND dbo.fn_ChronoToDateTime(Chrono) BETWEEN '" & D1 & "' AND '" & D4 & "' AND Name = '" & sPAR(0) & "'"

            Case 2

                sSQL = "SELECT max(Value) as f_s, min(Value) as f_d FROM dbo.[TRD] Where Quality=192 AND dbo.fn_ChronoToDateTime(Chrono) BETWEEN '" & D1 & "' AND '" & D4 & "' AND Name in ('" & sPAR(0) & "','" & sPAR(1) & "')"

            Case 3

                sSQL = "SELECT max(Value) as f_s, min(Value) as f_d FROM dbo.[TRD] Where Quality=192 AND dbo.fn_ChronoToDateTime(Chrono) BETWEEN '" & D1 & "' AND '" & D4 & "' AND Name in ('" & sPAR(0) & "','" & sPAR(1) & "','" & sPAR(2) & "')"

            Case 4

                sSQL = "SELECT max(Value) as f_s, min(Value) as f_d FROM dbo.[TRD] Where Quality=192 AND dbo.fn_ChronoToDateTime(Chrono) BETWEEN '" & D1 & "' AND '" & D4 & "' AND Name in ('" & sPAR(0) & "','" & sPAR(1) & "','" & sPAR(2) & "','" & sPAR(3) & "')"

        End Select

        cmd = New OleDbCommand(sSQL, DBASUE)
        rs = cmd.ExecuteReader
        Dim sMax As String = ""
        Dim sMin As String = ""

        While rs.Read

            If Not IsDBNull(rs.Item("f_s")) Then
                sMax = Math.Round(rs.Item("f_s"), 2)
            Else
                sMax = 0
            End If


            If Not IsDBNull(rs.Item("f_d")) Then
                sMin = Math.Round(rs.Item("f_d"), 2)
            Else
                sMin = 0
            End If

        End While

        'Вставляем надпись на график
        myPane.Title.Text = ComboBox3.Text & " - Архивные данные" & " " & "(максимальное значение = " & sMax & ", минимальное = " & sMin & ") " & vbNewLine & "Данные за период с " & D1 & " по " & D4

        'Формируем график
        myPane.XAxis.Title.Text = "Время"
        myPane.YAxis.Title.Text = "Данные"
        myPane.XAxis.Type = AxisType.Date

        myPane.Title.FontSpec.Size = 20
        myPane.XAxis.Title.FontSpec.Size = 10
        myPane.YAxis.Title.FontSpec.Size = 10

        myPane.XAxis.MajorGrid.IsVisible = True
        myPane.XAxis.MajorGrid.DashOn = 10
        myPane.XAxis.MajorGrid.DashOff = 5

        myPane.YAxis.MajorGrid.IsVisible = True
        myPane.YAxis.MajorGrid.DashOn = 10
        myPane.YAxis.MajorGrid.DashOff = 5
        ' myPane.

        myPane.XAxis.MinorGrid.IsVisible = True
        myPane.XAxis.MinorGrid.DashOn = 1
        myPane.XAxis.MinorGrid.DashOff = 2

        myPane.YAxis.MinorGrid.IsVisible = True
        myPane.YAxis.MinorGrid.DashOn = 1
        myPane.YAxis.MinorGrid.DashOff = 2


        'Dim filteredList As New FilteredPointList(xlist, ylist)
        'Dim filteredCount As Integer = filteredList.Count / 2
        'Dim filteredXMin As Double = sMin
        'Dim filteredXMax As Double = sMax
        'filteredList.SetBounds(filteredXMin, filteredXMax, filteredCount)

        

        Select Case sCtr

            Case 1

                Dim myCurve As LineItem = myPane.AddCurve(sPAR(0), alist, Color.Red, SymbolType.None)

                myCurve.Line.Width = 3.0F
                myCurve.Line.Style = Drawing2D.DashStyle.Solid
                ' myCurve.Line.Style = Drawing2D.DashCap.Round
                'myCurve.Line.IsSmooth = True 'Сглаживает углы

            Case 2
                Dim myCurve As LineItem = myPane.AddCurve(sPAR(0), alist, Color.Red, SymbolType.None)
                myCurve.Line.Width = 3.0F
                myCurve.Line.Style = Drawing2D.DashStyle.Solid

                Dim myCurve2 As LineItem = myPane.AddCurve(sPAR(1), blist, Color.Green, SymbolType.None)
                myCurve2.Line.Width = 3.0F
                myCurve2.Line.Style = Drawing2D.DashStyle.Solid

            Case 3
                Dim myCurve As LineItem = myPane.AddCurve(sPAR(0), alist, Color.Red, SymbolType.None)
                myCurve.Line.Width = 2.0F
                myCurve.Line.Style = Drawing2D.DashStyle.Solid

                Dim myCurve2 As LineItem = myPane.AddCurve(sPAR(1), blist, Color.Green, SymbolType.None)
                myCurve2.Line.Width = 2.0F
                myCurve2.Line.Style = Drawing2D.DashStyle.Solid

                Dim myCurve3 As LineItem = myPane.AddCurve(sPAR(2), clist, Color.Blue, SymbolType.None)
                myCurve3.Line.Width = 2.0F
                myCurve3.Line.Style = Drawing2D.DashStyle.Solid

            Case 4
                Dim myCurve As LineItem = myPane.AddCurve(sPAR(0), alist, Color.Red, SymbolType.None)
                myCurve.Line.Width = 2.0F
                myCurve.Line.Style = Drawing2D.DashStyle.Solid

                Dim myCurve2 As LineItem = myPane.AddCurve(sPAR(1), blist, Color.Green, SymbolType.None)
                myCurve2.Line.Width = 2.0F
                myCurve2.Line.Style = Drawing2D.DashStyle.Solid

                Dim myCurve3 As LineItem = myPane.AddCurve(sPAR(2), clist, Color.Blue, SymbolType.None)
                myCurve3.Line.Width = 2.0F
                myCurve3.Line.Style = Drawing2D.DashStyle.Solid

                Dim myCurve4 As LineItem = myPane.AddCurve(sPAR(3), dlist, Color.Olive, SymbolType.None)
                myCurve4.Line.Width = 2.0F
                myCurve4.Line.Style = Drawing2D.DashStyle.Solid

        End Select

        myPane.YAxis.MinorGrid.Color = Color.Gray
        myPane.XAxis.MinorGrid.Color = Color.Gray
        myPane.Chart.Fill = New Fill(Color.LightYellow, Color.Gray)
        myPane.Border.Color = Color.Black

        myPane.YAxis.Scale.MinAuto = True
        myPane.XAxis.Scale.MinAuto = True
        myPane.YAxis.Scale.MaxAuto = True
        myPane.XAxis.Scale.MaxAuto = True

        ' myPane.YAxis.Scale.Max += myPane.YAxis.Scale.MajorStep
        ' myPane.XAxis.Scale.Max += myPane.XAxis.Scale.MajorStep

        'inhibit_scroll = True
        'If Not inhibit_scroll Then
        '    LOAD_TREND(zgc)
        'End If

        ' zgc.Size = New Size(alist1.Count * 10, sMax * 10)
        myPane.IsBoundedRanges = True
        zgc.IsShowHScrollBar = True
        zgc.IsShowVScrollBar = True
        zgc.AxisChange()
        zgc.Invalidate()

        Me.Cursor = Cursors.Default

        Exit Sub
err_:
        MsgBox(Err.Description)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub zg1_ContextMenuBuilder(sender As ZedGraphControl, menuStrip As ContextMenuStrip, mousePt As System.Drawing.Point, objState As ZedGraphControl.ContextMenuObjectState)
        ' !!!
        ' Переименуем (переведем на русский язык) некоторые пункты контекстного меню
        menuStrip.Items(0).Text = "Копировать"
        menuStrip.Items(1).Text = "Сохранить как картинку…"
        menuStrip.Items(2).Text = "Параметры страницы…"
        menuStrip.Items(3).Text = "Печать…"
        menuStrip.Items(4).Text = "Показывать значения в точках…"
        ' menuStrip.Items(4).Checked = True
        menuStrip.Items(5).Text = "Убрать увеличение"
        menuStrip.Items(6).Text = "Убрать все увеличение"
        menuStrip.Items(7).Text = "Установить масштаб по умолчанию…"

        ' Некоторые пункты удалим
        ' menuStrip.Items.RemoveAt(5)
        ' menuStrip.Items.RemoveAt(5)

        ' Добавим свой пункт меню
        ' Dim newMenuItem As ToolStripItem = New ToolStripMenuItem("Этот пункт меню ничего не делает")
        '  menuStrip.Items.Add(newMenuItem)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Select Case thStart2
            Case "Start"
                thStart2 = ""
                ThG1.Abort()
                btnRt.Text = "Текущие показания"
            Case Else
                Graph_n(zg1)
        End Select

        Me.Cursor = Cursors.WaitCursor

        If DTP_DATE_K.Value > Date.Now.Date Then

            MsgBox("Конечная дата больше текущей", MsgBoxStyle.Exclamation, Me.Text)
            Me.Cursor = Cursors.Default
            Exit Sub

        End If

        Dim DTT As String = DTP_TIME_K.Value.Hour & ":" & DTP_TIME_K.Value.Minute & ":" & DTP_TIME_K.Value.Second
        Dim DTT1 As String = DateTime.Now.Hour & ":" & DateTime.Now.Minute & ":" & DateTime.Now.Second

        If DTP_DATE_K.Value > Date.Now.Date And DTT > DTT1 Then

            MsgBox("Конечное время больше текущего", MsgBoxStyle.Exclamation, Me.Text)
            Me.Cursor = Cursors.Default
            Exit Sub

        End If

        Call LOAD_TREND(zg1)
    End Sub

    Private Sub btnRt_Click(sender As System.Object, e As System.EventArgs) Handles btnRt.Click

        Select Case btnRt.Text

            Case "Текущие показания"
                btnRt.Text = "Стоп"
                Graph_n(zg1)
            Case Else
                btnRt.Text = "Текущие показания"
                thStart2 = ""
                m_server.CancelSubscription(groupTrends)
                ThG1.Abort()

                Exit Sub
        End Select


        If ComboBox3.Text = "" Then

            MsgBox("Не выбран тренд", MsgBoxStyle.Exclamation, ProductName)

        Else
            ' frm_chart.Show()

        End If


        '#######################################################################
        'Чарт по новому
        '#######################################################################

        sCOMBOTEXT = ComboBox3.Text

        ThG1 = New System.Threading.Thread(AddressOf Thr_G1)
        ThG1.Start()
    End Sub

    Sub Thr_G1()

        Dim sSQL As String
        Dim cmd As OleDbCommand
        Dim rs As OleDbDataReader

        sSQL = "SELECT count(*) as t_n FROM Trends where Name='" & sCOMBOTEXT & "'"
        cmd = New OleDbCommand(sSQL, DB7)
        rs = cmd.ExecuteReader

        While rs.Read

            sCtr = rs.Item("t_n")

        End While

        rs.Close()
        rs = Nothing

        If sCtr = 0 Then Exit Sub

        Dim intj As Integer = 0
        sSQL = "SELECT TEG FROM Trends where Name='" & sCOMBOTEXT & "'"
        cmd = New OleDbCommand(sSQL, DB7)
        rs = cmd.ExecuteReader

        Try
ARG:
            thStart2 = "Start"

            groupStateTrends.Name = "TRENDS"
            groupStateTrends.Active = True
            groupStateTrends.UpdateRate = TSPEED

            groupTrends = DirectCast(m_server.CreateSubscription(groupStateTrends), Opc.Da.Subscription)
            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(sCtr - 1) {}


            While rs.Read

                items(intj) = New Global.Opc.Da.Item()
                items(intj).ItemName = rs.Item("TEG")
                sPAR(intj) = rs.Item("TEG")

                intj = intj + 1

            End While

            rs.Close()
            rs = Nothing

            Do

                Dim results As ItemValueResult() = Nothing
                results = groupTrends.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                Dim now As DateTime


                For i As Integer = 0 To results.Length - 1
                    'results(0).Value


                    Select Case sCtr

                        Case 1
                            '$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                            now = results(0).Timestamp
                            If now <> DateTime.Now Then

                                now = DateTime.Now

                            End If
                            Dim timestamp As Double = CDbl(New XDate(now))
                            alist.Add(timestamp, results(0).Value)

                        Case 2
                            '$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                            Dim timestampa As Double

                            now = results(0).Timestamp

                            If now <> DateTime.Now Then

                                now = DateTime.Now

                            End If

                            timestampa = CDbl(New XDate(now))
                            alist.Add(timestampa, results(0).Value)

                            '$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                            Dim timestampb As Double
                            now = results(1).Timestamp

                            If now <> DateTime.Now Then

                                now = DateTime.Now

                            End If
                            timestampb = CDbl(New XDate(now))
                            blist.Add(timestampb, results(1).Value)

                        Case 3
                            '$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                            Dim timestampa As Double

                            now = results(0).Timestamp

                            If now <> DateTime.Now Then

                                now = DateTime.Now

                            End If

                            timestampa = CDbl(New XDate(now))
                            alist.Add(timestampa, results(0).Value)

                            '$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                            Dim timestampb As Double
                            now = results(1).Timestamp

                            If now <> DateTime.Now Then

                                now = DateTime.Now

                            End If
                            timestampb = CDbl(New XDate(now))
                            blist.Add(timestampb, results(1).Value)
                            '$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                            Dim timestampc As Double
                            now = results(2).Timestamp

                            If now <> DateTime.Now Then

                                now = DateTime.Now

                            End If
                            timestampc = CDbl(New XDate(now))
                            clist.Add(timestampc, results(2).Value)

                        Case 4
                            '$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                            Dim timestampa As Double

                            now = results(0).Timestamp

                            If now <> DateTime.Now Then

                                now = DateTime.Now

                            End If

                            timestampa = CDbl(New XDate(now))
                            alist.Add(timestampa, results(0).Value)

                            '$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                            Dim timestampb As Double
                            now = results(1).Timestamp

                            If now <> DateTime.Now Then

                                now = DateTime.Now

                            End If

                            timestampb = CDbl(New XDate(now))
                            blist.Add(timestampb, results(1).Value)

                            '$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                            Dim timestampc As Double
                            now = results(2).Timestamp

                            If now <> DateTime.Now Then
                                now = DateTime.Now
                            End If
                            timestampc = CDbl(New XDate(now))
                            clist.Add(timestampc, results(2).Value)

                            '$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                            Dim timestampd As Double
                            now = results(3).Timestamp

                            If now <> DateTime.Now Then
                                now = DateTime.Now
                            End If

                            timestampd = CDbl(New XDate(now))
                            dlist.Add(timestampd, results(3).Value)

                    End Select

                Next

                If alist.count > TDOT Then
                    alist.removeAt(0)
                End If
                If blist.count > TDOT Then
                    blist.removeAt(0)
                End If
                If clist.count > TDOT Then
                    clist.removeAt(0)
                End If

                If dlist.count > TDOT Then
                    dlist.removeAt(0)
                End If

                Graph1(zg1)

                ' End If

                Threading.Thread.Sleep(TSPEED)

            Loop

        Catch ex As Exception

            'Me.Invoke(Sub() MsgBox(ex.Message, MsgBoxStyle.Critical, ""))

            GoTo ARG

        End Try

    End Sub

    Private Sub Graph1(ByVal zgc As ZedGraphControl)

        Dim myPane17 As GraphPane = zgc.GraphPane

        myPane17.YAxis.Scale.MinAuto = True
        myPane17.XAxis.Scale.MinAuto = True
        myPane17.YAxis.Scale.MaxAuto = True
        myPane17.XAxis.Scale.MaxAuto = True

        myPane17.CurveList.Clear()
        myPane17.GraphObjList.Clear()

        Me.Invoke(Sub() myPane17.Title.Text = ComboBox3.Text & " - Тренд реального времени")

        myPane17.XAxis.Title.Text = "Время"
        myPane17.YAxis.Title.Text = "Данные"
        myPane17.XAxis.Type = AxisType.Date

        myPane17.Title.FontSpec.Size = 20
        myPane17.XAxis.Title.FontSpec.Size = 10
        myPane17.YAxis.Title.FontSpec.Size = 10

        myPane17.XAxis.MajorGrid.IsVisible = True
        myPane17.XAxis.MajorGrid.DashOn = 10
        myPane17.XAxis.MajorGrid.DashOff = 5

        myPane17.YAxis.MajorGrid.IsVisible = True
        myPane17.YAxis.MajorGrid.DashOn = 10
        myPane17.YAxis.MajorGrid.DashOff = 5
        ' myPane17.

        myPane17.XAxis.MinorGrid.IsVisible = True
        myPane17.XAxis.MinorGrid.DashOn = 1
        myPane17.XAxis.MinorGrid.DashOff = 2

        myPane17.YAxis.MinorGrid.IsVisible = True
        myPane17.YAxis.MinorGrid.DashOn = 1
        myPane17.YAxis.MinorGrid.DashOff = 2
        myPane17.IsFontsScaled = False

        Select Case sCtr

            Case 1

                Dim myCurve As LineItem = myPane17.AddCurve(sPAR(0), alist, Color.Red, SymbolType.None)
                myCurve.Line.Width = 3.0F
                myCurve.Line.Style = Drawing2D.DashStyle.Solid

            Case 2
                Dim myCurve As LineItem = myPane17.AddCurve(sPAR(0), alist, Color.Red, SymbolType.None)
                myCurve.Line.Width = 3.0F
                myCurve.Line.Style = Drawing2D.DashStyle.Solid

                Dim myCurve2 As LineItem = myPane17.AddCurve(sPAR(1), blist, Color.Green, SymbolType.None)
                myCurve2.Line.Width = 3.0F
                myCurve2.Line.Style = Drawing2D.DashStyle.Solid

            Case 3
                Dim myCurve As LineItem = myPane17.AddCurve(sPAR(0), alist, Color.Red, SymbolType.None)
                myCurve.Line.Width = 3.0F
                myCurve.Line.Style = Drawing2D.DashStyle.Solid

                Dim myCurve2 As LineItem = myPane17.AddCurve(sPAR(1), blist, Color.Green, SymbolType.None)
                myCurve2.Line.Width = 3.0F
                myCurve2.Line.Style = Drawing2D.DashStyle.Solid

                Dim myCurve3 As LineItem = myPane17.AddCurve(sPAR(2), clist, Color.Blue, SymbolType.None)
                myCurve3.Line.Width = 3.0F
                myCurve3.Line.Style = Drawing2D.DashStyle.Solid

            Case 4
                Dim myCurve As LineItem = myPane17.AddCurve(sPAR(0), alist, Color.Red, SymbolType.None)
                myCurve.Line.Width = 3.0F
                myCurve.Line.Style = Drawing2D.DashStyle.Solid

                Dim myCurve2 As LineItem = myPane17.AddCurve(sPAR(1), blist, Color.Green, SymbolType.None)
                myCurve2.Line.Width = 3.0F
                myCurve2.Line.Style = Drawing2D.DashStyle.Solid

                Dim myCurve3 As LineItem = myPane17.AddCurve(sPAR(2), clist, Color.Blue, SymbolType.None)
                myCurve3.Line.Width = 3.0F
                myCurve3.Line.Style = Drawing2D.DashStyle.Solid

                Dim myCurve4 As LineItem = myPane17.AddCurve(sPAR(3), dlist, Color.Olive, SymbolType.None)
                myCurve4.Line.Width = 3.0F
                myCurve4.Line.Style = Drawing2D.DashStyle.Solid

        End Select

        myPane17.YAxis.MinorGrid.Color = Color.Gray
        myPane17.XAxis.MinorGrid.Color = Color.Gray

        myPane17.Border.Color = Color.Black
        myPane17.Chart.Fill = New Fill(Color.LightYellow, Color.Gray)

        myPane17.YAxis.Scale.MinAuto = True
        myPane17.XAxis.Scale.MinAuto = True
        myPane17.YAxis.Scale.MaxAuto = True
        myPane17.XAxis.Scale.MaxAuto = True

        'myPane17.Legend.Position = LegendPos.Float

        myPane17.IsBoundedRanges = True
        Me.Invoke(Sub() zgc.AxisChange())
        Me.Invoke(Sub() zgc.Invalidate())


    End Sub

    Public Sub LOAD_TREND_CMB()

        '  ComboBox3.Items.Add("КТП АВО Напряжение ввод 1")
        '

        Dim sSQL As String
        Dim cmd As OleDbCommand
        Dim rs As OleDbDataReader

        sSQL = "SELECT count(*) as t_n FROM Trends"

        cmd = New OleDbCommand(sSQL, DB7)
        rs = cmd.ExecuteReader

        Dim sCOUNT As Integer

        While rs.Read

            sCOUNT = rs.Item("t_n")

        End While

        rs.Close()
        rs = Nothing

        If sCOUNT = 0 Then Exit Sub

        sSQL = "SELECT Name FROM Trends Group by Name"

        cmd = New OleDbCommand(sSQL, DB7)
        rs = cmd.ExecuteReader

        ComboBox3.Items.Clear()

        While rs.Read

            ComboBox3.Items.Add(rs.Item("Name"))

        End While

        rs.Close()
        rs = Nothing


    End Sub

    Private Sub zg1_ScrollProgressEvent(sender As ZedGraph.ZedGraphControl, scrollBar As System.Windows.Forms.ScrollBar, oldState As ZedGraph.ZoomState, newState As ZedGraph.ZoomState) Handles zg1.ScrollProgressEvent
        inhibit_scroll = True
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub
End Class