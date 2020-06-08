Public Class frm2BTP
    Dim T_2BTP As System.Threading.Thread

    Private Sub frm2BTP_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed


        m_server.CancelSubscription(group_2BTP)
        T_2BTP.Abort()

    End Sub

    Private Sub frm2BTP_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Select Case btn2BTP.Text

            Case "Старт"

                btn2BTP.Text = "Стоп"
                T_2BTP = New System.Threading.Thread(AddressOf T_2BTP_START)
                T_2BTP.Start()

            Case "Стоп"

                btn2BTP.Text = "Старт"
                m_server.CancelSubscription(group_2BTP)
                T_2BTP.Abort()

        End Select

    End Sub


    Private Sub btn2BTP_Click(sender As System.Object, e As System.EventArgs) Handles btn2BTP.Click

        Select Case btn2BTP.Text

            Case "Старт"

                btn2BTP.Text = "Стоп"
                T_2BTP = New System.Threading.Thread(AddressOf T_2BTP_START)
                T_2BTP.Start()

            Case "Стоп"

                btn2BTP.Text = "Старт"
                m_server.CancelSubscription(group_2BTP)
                T_2BTP.Abort()

        End Select

    End Sub

    Sub T_2BTP_START()

        Try
ARG:
            groupState_2BTP.Name = "2BTP"
            groupState_2BTP.Active = True
            groupState_2BTP.UpdateRate = MSPEED

            group_2BTP = DirectCast(m_server.CreateSubscription(groupState_2BTP), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(39) {}

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "2БТП._.В3.Uao"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "2БТП._.В3.Ubo"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "2БТП._.В3.Uco"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "2БТП._.В3.Ia"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "2БТП._.В3.Ib"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "2БТП._.В3.Ic"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "2БТП._.В3.CLOSE"


            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "2БТП._.В3.ZMN_BLOCK"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "2БТП._.В3.APV_BLOCK"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "2БТП._.В3.UROV_RUN"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "2БТП._.В3.APV_SRAB"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "2БТП._.В3.MAN_CTRL"


            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "2БТП._.В3.FAIL"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "2БТП._.В3.EARTH"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "2БТП._.В3.SUPPL_FAIL"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "2БТП._.В3.FASE_BREAK"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "2БТП._.В3.DZ_SRAB"

            '#############################################
            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "2БТП._.В4.Uao"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "2БТП._.В4.Ubo"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "2БТП._.В4.Uco"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "2БТП._.В4.Ia"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "2БТП._.В4.Ib"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "2БТП._.В4.Ic"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "2БТП._.В4.CLOSE"


            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "2БТП._.В4.ZMN_BLOCK"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "2БТП._.В4.APV_BLOCK"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "2БТП._.В4.UROV_RUN"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "2БТП._.В4.APV_SRAB"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "2БТП._.В4.MAN_CTRL"


            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "2БТП._.В4.FAIL"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "2БТП._.В4.EARTH"

            items(31) = New Global.Opc.Da.Item()
            items(31).ItemName = "2БТП._.В4.SUPPL_FAIL"

            items(32) = New Global.Opc.Da.Item()
            items(32).ItemName = "2БТП._.В4.FASE_BREAK"

            items(33) = New Global.Opc.Da.Item()
            items(33).ItemName = "2БТП._.В4.DZ_SRAB"

            '##########################################

            items(34) = New Global.Opc.Da.Item()
            items(34).ItemName = "2БТП._.В4.VOLT_COLOR"

            items(35) = New Global.Opc.Da.Item()
            items(35).ItemName = "КТП_АВО.С2.VOLT_COLOR"

            items(36) = New Global.Opc.Da.Item()
            items(36).ItemName = "2БТП._.B4Line.VOLT_COLOR"


            items(37) = New Global.Opc.Da.Item()
            items(37).ItemName = "2БТП._.В3.VOLT_COLOR"

            items(38) = New Global.Opc.Da.Item()
            items(38).ItemName = "КТП_АВО.С1.VOLT_COLOR"

            items(39) = New Global.Opc.Da.Item()
            items(39).ItemName = "2БТП._.B3Line.VOLT_COLOR"



            '2БТП._.В4.VOLT_COLOR

            items = group_2BTP.AddItems(items)

            'Dim MGg As Double

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_2BTP.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    If results(0).Quality.ToString <> "good" Then Me.Invoke(Sub() Label26.BackColor = Color.Pink) Else Me.Invoke(Sub() Label26.BackColor = Color.Transparent)
                    Me.Invoke(Sub() Label26.Text = Math.Round(results(0).Value, 1) & " кB")

                    If results(1).Quality.ToString <> "good" Then Me.Invoke(Sub() Label25.BackColor = Color.Pink) Else Me.Invoke(Sub() Label25.BackColor = Color.Transparent)
                    Me.Invoke(Sub() Label25.Text = Math.Round(results(1).Value, 1) & " кB")

                    If results(2).Quality.ToString <> "good" Then Me.Invoke(Sub() Label23.BackColor = Color.Pink) Else Me.Invoke(Sub() Label23.BackColor = Color.Transparent)
                    Me.Invoke(Sub() Label23.Text = Math.Round(results(2).Value, 1) & " кB")

                    If results(3).Quality.ToString <> "good" Then Me.Invoke(Sub() Label24.BackColor = Color.Pink) Else Me.Invoke(Sub() Label24.BackColor = Color.Transparent)
                    Me.Invoke(Sub() Label24.Text = Math.Round(results(3).Value, 1) & " А")

                    If results(4).Quality.ToString <> "good" Then Me.Invoke(Sub() Label22.BackColor = Color.Pink) Else Me.Invoke(Sub() Label22.BackColor = Color.Transparent)
                    Me.Invoke(Sub() Label22.Text = Math.Round(results(4).Value, 1) & " А")

                    If results(5).Quality.ToString <> "good" Then Me.Invoke(Sub() Label21.BackColor = Color.Pink) Else Me.Invoke(Sub() Label21.BackColor = Color.Transparent)
                    Me.Invoke(Sub() Label21.Text = Math.Round(results(5).Value, 1) & " А")



                    If results(7).Quality.ToString <> "good" Then Me.Invoke(Sub() l1.BackColor = Color.Pink) Else Me.Invoke(Sub() l1.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l1.Enabled = results(7).Value)

                    If results(8).Quality.ToString <> "good" Then Me.Invoke(Sub() l2.BackColor = Color.Pink) Else Me.Invoke(Sub() l2.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l2.Enabled = results(8).Value)

                    If results(9).Quality.ToString <> "good" Then Me.Invoke(Sub() l3.BackColor = Color.Pink) Else Me.Invoke(Sub() l3.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l3.Enabled = results(9).Value)

                    If results(10).Quality.ToString <> "good" Then Me.Invoke(Sub() l4.BackColor = Color.Pink) Else Me.Invoke(Sub() l4.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l4.Enabled = results(10).Value)

                    If results(11).Quality.ToString <> "good" Then Me.Invoke(Sub() l5.BackColor = Color.Pink) Else Me.Invoke(Sub() l5.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l5.Enabled = results(11).Value)

                    If results(12).Quality.ToString <> "good" Then Me.Invoke(Sub() l6.BackColor = Color.Pink) Else Me.Invoke(Sub() l6.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l6.Enabled = results(12).Value)

                    If results(13).Quality.ToString <> "good" Then Me.Invoke(Sub() l7.BackColor = Color.Pink) Else Me.Invoke(Sub() l7.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l7.Enabled = results(13).Value)

                    If results(14).Quality.ToString <> "good" Then Me.Invoke(Sub() l8.BackColor = Color.Pink) Else Me.Invoke(Sub() l8.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l8.Enabled = results(14).Value)

                    If results(15).Quality.ToString <> "good" Then Me.Invoke(Sub() l9.BackColor = Color.Pink) Else Me.Invoke(Sub() l9.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l9.Enabled = results(15).Value)

                    If results(16).Quality.ToString <> "good" Then Me.Invoke(Sub() l10.BackColor = Color.Pink) Else Me.Invoke(Sub() l10.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l10.Enabled = results(16).Value)


                    Select Case results(6).Quality.ToString

                        Case "good"

                            Select Case results(6).Value

                                Case True
                                    Me.Invoke(Sub() VV1_VyKL.Visible = False)
                                    Me.Invoke(Sub() VV1_VKL.Visible = True)

                                Case False

                                    Me.Invoke(Sub() VV1_VyKL.Visible = True)
                                    Me.Invoke(Sub() VV1_VKL.Visible = False)
                            End Select

                            Me.Invoke(Sub() lblVV1.Visible = False)

                        Case Else

                            Me.Invoke(Sub() VV1_VyKL.Visible = False)
                            Me.Invoke(Sub() VV1_VKL.Visible = False)

                            Me.Invoke(Sub() lblVV1.Visible = True)

                    End Select

                    '#################################################################################

                    If results(17).Quality.ToString <> "good" Then Me.Invoke(Sub() Label27.BackColor = Color.Pink) Else Me.Invoke(Sub() Label27.BackColor = Color.Transparent)
                    Me.Invoke(Sub() Label27.Text = Math.Round(results(17).Value, 1) & " кB")

                    If results(18).Quality.ToString <> "good" Then Me.Invoke(Sub() Label28.BackColor = Color.Pink) Else Me.Invoke(Sub() Label28.BackColor = Color.Transparent)
                    Me.Invoke(Sub() Label28.Text = Math.Round(results(18).Value, 1) & " кB")

                    If results(19).Quality.ToString <> "good" Then Me.Invoke(Sub() Label30.BackColor = Color.Pink) Else Me.Invoke(Sub() Label30.BackColor = Color.Transparent)
                    Me.Invoke(Sub() Label30.Text = Math.Round(results(19).Value, 1) & " кB")

                    If results(20).Quality.ToString <> "good" Then Me.Invoke(Sub() Label29.BackColor = Color.Pink) Else Me.Invoke(Sub() Label29.BackColor = Color.Transparent)
                    Me.Invoke(Sub() Label29.Text = Math.Round(results(20).Value, 1) & " А")

                    If results(21).Quality.ToString <> "good" Then Me.Invoke(Sub() Label31.BackColor = Color.Pink) Else Me.Invoke(Sub() Label31.BackColor = Color.Transparent)
                    Me.Invoke(Sub() Label31.Text = Math.Round(results(21).Value, 1) & " А")

                    If results(22).Quality.ToString <> "good" Then Me.Invoke(Sub() Label32.BackColor = Color.Pink) Else Me.Invoke(Sub() Label32.BackColor = Color.Transparent)
                    Me.Invoke(Sub() Label32.Text = Math.Round(results(22).Value, 1) & " А")


                    If results(24).Quality.ToString <> "good" Then Me.Invoke(Sub() l11.BackColor = Color.Pink) Else Me.Invoke(Sub() l11.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l11.Enabled = results(24).Value)

                    If results(25).Quality.ToString <> "good" Then Me.Invoke(Sub() l12.BackColor = Color.Pink) Else Me.Invoke(Sub() l12.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l12.Enabled = results(25).Value)

                    If results(26).Quality.ToString <> "good" Then Me.Invoke(Sub() l13.BackColor = Color.Pink) Else Me.Invoke(Sub() l13.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l13.Enabled = results(26).Value)

                    If results(27).Quality.ToString <> "good" Then Me.Invoke(Sub() l14.BackColor = Color.Pink) Else Me.Invoke(Sub() l14.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l14.Enabled = results(27).Value)

                    If results(28).Quality.ToString <> "good" Then Me.Invoke(Sub() l15.BackColor = Color.Pink) Else Me.Invoke(Sub() l15.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l15.Enabled = results(28).Value)


                    If results(29).Quality.ToString <> "good" Then Me.Invoke(Sub() l16.BackColor = Color.Pink) Else Me.Invoke(Sub() l16.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l16.Enabled = results(29).Value)

                    If results(30).Quality.ToString <> "good" Then Me.Invoke(Sub() l17.BackColor = Color.Pink) Else Me.Invoke(Sub() l17.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l17.Enabled = results(30).Value)

                    If results(31).Quality.ToString <> "good" Then Me.Invoke(Sub() l18.BackColor = Color.Pink) Else Me.Invoke(Sub() l18.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l18.Enabled = results(31).Value)

                    If results(32).Quality.ToString <> "good" Then Me.Invoke(Sub() l19.BackColor = Color.Pink) Else Me.Invoke(Sub() l19.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l19.Enabled = results(32).Value)

                    If results(33).Quality.ToString <> "good" Then Me.Invoke(Sub() l20.BackColor = Color.Pink) Else Me.Invoke(Sub() l20.BackColor = Color.Transparent)
                    Me.Invoke(Sub() l20.Enabled = results(33).Value)


                    Select Case results(23).Quality.ToString

                        Case "good"

                            Select Case results(23).Value

                                Case True
                                    Me.Invoke(Sub() VV2_VyKL.Visible = False)
                                    Me.Invoke(Sub() VV2_VKL.Visible = True)

                                Case False

                                    Me.Invoke(Sub() VV2_VyKL.Visible = True)
                                    Me.Invoke(Sub() VV2_VKL.Visible = False)
                            End Select

                            Me.Invoke(Sub() lblVV2.Visible = False)

                        Case Else

                            Me.Invoke(Sub() VV2_VyKL.Visible = False)
                            Me.Invoke(Sub() VV2_VKL.Visible = False)

                            Me.Invoke(Sub() lblVV2.Visible = True)

                    End Select

                    Me.Invoke(Sub() LineColor(results(35).Value, LineShape2))
                    Me.Invoke(Sub() OvalShape3.BorderColor = LineShape2.BorderColor)


                    Me.Invoke(Sub() LineColor(results(34).Value, LineShape1))
                    Me.Invoke(Sub() OvalShape2.BorderColor = LineShape1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(36).Value, LineShape4))


                    Me.Invoke(Sub() LineColor(results(38).Value, L1_10))
                    Me.Invoke(Sub() L1_4.BorderColor = L1_10.BorderColor)

                    Me.Invoke(Sub() LineColor(results(37).Value, LC1_2))
                    Me.Invoke(Sub() OvalShape1.BorderColor = LC1_2.BorderColor)

                    Me.Invoke(Sub() LineColor(results(39).Value, LineShape3))


                    'LineShape4

                Next

                Threading.Thread.Sleep(MSPEED + 120)

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
End Class