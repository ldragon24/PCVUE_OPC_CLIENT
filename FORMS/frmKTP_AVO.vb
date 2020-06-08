Public Class frmKTP_AVO
    Dim T_KTP_AVO As System.Threading.Thread

    Private Sub btnRp10V1_Click(sender As System.Object, e As System.EventArgs)

        Select Case btnRp10V1.Text

            Case "Старт"

                btnRp10V1.Text = "Стоп"
                T_KTP_AVO = New System.Threading.Thread(AddressOf T_KTP_AVO_START)
                T_KTP_AVO.Start()

            Case "Стоп"

                btnRp10V1.Text = "Старт"
                m_server.CancelSubscription(groupKTP_AVO)
                T_KTP_AVO.Abort()

        End Select


    End Sub

    Sub T_KTP_AVO_START()
        Try
ARG:
            groupStateKTP_AVO.Name = "KTPAVO"
            groupStateKTP_AVO.Active = True
            groupStateKTP_AVO.UpdateRate = MSPEED

            groupKTP_AVO = DirectCast(m_server.CreateSubscription(groupStateKTP_AVO), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(82) {}

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С1.9_СВ.CLOSE"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С1.9_СВ.DI"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С1.9_СВ.EARTH_SWITCH"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С2.18_СР.DI"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С1.9_СВ.TRIP"

            '#########################################################
            '3 фидер - КТП ЭБ

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С1.4_ФИД.CLOSE"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С1.4_ФИД.DI"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С1.4_ФИД.I1"

            'Нож заземления
            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С1.4_ФИД.EARTH_SWITCH"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С1.4_ФИД.TRIP"
            '#########################################################

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С2.13_ФИД.CLOSE"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С2.13_ФИД.DI"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С2.13_ФИД.I1"

            'Нож заземления
            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С2.13_ФИД.EARTH_SWITCH"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С2.13_ФИД.TRIP"

            '#########################################################################
            '#########################################################################
            'ВВОД 1
            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "КТП_АВО.С1.ВВ1.UBB"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "КТП_АВО.С1.ВВ1.CLOSE"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "КТП_АВО.С1.АВ.A_IZM_DRAWN_OUT1"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "КТП_АВО.С1.ВВ1.TRIP"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "КТП_АВО.С1.ВВ1.DISCREP_OPEN_CLOSE"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "КТП_АВО.С1.ВВ1.REMOTE_CNTRL_ENABLE"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "КТП_АВО.С1.ВВ1.T_TRANS_HI"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "КТП_АВО.С1.ВВ1.AVR_SV_ON"


            '###############################################################
            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "КТП_АВО.С1.АДЭС.READY"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "КТП_АВО.С1.АДЭС.WORK"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "КТП_АВО.С1.АДЭС.FAULT"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "КТП_АВО.С1.АДЭС.FAIL_STOP"

            items(36) = New Global.Opc.Da.Item()
            items(36).ItemName = "КТП_АВО.С1.QF13.CLOSE"

            items(37) = New Global.Opc.Da.Item()
            items(37).ItemName = "КТП_АВО.С1.QF13.DOC"

            items(38) = New Global.Opc.Da.Item()
            items(38).ItemName = "КТП_АВО.С2.QF23.CLOSE"

            items(39) = New Global.Opc.Da.Item()
            items(39).ItemName = "КТП_АВО.С2.QF23.DOC"

            '###############################################################


            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "КТП_АВО.С1.АВ.AVR_ON"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "КТП_АВО.С1.АВ.A_IZM_AG2_OPEN"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "КТП_АВО.С1.АВ.A_IZM_CLOSE"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "КТП_АВО.С1.АВ.ALA_I1_A_PSK"

            items(31) = New Global.Opc.Da.Item()
            items(31).ItemName = "КТП_АВО.С1.ККУ.I"

            items(32) = New Global.Opc.Da.Item()
            items(32).ItemName = "КТП_АВО.С1.ККУ.RPOW"

            items(33) = New Global.Opc.Da.Item()
            items(33).ItemName = "КТП_АВО.С1.ККУ.U"

            items(34) = New Global.Opc.Da.Item()
            items(34).ItemName = "КТП_АВО.С1.ККУ.COS"

            items(35) = New Global.Opc.Da.Item()
            items(35).ItemName = "КТП_АВО.С1.АВ.C_TRIP"

            '############################################################################

            items(40) = New Global.Opc.Da.Item()
            items(40).ItemName = "КТП_АВО.С1.СВ.AVR_ON"

            items(41) = New Global.Opc.Da.Item()
            items(41).ItemName = "КТП_АВО.С1.СВ.CLOSE"

            items(42) = New Global.Opc.Da.Item()
            items(42).ItemName = "КТП_АВО.С1.СВ.TRIP"
            '############################################################################
            'ВВОД 2
            items(43) = New Global.Opc.Da.Item()
            items(43).ItemName = "КТП_АВО.С2.ВВ2.UBB"

            items(44) = New Global.Opc.Da.Item()
            items(44).ItemName = "КТП_АВО.С2.ВВ2.CLOSE"

            items(45) = New Global.Opc.Da.Item()
            items(45).ItemName = "КТП_АВО.С2.ВВ2.TRIP"

            items(46) = New Global.Opc.Da.Item()
            items(46).ItemName = "КТП_АВО.С2.ВВ2.DISCREP_OPEN_CLOSE"


            items(47) = New Global.Opc.Da.Item()
            items(47).ItemName = "КТП_АВО.С2.ВВ2.REMOTE_CNTRL_ENABLE"

            items(48) = New Global.Opc.Da.Item()
            items(48).ItemName = "КТП_АВО.С2.ВВ2.T_TRANS_HI"


            items(49) = New Global.Opc.Da.Item()
            items(49).ItemName = "КТП_АВО.С2.ККУ.I"

            items(50) = New Global.Opc.Da.Item()
            items(50).ItemName = "КТП_АВО.С2.ККУ.RPOW"

            items(51) = New Global.Opc.Da.Item()
            items(51).ItemName = "КТП_АВО.С2.ККУ.U"

            items(52) = New Global.Opc.Da.Item()
            items(52).ItemName = "КТП_АВО.С2.ККУ.COS"


            'Дистанционное(управление)
            items(53) = New Global.Opc.Da.Item()
            items(53).ItemName = "КТП_АВО.С1.СВ.REMOTE_CNTRL_ENABLE"

            'Неисправность(ЦУ)
            items(54) = New Global.Opc.Da.Item()
            items(54).ItemName = "КТП_АВО.С1.СВ.DISCREP_OPEN_CLOSE"

            'Отключение СВ от защит
            items(55) = New Global.Opc.Da.Item()
            items(55).ItemName = "КТП_АВО.С1.СВ.CLOSE_SV_DEFAV"

            'неисправность БМПА
            items(56) = New Global.Opc.Da.Item()
            items(56).ItemName = "КТП_АВО.С1.СВ.C_BLOCK_FAILURE"

            'Включение СВ по АВР СВ
            items(57) = New Global.Opc.Da.Item()
            items(57).ItemName = "КТП_АВО.С1.СВ.CLOSE_SV_AVRAV"

            'Отключение СВ по автоматике
            items(58) = New Global.Opc.Da.Item()
            items(58).ItemName = "КТП_АВО.С1.СВ.C_TRIP"
            '#####################################################
            items(59) = New Global.Opc.Da.Item()
            items(59).ItemName = "КТП_АВО.С1.ВВ1.UA"

            items(60) = New Global.Opc.Da.Item()
            items(60).ItemName = "КТП_АВО.С1.ВВ1.UB"

            items(61) = New Global.Opc.Da.Item()
            items(61).ItemName = "КТП_АВО.С1.ВВ1.UC"


            items(62) = New Global.Opc.Da.Item()
            items(62).ItemName = "КТП_АВО.С1.ВВ1.IA"

            items(63) = New Global.Opc.Da.Item()
            items(63).ItemName = "КТП_АВО.С1.ВВ1.IB"

            items(64) = New Global.Opc.Da.Item()
            items(64).ItemName = "КТП_АВО.С1.ВВ1.IC"
            '#####################################################
            items(65) = New Global.Opc.Da.Item()
            items(65).ItemName = "КТП_АВО.С2.ВВ2.UA"

            items(66) = New Global.Opc.Da.Item()
            items(66).ItemName = "КТП_АВО.С2.ВВ2.UB"

            items(67) = New Global.Opc.Da.Item()
            items(67).ItemName = "КТП_АВО.С2.ВВ2.UC"


            items(68) = New Global.Opc.Da.Item()
            items(68).ItemName = "КТП_АВО.С2.ВВ2.IA"

            items(69) = New Global.Opc.Da.Item()
            items(69).ItemName = "КТП_АВО.С2.ВВ2.IB"

            items(70) = New Global.Opc.Da.Item()
            items(70).ItemName = "КТП_АВО.С2.ВВ2.IC"

            '##################################################
            items(71) = New Global.Opc.Da.Item()
            items(71).ItemName = "РП10.С2.18_СР.VOLT_COLOR"

            items(72) = New Global.Opc.Da.Item()
            items(72).ItemName = "РП10.С2.10_ВВОД.VOLT_COLOR"

            items(73) = New Global.Opc.Da.Item()
            items(73).ItemName = "РП10.С1.1_ВВОД.VOLT_COLOR"

            items(74) = New Global.Opc.Da.Item()
            items(74).ItemName = "РП10.С1.4_ФИД.VOLT_COLOR"

            items(75) = New Global.Opc.Da.Item()
            items(75).ItemName = "РП10.С2.13_ФИД.VOLT_COLOR"


            items(76) = New Global.Opc.Da.Item()
            items(76).ItemName = "КТП_АВО.С1.VOLT_COLOR"

            items(77) = New Global.Opc.Da.Item()
            items(77).ItemName = "КТП_АВО.С2.VOLT_COLOR"

            items(78) = New Global.Opc.Da.Item()
            items(78).ItemName = "КТП_АВО.С1.ККУ.VOLT_COLOR"

            items(79) = New Global.Opc.Da.Item()
            items(79).ItemName = "КТП_АВО.С1.ВВ1.VOLT_COLOR"

            items(80) = New Global.Opc.Da.Item()
            items(80).ItemName = "КТП_АВО.С1.СВ.VOLT_COLOR"

            items(81) = New Global.Opc.Da.Item()
            items(81).ItemName = "КТП_АВО.С2.ВВ2.VOLT_COLOR"

            items(82) = New Global.Opc.Da.Item()
            items(82).ItemName = "КТП_АВО.С2.ККУ.VOLT_COLOR"


            items = groupKTP_AVO.AddItems(items)

            Dim MGg As Double

            Do

                Dim results As ItemValueResult() = Nothing
                results = groupKTP_AVO.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Select Case results(1).Value

                        Case False
                            Me.Invoke(Sub() CB_VKL.Visible = False)
                            Me.Invoke(Sub() CB_VyKL.Visible = False)
                            Me.Invoke(Sub() CB_TV.Visible = True)
                        Case True
                            Me.Invoke(Sub() CB_TV.Visible = False)

                            Select Case results(0).Value

                                Case True

                                    Me.Invoke(Sub() CB_VKL.Visible = True)
                                    Me.Invoke(Sub() CB_VyKL.Visible = False)
                                Case False
                                    Me.Invoke(Sub() CB_VKL.Visible = False)
                                    Me.Invoke(Sub() CB_VyKL.Visible = True)
                            End Select

                    End Select

                    '####################################################################
                    'CP
                    Select Case results(3).Value

                        Case False
                            Me.Invoke(Sub() CP_VKL.Visible = False)
                            Me.Invoke(Sub() CP_VyKL.Visible = False)
                            Me.Invoke(Sub() CP_TV.Visible = True)
                        Case True
                            Me.Invoke(Sub() CP_TV.Visible = False)
                            Me.Invoke(Sub() CP_VKL.Visible = True)
                    End Select

                    '####################################################################
                    'Качество сигнала (Quality)
                    Select Case results(2).Quality.ToString

                        Case "good"
                            Me.Invoke(Sub() lblCB_EA.Visible = False)

                            Select Case results(19).Value

                                Case True

                                    Me.Invoke(Sub() CB_EA_VKL.Visible = False)
                                    Me.Invoke(Sub() CB_EA_VyKL.Visible = True)
                                Case False
                                    
                                    Me.Invoke(Sub() CB_EA_VKL.Visible = True)
                                    Me.Invoke(Sub() CB_EA_VyKL.Visible = False)
                            End Select

                        Case Else
                            Me.Invoke(Sub() CB_EA_VKL.Visible = False)
                            Me.Invoke(Sub() CB_EA_VyKL.Visible = False)
                            Me.Invoke(Sub() lblCB_EA.Visible = True)
                    End Select

                    '####################################################################
                    'Аварийная сигнализация
                    Select Case results(4).Value
                        Case True
                            Me.Invoke(Sub() lblA9.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA9.BackColor = Color.Transparent)
                    End Select

                    '####################################################################
                    'F3
                    Select Case results(6).Value

                        Case False
                            Me.Invoke(Sub() VVOD1_F3_VKL.Visible = False)
                            Me.Invoke(Sub() VVOD1_F3_VyKL.Visible = False)
                            Me.Invoke(Sub() VVOD1_F3_TV.Visible = True)
                        Case True
                            Me.Invoke(Sub() VVOD1_F3_TV.Visible = False)

                            Select Case results(5).Value

                                Case True
                                    Me.Invoke(Sub() VVOD1_F3_VKL.Visible = True)
                                    Me.Invoke(Sub() VVOD1_F3_VyKL.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VVOD1_F3_VKL.Visible = False)
                                    Me.Invoke(Sub() VVOD1_F3_VyKL.Visible = True)
                            End Select

                    End Select

                    MGg = results(7).Value
                    Me.Invoke(Sub() lblF3.Text = Math.Round(MGg, 1) & " A")

                    Select Case results(8).Value

                        Case True

                            Me.Invoke(Sub() VVOD1_F3_EA_Vkl.Visible = True)
                            Me.Invoke(Sub() VVOD1_F3_EA_Vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() VVOD1_F3_EA_Vkl.Visible = False)
                            Me.Invoke(Sub() VVOD1_F3_EA_Vykl.Visible = True)
                    End Select

                    Select Case results(9).Value
                        Case True
                            Me.Invoke(Sub() lblA3.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA3.BackColor = Color.Transparent)
                    End Select

                    '#########################################################
                    '12 фидер - КТП ЭБ С2

                    Select Case results(11).Value

                        Case False
                            Me.Invoke(Sub() VVOD2_F12_Vkl.Visible = False)
                            Me.Invoke(Sub() VVOD2_F12_Vykl.Visible = False)
                            Me.Invoke(Sub() VVOD2_F12_TV.Visible = True)
                        Case True
                            Me.Invoke(Sub() VVOD2_F12_TV.Visible = False)

                            Select Case results(10).Value

                                Case True
                                    Me.Invoke(Sub() VVOD2_F12_Vkl.Visible = True)
                                    Me.Invoke(Sub() VVOD2_F12_Vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VVOD2_F12_Vkl.Visible = False)
                                    Me.Invoke(Sub() VVOD2_F12_Vykl.Visible = True)
                            End Select

                    End Select

                    MGg = results(12).Value
                    Me.Invoke(Sub() lbl_F12.Text = Math.Round(MGg, 1) & " A")

                    Select Case results(13).Value

                        Case True

                            Me.Invoke(Sub() VVOD2_F12_EA_VKL.Visible = True)
                            Me.Invoke(Sub() VVOD2_F12_EA_VyKL.Visible = False)
                        Case False
                            Me.Invoke(Sub() VVOD2_F12_EA_VKL.Visible = False)
                            Me.Invoke(Sub() VVOD2_F12_EA_VyKL.Visible = True)
                    End Select

                    Select Case results(14).Value
                        Case True
                            Me.Invoke(Sub() lblA12.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA12.BackColor = Color.Transparent)
                    End Select

                    '#########################################################

                    MGg = results(15).Value
                    Me.Invoke(Sub() lblV1_UBB.Text = Math.Round(MGg, 1) & " B")

                    Select Case results(18).Value
                        Case True
                            Me.Invoke(Sub() lblA1.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA1.BackColor = Color.Transparent)
                    End Select

                    Select Case results(17).Value

                        Case True
                            Me.Invoke(Sub() VV1_vkl.Visible = False)
                            Me.Invoke(Sub() VV1_vykl.Visible = False)
                            Me.Invoke(Sub() VV1_TV.Visible = True)
                        Case False
                            Me.Invoke(Sub() VV1_TV.Visible = False)

                            Select Case results(16).Value

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
                    Me.Invoke(Sub() lblV1CU.Enabled = results(19).Value)

                    Select Case results(20).Value

                        Case True
                            Me.Invoke(Sub() REMOTE_CNTRL_ENABLE.Enabled = True)
                            Me.Invoke(Sub() REMOTE_CNTRL_DISABLE.Enabled = False)
                        Case False
                            Me.Invoke(Sub() REMOTE_CNTRL_ENABLE.Enabled = False)
                            Me.Invoke(Sub() REMOTE_CNTRL_DISABLE.Enabled = True)
                    End Select

                    Me.Invoke(Sub() lblRT_H_T.Enabled = results(21).Value)

                    'lblRT_H_T

                    '########################################################################

                    Select Case results(31).Quality.ToString

                        Case "good"

                            MGg = results(31).Value
                            Me.Invoke(Sub() lblKKU1_I.Text = Math.Round(MGg, 1) & " A")
                            Me.Invoke(Sub() lblKKU1_I.BackColor = Color.Transparent)
                        Case Else

                            Me.Invoke(Sub() lblKKU1_I.Text = "?")
                            Me.Invoke(Sub() lblKKU1_I.BackColor = Color.Pink)
                            Me.Invoke(Sub() lblKKU1_I.ForeColor = Color.Tomato)
                    End Select


                    Select Case results(32).Quality.ToString

                        Case "good"

                            MGg = results(32).Value
                            Me.Invoke(Sub() lblKKU1_Q.Text = Math.Round(MGg, 1) & " ВAр")
                            Me.Invoke(Sub() lblKKU1_Q.BackColor = Color.Transparent)
                        Case Else

                            Me.Invoke(Sub() lblKKU1_Q.Text = "?")
                            Me.Invoke(Sub() lblKKU1_Q.BackColor = Color.Pink)
                            Me.Invoke(Sub() lblKKU1_Q.ForeColor = Color.Tomato)
                    End Select

                    Select Case results(33).Quality.ToString

                        Case "good"

                            MGg = results(33).Value
                            Me.Invoke(Sub() lblKKU1_U.Text = Math.Round(MGg, 1) & " В")
                            Me.Invoke(Sub() lblKKU1_U.BackColor = Color.Transparent)
                        Case Else

                            Me.Invoke(Sub() lblKKU1_U.Text = "?")
                            Me.Invoke(Sub() lblKKU1_U.BackColor = Color.Pink)
                            Me.Invoke(Sub() lblKKU1_U.ForeColor = Color.Tomato)
                    End Select


                    Select Case results(34).Quality.ToString

                        Case "good"

                            MGg = results(34).Value
                            Me.Invoke(Sub() lblKKU1_COS.Text = Math.Round(MGg, 1))
                            Me.Invoke(Sub() lblKKU1_COS.BackColor = Color.Transparent)
                        Case Else

                            Me.Invoke(Sub() lblKKU1_COS.Text = "?")
                            Me.Invoke(Sub() lblKKU1_COS.BackColor = Color.Pink)
                            Me.Invoke(Sub() lblKKU1_COS.ForeColor = Color.Tomato)
                    End Select



                    'lblA4


                    '#############################################################
                    'AVR SV
                    Select Case results(40).Value

                        Case True
                            Me.Invoke(Sub() lblAVR_vkl.Enabled = True)
                            Me.Invoke(Sub() lblAVR_vykl.Enabled = False)
                        Case False
                            Me.Invoke(Sub() lblAVR_vkl.Enabled = False)
                            Me.Invoke(Sub() lblAVR_vykl.Enabled = True)
                    End Select

                    Select Case results(41).Value

                        Case True

                            Me.Invoke(Sub() SV_vkl.Visible = True)
                            Me.Invoke(Sub() SV_vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() SV_vkl.Visible = False)
                            Me.Invoke(Sub() SV_vykl.Visible = True)
                    End Select

                    Select Case results(42).Value
                        Case True
                            Me.Invoke(Sub() lblA3Sv.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA3Sv.BackColor = Color.Transparent)
                    End Select

                    '#############################################################
                    ''ВВОД 2

                    MGg = results(43).Value
                    Me.Invoke(Sub() lblV2_UBB.Text = Math.Round(MGg, 1) & " B")


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


                    Select Case results(49).Quality.ToString

                        Case "good"

                            MGg = results(49).Value
                            Me.Invoke(Sub() lblKKU2_I.Text = Math.Round(MGg, 1) & " A")
                            Me.Invoke(Sub() lblKKU2_I.BackColor = Color.Transparent)
                        Case Else


                            Me.Invoke(Sub() lblKKU2_I.Text = "?")
                            Me.Invoke(Sub() lblKKU2_I.BackColor = Color.Pink)
                            Me.Invoke(Sub() lblKKU2_I.ForeColor = Color.Tomato)
                    End Select

                    Select Case results(50).Quality.ToString

                        Case "good"

                            MGg = results(50).Value
                            Me.Invoke(Sub() lblKKU2_Q.Text = Math.Round(MGg, 1) & " ВAр")
                            Me.Invoke(Sub() lblKKU2_Q.BackColor = Color.Transparent)
                        Case Else


                            Me.Invoke(Sub() lblKKU2_Q.Text = "?")
                            Me.Invoke(Sub() lblKKU2_Q.BackColor = Color.Pink)
                            Me.Invoke(Sub() lblKKU2_Q.ForeColor = Color.Tomato)
                    End Select

                    Select Case results(50).Quality.ToString

                        Case "good"

                            MGg = results(51).Value
                            Me.Invoke(Sub() lblKKU2_U.Text = Math.Round(MGg, 1) & " В")
                            Me.Invoke(Sub() lblKKU2_U.BackColor = Color.Transparent)
                        Case Else


                            Me.Invoke(Sub() lblKKU2_U.Text = "?")
                            Me.Invoke(Sub() lblKKU2_U.BackColor = Color.Pink)
                            Me.Invoke(Sub() lblKKU2_U.ForeColor = Color.Tomato)
                    End Select

                    Select Case results(52).Quality.ToString

                        Case "good"

                            MGg = results(52).Value
                            Me.Invoke(Sub() lblKKU2_COS.Text = Math.Round(MGg, 1))
                            Me.Invoke(Sub() lblKKU2_COS.BackColor = Color.Transparent)
                        Case Else

                            Me.Invoke(Sub() lblKKU2_COS.Text = "?")
                            Me.Invoke(Sub() lblKKU2_COS.BackColor = Color.Pink)
                            Me.Invoke(Sub() lblKKU2_COS.ForeColor = Color.Tomato)
                    End Select


                   

                    '#############################################################
                    'Алармы СВ

                    Select Case results(53).Value

                        Case True
                            Me.Invoke(Sub() REMOTE_CNTRL_ENABLE3.Enabled = True)
                            Me.Invoke(Sub() REMOTE_CNTRL_DISABLE3.Enabled = False)
                        Case False
                            Me.Invoke(Sub() REMOTE_CNTRL_ENABLE3.Enabled = False)
                            Me.Invoke(Sub() REMOTE_CNTRL_DISABLE3.Enabled = True)
                    End Select

                    Me.Invoke(Sub() lblV3CU.Enabled = results(54).Value)

                    Me.Invoke(Sub() CLOSE_SV_ZA.Enabled = results(55).Value)
                    Me.Invoke(Sub() neis_BMPA.Enabled = results(56).Value)
                    Me.Invoke(Sub() VKL_SV_AVR.Enabled = results(57).Value)
                    Me.Invoke(Sub() VyKL_SV_AVR.Enabled = results(58).Value)


                    '#############################################################
                    'UA

                    MGg = results(59).Value
                    Me.Invoke(Sub() Label26.Text = Math.Round(MGg, 1) & " B")
                    MGg = results(60).Value
                    Me.Invoke(Sub() Label23.Text = Math.Round(MGg, 1) & " B")
                    MGg = results(61).Value
                    Me.Invoke(Sub() Label16.Text = Math.Round(MGg, 1) & " B")

                    MGg = results(62).Value
                    Me.Invoke(Sub() Label24.Text = Math.Round(MGg, 1) & " A")
                    MGg = results(63).Value
                    Me.Invoke(Sub() Label18.Text = Math.Round(MGg, 1) & " A")
                    MGg = results(64).Value
                    Me.Invoke(Sub() Label21.Text = Math.Round(MGg, 1) & " A")
                    '#############################################################
                    'UA

                    MGg = results(65).Value
                    Me.Invoke(Sub() Label15.Text = Math.Round(MGg, 1) & " B")
                    MGg = results(66).Value
                    Me.Invoke(Sub() Label13.Text = Math.Round(MGg, 1) & " B")
                    MGg = results(67).Value
                    Me.Invoke(Sub() Label11.Text = Math.Round(MGg, 1) & " B")

                    MGg = results(68).Value
                    Me.Invoke(Sub() Label12.Text = Math.Round(MGg, 1) & " A")
                    MGg = results(69).Value
                    Me.Invoke(Sub() Label9.Text = Math.Round(MGg, 1) & " A")
                    MGg = results(70).Value
                    Me.Invoke(Sub() Label10.Text = Math.Round(MGg, 1) & " A")


                    'AVR SV
                    Select Case results(22).Value

                        Case True
                            Me.Invoke(Sub() Label8.Enabled = True)
                            Me.Invoke(Sub() Label2.Enabled = False)
                        Case False
                            Me.Invoke(Sub() Label8.Enabled = False)
                            Me.Invoke(Sub() Label2.Enabled = True)
                    End Select

                    '#####################################################
                    Me.Invoke(Sub() LineColor(results(71).Value, L1))
                    Me.Invoke(Sub() L2.BorderColor = L1.BorderColor)
                    Me.Invoke(Sub() L3.BorderColor = L1.BorderColor)
                    Me.Invoke(Sub() L4.BorderColor = L1.BorderColor)
                    Me.Invoke(Sub() L5.BorderColor = L1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(72).Value, L6))
                    Me.Invoke(Sub() L7.BorderColor = L6.BorderColor)
                    Me.Invoke(Sub() L8.BorderColor = L6.BorderColor)

                    Me.Invoke(Sub() LineColor(results(73).Value, L9))
                    Me.Invoke(Sub() L10.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() L11.BorderColor = L9.BorderColor)

                    Me.Invoke(Sub() LineColor(results(74).Value, L1_1))
                    Me.Invoke(Sub() L1_2.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_3.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_4.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_5.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_6.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_7.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_8.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_9.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_10.BorderColor = L1_1.BorderColor)



                    Me.Invoke(Sub() LineColor(results(75).Value, L2_1))
                    Me.Invoke(Sub() L2_2.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L2_3.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L2_4.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L2_5.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L2_6.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L2_7.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L2_8.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L2_9.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L2_10.BorderColor = L1_1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(76).Value, LC1_2))
                    Me.Invoke(Sub() LC1_1.BorderColor = LC1_2.BorderColor)

                    Me.Invoke(Sub() LineColor(results(77).Value, LC2_2))
                    Me.Invoke(Sub() LC2_1.BorderColor = LC2_2.BorderColor)


                    Me.Invoke(Sub() LineColor(results(79).Value, LV1_1))
                    Me.Invoke(Sub() LV1_2.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() LV1_3.BorderColor = LV1_1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(78).Value, LKKU_1))
                    Me.Invoke(Sub() LKKU_2.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LKKU_3.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LKKU_4.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape4.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape5.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape9.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape8.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape13.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape14.BorderColor = LKKU_1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(80).Value, LineShape1))
                    Me.Invoke(Sub() LineShape2.BorderColor = LineShape1.BorderColor)
                    Me.Invoke(Sub() LineShape3.BorderColor = LineShape1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(82).Value, LV2_1))
                    Me.Invoke(Sub() LV2_3.BorderColor = LV2_1.BorderColor)


                    Me.Invoke(Sub() LineColor(results(81).Value, LKKU2_1))
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

                Threading.Thread.Sleep(MSPEED + 125)

            Loop

        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Private Sub KTP_AVO_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        m_server.CancelSubscription(groupKTP_AVO)
        T_KTP_AVO.Abort()


    End Sub


    Private Sub KTP_AVO_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Select Case btnRp10V1.Text

            Case "Старт"

                btnRp10V1.Text = "Стоп"
                T_KTP_AVO = New System.Threading.Thread(AddressOf T_KTP_AVO_START)
                T_KTP_AVO.Start()

            Case "Стоп"

                btnRp10V1.Text = "Старт"
                m_server.CancelSubscription(groupStateKTP_AVO)
                T_KTP_AVO.Abort()

        End Select

        VV2_vykl.Cursor = Cursors.Hand
        VV2_vkl.Cursor = Cursors.Hand
        VV2_TV.Cursor = Cursors.Hand

        VV1_vykl.Cursor = Cursors.Hand
        VV1_vkl.Cursor = Cursors.Hand
        VV1_TV.Cursor = Cursors.Hand


        VVOD1_F3_VyKL.Cursor = Cursors.Hand
        VVOD1_F3_VKL.Cursor = Cursors.Hand
        VVOD1_F3_TV.Cursor = Cursors.Hand

        VVOD2_F12_Vykl.Cursor = Cursors.Hand
        VVOD2_F12_Vkl.Cursor = Cursors.Hand
        VVOD2_F12_TV.Cursor = Cursors.Hand

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        frmRP10.MdiParent = frmIndexer
        frmRP10.Show()
        frmRP10.Focus()
    End Sub

    Private Sub VVOD1_F3_Vykl_Click(sender As System.Object, e As System.EventArgs) Handles VVOD1_F3_VyKL.Click, VVOD1_F3_VKL.Click, VVOD1_F3_TV.Click

        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ Фидер 4"
        frmUSTAVKI.Show()

    End Sub

    Private Sub VVOD2_F12_Vykl_Click(sender As System.Object, e As System.EventArgs) Handles VVOD2_F12_Vykl.Click, VVOD2_F12_Vkl.Click, VVOD2_F12_TV.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ Фидер 13"
        frmUSTAVKI.Show()
    End Sub

    Private Sub VV2_TV_Click(sender As System.Object, e As System.EventArgs) Handles VV2_TV.Click, VV2_vykl.Click, VV2_vkl.Click

        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения КТП АВО ВВ1"
        frmUSTAVKI.Show()

    End Sub

    Private Sub VV1_TV_Click(sender As System.Object, e As System.EventArgs) Handles VV1_TV.Click, VV1_vykl.Click, VV1_vkl.Click

        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения КТП АВО ВВ2"
        frmUSTAVKI.Show()

    End Sub

End Class