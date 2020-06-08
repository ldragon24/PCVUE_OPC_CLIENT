Public Class frmRP10S2
    Dim T_RP10S2 As System.Threading.Thread

    Private Sub btnRP10S1_Click(sender As System.Object, e As System.EventArgs) Handles btnRP10S1.Click, Button1.Click
        frmRP10S1.MdiParent = frmIndexer
        frmRP10S1.Show()
        frmRP10S1.Focus()
    End Sub

    Private Sub btnRp10V2_Click(sender As System.Object, e As System.EventArgs) Handles btnRp10V2.Click
        Select Case btnRp10V2.Text

            Case "Старт"

                btnRp10V2.Text = "Стоп"
                T_RP10S2 = New System.Threading.Thread(AddressOf T_RP10S2_START)
                T_RP10S2.Start()

            Case "Стоп"

                btnRp10V2.Text = "Старт"
                m_server.CancelSubscription(groupRP10S2)
                T_RP10S2.Abort()

        End Select
    End Sub

    Sub T_RP10S2_START()

        Try
ARG:
        
        groupStateRP10S2.Name = "RP10s2"
        groupStateRP10S2.Active = True
            groupStateRP10S2.UpdateRate = MSPEED

        groupRP10S2 = DirectCast(m_server.CreateSubscription(groupStateRP10S2), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(65) {}

        items(0) = New Global.Opc.Da.Item()
        items(0).ItemName = "РП10.С2.10_ВВОД.CLOSE"

        items(1) = New Global.Opc.Da.Item()
        items(1).ItemName = "РП10.С2.11_ШТН.AVR_ON"

        items(2) = New Global.Opc.Da.Item()
        items(2).ItemName = "РП10.С2.10_ВВОД.EARTH_SWITCH"

        items(3) = New Global.Opc.Da.Item()
        items(3).ItemName = "РП10.С2.10_ВВОД.DI"

        items(4) = New Global.Opc.Da.Item()
        items(4).ItemName = "РП10.С2.18_СР.DI"

        items(5) = New Global.Opc.Da.Item()
        items(5).ItemName = "РП10.С2.10_ВВОД.P"

        items(6) = New Global.Opc.Da.Item()
        items(6).ItemName = "РП10.С2.10_ВВОД.Q"

        items(7) = New Global.Opc.Da.Item()
        items(7).ItemName = "РП10.С2.10_ВВОД.I1"

        items(8) = New Global.Opc.Da.Item()
        items(8).ItemName = "РП10.С2.10_ВВОД.U_12"

        items(9) = New Global.Opc.Da.Item()
        items(9).ItemName = "РП10.С2.10_ВВОД.FREQ"

        items(10) = New Global.Opc.Da.Item()
        items(10).ItemName = "РП10.С2.10_ВВОД.EN_SW_CHANGE_ALA"

        'Тележка 18_СР (ручное управление, можем брать только положение тележки)
        items(11) = New Global.Opc.Da.Item()
        items(11).ItemName = "РП10.С2.18_СР.DI"

        'Нож заземления
        items(12) = New Global.Opc.Da.Item()
        items(12).ItemName = "РП10.С1.9_СВ.EARTH_SWITCH"

        items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С1.9_СВ.DO"

        items(14) = New Global.Opc.Da.Item()
        items(14).ItemName = "РП10.С1.9_СВ.CLOSE"

        '#########################################################################
        '#########################################################################
        '#########################################################################
        items(15) = New Global.Opc.Da.Item()
        items(15).ItemName = "РП10.С2.17_ФИД.CLOSE"

        items(16) = New Global.Opc.Da.Item()
        items(16).ItemName = "РП10.С2.17_ФИД.DI"

        items(17) = New Global.Opc.Da.Item()
        items(17).ItemName = "РП10.С2.17_ФИД.I1"

        'Нож заземления
        items(18) = New Global.Opc.Da.Item()
        items(18).ItemName = "РП10.С2.17_ФИД.EARTH_SWITCH"
        '#########################################################################
        items(19) = New Global.Opc.Da.Item()
        items(19).ItemName = "РП10.С2.16_ФИД.CLOSE"

        items(20) = New Global.Opc.Da.Item()
        items(20).ItemName = "РП10.С2.16_ФИД.DI"

        items(21) = New Global.Opc.Da.Item()
        items(21).ItemName = "РП10.С2.16_ФИД.I1"

        'Нож заземления
        items(22) = New Global.Opc.Da.Item()
        items(22).ItemName = "РП10.С2.16_ФИД.EARTH_SWITCH"
        '#########################################################################

        items(23) = New Global.Opc.Da.Item()
        items(23).ItemName = "РП10.С2.15_ФИД.CLOSE"

        items(24) = New Global.Opc.Da.Item()
        items(24).ItemName = "РП10.С2.15_ФИД.DI"

        'Нож заземления
        items(25) = New Global.Opc.Da.Item()
        items(25).ItemName = "РП10.С2.15_ФИД.EARTH_SWITCH"

        items(26) = New Global.Opc.Da.Item()
        items(26).ItemName = "РП10.С2.15_ФИД.P"

        items(27) = New Global.Opc.Da.Item()
        items(27).ItemName = "РП10.С2.15_ФИД.Q"

        items(28) = New Global.Opc.Da.Item()
        items(28).ItemName = "РП10.С2.15_ФИД.I1"

        items(29) = New Global.Opc.Da.Item()
        items(29).ItemName = "РП10.С2.15_ФИД.U_12"

        '#########################################################################

        items(30) = New Global.Opc.Da.Item()
        items(30).ItemName = "РП10.С2.14_ФИД.CLOSE"

        items(31) = New Global.Opc.Da.Item()
        items(31).ItemName = "РП10.С2.14_ФИД.DI"

        'Нож заземления
        items(32) = New Global.Opc.Da.Item()
        items(32).ItemName = "РП10.С2.14_ФИД.EARTH_SWITCH"

        items(33) = New Global.Opc.Da.Item()
        items(33).ItemName = "РП10.С2.14_ФИД.P"

        items(34) = New Global.Opc.Da.Item()
        items(34).ItemName = "РП10.С2.14_ФИД.Q"

        items(35) = New Global.Opc.Da.Item()
        items(35).ItemName = "РП10.С2.14_ФИД.I1"

        items(36) = New Global.Opc.Da.Item()
        items(36).ItemName = "РП10.С2.14_ФИД.U_12"

        '#########################################################################
        items(37) = New Global.Opc.Da.Item()
        items(37).ItemName = "РП10.С2.13_ФИД.CLOSE"

        items(38) = New Global.Opc.Da.Item()
        items(38).ItemName = "РП10.С2.13_ФИД.DI"

        items(39) = New Global.Opc.Da.Item()
        items(39).ItemName = "РП10.С2.13_ФИД.I1"

        'Нож заземления
        items(40) = New Global.Opc.Da.Item()
        items(40).ItemName = "РП10.С2.13_ФИД.EARTH_SWITCH"
        '#########################################################################
        items(41) = New Global.Opc.Da.Item()
        items(41).ItemName = "РП10.С2.12_ФИД.CLOSE"

        items(42) = New Global.Opc.Da.Item()
        items(42).ItemName = "РП10.С2.12_ФИД.DI"

        items(43) = New Global.Opc.Da.Item()
        items(43).ItemName = "РП10.С2.12_ФИД.I1"

        'Нож заземления
        items(44) = New Global.Opc.Da.Item()
        items(44).ItemName = "РП10.С2.12_ФИД.EARTH_SWITCH"
        '#########################################################################

        'Фидер 11 ШТН
        'Нож заземления
        items(45) = New Global.Opc.Da.Item()
        items(45).ItemName = "РП10.С2.1_ФИД.EARTH_SWITCH"


        '#########################################################################
        items(46) = New Global.Opc.Da.Item()
        items(46).ItemName = "РП10.С2.15_ФИД.TRIP"

        items(47) = New Global.Opc.Da.Item()
        items(47).ItemName = "РП10.С2.14_ФИД.TRIP"

        items(48) = New Global.Opc.Da.Item()
        items(48).ItemName = "РП10.С2.13_ФИД.TRIP"

        items(49) = New Global.Opc.Da.Item()
        items(49).ItemName = "РП10.С2.12_ФИД.TRIP"

        items(50) = New Global.Opc.Da.Item()
        items(50).ItemName = "РП10.С2.11_ФИД.TRIP"

        items(51) = New Global.Opc.Da.Item()
        items(51).ItemName = "РП10.С2.16_ФИД.TRIP"

        items(52) = New Global.Opc.Da.Item()
        items(52).ItemName = "РП10.С2.17_ФИД.TRIP"

        items(53) = New Global.Opc.Da.Item()
        items(53).ItemName = "РП10.С1.9_СВ.TRIP"

        items(54) = New Global.Opc.Da.Item()
        items(54).ItemName = "РП10.С2.10_ВВОД.TRIP"


            items(55) = New Global.Opc.Da.Item()
            items(55).ItemName = "РП10.С1.1_ВВОД.VOLT_COLOR"


            items(56) = New Global.Opc.Da.Item()
            items(56).ItemName = "РП10.С2.18_СР.VOLT_COLOR"


            items(57) = New Global.Opc.Da.Item()
            items(57).ItemName = "РП10.С2.10_ВВОД.VOLT_COLOR"

            items(58) = New Global.Opc.Da.Item()
            items(58).ItemName = "РП10.С2.15_ФИД.VOLT_COLOR"

            items(59) = New Global.Opc.Da.Item()
            items(59).ItemName = "РП10.С2.14_ФИД.VOLT_COLOR"

            items(60) = New Global.Opc.Da.Item()
            items(60).ItemName = "РП10.С2.13_ФИД.VOLT_COLOR"

            items(61) = New Global.Opc.Da.Item()
            items(61).ItemName = "РП10.С2.12_ФИД.VOLT_COLOR"

            items(62) = New Global.Opc.Da.Item()
            items(62).ItemName = "РП10.С2.11_ФИД.VOLT_COLOR"

            items(63) = New Global.Opc.Da.Item()
            items(63).ItemName = "РП10.С2.16_ФИД.VOLT_COLOR"

            items(64) = New Global.Opc.Da.Item()
            items(64).ItemName = "РП10.С2.17_ФИД.VOLT_COLOR"

            items(65) = New Global.Opc.Da.Item()
            items(65).ItemName = "РП10.С2.10_ВВОД.VOLT_COLOR_TN"

        items = groupRP10S2.AddItems(items)

        Do

            Dim results As ItemValueResult() = Nothing
            results = groupRP10S2.Read(items)
            For Each item As Item In items
                item.ClientHandle = item.ItemName
            Next

            results = m_server.Read(items)

            For i As Integer = 0 To results.Length - 1


                Select Case results(3).Value

                    Case False
                        Me.Invoke(Sub() VVOD2_VKL.Visible = False)
                        Me.Invoke(Sub() VVOD2_VyKL.Visible = False)
                        Me.Invoke(Sub() VVOD2_TV.Visible = True)
                    Case True
                        Me.Invoke(Sub() VVOD2_TV.Visible = False)

                        Select Case results(0).Value

                            Case True
                                ' VVOD1_VKL
                                Me.Invoke(Sub() VVOD2_VKL.Visible = True)
                                Me.Invoke(Sub() VVOD2_VyKL.Visible = False)
                            Case False
                                Me.Invoke(Sub() VVOD2_VKL.Visible = False)
                                Me.Invoke(Sub() VVOD2_VyKL.Visible = True)
                        End Select

                End Select

                Dim MGg As Double = results(5).Value
                Me.Invoke(Sub() lblVV2_P.Text = Math.Round(MGg, 1) & " кВт")

                MGg = results(6).Value
                Me.Invoke(Sub() lblVV2_Q.Text = Math.Round(MGg, 1) & " кВар")

                MGg = results(7).Value
                Me.Invoke(Sub() lblVV2_I.Text = Math.Round(MGg, 1) & " A")

                MGg = results(8).Value
                Me.Invoke(Sub() lblVV2_U.Text = Math.Round(MGg, 1) & " Кв")

                Me.Invoke(Sub() lblVV2_U_.Text = lblVV2_U.Text)

                MGg = results(9).Value
                Me.Invoke(Sub() lblVV2_F_.Text = Math.Round(MGg, 1) & " Гц")

                Select Case results(10).Value

                    Case True
                        Me.Invoke(Sub() lblVV2_ES.Enabled = True)
                    Case False
                        Me.Invoke(Sub() lblVV2_ES.Enabled = False)

                End Select

                Select Case results(1).Value

                    Case True
                        Me.Invoke(Sub() lblAVR_vkl.Enabled = True)
                        Me.Invoke(Sub() lblAVR_vykl.Enabled = False)
                    Case False
                        Me.Invoke(Sub() lblAVR_vkl.Enabled = False)
                        Me.Invoke(Sub() lblAVR_vykl.Enabled = True)
                End Select

                Select Case results(13).Value

                    Case False
                        Me.Invoke(Sub() VVOD1_SHTN_VKL.Visible = False)
                        Me.Invoke(Sub() VVOD1_SHTN_Vykl.Visible = False)
                        Me.Invoke(Sub() VVOD1_SHTN_TV.Visible = True)
                    Case True
                        Me.Invoke(Sub() VVOD1_SHTN_TV.Visible = False)

                        Select Case results(14).Value

                            Case True

                                Me.Invoke(Sub() VVOD1_SHTN_VKL.Visible = True)
                                Me.Invoke(Sub() VVOD1_SHTN_Vykl.Visible = False)
                            Case False
                                Me.Invoke(Sub() VVOD1_SHTN_VKL.Visible = False)
                                Me.Invoke(Sub() VVOD1_SHTN_Vykl.Visible = True)
                        End Select
                End Select

                Select Case results(12).Quality.ToString

                        Case "good"
                            Me.Invoke(Sub() lblSW_EA.Visible = False)

                            Select Case results(12).Value

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

                Select Case results(11).Value

                    Case False
                        Me.Invoke(Sub() VVOD2_SHTN_VKL.Visible = False)
                        Me.Invoke(Sub() VVOD2_SHTN_VyKL.Visible = False)
                        Me.Invoke(Sub() VVOD2_SHTN_TV.Visible = True)
                    Case True
                        Me.Invoke(Sub() VVOD2_SHTN_TV.Visible = False)

                        Select Case results(11).Value

                            Case True

                                Me.Invoke(Sub() VVOD2_SHTN_VKL.Visible = True)
                                Me.Invoke(Sub() VVOD2_SHTN_VyKL.Visible = False)
                            Case False
                                Me.Invoke(Sub() VVOD2_SHTN_VKL.Visible = False)
                                Me.Invoke(Sub() VVOD2_SHTN_VyKL.Visible = True)
                        End Select
                End Select


                Select Case results(2).Value

                    Case True

                        Me.Invoke(Sub() VVOD2_Earth_VKL.Visible = True)
                        Me.Invoke(Sub() VVOD2_Earth_VyKL.Visible = False)
                    Case False
                        Me.Invoke(Sub() VVOD2_Earth_VKL.Visible = False)
                        Me.Invoke(Sub() VVOD2_Earth_VyKL.Visible = True)
                End Select


                '#########################################################
                '17 фидер - Резерв

                Select Case results(16).Value

                    Case False
                        Me.Invoke(Sub() VVOD2_F17_Vkl.Visible = False)
                        Me.Invoke(Sub() VVOD2_F17_Vykl.Visible = False)
                        Me.Invoke(Sub() VVOD2_F17_TV.Visible = True)
                    Case True
                        Me.Invoke(Sub() VVOD2_F17_TV.Visible = False)

                        Select Case results(15).Value

                            Case True
                                Me.Invoke(Sub() VVOD2_F17_Vkl.Visible = True)
                                Me.Invoke(Sub() VVOD2_F17_Vykl.Visible = False)
                            Case False
                                Me.Invoke(Sub() VVOD2_F17_Vkl.Visible = False)
                                Me.Invoke(Sub() VVOD2_F17_Vykl.Visible = True)
                        End Select

                End Select

                MGg = results(17).Value
                Me.Invoke(Sub() lbl_F17.Text = Math.Round(MGg, 1) & " A")

                Select Case results(18).Value

                    Case True

                        Me.Invoke(Sub() VVOD2_F17_EA_VKL.Visible = True)
                        Me.Invoke(Sub() VVOD2_F17_EA_VyKL.Visible = False)
                    Case False
                        Me.Invoke(Sub() VVOD2_F17_EA_VKL.Visible = False)
                        Me.Invoke(Sub() VVOD2_F17_EA_VyKL.Visible = True)
                End Select

                '#########################################################
                '16 фидер - Резерв

                Select Case results(20).Value

                    Case False
                        Me.Invoke(Sub() VVOD2_F16_Vkl.Visible = False)
                        Me.Invoke(Sub() VVOD2_F16_Vykl.Visible = False)
                        Me.Invoke(Sub() VVOD2_F16_TV.Visible = True)
                    Case True
                        Me.Invoke(Sub() VVOD2_F16_TV.Visible = False)

                        Select Case results(19).Value

                            Case True
                                Me.Invoke(Sub() VVOD2_F16_Vkl.Visible = True)
                                Me.Invoke(Sub() VVOD2_F16_Vykl.Visible = False)
                            Case False
                                Me.Invoke(Sub() VVOD2_F16_Vkl.Visible = False)
                                Me.Invoke(Sub() VVOD2_F16_Vykl.Visible = True)
                        End Select

                End Select

                MGg = results(21).Value
                Me.Invoke(Sub() lbl_F16.Text = Math.Round(MGg, 1) & " A")

                Select Case results(22).Value

                    Case True

                        Me.Invoke(Sub() VVOD2_F16_EA_VKL.Visible = True)
                        Me.Invoke(Sub() VVOD2_F16_EA_VyKL.Visible = False)
                    Case False
                        Me.Invoke(Sub() VVOD2_F16_EA_VKL.Visible = False)
                        Me.Invoke(Sub() VVOD2_F16_EA_VyKL.Visible = True)
                End Select

                '#########################################################
                '15 фидер - Починки-Ярославль
                Select Case results(24).Value

                    Case False
                        Me.Invoke(Sub() VVOD2_F15_VKL.Visible = False)
                        Me.Invoke(Sub() VVOD2_F15_VyKL.Visible = False)
                        Me.Invoke(Sub() VVOD2_F15_TV.Visible = True)
                    Case True
                        Me.Invoke(Sub() VVOD2_F15_TV.Visible = False)

                        Select Case results(23).Value

                            Case True
                                Me.Invoke(Sub() VVOD2_F15_VKL.Visible = True)
                                Me.Invoke(Sub() VVOD2_F15_VyKL.Visible = False)
                            Case False
                                Me.Invoke(Sub() VVOD2_F15_VKL.Visible = False)
                                Me.Invoke(Sub() VVOD2_F15_VyKL.Visible = True)
                        End Select

                End Select

                Select Case results(25).Value

                    Case True

                        Me.Invoke(Sub() VVOD2_F15_EA_Vkl.Visible = True)
                        Me.Invoke(Sub() VVOD2_F15_EA_Vykl.Visible = False)
                    Case False
                        Me.Invoke(Sub() VVOD2_F15_EA_Vkl.Visible = False)
                        Me.Invoke(Sub() VVOD2_F15_EA_Vykl.Visible = True)
                End Select


                MGg = results(26).Value
                Me.Invoke(Sub() lblF15_P.Text = Math.Round(MGg, 1) & " Кв")
                MGg = results(27).Value
                Me.Invoke(Sub() lblF15_Q.Text = Math.Round(MGg, 1) & " Квар")
                MGg = results(28).Value
                Me.Invoke(Sub() lblF15_I.Text = Math.Round(MGg, 1) & " A")
                MGg = results(29).Value
                Me.Invoke(Sub() lblF15_U.Text = Math.Round(MGg, 1) & " Квт")

                '#########################################################
                '14 фидер - Ямбург-Тула1
                Select Case results(31).Value

                    Case False
                        Me.Invoke(Sub() VVOD2_F14_VKL.Visible = False)
                        Me.Invoke(Sub() VVOD2_F14_VyKL.Visible = False)
                        Me.Invoke(Sub() VVOD2_F14_TV.Visible = True)
                    Case True
                        Me.Invoke(Sub() VVOD2_F14_TV.Visible = False)

                        Select Case results(30).Value

                            Case True
                                Me.Invoke(Sub() VVOD2_F14_VKL.Visible = True)
                                Me.Invoke(Sub() VVOD2_F14_VyKL.Visible = False)
                            Case False
                                Me.Invoke(Sub() VVOD2_F14_VKL.Visible = False)
                                Me.Invoke(Sub() VVOD2_F14_VyKL.Visible = True)
                        End Select

                End Select

                Select Case results(32).Value

                    Case True

                        Me.Invoke(Sub() VVOD2_F14_EA_Vkl.Visible = True)
                        Me.Invoke(Sub() VVOD2_F14_EA_Vykl.Visible = False)
                    Case False
                        Me.Invoke(Sub() VVOD2_F14_EA_Vkl.Visible = False)
                        Me.Invoke(Sub() VVOD2_F14_EA_Vykl.Visible = True)
                End Select


                MGg = results(33).Value
                Me.Invoke(Sub() lblF14_P.Text = Math.Round(MGg, 1) & " Кв")
                MGg = results(34).Value
                Me.Invoke(Sub() lblF14_Q.Text = Math.Round(MGg, 1) & " Квар")
                MGg = results(35).Value
                Me.Invoke(Sub() lblF14_I.Text = Math.Round(MGg, 1) & " A")
                MGg = results(36).Value
                Me.Invoke(Sub() lblF14_U.Text = Math.Round(MGg, 1) & " Квт")


                '#########################################################
                '13 фидер - КТП АВО С1
                Select Case results(38).Value

                    Case False
                        Me.Invoke(Sub() VVOD2_F13_Vkl.Visible = False)
                        Me.Invoke(Sub() VVOD2_F13_Vykl.Visible = False)
                        Me.Invoke(Sub() VVOD2_F13_TV.Visible = True)
                    Case True
                        Me.Invoke(Sub() VVOD2_F13_TV.Visible = False)

                        Select Case results(37).Value

                            Case True
                                Me.Invoke(Sub() VVOD2_F13_Vkl.Visible = True)
                                Me.Invoke(Sub() VVOD2_F13_Vykl.Visible = False)
                            Case False
                                Me.Invoke(Sub() VVOD2_F13_Vkl.Visible = False)
                                Me.Invoke(Sub() VVOD2_F13_Vykl.Visible = True)
                        End Select

                End Select

                MGg = results(39).Value
                Me.Invoke(Sub() lbl_F13.Text = Math.Round(MGg, 1) & " A")

                Select Case results(40).Value

                    Case True

                        Me.Invoke(Sub() VVOD2_F13_EA_VKL.Visible = True)
                        Me.Invoke(Sub() VVOD2_F13_EA_VyKL.Visible = False)
                    Case False
                        Me.Invoke(Sub() VVOD2_F13_EA_VKL.Visible = False)
                        Me.Invoke(Sub() VVOD2_F13_EA_VyKL.Visible = True)
                End Select


                '#########################################################
                '12 фидер - КТП ЭБ С2

                Select Case results(42).Value

                    Case False
                        Me.Invoke(Sub() VVOD2_F12_Vkl.Visible = False)
                        Me.Invoke(Sub() VVOD2_F12_Vykl.Visible = False)
                        Me.Invoke(Sub() VVOD2_F12_TV.Visible = True)
                    Case True
                        Me.Invoke(Sub() VVOD2_F12_TV.Visible = False)

                        Select Case results(41).Value

                            Case True
                                Me.Invoke(Sub() VVOD2_F12_Vkl.Visible = True)
                                Me.Invoke(Sub() VVOD2_F12_Vykl.Visible = False)
                            Case False
                                Me.Invoke(Sub() VVOD2_F12_Vkl.Visible = False)
                                Me.Invoke(Sub() VVOD2_F12_Vykl.Visible = True)
                        End Select

                End Select

                MGg = results(43).Value
                Me.Invoke(Sub() lbl_F12.Text = Math.Round(MGg, 1) & " A")

                Select Case results(44).Value

                    Case True

                        Me.Invoke(Sub() VVOD2_F12_EA_VKL.Visible = True)
                        Me.Invoke(Sub() VVOD2_F12_EA_VyKL.Visible = False)
                    Case False
                        Me.Invoke(Sub() VVOD2_F12_EA_VKL.Visible = False)
                        Me.Invoke(Sub() VVOD2_F12_EA_VyKL.Visible = True)
                End Select

                '#########################################################
                '11 фидер - ШТН
                Select Case results(45).Value

                    Case True

                        Me.Invoke(Sub() VVOD2_F11_EA_Vkl.Visible = True)
                        Me.Invoke(Sub() VVOD2_F11_EA_Vykl.Visible = False)
                    Case False
                        Me.Invoke(Sub() VVOD2_F11_EA_Vkl.Visible = False)
                        Me.Invoke(Sub() VVOD2_F11_EA_Vykl.Visible = True)
                End Select



                '################################################
                'Сигнализация

                Select Case results(52).Value
                    Case True
                        Me.Invoke(Sub() lblA17.Text = "17")
                        Me.Invoke(Sub() lblA17.BackColor = Color.Red)
                    Case False
                        Me.Invoke(Sub() lblA17.Text = "17")
                        Me.Invoke(Sub() lblA17.BackColor = Color.Transparent)
                End Select

                Select Case results(51).Value
                    Case True
                        Me.Invoke(Sub() lblA16.Text = "16")
                        Me.Invoke(Sub() lblA16.BackColor = Color.Red)
                    Case False
                        Me.Invoke(Sub() lblA16.Text = "16")
                        Me.Invoke(Sub() lblA16.BackColor = Color.Transparent)
                End Select

                Select Case results(46).Value
                    Case True
                        Me.Invoke(Sub() lblA15.Text = "15")
                        Me.Invoke(Sub() lblA15.BackColor = Color.Red)
                    Case False
                        Me.Invoke(Sub() lblA15.Text = "15")
                        Me.Invoke(Sub() lblA15.BackColor = Color.Transparent)
                End Select

                Select Case results(47).Value
                    Case True
                        Me.Invoke(Sub() lblA14.Text = "14")
                        Me.Invoke(Sub() lblA14.BackColor = Color.Red)
                    Case False
                        Me.Invoke(Sub() lblA14.Text = "14")
                        Me.Invoke(Sub() lblA14.BackColor = Color.Transparent)
                End Select

                Select Case results(48).Value
                    Case True
                        Me.Invoke(Sub() lblA13.Text = "13")
                        Me.Invoke(Sub() lblA13.BackColor = Color.Red)
                    Case False
                        Me.Invoke(Sub() lblA13.Text = "13")
                        Me.Invoke(Sub() lblA13.BackColor = Color.Transparent)
                End Select

                Select Case results(49).Value
                    Case True
                        Me.Invoke(Sub() lblA12.Text = "12")
                        Me.Invoke(Sub() lblA12.BackColor = Color.Red)
                    Case False
                        Me.Invoke(Sub() lblA12.Text = "12")
                        Me.Invoke(Sub() lblA12.BackColor = Color.Transparent)
                End Select

                Select Case results(50).Value
                    Case True
                        Me.Invoke(Sub() lblA11.Text = "11")
                        Me.Invoke(Sub() lblA11.BackColor = Color.Red)
                    Case False
                        Me.Invoke(Sub() lblA11.Text = "11")
                        Me.Invoke(Sub() lblA11.BackColor = Color.Transparent)
                End Select

                Select Case results(53).Value
                    Case True
                        Me.Invoke(Sub() lblA9.Text = "9")
                        Me.Invoke(Sub() lblA9.BackColor = Color.Red)
                    Case False
                        Me.Invoke(Sub() lblA9.Text = "9")
                        Me.Invoke(Sub() lblA9.BackColor = Color.Transparent)
                End Select

                Select Case results(54).Value
                    Case True
                        Me.Invoke(Sub() lblA2.Text = "2")
                        Me.Invoke(Sub() lblA2.BackColor = Color.Red)
                    Case False
                        Me.Invoke(Sub() lblA2.Text = "2")
                        Me.Invoke(Sub() lblA2.BackColor = Color.Transparent)
                End Select



                    '########################################################


                    Me.Invoke(Sub() LineColor(results(56).Value, L1))

                    Me.Invoke(Sub() L2.BorderColor = L1.BorderColor)
                    Me.Invoke(Sub() L3.BorderColor = L1.BorderColor)
                    Me.Invoke(Sub() L4.BorderColor = L1.BorderColor)
                    Me.Invoke(Sub() L5.BorderColor = L1.BorderColor)


                    Me.Invoke(Sub() LineColor(results(55).Value, L7))
                    Me.Invoke(Sub() L9.BorderColor = L7.BorderColor)


                    Me.Invoke(Sub() LineColor(results(57).Value, L11))

                    Me.Invoke(Sub() L6.BorderColor = L11.BorderColor)
                    Me.Invoke(Sub() LineShape10.BorderColor = L11.BorderColor)
                    Me.Invoke(Sub() LineShape1.BorderColor = L11.BorderColor)
                    Me.Invoke(Sub() LineShape2.BorderColor = L11.BorderColor)
                    Me.Invoke(Sub() LineShape3.BorderColor = L11.BorderColor)
                    Me.Invoke(Sub() LineShape4.BorderColor = L11.BorderColor)
                    Me.Invoke(Sub() LineShape5.BorderColor = L11.BorderColor)
                    Me.Invoke(Sub() LineShape6.BorderColor = L11.BorderColor)
                    Me.Invoke(Sub() LineShape7.BorderColor = L11.BorderColor)
                    Me.Invoke(Sub() L10.BorderColor = L11.BorderColor)

                    Me.Invoke(Sub() LineColor(results(64).Value, L12))
                    Me.Invoke(Sub() L12_1.BorderColor = L12.BorderColor)
                    Me.Invoke(Sub() L12_2.BorderColor = L12.BorderColor)

                    Me.Invoke(Sub() LineColor(results(63).Value, LineShape12))
                    Me.Invoke(Sub() LineShape13.BorderColor = LineShape12.BorderColor)
                    Me.Invoke(Sub() LineShape14.BorderColor = LineShape12.BorderColor)


                    Me.Invoke(Sub() LineColor(results(58).Value, L15))

                    Me.Invoke(Sub() L15_1.BorderColor = L15.BorderColor)
                    Me.Invoke(Sub() L15_2.BorderColor = L15.BorderColor)


                    Me.Invoke(Sub() LineColor(results(59).Value, LineShape8))

                    Me.Invoke(Sub() LineShape9.BorderColor = LineShape8.BorderColor)
                    Me.Invoke(Sub() LineShape11.BorderColor = LineShape8.BorderColor)


                    Me.Invoke(Sub() LineColor(results(60).Value, LineShape15))


                    Me.Invoke(Sub() LineShape16.BorderColor = LineShape15.BorderColor)
                    Me.Invoke(Sub() LineShape17.BorderColor = LineShape15.BorderColor)


                    Me.Invoke(Sub() LineColor(results(61).Value, LineShape18))

                    Me.Invoke(Sub() LineShape19.BorderColor = LineShape18.BorderColor)
                    Me.Invoke(Sub() LineShape20.BorderColor = LineShape18.BorderColor)

                    Me.Invoke(Sub() LineColor(results(65).Value, L10_3))
                    Me.Invoke(Sub() L10_4.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() L10_5.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() LineShape21.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() LineShape22.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() LineShape23.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() LineShape24.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() LineShape25.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() LineShape26.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() RectangleShape1.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() OvalShape1.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() OvalShape2.BorderColor = L10_3.BorderColor)
                    Me.Invoke(Sub() OvalShape3.BorderColor = L10_3.BorderColor)


                    Me.Invoke(Sub() LineShape32.BorderColor = L15_1.BorderColor)
                    Me.Invoke(Sub() LineShape30.BorderColor = L15_1.BorderColor)
                    Me.Invoke(Sub() LineShape31.BorderColor = L15_1.BorderColor)
                    Me.Invoke(Sub() LineShape29.BorderColor = L15_1.BorderColor)
                    Me.Invoke(Sub() LineShape28.BorderColor = L15_1.BorderColor)
                    Me.Invoke(Sub() LineShape27.BorderColor = L15_1.BorderColor)
                    Me.Invoke(Sub() RectangleShape2.BorderColor = L15_1.BorderColor)
                    Me.Invoke(Sub() OvalShape6.BorderColor = L15_1.BorderColor)
                    Me.Invoke(Sub() OvalShape5.BorderColor = L15_1.BorderColor)
                    Me.Invoke(Sub() OvalShape4.BorderColor = L15_1.BorderColor)


                    Me.Invoke(Sub() LineShape38.BorderColor = LineShape9.BorderColor)
                    Me.Invoke(Sub() LineShape36.BorderColor = LineShape9.BorderColor)
                    Me.Invoke(Sub() LineShape37.BorderColor = LineShape9.BorderColor)
                    Me.Invoke(Sub() LineShape35.BorderColor = LineShape9.BorderColor)
                    Me.Invoke(Sub() LineShape34.BorderColor = LineShape9.BorderColor)
                    Me.Invoke(Sub() LineShape33.BorderColor = LineShape9.BorderColor)
                    Me.Invoke(Sub() RectangleShape3.BorderColor = LineShape9.BorderColor)
                    Me.Invoke(Sub() OvalShape9.BorderColor = LineShape9.BorderColor)
                    Me.Invoke(Sub() OvalShape8.BorderColor = LineShape9.BorderColor)
                    Me.Invoke(Sub() OvalShape7.BorderColor = LineShape9.BorderColor)


                    Me.Invoke(Sub() LineShape42.BorderColor = LineShape6.BorderColor)
                    Me.Invoke(Sub() LineShape43.BorderColor = LineShape6.BorderColor)
                    Me.Invoke(Sub() LineShape40.BorderColor = LineShape6.BorderColor)
                    Me.Invoke(Sub() LineShape41.BorderColor = LineShape6.BorderColor)
                    Me.Invoke(Sub() LineShape39.BorderColor = LineShape6.BorderColor)
                    Me.Invoke(Sub() RectangleShape4.BorderColor = LineShape6.BorderColor)
                    Me.Invoke(Sub() OvalShape12.BorderColor = LineShape6.BorderColor)
                    Me.Invoke(Sub() OvalShape10.BorderColor = LineShape6.BorderColor)
                    Me.Invoke(Sub() OvalShape11.BorderColor = LineShape6.BorderColor)



                    'LineShape18
                Next

                Threading.Thread.Sleep(MSPEED)
        Loop

        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try


    End Sub

    Private Sub frmRP10S2_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        m_server.CancelSubscription(groupRP10S2)
        T_RP10S2.Abort()

    End Sub

    Private Sub frmRP10S2_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Select Case btnRp10V2.Text

            Case "Старт"

                btnRp10V2.Text = "Стоп"
                T_RP10S2 = New System.Threading.Thread(AddressOf T_RP10S2_START)
                T_RP10S2.Start()

            Case "Стоп"

                btnRp10V2.Text = "Старт"
                m_server.CancelSubscription(groupRP10S2)
                T_RP10S2.Abort()

        End Select

    End Sub

    Private Sub btnRP10_Click(sender As System.Object, e As System.EventArgs) Handles btnRP10.Click
        frmRP10.MdiParent = frmIndexer
        frmRP10.Show()
        frmRP10.Focus()
    End Sub

    Private Sub VVOD2_VyKL_Click(sender As System.Object, e As System.EventArgs) Handles VVOD2_VyKL.Click, VVOD2_VKL.Click, VVOD2_TV.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ ВВОД 2"
        frmUSTAVKI.Show()
    End Sub

    Private Sub VVOD1_SHTN_Vykl_Click(sender As System.Object, e As System.EventArgs) Handles VVOD1_SHTN_Vykl.Click, VVOD1_SHTN_VKL.Click, VVOD1_SHTN_TV.Click

        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ СВ"
        frmUSTAVKI.Show()

    End Sub

    Private Sub VVOD2_F17_Vykl_Click(sender As System.Object, e As System.EventArgs) Handles VVOD2_F17_Vykl.Click, VVOD2_F17_Vkl.Click, VVOD2_F17_TV.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ Фидер 17"
        frmUSTAVKI.Show()
    End Sub

    Private Sub VVOD2_F16_Vykl_Click(sender As System.Object, e As System.EventArgs) Handles VVOD2_F16_Vykl.Click, VVOD2_F16_Vkl.Click, VVOD2_F16_TV.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ Фидер 16"
        frmUSTAVKI.Show()
    End Sub

    Private Sub VVOD2_F15_Vykl_Click(sender As System.Object, e As System.EventArgs) Handles VVOD2_F15_VyKL.Click, VVOD2_F15_VKL.Click, VVOD2_F15_TV.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ Фидер 15"
        frmUSTAVKI.Show()
    End Sub

    Private Sub VVOD2_F14_Vykl_Click(sender As System.Object, e As System.EventArgs) Handles VVOD2_F14_VyKL.Click, VVOD2_F14_VKL.Click, VVOD2_F14_TV.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ Фидер 14"
        frmUSTAVKI.Show()
    End Sub

    Private Sub VVOD2_F13_Vykl_Click(sender As System.Object, e As System.EventArgs) Handles VVOD2_F13_Vykl.Click, VVOD2_F13_Vkl.Click, VVOD2_F13_TV.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ Фидер 13"
        frmUSTAVKI.Show()
    End Sub

    Private Sub VVOD2_F12_Vykl_Click(sender As System.Object, e As System.EventArgs) Handles VVOD2_F12_Vykl.Click, VVOD2_F12_Vkl.Click, VVOD2_F12_TV.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ Фидер 12"
        frmUSTAVKI.Show()
    End Sub

End Class