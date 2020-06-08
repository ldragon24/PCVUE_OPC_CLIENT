Public Class frmStatus
    Dim T_SERV As System.Threading.Thread

    Dim T_ALARM As System.Threading.Thread
    Private END_OPROS As Boolean = False
    Private lstVW As ListView

    Private Sub frmStatus_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Try
            T_SERV.Abort()
            m_server.CancelSubscription(groupSTATUS)

            T_ALARM.Abort()
            m_server.CancelSubscription(group_Alarmt)
            SALARM = False


        Catch ex As Exception

        End Try


    End Sub

    Private Sub frmStatus_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        T_SERV = New System.Threading.Thread(AddressOf T_SERV_START)
        T_SERV.Start()

        T_ALARM = New System.Threading.Thread(AddressOf Ti_ALARM_START)
        T_ALARM.Start()

        LV_REPORT_ALARM.Columns.Add("Дата\Время", 150, HorizontalAlignment.Left)
        LV_REPORT_ALARM.Columns.Add("Описание", 300, HorizontalAlignment.Left)
        LV_REPORT_ALARM.Columns.Add("Наименование", 300, HorizontalAlignment.Left)

        ResList(LV_REPORT_ALARM)

        System.Windows.Forms.Application.DoEvents()

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Sub T_SERV_START()

        Try
