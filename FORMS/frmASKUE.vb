Public Class frmASKUE
    Dim T_ASKUER As System.Threading.Thread

    Private Sub btn_ASKUER_Click(sender As System.Object, e As System.EventArgs) Handles btn_ASTUE.Click
        Select Case btn_ASTUE.Text

            Case "Старт"

                btn_ASTUE.Text = "Стоп"
                T_ASKUER = New System.Threading.Thread(AddressOf T_ASKUER_START)
                T_ASKUER.Start()

            Case "Стоп"

                btn_ASTUE.Text = "Старт"
                m_server.CancelSubscription(groupASKUER)
                T_ASKUER.Abort()

        End Select
    End Sub

    Sub T_ASKUER_START()

        Try
ARG:
            groupStateASKUER.Name = "АСКУЭ"
            groupStateASKUER.Active = True
            groupStateASKUER.UpdateRate = MSPEED

            groupASKUER = DirectCast(m_server.CreateSubscription(groupStateASKUER), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(23) {}

            '##########################################################
            'ГПА №1
            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "АСКУЭР.К109.FE11.K109_FLOW"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "АСКУЭР.ШР1.QFI1.N2P_FLOW"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "АСКУЭР.ШР1.QFI1.SKV1_FLOW"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "АСКУЭР.ШР1.QFI1.SKV2_FLOW"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "АСКУЭР.ШР2.QFI2.GAR_FLOW"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "АСКУЭР.ШР2.QFI2.MOIKA_FLOW"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "АСКУЭР.ШР2.QFI2.PROH_FLOW"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "АСКУЭР.ШР2.QFI2.REB_FLOW"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "АСКУЭР.ШР2.QFI2.STOL_FLOW"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "АСКУЭР.ШР3.QFI3.DZD_FLOW"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "АСКУЭР.ШР3.QFI3.BYT_FLOW"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "АСКУЭР.КОТ.QFI4.CIRC_FLOW"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "АСКУЭР.КОТ.QFI4.E"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "АСКУЭР.КОТ.QFI4.M"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "АСКУЭР.КОТ.QFI4.PRYM_FLOW"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "АСКУЭР.КОТ.QFI4.OBR_FLOW"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "АСКУЭР.КОТ.QFI4.PODP_FLOW"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "АСКУЭР.КОТ.QFI4.Qm"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "АСКУЭР.КОТ.QFI4.T"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "АСКУЭР.КОТ.QFI4.GOR_FLOW"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "АСКУЭР.КОТ.QFI4.ISKH_FLOW"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "АСКУЭР.КОТ.QFI4.T_OBR_TR"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "АСКУЭР.КОТ.QFI4.T_PRYAM_TR"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "АСКУЭР.КОТ.QFI4.W"

            'АСКУЭР.КОТ.QFI4.E
            'АСКУЭР.КОТ.QFI4.T_PRYAM_TR


            items = groupASKUER.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = groupASKUER.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1
                    '##########################################################
                    'ГПА №1



                    Select Case results(0).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label21.Text = Math.Round(results(0).Value, 2) & " М3")
                            Me.Invoke(Sub() Label21.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label21.Text = Math.Round(results(0).Value, 2) & " М3")
                            Me.Invoke(Sub() Label21.BackColor = Color.Pink)
                    End Select

                    Select Case results(1).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label2.Text = Math.Round(results(1).Value, 2) & " М3")
                            Me.Invoke(Sub() Label2.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label2.Text = Math.Round(results(1).Value, 2) & " М3")
                            Me.Invoke(Sub() Label2.BackColor = Color.Pink)
                    End Select

                    Select Case results(2).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label3.Text = Math.Round(results(2).Value, 2) & " М3")
                            Me.Invoke(Sub() Label3.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label3.Text = Math.Round(results(2).Value, 2) & " М3")
                            Me.Invoke(Sub() Label3.BackColor = Color.Pink)
                    End Select

                    Select Case results(3).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label5.Text = Math.Round(results(3).Value, 2) & " М3")
                            Me.Invoke(Sub() Label5.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label5.Text = Math.Round(results(3).Value, 2) & " М3")
                            Me.Invoke(Sub() Label5.BackColor = Color.Pink)
                    End Select

                    Select Case results(4).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label13.Text = Math.Round(results(4).Value, 2) & " М3")
                            Me.Invoke(Sub() Label13.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label13.Text = Math.Round(results(4).Value, 2) & " М3")
                            Me.Invoke(Sub() Label13.BackColor = Color.Pink)
                    End Select

                    Select Case results(5).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label15.Text = Math.Round(results(5).Value, 2) & " М3")
                            Me.Invoke(Sub() Label15.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label15.Text = Math.Round(results(5).Value, 2) & " М3")
                            Me.Invoke(Sub() Label15.BackColor = Color.Pink)
                    End Select

                    Select Case results(6).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label9.Text = Math.Round(results(6).Value, 2) & " М3")
                            Me.Invoke(Sub() Label9.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label9.Text = Math.Round(results(6).Value, 2) & " М3")
                            Me.Invoke(Sub() Label9.BackColor = Color.Pink)
                    End Select

                    Select Case results(7).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label7.Text = Math.Round(results(7).Value, 2) & " М3")
                            Me.Invoke(Sub() Label7.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label7.Text = Math.Round(results(7).Value, 2) & " М3")
                            Me.Invoke(Sub() Label7.BackColor = Color.Pink)
                    End Select

                    Select Case results(8).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label11.Text = Math.Round(results(8).Value, 2) & " М3")
                            Me.Invoke(Sub() Label11.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label11.Text = Math.Round(results(8).Value, 2) & " М3")
                            Me.Invoke(Sub() Label11.BackColor = Color.Pink)
                    End Select


                    Select Case results(9).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label19.Text = Math.Round(results(9).Value, 2) & " М3")
                            Me.Invoke(Sub() Label19.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label19.Text = Math.Round(results(9).Value, 2) & " М3")
                            Me.Invoke(Sub() Label19.BackColor = Color.Pink)
                    End Select

                    Select Case results(10).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label17.Text = Math.Round(results(10).Value, 2) & " М3")
                            Me.Invoke(Sub() Label17.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label17.Text = Math.Round(results(10).Value, 2) & " М3")
                            Me.Invoke(Sub() Label17.BackColor = Color.Pink)
                    End Select

                    Select Case results(11).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label36.Text = Math.Round(results(11).Value, 2) & " М3")
                            Me.Invoke(Sub() Label36.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label36.Text = Math.Round(results(11).Value, 2) & " М3")
                            Me.Invoke(Sub() Label36.BackColor = Color.Pink)
                    End Select

                    Select Case results(12).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label41.Text = Math.Round(results(12).Value, 2) & " Гдж\ч")
                            Me.Invoke(Sub() Label41.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label41.Text = Math.Round(results(12).Value, 2) & " Гдж\ч")
                            Me.Invoke(Sub() Label41.BackColor = Color.Pink)
                    End Select

                    Select Case results(13).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label43.Text = Math.Round(results(13).Value, 2) & " т,кг.")
                            Me.Invoke(Sub() Label43.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label43.Text = Math.Round(results(13).Value, 2) & " т,кг.")
                            Me.Invoke(Sub() Label43.BackColor = Color.Pink)
                    End Select

                    Select Case results(14).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label23.Text = Math.Round(results(14).Value, 2) & " М3")
                            Me.Invoke(Sub() Label23.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label23.Text = Math.Round(results(14).Value, 2) & " М3")
                            Me.Invoke(Sub() Label23.BackColor = Color.Pink)
                    End Select

                    Select Case results(15).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label29.Text = Math.Round(results(15).Value, 2) & " М3")
                            Me.Invoke(Sub() Label29.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label29.Text = Math.Round(results(15).Value, 2) & " М3")
                            Me.Invoke(Sub() Label29.BackColor = Color.Pink)
                    End Select

                    Select Case results(16).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label40.Text = Math.Round(results(16).Value, 2) & " М3")
                            Me.Invoke(Sub() Label40.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label40.Text = Math.Round(results(16).Value, 2) & " М3")
                            Me.Invoke(Sub() Label40.BackColor = Color.Pink)
                    End Select

                    Select Case results(17).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label44.Text = Math.Round(results(17).Value, 2) & " т,кг.")
                            Me.Invoke(Sub() Label44.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label44.Text = Math.Round(results(17).Value, 2) & " т,кг.")
                            Me.Invoke(Sub() Label44.BackColor = Color.Pink)
                    End Select

                    Select Case results(18).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label34.Text = Math.Round(results(18).Value, 2) & " С")
                            Me.Invoke(Sub() Label34.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label34.Text = Math.Round(results(18).Value, 2) & " С")
                            Me.Invoke(Sub() Label34.BackColor = Color.Pink)
                    End Select

                    Select Case results(19).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label32.Text = Math.Round(results(19).Value, 2) & " М3")
                            Me.Invoke(Sub() Label32.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label32.Text = Math.Round(results(19).Value, 2) & " М3")
                            Me.Invoke(Sub() Label32.BackColor = Color.Pink)
                    End Select

                    Select Case results(20).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label38.Text = Math.Round(results(20).Value, 2) & " М3")
                            Me.Invoke(Sub() Label38.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label38.Text = Math.Round(results(20).Value, 2) & " М3")
                            Me.Invoke(Sub() Label38.BackColor = Color.Pink)
                    End Select

                    Select Case results(21).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label30.Text = Math.Round(results(21).Value, 2) & " С")
                            Me.Invoke(Sub() Label30.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label30.Text = Math.Round(results(21).Value, 2) & " С")
                            Me.Invoke(Sub() Label30.BackColor = Color.Pink)
                    End Select

                    Select Case results(22).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label26.Text = Math.Round(results(22).Value, 2) & " С")
                            Me.Invoke(Sub() Label26.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label26.Text = Math.Round(results(22).Value, 2) & " С")
                            Me.Invoke(Sub() Label26.BackColor = Color.Pink)
                    End Select

                    Select Case results(23).Quality.ToString
                        Case "good"
                            Me.Invoke(Sub() Label42.Text = Math.Round(results(23).Value, 2) & " Гкал,ГДж")
                            Me.Invoke(Sub() Label42.BackColor = Color.LightGreen)
                        Case Else

                            Me.Invoke(Sub() Label42.Text = Math.Round(results(23).Value, 2) & " Гкал,ГДж")
                            Me.Invoke(Sub() Label42.BackColor = Color.Pink)
                    End Select


                Next

                Threading.Thread.Sleep(MSPEED + 850)
            Loop

        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Private Sub frmASKUE_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        T_ASKUER.Abort()
        m_server.CancelSubscription(groupASKUER)

    End Sub

    Private Sub frmASKUE_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Select Case btn_ASTUE.Text

            Case "Старт"

                btn_ASTUE.Text = "Стоп"
                T_ASKUER = New System.Threading.Thread(AddressOf T_ASKUER_START)
                T_ASKUER.Start()

            Case "Стоп"

                btn_ASTUE.Text = "Старт"
                m_server.CancelSubscription(groupASKUER)
                T_ASKUER.Abort()

        End Select


    End Sub

    Private Sub frmASKUE_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Call FONT_SIZE(Me)
    End Sub
End Class