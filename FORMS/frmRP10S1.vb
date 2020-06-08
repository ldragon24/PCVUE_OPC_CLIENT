Public Class frmRP10S1
    Dim T_RP10S1 As System.Threading.Thread

    Private Sub btnRp10V1_Click(sender As System.Object, e As System.EventArgs)

        Select Case btnRp10V1.Text

            Case "Старт"

                btnRp10V1.Text = "Стоп"
                T_RP10S1 = New System.Threading.Thread(AddressOf T_RP10S1_START)
                T_RP10S1.Start()

            Case "Стоп"

                btnRp10V1.Text = "Старт"
                m_server.CancelSubscription(groupRP10S1)
                T_RP10S1.Abort()

        End Select


    End Sub

    Sub T_RP10S1_START()

        Try
ARG:
            groupStateRP10S1.Name = "RP10s1"
            groupStateRP10S1.Active = True
            groupStateRP10S1.UpdateRate = MSPEED

            groupRP10S1 = DirectCast(m_server.CreateSubscription(groupStateRP10S1), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(65) {}

            '##########################################################
            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С1.1_ВВОД.CLOSE"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С2.11_ШТН.AVR_ON"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С1.1_ВВОД.EARTH_SWITCH"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С1.1_ВВОД.P"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С1.1_ВВОД.Q"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С1.1_ВВОД.I1"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С1.1_ВВОД.U_12"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С1.1_ВВОД.FREQ"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С1.1_ВВОД.EN_SW_CHANGE_ALA"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С1.9_СВ.CLOSE"

            'Тележка вкачена\выкачена
            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С1.1_ВВОД.DO"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С1.9_СВ.DO"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С2.10_ВВОД.DO"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С2.18_СР.DO"

            'Нож заземления
            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С1.9_СВ.EARTH_SWITCH"

            'Тележка 18_СР (ручное управление, можем брать только положение тележки)
            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.С2.18_СР.DO"

            '#########################################################
            '8 фидер - Резерв
            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.С1.8_ФИД.CLOSE"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РП10.С1.8_ФИД.DO"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РП10.С1.8_ФИД.I1"

            'Нож заземления
            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "РП10.С1.8_ФИД.EARTH_SWITCH"
            '#########################################################
            '7 фидер - ТП Базы дирекции
            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "РП10.С1.7_ФИД.CLOSE"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "РП10.С1.7_ФИД.DO"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С1.7_ФИД.I1"

            'Нож заземления
            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С1.7_ФИД.EARTH_SWITCH"
            '#########################################################

            '6 фидер - ВЛ 10кВ Починки Ярославль (Починки)
            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С1.6_ФИД.CLOSE"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С1.6_ФИД.DO"

            'Нож заземления
            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С1.6_ФИД.EARTH_SWITCH"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С1.6_ФИД.P"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С1.6_ФИД.Q"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С1.6_ФИД.I1"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С1.6_ФИД.U_12"

            '#########################################################

            '5 фидер - ВЛ 10кВ Ямбург-Тула (КП 201) Первомайск

            items(31) = New Global.Opc.Da.Item()
            items(31).ItemName = "РП10.С1.5_ФИД.CLOSE"

            items(32) = New Global.Opc.Da.Item()
            items(32).ItemName = "РП10.С1.5_ФИД.DO"

            'Нож заземления
            items(33) = New Global.Opc.Da.Item()
            items(33).ItemName = "РП10.С1.5_ФИД.EARTH_SWITCH"

            items(34) = New Global.Opc.Da.Item()
            items(34).ItemName = "РП10.С1.5_ФИД.P"

            items(35) = New Global.Opc.Da.Item()
            items(35).ItemName = "РП10.С1.5_ФИД.Q"

            items(36) = New Global.Opc.Da.Item()
            items(36).ItemName = "РП10.С1.5_ФИД.I1"

            items(37) = New Global.Opc.Da.Item()
            items(37).ItemName = "РП10.С1.5_ФИД.U_12"

            '#########################################################

            '4 фидер - КТП АВО
            items(38) = New Global.Opc.Da.Item()
            items(38).ItemName = "РП10.С1.4_ФИД.CLOSE"

            items(39) = New Global.Opc.Da.Item()
            items(39).ItemName = "РП10.С1.4_ФИД.DO"

            items(40) = New Global.Opc.Da.Item()
            items(40).ItemName = "РП10.С1.4_ФИД.I1"

            'Нож заземления
            items(41) = New Global.Opc.Da.Item()
            items(41).ItemName = "РП10.С1.4_ФИД.EARTH_SWITCH"

            '#########################################################
            '3 фидер - КТП ЭБ

            items(42) = New Global.Opc.Da.Item()
            items(42).ItemName = "РП10.С1.3_ФИД.CLOSE"

            items(43) = New Global.Opc.Da.Item()
            items(43).ItemName = "РП10.С1.3_ФИД.DO"

            items(44) = New Global.Opc.Da.Item()
            items(44).ItemName = "РП10.С1.3_ФИД.I1"

            'Нож заземления
            items(45) = New Global.Opc.Da.Item()
            items(45).ItemName = "РП10.С1.3_ФИД.EARTH_SWITCH"

            '#########################################################

            'Фидер 2 ШТН
            'Нож заземления
            items(46) = New Global.Opc.Da.Item()
            items(46).ItemName = "РП10.С1.2_ФИД.EARTH_SWITCH"

            '#########################################################################
            'Сигнализация

            items(47) = New Global.Opc.Da.Item()
            items(47).ItemName = "РП10.С1.1_ВВОД.TRIP"

            items(48) = New Global.Opc.Da.Item()
            items(48).ItemName = "РП10.С1.2_ФИД.TRIP"

            items(49) = New Global.Opc.Da.Item()
            items(49).ItemName = "РП10.С1.3_ФИД.TRIP"

            items(50) = New Global.Opc.Da.Item()
            items(50).ItemName = "РП10.С1.4_ФИД.TRIP"

            items(51) = New Global.Opc.Da.Item()
            items(51).ItemName = "РП10.С1.5_ФИД.TRIP"

            items(52) = New Global.Opc.Da.Item()
            items(52).ItemName = "РП10.С1.6_ФИД.TRIP"

            items(53) = New Global.Opc.Da.Item()
            items(53).ItemName = "РП10.С1.7_ВВОД.TRIP"

            items(54) = New Global.Opc.Da.Item()
            items(54).ItemName = "РП10.С1.8_ВВОД.TRIP"

            items(55) = New Global.Opc.Da.Item()
            items(55).ItemName = "РП10.С1.9_СВ.TRIP"


            items(56) = New Global.Opc.Da.Item()
            items(56).ItemName = "РП10.С2.18_СР.VOLT_COLOR"

            items(57) = New Global.Opc.Da.Item()
            items(57).ItemName = "РП10.С2.10_ВВОД.VOLT_COLOR"

            items(58) = New Global.Opc.Da.Item()
            items(58).ItemName = "РП10.С1.1_ВВОД.VOLT_COLOR"


            items(59) = New Global.Opc.Da.Item()
            items(59).ItemName = "РП10.С1.8_ФИД.VOLT_COLOR"

            items(60) = New Global.Opc.Da.Item()
            items(60).ItemName = "РП10.С1.7_ФИД.VOLT_COLOR"

            items(61) = New Global.Opc.Da.Item()
            items(61).ItemName = "РП10.С1.6_ФИД.VOLT_COLOR"

            items(62) = New Global.Opc.Da.Item()
            items(62).ItemName = "РП10.С1.5_ФИД.VOLT_COLOR"

            items(63) = New Global.Opc.Da.Item()
            items(63).ItemName = "РП10.С1.4_ФИД.VOLT_COLOR"

            items(64) = New Global.Opc.Da.Item()
            items(64).ItemName = "РП10.С1.3_ФИД.VOLT_COLOR"

            items(65) = New Global.Opc.Da.Item()
            items(65).ItemName = "РП10.С1.1_ВВОД.VOLT_COLOR_TN"

            items = groupRP10S1.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = groupRP10S1.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Select Case results(10).Value

                        Case True
                            Me.Invoke(Sub() VVOD1_VKL.Visible = False)
                            Me.Invoke(Sub() VVOD1_VyKL.Visible = False)
                            Me.Invoke(Sub() VVOD1_TV.Visible = True)
                        Case Else
                            Me.Invoke(Sub() VVOD1_TV.Visible = False)

                            Select Case results(0).Value

                                Case True
                                    Me.Invoke(Sub() VVOD1_VKL.Visible = True)
                                    Me.Invoke(Sub() VVOD1_VyKL.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VVOD1_VKL.Visible = False)
                                    Me.Invoke(Sub() VVOD1_VyKL.Visible = True)

                            End Select

                    End Select


                    Select Case results(1).Value

                        Case True
                            Me.Invoke(Sub() lblAVR_vkl.Enabled = True)
                            Me.Invoke(Sub() lblAVR_vykl.Enabled = False)
                        Case False
                            Me.Invoke(Sub() lblAVR_vkl.Enabled = False)
                            Me.Invoke(Sub() lblAVR_vykl.Enabled = True)
                    End Select


                    Select Case results(2).Value

                        Case True

                            Me.Invoke(Sub() VVOD1_Earth_VKL.Visible = True)
                            Me.Invoke(Sub() VVOD1_Earth_VyKL.Visible = False)
                        Case False
                            Me.Invoke(Sub() VVOD1_Earth_VKL.Visible = False)
                            Me.Invoke(Sub() VVOD1_Earth_VyKL.Visible = True)
                    End Select

                    'lblVV1_P

                    Dim MGg As Double = results(3).Value
                    Me.Invoke(Sub() lblVV1_P.Text = Math.Round(MGg, 1) & " кВт")

                    MGg = results(4).Value
                    Me.Invoke(Sub() lblVV1_Q.Text = Math.Round(MGg, 1) & " кВар")

                    MGg = results(5).Value
                    Me.Invoke(Sub() lblVV1_I.Text = Math.Round(MGg, 1) & " A")

                    MGg = results(6).Value
                    Me.Invoke(Sub() lblVV1_U.Text = Math.Round(MGg, 1) & " Кв")

                    Me.Invoke(Sub() lblVV1_U_.Text = lblVV1_U.Text)

                    MGg = results(7).Value
                    Me.Invoke(Sub() lblVV1_F_.Text = Math.Round(MGg, 1) & " Гц")

                    'lblVV1_ES

                    Select Case results(8).Value

                        Case True
                            Me.Invoke(Sub() lblVV1_ES.Enabled = True)
                        Case False
                            Me.Invoke(Sub() lblVV1_ES.Enabled = False)

                    End Select

                    Select Case results(11).Value

                        Case True

                            Me.Invoke(Sub() VVOD1_SHTN_VKL.Visible = False)
                            Me.Invoke(Sub() VVOD1_SHTN_Vykl.Visible = False)
                            Me.Invoke(Sub() VVOD1_SHTN_TV.Visible = True)

                        Case Else
                            Me.Invoke(Sub() VVOD1_SHTN_TV.Visible = False)

                            Select Case results(9).Value

                                Case True

                                    Me.Invoke(Sub() VVOD1_SHTN_VKL.Visible = True)
                                    Me.Invoke(Sub() VVOD1_SHTN_Vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VVOD1_SHTN_VKL.Visible = False)
                                    Me.Invoke(Sub() VVOD1_SHTN_Vykl.Visible = True)
                            End Select
                    End Select

                    Select Case results(13).Value

                        Case True
                            Me.Invoke(Sub() VVOD2_SHTN_VKL.Visible = False)
                            Me.Invoke(Sub() VVOD2_SHTN_VyKL.Visible = False)
                            Me.Invoke(Sub() VVOD2_SHTN_TV.Visible = True)

                        Case Else

                            Me.Invoke(Sub() VVOD2_SHTN_TV.Visible = False)

                            Select Case results(15).Value

                                Case False

                                    Me.Invoke(Sub() VVOD2_SHTN_VKL.Visible = True)
                                    Me.Invoke(Sub() VVOD2_SHTN_VyKL.Visible = False)
                                Case Else

                                    Me.Invoke(Sub() VVOD2_SHTN_VKL.Visible = False)
                                    Me.Invoke(Sub() VVOD2_SHTN_VyKL.Visible = True)
                            End Select
                    End Select

                    'Качество сигнала (Quality)
                    Select Case results(14).Quality.ToString

                        Case "good"
                            Me.Invoke(Sub() lblSW_EA.Visible = False)

                            Select Case results(14).Value

                                Case True

                                    Me.Invoke(Sub() VVOD1_SV_EA_VKL.Visible = True)
                                    Me.Invoke(Sub() VVOD1_SV_EA_VYKL.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VVOD1_SV_EA_VKL.Visible = False)
                                    Me.Invoke(Sub() VVOD1_SV_EA_VYKL.Visible = True)

                            End Select

                        Case Else
                            Me.Invoke(Sub() VVOD1_SV_EA_VKL.Visible = False)
                            Me.Invoke(Sub() VVOD1_SV_EA_VYKL.Visible = False)
                            Me.Invoke(Sub() lblSW_EA.Visible = True)
                    End Select

                    'Резерв, проверяем если тележка выкачена то....


                    Select Case results(17).Value

                        Case True
                            Me.Invoke(Sub() VVOD1_Rez_Vkl.Visible = False)
                            Me.Invoke(Sub() VVOD1_Rez_Vykl.Visible = False)
                            Me.Invoke(Sub() VVOD1_Rez_TV.Visible = True)
                        Case False
                            Me.Invoke(Sub() VVOD1_Rez_TV.Visible = False)

                            Select Case results(16).Value

                                Case True
                                    Me.Invoke(Sub() VVOD1_Rez_Vkl.Visible = True)
                                    Me.Invoke(Sub() VVOD1_Rez_Vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VVOD1_Rez_Vkl.Visible = False)
                                    Me.Invoke(Sub() VVOD1_Rez_Vykl.Visible = True)
                            End Select

                    End Select


                    MGg = results(18).Value
                    Me.Invoke(Sub() lbl_Rez.Text = Math.Round(MGg, 1) & " A")

                    Select Case results(19).Quality.ToString

                        Case "good"
                            Me.Invoke(Sub() lblRez_EA.Visible = False)

                            Select Case results(19).Value

                                Case True

                                    Me.Invoke(Sub() VVOD1_REZ_EA_VKL.Visible = True)
                                    Me.Invoke(Sub() VVOD1_REZ_EA_VyKL.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VVOD1_REZ_EA_VKL.Visible = False)
                                    Me.Invoke(Sub() VVOD1_REZ_EA_VyKL.Visible = True)
                            End Select
                        Case Else
                            Me.Invoke(Sub() VVOD1_REZ_EA_VKL.Visible = False)
                            Me.Invoke(Sub() VVOD1_REZ_EA_VyKL.Visible = False)
                            Me.Invoke(Sub() lblRez_EA.Visible = True)
                    End Select

                    'ТП БД, проверяем если тележка выкачена то....
                    Select Case results(21).Value

                        Case True
                            Me.Invoke(Sub() VVOD1_F7_Vkl.Visible = False)
                            Me.Invoke(Sub() VVOD1_F7_Vykl.Visible = False)
                            Me.Invoke(Sub() VVOD1_F7_TV.Visible = True)
                        Case False
                            Me.Invoke(Sub() VVOD1_F7_TV.Visible = False)

                            Select Case results(20).Value

                                Case True
                                    Me.Invoke(Sub() VVOD1_F7_Vkl.Visible = True)
                                    Me.Invoke(Sub() VVOD1_F7_Vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VVOD1_F7_Vkl.Visible = False)
                                    Me.Invoke(Sub() VVOD1_F7_Vykl.Visible = True)
                            End Select

                    End Select

                    MGg = results(22).Value
                    Me.Invoke(Sub() lblF7.Text = Math.Round(MGg, 1) & " A")


                    Select Case results(23).Quality.ToString

                        Case "good"
                            Me.Invoke(Sub() lblF7_EA.Visible = False)
                            Select Case results(23).Value

                                Case True

                                    Me.Invoke(Sub() VVOD1_F7_EA_Vkl.Visible = True)
                                    Me.Invoke(Sub() VVOD1_F7_EA_Vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VVOD1_F7_EA_Vkl.Visible = False)
                                    Me.Invoke(Sub() VVOD1_F7_EA_Vykl.Visible = True)
                            End Select
                        Case Else
                            Me.Invoke(Sub() VVOD1_F7_EA_Vkl.Visible = False)
                            Me.Invoke(Sub() VVOD1_F7_EA_Vykl.Visible = False)
                            Me.Invoke(Sub() lblF7_EA.Visible = True)
                    End Select


                    '#########################################
                    'FID 6

                    Select Case results(25).Value

                        Case True
                            Me.Invoke(Sub() VVOD1_F6_VKL.Visible = False)
                            Me.Invoke(Sub() VVOD1_F6_Vykl.Visible = False)
                            Me.Invoke(Sub() VVOD1_F6_TV.Visible = True)
                        Case Else
                            Me.Invoke(Sub() VVOD1_F6_TV.Visible = False)

                            Select Case results(24).Value

                                Case True
                                    Me.Invoke(Sub() VVOD1_F6_VKL.Visible = True)
                                    Me.Invoke(Sub() VVOD1_F6_Vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VVOD1_F6_VKL.Visible = False)
                                    Me.Invoke(Sub() VVOD1_F6_Vykl.Visible = True)
                            End Select

                    End Select


                    'lblF6_EA

                    Select Case results(26).Quality.ToString

                        Case "good"
                            Me.Invoke(Sub() lblF6_EA.Visible = False)

                            Select Case results(26).Value

                                Case True

                                    Me.Invoke(Sub() VVOD1_F6_EA_Vkl.Visible = True)
                                    Me.Invoke(Sub() VVOD1_F6_EA_Vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VVOD1_F6_EA_Vkl.Visible = False)
                                    Me.Invoke(Sub() VVOD1_F6_EA_Vykl.Visible = True)
                            End Select
                        Case Else
                            Me.Invoke(Sub() VVOD1_F6_EA_Vkl.Visible = False)
                            Me.Invoke(Sub() VVOD1_F6_EA_Vykl.Visible = False)
                            Me.Invoke(Sub() lblF6_EA.Visible = True)
                    End Select

                    MGg = results(27).Value
                    Me.Invoke(Sub() lblF6_P.Text = Math.Round(MGg, 1) & " Кв")
                    MGg = results(28).Value
                    Me.Invoke(Sub() lblF6_Q.Text = Math.Round(MGg, 1) & " Квар")
                    MGg = results(29).Value
                    Me.Invoke(Sub() lblF6_I.Text = Math.Round(MGg, 1) & " A")
                    MGg = results(30).Value
                    Me.Invoke(Sub() lblF6_U.Text = Math.Round(MGg, 1) & " Квт")


                    '#########################################
                    'FID 5

                    Select Case results(32).Value

                        Case True
                            Me.Invoke(Sub() VVOD1_F5_VKL.Visible = False)
                            Me.Invoke(Sub() VVOD1_F5_VyKL.Visible = False)
                            Me.Invoke(Sub() VVOD1_F5_TV.Visible = True)
                        Case Else
                            Me.Invoke(Sub() VVOD1_F5_TV.Visible = False)

                            Select Case results(31).Value

                                Case True
                                    Me.Invoke(Sub() VVOD1_F5_VKL.Visible = True)
                                    Me.Invoke(Sub() VVOD1_F5_VyKL.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VVOD1_F5_VKL.Visible = False)
                                    Me.Invoke(Sub() VVOD1_F5_VyKL.Visible = True)
                            End Select

                    End Select

                    Select Case results(33).Value

                        Case True

                            Me.Invoke(Sub() VVOD1_F5_EA_Vkl.Visible = True)
                            Me.Invoke(Sub() VVOD1_F5_EA_Vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() VVOD1_F5_EA_Vkl.Visible = False)
                            Me.Invoke(Sub() VVOD1_F5_EA_Vykl.Visible = True)
                    End Select


                    MGg = results(34).Value
                    Me.Invoke(Sub() lblF5_P.Text = Math.Round(MGg, 1) & " Кв")
                    MGg = results(35).Value
                    Me.Invoke(Sub() lblF5_Q.Text = Math.Round(MGg, 1) & " Квар")
                    MGg = results(36).Value
                    Me.Invoke(Sub() lblF5_I.Text = Math.Round(MGg, 1) & " A")
                    MGg = results(37).Value
                    Me.Invoke(Sub() lblF5_U.Text = Math.Round(MGg, 1) & " Квт")


                    '####################################################
                    Select Case results(39).Value

                        Case True
                            Me.Invoke(Sub() VVOD1_F4_Vkl.Visible = False)
                            Me.Invoke(Sub() VVOD1_F4_Vykl.Visible = False)
                            Me.Invoke(Sub() VVOD1_F4_TV.Visible = True)
                        Case Else
                            Me.Invoke(Sub() VVOD1_F4_TV.Visible = False)

                            Select Case results(38).Value

                                Case True
                                    Me.Invoke(Sub() VVOD1_F4_Vkl.Visible = True)
                                    Me.Invoke(Sub() VVOD1_F4_Vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VVOD1_F4_Vkl.Visible = False)
                                    Me.Invoke(Sub() VVOD1_F4_Vykl.Visible = True)
                            End Select

                    End Select

                    MGg = results(40).Value
                    Me.Invoke(Sub() lblF4.Text = Math.Round(MGg, 1) & " A")

                    Select Case results(41).Value

                        Case True

                            Me.Invoke(Sub() VVOD1_F4_EA_Vkl.Visible = True)
                            Me.Invoke(Sub() VVOD1_F4_EA_Vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() VVOD1_F4_EA_Vkl.Visible = False)
                            Me.Invoke(Sub() VVOD1_F4_EA_Vykl.Visible = True)
                    End Select


                    '####################################################
                    Select Case results(43).Value

                        Case True
                            Me.Invoke(Sub() VVOD1_F3_VKL.Visible = False)
                            Me.Invoke(Sub() VVOD1_F3_VyKL.Visible = False)
                            Me.Invoke(Sub() VVOD1_F3_TV.Visible = True)
                        Case Else
                            Me.Invoke(Sub() VVOD1_F3_TV.Visible = False)

                            Select Case results(42).Value

                                Case True
                                    Me.Invoke(Sub() VVOD1_F3_VKL.Visible = True)
                                    Me.Invoke(Sub() VVOD1_F3_VyKL.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VVOD1_F3_VKL.Visible = False)
                                    Me.Invoke(Sub() VVOD1_F3_VyKL.Visible = True)
                            End Select

                    End Select

                    MGg = results(44).Value
                    Me.Invoke(Sub() lblF3.Text = Math.Round(MGg, 1) & " A")

                    Select Case results(45).Value

                        Case True

                            Me.Invoke(Sub() VVOD1_F3_EA_Vkl.Visible = True)
                            Me.Invoke(Sub() VVOD1_F3_EA_Vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() VVOD1_F3_EA_Vkl.Visible = False)
                            Me.Invoke(Sub() VVOD1_F3_EA_Vykl.Visible = True)
                    End Select

                    '####################################################
                    Select Case results(46).Value

                        Case True

                            Me.Invoke(Sub() VVOD1_F2_EA_Vkl.Visible = True)
                            Me.Invoke(Sub() VVOD1_F2_EA_Vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() VVOD1_F2_EA_Vkl.Visible = False)
                            Me.Invoke(Sub() VVOD1_F2_EA_Vykl.Visible = True)
                    End Select

                    '################################################
                    'Сигнализация

                    Select Case results(47).Value
                        Case True
                            Me.Invoke(Sub() lblA1.Text = "1")
                            Me.Invoke(Sub() lblA1.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA1.Text = "1")
                            Me.Invoke(Sub() lblA1.BackColor = Color.Transparent)
                    End Select

                    Select Case results(48).Value
                        Case True
                            Me.Invoke(Sub() lblA2.Text = "2")
                            Me.Invoke(Sub() lblA2.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA2.Text = "2")
                            Me.Invoke(Sub() lblA2.BackColor = Color.Transparent)
                    End Select

                    Select Case results(49).Value
                        Case True
                            Me.Invoke(Sub() lblA3.Text = "3")
                            Me.Invoke(Sub() lblA3.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA3.Text = "3")
                            Me.Invoke(Sub() lblA3.BackColor = Color.Transparent)
                    End Select

                    Select Case results(50).Value
                        Case True
                            Me.Invoke(Sub() lblA4.Text = "4")
                            Me.Invoke(Sub() lblA4.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA4.Text = "4")
                            Me.Invoke(Sub() lblA4.BackColor = Color.Transparent)
                    End Select

                    Select Case results(51).Value
                        Case True
                            Me.Invoke(Sub() lblA5.Text = "5")
                            Me.Invoke(Sub() lblA5.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA5.Text = "5")
                            Me.Invoke(Sub() lblA5.BackColor = Color.Transparent)
                    End Select

                    Select Case results(52).Value
                        Case True
                            Me.Invoke(Sub() lblA6.Text = "6")
                            Me.Invoke(Sub() lblA6.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA6.Text = "6")
                            Me.Invoke(Sub() lblA6.BackColor = Color.Transparent)
                    End Select

                    Select Case results(53).Value
                        Case True
                            Me.Invoke(Sub() lblA7.Text = "7")
                            Me.Invoke(Sub() lblA7.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA7.Text = "7")
                            Me.Invoke(Sub() lblA7.BackColor = Color.Transparent)
                    End Select

                    Select Case results(54).Value
                        Case True
                            Me.Invoke(Sub() lblA8.Text = "8")
                            Me.Invoke(Sub() lblA8.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA8.Text = "8")
                            Me.Invoke(Sub() lblA8.BackColor = Color.Transparent)
                    End Select

                    Select Case results(55).Value
                        Case True
                            Me.Invoke(Sub() lblA9.Text = "9")
                            Me.Invoke(Sub() lblA9.BackColor = Color.Red)
                        Case False
                            Me.Invoke(Sub() lblA9.Text = "9")
                            Me.Invoke(Sub() lblA9.BackColor = Color.Transparent)
                    End Select




                    '###########################################################################

                    Me.Invoke(Sub() LineColor(results(56).Value, L1))

                    Me.Invoke(Sub() L2.BorderColor = L1.BorderColor)
                    Me.Invoke(Sub() L3.BorderColor = L1.BorderColor)
                    Me.Invoke(Sub() L4.BorderColor = L1.BorderColor)
                    Me.Invoke(Sub() L5.BorderColor = L1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(57).Value, L7))
                    Me.Invoke(Sub() L6.BorderColor = L7.BorderColor)

                    Me.Invoke(Sub() LineColor(results(58).Value, L9))

                    Me.Invoke(Sub() L10.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() L11.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() L10_1.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() L10_2.BorderColor = L9.BorderColor)






                    Me.Invoke(Sub() LineShape10.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() LineShape11.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() LineShape15.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() LineShape12.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() LineShape13.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() LineShape14.BorderColor = L9.BorderColor)


                    Me.Invoke(Sub() LineColor(results(59).Value, L17))

                    Me.Invoke(Sub() L17_1.BorderColor = L17.BorderColor)
                    Me.Invoke(Sub() L17_2.BorderColor = L17.BorderColor)

                    Me.Invoke(Sub() LineColor(results(60).Value, L16))

                    Me.Invoke(Sub() L16_1.BorderColor = L16.BorderColor)
                    Me.Invoke(Sub() L16_2.BorderColor = L16.BorderColor)

                    Me.Invoke(Sub() LineColor(results(61).Value, L15))

                    Me.Invoke(Sub() L15_1.BorderColor = L15.BorderColor)
                    Me.Invoke(Sub() L15_2.BorderColor = L15.BorderColor)

                    Me.Invoke(Sub() LineColor(results(62).Value, L14))
                    Me.Invoke(Sub() L14_1.BorderColor = L14.BorderColor)
                    Me.Invoke(Sub() L14_2.BorderColor = L14.BorderColor)

                    Me.Invoke(Sub() LineColor(results(63).Value, L13))

                    Me.Invoke(Sub() L13_1.BorderColor = L13.BorderColor)
                    Me.Invoke(Sub() L13_2.BorderColor = L13.BorderColor)

                    Me.Invoke(Sub() LineColor(results(64).Value, L12))


                    Me.Invoke(Sub() L12_1.BorderColor = L12.BorderColor)
                    Me.Invoke(Sub() L12_2.BorderColor = L12.BorderColor)


                    Me.Invoke(Sub() LineColor(results(65).Value, L10_3))
                    Me.Invoke(Sub() L10_4.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() L10_5.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() LineShape4.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() LineShape5.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() LineShape6.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() LineShape7.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() LineShape8.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() LineShape9.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() RectangleShape1.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() OvalShape1.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() OvalShape2.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() OvalShape3.BorderColor = L10_3.BorderColor)

                    Me.Invoke(Sub() LineShape28.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() LineShape29.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() LineShape27.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() LineShape26.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() LineShape25.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() RectangleShape4.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() OvalShape12.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() OvalShape11.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() OvalShape10.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() LineShape30.BorderColor = L9.BorderColor)

                    Me.Invoke(Sub() LineShape3.BorderColor = L14.BorderColor)
                    Me.Invoke(Sub() LineShape2.BorderColor = L14.BorderColor)
                    Me.Invoke(Sub() LineShape16.BorderColor = L14.BorderColor)
                    Me.Invoke(Sub() LineShape17.BorderColor = L14.BorderColor)
                    Me.Invoke(Sub() LineShape18.BorderColor = L14.BorderColor)
                    Me.Invoke(Sub() RectangleShape2.BorderColor = L14.BorderColor)
                    Me.Invoke(Sub() OvalShape4.BorderColor = L14.BorderColor)
                    Me.Invoke(Sub() OvalShape5.BorderColor = L14.BorderColor)
                    Me.Invoke(Sub() OvalShape6.BorderColor = L14.BorderColor)
                    Me.Invoke(Sub() LineShape1.BorderColor = L14.BorderColor)

                    Me.Invoke(Sub() LineShape24.BorderColor = L15.BorderColor)
                    Me.Invoke(Sub() LineShape22.BorderColor = L15.BorderColor)
                    Me.Invoke(Sub() LineShape23.BorderColor = L15.BorderColor)
                    Me.Invoke(Sub() LineShape21.BorderColor = L15.BorderColor)
                    Me.Invoke(Sub() LineShape20.BorderColor = L15.BorderColor)
                    Me.Invoke(Sub() LineShape19.BorderColor = L15.BorderColor)
                    Me.Invoke(Sub() RectangleShape3.BorderColor = L15.BorderColor)
                    Me.Invoke(Sub() OvalShape9.BorderColor = L15.BorderColor)
                    Me.Invoke(Sub() OvalShape8.BorderColor = L15.BorderColor)
                    Me.Invoke(Sub() OvalShape7.BorderColor = L15.BorderColor)




                Next

                Threading.Thread.Sleep(MSPEED)
            Loop

        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Private Sub frmRP10S1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        m_server.CancelSubscription(groupRP10S1)
        T_RP10S1.Abort()
    End Sub

    Private Sub frmRP10S1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Select Case btnRp10V1.Text

            Case "Старт"

                btnRp10V1.Text = "Стоп"
                T_RP10S1 = New System.Threading.Thread(AddressOf T_RP10S1_START)
                T_RP10S1.Start()

            Case "Стоп"

                btnRp10V1.Text = "Старт"
                m_server.CancelSubscription(groupRP10)
                T_RP10S1.Abort()

        End Select
    End Sub

    Private Sub btnRP10S2_Click(sender As System.Object, e As System.EventArgs) Handles btnRP10S2.Click, Button1.Click
        frmRP10S2.MdiParent = frmIndexer
        frmRP10S2.Show()
        frmRP10S2.Focus()
    End Sub

    Private Sub btnRP10_Click(sender As System.Object, e As System.EventArgs) Handles btnRP10.Click
        frmRP10.MdiParent = frmIndexer
        frmRP10.Show()
        frmRP10.Focus()
    End Sub

    Private Sub VVOD1_F3_VyKL_Click(sender As System.Object, e As System.EventArgs) Handles VVOD1_F3_VyKL.Click, VVOD1_F3_VKL.Click, VVOD1_F3_TV.Click

        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ Фидер 3"
        frmUSTAVKI.Show()

    End Sub

    Private Sub VVOD1_F4_Vykl_Click(sender As System.Object, e As System.EventArgs) Handles VVOD1_F4_Vykl.Click, VVOD1_F4_Vkl.Click, VVOD1_F4_TV.Click

        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ Фидер 4"
        frmUSTAVKI.Show()

    End Sub

    Private Sub VVOD1_F5_VyKL_Click(sender As System.Object, e As System.EventArgs) Handles VVOD1_F5_VyKL.Click, VVOD1_F5_VKL.Click, VVOD1_F5_TV.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ Фидер 5"
        frmUSTAVKI.Show()
    End Sub

    Private Sub VVOD1_F6_VyKL_Click(sender As System.Object, e As System.EventArgs) Handles VVOD1_F6_Vykl.Click, VVOD1_F6_VKL.Click, VVOD1_F6_TV.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ Фидер 6"
        frmUSTAVKI.Show()
    End Sub

    Private Sub VVOD1_F7_VyKL_Click(sender As System.Object, e As System.EventArgs) Handles VVOD1_F7_Vykl.Click, VVOD1_F7_Vkl.Click, VVOD1_F7_TV.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ Фидер 7"
        frmUSTAVKI.Show()
    End Sub

    Private Sub VVOD1_Rez_Vykl_Click(sender As System.Object, e As System.EventArgs) Handles VVOD1_Rez_Vykl.Click, VVOD1_Rez_Vkl.Click, VVOD1_Rez_TV.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ Фидер 8"
        frmUSTAVKI.Show()
    End Sub

    Private Sub VVOD1_SHTN_Vykl_Click(sender As System.Object, e As System.EventArgs) Handles VVOD1_SHTN_Vykl.Click, VVOD1_SHTN_VKL.Click, VVOD1_SHTN_TV.Click

        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ СВ"
        frmUSTAVKI.Show()

    End Sub

    Private Sub LineShape25_Click(sender As System.Object, e As System.EventArgs) Handles LineShape25.Click, RectangleShape4.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ ШТН"
        frmUSTAVKI.Show()

    End Sub

    Private Sub VVOD1_VyKL_Click(sender As System.Object, e As System.EventArgs) Handles VVOD1_VyKL.Click, VVOD1_VKL.Click, VVOD1_TV.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ ВВОД 1"
        frmUSTAVKI.Show()

    End Sub
End Class