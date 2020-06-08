Public Class frm_CHGP
    Dim T_CHGP As System.Threading.Thread

    Private Sub frm_CHGP_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        m_server.CancelSubscription(group_CHGP)
        T_CHGP.Abort()

    End Sub

    Private Sub frm_CHGP_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'btnCHGP
        Select Case btnCHGP.Text

            Case "Старт"

                btnCHGP.Text = "Стоп"
                T_CHGP = New System.Threading.Thread(AddressOf T_CHGP_START)
                T_CHGP.Start()

            Case "Стоп"

                btnCHGP.Text = "Старт"
                m_server.CancelSubscription(group_CHGP)
                T_CHGP.Abort()

        End Select

    End Sub

    Sub T_CHGP_START()

        Try

ARG:
            groupState_CHGP.Name = "CHGP"
            groupState_CHGP.Active = True
            groupState_CHGP.UpdateRate = MSPEED

            group_CHGP = DirectCast(m_server.CreateSubscription(groupState_CHGP), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(55) {}
            'ЩГП ЭБ Инвертор 1
            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "ЩГП_ЭБ.С1.ИНВ1.INV_OPERATING"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "ЩГП_ЭБ.С1.ИНВ1.NET_OPERATING"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "ЩГП_ЭБ.С1.ИНВ1.MANUAL_BP_NET"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "ЩГП_ЭБ.С1.ИНВ1.BATTERY_LOW"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "ЩГП_ЭБ.С1.ИНВ1.GENERAL_FAULT"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "ЩГП_ЭБ.С1.QF1.CLOSE"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "ЩГП_ЭБ.С1.QF1.DOC"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "ЩГП_ЭБ.С1.QF3.CLOSE"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "ЩГП_ЭБ.С1.QF3.DOC"

            'ЩГП ЭБ Инвертор 2
            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "ЩГП_ЭБ.С2.ИНВ2.INV_OPERATING"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "ЩГП_ЭБ.С2.ИНВ2.NET_OPERATING"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "ЩГП_ЭБ.С2.ИНВ2.MANUAL_BP_NET"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "ЩГП_ЭБ.С2.ИНВ2.BATTERY_LOW"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "ЩГП_ЭБ.С2.ИНВ2.GENERAL_FAULT"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "ЩГП_ЭБ.С2.QF2.CLOSE"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "ЩГП_ЭБ.С2.QF2.DOC"

            'ЩГП РЭБа Инвертор 1

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "ЩГП_РЭБ.С1.ИНВ1.INV_OPERATING"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "ЩГП_РЭБ.С1.ИНВ1.NET_OPERATING"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "ЩГП_РЭБ.С1.ИНВ1.MANUAL_BP_NET"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "ЩГП_РЭБ.С1.ИНВ1.BATTERY_LOW"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "ЩГП_РЭБ.С1.ИНВ1.GENERAL_FAULT"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "ЩГП_РЭБ.С1.QF1.CLOSE"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "ЩГП_РЭБ.С1.QF1.DOC"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "ЩГП_РЭБ.С1.QF3.CLOSE"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "ЩГП_РЭБ.С1.QF3.DOC"

            'ЩГП РЭБа Инвертор 2

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "ЩГП_РЭБ.С2.ИНВ2.INV_OPERATING"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "ЩГП_РЭБ.С2.ИНВ2.NET_OPERATING"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "ЩГП_РЭБ.С2.ИНВ2.MANUAL_BP_NET"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "ЩГП_РЭБ.С2.ИНВ2.BATTERY_LOW"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "ЩГП_РЭБ.С2.ИНВ2.GENERAL_FAULT"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "ЩГП_РЭБ.С2.QF2.CLOSE"

            items(31) = New Global.Opc.Da.Item()
            items(31).ItemName = "ЩГП_РЭБ.С2.QF2.DOC"

            ''''''''''''''''''''''''''''''''''''''''''''''
            items(32) = New Global.Opc.Da.Item()
            items(32).ItemName = "КТП_РЭБ.С1.КАУ1.AB_DISCHARGE"

            items(33) = New Global.Opc.Da.Item()
            items(33).ItemName = "КТП_РЭБ.С1.КАУ1.GENERAL_FAULT"

            items(34) = New Global.Opc.Da.Item()
            items(34).ItemName = "КТП_РЭБ.С1.КАУ1.IN_SW_CLOSE"

            items(35) = New Global.Opc.Da.Item()
            items(35).ItemName = "КТП_РЭБ.С1.КАУ1.AB_PROTECTOR_ON"

            items(36) = New Global.Opc.Da.Item()
            items(36).ItemName = "КТП_РЭБ.С1.КАУ1.AB_PROTECTOR_ON"

            ''''''''''''''''''''''''''''''''''''''''''''''

            items(37) = New Global.Opc.Da.Item()
            items(37).ItemName = "КТП_РЭБ.С2.КАУ2.AB_DISCHARGE"

            items(38) = New Global.Opc.Da.Item()
            items(38).ItemName = "КТП_РЭБ.С2.КАУ2.GENERAL_FAULT"

            items(39) = New Global.Opc.Da.Item()
            items(39).ItemName = "КТП_РЭБ.С2.КАУ2.IN_SW_CLOSE"

            items(40) = New Global.Opc.Da.Item()
            items(40).ItemName = "КТП_РЭБ.С2.КАУ2.AB_PROTECTOR_ON"

            items(41) = New Global.Opc.Da.Item()
            items(41).ItemName = "КТП_РЭБ.С2.КАУ2.AB_PROTECTOR_ON"

            items(42) = New Global.Opc.Da.Item()
            items(42).ItemName = "ОЩСУ.С1.QF14.VOLT_COLOR"

            items(43) = New Global.Opc.Da.Item()
            items(43).ItemName = "ОЩСУ.С2.QF64.VOLT_COLOR"

            items(44) = New Global.Opc.Da.Item()
            items(44).ItemName = "ЩГП_ЭБ.С1.QF1.VOLT_COLOR"

            items(45) = New Global.Opc.Da.Item()
            items(45).ItemName = "ЩГП_ЭБ.С1.QF3.VOLT_COLOR"

            items(46) = New Global.Opc.Da.Item()
            items(46).ItemName = "ЩГП_ЭБ.С1.VOLT_COLOR"

            items(47) = New Global.Opc.Da.Item()
            items(47).ItemName = "ЩПТ.С2.QF33.VOLT_COLOR"

            items(48) = New Global.Opc.Da.Item()
            items(48).ItemName = "ЩПТ.С1.QF22.VOLT_COLOR"

            items(49) = New Global.Opc.Da.Item()
            items(49).ItemName = "ЩГП_ЭБ.С2.VOLT_COLOR"

            '############################################################################
            items(50) = New Global.Opc.Da.Item()
            items(50).ItemName = "КТП_РЭБ.С1.QF12.VOLT_COLOR"

            items(51) = New Global.Opc.Da.Item()
            items(51).ItemName = "КТП_РЭБ.С2.QF27.VOLT_COLOR"

            items(52) = New Global.Opc.Da.Item()
            items(52).ItemName = "ЩГП_РЭБ.С1.QF1.VOLT_COLOR"

            items(53) = New Global.Opc.Da.Item()
            items(53).ItemName = "ЩГП_РЭБ.С1.QF3.VOLT_COLOR"

            items(54) = New Global.Opc.Da.Item()
            items(54).ItemName = "ЩГП_РЭБ.С1.VOLT_COLOR"

            items(55) = New Global.Opc.Da.Item()
            items(55).ItemName = "ЩГП_РЭБ.С2.VOLT_COLOR"

            items = group_CHGP.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_CHGP.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label1.Enabled = results(0).Value)
                    Me.Invoke(Sub() Label2.Enabled = results(1).Value)
                    Me.Invoke(Sub() Label3.Enabled = results(2).Value)
                    Me.Invoke(Sub() Label4.Enabled = results(3).Value)
                    Me.Invoke(Sub() Label5.Enabled = results(4).Value)

                    Select Case results(6).Value

                        Case False

                            Me.Invoke(Sub() lbl5.Visible = False)

                            Select Case results(5).Value

                                Case True
                                    Me.Invoke(Sub() Q5_vkl.Visible = True)
                                    Me.Invoke(Sub() Q5_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() Q5_vkl.Visible = False)
                                    Me.Invoke(Sub() Q5_vykl.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() Q5_vykl.Visible = False)
                            Me.Invoke(Sub() Q5_vkl.Visible = False)
                            Me.Invoke(Sub() lbl5.Visible = True)
                    End Select

                    Select Case results(8).Value

                        Case False

                            Me.Invoke(Sub() lblQF3.Visible = False)

                            Select Case results(7).Value

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

                    Select Case results(0).Value

                        Case True
                            Me.Invoke(Sub() Q1_vkl.Visible = True)
                            Me.Invoke(Sub() Q1_vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() Q1_vkl.Visible = False)
                            Me.Invoke(Sub() Q1_vykl.Visible = True)
                    End Select

                    Select Case results(1).Value

                        Case True
                            Me.Invoke(Sub() Q2_vkl.Visible = True)
                            Me.Invoke(Sub() Q2_vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() Q2_vkl.Visible = False)
                            Me.Invoke(Sub() Q2_vykl.Visible = True)
                    End Select

                    Select Case results(2).Value

                        Case True
                            Me.Invoke(Sub() Q4_vkl.Visible = True)
                            Me.Invoke(Sub() Q4_vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() Q4_vkl.Visible = False)
                            Me.Invoke(Sub() Q4_vykl.Visible = True)
                    End Select

                    Me.Invoke(Sub() Label6.Enabled = results(9).Value)
                    Me.Invoke(Sub() Label7.Enabled = results(10).Value)
                    Me.Invoke(Sub() Label8.Enabled = results(11).Value)
                    Me.Invoke(Sub() Label9.Enabled = results(12).Value)
                    Me.Invoke(Sub() Label10.Enabled = results(13).Value)

                    Select Case results(9).Value

                        Case True
                            Me.Invoke(Sub() Q6_vkl.Visible = True)
                            Me.Invoke(Sub() Q6_vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() Q6_vkl.Visible = False)
                            Me.Invoke(Sub() Q6_vykl.Visible = True)
                    End Select

                    Select Case results(10).Value

                        Case True
                            Me.Invoke(Sub() Q7_vkl.Visible = True)
                            Me.Invoke(Sub() Q7_vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() Q7_vkl.Visible = False)
                            Me.Invoke(Sub() Q7_vykl.Visible = True)
                    End Select

                    Select Case results(11).Value

                        Case True
                            Me.Invoke(Sub() Q9_vkl.Visible = True)
                            Me.Invoke(Sub() Q9_vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() Q9_vkl.Visible = False)
                            Me.Invoke(Sub() Q9_vykl.Visible = True)
                    End Select

                    Select Case results(15).Value

                        Case False

                            Me.Invoke(Sub() lblQF2.Visible = False)

                            Select Case results(14).Value

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

                    '################################################################################################
                    '№1
                    Me.Invoke(Sub() Label11.Enabled = results(16).Value)
                    Me.Invoke(Sub() Label12.Enabled = results(17).Value)
                    Me.Invoke(Sub() Label13.Enabled = results(18).Value)
                    Me.Invoke(Sub() Label14.Enabled = results(19).Value)
                    Me.Invoke(Sub() Label15.Enabled = results(20).Value)


                    Select Case results(16).Value

                        Case True
                            Me.Invoke(Sub() Q10_vkl.Visible = True)
                            Me.Invoke(Sub() Q10_vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() Q10_vkl.Visible = False)
                            Me.Invoke(Sub() Q10_vykl.Visible = True)
                    End Select

                    Select Case results(17).Value

                        Case True
                            Me.Invoke(Sub() Q11_vkl.Visible = True)
                            Me.Invoke(Sub() Q11_vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() Q11_vkl.Visible = False)
                            Me.Invoke(Sub() Q11_vykl.Visible = True)
                    End Select

                    Select Case results(18).Value

                        Case True
                            Me.Invoke(Sub() Q13_vkl.Visible = True)
                            Me.Invoke(Sub() Q13_vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() Q13_vkl.Visible = False)
                            Me.Invoke(Sub() Q13_vykl.Visible = True)
                    End Select

                    Select Case results(22).Value

                        Case False

                            Me.Invoke(Sub() lblQF1_.Visible = False)

                            Select Case results(21).Value

                                Case True
                                    Me.Invoke(Sub() QF1_vkl_.Visible = True)
                                    Me.Invoke(Sub() QF1_vykl_.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF1_vkl_.Visible = False)
                                    Me.Invoke(Sub() QF1_vykl_.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF1_vykl_.Visible = False)
                            Me.Invoke(Sub() QF1_vkl_.Visible = False)
                            Me.Invoke(Sub() lblQF1_.Visible = True)
                    End Select

                    Select Case results(24).Value

                        Case False

                            Me.Invoke(Sub() lblQF3_.Visible = False)

                            Select Case results(23).Value

                                Case True
                                    Me.Invoke(Sub() QF3_vkl_.Visible = True)
                                    Me.Invoke(Sub() QF3_vykl_.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF3_vkl_.Visible = False)
                                    Me.Invoke(Sub() QF3_vykl_.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF3_vykl_.Visible = False)
                            Me.Invoke(Sub() QF3_vkl_.Visible = False)
                            Me.Invoke(Sub() lblQF3_.Visible = True)
                    End Select
                    '################################################################################################
                    '№2
                    Me.Invoke(Sub() Label16.Enabled = results(25).Value)
                    Me.Invoke(Sub() Label17.Enabled = results(26).Value)
                    Me.Invoke(Sub() Label18.Enabled = results(27).Value)
                    Me.Invoke(Sub() Label19.Enabled = results(28).Value)
                    Me.Invoke(Sub() Label20.Enabled = results(29).Value)


                    Select Case results(25).Value

                        Case True
                            Me.Invoke(Sub() Q14_vkl.Visible = True)
                            Me.Invoke(Sub() Q14_vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() Q14_vkl.Visible = False)
                            Me.Invoke(Sub() Q14_vykl.Visible = True)
                    End Select

                    Select Case results(26).Value

                        Case True
                            Me.Invoke(Sub() Q15_vkl.Visible = True)
                            Me.Invoke(Sub() Q15_vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() Q15_vkl.Visible = False)
                            Me.Invoke(Sub() Q15_vykl.Visible = True)
                    End Select

                    Select Case results(27).Value

                        Case True
                            Me.Invoke(Sub() Q17_vkl.Visible = True)
                            Me.Invoke(Sub() Q17_vykl.Visible = False)
                        Case False
                            Me.Invoke(Sub() Q17_vkl.Visible = False)
                            Me.Invoke(Sub() Q17_vykl.Visible = True)
                    End Select

                    Select Case results(31).Value

                        Case False

                            Me.Invoke(Sub() lblQF2_.Visible = False)

                            Select Case results(30).Value

                                Case True
                                    Me.Invoke(Sub() QF2_vkl_.Visible = True)
                                    Me.Invoke(Sub() QF2_vykl_.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF2_vkl_.Visible = False)
                                    Me.Invoke(Sub() QF2_vykl_.Visible = True)
                            End Select

                        Case True

                            Me.Invoke(Sub() QF2_vykl_.Visible = False)
                            Me.Invoke(Sub() QF2_vkl_.Visible = False)
                            Me.Invoke(Sub() lblQF2_.Visible = True)
                    End Select

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    Me.Invoke(Sub() Label21.Enabled = results(32).Value)
                    Me.Invoke(Sub() Label22.Enabled = results(33).Value)
                    Me.Invoke(Sub() Label23.Enabled = results(34).Value)
                    Me.Invoke(Sub() Label24.Enabled = results(35).Value)
                    Me.Invoke(Sub() Label25.Enabled = results(36).Value)


                    Me.Invoke(Sub() Label26.Enabled = results(37).Value)
                    Me.Invoke(Sub() Label27.Enabled = results(38).Value)
                    Me.Invoke(Sub() Label28.Enabled = results(39).Value)
                    Me.Invoke(Sub() Label29.Enabled = results(40).Value)
                    Me.Invoke(Sub() Label30.Enabled = results(41).Value)

                    Me.Invoke(Sub() LineColor(results(42).Value, L1_1))
                    Me.Invoke(Sub() L1_2.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_3.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_4.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_5.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_6.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L2_5.BorderColor = L1_1.BorderColor)


                    Me.Invoke(Sub() LineColor(results(44).Value, L3_1))
                    Me.Invoke(Sub() L3_2.BorderColor = L3_1.BorderColor)
                    Me.Invoke(Sub() L3_3.BorderColor = L3_1.BorderColor)
                    Me.Invoke(Sub() L3_4.BorderColor = L3_1.BorderColor)


                    Me.Invoke(Sub() LineColor(results(43).Value, LI2_1))
                    Me.Invoke(Sub() LI2_2.BorderColor = LI2_1.BorderColor)
                    Me.Invoke(Sub() LI2_3.BorderColor = LI2_1.BorderColor)
                    Me.Invoke(Sub() LI2_4.BorderColor = LI2_1.BorderColor)
                    Me.Invoke(Sub() LI2_6.BorderColor = LI2_1.BorderColor)
                    Me.Invoke(Sub() LI2_7.BorderColor = LI2_1.BorderColor)
                    Me.Invoke(Sub() LineShape9.BorderColor = LI2_1.BorderColor)
                    'LineShape9

                    Me.Invoke(Sub() LineColor(results(45).Value, L4_1))
                    Me.Invoke(Sub() L4_2.BorderColor = L4_1.BorderColor)
                    Me.Invoke(Sub() L4_3.BorderColor = L4_1.BorderColor)
                    Me.Invoke(Sub() L4_4.BorderColor = L4_1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(48).Value, L2_1))

                    Me.Invoke(Sub() LineColor(results(46).Value, L2_2))
                    Me.Invoke(Sub() L2_3.BorderColor = L2_2.BorderColor)
                    Me.Invoke(Sub() L2_4.BorderColor = L2_2.BorderColor)

                    Me.Invoke(Sub() LineColor(results(47).Value, LineShape6))

                    Me.Invoke(Sub() LineColor(results(49).Value, LineShape7))
                    Me.Invoke(Sub() LineShape10.BorderColor = LineShape7.BorderColor)
                    Me.Invoke(Sub() LineShape11.BorderColor = LineShape7.BorderColor)

                    Me.Invoke(Sub() LineColor(results(50).Value, LineShape24))
                    Me.Invoke(Sub() LineShape31.BorderColor = LineShape24.BorderColor)
                    Me.Invoke(Sub() LineShape32.BorderColor = LineShape24.BorderColor)
                    Me.Invoke(Sub() LineShape29.BorderColor = LineShape24.BorderColor)
                    Me.Invoke(Sub() LineShape28.BorderColor = LineShape24.BorderColor)
                    Me.Invoke(Sub() LineShape27.BorderColor = LineShape24.BorderColor)

                    Me.Invoke(Sub() LineColor(results(54).Value, LineShape23))
                    Me.Invoke(Sub() LineShape25.BorderColor = LineShape23.BorderColor)
                    Me.Invoke(Sub() LineShape26.BorderColor = LineShape23.BorderColor)
                    Me.Invoke(Sub() LineShape22.BorderColor = LineShape23.BorderColor)


                    Me.Invoke(Sub() LineColor(results(51).Value, LineShape2))
                    Me.Invoke(Sub() LineShape12.BorderColor = LineShape2.BorderColor)
                    Me.Invoke(Sub() LineShape34.BorderColor = LineShape2.BorderColor)
                    Me.Invoke(Sub() LineShape35.BorderColor = LineShape2.BorderColor)
                    Me.Invoke(Sub() LineShape3.BorderColor = LineShape2.BorderColor)
                    Me.Invoke(Sub() LineShape4.BorderColor = LineShape2.BorderColor)

                    Me.Invoke(Sub() LineColor(results(55).Value, LineShape5))
                    Me.Invoke(Sub() LineShape8.BorderColor = LineShape5.BorderColor)
                    Me.Invoke(Sub() LineShape13.BorderColor = LineShape5.BorderColor)
                    Me.Invoke(Sub() LineShape14.BorderColor = LineShape5.BorderColor)

                    Me.Invoke(Sub() LineColor(results(52).Value, LineShape21))
                    Me.Invoke(Sub() LineShape20.BorderColor = LineShape21.BorderColor)
                    Me.Invoke(Sub() LineShape19.BorderColor = LineShape21.BorderColor)
                    Me.Invoke(Sub() LineShape18.BorderColor = LineShape21.BorderColor)

                    Me.Invoke(Sub() LineColor(results(53).Value, LineShape1))
                    Me.Invoke(Sub() LineShape15.BorderColor = LineShape1.BorderColor)
                    Me.Invoke(Sub() LineShape16.BorderColor = LineShape1.BorderColor)
                    Me.Invoke(Sub() LineShape17.BorderColor = LineShape1.BorderColor)



                Next


                Threading.Thread.Sleep(MSPEED + 450)
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
        frmOHCU.MdiParent = frmIndexer
        frmOHCU.Show()
        frmOHCU.Focus()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        frmChpt.MdiParent = frmIndexer
        frmChpt.Show()
        frmChpt.Focus()
    End Sub
End Class