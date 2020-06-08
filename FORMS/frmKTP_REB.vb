﻿Public Class frmKTP_REB
    Dim T_KTP_REB As System.Threading.Thread

    Private Sub btnRp10V1_Click(sender As System.Object, e As System.EventArgs) Handles btnRp10V1.Click

        Select Case btnRp10V1.Text

            Case "Старт"

                btnRp10V1.Text = "Стоп"
                T_KTP_REB = New System.Threading.Thread(AddressOf T_KTP_REB_START)
                T_KTP_REB.Start()

            Case "Стоп"

                btnRp10V1.Text = "Старт"
                m_server.CancelSubscription(groupKTP_REB)
                T_KTP_REB.Abort()

        End Select


    End Sub

    Sub T_KTP_REB_START()

        Try
ARG:
            groupStateKTP_REB.Name = "KTPREB"
            groupStateKTP_REB.Active = True
            groupStateKTP_REB.UpdateRate = MSPEED

            groupKTP_REB = DirectCast(m_server.CreateSubscription(groupStateKTP_REB), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(65) {}

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "КТП_РЭБ.С1.ВВ1.CLOSE"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "КТП_РЭБ.С2.ВВ2.CLOSE"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "КТП_РЭБ.С1.ВВ1.TRIP"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "КТП_РЭБ.С2.ВВ2.TRIP"
            '#########################################################


            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "КТП_РЭБ.С1.ВВ1.UBB"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "КТП_РЭБ.С2.ВВ2.UBB"


            '#########################################################
            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "КТП_РЭБ.С1.ВВ1.UA"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "КТП_РЭБ.С1.ВВ1.UB"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "КТП_РЭБ.С1.ВВ1.UC"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "КТП_РЭБ.С1.ВВ1.IA"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "КТП_РЭБ.С1.ВВ1.IB"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "КТП_РЭБ.С1.ВВ1.IC"
            '#########################################################

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "КТП_РЭБ.С2.ВВ2.UA"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "КТП_РЭБ.С2.ВВ2.UB"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "КТП_РЭБ.С2.ВВ2.UC"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "КТП_РЭБ.С2.ВВ2.IA"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "КТП_РЭБ.С2.ВВ2.IB"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "КТП_РЭБ.С2.ВВ2.IC"
            '#########################################################

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "КТП_РЭБ.С1.ККУ.I"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "КТП_РЭБ.С1.ККУ.Q"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "КТП_РЭБ.С1.ККУ.U"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "КТП_РЭБ.С1.ККУ.COS"
            '#########################################################

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "КТП_РЭБ.С2.ККУ.I"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "КТП_РЭБ.С2.ККУ.Q"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "КТП_РЭБ.С2.ККУ.U"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "КТП_РЭБ.С2.ККУ.COS"

            '#########################################################

            'ВВОД 1
            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "КТП_РЭБ.С1.ВВ1.UBB"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "КТП_РЭБ.С1.ВВ1.CLOSE"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "КТП_РЭБ.С1.АВ.A_IZM_DRAWN_OUT1"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "КТП_РЭБ.С1.ВВ1.TRIP"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "КТП_РЭБ.С1.ВВ1.DISCREP_OPEN_CLOSE"

            items(31) = New Global.Opc.Da.Item()
            items(31).ItemName = "КТП_РЭБ.С1.ВВ1.REMOTE_CNTRL_ENABLE"

            items(32) = New Global.Opc.Da.Item()
            items(32).ItemName = "КТП_РЭБ.С1.ВВ1.T_TRANS_HI"

            items(33) = New Global.Opc.Da.Item()
            items(33).ItemName = "КТП_РЭБ.С1.АДЭС.RESERV_NET"

            items(34) = New Global.Opc.Da.Item()
            items(34).ItemName = "КТП_РЭБ.С1.АДЭС.READY"

            items(35) = New Global.Opc.Da.Item()
            items(35).ItemName = "КТП_РЭБ.С1.АДЭС.WORK"

            items(36) = New Global.Opc.Da.Item()
            items(36).ItemName = "КТП_РЭБ.С1.АДЭС.FAULT"

            items(37) = New Global.Opc.Da.Item()
            items(37).ItemName = "КТП_РЭБ.С1.АДЭС.FAIL_STOP"

            items(38) = New Global.Opc.Da.Item()
            items(38).ItemName = "КТП_РЭБ.С1.АВ.AVR_ON"

            items(39) = New Global.Opc.Da.Item()
            items(39).ItemName = "КТП_РЭБ.С1.АВ.CLOSE"

            items(40) = New Global.Opc.Da.Item()
            items(40).ItemName = "КТП_РЭБ.С1.АВ.GENE_OPEN"
            'КТП_ЭБ.С1.АВ.CLOSE

            items(41) = New Global.Opc.Da.Item()
            items(41).ItemName = "КТП_РЭБ.С1.АВ.ALA_I1_A_PSK"

            items(42) = New Global.Opc.Da.Item()
            items(42).ItemName = "КТП_РЭБ.С1.АВ.C_TRIP"

            '#########################################################

            'ВВОД 2
            items(43) = New Global.Opc.Da.Item()
            items(43).ItemName = "КТП_РЭБ.C2.ВВ2.UBB"
            'items(17).ItemName = "КТП_РЭБ.С2.ВВ2.UBB"

            items(44) = New Global.Opc.Da.Item()
            items(44).ItemName = "КТП_РЭБ.С2.ВВ2.CLOSE"

            items(45) = New Global.Opc.Da.Item()
            items(45).ItemName = "КТП_РЭБ.С2.ВВ2.TRIP"

            items(46) = New Global.Opc.Da.Item()
            items(46).ItemName = "КТП_РЭБ.С2.ВВ2.DISCREP_OPEN_CLOSE"

            items(47) = New Global.Opc.Da.Item()
            items(47).ItemName = "КТП_РЭБ.С2.ВВ2.REMOTE_CNTRL_ENABLE"

            items(48) = New Global.Opc.Da.Item()
            items(48).ItemName = "КТП_РЭБ.С2.ВВ2.T_TRANS_HI"

            'Дистанционное(управление)
            items(49) = New Global.Opc.Da.Item()
            items(49).ItemName = "КТП_РЭБ.С1.СВ.REMOTE_CNTRL_ENABLE"

            'Неисправность(ЦУ)
            items(50) = New Global.Opc.Da.Item()
            items(50).ItemName = "КТП_РЭБ.С1.СВ.DISCREP_OPEN_CLOSE"

            'Отключение СВ от защит
            items(51) = New Global.Opc.Da.Item()
            items(51).ItemName = "КТП_РЭБ.С1.СВ.CLOSE_SV_DEFAV"

            'неисправность БМПА
            items(52) = New Global.Opc.Da.Item()
            items(52).ItemName = "КТП_РЭБ.С1.СВ.C_BLOCK_FAILURE"

            'Включение СВ по АВР СВ
            items(53) = New Global.Opc.Da.Item()
            items(53).ItemName = "КТП_РЭБ.С1.СВ.CLOSE_SV_AVRAV"

            'Отключение СВ по автоматике
            items(54) = New Global.Opc.Da.Item()
            items(54).ItemName = "КТП_РЭБ.С1.СВ.C_TRIP"


            items(55) = New Global.Opc.Da.Item()
            items(55).ItemName = "КТП_РЭБ.С1.СВ.AVR_ON"

            items(56) = New Global.Opc.Da.Item()
            items(56).ItemName = "КТП_РЭБ.С1.СВ.CLOSE"

            'КТП_РЭБ.С1.СВ.CLOSE


            items(57) = New Global.Opc.Da.Item()
            items(57).ItemName = "КТП_РЭБ.С1.СВ.TRIP"

            items(58) = New Global.Opc.Da.Item()
            items(58).ItemName = "КТП_РЭБ.С1.ВВ1.VOLT_COLOR"

            items(59) = New Global.Opc.Da.Item()
            items(59).ItemName = "КТП_РЭБ.С1.ККУ.VOLT_COLOR"

            items(60) = New Global.Opc.Da.Item()
            items(60).ItemName = "КТП_РЭБ.С1.АВ.VOLT_COLOR"

            items(61) = New Global.Opc.Da.Item()
            items(61).ItemName = "КТП_РЭБ.С1.СВ.VOLT_COLOR"

            items(62) = New Global.Opc.Da.Item()
            items(62).ItemName = "КТП_РЭБ.С1.VOLT_COLOR"

            items(63) = New Global.Opc.Da.Item()
            items(63).ItemName = "КТП_РЭБ.С2.ВВ2.VOLT_COLOR"

            items(64) = New Global.Opc.Da.Item()
            items(64).ItemName = "КТП_РЭБ.С2.ККУ.VOLT_COLOR"

            items(65) = New Global.Opc.Da.Item()
            items(65).ItemName = "КТП_РЭБ.С2.VOLT_COLOR"


            items = groupKTP_REB.AddItems(items)

            Dim MGg As Double

            Do

                Dim results As ItemValueResult() = Nothing
                results = groupKTP_REB.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1


                    '####################################################################
                    'СВ
                    Select Case results(1).Value

                        'Case False
                        '    Me.Invoke(Sub() CB_VKL.Visible = False)
                        '    Me.Invoke(Sub() CB_VyKL.Visible = False)
                        '    Me.Invoke(Sub() CB_TV.Visible = True)
                        'Case True
                        '    Me.Invoke(Sub() CB_TV.Visible = False)

                        '    Select Case results(0).Value

                        '        Case True

                        '            Me.Invoke(Sub() CB_VKL.Visible = True)
                        '            Me.Invoke(Sub() CB_VyKL.Visible = False)
                        '        Case False
                        '            Me.Invoke(Sub() CB_VKL.Visible = False)
                        '            Me.Invoke(Sub() CB_VyKL.Visible = True)
                        '    End Select

                    End Select

                    '####################################################################

                    MGg = results(5).Value
                    Me.Invoke(Sub() Label2.Text = Math.Round(MGg, 1) & " B")
                    MGg = results(6).Value
                    Me.Invoke(Sub() Label3.Text = Math.Round(MGg, 1) & " B")
                    MGg = results(7).Value
                    Me.Invoke(Sub() Label5.Text = Math.Round(MGg, 1) & " B")

                    MGg = results(8).Value
                    Me.Invoke(Sub() Label8.Text = Math.Round(MGg, 1) & " A")
                    MGg = results(9).Value
                    Me.Invoke(Sub() Label9.Text = Math.Round(MGg, 1) & " A")
                    MGg = results(10).Value
                    Me.Invoke(Sub() Label10.Text = Math.Round(MGg, 1) & " A")


                    MGg = results(11).Value
                    Me.Invoke(Sub() Label11.Text = Math.Round(MGg, 1) & " B")
                    MGg = results(12).Value
                    Me.Invoke(Sub() Label12.Text = Math.Round(MGg, 1) & " B")
                    MGg = results(13).Value
                    Me.Invoke(Sub() Label15.Text = Math.Round(MGg, 1) & " B")

                    MGg = results(14).Value
                    Me.Invoke(Sub() Label16.Text = Math.Round(MGg, 1) & " A")
                    MGg = results(15).Value
                    Me.Invoke(Sub() Label18.Text = Math.Round(MGg, 1) & " A")
                    MGg = results(16).Value
                    Me.Invoke(Sub() Label21.Text = Math.Round(MGg, 1) & " A")

                    MGg = results(4).Value
                    Me.Invoke(Sub() lblV1_UBB.Text = Math.Round(MGg, 1) & " B")

                    MGg = results(17).Value
                    Me.Invoke(Sub() lblV2_UBB.Text = Math.Round(MGg, 1) & " B")

                    '####################################################################

                    MGg = results(18).Value
                    Me.Invoke(Sub() lblKKU1_I.Text = Math.Round(MGg, 1) & " A")

                    MGg = results(19).Value
                    Me.Invoke(Sub() lblKKU1_Q.Text = Math.Round(MGg, 1) & " ВAр")

                    MGg = results(20).Value
                    Me.Invoke(Sub() lblKKU1_U.Text = Math.Round(MGg, 1) & " В")

                    MGg = results(21).Value
                    Me.Invoke(Sub() lblKKU1_COS.Text = Math.Round(MGg, 1))

                    '####################################################################

                    MGg = results(22).Value
                    Me.Invoke(Sub() lblKKU2_I.Text = Math.Round(MGg, 1) & " A")

                    MGg = results(23).Value
                    Me.Invoke(Sub() lblKKU2_Q.Text = Math.Round(MGg, 1) & " ВAр")

                    MGg = results(24).Value
                    Me.Invoke(Sub() lblKKU2_U.Text = Math.Round(MGg, 1) & " В")

                    MGg = results(25).Value
                    Me.Invoke(Sub() lblKKU2_COS.Text = Math.Round(MGg, 1))

                    '####################################################################

                    MGg = results(26).Value
                    Me.Invoke(Sub() lblV1_UBB.Text = Math.Round(MGg, 1) & " B")

                    Select Case results(29).Value
                        Case True
                            Me.Invoke(Sub() lblA1.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA1.BackColor = Color.Transparent)
                    End Select

                    Select Case results(30).Value

                        Case True
                            Me.Invoke(Sub() VV1_vkl.Visible = False)
                            Me.Invoke(Sub() VV1_vykl.Visible = False)
                            Me.Invoke(Sub() VV1_TV.Visible = True)
                        Case False
                            Me.Invoke(Sub() VV1_TV.Visible = False)

                            Select Case results(27).Value

                                Case True
                                    Me.Invoke(Sub() VV1_vkl.Visible = True)
                                    Me.Invoke(Sub() VV1_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VV1_vkl.Visible = False)
                                    Me.Invoke(Sub() VV1_vykl.Visible = True)
                            End Select

                    End Select
                    '#########################################################
                    'Алармы ввода 1
                    Me.Invoke(Sub() lblV1CU.Enabled = results(30).Value)

                    Select Case results(31).Value

                        Case True
                            Me.Invoke(Sub() REMOTE_CNTRL_ENABLE.Enabled = True)
                            Me.Invoke(Sub() REMOTE_CNTRL_DISABLE.Enabled = False)
                        Case False
                            Me.Invoke(Sub() REMOTE_CNTRL_ENABLE.Enabled = False)
                            Me.Invoke(Sub() REMOTE_CNTRL_DISABLE.Enabled = True)
                    End Select

                    Me.Invoke(Sub() lblRT_H_T.Enabled = results(32).Value)

                    'lblRT_H_T

                    'MGg = results(22).Value
                    Me.Invoke(Sub() lblADES_RES.Enabled = results(33).Value)
                    Me.Invoke(Sub() lblADES_READY.Enabled = results(34).Value)
                    Me.Invoke(Sub() lblADES_WORK.Enabled = results(35).Value)
                    Me.Invoke(Sub() lblADES_FAULT.Enabled = results(36).Value)
                    Me.Invoke(Sub() lblADES_FAILSTOP.Enabled = results(37).Value)

                    '########################################################################
                    Select Case results(38).Value

                        Case True
                            Me.Invoke(Sub() Label30.Enabled = True)
                            Me.Invoke(Sub() Label31.Enabled = False)
                        Case False
                            Me.Invoke(Sub() Label30.Enabled = False)
                            Me.Invoke(Sub() Label31.Enabled = True)
                    End Select

                    Select Case results(39).Value

                        Case True
                            Me.Invoke(Sub() AV_vykl.Visible = False)
                            Me.Invoke(Sub() AV_vkl.Visible = True)

                        Case False

                            Me.Invoke(Sub() AV_vykl.Visible = True)
                            Me.Invoke(Sub() AV_vkl.Visible = False)
                    End Select

                    Select Case results(40).Value

                        Case False
                            Me.Invoke(Sub() ADES_VyKL.Visible = False)
                            Me.Invoke(Sub() ADES_VKL.Visible = True)

                        Case True

                            Me.Invoke(Sub() ADES_VyKL.Visible = True)
                            Me.Invoke(Sub() ADES_VKL.Visible = False)
                    End Select

                    MGg = results(41).Value
                    Me.Invoke(Sub() lblSHVA_I.Text = Math.Round(MGg, 1) & " A")

                    Select Case results(42).Value
                        Case True
                            Me.Invoke(Sub() lblA4.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA4.BackColor = Color.Transparent)
                    End Select

                    '##########################################################

                    ' MGg = results(43).Value
                    ' Me.Invoke(Sub() lblV2_UBB.Text = Math.Round(MGg, 1) & " B")

                    Select Case results(45).Value
                        Case True
                            Me.Invoke(Sub() lblA2.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA2.BackColor = Color.Transparent)
                    End Select

                    Select Case results(46).Value

                        Case True
                            Me.Invoke(Sub() VV2_vkl.Visible = False)
                            Me.Invoke(Sub() VV2_vykl.Visible = False)
                            Me.Invoke(Sub() VV2_TV.Visible = True)
                        Case False
                            Me.Invoke(Sub() VV2_TV.Visible = False)

                            Select Case results(44).Value

                                Case True
                                    Me.Invoke(Sub() VV2_vkl.Visible = True)
                                    Me.Invoke(Sub() VV2_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VV2_vkl.Visible = False)
                                    Me.Invoke(Sub() VV2_vykl.Visible = True)
                            End Select

                    End Select


                    '#########################################################
                    'Алармы ввода 2

                    Me.Invoke(Sub() lblV2CU.Enabled = results(46).Value)

                    Select Case results(47).Value

                        Case True
                            Me.Invoke(Sub() REMOTE_CNTRL_ENABLE2.Enabled = True)
                            Me.Invoke(Sub() REMOTE_CNTRL_DISABLE2.Enabled = False)
                        Case False
                            Me.Invoke(Sub() REMOTE_CNTRL_ENABLE2.Enabled = False)
                            Me.Invoke(Sub() REMOTE_CNTRL_DISABLE2.Enabled = True)
                    End Select

                    Me.Invoke(Sub() lblRT_H_T2.Enabled = results(48).Value)

                    '#############################################################
                    'Алармы СВ

                    Select Case results(49).Value

                        Case True
                            Me.Invoke(Sub() REMOTE_CNTRL_ENABLE3.Enabled = True)
                            Me.Invoke(Sub() REMOTE_CNTRL_DISABLE3.Enabled = False)
                        Case False
                            Me.Invoke(Sub() REMOTE_CNTRL_ENABLE3.Enabled = False)
                            Me.Invoke(Sub() REMOTE_CNTRL_DISABLE3.Enabled = True)
                    End Select

                    Me.Invoke(Sub() lblV3CU.Enabled = results(50).Value)

                    Me.Invoke(Sub() CLOSE_SV_ZA.Enabled = results(51).Value)
                    Me.Invoke(Sub() neis_BMPA.Enabled = results(52).Value)
                    Me.Invoke(Sub() VKL_SV_AVR.Enabled = results(53).Value)
                    Me.Invoke(Sub() VyKL_SV_AVR.Enabled = results(54).Value)

                    '#############################################################

                    '#############################################################
                    'AVR SV
                    Select Case results(55).Value

                        Case True
                            Me.Invoke(Sub() lblAVR_vkl.Enabled = True)
                            Me.Invoke(Sub() lblAVR_vykl.Enabled = False)
                        Case False
                            Me.Invoke(Sub() lblAVR_vkl.Enabled = False)
                            Me.Invoke(Sub() lblAVR_vykl.Enabled = True)
                    End Select

                    Select Case results(56).Value

                        Case True

                            Me.Invoke(Sub() SV_vkl.Visible = True)
                            Me.Invoke(Sub() SV_vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() SV_vkl.Visible = False)
                            Me.Invoke(Sub() SV_vykl.Visible = True)
                    End Select

                    Select Case results(57).Value
                        Case True
                            Me.Invoke(Sub() lblA3Sv.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA3Sv.BackColor = Color.Transparent)
                    End Select

                    Me.Invoke(Sub() LineColor(results(62).Value, LC1_2))
                    Me.Invoke(Sub() LC1_1.BorderColor = LC1_2.BorderColor)

                    Me.Invoke(Sub() LineColor(results(58).Value, LV1_1))
                    Me.Invoke(Sub() LV1_2.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() LV1_3.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() LV1_5.BorderColor = LV1_1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(60).Value, LineShape10))

                    Me.Invoke(Sub() LineColor(results(59).Value, LKKU_1))
                    Me.Invoke(Sub() LKKU_2.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LKKU_3.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LKKU_4.BorderColor = LKKU_1.BorderColor)

                    Me.Invoke(Sub() LineShape4.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape5.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape9.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape8.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape13.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape14.BorderColor = LKKU_1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(61).Value, LineShape1))
                    Me.Invoke(Sub() LineShape2.BorderColor = LineShape1.BorderColor)
                    Me.Invoke(Sub() LineShape3.BorderColor = LineShape1.BorderColor)


                    Me.Invoke(Sub() LineColor(results(65).Value, LC2_2))
                    Me.Invoke(Sub() LC2_1.BorderColor = LC2_2.BorderColor)




                    Select Case results(56).Value

                        Case True

                            Me.Invoke(Sub() LineColor(results(61).Value, LV2_1))

                        Case Else

                            Me.Invoke(Sub() LineColor(results(63).Value, LV2_1))

                    End Select

                    Me.Invoke(Sub() LV2_3.BorderColor = LV2_1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(64).Value, LKKU2_1))
                    Me.Invoke(Sub() LKKU2_2.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LKKU2_3.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LKKU2_4.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LineShape6.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LineShape7.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LineShape11.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LineShape12.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LineShape15.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LineShape16.BorderColor = LKKU2_1.BorderColor)


                Next

                Threading.Thread.Sleep(MSPEED + 150)

            Loop

        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try


    End Sub

    Private Sub frmKTP_REB_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        m_server.CancelSubscription(groupKTP_REB)
        T_KTP_REB.Abort()

    End Sub

    Private Sub frmKTP_REB_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Select Case btnRp10V1.Text

            Case "Старт"

                btnRp10V1.Text = "Стоп"
                T_KTP_REB = New System.Threading.Thread(AddressOf T_KTP_REB_START)
                T_KTP_REB.Start()

            Case "Стоп"

                btnRp10V1.Text = "Старт"
                m_server.CancelSubscription(groupKTP_REB)
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        frmKTP_REB_Detail.MdiParent = frmIndexer
        frmKTP_REB_Detail.Show()
        frmKTP_REB_Detail.Focus()

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