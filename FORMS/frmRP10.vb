Public Class frmRP10
    Dim T_RP10 As System.Threading.Thread

    Private Sub btnRp10V1_Click(sender As System.Object, e As System.EventArgs)

        Select Case btnRp10V1.Text

            Case "Старт"

                btnRp10V1.Text = "Стоп"
                T_RP10 = New System.Threading.Thread(AddressOf T_RP10_START)
                T_RP10.Start()

            Case "Стоп"

                btnRp10V1.Text = "Старт"
                m_server.CancelSubscription(groupRP10)
                T_RP10.Abort()

        End Select


    End Sub

    Sub T_RP10_START()

        Try

ARG:
        groupStateRP10.Name = "RP10"
        groupStateRP10.Active = True
            groupStateRP10.UpdateRate = MSPEED

        groupRP10 = DirectCast(m_server.CreateSubscription(groupStateRP10), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(35) {}

            '##########################################################
            'ГПА №1


            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С1.1_ВВОД.CLOSE"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С2.10_ВВОД.CLOSE"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С2.11_ШТН.AVR_ON"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С1.1_ВВОД.EARTH_SWITCH"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С2.10_ВВОД.EARTH_SWITCH"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С1.1_ВВОД.P"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С1.1_ВВОД.Q"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С1.1_ВВОД.I1"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С1.1_ВВОД.U_12"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С1.1_ВВОД.FREQ"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С1.1_ВВОД.EN_SW_CHANGE_ALA"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С1.9_СВ.CLOSE"

            'Тележка вкачена\выкачена
            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "РП10.С1.1_ВВОД.DI"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "РП10.С1.9_СВ.DI"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С2.10_ВВОД.DI"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С2.18_СР.DI"


            '############################################################
            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С2.10_ВВОД.P"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С2.10_ВВОД.Q"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С2.10_ВВОД.I1"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.С2.10_ВВОД.U_12"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.С2.10_ВВОД.FREQ"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РП10.С2.10_ВВОД.EN_SW_CHANGE_ALA"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РП10.С2.18_СР.DI"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "РП10.С1.9_СВ.EARTH_SWITCH"
            'РП10.С1.9_СВ.EARTH_SWITCH

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С1.1_ВВОД.I1"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С1.1_ВВОД.I2"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С1.1_ВВОД.I3"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С1.1_ВВОД.TRIP"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С2.10_ВВОД.TRIP"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С1.1_ВВОД.TS_1"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С2.10_ВВОД.TS_1"

            items(31) = New Global.Opc.Da.Item()
            items(31).ItemName = "РП10.С2.18_СР.VOLT_COLOR"

            items(32) = New Global.Opc.Da.Item()
            items(32).ItemName = "РП10.С2.10_ВВОД.VOLT_COLOR"

            items(33) = New Global.Opc.Da.Item()
            items(33).ItemName = "РП10.С1.1_ВВОД.VOLT_COLOR"

            items(34) = New Global.Opc.Da.Item()
            items(34).ItemName = "РП10.С1.1_ВВОД.VOLT_COLOR_TN"

            items(35) = New Global.Opc.Da.Item()
            items(35).ItemName = "РП10.С2.10_ВВОД.VOLT_COLOR_TN"


            'РП10.С1.1_ВВОД.VOLT_COLOR_TN


        items = groupRP10.AddItems(items)

        Do

            Dim results As ItemValueResult() = Nothing
            results = groupRP10.Read(items)
            For Each item As Item In items
                item.ClientHandle = item.ItemName
            Next

            results = m_server.Read(items)

            For i As Integer = 0 To results.Length - 1

                    Select Case results(20).Value

                        Case False
                            Me.Invoke(Sub() VVOD1.Visible = False)
                            ' Me.Invoke(Sub() VVOD1_VKL.Visible = False)
                            ' Me.Invoke(Sub() VVOD1_VyKL.Visible = False)
                            Me.Invoke(Sub() VVOD1_TV.Visible = True)
                        Case True
                            Me.Invoke(Sub() VVOD1_TV.Visible = False)

                            Select Case results(0).Value

                                Case True
                                    ' VVOD1_VKL
                                    Me.Invoke(Sub() VVOD1.Image = My.Resources.VKL_NEW_2)

                                    ' Me.Invoke(Sub() VVOD1_VKL.Visible = True)
                                    ' Me.Invoke(Sub() VVOD1_VyKL.Visible = False)
                                    '  Me.Invoke(Sub() VVOD1_TV.Visible = False)
                                    'VVOD1_TV
                                Case False
                                    ' Me.Invoke(Sub() VVOD1_VKL.Visible = False)
                                    ' Me.Invoke(Sub() VVOD1_VyKL.Visible = True)
                                    '  Me.Invoke(Sub() VVOD1_TV.Visible = False)

                                    Me.Invoke(Sub() VVOD1.Image = My.Resources.VKL_NEW_1)
                            End Select

                    End Select


                Select Case results(22).Value

                        Case False

                            Me.Invoke(Sub() VVOD2.Visible = False)
                            ' Me.Invoke(Sub() VVOD2_VKL.Visible = False)
                            ' Me.Invoke(Sub() VVOD2_VyKL.Visible = False)
                            Me.Invoke(Sub() VVOD2_TV.Visible = True)
                        Case True

                            Me.Invoke(Sub() VVOD2_TV.Visible = False)

                            Select Case results(1).Value

                                Case True

                                    Me.Invoke(Sub() VVOD2.Image = My.Resources.VKL_NEW_2)

                                    ' Me.Invoke(Sub() VVOD2_VKL.Visible = True)
                                    ' Me.Invoke(Sub() VVOD2_VyKL.Visible = False)
                                Case False
                                    '  Me.Invoke(Sub() VVOD2_VKL.Visible = False)
                                    ' Me.Invoke(Sub() VVOD2_VyKL.Visible = True)

                                    Me.Invoke(Sub() VVOD2.Image = My.Resources.VKL_NEW_1)
                            End Select

                    End Select



                Select Case results(2).Value

                    Case True
                        Me.Invoke(Sub() lblAVR_vkl.Enabled = True)
                        Me.Invoke(Sub() lblAVR_vykl.Enabled = False)
                    Case False
                        Me.Invoke(Sub() lblAVR_vkl.Enabled = False)
                        Me.Invoke(Sub() lblAVR_vykl.Enabled = True)
                End Select


                Select Case results(3).Value

                    Case True

                            Me.Invoke(Sub() VVOD1_Earth.Image = My.Resources.OnState)

                    Case False
                            Me.Invoke(Sub() VVOD1_Earth.Image = My.Resources.OffState)
                End Select

                Select Case results(4).Value

                    Case True

                            Me.Invoke(Sub() VVOD2_Earth.Image = My.Resources.OnState)

                    Case False

                            Me.Invoke(Sub() VVOD2_Earth.Image = My.Resources.OffState)
                End Select

                'lblVV1_P

                Dim MGg As Double = results(5).Value
                Me.Invoke(Sub() lblVV1_P.Text = Math.Round(MGg, 1) & " кВт")

                MGg = results(6).Value
                Me.Invoke(Sub() lblVV1_Q.Text = Math.Round(MGg, 1) & " кВар")

                MGg = results(7).Value
                Me.Invoke(Sub() lblVV1_I.Text = Math.Round(MGg, 1) & " A")

                MGg = results(8).Value
                Me.Invoke(Sub() lblVV1_U.Text = Math.Round(MGg, 1) & " Кв")

                    ' Me.Invoke(Sub() lblVV1_U_.Text = lblVV1_U.Text)

                MGg = results(9).Value
                Me.Invoke(Sub() lblVV1_F_.Text = Math.Round(MGg, 1) & " Гц")

                'lblVV1_ES

                Select Case results(10).Value

                    Case True
                        Me.Invoke(Sub() lblVV1_ES.Enabled = True)
                    Case False
                        Me.Invoke(Sub() lblVV1_ES.Enabled = False)

                End Select

                Select Case results(11).Value

                    Case True
                            Me.Invoke(Sub() VVOD1_SHTN.Image = My.Resources.VKL_NEW_2)

                            ' Me.Invoke(Sub() VVOD1_SHTN_VKL.Visible = True)
                            ' Me.Invoke(Sub() VVOD1_SHTN_VyKL.Visible = False)
                        Case False
                            ' Me.Invoke(Sub() VVOD1_SHTN.Image = My.Resources.VKL_NEW_1)
                            ' Me.Invoke(Sub() VVOD1_SHTN_VKL.Visible = False)
                            ' Me.Invoke(Sub() VVOD1_SHTN_VyKL.Visible = True)

                            Select Case results(21).Value

                                Case False
                                    Me.Invoke(Sub() VVOD1_SHTN.Visible = False)
                                    ' Me.Invoke(Sub() VVOD1_SHTN_VKL.Visible = False)
                                    'Me.Invoke(Sub() VVOD1_SHTN_VyKL.Visible = False)
                                    Me.Invoke(Sub() VVOD1_SHTN_TV.Visible = True)

                                Case True
                                    Me.Invoke(Sub() VVOD1_SHTN_TV.Visible = False)
                                    Me.Invoke(Sub() VVOD1_SHTN.Visible = True)

                            End Select


                    End Select


                   



                MGg = results(12).Value
                Me.Invoke(Sub() lblVV2_P.Text = Math.Round(MGg, 1) & " кВт")

                MGg = results(13).Value
                Me.Invoke(Sub() lblVV2_Q.Text = Math.Round(MGg, 1) & " кВар")

                MGg = results(14).Value
                Me.Invoke(Sub() lblVV2_I.Text = Math.Round(MGg, 1) & " A")

                MGg = results(15).Value
                Me.Invoke(Sub() lblVV2_U.Text = Math.Round(MGg, 1) & " Кв")

                Me.Invoke(Sub() lblVV2_U_.Text = lblVV2_U.Text)

                MGg = results(16).Value
                Me.Invoke(Sub() lblVV2_F_.Text = Math.Round(MGg, 1) & " Гц")

                'lblVV1_ES

                Select Case results(17).Value

                    Case True
                        Me.Invoke(Sub() lblVV2_ES.Enabled = True)
                    Case False
                        Me.Invoke(Sub() lblVV2_ES.Enabled = False)

                End Select


                Select Case results(18).Value

                    Case True

                            Me.Invoke(Sub() VVOD2_SHTN.Image = My.Resources.VKL_NEW_2)


                            ' Me.Invoke(Sub() VVOD2_SHTN_VKL.Visible = True)
                            '  Me.Invoke(Sub() VVOD2_SHTN_VyKL.Visible = False)
                            Me.Invoke(Sub() VVOD2_SHTN_TV.Visible = False)

                        Case False

                            Me.Invoke(Sub() VVOD2_SHTN.Image = My.Resources.VKL_NEW_1)
                            ' Me.Invoke(Sub() VVOD2_SHTN_VKL.Visible = False)
                            ' Me.Invoke(Sub() VVOD2_SHTN_VyKL.Visible = False)
                            Me.Invoke(Sub() VVOD2_SHTN_TV.Visible = True)

                    End Select

                Select Case results(23).Value

                    Case False
                            ' Me.Invoke(Sub() VVOD2_SHTN_VKL.Visible = False)
                            ' Me.Invoke(Sub() VVOD2_SHTN_VyKL.Visible = False)

                            Me.Invoke(Sub() VVOD2_SHTN.Visible = False)

                        Me.Invoke(Sub() VVOD2_SHTN_TV.Visible = True)
                    Case True
                        Me.Invoke(Sub() VVOD2_SHTN_TV.Visible = False)
                End Select


                'Качество сигнала (Quality)
                Select Case results(19).Quality.ToString

                        Case "good"
                            Me.Invoke(Sub() lblSW_EA.Visible = False)

                            Select Case results(19).Value

                                Case True
                                    Me.Invoke(Sub() VVOD1_SV_EA.Image = My.Resources.OnState)
                                    ' Me.Invoke(Sub() VVOD1_SV_EA_VKL.Visible = True)
                                    ' Me.Invoke(Sub() VVOD1_SV_EA_VYKL.Visible = False)
                                Case False
                                    Me.Invoke(Sub() VVOD1_SV_EA.Image = My.Resources.OffState)
                                    ' Me.Invoke(Sub() VVOD1_SV_EA_VKL.Visible = False)
                                    'Me.Invoke(Sub() VVOD1_SV_EA_VYKL.Visible = True)

                            End Select

                        Case Else
                            Me.Invoke(Sub() VVOD1_SV_EA.Visible = False)
                            'Me.Invoke(Sub() VVOD1_SV_EA_VYKL.Visible = False)
                            Me.Invoke(Sub() lblSW_EA.Visible = True)
                    End Select

                    MGg = results(24).Value
                    Me.Invoke(Sub() lbll1.Text = Math.Round(MGg, 1) & " A")

                    MGg = results(25).Value
                    Me.Invoke(Sub() lbll2.Text = Math.Round(MGg, 1) & " A")

                    MGg = results(26).Value
                    Me.Invoke(Sub() lbll3.Text = Math.Round(MGg, 1) & " A")



                    '################################################
                    'Сигнализация

                    Select Case results(27).Value
                        Case True
                            Beep()
                        Case False
                    End Select

                    Select Case results(28).Value
                        Case True
                            Beep()
                        Case False
                    End Select

                    lblTRIP_V1.Visible = results(27).Value
                    lblTRIP_V2.Visible = results(28).Value

                    Select Case results(29).Value
                        Case True
                            Beep()
                        Case False
                    End Select

                    Select Case results(30).Value
                        Case True
                            Beep()
                        Case False
                    End Select

                    lblTS_1_V1.Visible = results(29).Value
                    lblTS_1_V2.Visible = results(30).Value


                    Select Case results(31).Value

                        Case "0"

                            Me.Invoke(Sub() L1.BorderColor = Color.Black)

                        Case "1"

                            Me.Invoke(Sub() L1.BorderColor = Color.Gray)

                        Case "4"

                            Me.Invoke(Sub() L1.BorderColor = Color.Blue)

                        Case "8"

                            Me.Invoke(Sub() L1.BorderColor = Color.DeepSkyBlue)

                        Case "40"

                            Me.Invoke(Sub() L1.BorderColor = Color.Yellow)

                    End Select

                    Me.Invoke(Sub() L2.BorderColor = L1.BorderColor)
                    Me.Invoke(Sub() L3.BorderColor = L1.BorderColor)
                    Me.Invoke(Sub() L4.BorderColor = L1.BorderColor)
                    Me.Invoke(Sub() L5.BorderColor = L1.BorderColor)



                    Select Case results(32).Value

                        Case "0"

                            Me.Invoke(Sub() L6.BorderColor = Color.Black)

                        Case "1"

                            Me.Invoke(Sub() L6.BorderColor = Color.Gray)

                        Case "4"

                            Me.Invoke(Sub() L6.BorderColor = Color.Blue)

                        Case "8"

                            Me.Invoke(Sub() L6.BorderColor = Color.DeepSkyBlue)

                        Case "40"

                            Me.Invoke(Sub() L6.BorderColor = Color.Yellow)

                    End Select

                    Me.Invoke(Sub() L7.BorderColor = L6.BorderColor)
                    Me.Invoke(Sub() L8.BorderColor = L6.BorderColor)


                    Select Case results(33).Quality.ToString

                        Case "good"

                            Select Case results(33).Value

                                Case "0"

                                    Me.Invoke(Sub() L9.BorderColor = Color.Black)

                                Case "1"

                                    Me.Invoke(Sub() L9.BorderColor = Color.Gray)

                                Case "4"

                                    Me.Invoke(Sub() L9.BorderColor = Color.Blue)

                                Case "8"

                                    Me.Invoke(Sub() L9.BorderColor = Color.DeepSkyBlue)

                                Case "40"

                                    Me.Invoke(Sub() L9.BorderColor = Color.Yellow)

                            End Select


                        Case Else

                            Me.Invoke(Sub() L9.BorderColor = Color.Pink)

                    End Select

                    

                    Me.Invoke(Sub() L10.BorderColor = L9.BorderColor)
                    Me.Invoke(Sub() L11.BorderColor = L9.BorderColor)
                   


                    Me.Invoke(Sub() LineColor(results(34).Value, LineShape1))
                    Me.Invoke(Sub() LineShape2.BorderColor = LineShape1.BorderColor)
                    Me.Invoke(Sub() LineShape3.BorderColor = LineShape1.BorderColor)
                    Me.Invoke(Sub() LineShape4.BorderColor = LineShape1.BorderColor)
                    Me.Invoke(Sub() LineShape5.BorderColor = LineShape1.BorderColor)
                    Me.Invoke(Sub() LineShape6.BorderColor = LineShape1.BorderColor)
                    Me.Invoke(Sub() LineShape7.BorderColor = LineShape1.BorderColor)
                    Me.Invoke(Sub() LineShape8.BorderColor = LineShape1.BorderColor)
                    Me.Invoke(Sub() LineShape9.BorderColor = LineShape1.BorderColor)
                    Me.Invoke(Sub() RectangleShape1.BorderColor = LineShape1.BorderColor)
                    Me.Invoke(Sub() OvalShape1.BorderColor = LineShape1.BorderColor)
                    Me.Invoke(Sub() OvalShape2.BorderColor = LineShape1.BorderColor)
                    Me.Invoke(Sub() OvalShape3.BorderColor = LineShape1.BorderColor)


                    Me.Invoke(Sub() LineColor(results(35).Value, LineShape18))
                    Me.Invoke(Sub() LineShape17.BorderColor = LineShape18.BorderColor)
                    Me.Invoke(Sub() LineShape16.BorderColor = LineShape18.BorderColor)
                    Me.Invoke(Sub() LineShape15.BorderColor = LineShape18.BorderColor)
                    Me.Invoke(Sub() LineShape14.BorderColor = LineShape18.BorderColor)
                    Me.Invoke(Sub() LineShape13.BorderColor = LineShape18.BorderColor)
                    Me.Invoke(Sub() LineShape11.BorderColor = LineShape18.BorderColor)
                    Me.Invoke(Sub() LineShape12.BorderColor = LineShape18.BorderColor)
                    Me.Invoke(Sub() LineShape10.BorderColor = LineShape18.BorderColor)
                    Me.Invoke(Sub() RectangleShape2.BorderColor = LineShape18.BorderColor)
                    Me.Invoke(Sub() OvalShape4.BorderColor = LineShape18.BorderColor)
                    Me.Invoke(Sub() OvalShape5.BorderColor = LineShape18.BorderColor)
                    Me.Invoke(Sub() OvalShape6.BorderColor = LineShape18.BorderColor)





            Next

                Threading.Thread.Sleep(MSPEED)
        Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Private Sub frmRP10_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        m_server.CancelSubscription(groupRP10)
        T_RP10.Abort()
    End Sub

    Private Sub frmRP10_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Select Case btnRp10V1.Text

            Case "Старт"

                btnRp10V1.Text = "Стоп"
                T_RP10 = New System.Threading.Thread(AddressOf T_RP10_START)
                T_RP10.Start()

            Case "Стоп"

                btnRp10V1.Text = "Старт"
                m_server.CancelSubscription(groupRP10)
                T_RP10.Abort()

        End Select

    End Sub

    Private Sub btnRP10S1_Click(sender As System.Object, e As System.EventArgs) Handles btnRP10S1.Click
        frmRP10S1.MdiParent = frmIndexer
        frmRP10S1.Show()
        frmRP10S1.Focus()
    End Sub

    Private Sub btnRP10S2_Click(sender As System.Object, e As System.EventArgs) Handles btnRP10S2.Click
        frmRP10S2.MdiParent = frmIndexer
        frmRP10S2.Show()
        frmRP10S2.Focus()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frmKTP_AVO.MdiParent = frmIndexer
        frmKTP_AVO.Show()
        frmKTP_AVO.Focus()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        frmKTP_EB.MdiParent = frmIndexer
        frmKTP_EB.Show()
        frmKTP_EB.Focus()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        frmOHCU.MdiParent = frmIndexer
        frmOHCU.Show()
        frmOHCU.Focus()

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        frm_CHGP.MdiParent = frmIndexer
        frm_CHGP.Show()
        frm_CHGP.Focus()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        frmChpt.MdiParent = frmIndexer
        frmChpt.Show()
        frmChpt.Focus()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        frmKTP_REB.MdiParent = frmIndexer
        frmKTP_REB.Show()
        frmKTP_REB.Focus()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        frm2BTP.MdiParent = frmIndexer
        frm2BTP.Show()
        frm2BTP.Focus()
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        frmSAUT.MdiParent = frmIndexer
        frmSAUT.Show()
        frmSAUT.Focus()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        frmSauV.MdiParent = frmIndexer
        frmSauV.Show()
        frmSauV.Focus()
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        frmSAUKOS.MdiParent = frmIndexer
        frmSAUKOS.Show()
        frmSAUKOS.Focus()
    End Sub

    Private Sub VVOD1_Click(sender As System.Object, e As System.EventArgs) Handles VVOD1.Click, VVOD1_TV.Click
        'frmUSTAVKI

        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ ВВОД 1"
        frmUSTAVKI.Show()

    End Sub

    Private Sub VVOD2_Click(sender As System.Object, e As System.EventArgs) Handles VVOD2.Click, VVOD2_TV.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ ВВОД 2"
        frmUSTAVKI.Show()
    End Sub

    Private Sub VVOD1_SHTN_Click(sender As System.Object, e As System.EventArgs) Handles VVOD1_SHTN.Click, VVOD1_SHTN_TV.Click
        Dim frmUSTAVKI As frmUSTAVKI = New frmUSTAVKI
        frmUSTAVKI.Text = "Измерения РП 10кВ СВ"
        frmUSTAVKI.Show()

    End Sub
End Class