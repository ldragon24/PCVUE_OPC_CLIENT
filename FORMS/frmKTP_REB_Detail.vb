Public Class frmKTP_REB_Detail
    Dim T_KTP_REB As System.Threading.Thread

    Private Sub btnRp10V1_Click(sender As System.Object, e As System.EventArgs) Handles btnRp10V1.Click

    End Sub

    Sub T_KTP_REB_START()

        Try
ARG:
            groupStateKTP_REB_D.Name = "KTPREBD"
            groupStateKTP_REB_D.Active = True
            groupStateKTP_REB_D.UpdateRate = MSPEED

            groupKTP_REB_D = DirectCast(m_server.CreateSubscription(groupStateKTP_REB_D), Opc.Da.Subscription)
            
            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(117) {}

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "КТП_РЭБ.С1.ВВ1.CLOSE"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "КТП_РЭБ.С1.ВВ1.DISCREP_OPEN_CLOSE"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "КТП_РЭБ.С2.ВВ2.CLOSE"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "КТП_РЭБ.С2.ВВ2.DISCREP_OPEN_CLOSE"


            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "КТП_РЭБ.С1.ВВ1.TRIP"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "КТП_РЭБ.С2.ВВ2.TRIP"
            '#########################################################

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "КТП_РЭБ.С1.ВВ1.UBB"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "КТП_РЭБ.С2.ВВ2.UBB"

            '#########################################################

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "КТП_РЭБ.С1.ККУ.I"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "КТП_РЭБ.С1.ККУ.Q"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "КТП_РЭБ.С1.ККУ.U"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "КТП_РЭБ.С1.ККУ.COS"
            '#########################################################

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "КТП_РЭБ.С2.ККУ.I"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "КТП_РЭБ.С2.ККУ.Q"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "КТП_РЭБ.С2.ККУ.U"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "КТП_РЭБ.С2.ККУ.COS"

            '#########################################################

            'ВВОД 1
            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "КТП_РЭБ.С1.ВВ1.UBB"

            '#########################################################
            'ВВОД 2
            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "КТП_РЭБ.C2.ВВ2.UBB"

            '#########################################################
            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "КТП_РЭБ.С1.АВ.AVR_ON"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "КТП_РЭБ.С1.АВ.CLOSE"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "КТП_РЭБ.С1.АВ.GENE_OPEN"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "КТП_РЭБ.С1.АВ.ALA_I1_A_PSK"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "КТП_РЭБ.С1.АВ.C_TRIP"

            '#########################################################
            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "КТП_РЭБ.С1.СВ.AVR_ON"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "КТП_РЭБ.С1.СВ.CLOSE"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "КТП_РЭБ.С1.СВ.TRIP"

            '#########################################################
            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "КТП_РЭБ.С1.QF3.CLOSE"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "КТП_РЭБ.С1.QF3.DOC"
            '##########################################################
            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "КТП_РЭБ.С1.QF4.CLOSE"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "КТП_РЭБ.С1.QF4.DOC"
            '##########################################################
            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "КТП_РЭБ.С1.QF5.CLOSE"

            items(31) = New Global.Opc.Da.Item()
            items(31).ItemName = "КТП_РЭБ.С1.QF5.DOC"
            '##########################################################
            items(32) = New Global.Opc.Da.Item()
            items(32).ItemName = "КТП_РЭБ.С1.QF6.CLOSE"

            items(33) = New Global.Opc.Da.Item()
            items(33).ItemName = "КТП_РЭБ.С1.QF6.DOC"
            '##########################################################
            items(34) = New Global.Opc.Da.Item()
            items(34).ItemName = "КТП_РЭБ.С1.QF7.CLOSE"

            items(35) = New Global.Opc.Da.Item()
            items(35).ItemName = "КТП_РЭБ.С1.QF7.DOC"
            '##########################################################
            items(36) = New Global.Opc.Da.Item()
            items(36).ItemName = "КТП_РЭБ.С1.QF8.CLOSE"

            items(37) = New Global.Opc.Da.Item()
            items(37).ItemName = "КТП_РЭБ.С1.QF8.DOC"
            '##########################################################
            items(38) = New Global.Opc.Da.Item()
            items(38).ItemName = "КТП_РЭБ.С1.QF9.CLOSE"

            items(39) = New Global.Opc.Da.Item()
            items(39).ItemName = "КТП_РЭБ.С1.QF9.DOC"
            '##########################################################
            items(40) = New Global.Opc.Da.Item()
            items(40).ItemName = "КТП_РЭБ.С1.QF10.CLOSE"

            items(41) = New Global.Opc.Da.Item()
            items(41).ItemName = "КТП_РЭБ.С1.QF10.DOC"
            '##########################################################
            items(42) = New Global.Opc.Da.Item()
            items(42).ItemName = "КТП_РЭБ.С1.QF11.CLOSE"

            items(43) = New Global.Opc.Da.Item()
            items(43).ItemName = "КТП_РЭБ.С1.QF11.DOC"
            '##########################################################
            items(44) = New Global.Opc.Da.Item()
            items(44).ItemName = "КТП_РЭБ.С1.QF12.CLOSE"

            items(45) = New Global.Opc.Da.Item()
            items(45).ItemName = "КТП_РЭБ.С1.QF12.DOC"
            '##########################################################
            items(46) = New Global.Opc.Da.Item()
            items(46).ItemName = "КТП_РЭБ.С1.QF13.CLOSE"

            items(47) = New Global.Opc.Da.Item()
            items(47).ItemName = "КТП_РЭБ.С1.QF13.DOC"
            '##########################################################
            items(48) = New Global.Opc.Da.Item()
            items(48).ItemName = "КТП_РЭБ.С1.QF14.CLOSE"

            items(49) = New Global.Opc.Da.Item()
            items(49).ItemName = "КТП_РЭБ.С1.QF14.DOC"
            '##########################################################
            items(50) = New Global.Opc.Da.Item()
            items(50).ItemName = "КТП_РЭБ.С1.QF15.CLOSE"

            items(51) = New Global.Opc.Da.Item()
            items(51).ItemName = "КТП_РЭБ.С1.QF15.DOC"
            '##########################################################
            items(52) = New Global.Opc.Da.Item()
            items(52).ItemName = "КТП_РЭБ.С1.QF16.CLOSE"

            items(53) = New Global.Opc.Da.Item()
            items(53).ItemName = "КТП_РЭБ.С1.QF16.DOC"
            '##########################################################



            items(54) = New Global.Opc.Da.Item()
            items(54).ItemName = "КТП_РЭБ.С2.QF18.CLOSE"

            items(55) = New Global.Opc.Da.Item()
            items(55).ItemName = "КТП_РЭБ.С2.QF18.DOC"
            '##########################################################
            items(56) = New Global.Opc.Da.Item()
            items(56).ItemName = "КТП_РЭБ.С2.QF19.CLOSE"

            items(57) = New Global.Opc.Da.Item()
            items(57).ItemName = "КТП_РЭБ.С2.QF19.DOC"
            '##########################################################
            items(58) = New Global.Opc.Da.Item()
            items(58).ItemName = "КТП_РЭБ.С2.QF20.CLOSE"

            items(59) = New Global.Opc.Da.Item()
            items(59).ItemName = "КТП_РЭБ.С2.QF20.DOC"
            '##########################################################
            items(60) = New Global.Opc.Da.Item()
            items(60).ItemName = "КТП_РЭБ.С2.QF21.CLOSE"

            items(61) = New Global.Opc.Da.Item()
            items(61).ItemName = "КТП_РЭБ.С2.QF21.DOC"
            '##########################################################
            items(62) = New Global.Opc.Da.Item()
            items(62).ItemName = "КТП_РЭБ.С2.QF22.CLOSE"

            items(63) = New Global.Opc.Da.Item()
            items(63).ItemName = "КТП_РЭБ.С2.QF22.DOC"

            '##########################################################
            items(64) = New Global.Opc.Da.Item()
            items(64).ItemName = "КТП_РЭБ.С2.QF24.CLOSE"

            items(65) = New Global.Opc.Da.Item()
            items(65).ItemName = "КТП_РЭБ.С2.QF24.DOC"
            '##########################################################
            items(66) = New Global.Opc.Da.Item()
            items(66).ItemName = "КТП_РЭБ.С2.QF25.CLOSE"

            items(67) = New Global.Opc.Da.Item()
            items(67).ItemName = "КТП_РЭБ.С2.QF25.DOC"

            '##########################################################
            items(68) = New Global.Opc.Da.Item()
            items(68).ItemName = "КТП_РЭБ.С2.QF26.CLOSE"

            items(69) = New Global.Opc.Da.Item()
            items(69).ItemName = "КТП_РЭБ.С2.QF26.DOC"
            '##########################################################
            items(70) = New Global.Opc.Da.Item()
            items(70).ItemName = "КТП_РЭБ.С2.QF27.CLOSE"

            items(71) = New Global.Opc.Da.Item()
            items(71).ItemName = "КТП_РЭБ.С2.QF27.DOC"
            '##########################################################
            items(72) = New Global.Opc.Da.Item()
            items(72).ItemName = "КТП_РЭБ.С2.QF28.CLOSE"

            items(73) = New Global.Opc.Da.Item()
            items(73).ItemName = "КТП_РЭБ.С2.QF28.DOC"
            '##########################################################
            items(74) = New Global.Opc.Da.Item()
            items(74).ItemName = "КТП_РЭБ.С2.QF29.CLOSE"

            items(75) = New Global.Opc.Da.Item()
            items(75).ItemName = "КТП_РЭБ.С2.QF29.DOC"
            '##########################################################
            items(76) = New Global.Opc.Da.Item()
            items(76).ItemName = "КТП_РЭБ.С2.QF30.CLOSE"

            items(77) = New Global.Opc.Da.Item()
            items(77).ItemName = "КТП_РЭБ.С2.QF30.DOC"
            '##########################################################
            items(78) = New Global.Opc.Da.Item()
            items(78).ItemName = "КТП_РЭБ.С2.QF31.CLOSE"

            items(79) = New Global.Opc.Da.Item()
            items(79).ItemName = "КТП_РЭБ.С2.QF31.DOC"
            '##########################################################
            items(80) = New Global.Opc.Da.Item()
            items(80).ItemName = "КТП_РЭБ.С2.QF23.CLOSE"

            items(81) = New Global.Opc.Da.Item()
            items(81).ItemName = "КТП_РЭБ.С2.QF23.DOC"
            '##########################################################



            items(82) = New Global.Opc.Da.Item()
            items(82).ItemName = "КТП_РЭБ.С1.СВ.VOLT_COLOR"

            items(83) = New Global.Opc.Da.Item()
            items(83).ItemName = "КТП_РЭБ.С1.VOLT_COLOR"

            items(84) = New Global.Opc.Da.Item()
            items(84).ItemName = "КТП_РЭБ.С2.VOLT_COLOR"

            items(85) = New Global.Opc.Da.Item()
            items(85).ItemName = "КТП_РЭБ.С1.ВВ1.VOLT_COLOR"

            items(86) = New Global.Opc.Da.Item()
            items(86).ItemName = "КТП_ЭБ.С1.ККУ.VOLT_COLOR"

            '#########################################################
            items(87) = New Global.Opc.Da.Item()
            items(87).ItemName = "КТП_РЭБ.С1.QF3.VOLT_COLOR"

            items(88) = New Global.Opc.Da.Item()
            items(88).ItemName = "КТП_РЭБ.С1.QF4.VOLT_COLOR"

            items(89) = New Global.Opc.Da.Item()
            items(89).ItemName = "КТП_РЭБ.С1.QF5.VOLT_COLOR"

            items(90) = New Global.Opc.Da.Item()
            items(90).ItemName = "КТП_РЭБ.С1.QF6.VOLT_COLOR"

            items(91) = New Global.Opc.Da.Item()
            items(91).ItemName = "КТП_РЭБ.С1.QF7.VOLT_COLOR"

            items(92) = New Global.Opc.Da.Item()
            items(92).ItemName = "КТП_РЭБ.С1.QF8.VOLT_COLOR"

            items(93) = New Global.Opc.Da.Item()
            items(93).ItemName = "КТП_РЭБ.С1.QF9.VOLT_COLOR"

            items(94) = New Global.Opc.Da.Item()
            items(94).ItemName = "КТП_РЭБ.С1.QF10.VOLT_COLOR"

            items(95) = New Global.Opc.Da.Item()
            items(95).ItemName = "КТП_РЭБ.С1.QF11.VOLT_COLOR"

            items(96) = New Global.Opc.Da.Item()
            items(96).ItemName = "КТП_РЭБ.С1.QF12.VOLT_COLOR"

            items(97) = New Global.Opc.Da.Item()
            items(97).ItemName = "КТП_РЭБ.С1.QF13.VOLT_COLOR"

            items(98) = New Global.Opc.Da.Item()
            items(98).ItemName = "КТП_РЭБ.С1.QF14.VOLT_COLOR"

            items(99) = New Global.Opc.Da.Item()
            items(99).ItemName = "КТП_РЭБ.С1.QF15.VOLT_COLOR"

            items(100) = New Global.Opc.Da.Item()
            items(100).ItemName = "КТП_РЭБ.С1.QF16.VOLT_COLOR"


            items(101) = New Global.Opc.Da.Item()
            items(101).ItemName = "КТП_РЭБ.С2.ВВ2.VOLT_COLOR"

            items(102) = New Global.Opc.Da.Item()
            items(102).ItemName = "КТП_РЭБ.С2.ККУ.VOLT_COLOR"

            items(103) = New Global.Opc.Da.Item()
            items(103).ItemName = "КТП_РЭБ.С2.QF18.VOLT_COLOR"

            items(104) = New Global.Opc.Da.Item()
            items(104).ItemName = "КТП_РЭБ.С2.QF19.VOLT_COLOR"

            items(105) = New Global.Opc.Da.Item()
            items(105).ItemName = "КТП_РЭБ.С2.QF20.VOLT_COLOR"

            items(106) = New Global.Opc.Da.Item()
            items(106).ItemName = "КТП_РЭБ.С2.QF21.VOLT_COLOR"

            items(107) = New Global.Opc.Da.Item()
            items(107).ItemName = "КТП_РЭБ.С2.QF22.VOLT_COLOR"

            items(108) = New Global.Opc.Da.Item()
            items(108).ItemName = "КТП_РЭБ.С2.QF23.VOLT_COLOR"

            items(109) = New Global.Opc.Da.Item()
            items(109).ItemName = "КТП_РЭБ.С2.QF24.VOLT_COLOR"

            items(110) = New Global.Opc.Da.Item()
            items(110).ItemName = "КТП_РЭБ.С2.QF25.VOLT_COLOR"

            items(111) = New Global.Opc.Da.Item()
            items(111).ItemName = "КТП_РЭБ.С2.QF26.VOLT_COLOR"

            items(112) = New Global.Opc.Da.Item()
            items(112).ItemName = "КТП_РЭБ.С2.QF27.VOLT_COLOR"

            items(113) = New Global.Opc.Da.Item()
            items(113).ItemName = "КТП_РЭБ.С2.QF28.VOLT_COLOR"

            items(114) = New Global.Opc.Da.Item()
            items(114).ItemName = "КТП_РЭБ.С2.QF29.VOLT_COLOR"

            items(115) = New Global.Opc.Da.Item()
            items(115).ItemName = "КТП_РЭБ.С2.QF30.VOLT_COLOR"

            items(116) = New Global.Opc.Da.Item()
            items(116).ItemName = "КТП_РЭБ.С2.QF31.VOLT_COLOR"
            'EXPRV;@КТП_РЭБ.С1.VOLT_COLOR_SRC;(@КТП_РЭБ.С1.ВВ1.UA + @КТП_РЭБ.С1.ВВ1.UB + @КТП_РЭБ.С1.ВВ1.UC) > 60;КТП_РЭБ.С1;;2501;;;0;
            'КТП_РЭБ.С2.ВВ2.VOLT_COLOR

            items(117) = New Global.Opc.Da.Item()
            items(117).ItemName = "КТП_РЭБ.С1.АВ.VOLT_COLOR"




            items = groupKTP_REB_D.AddItems(items)

            Dim MGg As Double

            Do

                Dim results As ItemValueResult() = Nothing
                results = groupKTP_REB_D.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    MGg = results(6).Value
                    Me.Invoke(Sub() lblKKU1_I.Text = Math.Round(MGg, 1) & " A")

                    MGg = results(7).Value
                    Me.Invoke(Sub() lblKKU1_Q.Text = Math.Round(MGg, 1) & " ВAр")

                    MGg = results(8).Value
                    Me.Invoke(Sub() lblKKU1_U.Text = Math.Round(MGg, 1) & " В")

                    MGg = results(9).Value
                    Me.Invoke(Sub() lblKKU1_COS.Text = Math.Round(MGg, 1))
                    '####################################################################

                    MGg = results(10).Value
                    Me.Invoke(Sub() lblKKU2_I.Text = Math.Round(MGg, 1) & " A")

                    MGg = results(11).Value
                    Me.Invoke(Sub() lblKKU2_Q.Text = Math.Round(MGg, 1) & " ВAр")

                    MGg = results(12).Value
                    Me.Invoke(Sub() lblKKU2_U.Text = Math.Round(MGg, 1) & " В")

                    MGg = results(13).Value
                    Me.Invoke(Sub() lblKKU2_COS.Text = Math.Round(MGg, 1))


                    '####################################################################
                    Select Case results(16).Value

                        Case True
                            Me.Invoke(Sub() VV1_vkl.Visible = False)
                            Me.Invoke(Sub() VV1_vykl.Visible = False)
                            Me.Invoke(Sub() VV1_TV.Visible = True)
                        Case False
                            Me.Invoke(Sub() VV1_TV.Visible = False)

                            Select Case results(0).Value

                                Case True
                                    Me.Invoke(Sub() VV1_vkl.Visible = True)
                                    Me.Invoke(Sub() VV1_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VV1_vkl.Visible = False)
                                    Me.Invoke(Sub() VV1_vykl.Visible = True)
                            End Select

                    End Select
                    '####################################################################
                    Select Case results(17).Value

                        Case True
                            Me.Invoke(Sub() VV2_vkl.Visible = False)
                            Me.Invoke(Sub() VV2_vykl.Visible = False)
                            Me.Invoke(Sub() VV2_TV.Visible = True)
                        Case False
                            Me.Invoke(Sub() VV2_TV.Visible = False)

                            Select Case results(1).Value

                                Case True
                                    Me.Invoke(Sub() VV2_vkl.Visible = True)
                                    Me.Invoke(Sub() VV2_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VV2_vkl.Visible = False)
                                    Me.Invoke(Sub() VV2_vykl.Visible = True)
                            End Select

                    End Select
                    '####################################################################
                    Select Case results(18).Value

                        Case True
                            Me.Invoke(Sub() Label30.Enabled = True)
                            Me.Invoke(Sub() Label31.Enabled = False)
                        Case False
                            Me.Invoke(Sub() Label30.Enabled = False)
                            Me.Invoke(Sub() Label31.Enabled = True)
                    End Select

                    Select Case results(19).Value

                        Case True
                            Me.Invoke(Sub() AV_vykl.Visible = False)
                            Me.Invoke(Sub() AV_vkl.Visible = True)

                        Case False

                            Me.Invoke(Sub() AV_vykl.Visible = True)
                            Me.Invoke(Sub() AV_vkl.Visible = False)
                    End Select

                    Select Case results(20).Value

                        Case False
                            Me.Invoke(Sub() ADES_VyKL.Visible = False)
                            Me.Invoke(Sub() ADES_VKL.Visible = True)

                        Case True

                            Me.Invoke(Sub() ADES_VyKL.Visible = True)
                            Me.Invoke(Sub() ADES_VKL.Visible = False)
                    End Select

                    MGg = results(21).Value
                    Me.Invoke(Sub() lblSHVA_I.Text = Math.Round(MGg, 1) & " A")

                    Select Case results(22).Value
                        Case True
                            Me.Invoke(Sub() lblA4.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA4.BackColor = Color.Transparent)
                    End Select

                    '####################################################################
                    Select Case results(23).Value

                        Case True
                            Me.Invoke(Sub() lblAVR_vkl.Enabled = True)
                            Me.Invoke(Sub() lblAVR_vykl.Enabled = False)
                        Case False
                            Me.Invoke(Sub() lblAVR_vkl.Enabled = False)
                            Me.Invoke(Sub() lblAVR_vykl.Enabled = True)
                    End Select

                    Select Case results(24).Value

                        Case True

                            Me.Invoke(Sub() SV_vkl.Visible = True)
                            Me.Invoke(Sub() SV_vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() SV_vkl.Visible = False)
                            Me.Invoke(Sub() SV_vykl.Visible = True)
                    End Select

                    Select Case results(25).Value
                        Case True
                            Me.Invoke(Sub() lblA3Sv.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA3Sv.BackColor = Color.Transparent)
                    End Select


                    '####################################################################
                    MGg = results(4).Value
                    Me.Invoke(Sub() lblV1_UBB.Text = Math.Round(MGg, 1) & " B")

                    MGg = results(5).Value
                    Me.Invoke(Sub() lblV2_UBB.Text = Math.Round(MGg, 1) & " B")

                    '####################################################################
                    Select Case results(3).Value
                        Case True
                            Me.Invoke(Sub() lblA2.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA2.BackColor = Color.Transparent)
                    End Select
                    '####################################################################
                    Select Case results(2).Value
                        Case True
                            Me.Invoke(Sub() lblA1.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA1.BackColor = Color.Transparent)
                    End Select
                    '####################################################################

                    'QF3
                    Select Case results(27).Value

                        Case False

                            Me.Invoke(Sub() lblQF3.Visible = False)

                            Select Case results(26).Value

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
                    'QF4
                    Select Case results(29).Value

                        Case False

                            Me.Invoke(Sub() lblQF4.Visible = False)

                            Select Case results(28).Value

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
                    'QF5
                    Select Case results(31).Value

                        Case False

                            Me.Invoke(Sub() lblQF5.Visible = False)

                            Select Case results(30).Value

                                Case True
                                    Me.Invoke(Sub() QF5_vkl.Visible = True)
                                    Me.Invoke(Sub() QF5_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF5_vkl.Visible = False)
                                    Me.Invoke(Sub() QF5_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF5_vykl.Visible = False)
                            Me.Invoke(Sub() QF5_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF5.Visible = True)
                    End Select

                    '#############################################################

                    'QF6
                    Select Case results(33).Value

                        Case False

                            Me.Invoke(Sub() lblQF6.Visible = False)

                            Select Case results(32).Value

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
                    'QF7
                    Select Case results(35).Value

                        Case False

                            Me.Invoke(Sub() lblQF7.Visible = False)

                            Select Case results(34).Value

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
                    'QF8
                    Select Case results(37).Value

                        Case False

                            Me.Invoke(Sub() lblQF8.Visible = False)

                            Select Case results(36).Value

                                Case True
                                    Me.Invoke(Sub() QF8_vkl.Visible = True)
                                    Me.Invoke(Sub() QF8_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF8_vkl.Visible = False)
                                    Me.Invoke(Sub() QF8_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF8_vykl.Visible = False)
                            Me.Invoke(Sub() QF8_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF8.Visible = True)
                    End Select

                    '#############################################################
                    'QF9
                    Select Case results(39).Value

                        Case False

                            Me.Invoke(Sub() lblQF9.Visible = False)

                            Select Case results(38).Value

                                Case True
                                    Me.Invoke(Sub() QF9_vkl.Visible = True)
                                    Me.Invoke(Sub() QF9_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF9_vkl.Visible = False)
                                    Me.Invoke(Sub() QF9_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF9_vykl.Visible = False)
                            Me.Invoke(Sub() QF9_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF9.Visible = True)
                    End Select

                    '#############################################################
                    'QF10
                    Select Case results(41).Value

                        Case False

                            Me.Invoke(Sub() lblQF10.Visible = False)

                            Select Case results(40).Value

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
                    'QF11
                    Select Case results(43).Value

                        Case False

                            Me.Invoke(Sub() lblQF13.Visible = False)

                            Select Case results(42).Value

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
                            Me.Invoke(Sub() lblQF13.Visible = True)
                    End Select

                    '#############################################################
                    'QF12
                    Select Case results(45).Value

                        Case False

                            Me.Invoke(Sub() lblQF12.Visible = False)

                            Select Case results(44).Value

                                Case True
                                    Me.Invoke(Sub() QF12_vkl.Visible = True)
                                    Me.Invoke(Sub() QF12_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF12_vkl.Visible = False)
                                    Me.Invoke(Sub() QF12_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF12_vykl.Visible = False)
                            Me.Invoke(Sub() QF12_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF12.Visible = True)
                    End Select

                    '#############################################################
                    'QF13
                    Select Case results(47).Value

                        Case False

                            Me.Invoke(Sub() lblQF13.Visible = False)

                            Select Case results(46).Value

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
                    'QF14
                    Select Case results(49).Value

                        Case False

                            Me.Invoke(Sub() lblQF14.Visible = False)

                            Select Case results(48).Value

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
                    'QF15
                    Select Case results(51).Value

                        Case False

                            Me.Invoke(Sub() lblQF15.Visible = False)

                            Select Case results(50).Value

                                Case True
                                    Me.Invoke(Sub() QF15_vkl.Visible = True)
                                    Me.Invoke(Sub() QF15_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF15_vkl.Visible = False)
                                    Me.Invoke(Sub() QF15_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF15_vykl.Visible = False)
                            Me.Invoke(Sub() QF15_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF15.Visible = True)
                    End Select

                    '#############################################################
                    'QF16
                    Select Case results(53).Value

                        Case False

                            Me.Invoke(Sub() lblQF16.Visible = False)

                            Select Case results(52).Value

                                Case True
                                    Me.Invoke(Sub() QF16_vkl.Visible = True)
                                    Me.Invoke(Sub() QF16_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF16_vkl.Visible = False)
                                    Me.Invoke(Sub() QF16_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF16_vykl.Visible = False)
                            Me.Invoke(Sub() QF16_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF16.Visible = True)
                    End Select

                    '#############################################################


                    'QF18
                    Select Case results(55).Value

                        Case False

                            Me.Invoke(Sub() lblQF18.Visible = False)

                            Select Case results(54).Value

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
                    'QF19
                    Select Case results(57).Value

                        Case False

                            Me.Invoke(Sub() lblQF19.Visible = False)

                            Select Case results(56).Value

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
                    'QF20
                    Select Case results(59).Value

                        Case False

                            Me.Invoke(Sub() lblQF20.Visible = False)

                            Select Case results(58).Value

                                Case True
                                    Me.Invoke(Sub() QF20_vkl.Visible = True)
                                    Me.Invoke(Sub() QF20_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF20_vkl.Visible = False)
                                    Me.Invoke(Sub() QF20_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF20_vykl.Visible = False)
                            Me.Invoke(Sub() QF20_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF20.Visible = True)
                    End Select

                    '#############################################################
                    'QF21
                    Select Case results(61).Value

                        Case False

                            Me.Invoke(Sub() lblQF21.Visible = False)

                            Select Case results(60).Value

                                Case True
                                    Me.Invoke(Sub() QF21_vkl.Visible = True)
                                    Me.Invoke(Sub() QF21_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF21_vkl.Visible = False)
                                    Me.Invoke(Sub() QF21_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF21_vykl.Visible = False)
                            Me.Invoke(Sub() QF21_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF21.Visible = True)
                    End Select

                    '#############################################################
                    'QF22
                    Select Case results(63).Value

                        Case False

                            Me.Invoke(Sub() lblQF22.Visible = False)

                            Select Case results(62).Value

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
                    'QF24
                    Select Case results(65).Value

                        Case False

                            Me.Invoke(Sub() lblQF24.Visible = False)

                            Select Case results(64).Value

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
                    'QF25
                    Select Case results(67).Value

                        Case False

                            Me.Invoke(Sub() lblQF25.Visible = False)

                            Select Case results(66).Value

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
                    'QF26
                    Select Case results(69).Value

                        Case False

                            Me.Invoke(Sub() lblQF26.Visible = False)

                            Select Case results(68).Value

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
                    'QF27
                    Select Case results(71).Value

                        Case False

                            Me.Invoke(Sub() lblQF27.Visible = False)

                            Select Case results(70).Value

                                Case True
                                    Me.Invoke(Sub() QF27_vkl.Visible = True)
                                    Me.Invoke(Sub() QF27_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF27_vkl.Visible = False)
                                    Me.Invoke(Sub() QF27_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF27_vykl.Visible = False)
                            Me.Invoke(Sub() QF27_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF27.Visible = True)
                    End Select

                    '#############################################################
                    'QF28
                    Select Case results(73).Value

                        Case False

                            Me.Invoke(Sub() lblQF28.Visible = False)

                            Select Case results(72).Value

                                Case True
                                    Me.Invoke(Sub() QF28_vkl.Visible = True)
                                    Me.Invoke(Sub() QF28_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF28_vkl.Visible = False)
                                    Me.Invoke(Sub() QF28_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF28_vykl.Visible = False)
                            Me.Invoke(Sub() QF28_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF28.Visible = True)
                    End Select

                    '#############################################################
                    'QF29
                    Select Case results(75).Value

                        Case False

                            Me.Invoke(Sub() lblQF29.Visible = False)

                            Select Case results(74).Value

                                Case True
                                    Me.Invoke(Sub() QF29_vkl.Visible = True)
                                    Me.Invoke(Sub() QF29_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF29_vkl.Visible = False)
                                    Me.Invoke(Sub() QF29_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF29_vykl.Visible = False)
                            Me.Invoke(Sub() QF29_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF29.Visible = True)
                    End Select

                    '#############################################################
                    'QF30
                    Select Case results(77).Value

                        Case False

                            Me.Invoke(Sub() lblQF30.Visible = False)

                            Select Case results(76).Value

                                Case True
                                    Me.Invoke(Sub() QF30_vkl.Visible = True)
                                    Me.Invoke(Sub() QF30_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF30_vkl.Visible = False)
                                    Me.Invoke(Sub() QF30_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF30_vykl.Visible = False)
                            Me.Invoke(Sub() QF30_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF30.Visible = True)
                    End Select

                    '#############################################################
                    'QF31
                    Select Case results(79).Value

                        Case False

                            Me.Invoke(Sub() lblQF31.Visible = False)

                            Select Case results(78).Value

                                Case True
                                    Me.Invoke(Sub() QF31_vkl.Visible = True)
                                    Me.Invoke(Sub() QF31_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF31_vkl.Visible = False)
                                    Me.Invoke(Sub() QF31_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF31_vykl.Visible = False)
                            Me.Invoke(Sub() QF31_vkl.Visible = False)
                            Me.Invoke(Sub() lblQF31.Visible = True)
                    End Select

                    '#############################################################
                    'QF23
                    Select Case results(81).Value

                        Case False

                            Me.Invoke(Sub() lblQF23.Visible = False)

                            Select Case results(80).Value

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

                    Me.Invoke(Sub() LineColor(results(82).Value, LineShape1))
                    Me.Invoke(Sub() LineShape2.BorderColor = LineShape1.BorderColor)
                    Me.Invoke(Sub() LineShape3.BorderColor = LineShape1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(83).Value, LC1_2))
                    Me.Invoke(Sub() LC1_1.BorderColor = LC1_2.BorderColor)

                    Me.Invoke(Sub() LineColor(results(84).Value, LC2_2))
                    Me.Invoke(Sub() LC2_1.BorderColor = LC2_2.BorderColor)

                    Me.Invoke(Sub() LineColor(results(85).Value, LV1_1))
                    Me.Invoke(Sub() LV1_2.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() LV1_5.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() L3.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() L4.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() L5.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() L6.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() L7.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() L8.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() L9.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() L10.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() L11.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() L12.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() L13.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() L14.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() L15.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() L16.BorderColor = LV1_1.BorderColor)


                    Me.Invoke(Sub() LineColor(results(86).Value, LKKU_1))
                    Me.Invoke(Sub() LKKU_2.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LKKU_3.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LKKU_4.BorderColor = LKKU_1.BorderColor)

                    Me.Invoke(Sub() LineShape6.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape5.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape9.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape8.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape13.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape14.BorderColor = LKKU_1.BorderColor)


                    Me.Invoke(Sub() LineColor(results(87).Value, L3_))
                    Me.Invoke(Sub() LineColor(results(88).Value, L4_))
                    Me.Invoke(Sub() LineColor(results(89).Value, L5_))
                    Me.Invoke(Sub() LineColor(results(90).Value, L6_))
                    Me.Invoke(Sub() LineColor(results(91).Value, L7_))
                    Me.Invoke(Sub() LineColor(results(92).Value, L8_))
                    Me.Invoke(Sub() LineColor(results(93).Value, L9_))
                    Me.Invoke(Sub() LineColor(results(94).Value, L10_))
                    Me.Invoke(Sub() LineColor(results(95).Value, L11_))
                    Me.Invoke(Sub() LineColor(results(96).Value, L12_))
                    Me.Invoke(Sub() LineColor(results(97).Value, L13_))
                    Me.Invoke(Sub() LineColor(results(98).Value, L14_))
                    Me.Invoke(Sub() LineColor(results(99).Value, L15_))
                    Me.Invoke(Sub() LineColor(results(100).Value, L16_))

                    Me.Invoke(Sub() LineColor(results(101).Value, LV2_2))
                    Me.Invoke(Sub() LV2_1.BorderColor = LV2_2.BorderColor)


                    Select Case results(24).Value

                        Case True

                            Me.Invoke(Sub() LineColor(results(82).Value, LV2_3))

                        Case Else

                            Me.Invoke(Sub() LV2_3.BorderColor = LV2_2.BorderColor)

                    End Select


                    Me.Invoke(Sub() LineShape44.BorderColor = LV2_3.BorderColor)
                    Me.Invoke(Sub() LineShape43.BorderColor = LV2_3.BorderColor)
                    Me.Invoke(Sub() LineShape42.BorderColor = LV2_3.BorderColor)
                    Me.Invoke(Sub() LineShape41.BorderColor = LV2_3.BorderColor)
                    Me.Invoke(Sub() LineShape40.BorderColor = LV2_3.BorderColor)
                    Me.Invoke(Sub() LineShape39.BorderColor = LV2_3.BorderColor)
                    Me.Invoke(Sub() LineShape31.BorderColor = LV2_3.BorderColor)
                    Me.Invoke(Sub() LineShape32.BorderColor = LV2_3.BorderColor)
                    Me.Invoke(Sub() LineShape33.BorderColor = LV2_3.BorderColor)
                    Me.Invoke(Sub() LineShape34.BorderColor = LV2_3.BorderColor)
                    Me.Invoke(Sub() LineShape35.BorderColor = LV2_3.BorderColor)
                    Me.Invoke(Sub() LineShape36.BorderColor = LV2_3.BorderColor)
                    Me.Invoke(Sub() LineShape37.BorderColor = LV2_3.BorderColor)
                    Me.Invoke(Sub() LineShape38.BorderColor = LV2_3.BorderColor)
                   

                    Me.Invoke(Sub() LineColor(results(102).Value, LKKU2_1))
                    Me.Invoke(Sub() LKKU2_2.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LKKU2_3.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LKKU2_4.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LineShape7.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LineShape10.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LineShape12.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LineShape11.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LineShape16.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LineShape15.BorderColor = LKKU2_1.BorderColor)


                    Me.Invoke(Sub() LineColor(results(103).Value, L18))
                    Me.Invoke(Sub() LineColor(results(104).Value, L19))
                    Me.Invoke(Sub() LineColor(results(105).Value, L20))
                    Me.Invoke(Sub() LineColor(results(106).Value, L21))
                    Me.Invoke(Sub() LineColor(results(107).Value, L22))
                    Me.Invoke(Sub() LineColor(results(108).Value, L23))
                    Me.Invoke(Sub() LineColor(results(109).Value, L24))
                    Me.Invoke(Sub() LineColor(results(110).Value, L25))
                    Me.Invoke(Sub() LineColor(results(111).Value, L26))
                    Me.Invoke(Sub() LineColor(results(112).Value, L27))
                    Me.Invoke(Sub() LineColor(results(113).Value, L28))
                    Me.Invoke(Sub() LineColor(results(114).Value, L29))
                    Me.Invoke(Sub() LineColor(results(115).Value, L30))
                    Me.Invoke(Sub() LineColor(results(116).Value, L31))

                    Me.Invoke(Sub() LineColor(results(117).Value, LineShape4))

                Next



                Threading.Thread.Sleep(MSPEED + 150)

            Loop

        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try


    End Sub

    Private Sub frmKTP_REB_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        m_server.CancelSubscription(groupKTP_REB_D)
        T_KTP_REB.Abort()

    End Sub

    Private Sub frmKTP_REB_detail_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Select Case btnRp10V1.Text

            Case "Старт"

                btnRp10V1.Text = "Стоп"
                T_KTP_REB = New System.Threading.Thread(AddressOf T_KTP_REB_START)
                T_KTP_REB.Start()

            Case "Стоп"

                btnRp10V1.Text = "Старт"
                m_server.CancelSubscription(groupKTP_REB_D)
                T_KTP_REB.Abort()

        End Select

        VV2_vykl.Cursor = Cursors.Hand
        VV2_vkl.Cursor = Cursors.Hand
        VV2_TV.Cursor = Cursors.Hand

        VV1_vykl.Cursor = Cursors.Hand
        VV1_vkl.Cursor = Cursors.Hand
        VV1_TV.Cursor = Cursors.Hand


        AV_vkl.Cursor = Cursors.Hand
        AV_vykl.Cursor = Cursors.Hand


    End Sub

    Private Sub btnRP10_Click(sender As System.Object, e As System.EventArgs) Handles btnRP10.Click
        frmKTP_REB.MdiParent = frmIndexer
        frmKTP_REB.Show()
        frmKTP_REB.Focus()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        frmRP10.MdiParent = frmIndexer
        frmRP10.Show()
        frmRP10.Focus()
    End Sub

    Private Sub VV1_TV_Click(sender As System.Object, e As System.EventArgs) Handles VV1_TV.Click, VV1_vykl.Click, VV1_vkl.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения КТП РЭБ ВВ1"
        frmUSTAVKI.Show()
    End Sub

    Private Sub VV2_TV_Click(sender As System.Object, e As System.EventArgs) Handles VV2_TV.Click, VV2_vykl.Click, VV2_vkl.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения КТП РЭБ ВВ2"
        frmUSTAVKI.Show()
    End Sub

    Private Sub AV_vkl_Click(sender As System.Object, e As System.EventArgs) Handles AV_vkl.Click, AV_vykl.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения КТП РЭБ АВ"
        frmUSTAVKI.Show()
    End Sub

End Class