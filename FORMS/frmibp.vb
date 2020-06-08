Public Class frmibp
    Dim T_IBP As System.Threading.Thread
    Dim T_IBP2 As System.Threading.Thread
    Dim T_IBP3 As System.Threading.Thread
    Dim T_IBP4 As System.Threading.Thread
    Dim T_IBP5 As System.Threading.Thread


    Private Sub frmibp_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Select Case Me.Text

            Case "ИБП шкафа №1"

                T_IBP.Abort()
                m_server.CancelSubscription(group_IBP_1)

            Case "ИБП шкафа №2"

                T_IBP2.Abort()
                m_server.CancelSubscription(group_IBP_2)

            Case "ИБП шкафа №3"

                T_IBP3.Abort()
                m_server.CancelSubscription(group_IBP_3)

            Case "ИБП шкафа №4"

                T_IBP4.Abort()
                m_server.CancelSubscription(group_IBP_4)

            Case "ИБП шкафа сереров"

                T_IBP5.Abort()
                m_server.CancelSubscription(group_IBP_5)

        End Select

    End Sub

    Private Sub frmibp_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        Select Case Me.Text

            Case "ИБП шкафа №1"

                T_IBP = New System.Threading.Thread(AddressOf T_IBP_start)
                T_IBP.Start()

            Case "ИБП шкафа №2"

                T_IBP2 = New System.Threading.Thread(AddressOf T_IBP_start2)
                T_IBP2.Start()

            Case "ИБП шкафа №3"

                T_IBP3 = New System.Threading.Thread(AddressOf T_IBP_start3)
                T_IBP3.Start()

            Case "ИБП шкафа №4"

                T_IBP4 = New System.Threading.Thread(AddressOf T_IBP_start4)
                T_IBP4.Start()

            Case "ИБП шкафа сереров"

                T_IBP5 = New System.Threading.Thread(AddressOf T_IBP_start5)
                T_IBP5.Start()

        End Select



    End Sub

    Sub T_IBP_start()

        Try
