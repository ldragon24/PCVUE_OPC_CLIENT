Public Class frmKTP_EB
    Dim T_KTP_EB As System.Threading.Thread

    Private Sub btnRp10V1_Click(sender As System.Object, e As System.EventArgs)

        Select Case btnRp10V1.Text

            Case "Старт"

                btnRp10V1.Text = "Стоп"
                T_KTP_EB = New System.Threading.Thread(AddressOf T_KTP_EB_START)
                T_KTP_EB.Start()

            Case "Стоп"

                btnRp10V1.Text = "Старт"
                m_server.CancelSubscription(groupKTP_EB)
                T_KTP_EB.Abort()

        End Select


    End Sub

    Sub T_KTP_EB_START()

        Try
ARG:
            groupStateKTP_EB.Name = "KTPEB"
            groupStateKTP_EB.Active = True
            groupStateKTP_EB.UpdateRate = MSPEED

            groupKTP_EB = DirectCast(m_server.CreateSubscription(groupStateKTP_EB), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(81) {}

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
            items(5).ItemName = "РП10.С1.3_ФИД.CLOSE"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С1.3_ФИД.DI"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С1.3_ФИД.I1"

            'Нож заземления
            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С1.3_ФИД.EARTH_SWITCH"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С1.3_ФИД.TRIP"
            '#########################################################

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С2.12_ФИД.CLOSE"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С2.12_ФИД.DI"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С2.12_ФИД.I1"

            'Нож заземления
            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С2.12_ФИД.EARTH_SWITCH"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С2.12_ФИД.TRIP"

            '#########################################################################
            'ВВОД 1
            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "КТП_ЭБ.С1.ВВ1.UBB"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "КТП_ЭБ.С1.ВВ1.CLOSE"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "КТП_ЭБ.С1.АВ.A_IZM_DRAWN_OUT1"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "КТП_ЭБ.С1.ВВ1.TRIP"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "КТП_ЭБ.С1.ВВ1.DISCREP_OPEN_CLOSE"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "КТП_ЭБ.С1.ВВ1.REMOTE_CNTRL_ENABLE"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "КТП_ЭБ.С1.ВВ1.T_TRANS_HI"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "КТП_ЭБ.С1.АДЭС.RESERV_NET"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "КТП_ЭБ.С1.АДЭС.READY"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "КТП_ЭБ.С1.АДЭС.WORK"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "КТП_ЭБ.С1.АДЭС.FAULT"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "КТП_ЭБ.С1.АДЭС.FAIL_STOP"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "КТП_ЭБ.С1.АВ.AVR_ON"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "КТП_ЭБ.С1.АВ.CLOSE"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "КТП_ЭБ.С1.АВ.GENE_OPEN"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "КТП_ЭБ.С1.АВ.ALA_I1_A_PSK"

            items(31) = New Global.Opc.Da.Item()
            items(31).ItemName = "КТП_ЭБ.С1.ККУ.I"

            items(32) = New Global.Opc.Da.Item()
            items(32).ItemName = "КТП_ЭБ.С1.ККУ.RPOW"

            items(33) = New Global.Opc.Da.Item()
            items(33).ItemName = "КТП_ЭБ.С1.ККУ.U"

            items(34) = New Global.Opc.Da.Item()
            items(34).ItemName = "КТП_ЭБ.С1.ККУ.COS"

            items(35) = New Global.Opc.Da.Item()
            items(35).ItemName = "КТП_ЭБ.С1.АВ.C_TRIP"

            items(36) = New Global.Opc.Da.Item()
            items(36).ItemName = "КТП_ЭБ.С1.QF13.CLOSE"

            items(37) = New Global.Opc.Da.Item()
            items(37).ItemName = "КТП_ЭБ.С1.QF13.DOC"

            '############################################################################
            items(38) = New Global.Opc.Da.Item()
            items(38).ItemName = "КТП_ЭБ.С2.QF23.CLOSE"

            items(39) = New Global.Opc.Da.Item()
            items(39).ItemName = "КТП_ЭБ.С2.QF23.DOC"

            items(40) = New Global.Opc.Da.Item()
            items(40).ItemName = "КТП_ЭБ.С1.СВ.AVR_ON"

            items(41) = New Global.Opc.Da.Item()
            items(41).ItemName = "КТП_ЭБ.С1.СВ.CLOSE"

            items(42) = New Global.Opc.Da.Item()
            items(42).ItemName = "КТП_ЭБ.С1.СВ.TRIP"
            '############################################################################
            'ВВОД 2
            items(43) = New Global.Opc.Da.Item()
            items(43).ItemName = "КТП_ЭБ.С2.ВВ2.UBB"

            items(44) = New Global.Opc.Da.Item()
            items(44).ItemName = "КТП_ЭБ.С2.ВВ2.CLOSE"

            items(45) = New Global.Opc.Da.Item()
            items(45).ItemName = "КТП_ЭБ.С2.ВВ2.TRIP"

            items(46) = New Global.Opc.Da.Item()
            items(46).ItemName = "КТП_ЭБ.С2.ВВ2.DISCREP_OPEN_CLOSE"


            items(47) = New Global.Opc.Da.Item()
            items(47).ItemName = "КТП_ЭБ.С2.ВВ2.REMOTE_CNTRL_ENABLE"

            items(48) = New Global.Opc.Da.Item()
            items(48).ItemName = "КТП_ЭБ.С2.ВВ2.T_TRANS_HI"


            items(49) = New Global.Opc.Da.Item()
            items(49).ItemName = "КТП_ЭБ.С2.ККУ.I"

            items(50) = New Global.Opc.Da.Item()
            items(50).ItemName = "КТП_ЭБ.С2.ККУ.RPOW"

            items(51) = New Global.Opc.Da.Item()
            items(51).ItemName = "КТП_ЭБ.С2.ККУ.U"

            items(52) = New Global.Opc.Da.Item()
            items(52).ItemName = "КТП_ЭБ.С2.ККУ.COS"


            'Дистанционное(управление)
            items(53) = New Global.Opc.Da.Item()
            items(53).ItemName = "КТП_ЭБ.С1.СВ.REMOTE_CNTRL_ENABLE"

            'Неисправность(ЦУ)
            items(54) = New Global.Opc.Da.Item()
            items(54).ItemName = "КТП_ЭБ.С1.СВ.DISCREP_OPEN_CLOSE"

            'Отключение СВ от защит
            items(55) = New Global.Opc.Da.Item()
            items(55).ItemName = "КТП_ЭБ.С1.СВ.CLOSE_SV_DEFAV"

            'неисправность БМПА
            items(56) = New Global.Opc.Da.Item()
            items(56).ItemName = "КТП_ЭБ.С1.СВ.C_BLOCK_FAILURE"

            'Включение СВ по АВР СВ
            items(57) = New Global.Opc.Da.Item()
            items(57).ItemName = "КТП_ЭБ.С1.СВ.CLOSE_SV_AVRAV"

            'Отключение СВ по автоматике
            items(58) = New Global.Opc.Da.Item()
            items(58).ItemName = "КТП_ЭБ.С1.СВ.C_TRIP"

            items(59) = New Global.Opc.Da.Item()
            items(59).ItemName = "ОЩСУ.С1.QF3.CLOSE"

            items(60) = New Global.Opc.Da.Item()
            items(60).ItemName = "ОЩСУ.С1.QF1.CLOSE"

            items(61) = New Global.Opc.Da.Item()
            items(61).ItemName = "ОЩСУ.С2.QF2.CLOSE"

            items(62) = New Global.Opc.Da.Item()
            items(62).ItemName = "ОЩСУ.С2.QF1.DOC"

            items(63) = New Global.Opc.Da.Item()
            items(63).ItemName = "ОЩСУ.С2.QF2.DOC"

            '##################################################
            items(64) = New Global.Opc.Da.Item()
            items(64).ItemName = "РП10.С2.18_СР.VOLT_COLOR"

            items(65) = New Global.Opc.Da.Item()
            items(65).ItemName = "РП10.С2.10_ВВОД.VOLT_COLOR"

            items(66) = New Global.Opc.Da.Item()
            items(66).ItemName = "РП10.С1.1_ВВОД.VOLT_COLOR"

            items(67) = New Global.Opc.Da.Item()
            items(67).ItemName = "РП10.С1.3_ФИД.VOLT_COLOR"

            items(68) = New Global.Opc.Da.Item()
            items(68).ItemName = "РП10.С2.12_ФИД.VOLT_COLOR"

            items(69) = New Global.Opc.Da.Item()
            items(69).ItemName = "КТП_ЭБ.С1.ВВ1.VOLT_COLOR"

            items(70) = New Global.Opc.Da.Item()
            items(70).ItemName = "КТП_ЭБ.С1.ККУ.VOLT_COLOR"

            items(71) = New Global.Opc.Da.Item()
            items(71).ItemName = "КТП_ЭБ.С1.АВ.VOLT_COLOR"

            items(72) = New Global.Opc.Da.Item()
            items(72).ItemName = "КТП_ЭБ.С1.СВ.VOLT_COLOR"

            items(73) = New Global.Opc.Da.Item()
            items(73).ItemName = "КТП_ЭБ.С1.VOLT_COLOR"

            items(74) = New Global.Opc.Da.Item()
            items(74).ItemName = "КТП_ЭБ.С2.ВВ2.VOLT_COLOR"

            items(75) = New Global.Opc.Da.Item()
            items(75).ItemName = "КТП_ЭБ.С2.ККУ.VOLT_COLOR"

            items(76) = New Global.Opc.Da.Item()
            items(76).ItemName = "КТП_ЭБ.С2.VOLT_COLOR"

            items(77) = New Global.Opc.Da.Item()
            items(77).ItemName = "КТП_ЭБ.С1.QF13.VOLT_COLOR"

            items(78) = New Global.Opc.Da.Item()
            items(78).ItemName = "КТП_ЭБ.С2.QF23.VOLT_COLOR"

            items(79) = New Global.Opc.Da.Item()
            items(79).ItemName = "ОЩСУ.С1.QF1.VOLT_COLOR"
            items(80) = New Global.Opc.Da.Item()
            items(80).ItemName = "ОЩСУ.С2.QF2.VOLT_COLOR"
            items(81) = New Global.Opc.Da.Item()
            items(81).ItemName = "ОЩСУ.С1.QF3.VOLT_COLOR"


            items = groupKTP_EB.AddItems(items)

            Dim MGg As Double

            Do

                Dim results As ItemValueResult() = Nothing
                results = groupKTP_EB.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1


                    '####################################################################
                    'СВ
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

                            Select Case results(2).Value

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

                    'MGg = results(22).Value
                    Me.Invoke(Sub() lblADES_RES.Enabled = results(22).Value)
                    Me.Invoke(Sub() lblADES_READY.Enabled = results(23).Value)
                    Me.Invoke(Sub() lblADES_WORK.Enabled = results(24).Value)
                    Me.Invoke(Sub() lblADES_FAULT.Enabled = results(25).Value)
                    Me.Invoke(Sub() lblADES_FAILSTOP.Enabled = results(26).Value)



                    '########################################################################
                    Select Case results(27).Value

                        Case True
                            Me.Invoke(Sub() Label30.Enabled = True)
                            Me.Invoke(Sub() Label31.Enabled = False)
                        Case False
                            Me.Invoke(Sub() Label30.Enabled = False)
                            Me.Invoke(Sub() Label31.Enabled = True)
                    End Select

                    Select Case results(28).Value

                        Case True
                            Me.Invoke(Sub() AV_vykl.Visible = False)
                            Me.Invoke(Sub() AV_vkl.Visible = True)

                        Case False

                            Me.Invoke(Sub() AV_vykl.Visible = True)
                            Me.Invoke(Sub() AV_vkl.Visible = False)
                    End Select

                    Select Case results(29).Value

                        Case False
                            Me.Invoke(Sub() ADES_VyKL.Visible = False)
                            Me.Invoke(Sub() ADES_VKL.Visible = True)

                        Case True

                            Me.Invoke(Sub() ADES_VyKL.Visible = True)
                            Me.Invoke(Sub() ADES_VKL.Visible = False)
                    End Select

                    MGg = results(30).Value
                    Me.Invoke(Sub() lblSHVA_I.Text = Math.Round(MGg, 1) & " A")
                    '########################################################################

                    Select Case results(31).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() lblKKU1_I.BackColor = Color.Transparent)
                        Case Else
                            Me.Invoke(Sub() lblKKU1_I.BackColor = Color.Pink)
                    End Select

                    MGg = results(31).Value
                    Me.Invoke(Sub() lblKKU1_I.Text = Math.Round(MGg, 1) & " A")

                    Select Case results(32).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() lblKKU1_Q.BackColor = Color.Transparent)
                        Case Else
                            Me.Invoke(Sub() lblKKU1_Q.BackColor = Color.Pink)
                    End Select

                    MGg = results(32).Value
                    Me.Invoke(Sub() lblKKU1_Q.Text = Math.Round(MGg, 1) & " ВAр")

                    Select Case results(33).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() lblKKU1_U.BackColor = Color.Transparent)
                        Case Else
                            Me.Invoke(Sub() lblKKU1_U.BackColor = Color.Pink)
                    End Select

                    MGg = results(33).Value
                    Me.Invoke(Sub() lblKKU1_U.Text = Math.Round(MGg, 1) & " В")

                    Select Case results(34).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() lblKKU1_COS.BackColor = Color.Transparent)
                        Case Else
                            Me.Invoke(Sub() lblKKU1_COS.BackColor = Color.Pink)
                    End Select

                    MGg = results(34).Value
                    Me.Invoke(Sub() lblKKU1_COS.Text = Math.Round(MGg, 1))

                    'lblA4

                    Select Case results(35).Value
                        Case True
                            Me.Invoke(Sub() lblA4.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA4.BackColor = Color.Transparent)
                    End Select

                    '##########################################################
                    'QF13
                    Select Case results(37).Value

                        Case False

                            Me.Invoke(Sub() lblQF13.Visible = False)

                            Select Case results(36).Value

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
                    '##########################################################
                    'QF23
                    Select Case results(39).Value

                        Case False

                            Me.Invoke(Sub() lblQF23.Visible = False)

                            Select Case results(38).Value

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
                            Me.Invoke(Sub() lblKKU2_I.BackColor = Color.Transparent)
                        Case Else
                            Me.Invoke(Sub() lblKKU2_I.BackColor = Color.Pink)
                    End Select

                    MGg = results(49).Value
                    Me.Invoke(Sub() lblKKU2_I.Text = Math.Round(MGg, 1) & " A")

                    Select Case results(50).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() lblKKU2_Q.BackColor = Color.Transparent)
                        Case Else
                            Me.Invoke(Sub() lblKKU2_Q.BackColor = Color.Pink)
                    End Select

                    MGg = results(50).Value
                    Me.Invoke(Sub() lblKKU2_Q.Text = Math.Round(MGg, 1) & " ВAр")

                    Select Case results(51).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() lblKKU2_U.BackColor = Color.Transparent)
                        Case Else
                            Me.Invoke(Sub() lblKKU2_U.BackColor = Color.Pink)
                    End Select

                    MGg = results(51).Value
                    Me.Invoke(Sub() lblKKU2_U.Text = Math.Round(MGg, 1) & " В")

                    Select Case results(52).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() lblKKU2_COS.BackColor = Color.Transparent)
                        Case Else
                            Me.Invoke(Sub() lblKKU2_COS.BackColor = Color.Pink)
                    End Select

                    MGg = results(52).Value
                    Me.Invoke(Sub() lblKKU2_COS.Text = Math.Round(MGg, 1))

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
                    'ОЩСУ

                    Select Case results(59).Value

                        Case True

                            Me.Invoke(Sub() OCHSU_Vkl.Visible = True)
                            Me.Invoke(Sub() OCHSU_Vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() OCHSU_Vkl.Visible = False)
                            Me.Invoke(Sub() OCHSU_Vykl.Visible = True)
                    End Select

                    Select Case results(62).Value

                        Case False

                            Me.Invoke(Sub() lblQF1.Visible = False)

                            Select Case results(60).Value

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

                    Select Case results(63).Value

                        Case False

                            Me.Invoke(Sub() lblQF2.Visible = False)

                            Select Case results(61).Value

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


                    '###########################################################
                    Me.Invoke(Sub() LineColor(results(64).Value, L1))
                    Me.Invoke(Sub() L2.BorderColor = L1.BorderColor)
                    Me.Invoke(Sub() L3.BorderColor = L1.BorderColor)
                    Me.Invoke(Sub() L4.BorderColor = L1.BorderColor)
                    Me.Invoke(Sub() L5.BorderColor = L1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(65).Value, L6))
                    Me.Invoke(Sub() L7.BorderColor = L6.BorderColor)
                    Me.Invoke(Sub() L8.BorderColor = L6.BorderColor)

                    Me.Invoke(Sub() LineColor(results(66).Value, L9))
                    Me.Invoke(Sub() L10.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() L11.BorderColor = L9.BorderColor)

                    Me.Invoke(Sub() LineColor(results(67).Value, L1_1))
                    Me.Invoke(Sub() L1_2.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_3.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_4.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_5.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_6.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_7.BorderColor = L1_1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(68).Value, L2_1))
                    Me.Invoke(Sub() L2_2.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_3.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_4.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_5.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_6.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_7.BorderColor = L2_1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(69).Value, LV1_1))
                    Me.Invoke(Sub() LV1_2.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() LV1_3.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() LV1_4.BorderColor = LV1_1.BorderColor)
                    Me.Invoke(Sub() LV1_5.BorderColor = LV1_1.BorderColor)


                    Me.Invoke(Sub() LineColor(results(70).Value, LKKU_1))
                    Me.Invoke(Sub() LKKU_2.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LKKU_3.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LKKU_4.BorderColor = LKKU_1.BorderColor)

                    Me.Invoke(Sub() LineShape4.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape5.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape9.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape8.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape13.BorderColor = LKKU_1.BorderColor)
                    Me.Invoke(Sub() LineShape14.BorderColor = LKKU_1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(71).Value, LineShape10))

                    Me.Invoke(Sub() LineColor(results(72).Value, LineShape1))
                    Me.Invoke(Sub() LineShape2.BorderColor = LineShape1.BorderColor)
                    Me.Invoke(Sub() LineShape3.BorderColor = LineShape1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(73).Value, LC1_2))
                    Me.Invoke(Sub() LC1_1.BorderColor = LC1_2.BorderColor)

                    Me.Invoke(Sub() LineColor(results(74).Value, LV2_2))
                    Me.Invoke(Sub() LV2_1.BorderColor = LV2_2.BorderColor)
                    Me.Invoke(Sub() LV2_3.BorderColor = LV2_2.BorderColor)

                    Me.Invoke(Sub() LineColor(results(75).Value, LKKU2_1))
                    Me.Invoke(Sub() LKKU2_2.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LKKU2_3.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LKKU2_4.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LineShape6.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LineShape7.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LineShape11.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LineShape12.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LineShape15.BorderColor = LKKU2_1.BorderColor)
                    Me.Invoke(Sub() LineShape16.BorderColor = LKKU2_1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(76).Value, LC2_2))
                    Me.Invoke(Sub() LC2_1.BorderColor = LC2_2.BorderColor)

                    Me.Invoke(Sub() LineColor(results(77).Value, LQ13))
                    Me.Invoke(Sub() LineColor(results(78).Value, LQ23))


                    Me.Invoke(Sub() LineColor(results(79).Value, LOQ1_1))
                    Me.Invoke(Sub() LOQ1_2.BorderColor = LOQ1_1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(80).Value, LOQ2_1))
                    Me.Invoke(Sub() LOQ2_2.BorderColor = LOQ2_1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(81).Value, LOCV_1))
                    Me.Invoke(Sub() LOCV_2.BorderColor = LOCV_1.BorderColor)
                    Me.Invoke(Sub() LOCV_3.BorderColor = LOCV_1.BorderColor)
                    Me.Invoke(Sub() LOCV_4.BorderColor = LOCV_1.BorderColor)

                Next

                Threading.Thread.Sleep(MSPEED + 250)

            Loop

        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try


    End Sub

    Private Sub frmKTP_EB_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        m_server.CancelSubscription(groupKTP_EB)
        T_KTP_EB.Abort()

    End Sub

    Private Sub frmKTP_EB_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Select Case btnRp10V1.Text

            Case "Старт"

                btnRp10V1.Text = "Стоп"
                T_KTP_EB = New System.Threading.Thread(AddressOf T_KTP_EB_START)
                T_KTP_EB.Start()

            Case "Стоп"

                btnRp10V1.Text = "Старт"
                m_server.CancelSubscription(groupKTP_EB)
                T_KTP_EB.Abort()

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

        AV_vkl.Cursor = Cursors.Hand
        AV_vykl.Cursor = Cursors.Hand


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frmKTP_EB_DETAIL.MdiParent = frmIndexer
        frmKTP_EB_DETAIL.Show()
        frmKTP_EB_DETAIL.Focus()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        frmRP10.MdiParent = frmIndexer
        frmRP10.Show()
        frmRP10.Focus()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        frmOHCU.MdiParent = frmIndexer
        frmOHCU.Show()
        frmOHCU.Focus()
    End Sub

    Private Sub VVOD1_F3_VyKL_Click(sender As System.Object, e As System.EventArgs) Handles VVOD1_F3_VyKL.Click, VVOD1_F3_VKL.Click, VVOD1_F3_TV.Click

        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ Фидер 3"
        frmUSTAVKI.Show()

    End Sub

    Private Sub CB_VyKL_Click(sender As System.Object, e As System.EventArgs) Handles CB_VyKL.Click, CB_TV.Click, CB_VKL.Click

        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ СВ"
        frmUSTAVKI.Show()

    End Sub

    Private Sub VVOD2_F12_Vykl_Click(sender As System.Object, e As System.EventArgs) Handles VVOD2_F12_Vykl.Click, VVOD2_F12_Vkl.Click, VVOD2_F12_TV.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ Фидер 12"
        frmUSTAVKI.Show()
    End Sub

   
    Private Sub VV1_vykl_Click(sender As System.Object, e As System.EventArgs) Handles VV1_vykl.Click, VV1_vkl.Click, VV1_TV.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения КТП ЭБ ВВ1"
        frmUSTAVKI.Show()
    End Sub

    Private Sub VV2_vykl_Click(sender As System.Object, e As System.EventArgs) Handles VV2_vykl.Click, VV2_vkl.Click, VV2_TV.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения КТП ЭБ ВВ2"
        frmUSTAVKI.Show()
    End Sub

    Private Sub AV_vkl_Click(sender As System.Object, e As System.EventArgs) Handles AV_vkl.Click, AV_vykl.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения КТП ЭБ АВ"
        frmUSTAVKI.Show()
    End Sub
End Class