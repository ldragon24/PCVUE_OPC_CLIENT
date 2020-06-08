Public Class frmOHCU
    Dim T_OHCU As System.Threading.Thread

    Private Sub frmOHCU_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        m_server.CancelSubscription(group_OCHU)
        T_OHCU.Abort()

    End Sub

    Private Sub frmOHCU_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Select Case btn_SAUV.Text

            Case "Старт"

                btn_SAUV.Text = "Стоп"
                T_OHCU = New System.Threading.Thread(AddressOf T_OHCU_START)
                T_OHCU.Start()

            Case "Стоп"

                btn_SAUV.Text = "Старт"
                m_server.CancelSubscription(group_OCHU)
                T_OHCU.Abort()

        End Select

    End Sub


    Sub T_OHCU_START()

        Try

ARG:
            groupState_OCHU.Name = "OCHU"
            groupState_OCHU.Active = True
            groupState_OCHU.UpdateRate = MSPEED

            group_OCHU = DirectCast(m_server.CreateSubscription(groupState_OCHU), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(99) {}

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "КТП_ЭБ.С1.QF13.CLOSE"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "КТП_ЭБ.С1.QF13.DOC"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "ОЩСУ.С1.QF1.CLOSE"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "ОЩСУ.С1.QF1.DOC"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "ОЩСУ.С1.QF4.CLOSE"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "ОЩСУ.С1.QF4.DOC"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "ОЩСУ.С1.QF6.CLOSE"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "ОЩСУ.С1.QF6.DOC"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "ОЩСУ.С1.QF7.CLOSE"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "ОЩСУ.С1.QF7.DOC"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "ОЩСУ.С1.QF10.CLOSE"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "ОЩСУ.С1.QF10.DOC"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "ОЩСУ.С1.QF11.CLOSE"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "ОЩСУ.С1.QF11.DOC"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "ОЩСУ.С1.QF14.CLOSE"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "ОЩСУ.С1.QF14.DOC"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "ОЩСУ.С1.QF17.CLOSE"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "ОЩСУ.С1.QF17.DOC"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "ОЩСУ.С1.QF18.CLOSE"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "ОЩСУ.С1.QF18.DOC"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "ОЩСУ.С1.QF19.CLOSE"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "ОЩСУ.С1.QF19.DOC"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "ОЩСУ.С1.QF22.CLOSE"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "ОЩСУ.С1.QF22.DOC"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "ОЩСУ.С1.QF23.CLOSE"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "ОЩСУ.С1.QF23.DOC"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "ОЩСУ.С1.QF24.CLOSE"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "ОЩСУ.С1.QF24.DOC"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "ОЩСУ.С1.QF25.CLOSE"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "ОЩСУ.С1.QF25.DOC"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "ОЩСУ.С1.QF26.CLOSE"

            items(31) = New Global.Opc.Da.Item()
            items(31).ItemName = "ОЩСУ.С1.QF26.DOC"

            items(32) = New Global.Opc.Da.Item()
            items(32).ItemName = "ОЩСУ.С1.QF3.CLOSE"

            items(33) = New Global.Opc.Da.Item()
            items(33).ItemName = "ОЩСУ.С1.QF3.DOC"

            '#########################################################

            items(34) = New Global.Opc.Da.Item()
            items(34).ItemName = "КТП_ЭБ.С2.QF23.CLOSE"

            items(35) = New Global.Opc.Da.Item()
            items(35).ItemName = "КТП_ЭБ.С2.QF23.DOC"


            items(36) = New Global.Opc.Da.Item()
            items(36).ItemName = "ОЩСУ.С2.QF2.CLOSE"

            items(37) = New Global.Opc.Da.Item()
            items(37).ItemName = "ОЩСУ.С2.QF2.DOC"

            items(38) = New Global.Opc.Da.Item()
            items(38).ItemName = "ОЩСУ.С1.U.U_OK"

            items(39) = New Global.Opc.Da.Item()
            items(39).ItemName = "ОЩСУ.С2.U.U_OK"

            items(40) = New Global.Opc.Da.Item()
            items(40).ItemName = "ОЩСУ.С2.QF56.CLOSE"

            items(41) = New Global.Opc.Da.Item()
            items(41).ItemName = "ОЩСУ.С2.QF56.DOC"

            items(42) = New Global.Opc.Da.Item()
            items(42).ItemName = "ОЩСУ.С2.QF57.CLOSE"

            items(43) = New Global.Opc.Da.Item()
            items(43).ItemName = "ОЩСУ.С2.QF57.DOC"

            items(44) = New Global.Opc.Da.Item()
            items(44).ItemName = "ОЩСУ.С2.QF60.CLOSE"

            items(45) = New Global.Opc.Da.Item()
            items(45).ItemName = "ОЩСУ.С2.QF60.DOC"

            items(46) = New Global.Opc.Da.Item()
            items(46).ItemName = "ОЩСУ.С2.QF61.CLOSE"

            items(47) = New Global.Opc.Da.Item()
            items(47).ItemName = "ОЩСУ.С2.QF61.DOC"

            items(48) = New Global.Opc.Da.Item()
            items(48).ItemName = "ОЩСУ.С2.QF64.CLOSE"

            items(49) = New Global.Opc.Da.Item()
            items(49).ItemName = "ОЩСУ.С2.QF64.DOC"

            items(50) = New Global.Opc.Da.Item()
            items(50).ItemName = "ОЩСУ.С2.QF65.CLOSE"

            items(51) = New Global.Opc.Da.Item()
            items(51).ItemName = "ОЩСУ.С2.QF65.DOC"

            items(52) = New Global.Opc.Da.Item()
            items(52).ItemName = "ОЩСУ.С2.QF68.CLOSE"

            items(53) = New Global.Opc.Da.Item()
            items(53).ItemName = "ОЩСУ.С2.QF68.DOC"

            items(54) = New Global.Opc.Da.Item()
            items(54).ItemName = "ОЩСУ.С2.QF70.CLOSE"

            items(55) = New Global.Opc.Da.Item()
            items(55).ItemName = "ОЩСУ.С2.QF70.DOC"

            items(56) = New Global.Opc.Da.Item()
            items(56).ItemName = "ОЩСУ.С2.QF72.CLOSE"

            items(57) = New Global.Opc.Da.Item()
            items(57).ItemName = "ОЩСУ.С2.QF72.DOC"

            items(58) = New Global.Opc.Da.Item()
            items(58).ItemName = "ОЩСУ.С2.QF76.CLOSE"

            items(59) = New Global.Opc.Da.Item()
            items(59).ItemName = "ОЩСУ.С2.QF76.DOC"

            items(60) = New Global.Opc.Da.Item()
            items(60).ItemName = "ОЩСУ.С2.QF77.CLOSE"

            items(61) = New Global.Opc.Da.Item()
            items(61).ItemName = "ОЩСУ.С2.QF77.DOC"

            items(62) = New Global.Opc.Da.Item()
            items(62).ItemName = "ОЩСУ.С2.QF78.CLOSE"

            items(63) = New Global.Opc.Da.Item()
            items(63).ItemName = "ОЩСУ.С2.QF78.DOC"

            items(64) = New Global.Opc.Da.Item()
            items(64).ItemName = "ОЩСУ.С2.QF79.CLOSE"

            items(65) = New Global.Opc.Da.Item()
            items(65).ItemName = "ОЩСУ.С2.QF79.DOC"

            items(66) = New Global.Opc.Da.Item()
            items(66).ItemName = "ОЩСУ.С2.QF80.CLOSE"

            items(67) = New Global.Opc.Da.Item()
            items(67).ItemName = "ОЩСУ.С2.QF80.DOC"

            items(68) = New Global.Opc.Da.Item()
            items(68).ItemName = "ОЩСУ.С2.QF2.VOLT_COLOR"

            items(69) = New Global.Opc.Da.Item()
            items(69).ItemName = "ОЩСУ.С2.QF56.VOLT_COLOR"

            items(70) = New Global.Opc.Da.Item()
            items(70).ItemName = "ОЩСУ.С2.QF57.VOLT_COLOR"

            items(71) = New Global.Opc.Da.Item()
            items(71).ItemName = "ОЩСУ.С2.QF60.VOLT_COLOR"

            items(72) = New Global.Opc.Da.Item()
            items(72).ItemName = "ОЩСУ.С2.QF61.VOLT_COLOR"

            items(73) = New Global.Opc.Da.Item()
            items(73).ItemName = "ОЩСУ.С2.QF64.VOLT_COLOR"

            items(74) = New Global.Opc.Da.Item()
            items(74).ItemName = "ОЩСУ.С2.QF65.VOLT_COLOR"

            items(75) = New Global.Opc.Da.Item()
            items(75).ItemName = "ОЩСУ.С2.QF68.VOLT_COLOR"

            items(76) = New Global.Opc.Da.Item()
            items(76).ItemName = "ОЩСУ.С2.QF70.VOLT_COLOR"

            items(77) = New Global.Opc.Da.Item()
            items(77).ItemName = "ОЩСУ.С2.QF72.VOLT_COLOR"

            items(78) = New Global.Opc.Da.Item()
            items(78).ItemName = "ОЩСУ.С2.QF76.VOLT_COLOR"

            items(79) = New Global.Opc.Da.Item()
            items(79).ItemName = "ОЩСУ.С2.QF77.VOLT_COLOR"

            items(80) = New Global.Opc.Da.Item()
            items(80).ItemName = "ОЩСУ.С2.QF78.VOLT_COLOR"

            items(81) = New Global.Opc.Da.Item()
            items(81).ItemName = "ОЩСУ.С2.QF79.VOLT_COLOR"

            items(82) = New Global.Opc.Da.Item()
            items(82).ItemName = "ОЩСУ.С2.QF80.VOLT_COLOR"

            items(83) = New Global.Opc.Da.Item()
            items(83).ItemName = "КТП_ЭБ.С2.QF23.VOLT_COLOR"

            items(84) = New Global.Opc.Da.Item()
            items(84).ItemName = "КТП_ЭБ.С1.QF13.VOLT_COLOR"

            items(85) = New Global.Opc.Da.Item()
            items(85).ItemName = "ОЩСУ.С1.QF1.VOLT_COLOR"

            items(86) = New Global.Opc.Da.Item()
            items(86).ItemName = "ОЩСУ.С1.QF4.VOLT_COLOR"

            items(87) = New Global.Opc.Da.Item()
            items(87).ItemName = "ОЩСУ.С1.QF6.VOLT_COLOR"

            items(88) = New Global.Opc.Da.Item()
            items(88).ItemName = "ОЩСУ.С1.QF7.VOLT_COLOR"

            items(89) = New Global.Opc.Da.Item()
            items(89).ItemName = "ОЩСУ.С1.QF10.VOLT_COLOR"

            items(90) = New Global.Opc.Da.Item()
            items(90).ItemName = "ОЩСУ.С1.QF11.VOLT_COLOR"

            items(91) = New Global.Opc.Da.Item()
            items(91).ItemName = "ОЩСУ.С1.QF14.VOLT_COLOR"

            items(92) = New Global.Opc.Da.Item()
            items(92).ItemName = "ОЩСУ.С1.QF17.VOLT_COLOR"

            items(93) = New Global.Opc.Da.Item()
            items(93).ItemName = "ОЩСУ.С1.QF18.VOLT_COLOR"

            items(94) = New Global.Opc.Da.Item()
            items(94).ItemName = "ОЩСУ.С1.QF19.VOLT_COLOR"

            items(95) = New Global.Opc.Da.Item()
            items(95).ItemName = "ОЩСУ.С1.QF22.VOLT_COLOR"

            items(96) = New Global.Opc.Da.Item()
            items(96).ItemName = "ОЩСУ.С1.QF23.VOLT_COLOR"

            items(97) = New Global.Opc.Da.Item()
            items(97).ItemName = "ОЩСУ.С1.QF24.VOLT_COLOR"

            items(98) = New Global.Opc.Da.Item()
            items(98).ItemName = "ОЩСУ.С1.QF25.VOLT_COLOR"

            items(99) = New Global.Opc.Da.Item()
            items(99).ItemName = "ОЩСУ.С1.QF26.VOLT_COLOR"

            items = group_OCHU.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_OCHU.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    '########################################################################
                    Select Case results(1).Value

                        Case False

                            Me.Invoke(Sub() lblQF13.Visible = False)

                            Select Case results(0).Value

                                Case True
                                    Me.Invoke(Sub() QF13_vkl.Visible = True)
                                    Me.Invoke(Sub() QF13_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF13_vkl.Visible = False)
                                    Me.Invoke(Sub() QF13_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF13_vykl.Visible = False)
                            Me.Invoke(Sub() QF13_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF13.Visible = True)
                    End Select

                    '#############################################################
                    Select Case results(3).Value

                        Case False

                            Me.Invoke(Sub() lblQF1.Visible = False)

                            Select Case results(2).Value

                                Case True
                                    Me.Invoke(Sub() QF1_vkl.Visible = True)
                                    Me.Invoke(Sub() QF1_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF1_vkl.Visible = False)
                                    Me.Invoke(Sub() QF1_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF1_vykl.Visible = False)
                            Me.Invoke(Sub() QF1_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF1.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(5).Value

                        Case False

                            Me.Invoke(Sub() lblQF4.Visible = False)

                            Select Case results(4).Value

                                Case True
                                    Me.Invoke(Sub() QF4_vkl.Visible = True)
                                    Me.Invoke(Sub() QF4_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF4_vkl.Visible = False)
                                    Me.Invoke(Sub() QF4_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF4_vykl.Visible = False)
                            Me.Invoke(Sub() QF4_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF4.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(7).Value

                        Case False

                            Me.Invoke(Sub() lblQF6.Visible = False)

                            Select Case results(6).Value

                                Case True
                                    Me.Invoke(Sub() QF6_vkl.Visible = True)
                                    Me.Invoke(Sub() QF6_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF6_vkl.Visible = False)
                                    Me.Invoke(Sub() QF6_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF6_vykl.Visible = False)
                            Me.Invoke(Sub() QF6_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF6.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(9).Value

                        Case False

                            Me.Invoke(Sub() lblQF7.Visible = False)

                            Select Case results(8).Value

                                Case True
                                    Me.Invoke(Sub() QF7_vkl.Visible = True)
                                    Me.Invoke(Sub() QF7_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF7_vkl.Visible = False)
                                    Me.Invoke(Sub() QF7_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF7_vykl.Visible = False)
                            Me.Invoke(Sub() QF7_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF7.Visible = True)
                    End Select

                    '#############################################################
                    Select Case results(11).Value

                        Case False

                            Me.Invoke(Sub() lblQF10.Visible = False)

                            Select Case results(10).Value

                                Case True
                                    Me.Invoke(Sub() QF10_vkl.Visible = True)
                                    Me.Invoke(Sub() QF10_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF10_vkl.Visible = False)
                                    Me.Invoke(Sub() QF10_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF10_vykl.Visible = False)
                            Me.Invoke(Sub() QF10_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF10.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(13).Value

                        Case False

                            Me.Invoke(Sub() lblQF11.Visible = False)

                            Select Case results(12).Value

                                Case True
                                    Me.Invoke(Sub() QF11_vkl.Visible = True)
                                    Me.Invoke(Sub() QF11_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF11_vkl.Visible = False)
                                    Me.Invoke(Sub() QF11_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF11_vykl.Visible = False)
                            Me.Invoke(Sub() QF11_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF11.Visible = True)
                    End Select

                    '#############################################################
                    Select Case results(15).Value

                        Case False

                            Me.Invoke(Sub() lblQF14.Visible = False)

                            Select Case results(14).Value

                                Case True
                                    Me.Invoke(Sub() QF14_vkl.Visible = True)
                                    Me.Invoke(Sub() QF14_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF14_vkl.Visible = False)
                                    Me.Invoke(Sub() QF14_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF14_vykl.Visible = False)
                            Me.Invoke(Sub() QF14_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF14.Visible = True)
                    End Select

                    '#############################################################
                    Select Case results(17).Value

                        Case False

                            Me.Invoke(Sub() lblQF17.Visible = False)

                            Select Case results(16).Value

                                Case True
                                    Me.Invoke(Sub() QF17_vkl.Visible = True)
                                    Me.Invoke(Sub() QF17_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF17_vkl.Visible = False)
                                    Me.Invoke(Sub() QF17_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF17_vykl.Visible = False)
                            Me.Invoke(Sub() QF17_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF17.Visible = True)
                    End Select

                    '#############################################################
                    Select Case results(19).Value

                        Case False

                            Me.Invoke(Sub() lblQF18.Visible = False)

                            Select Case results(18).Value

                                Case True
                                    Me.Invoke(Sub() QF18_vkl.Visible = True)
                                    Me.Invoke(Sub() QF18_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF18_vkl.Visible = False)
                                    Me.Invoke(Sub() QF18_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF18_vykl.Visible = False)
                            Me.Invoke(Sub() QF18_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF18.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(21).Value

                        Case False

                            Me.Invoke(Sub() lblQF19.Visible = False)

                            Select Case results(20).Value

                                Case True
                                    Me.Invoke(Sub() QF19_vkl.Visible = True)
                                    Me.Invoke(Sub() QF19_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF19_vkl.Visible = False)
                                    Me.Invoke(Sub() QF19_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF19_vykl.Visible = False)
                            Me.Invoke(Sub() QF19_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF19.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(23).Value

                        Case False

                            Me.Invoke(Sub() lblQF22.Visible = False)

                            Select Case results(22).Value

                                Case True
                                    Me.Invoke(Sub() QF22_vkl.Visible = True)
                                    Me.Invoke(Sub() QF22_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF22_vkl.Visible = False)
                                    Me.Invoke(Sub() QF22_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF22_vykl.Visible = False)
                            Me.Invoke(Sub() QF22_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF22.Visible = True)
                    End Select

                    '#############################################################
                    Select Case results(25).Value

                        Case False

                            Me.Invoke(Sub() lblQF23.Visible = False)

                            Select Case results(24).Value

                                Case True
                                    Me.Invoke(Sub() QF23_vkl.Visible = True)
                                    Me.Invoke(Sub() QF23_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF23_vkl.Visible = False)
                                    Me.Invoke(Sub() QF23_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF23_vykl.Visible = False)
                            Me.Invoke(Sub() QF23_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF23.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(27).Value

                        Case False

                            Me.Invoke(Sub() lblQF24.Visible = False)

                            Select Case results(26).Value

                                Case True
                                    Me.Invoke(Sub() QF24_vkl.Visible = True)
                                    Me.Invoke(Sub() QF24_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF24_vkl.Visible = False)
                                    Me.Invoke(Sub() QF24_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF24_vykl.Visible = False)
                            Me.Invoke(Sub() QF24_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF24.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(29).Value

                        Case False

                            Me.Invoke(Sub() lblQF25.Visible = False)

                            Select Case results(28).Value

                                Case True
                                    Me.Invoke(Sub() QF25_vkl.Visible = True)
                                    Me.Invoke(Sub() QF25_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF25_vkl.Visible = False)
                                    Me.Invoke(Sub() QF25_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF25_vykl.Visible = False)
                            Me.Invoke(Sub() QF25_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF25.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(31).Value

                        Case False

                            Me.Invoke(Sub() lblQF26.Visible = False)

                            Select Case results(30).Value

                                Case True
                                    Me.Invoke(Sub() QF26_vkl.Visible = True)
                                    Me.Invoke(Sub() QF26_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF26_vkl.Visible = False)
                                    Me.Invoke(Sub() QF26_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF26_vykl.Visible = False)
                            Me.Invoke(Sub() QF26_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF26.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(33).Value

                        Case False

                            Me.Invoke(Sub() lblQF3.Visible = False)

                            Select Case results(32).Value

                                Case True
                                    Me.Invoke(Sub() QF3_vkl.Visible = True)
                                    Me.Invoke(Sub() QF3_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF3_vkl.Visible = False)
                                    Me.Invoke(Sub() QF3_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF3_vykl.Visible = False)
                            Me.Invoke(Sub() QF3_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF3.Visible = True)
                    End Select
                    '#############################################################
                    '#############################################################
                    '#############################################################
                    Select Case results(35).Value

                        Case False

                            Me.Invoke(Sub() lblQF23_.Visible = False)

                            Select Case results(34).Value

                                Case True
                                    Me.Invoke(Sub() QF23_vkl_.Visible = True)
                                    Me.Invoke(Sub() QF23_vykl_.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF23_vkl_.Visible = False)
                                    Me.Invoke(Sub() QF23_vykl_.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF23_vykl_.Visible = False)
                            Me.Invoke(Sub() QF23_vkl_.Visible = False)
                            Me.Invoke(Sub() lblQF23_.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(37).Value

                        Case False

                            Me.Invoke(Sub() lblQF2.Visible = False)

                            Select Case results(36).Value

                                Case True
                                    Me.Invoke(Sub() QF2_vkl.Visible = True)
                                    Me.Invoke(Sub() QF2_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF2_vkl.Visible = False)
                                    Me.Invoke(Sub() QF2_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF2_vykl.Visible = False)
                            Me.Invoke(Sub() QF2_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF2.Visible = True)
                    End Select

                    Select Case results(38).Value

                        Case True

                            vv1_u.BackColor = Color.Green
                        Case False

                            vv1_u.BackColor = Color.Red

                    End Select

                    Select Case results(39).Value

                        Case True

                            vv2_u.BackColor = Color.Green
                        Case False

                            vv2_u.BackColor = Color.Red

                    End Select
                    '#############################################################
                    Select Case results(41).Value

                        Case False

                            Me.Invoke(Sub() lblQF56.Visible = False)

                            Select Case results(40).Value

                                Case True
                                    Me.Invoke(Sub() QF56_vkl.Visible = True)
                                    Me.Invoke(Sub() QF56_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF56_vkl.Visible = False)
                                    Me.Invoke(Sub() QF56_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF56_vykl.Visible = False)
                            Me.Invoke(Sub() QF56_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF56.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(43).Value

                        Case False

                            Me.Invoke(Sub() lblQF57.Visible = False)

                            Select Case results(42).Value

                                Case True
                                    Me.Invoke(Sub() QF57_vkl.Visible = True)
                                    Me.Invoke(Sub() QF57_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF57_vkl.Visible = False)
                                    Me.Invoke(Sub() QF57_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF57_vykl.Visible = False)
                            Me.Invoke(Sub() QF57_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF57.Visible = True)
                    End Select

                    '#############################################################
                    Select Case results(45).Value

                        Case False

                            Me.Invoke(Sub() lblQF60.Visible = False)

                            Select Case results(44).Value

                                Case True
                                    Me.Invoke(Sub() QF60_vkl.Visible = True)
                                    Me.Invoke(Sub() QF60_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF60_vkl.Visible = False)
                                    Me.Invoke(Sub() QF60_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF60_vykl.Visible = False)
                            Me.Invoke(Sub() QF60_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF60.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(47).Value

                        Case False

                            Me.Invoke(Sub() lblQF61.Visible = False)

                            Select Case results(46).Value

                                Case True
                                    Me.Invoke(Sub() QF61_vkl.Visible = True)
                                    Me.Invoke(Sub() QF61_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF61_vkl.Visible = False)
                                    Me.Invoke(Sub() QF61_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF61_vykl.Visible = False)
                            Me.Invoke(Sub() QF61_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF61.Visible = True)
                    End Select

                    '#############################################################
                    Select Case results(49).Value

                        Case False

                            Me.Invoke(Sub() lblQF64.Visible = False)

                            Select Case results(48).Value

                                Case True
                                    Me.Invoke(Sub() QF64_vkl.Visible = True)
                                    Me.Invoke(Sub() QF64_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF64_vkl.Visible = False)
                                    Me.Invoke(Sub() QF64_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF64_vykl.Visible = False)
                            Me.Invoke(Sub() QF64_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF64.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(51).Value

                        Case False

                            Me.Invoke(Sub() lblQF65.Visible = False)

                            Select Case results(50).Value

                                Case True
                                    Me.Invoke(Sub() QF65_vkl.Visible = True)
                                    Me.Invoke(Sub() QF65_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF65_vkl.Visible = False)
                                    Me.Invoke(Sub() QF65_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF65_vykl.Visible = False)
                            Me.Invoke(Sub() QF65_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF65.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(53).Value

                        Case False

                            Me.Invoke(Sub() lblQF68.Visible = False)

                            Select Case results(52).Value

                                Case True
                                    Me.Invoke(Sub() QF68_vkl.Visible = True)
                                    Me.Invoke(Sub() QF68_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF68_vkl.Visible = False)
                                    Me.Invoke(Sub() QF68_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF68_vykl.Visible = False)
                            Me.Invoke(Sub() QF68_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF68.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(55).Value

                        Case False

                            Me.Invoke(Sub() lblQF70.Visible = False)

                            Select Case results(54).Value

                                Case True
                                    Me.Invoke(Sub() QF70_vkl.Visible = True)
                                    Me.Invoke(Sub() QF70_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF70_vkl.Visible = False)
                                    Me.Invoke(Sub() QF70_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF70_vykl.Visible = False)
                            Me.Invoke(Sub() QF70_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF70.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(57).Value

                        Case False

                            Me.Invoke(Sub() lblQF72.Visible = False)

                            Select Case results(56).Value

                                Case True
                                    Me.Invoke(Sub() QF72_vkl.Visible = True)
                                    Me.Invoke(Sub() QF72_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF72_vkl.Visible = False)
                                    Me.Invoke(Sub() QF72_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF72_vykl.Visible = False)
                            Me.Invoke(Sub() QF72_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF72.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(59).Value

                        Case False

                            Me.Invoke(Sub() lblQF76.Visible = False)

                            Select Case results(58).Value

                                Case True
                                    Me.Invoke(Sub() QF76_vkl.Visible = True)
                                    Me.Invoke(Sub() QF76_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF76_vkl.Visible = False)
                                    Me.Invoke(Sub() QF76_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF76_vykl.Visible = False)
                            Me.Invoke(Sub() QF76_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF76.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(61).Value

                        Case False

                            Me.Invoke(Sub() lblQF77.Visible = False)

                            Select Case results(60).Value

                                Case True
                                    Me.Invoke(Sub() QF77_vkl.Visible = True)
                                    Me.Invoke(Sub() QF77_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF77_vkl.Visible = False)
                                    Me.Invoke(Sub() QF77_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF77_vykl.Visible = False)
                            Me.Invoke(Sub() QF77_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF77.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(63).Value

                        Case False

                            Me.Invoke(Sub() lblQF78.Visible = False)

                            Select Case results(62).Value

                                Case True
                                    Me.Invoke(Sub() QF78_vkl.Visible = True)
                                    Me.Invoke(Sub() QF78_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF78_vkl.Visible = False)
                                    Me.Invoke(Sub() QF78_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF78_vykl.Visible = False)
                            Me.Invoke(Sub() QF78_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF78.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(65).Value

                        Case False

                            Me.Invoke(Sub() lblQF79.Visible = False)

                            Select Case results(64).Value

                                Case True
                                    Me.Invoke(Sub() QF79_vkl.Visible = True)
                                    Me.Invoke(Sub() QF79_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF79_vkl.Visible = False)
                                    Me.Invoke(Sub() QF79_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF79_vykl.Visible = False)
                            Me.Invoke(Sub() QF79_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF79.Visible = True)
                    End Select
                    '#############################################################
                    Select Case results(67).Value

                        Case False

                            Me.Invoke(Sub() lblQF80.Visible = False)

                            Select Case results(66).Value

                                Case True
                                    Me.Invoke(Sub() QF80_vkl.Visible = True)
                                    Me.Invoke(Sub() QF80_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF80_vkl.Visible = False)
                                    Me.Invoke(Sub() QF80_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF80_vykl.Visible = False)
                            Me.Invoke(Sub() QF80_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF80.Visible = True)
                    End Select

                    Me.Invoke(Sub() LineColor(results(68).Value, L2_2))
                    Me.Invoke(Sub() L2_3.BorderColor = L2_2.BorderColor)
                    Me.Invoke(Sub() L2_4.BorderColor = L2_2.BorderColor)
                    Me.Invoke(Sub() L2_5.BorderColor = L2_2.BorderColor)
                    Me.Invoke(Sub() L2_6.BorderColor = L2_2.BorderColor)
                    Me.Invoke(Sub() L2_7.BorderColor = L2_2.BorderColor)
                    Me.Invoke(Sub() L2_8.BorderColor = L2_2.BorderColor)
                    Me.Invoke(Sub() L2_9.BorderColor = L2_2.BorderColor)
                    Me.Invoke(Sub() L2_10.BorderColor = L2_2.BorderColor)
                    Me.Invoke(Sub() L2_11.BorderColor = L2_2.BorderColor)
                    Me.Invoke(Sub() L2_12.BorderColor = L2_2.BorderColor)
                    Me.Invoke(Sub() L2_13.BorderColor = L2_2.BorderColor)
                    Me.Invoke(Sub() L2_14.BorderColor = L2_2.BorderColor)
                    Me.Invoke(Sub() L2_15.BorderColor = L2_2.BorderColor)
                    Me.Invoke(Sub() L2_16.BorderColor = L2_2.BorderColor)
                    Me.Invoke(Sub() L2_17.BorderColor = L2_2.BorderColor)
                    Me.Invoke(Sub() L2_18.BorderColor = L2_2.BorderColor)
                    Me.Invoke(Sub() L2_19.BorderColor = L2_2.BorderColor)


                    Me.Invoke(Sub() LineColor(results(69).Value, LineShape27))
                    Me.Invoke(Sub() LineColor(results(70).Value, LineShape28))
                    Me.Invoke(Sub() LineColor(results(71).Value, LineShape29))
                    Me.Invoke(Sub() LineColor(results(72).Value, LineShape30))
                    Me.Invoke(Sub() LineColor(results(73).Value, LineShape31))
                    Me.Invoke(Sub() LineColor(results(74).Value, LineShape32))
                    Me.Invoke(Sub() LineColor(results(75).Value, LineShape33))
                    Me.Invoke(Sub() LineColor(results(76).Value, LineShape34))
                    Me.Invoke(Sub() LineColor(results(77).Value, LineShape35))
                    Me.Invoke(Sub() LineColor(results(78).Value, LineShape36))
                    Me.Invoke(Sub() LineColor(results(79).Value, LineShape37))
                    Me.Invoke(Sub() LineColor(results(80).Value, LineShape38))
                    Me.Invoke(Sub() LineColor(results(81).Value, LineShape39))
                    Me.Invoke(Sub() LineColor(results(82).Value, LineShape40))

                    Me.Invoke(Sub() LineColor(results(83).Value, L2_1))
                    Me.Invoke(Sub() LineColor(results(84).Value, LineShape3))

                    Me.Invoke(Sub() LineColor(results(85).Value, L1_1))
                    Me.Invoke(Sub() LineShape1.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() LineShape11.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() LineShape9.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() LineShape6.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() LineShape7.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() LineShape8.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() LineShape10.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() LineShape12.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() LineShape13.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() LineShape14.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() LineShape15.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() LineShape16.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() LineShape17.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() LineShape18.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() LineShape19.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() LineShape20.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() LineShape21.BorderColor = L1_1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(86).Value, LineShape49))
                    Me.Invoke(Sub() LineColor(results(87).Value, LineShape48))
                    Me.Invoke(Sub() LineColor(results(88).Value, LineShape47))
                    Me.Invoke(Sub() LineColor(results(89).Value, LineShape46))
                    Me.Invoke(Sub() LineColor(results(90).Value, LineShape45))
                    Me.Invoke(Sub() LineColor(results(91).Value, LineShape44))
                    Me.Invoke(Sub() LineColor(results(92).Value, LineShape43))
                    Me.Invoke(Sub() LineColor(results(93).Value, LineShape42))
                    Me.Invoke(Sub() LineColor(results(94).Value, LineShape41))
                    Me.Invoke(Sub() LineColor(results(95).Value, LineShape26))
                    Me.Invoke(Sub() LineColor(results(96).Value, LineShape25))
                    Me.Invoke(Sub() LineColor(results(97).Value, LineShape24))
                    Me.Invoke(Sub() LineColor(results(98).Value, LineShape23))
                    Me.Invoke(Sub() LineColor(results(99).Value, LineShape22))

                Next


                Threading.Thread.Sleep(MSPEED + 500)
            Loop

        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        frmRP10.MdiParent = frmIndexer
        frmRP10.Show()
        frmRP10.Focus()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frm_CHGP.MdiParent = frmIndexer
        frm_CHGP.Show()
        frm_CHGP.Focus()
    End Sub

    'frm_CHGP
End Class