ARG:
            groupState_IBP_1.Name = "IBP1"
            groupState_IBP_1.Active = True
            groupState_IBP_1.UpdateRate = MSPEED

            group_IBP_1 = DirectCast(m_server.CreateSubscription(groupState_IBP_1), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(9) {}

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "АСУ.ИБП.ШК1.BatLevel"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "АСУ.ИБП.ШК1.BatReplacement"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "АСУ.ИБП.ШК1.OVERTEMP"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "АСУ.ИБП.ШК1.InVoltage"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "АСУ.ИБП.ШК1.ONBAT"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "АСУ.ИБП.ШК1.OutCurr"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "АСУ.ИБП.ШК1.OutFreq"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "АСУ.ИБП.ШК1.OutLoad"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "АСУ.ИБП.ШК1.OutVoltage"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "АСУ.ИБП.ШК1.UpsRemTime"

            items = group_IBP_1.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_IBP_1.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1


                    Me.Invoke(Sub() ProgBar_VerticalTEXT2.Value = results(0).Value)
                    Me.Invoke(Sub() ProgBar_HorizontalTEXT1.Value = results(7).Value)
                    Me.Invoke(Sub() VerticalLabel1.Text = results(9).Value & " минут")


                    Select Case results(1).Value

                        Case True
                            Me.Invoke(Sub() Label8.Text = "Требуется замена")
                            Me.Invoke(Sub() Label8.ForeColor = Color.Red)

                        Case Else
                            Me.Invoke(Sub() Label8.Text = "Батарея нормальная\Не требуется замена")
                            Me.Invoke(Sub() Label8.ForeColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label10.Text = results(3).Value & " VAC")
                    Me.Invoke(Sub() Label11.Text = results(8).Value & " VAC")
                    Me.Invoke(Sub() Label23.Text = results(6).Value & " MHz")

                    Select Case results(4).Value

                        Case 2
                            Me.Invoke(Sub() Label24.Text = "От сети")
                            Me.Invoke(Sub() Label24.ForeColor = Color.Green)
                        Case Else
                            Me.Invoke(Sub() Label24.Text = "От батареи")
                            Me.Invoke(Sub() Label24.ForeColor = Color.Red)
                    End Select

                    Select Case results(2).Value

                        Case 2
                            Me.Invoke(Sub() Label30.Text = "В норме")
                            Me.Invoke(Sub() Label30.ForeColor = Color.Green)
                        Case Else
                            Me.Invoke(Sub() Label30.Text = "Перегрев")
                            Me.Invoke(Sub() Label30.ForeColor = Color.Red)
                    End Select

                Next

                Threading.Thread.Sleep(MSPEED + 120)

            Loop

        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try


    End Sub

    Sub T_IBP_start2()

        Try
ARG:
            groupState_IBP_2.Name = "IBP2"
            groupState_IBP_2.Active = True
            groupState_IBP_2.UpdateRate = MSPEED

            group_IBP_2 = DirectCast(m_server.CreateSubscription(groupState_IBP_2), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(9) {}

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "АСУ.ИБП.ШК2.BatLevel"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "АСУ.ИБП.ШК2.BatReplacement"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "АСУ.ИБП.ШК2.OVERTEMP"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "АСУ.ИБП.ШК2.InVoltage"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "АСУ.ИБП.ШК2.ONBAT"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "АСУ.ИБП.ШК2.OutCurr"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "АСУ.ИБП.ШК2.OutFreq"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "АСУ.ИБП.ШК2.OutLoad"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "АСУ.ИБП.ШК2.OutVoltage"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "АСУ.ИБП.ШК2.UpsRemTime"

            items = group_IBP_2.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_IBP_2.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1


                    Me.Invoke(Sub() ProgBar_VerticalTEXT2.Value = results(0).Value)
                    Me.Invoke(Sub() ProgBar_HorizontalTEXT1.Value = results(7).Value)
                    Me.Invoke(Sub() VerticalLabel1.Text = results(9).Value & " минут")

                    Select Case results(1).Value

                        Case True
                            Me.Invoke(Sub() Label8.Text = "Требуется замена")
                            Me.Invoke(Sub() Label8.ForeColor = Color.Red)

                        Case Else
                            Me.Invoke(Sub() Label8.Text = "Батарея нормальная\Не требуется замена")
                            Me.Invoke(Sub() Label8.ForeColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label10.Text = results(3).Value & " VAC")
                    Me.Invoke(Sub() Label11.Text = results(8).Value & " VAC")
                    Me.Invoke(Sub() Label23.Text = results(6).Value & " MHz")

                    Select Case results(4).Value

                        Case 2
                            Me.Invoke(Sub() Label24.Text = "От сети")
                            Me.Invoke(Sub() Label24.ForeColor = Color.Green)
                        Case Else
                            Me.Invoke(Sub() Label24.Text = "От батареи")
                            Me.Invoke(Sub() Label24.ForeColor = Color.Red)
                    End Select

                    Select Case results(2).Value

                        Case 2
                            Me.Invoke(Sub() Label30.Text = "В норме")
                            Me.Invoke(Sub() Label30.ForeColor = Color.Green)
                        Case Else
                            Me.Invoke(Sub() Label30.Text = "Перегрев")
                            Me.Invoke(Sub() Label30.ForeColor = Color.Red)
                    End Select

                Next

                Threading.Thread.Sleep(MSPEED + 120)

            Loop

        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try


    End Sub

    Sub T_IBP_start3()

        Try
ARG:
            groupState_IBP_3.Name = "IBP3"
            groupState_IBP_3.Active = True
            groupState_IBP_3.UpdateRate = MSPEED

            group_IBP_3 = DirectCast(m_server.CreateSubscription(groupState_IBP_3), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(9) {}

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "АСУ.ИБП.ШК3.BatLevel"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "АСУ.ИБП.ШК3.BatReplacement"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "АСУ.ИБП.ШК3.OVERTEMP"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "АСУ.ИБП.ШК3.InVoltage"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "АСУ.ИБП.ШК3.ONBAT"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "АСУ.ИБП.ШК3.OutCurr"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "АСУ.ИБП.ШК3.OutFreq"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "АСУ.ИБП.ШК3.OutLoad"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "АСУ.ИБП.ШК3.OutVoltage"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "АСУ.ИБП.ШК3.UpsRemTime"

            items = group_IBP_3.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_IBP_3.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1


                    Me.Invoke(Sub() ProgBar_VerticalTEXT2.Value = results(0).Value)
                    Me.Invoke(Sub() ProgBar_HorizontalTEXT1.Value = results(7).Value)
                    Me.Invoke(Sub() VerticalLabel1.Text = results(9).Value & " минут")


                    Select Case results(1).Value

                        Case True
                            Me.Invoke(Sub() Label8.Text = "Требуется замена")
                            Me.Invoke(Sub() Label8.ForeColor = Color.Red)

                        Case Else
                            Me.Invoke(Sub() Label8.Text = "Батарея нормальная\Не требуется замена")
                            Me.Invoke(Sub() Label8.ForeColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label10.Text = results(3).Value & " VAC")
                    Me.Invoke(Sub() Label11.Text = results(8).Value & " VAC")
                    Me.Invoke(Sub() Label23.Text = results(6).Value & " MHz")

                    Select Case results(4).Value

                        Case 2
                            Me.Invoke(Sub() Label24.Text = "От сети")
                            Me.Invoke(Sub() Label24.ForeColor = Color.Green)
                        Case Else
                            Me.Invoke(Sub() Label24.Text = "От батареи")
                            Me.Invoke(Sub() Label24.ForeColor = Color.Red)
                    End Select

                    Select Case results(2).Value

                        Case 2
                            Me.Invoke(Sub() Label30.Text = "В норме")
                            Me.Invoke(Sub() Label30.ForeColor = Color.Green)
                        Case Else
                            Me.Invoke(Sub() Label30.Text = "Перегрев")
                            Me.Invoke(Sub() Label30.ForeColor = Color.Red)
                    End Select

                Next

                Threading.Thread.Sleep(MSPEED + 120)

            Loop

        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try


    End Sub

    Sub T_IBP_start4()

        Try
ARG:
            groupState_IBP_4.Name = "IBP4"
            groupState_IBP_4.Active = True
            groupState_IBP_4.UpdateRate = MSPEED

            group_IBP_4 = DirectCast(m_server.CreateSubscription(groupState_IBP_4), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(9) {}

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "АСУ.ИБП.ШК4.BatLevel"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "АСУ.ИБП.ШК4.BatReplacement"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "АСУ.ИБП.ШК4.OVERTEMP"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "АСУ.ИБП.ШК4.InVoltage"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "АСУ.ИБП.ШК4.ONBAT"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "АСУ.ИБП.ШК4.OutCurr"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "АСУ.ИБП.ШК4.OutFreq"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "АСУ.ИБП.ШК4.OutLoad"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "АСУ.ИБП.ШК4.OutVoltage"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "АСУ.ИБП.ШК4.UpsRemTime"

            items = group_IBP_4.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_IBP_4.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1


                    Me.Invoke(Sub() ProgBar_VerticalTEXT2.Value = results(0).Value)
                    Me.Invoke(Sub() ProgBar_HorizontalTEXT1.Value = results(7).Value)
                    Me.Invoke(Sub() VerticalLabel1.Text = results(9).Value & " минут")


                    Select Case results(1).Value

                        Case True
                            Me.Invoke(Sub() Label8.Text = "Требуется замена")
                            Me.Invoke(Sub() Label8.ForeColor = Color.Red)

                        Case Else
                            Me.Invoke(Sub() Label8.Text = "Батарея нормальная\Не требуется замена")
                            Me.Invoke(Sub() Label8.ForeColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label10.Text = results(3).Value & " VAC")
                    Me.Invoke(Sub() Label11.Text = results(8).Value & " VAC")
                    Me.Invoke(Sub() Label23.Text = results(6).Value & " MHz")

                    Select Case results(4).Value

                        Case 2
                            Me.Invoke(Sub() Label24.Text = "От сети")
                            Me.Invoke(Sub() Label24.ForeColor = Color.Green)
                        Case Else
                            Me.Invoke(Sub() Label24.Text = "От батареи")
                            Me.Invoke(Sub() Label24.ForeColor = Color.Red)
                    End Select

                    Select Case results(2).Value

                        Case 2
                            Me.Invoke(Sub() Label30.Text = "В норме")
                            Me.Invoke(Sub() Label30.ForeColor = Color.Green)
                        Case Else
                            Me.Invoke(Sub() Label30.Text = "Перегрев")
                            Me.Invoke(Sub() Label30.ForeColor = Color.Red)
                    End Select

                Next

                Threading.Thread.Sleep(MSPEED + 120)

            Loop

        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try


    End Sub

    Sub T_IBP_start5()

        Try
ARG:
            groupState_IBP_5.Name = "IBP5"
            groupState_IBP_5.Active = True
            groupState_IBP_5.UpdateRate = MSPEED

            group_IBP_5 = DirectCast(m_server.CreateSubscription(groupState_IBP_5), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(9) {}

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "АСУ.ИБП.ШК_СЕРВ.BatLevel"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "АСУ.ИБП.ШК_СЕРВ.BatReplacement"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "АСУ.ИБП.ШК_СЕРВ.OVERTEMP"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "АСУ.ИБП.ШК_СЕРВ.InVoltage"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "АСУ.ИБП.ШК_СЕРВ.ONBAT"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "АСУ.ИБП.ШК_СЕРВ.OutCurr"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "АСУ.ИБП.ШК_СЕРВ.OutFreq"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "АСУ.ИБП.ШК_СЕРВ.OutLoad"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "АСУ.ИБП.ШК_СЕРВ.OutVoltage"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "АСУ.ИБП.ШК_СЕРВ.UpsRemTime"

            items = group_IBP_5.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_IBP_5.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1


                    Me.Invoke(Sub() ProgBar_VerticalTEXT2.Value = results(0).Value)
                    Me.Invoke(Sub() ProgBar_HorizontalTEXT1.Value = results(7).Value)
                    Me.Invoke(Sub() VerticalLabel1.Text = results(9).Value & " минут")


                    Select Case results(1).Value

                        Case True
                            Me.Invoke(Sub() Label8.Text = "Требуется замена")
                            Me.Invoke(Sub() Label8.ForeColor = Color.Red)

                        Case Else
                            Me.Invoke(Sub() Label8.Text = "Батарея нормальная\Не требуется замена")
                            Me.Invoke(Sub() Label8.ForeColor = Color.Green)
                    End Select

                    Me.Invoke(Sub() Label10.Text = results(3).Value & " VAC")
                    Me.Invoke(Sub() Label11.Text = results(8).Value & " VAC")
                    Me.Invoke(Sub() Label23.Text = results(6).Value & " MHz")

                    Select Case results(4).Value

                        Case 2
                            Me.Invoke(Sub() Label24.Text = "От сети")
                            Me.Invoke(Sub() Label24.ForeColor = Color.Green)
                        Case Else
                            Me.Invoke(Sub() Label24.Text = "От батареи")
                            Me.Invoke(Sub() Label24.ForeColor = Color.Red)
                    End Select

                    Select Case results(2).Value

                        Case 2
                            Me.Invoke(Sub() Label30.Text = "В норме")
                            Me.Invoke(Sub() Label30.ForeColor = Color.Green)
                        Case Else
                            Me.Invoke(Sub() Label30.Text = "Перегрев")
                            Me.Invoke(Sub() Label30.ForeColor = Color.Red)
                    End Select

                Next

                Threading.Thread.Sleep(MSPEED + 120)

            Loop

        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try


    End Sub

End Class