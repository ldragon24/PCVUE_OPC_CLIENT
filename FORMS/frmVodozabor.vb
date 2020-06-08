Public Class frmVodozabor
    'Public group_VOD As Global.Opc.Da.Subscription
    'Public groupState_VOD As New Global.Opc.Da.SubscriptionState()

    Dim T_VOD As System.Threading.Thread

    Private Sub frmVodozabor_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        T_VOD.Abort()
        m_server.CancelSubscription(group_VOD)

    End Sub

    Private Sub frmVodozabor_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        T_VOD = New System.Threading.Thread(AddressOf T_VOD_START)
        T_VOD.Start()

    End Sub

    Private Sub T_VOD_START()

        Try
ARG:

            groupState_VOD.Name = "Водозабор"
            groupState_VOD.Active = True
            groupState_VOD.UpdateRate = MSPEED

            group_VOD = DirectCast(m_server.CreateSubscription(groupState_VOD), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(13) {}

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "БКЭС.С1._.U_OK"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "БКЭС.С2._.U_OK"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "БКЭС.С1.QF1.Close"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "БКЭС.С2.QF2.Close"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "БКЭС.С1.QF3.Close"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "ЩС1.С1.QF1.Close"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "ЩС1.С2.QF2.Close"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "ЩС1.С1.QF3.Close"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "ЩС1.С1._.U_OK"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "ЩС1.С2._.U_OK"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "ЩС1.С2.VOLT_COLOR"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "ЩС1.С1.VOLT_COLOR"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "БКЭС.С1.QF1.VOLT_COLOR"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "БКЭС.С2.QF2.VOLT_COLOR"



            items = group_VOD.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_VOD.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1


                    Select Case results(0).Value

                        Case True

                            vv1_u.BackColor = Color.Green
                        Case False

                            vv1_u.BackColor = Color.Red

                    End Select

                    Select Case results(1).Value

                        Case True

                            vv2_u.BackColor = Color.Green
                        Case False

                            vv2_u.BackColor = Color.Red

                    End Select

                    Sost3(results(2).Quality.ToString, results(2).Value, QF1_vykl, lblQF1)
                    Sost3(results(3).Quality.ToString, results(3).Value, QF2_vykl, lblQF2)

                    Select Case results(4).Quality.ToString
                        Case "good"

                            Select Case results(4).Value

                                Case True

                                    Me.Invoke(Sub() QF3_vkl.Visible = True)
                                    Me.Invoke(Sub() QF3_vykl.Visible = False)
                                Case False
                                    Me.Invoke(Sub() QF3_vkl.Visible = False)
                                    Me.Invoke(Sub() QF3_vykl.Visible = True)
                            End Select

                        Case Else
                            Me.Invoke(Sub() lblQF3.Visible = True)
                            Me.Invoke(Sub() QF3_vykl.Visible = False)
                            Me.Invoke(Sub() QF3_vkl.Visible = False)

                    End Select

                    Select Case results(5).Quality.ToString
                        Case "good"

                            Select Case results(5).Value

                                Case False

                                    Me.Invoke(Sub() QF1_1_vkl.Visible = False)
                                    Me.Invoke(Sub() QF1_1_vykl.Visible = True)
                                Case True
                                    Me.Invoke(Sub() QF1_1_vkl.Visible = True)
                                    Me.Invoke(Sub() QF1_1_vykl.Visible = False)
                            End Select

                        Case Else
                            Me.Invoke(Sub() lblQF1_1.Visible = True)
                            Me.Invoke(Sub() QF1_1_vykl.Visible = False)
                            Me.Invoke(Sub() QF1_1_vkl.Visible = False)

                    End Select

                    Select Case results(6).Quality.ToString
                        Case "good"

                            Select Case results(6).Value

                                Case False

                                    Me.Invoke(Sub() QF2_1_vkl.Visible = False)
                                    Me.Invoke(Sub() QF2_1_vykl.Visible = True)
                                Case True
                                    Me.Invoke(Sub() QF2_1_vkl.Visible = True)
                                    Me.Invoke(Sub() QF2_1_vykl.Visible = False)
                            End Select

                        Case Else
                            Me.Invoke(Sub() lblQF2_1.Visible = True)
                            Me.Invoke(Sub() QF2_1_vykl.Visible = False)
                            Me.Invoke(Sub() QF2_1_vkl.Visible = False)

                    End Select

                    Select Case results(7).Quality.ToString
                        Case "good"

                            Select Case results(7).Value

                                Case False

                                    Me.Invoke(Sub() QF3_1_vkl.Visible = False)
                                    Me.Invoke(Sub() QF3_1_vykl.Visible = True)
                                Case True
                                    Me.Invoke(Sub() QF3_1_vkl.Visible = True)
                                    Me.Invoke(Sub() QF3_1_vykl.Visible = False)
                            End Select

                        Case Else
                            Me.Invoke(Sub() lblQF3_1.Visible = True)
                            Me.Invoke(Sub() QF3_1_vykl.Visible = False)
                            Me.Invoke(Sub() QF3_1_vkl.Visible = False)

                    End Select


                    Select Case results(8).Value

                        Case True

                            Me.Invoke(Sub() vv1_1_u.BackColor = Color.Green)
                        Case False

                            Me.Invoke(Sub() vv1_1_u.BackColor = Color.Red)

                    End Select

                    Select Case results(9).Value

                        Case True

                            Me.Invoke(Sub() vv2_1_u.BackColor = Color.Green)
                        Case False

                            Me.Invoke(Sub() vv2_1_u.BackColor = Color.Red)

                    End Select

                    Select Case results(10).Value

                        Case "0"

                            Me.Invoke(Sub() L1_1.BorderColor = Color.Black)
                            Me.Invoke(Sub() L1_2.BorderColor = L1_1.BorderColor)
                            Me.Invoke(Sub() L1_3.BorderColor = L1_1.BorderColor)
                            Me.Invoke(Sub() L1_4.BorderColor = L1_1.BorderColor)

                        Case "1"

                            Me.Invoke(Sub() L1_1.BorderColor = Color.Gray)
                            Me.Invoke(Sub() L1_2.BorderColor = L1_1.BorderColor)
                            Me.Invoke(Sub() L1_3.BorderColor = L1_1.BorderColor)
                            Me.Invoke(Sub() L1_4.BorderColor = L1_1.BorderColor)

                        Case "4"

                            Me.Invoke(Sub() L1_1.BorderColor = Color.Blue)
                            Me.Invoke(Sub() L1_2.BorderColor = L1_1.BorderColor)
                            Me.Invoke(Sub() L1_3.BorderColor = L1_1.BorderColor)
                            Me.Invoke(Sub() L1_4.BorderColor = L1_1.BorderColor)

                        Case "8"

                            Me.Invoke(Sub() L1_1.BorderColor = Color.DeepSkyBlue)
                            Me.Invoke(Sub() L1_2.BorderColor = L1_1.BorderColor)
                            Me.Invoke(Sub() L1_3.BorderColor = L1_1.BorderColor)
                            Me.Invoke(Sub() L1_4.BorderColor = L1_1.BorderColor)

                        Case "40"

                            Me.Invoke(Sub() L1_1.BorderColor = Color.Yellow)
                            Me.Invoke(Sub() L1_2.BorderColor = L1_1.BorderColor)
                            Me.Invoke(Sub() L1_3.BorderColor = L1_1.BorderColor)
                            Me.Invoke(Sub() L1_4.BorderColor = L1_1.BorderColor)


                    End Select

                    Select Case results(11).Value

                        Case "0"
                            Me.Invoke(Sub() L2_1.BorderColor = Color.Black)
                        Case "1"
                            Me.Invoke(Sub() L2_1.BorderColor = Color.Gray)
                        Case "4"
                            Me.Invoke(Sub() L2_1.BorderColor = Color.Blue)
                        Case "8"
                            Me.Invoke(Sub() L2_1.BorderColor = Color.DeepSkyBlue)
                        Case "40"
                            Me.Invoke(Sub() L2_1.BorderColor = Color.Yellow)
                        Case Else
                            Me.Invoke(Sub() L2_1.BorderColor = Color.Pink)
                    End Select

                    Me.Invoke(Sub() L2_2.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_3.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_4.BorderColor = L2_1.BorderColor)


                    Select Case results(12).Value

                        Case "0"
                            Me.Invoke(Sub() L3_1.BorderColor = Color.Black)
                        Case "1"
                            Me.Invoke(Sub() L3_1.BorderColor = Color.Gray)
                        Case "4"
                            Me.Invoke(Sub() L3_1.BorderColor = Color.Blue)
                        Case "8"
                            Me.Invoke(Sub() L3_1.BorderColor = Color.DeepSkyBlue)
                        Case "40"
                            Me.Invoke(Sub() L3_1.BorderColor = Color.Yellow)
                        Case Else
                            Me.Invoke(Sub() L3_1.BorderColor = Color.Pink)
                    End Select

                    Me.Invoke(Sub() L3_2.BorderColor = L3_1.BorderColor)
                    Me.Invoke(Sub() L3_3.BorderColor = L3_1.BorderColor)
                    Me.Invoke(Sub() L3_4.BorderColor = L3_1.BorderColor)
                    Me.Invoke(Sub() L3_5.BorderColor = L3_1.BorderColor)
                    Me.Invoke(Sub() L3_6.BorderColor = L3_1.BorderColor)

                    Select Case results(13).Value

                        Case "0"
                            Me.Invoke(Sub() L4_1.BorderColor = Color.Black)
                        Case "1"
                            Me.Invoke(Sub() L4_1.BorderColor = Color.Gray)
                        Case "4"
                            Me.Invoke(Sub() L4_1.BorderColor = Color.Blue)
                        Case "8"
                            Me.Invoke(Sub() L4_1.BorderColor = Color.DeepSkyBlue)
                        Case "40"
                            Me.Invoke(Sub() L4_1.BorderColor = Color.Yellow)
                        Case Else
                            Me.Invoke(Sub() L4_1.BorderColor = Color.Pink)
                    End Select

                    Me.Invoke(Sub() L4_2.BorderColor = L4_1.BorderColor)
                    Me.Invoke(Sub() L4_3.BorderColor = L4_1.BorderColor)
                    Me.Invoke(Sub() L4_4.BorderColor = L4_1.BorderColor)


                Next

                Threading.Thread.Sleep(MSPEED + 10)
            Loop

        Catch ex As Exception
            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try


    End Sub

    Private Sub Sost3(ByVal Quality As String, ByVal Value As Boolean, ByVal qf As PictureBox, ByVal lbl As System.Windows.Forms.Label)

        Select Case Quality
            Case "good"

                Select Case Value
                    Case True
                        qf.BackgroundImage = My.Resources.OnState
                    Case False
                        qf.BackgroundImage = My.Resources.OffState
                End Select

                Me.Invoke(Sub() lbl.Visible = False)
                Me.Invoke(Sub() qf.Visible = True)

            Case Else
                Me.Invoke(Sub() lbl.Visible = True)
                Me.Invoke(Sub() qf.Visible = False)

        End Select

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        frmRP10.MdiParent = frmIndexer
        frmRP10.Show()
        frmRP10.Focus()
    End Sub
End Class