Public Class frmPLC
    Dim T_PLC1 As System.Threading.Thread
    Dim T_PLC2 As System.Threading.Thread
    Dim T_PLC3 As System.Threading.Thread

    Sub T_PLC1_start()

        Try
ARG:
            groupState_PLC_1.Name = "PLC1"
            groupState_PLC_1.Active = True
            groupState_PLC_1.UpdateRate = MSPEED

            group_PLC_1 = DirectCast(m_server.CreateSubscription(groupState_PLC_1), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(16) {}

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.ШК1.ПЛК.DATA_LOOSE"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.ШК1.ПЛК.COMM_FAILURE"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.ШК1.ПЛК.CELL_DESCR"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.ШК1.ПЛК.DAY"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.ШК1.ПЛК.MONTH"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.ШК1.ПЛК.YEAR"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.ШК1.ПЛК.HOUR"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.ШК1.ПЛК.MINUTE"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.ШК1.ПЛК.SECOND"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.ШК1.ПЛК.MOD_FAULT_1_4"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.ШК1.ПЛК.MOD_FAULT_1_5"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.ШК1.ПЛК.MOD_FAULT_1_6"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.ШК1.ПЛК.SYNC_LOOSE"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.ШК1.ПЛК.TIME_LOOSE"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.ШК1.ПЛК.MOD_FAULT_1_4"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.ШК1.ПЛК.MOD_FAULT_1_5"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.ШК1.ПЛК.MOD_FAULT_1_6"

            'РП10.ШК1.ПЛК.MOD_FAULT_1_4 - Ош. модуля ВВ 1/4
            'РП10.ШК1.ПЛК.MOD_FAULT_1_5 - Ош. модуля ВВ 1/5
            'РП10.ШК1.ПЛК.MOD_FAULT_1_6 - Ош. модуля ВВ 1/6

            items = group_PLC_1.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_PLC_1.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Select Case results(12).Value

                        Case True
                            Me.Invoke(Sub() Label3.Enabled = True)

                        Case False
                            Me.Invoke(Sub() Label3.Enabled = False)
                    End Select

                    Select Case results(13).Value

                        Case True
                            Me.Invoke(Sub() Label4.Enabled = True)

                        Case False
                            Me.Invoke(Sub() Label4.Enabled = False)
                    End Select

                    Select Case results(0).Value

                        Case True
                            Me.Invoke(Sub() Label5.Enabled = True)

                        Case False
                            Me.Invoke(Sub() Label5.Enabled = False)
                    End Select

                    Select Case results(1).Value

                        Case True
                            Me.Invoke(Sub() Label6.Enabled = True)

                        Case False
                            Me.Invoke(Sub() Label6.Enabled = False)
                    End Select


                    Me.Invoke(Sub() Label2.Text = results(3).Value & "." & results(4).Value & "." & results(5).Value)

                    Me.Invoke(Sub() Label1.Text = results(6).Value & ":" & results(7).Value & ":" & results(8).Value)

                    Me.Invoke(Sub() Label7.Text = results(2).Value)


                    Select Case results(14).Value

                        Case True
                            Me.Invoke(Sub() pl4.ForeColor = Color.Red)

                        Case False
                            Me.Invoke(Sub() pl4.ForeColor = Color.Green)

                    End Select

                    Select Case results(15).Value

                        Case True
                            Me.Invoke(Sub() pl5.ForeColor = Color.Red)

                        Case False
                            Me.Invoke(Sub() pl5.ForeColor = Color.Green)

                    End Select

                    Select Case results(16).Value

                        Case True
                            '  Me.Invoke(Sub() pl6.Enabled = False)
                            Me.Invoke(Sub() pl6.ForeColor = Color.Red)

                        Case False
                            ' Me.Invoke(Sub() pl6.Enabled = True)
                            Me.Invoke(Sub() pl6.ForeColor = Color.Green)

                    End Select


                    Me.Invoke(Sub() pl7.Visible = False)
                    Me.Invoke(Sub() pl8.Visible = False)
                    Me.Invoke(Sub() pl9.Visible = False)
                    Me.Invoke(Sub() pl10.Visible = False)


                Next

                Threading.Thread.Sleep(MSPEED + 120)

            Loop

        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try


    End Sub

    Private Sub frmPLC_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Select Case Me.Text

            Case "РП10Кв ПЛК"

                T_PLC1.Abort()
                m_server.CancelSubscription(group_PLC_1)

            Case "КТП РЭБ ПЛК"

                T_PLC2.Abort()
                m_server.CancelSubscription(group_PLC_2)

            Case "КТП ЭБ ПЛК"

                T_PLC3.Abort()
                m_server.CancelSubscription(group_PLC_3)


        End Select
    End Sub


    Private Sub frmPLC_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Select Case Me.Text

            Case "РП10Кв ПЛК"

                T_PLC1 = New System.Threading.Thread(AddressOf T_PLC1_start)
                T_PLC1.Start()

            Case "КТП РЭБ ПЛК"

                T_PLC2 = New System.Threading.Thread(AddressOf T_PLC2_start)
                T_PLC2.Start()

            Case "КТП ЭБ ПЛК"

                T_PLC3 = New System.Threading.Thread(AddressOf T_PLC3_start)
                T_PLC3.Start()


        End Select
    End Sub


    Sub T_PLC2_start()

        Try
ARG:
            groupState_PLC_2.Name = "PLC2"
            groupState_PLC_2.Active = True
            groupState_PLC_2.UpdateRate = MSPEED

            group_PLC_2 = DirectCast(m_server.CreateSubscription(groupState_PLC_2), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(18) {}

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РЭБ.ШК3.ПЛК.DATA_LOOSE"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РЭБ.ШК3.ПЛК.COMM_FAILURE"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РЭБ.ШК3.ПЛК.CELL_DESCR"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РЭБ.ШК3.ПЛК.DAY"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РЭБ.ШК3.ПЛК.MONTH"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РЭБ.ШК3.ПЛК.YEAR"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РЭБ.ШК3.ПЛК.HOUR"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РЭБ.ШК3.ПЛК.MINUTE"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РЭБ.ШК3.ПЛК.SECOND"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РЭБ.ШК3.ПЛК.MOD_FAULT_1_4"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РЭБ.ШК3.ПЛК.MOD_FAULT_1_5"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РЭБ.ШК3.ПЛК.MOD_FAULT_1_6"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РЭБ.ШК3.ПЛК.SYNC_LOOSE"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РЭБ.ШК3.ПЛК.TIME_LOOSE"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РЭБ.ШК3.ПЛК.MOD_FAULT_1_4"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РЭБ.ШК3.ПЛК.MOD_FAULT_1_5"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РЭБ.ШК3.ПЛК.MOD_FAULT_1_6"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РЭБ.ШК3.ПЛК.MOD_FAULT_1_7"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РЭБ.ШК3.ПЛК.MOD_FAULT_1_8"


            items = group_PLC_2.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_PLC_2.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Select Case results(12).Value

                        Case True
                            Me.Invoke(Sub() Label3.Enabled = True)

                        Case False
                            Me.Invoke(Sub() Label3.Enabled = False)
                    End Select

                    Select Case results(13).Value

                        Case True
                            Me.Invoke(Sub() Label4.Enabled = True)

                        Case False
                            Me.Invoke(Sub() Label4.Enabled = False)
                    End Select

                    Select Case results(0).Value

                        Case True
                            Me.Invoke(Sub() Label5.Enabled = True)

                        Case False
                            Me.Invoke(Sub() Label5.Enabled = False)
                    End Select

                    Select Case results(1).Value

                        Case True
                            Me.Invoke(Sub() Label6.Enabled = True)

                        Case False
                            Me.Invoke(Sub() Label6.Enabled = False)
                    End Select


                    Me.Invoke(Sub() Label2.Text = results(3).Value & "." & results(4).Value & "." & results(5).Value)

                    Me.Invoke(Sub() Label1.Text = results(6).Value & ":" & results(7).Value & ":" & results(8).Value)

                    Me.Invoke(Sub() Label7.Text = results(2).Value)



                    Select Case results(14).Value

                        Case True
                            Me.Invoke(Sub() pl4.ForeColor = Color.Red)

                        Case False
                            Me.Invoke(Sub() pl4.ForeColor = Color.Green)

                    End Select

                    Select Case results(15).Value

                        Case True
                            Me.Invoke(Sub() pl5.ForeColor = Color.Red)

                        Case False
                            Me.Invoke(Sub() pl5.ForeColor = Color.Green)

                    End Select

                    Select Case results(16).Value

                        Case True
                            '  Me.Invoke(Sub() pl6.Enabled = False)
                            Me.Invoke(Sub() pl6.ForeColor = Color.Red)

                        Case False
                            ' Me.Invoke(Sub() pl6.Enabled = True)
                            Me.Invoke(Sub() pl6.ForeColor = Color.Green)

                    End Select

                    Select Case results(17).Value

                        Case True
                            Me.Invoke(Sub() pl7.ForeColor = Color.Red)

                        Case False
                            Me.Invoke(Sub() pl7.ForeColor = Color.Green)

                    End Select

                    Select Case results(18).Value

                        Case True
                            '  Me.Invoke(Sub() pl6.Enabled = False)
                            Me.Invoke(Sub() pl8.ForeColor = Color.Red)

                        Case False
                            ' Me.Invoke(Sub() pl6.Enabled = True)
                            Me.Invoke(Sub() pl8.ForeColor = Color.Green)

                    End Select


                    Me.Invoke(Sub() pl9.Visible = False)
                    Me.Invoke(Sub() pl10.Visible = False)


                Next

                Threading.Thread.Sleep(MSPEED + 120)

            Loop

        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try


    End Sub


    Sub T_PLC3_start()

        Try
ARG:
            groupState_PLC_3.Name = "PLC3"
            groupState_PLC_3.Active = True
            groupState_PLC_3.UpdateRate = MSPEED

            group_PLC_3 = DirectCast(m_server.CreateSubscription(groupState_PLC_3), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(20) {}

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "КЦ2.ШК2.ПЛК.DATA_LOOSE"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "КЦ2.ШК2.ПЛК.COMM_FAILURE"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "КЦ2.ШК2.ПЛК.CELL_DESCR"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "КЦ2.ШК2.ПЛК.DAY"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "КЦ2.ШК2.ПЛК.MONTH"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "КЦ2.ШК2.ПЛК.YEAR"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "КЦ2.ШК2.ПЛК.HOUR"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "КЦ2.ШК2.ПЛК.MINUTE"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "КЦ2.ШК2.ПЛК.SECOND"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "КЦ2.ШК2.ПЛК.MOD_FAULT_1_4"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "КЦ2.ШК2.ПЛК.MOD_FAULT_1_5"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "КЦ2.ШК2.ПЛК.MOD_FAULT_1_6"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "КЦ2.ШК2.ПЛК.SYNC_LOOSE"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "КЦ2.ШК2.ПЛК.TIME_LOOSE"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "КЦ2.ШК2.ПЛК.MOD_FAULT_1_4"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "КЦ2.ШК2.ПЛК.MOD_FAULT_1_5"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "КЦ2.ШК2.ПЛК.MOD_FAULT_1_6"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "КЦ2.ШК2.ПЛК.MOD_FAULT_1_7"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "КЦ2.ШК2.ПЛК.MOD_FAULT_1_8"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "КЦ2.ШК2.ПЛК.MOD_FAULT_1_9"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "КЦ2.ШК2.ПЛК.MOD_FAULT_1_10"



            items = group_PLC_3.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_PLC_3.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Select Case results(12).Value

                        Case True
                            Me.Invoke(Sub() Label3.Enabled = True)

                        Case False
                            Me.Invoke(Sub() Label3.Enabled = False)
                    End Select

                    Select Case results(13).Value

                        Case True
                            Me.Invoke(Sub() Label4.Enabled = True)

                        Case False
                            Me.Invoke(Sub() Label4.Enabled = False)
                    End Select

                    Select Case results(0).Value

                        Case True
                            Me.Invoke(Sub() Label5.Enabled = True)

                        Case False
                            Me.Invoke(Sub() Label5.Enabled = False)
                    End Select

                    Select Case results(1).Value

                        Case True
                            Me.Invoke(Sub() Label6.Enabled = True)

                        Case False
                            Me.Invoke(Sub() Label6.Enabled = False)
                    End Select


                    Me.Invoke(Sub() Label2.Text = results(3).Value & "." & results(4).Value & "." & results(5).Value)

                    Me.Invoke(Sub() Label1.Text = results(6).Value & ":" & results(7).Value & ":" & results(8).Value)

                    Me.Invoke(Sub() Label7.Text = results(2).Value)


                    Select Case results(14).Value

                        Case True
                            Me.Invoke(Sub() pl4.ForeColor = Color.Red)

                        Case False
                            Me.Invoke(Sub() pl4.ForeColor = Color.Green)

                    End Select

                    Select Case results(15).Value

                        Case True
                            Me.Invoke(Sub() pl5.ForeColor = Color.Red)

                        Case False
                            Me.Invoke(Sub() pl5.ForeColor = Color.Green)

                    End Select

                    Select Case results(16).Value

                        Case True
                            Me.Invoke(Sub() pl6.ForeColor = Color.Red)

                        Case False
                            Me.Invoke(Sub() pl6.ForeColor = Color.Green)

                    End Select

                    Select Case results(17).Value

                        Case True
                            '  Me.Invoke(Sub() pl6.Enabled = False)
                            Me.Invoke(Sub() pl7.ForeColor = Color.Red)

                        Case False
                            ' Me.Invoke(Sub() pl6.Enabled = True)
                            Me.Invoke(Sub() pl7.ForeColor = Color.Green)

                    End Select

                    Select Case results(18).Value

                        Case True
                            Me.Invoke(Sub() pl8.ForeColor = Color.Red)

                        Case False
                            Me.Invoke(Sub() pl8.ForeColor = Color.Green)

                    End Select

                    Select Case results(19).Value

                        Case True
                            Me.Invoke(Sub() pl9.ForeColor = Color.Red)

                        Case False
                            Me.Invoke(Sub() pl9.ForeColor = Color.Green)

                    End Select

                    Select Case results(20).Value

                        Case True
                            '  Me.Invoke(Sub() pl6.Enabled = False)
                            Me.Invoke(Sub() pl10.ForeColor = Color.Red)

                        Case False
                            ' Me.Invoke(Sub() pl6.Enabled = True)
                            Me.Invoke(Sub() pl10.ForeColor = Color.Green)

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