ARG:
            groupStateSTATUS.Name = "SERVER"
            groupStateSTATUS.Active = True
            groupStateSTATUS.UpdateRate = MSPEED

            groupSTATUS = DirectCast(m_server.CreateSubscription(groupStateSTATUS), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(103) {}

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "ДИАГН.СЕРВ1.ACT_SRV1"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "ДИАГН.СЕРВ2.ACT_SRV2"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "ДИАГН.СЕРВ1.FLT_SRV1"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "ДИАГН.СЕРВ2.FLT_SRV2"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "ДИАГН.АРМ21.FLT_ARM21"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "ДИАГН.АСУТП.OPC_FLT"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.ШК1.ПЛК.COMM_FAILURE"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "КЦ2.ШК2.ПЛК.COMM_FAILURE"
            'КЦ2.ШК2.ПЛК.COMM_FAILURE

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РЭБ.ШК3.ПЛК.COMM_FAILURE"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.ШК1.ПЛК.DATA_LOOSE"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "КЦ2.ШК2.ПЛК.DATA_LOOSE"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РЭБ.ШК3.ПЛК.DATA_LOOSE"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "АСУ.ИБП.ШК_СЕРВ.BatLevel"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "АСУ.ИБП.ШК1.BatLevel"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "АСУ.ИБП.ШК2.BatLevel"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "АСУ.ИБП.ШК3.BatLevel"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "АСУ.ИБП.ШК4.BatLevel"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "АСУ.ИБП.ШК_СЕРВ.COMM_FAILURE"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "АСУ.ИБП.ШК1.COMM_FAILURE"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "АСУ.ИБП.ШК2.COMM_FAILURE"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "АСУ.ИБП.ШК3.COMM_FAILURE"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "АСУ.ИБП.ШК4.COMM_FAILURE"

            '##############################################################
            'Шкаф № 1
            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С1.1_ВВОД.BAD_TIME_REPEAT"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С1.1_ВВОД.COMM_FAILURE"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С1.2_ШТН.BAD_TIME_REPEAT"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С1.2_ШТН.COMM_FAILURE"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С1.3_ФИД.BAD_TIME_REPEAT"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С1.3_ФИД.COMM_FAILURE"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С1.4_ФИД.BAD_TIME_REPEAT"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С1.4_ФИД.COMM_FAILURE"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С1.5_ФИД.BAD_TIME_REPEAT"

            items(31) = New Global.Opc.Da.Item()
            items(31).ItemName = "РП10.С1.5_ФИД.COMM_FAILURE"

            items(32) = New Global.Opc.Da.Item()
            items(32).ItemName = "РП10.С1.6_ФИД.BAD_TIME_REPEAT"

            items(33) = New Global.Opc.Da.Item()
            items(33).ItemName = "РП10.С1.6_ФИД.COMM_FAILURE"

            items(34) = New Global.Opc.Da.Item()
            items(34).ItemName = "РП10.С1.7_ФИД.BAD_TIME_REPEAT"

            items(35) = New Global.Opc.Da.Item()
            items(35).ItemName = "РП10.С1.7_ФИД.COMM_FAILURE"

            items(36) = New Global.Opc.Da.Item()
            items(36).ItemName = "РП10.С1.8_ФИД.BAD_TIME_REPEAT"

            items(37) = New Global.Opc.Da.Item()
            items(37).ItemName = "РП10.С1.8_ФИД.COMM_FAILURE"

            items(38) = New Global.Opc.Da.Item()
            items(38).ItemName = "РП10.С1.9_СВ.BAD_TIME_REPEAT"

            items(39) = New Global.Opc.Da.Item()
            items(39).ItemName = "РП10.С1.9_СВ.COMM_FAILURE"

            items(40) = New Global.Opc.Da.Item()
            items(40).ItemName = "РП10.С2.10_ВВОД.BAD_TIME_REPEAT"

            items(41) = New Global.Opc.Da.Item()
            items(41).ItemName = "РП10.С2.10_ВВОД.COMM_FAILURE"

            items(42) = New Global.Opc.Da.Item()
            items(42).ItemName = "РП10.С2.11_ШТН.BAD_TIME_REPEAT"

            items(43) = New Global.Opc.Da.Item()
            items(43).ItemName = "РП10.С2.11_ШТН.COMM_FAILURE"

            items(44) = New Global.Opc.Da.Item()
            items(44).ItemName = "РП10.С2.12_ФИД.BAD_TIME_REPEAT"

            items(45) = New Global.Opc.Da.Item()
            items(45).ItemName = "РП10.С2.12_ФИД.COMM_FAILURE"

            items(46) = New Global.Opc.Da.Item()
            items(46).ItemName = "РП10.С2.13_ФИД.BAD_TIME_REPEAT"

            items(47) = New Global.Opc.Da.Item()
            items(47).ItemName = "РП10.С2.13_ФИД.COMM_FAILURE"

            items(48) = New Global.Opc.Da.Item()
            items(48).ItemName = "РП10.С2.14_ФИД.BAD_TIME_REPEAT"

            items(49) = New Global.Opc.Da.Item()
            items(49).ItemName = "РП10.С2.14_ФИД.COMM_FAILURE"

            items(50) = New Global.Opc.Da.Item()
            items(50).ItemName = "РП10.С2.15_ФИД.BAD_TIME_REPEAT"

            items(51) = New Global.Opc.Da.Item()
            items(51).ItemName = "РП10.С2.15_ФИД.COMM_FAILURE"

            items(52) = New Global.Opc.Da.Item()
            items(52).ItemName = "РП10.С2.16_ФИД.BAD_TIME_REPEAT"

            items(53) = New Global.Opc.Da.Item()
            items(53).ItemName = "РП10.С2.16_ФИД.COMM_FAILURE"

            items(54) = New Global.Opc.Da.Item()
            items(54).ItemName = "РП10.С2.17_ФИД.BAD_TIME_REPEAT"

            items(55) = New Global.Opc.Da.Item()
            items(55).ItemName = "РП10.С2.17_ФИД.COMM_FAILURE"

            'ПЛК дата-время
            items(56) = New Global.Opc.Da.Item()
            items(56).ItemName = "РП10.ШК1.ПЛК.HOUR"

            items(57) = New Global.Opc.Da.Item()
            items(57).ItemName = "РП10.ШК1.ПЛК.MINUTE"

            items(58) = New Global.Opc.Da.Item()
            items(58).ItemName = "РП10.ШК1.ПЛК.SECOND"

            items(59) = New Global.Opc.Da.Item()
            items(59).ItemName = "РП10.ШК1.ПЛК.DAY"

            items(60) = New Global.Opc.Da.Item()
            items(60).ItemName = "РП10.ШК1.ПЛК.MONTH"

            items(61) = New Global.Opc.Da.Item()
            items(61).ItemName = "РП10.ШК1.ПЛК.YEAR"

            '##############################################################

            items(62) = New Global.Opc.Da.Item()
            items(62).ItemName = "КТП_ЭБ.С1.ВВ1.COMM_FAILURE"

            items(63) = New Global.Opc.Da.Item()
            items(63).ItemName = "КТП_ЭБ.С2.ВВ2.COMM_FAILURE"

            items(64) = New Global.Opc.Da.Item()
            items(64).ItemName = "КТП_ЭБ.С1.СВ.COMM_FAILURE"

            items(65) = New Global.Opc.Da.Item()
            items(65).ItemName = "КТП_ЭБ.С1.АВ.COMM_FAILURE"

            items(66) = New Global.Opc.Da.Item()
            items(66).ItemName = "КТП_ЭБ.С1.БМЦС.COMM_FAILURE"

            items(67) = New Global.Opc.Da.Item()
            items(67).ItemName = "КТП_ЭБ.С1.ККУ.COMM_FAILURE"

            items(68) = New Global.Opc.Da.Item()
            items(68).ItemName = "КТП_ЭБ.С2.ККУ.COMM_FAILURE"

            items(69) = New Global.Opc.Da.Item()
            items(69).ItemName = "ЩПТ.НИПОМ.ПЛК.COMM_FAILURE"

            items(70) = New Global.Opc.Da.Item()
            items(70).ItemName = "ЩПТ.VAGO.ПЛК.COMM_FAILURE"


            'ПЛК дата-время
            items(71) = New Global.Opc.Da.Item()
            items(71).ItemName = "КЦ2.ШК2.ПЛК.HOUR"

            items(72) = New Global.Opc.Da.Item()
            items(72).ItemName = "КЦ2.ШК2.ПЛК.MINUTE"

            items(73) = New Global.Opc.Da.Item()
            items(73).ItemName = "КЦ2.ШК2.ПЛК.SECOND"

            items(74) = New Global.Opc.Da.Item()
            items(74).ItemName = "КЦ2.ШК2.ПЛК.DAY"

            items(75) = New Global.Opc.Da.Item()
            items(75).ItemName = "КЦ2.ШК2.ПЛК.MONTH"

            items(76) = New Global.Opc.Da.Item()
            items(76).ItemName = "КЦ2.ШК2.ПЛК.YEAR"

            '##############################################################
            'ПЛК дата-время
            items(77) = New Global.Opc.Da.Item()
            items(77).ItemName = "РЭБ.ШК3.ПЛК.HOUR"

            items(78) = New Global.Opc.Da.Item()
            items(78).ItemName = "РЭБ.ШК3.ПЛК.MINUTE"

            items(79) = New Global.Opc.Da.Item()
            items(79).ItemName = "РЭБ.ШК3.ПЛК.SECOND"

            items(80) = New Global.Opc.Da.Item()
            items(80).ItemName = "РЭБ.ШК3.ПЛК.DAY"

            items(81) = New Global.Opc.Da.Item()
            items(81).ItemName = "РЭБ.ШК3.ПЛК.MONTH"

            items(82) = New Global.Opc.Da.Item()
            items(82).ItemName = "РЭБ.ШК3.ПЛК.YEAR"

            items(83) = New Global.Opc.Da.Item()
            items(83).ItemName = "2БТП._.1.COMM_FAILURE"

            items(84) = New Global.Opc.Da.Item()
            items(84).ItemName = "2БТП._.2.COMM_FAILURE"

            items(85) = New Global.Opc.Da.Item()
            items(85).ItemName = "КТП_РЭБ.С1.ВВ1.COMM_FAILURE"

            items(86) = New Global.Opc.Da.Item()
            items(86).ItemName = "КТП_РЭБ.С1.АВ.COMM_FAILURE"

            items(87) = New Global.Opc.Da.Item()
            items(87).ItemName = "КТП_РЭБ.С1.СВ.COMM_FAILURE"

            items(88) = New Global.Opc.Da.Item()
            items(88).ItemName = "КТП_РЭБ.С2.ВВ2.COMM_FAILURE"

            items(89) = New Global.Opc.Da.Item()
            items(89).ItemName = "КТП_РЭБ.С1.БМЦС.COMM_FAILURE"

            items(90) = New Global.Opc.Da.Item()
            items(90).ItemName = "КТП_РЭБ.С1.ККУ.COMM_FAILURE"

            items(91) = New Global.Opc.Da.Item()
            items(91).ItemName = "КТП_РЭБ.С2.ККУ.COMM_FAILURE"

            items(92) = New Global.Opc.Da.Item()
            items(92).ItemName = "САУ_Т._.1.COMM_FAILURE"

            items(93) = New Global.Opc.Da.Item()
            items(93).ItemName = "САУ_В._._.COMM_FAILURE"


            '###########################################################
            items(94) = New Global.Opc.Da.Item()
            items(94).ItemName = "КТП_АВО.С1.ВВ1.COMM_FAILURE"

            items(95) = New Global.Opc.Da.Item()
            items(95).ItemName = "КТП_АВО.С2.ВВ2.COMM_FAILURE"

            items(96) = New Global.Opc.Da.Item()
            items(96).ItemName = "КТП_АВО.С1.СВ.COMM_FAILURE"

            items(97) = New Global.Opc.Da.Item()
            items(97).ItemName = "КТП_АВО.С1.ККУ.COMM_FAILURE"

            items(98) = New Global.Opc.Da.Item()
            items(98).ItemName = "КТП_АВО.С2.ККУ.COMM_FAILURE"


            '#############################################################
            'АСУ.ИБП.ШК1.OutOnBaterry
            'АСУ.ИБП.ШК2.OutOnBaterry
            'АСУ.ИБП.ШК3.OutOnBaterry
            'АСУ.ИБП.ШК4.OutOnBaterry
            'АСУ.ИБП.ШК_СЕРВ.OutOnBaterry

            items(99) = New Global.Opc.Da.Item()
            items(99).ItemName = "АСУ.ИБП.ШК1.OutOnBaterry"

            items(100) = New Global.Opc.Da.Item()
            items(100).ItemName = "АСУ.ИБП.ШК2.OutOnBaterry"

            items(101) = New Global.Opc.Da.Item()
            items(101).ItemName = "АСУ.ИБП.ШК3.OutOnBaterry"

            items(102) = New Global.Opc.Da.Item()
            items(102).ItemName = "АСУ.ИБП.ШК4.OutOnBaterry"

            items(103) = New Global.Opc.Da.Item()
            items(103).ItemName = "АСУ.ИБП.ШК_СЕРВ.OutOnBaterry"


            items = groupSTATUS.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = groupSTATUS.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Select Case results(0).Value

                        Case True
                            Me.Invoke(Sub() Label1.ForeColor = Color.Green)
                            Me.Invoke(Sub() Label5.Text = "А")
                            Me.Invoke(Sub() Label5.ForeColor = Color.Green)
                            Me.Invoke(Sub() Label5.Visible = True)
                            '  Me.Invoke(Sub() Label7.Text = results(0).Timestamp)
                        Case False
                            Me.Invoke(Sub() Label1.ForeColor = Color.Blue)
                            Me.Invoke(Sub() Label5.Text = "Р")
                            Me.Invoke(Sub() Label5.ForeColor = Color.Blue)
                            Me.Invoke(Sub() Label5.Visible = True)
                            ' Me.Invoke(Sub() Label7.Text = results(0).Timestamp)
                    End Select

                    Select Case results(1).Value

                        Case True
                            Me.Invoke(Sub() Label2.ForeColor = Color.Green)
                            Me.Invoke(Sub() Label6.Text = "А")
                            Me.Invoke(Sub() Label6.ForeColor = Color.Green)
                            Me.Invoke(Sub() Label6.Visible = True)
                            ' Me.Invoke(Sub() Label8.Text = results(1).Timestamp)
                        Case False
                            Me.Invoke(Sub() Label2.ForeColor = Color.Blue)
                            Me.Invoke(Sub() Label6.Text = "Р")
                            Me.Invoke(Sub() Label6.ForeColor = Color.Blue)
                            Me.Invoke(Sub() Label6.Visible = True)
                            ' Me.Invoke(Sub() Label8.Text = results(1).Timestamp)
                    End Select

                    Select Case results(2).Value

                        Case True

                            Me.Invoke(Sub() Label1.BackColor = Color.Red)

                        Case False
                            Me.Invoke(Sub() Label1.BackColor = IBP1.BackColor)

                    End Select

                    Select Case results(3).Value

                        Case True

                            Me.Invoke(Sub() Label2.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() Label2.BackColor = IBP1.BackColor)

                    End Select

                    Select Case results(4).Value

                        Case True

                            Me.Invoke(Sub() Label4.BackColor = Color.Red)
                            '  Me.Invoke(Sub() Label10.Text = results(4).Timestamp)
                        Case False
                            Me.Invoke(Sub() Label4.BackColor = Color.Transparent)
                            '  Me.Invoke(Sub() Label10.Text = results(4).Timestamp)
                    End Select

                    Select Case results(5).Value

                        Case True

                            Me.Invoke(Sub() Label3.BackColor = Color.Red)
                            '  Me.Invoke(Sub() Label9.Text = results(5).Timestamp)
                        Case False
                            Me.Invoke(Sub() Label3.BackColor = IBP1.BackColor)
                            '  Me.Invoke(Sub() Label9.Text = results(5).Timestamp)
                    End Select

                    Select Case results(6).Value

                        Case True

                            Me.Invoke(Sub() LPLK1.BorderColor = Color.Red)

                        Case False
                            Me.Invoke(Sub() LPLK1.BorderColor = Color.Green)

                    End Select

                    Select Case results(7).Value

                        Case True

                            Me.Invoke(Sub() LPLK2.BorderColor = Color.Red)

                        Case False
                            Me.Invoke(Sub() LPLK2.BorderColor = Color.Green)

                    End Select

                    Select Case results(8).Value

                        Case True

                            Me.Invoke(Sub() LPLK3.BorderColor = Color.Red)

                        Case False
                            Me.Invoke(Sub() LPLK3.BorderColor = Color.Green)

                    End Select


                    Select Case results(9).Quality.ToString

                        Case "good"

                            Select Case results(9).Value
                                Case True
                                    Me.Invoke(Sub() Label15.Visible = True)
                                Case False
                                    Me.Invoke(Sub() Label15.Visible = False)
                            End Select

                        Case Else

                            Me.Invoke(Sub() Label15.Visible = True)
                    End Select


                    Select Case results(10).Quality.ToString

                        Case "good"

                            Select Case results(10).Value
                                Case True
                                    Me.Invoke(Sub() Label16.Visible = True)
                                Case False
                                    Me.Invoke(Sub() Label16.Visible = False)
                            End Select

                        Case Else

                            Me.Invoke(Sub() Label16.Visible = True)
                    End Select

                   
                    Select Case results(11).Quality.ToString

                        Case "good"

                            Select Case results(11).Value
                                Case True
                                    Me.Invoke(Sub() Label18.Visible = True)
                                Case False
                                    Me.Invoke(Sub() Label18.Visible = False)
                            End Select

                        Case Else

                            Me.Invoke(Sub() Label18.Visible = True)
                    End Select

                    Me.Invoke(Sub() IBP1.Text = results(12).Value & "%")
                    Me.Invoke(Sub() IBP2.Text = results(13).Value & "%")
                    Me.Invoke(Sub() IBP3.Text = results(14).Value & "%")
                    Me.Invoke(Sub() IBP4.Text = results(15).Value & "%")
                    Me.Invoke(Sub() IBP5.Text = results(16).Value & "%")


                    'IBP1
                    Select Case results(17).Value
                        Case True
                            Me.Invoke(Sub() LineShape1.BorderColor = Color.Red)
                            Me.Invoke(Sub() LineShape2.BorderColor = Color.Red)
                            Me.Invoke(Sub() LineShape3.BorderColor = Color.Red)
                            Me.Invoke(Sub() LineShape4.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() LineShape1.BorderColor = Color.Green)
                            Me.Invoke(Sub() LineShape2.BorderColor = Color.Green)
                            Me.Invoke(Sub() LineShape3.BorderColor = Color.Green)
                            Me.Invoke(Sub() LineShape4.BorderColor = Color.Green)
                    End Select

                    Select Case results(18).Value
                        Case True
                            Me.Invoke(Sub() libp1.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() libp1.BorderColor = Color.Green)
                    End Select
                    Select Case results(19).Value
                        Case True
                            Me.Invoke(Sub() libp2.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() libp2.BorderColor = Color.Green)
                    End Select
                    Select Case results(20).Value
                        Case True
                            Me.Invoke(Sub() libp3.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() libp3.BorderColor = Color.Green)
                    End Select
                    Select Case results(21).Value
                        Case True
                            Me.Invoke(Sub() libp2.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() libp2.BorderColor = Color.Green)
                    End Select


                    Me.Invoke(Sub() Label8.Text = results(22).Timestamp)
                    Select Case results(23).Value
                        Case True
                            Me.Invoke(Sub() lrp10v1.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lrp10v1.BorderColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label10.Text = results(24).Timestamp)
                    Select Case results(25).Value
                        Case True
                            Me.Invoke(Sub() lrp10v1shtn.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lrp10v1shtn.BorderColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label12.Text = results(26).Timestamp)

                    Select Case results(27).Value
                        Case True
                            Me.Invoke(Sub() lrp10v1f3.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lrp10v1f3.BorderColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label14.Text = results(28).Timestamp)
                    Select Case results(29).Value
                        Case True
                            Me.Invoke(Sub() lrp10v1f4.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lrp10v1f4.BorderColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label19.Text = results(30).Timestamp)
                    Select Case results(31).Value
                        Case True
                            Me.Invoke(Sub() lrp10v1f5.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lrp10v1f5.BorderColor = Color.Green)
                    End Select



                    Me.Invoke(Sub() Label21.Text = results(32).Timestamp)
                    Select Case results(33).Value
                        Case True
                            Me.Invoke(Sub() lrp10v1f6.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lrp10v1f6.BorderColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label22.Text = results(34).Timestamp)
                    Select Case results(35).Value
                        Case True
                            Me.Invoke(Sub() lrp10v1f7.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lrp10v1f7.BorderColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label24.Text = results(36).Timestamp)
                    Select Case results(37).Value
                        Case True
                            Me.Invoke(Sub() lrp10v1f8.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lrp10v1f8.BorderColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label26.Text = results(38).Timestamp)
                    Select Case results(39).Value
                        Case True
                            Me.Invoke(Sub() lrp10v1f9.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lrp10v1f9.BorderColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label36.Text = results(40).Timestamp)
                    Select Case results(41).Value
                        Case True
                            Me.Invoke(Sub() lrp10v2f10.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lrp10v2f10.BorderColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label38.Text = results(42).Timestamp)
                    Select Case results(43).Value
                        Case True
                            Me.Invoke(Sub() lrp10v2f11.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lrp10v2f11.BorderColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label40.Text = results(44).Timestamp)
                    Select Case results(45).Value
                        Case True
                            Me.Invoke(Sub() lrp10v2f12.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lrp10v2f12.BorderColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label42.Text = results(46).Timestamp)
                    Select Case results(47).Value
                        Case True
                            Me.Invoke(Sub() lrp10v2f13.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lrp10v2f13.BorderColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label28.Text = results(48).Timestamp)
                    Select Case results(49).Value
                        Case True
                            Me.Invoke(Sub() lrp10v2f14.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lrp10v2f14.BorderColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label30.Text = results(50).Timestamp)
                    Select Case results(51).Value
                        Case True
                            Me.Invoke(Sub() lrp10v2f15.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lrp10v2f15.BorderColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label32.Text = results(52).Timestamp)
                    Select Case results(53).Value
                        Case True
                            Me.Invoke(Sub() lrp10v2f16.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lrp10v2f16.BorderColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label34.Text = results(54).Timestamp)
                    Select Case results(55).Value
                        Case True
                            Me.Invoke(Sub() lrp10v2f17.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lrp10v2f17.BorderColor = Color.Green)
                    End Select


                    Me.Invoke(Sub() Label44.Text = results(56).Value & ":" & results(57).Value & ":" & results(58).Value & " " & results(59).Value & "/" & results(60).Value & "/" & results(61).Value)
                    'Label44



                    Select Case results(62).Value
                        Case True
                            Me.Invoke(Sub() lktpEbVV1.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpEbVV1.BorderColor = Color.Green)
                    End Select

                    Select Case results(63).Value
                        Case True
                            Me.Invoke(Sub() lktpEbVV2.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpEbVV2.BorderColor = Color.Green)
                    End Select

                    Select Case results(64).Value
                        Case True
                            Me.Invoke(Sub() lktpEbSV.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpEbSV.BorderColor = Color.Green)
                    End Select

                    Select Case results(65).Value
                        Case True
                            Me.Invoke(Sub() lktpEbAV.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpEbAV.BorderColor = Color.Green)
                    End Select

                    Select Case results(66).Value
                        Case True
                            Me.Invoke(Sub() lktpEbBMCS.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpEbBMCS.BorderColor = Color.Green)
                    End Select

                    Select Case results(67).Value
                        Case True
                            Me.Invoke(Sub() lktpEbKKU1.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpEbKKU1.BorderColor = Color.Green)
                    End Select

                    Select Case results(68).Value
                        Case True
                            Me.Invoke(Sub() lktpEbKKU2.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpEbKKU2.BorderColor = Color.Green)
                    End Select

                    Select Case results(69).Value
                        Case True
                            Me.Invoke(Sub() lktpEbNIPOM.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpEbNIPOM.BorderColor = Color.Green)
                    End Select

                    Select Case results(70).Value
                        Case True
                            Me.Invoke(Sub() lktpEbVAGO.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpEbVAGO.BorderColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label55.Text = results(71).Value & ":" & results(72).Value & ":" & results(73).Value & " " & results(74).Value & "/" & results(75).Value & "/" & results(76).Value)


                    Me.Invoke(Sub() Label68.Text = results(77).Value & ":" & results(78).Value & ":" & results(79).Value & " " & results(80).Value & "/" & results(81).Value & "/" & results(82).Value)

                    Select Case results(83).Value
                        Case True
                            Me.Invoke(Sub() lktpREb2btp1.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpREb2btp1.BorderColor = Color.Green)
                    End Select

                    Select Case results(84).Value
                        Case True
                            Me.Invoke(Sub() lktpREb2btp2.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpREb2btp2.BorderColor = Color.Green)
                    End Select

                    Select Case results(85).Value
                        Case True
                            Me.Invoke(Sub() lktpREbVV1.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpREbVV1.BorderColor = Color.Green)
                    End Select

                    Select Case results(86).Value
                        Case True
                            Me.Invoke(Sub() lktpREbAV.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpREbAV.BorderColor = Color.Green)
                    End Select

                    Select Case results(87).Value
                        Case True
                            Me.Invoke(Sub() lktpREbSV.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpREbSV.BorderColor = Color.Green)
                    End Select

                    Select Case results(88).Value
                        Case True
                            Me.Invoke(Sub() lktpREbVV2.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpREbVV2.BorderColor = Color.Green)
                    End Select

                    Select Case results(89).Value
                        Case True
                            Me.Invoke(Sub() lktpREbBMCS.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpREbBMCS.BorderColor = Color.Green)
                    End Select

                    Select Case results(90).Value
                        Case True
                            Me.Invoke(Sub() lktpREbKKU1.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpREbKKU1.BorderColor = Color.Green)
                    End Select

                    Select Case results(91).Value
                        Case True
                            Me.Invoke(Sub() lktpREbKKU2.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpREbKKU2.BorderColor = Color.Green)
                    End Select
                    Select Case results(92).Value
                        Case True
                            Me.Invoke(Sub() lktpREbsaut.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpREbsaut.BorderColor = Color.Green)
                    End Select

                    Select Case results(93).Value
                        Case True
                            Me.Invoke(Sub() lktpREbsauv.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpREbsauv.BorderColor = Color.Green)
                    End Select


                    'lktpAVOVV1
                    Select Case results(94).Value
                        Case True
                            Me.Invoke(Sub() lktpAVOVV1.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpAVOVV1.BorderColor = Color.Green)
                    End Select

                    Select Case results(95).Value
                        Case True
                            Me.Invoke(Sub() lktpAVOVV2.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpAVOVV2.BorderColor = Color.Green)
                    End Select

                    Select Case results(96).Value
                        Case True
                            Me.Invoke(Sub() lktpAVOSV.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpAVOSV.BorderColor = Color.Green)
                    End Select

                    Select Case results(97).Value
                        Case True
                            Me.Invoke(Sub() lktpAVOKKU1.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpAVOKKU1.BorderColor = Color.Green)
                    End Select

                    Select Case results(98).Value
                        Case True
                            Me.Invoke(Sub() lktpAVOKKU2.BorderColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lktpAVOKKU2.BorderColor = Color.Green)
                    End Select

                    Select Case results(99).Value
                        Case True
                            Me.Invoke(Sub() IBP_S1_220.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() IBP_S1_220.BackColor = Color.Transparent)
                    End Select

                    Select Case results(100).Value
                        Case True
                            Me.Invoke(Sub() IBP_S2_220.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() IBP_S2_220.BackColor = Color.Transparent)
                    End Select

                    Select Case results(101).Value
                        Case True
                            Me.Invoke(Sub() IBP_S3_220.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() IBP_S3_220.BackColor = Color.Transparent)
                    End Select

                    Select Case results(102).Value
                        Case True
                            Me.Invoke(Sub() IBP_S4_220.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() IBP_S4_220.BackColor = Color.Transparent)
                    End Select

                    Select Case results(103).Value
                        Case True
                            Me.Invoke(Sub() IBP_S5_220.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() IBP_S5_220.BackColor = Color.Transparent)
                    End Select


                Next


                Threading.Thread.Sleep(MSPEED - 50)
            Loop

        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

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

            'y~u$U6wN


        End While

        rs.Close()
        rs = Nothing

        Dim sOpisanie(sCOUNT) As String

        SALARM = False
        Try
ARG:
            groupState_Alarmt.Name = "ALARMs"
            groupState_Alarmt.Active = True
            groupState_Alarmt.UpdateRate = 60000

            group_Alarmt = DirectCast(m_server.CreateSubscription(groupState_Alarmt), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(sCOUNT - 1) {}

            'sSQL = "SELECT Name FROM dbo.[Vars] where Label like '%Ава%'and label not like 'Квитирование%' or Label like 'неиспр%' or Label like 'Потеря%' or Label like '%не в норме%' or Label like '%низ%' or Label like '%отказ%' or Label like '%повыш%' or Label like '%сбой%' or Label like '%сраб%' or Label like '%отключение%' or Label like '%пере%' or Label like '%неопред%' or Label like '%пониж%'"
            sSQL = "SELECT * FROM Vars"
            'cmd = New OleDbCommand(sSQL, DBASUE)
            cmd = New OleDbCommand(sSQL, DB7)
            rs = cmd.ExecuteReader

            Dim intCount2 As Decimal = 0
            While rs.Read

                items(intCount2) = New Global.Opc.Da.Item()
                items(intCount2).ItemName = rs.Item("Name")
                sOpisanie(intCount2) = rs.Item("Label")

                intCount2 = intCount2 + 1
               
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
                Dim intCount As Integer = 0

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
                                    Me.Invoke(Sub() LV_REPORT_ALARM.Items(CInt(intCount)).BackColor = Color.Red)

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
                    ' Me.Invoke(Sub() Me.Visible = False)
                    Me.Invoke(Sub() SALARM = False)
                Else
                    ' Me.Invoke(Sub() Me.Visible = True)
                    Me.Invoke(Sub() SALARM = True)
                End If

                Threading.Thread.Sleep(60000)

            Loop

        Catch ex As Exception
            'GoTo ARG
            'Print(Err.Description)
            'Me.Invoke(Sub() Print(ex.Message))
        End Try

    End Sub

    Private Sub LV_REPORT_ALARM_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs)

        SORTING_LV(LV_REPORT_ALARM, e)

    End Sub

    Private Sub IBP_S1_220_Click(sender As System.Object, e As System.EventArgs) Handles IBP_S1_220.Click

        Dim frmibp As frmibp = New frmibp
        frmibp.Text = "ИБП шкафа №1"
        frmibp.Show()

    End Sub

    Private Sub IBP_S2_220_Click(sender As System.Object, e As System.EventArgs) Handles IBP_S2_220.Click
        Dim frmibp As frmibp = New frmibp
        frmibp.Text = "ИБП шкафа №2"
        frmibp.Show()
    End Sub

    Private Sub IBP_S3_220_Click(sender As System.Object, e As System.EventArgs) Handles IBP_S3_220.Click
        Dim frmibp As frmibp = New frmibp
        frmibp.Text = "ИБП шкафа №3"
        frmibp.Show()
    End Sub

    Private Sub IBP_S4_220_Click(sender As System.Object, e As System.EventArgs) Handles IBP_S4_220.Click
        Dim frmibp As frmibp = New frmibp
        frmibp.Text = "ИБП шкафа №4"
        frmibp.Show()
    End Sub

    Private Sub IBP_S5_220_Click(sender As System.Object, e As System.EventArgs) Handles IBP_S5_220.Click
        Dim frmibp As frmibp = New frmibp
        frmibp.Text = "ИБП шкафа сереров"
        frmibp.Show()
    End Sub

    Private Sub Label75_Click(sender As System.Object, e As System.EventArgs) Handles Label75.Click
        Dim frmPLC As frmPLC = New frmPLC
        frmPLC.Text = "РП10Кв ПЛК"
        frmPLC.Show()

    End Sub

    Private Sub Label77_Click(sender As System.Object, e As System.EventArgs) Handles Label77.Click

        Dim frmPLC As frmPLC = New frmPLC
        frmPLC.Text = "КТП РЭБ ПЛК"
        frmPLC.Show()

    End Sub

    Private Sub Label76_Click(sender As System.Object, e As System.EventArgs) Handles Label76.Click

        Dim frmPLC As frmPLC = New frmPLC
        frmPLC.Text = "КТП ЭБ ПЛК"
        frmPLC.Show()

    End Sub
End Class