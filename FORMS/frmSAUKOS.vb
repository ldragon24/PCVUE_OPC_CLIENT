Public Class frmSAUKOS
    Dim T_KOS As System.Threading.Thread

    Private Sub btn_SAUT_Click(sender As System.Object, e As System.EventArgs) Handles btn_SAUT.Click

        Select Case btn_SAUT.Text

            Case "Старт"

                btn_SAUT.Text = "Стоп"
                T_KOS = New System.Threading.Thread(AddressOf T_SAUT_KOS)
                T_KOS.Start()

            Case "Стоп"

                btn_SAUT.Text = "Старт"
                m_server.CancelSubscription(group_SAUKOS)
                T_KOS.Abort()

        End Select

    End Sub

    Private Sub frmSAUKOS_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        T_KOS.Abort()
        m_server.CancelSubscription(group_SAUKOS)
    End Sub

    Private Sub frmSAUKOS_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Select Case btn_SAUT.Text

            Case "Старт"

                btn_SAUT.Text = "Стоп"
                T_KOS = New System.Threading.Thread(AddressOf T_SAUT_KOS)
                T_KOS.Start()

            Case "Стоп"

                btn_SAUT.Text = "Старт"
                m_server.CancelSubscription(group_SAUKOS)
                T_KOS.Abort()

        End Select
    End Sub



    Sub T_SAUT_KOS()

        Try
ARG:
            groupState_SAUKOS.Name = "САУ_КОС"
            groupState_SAUKOS.Active = True
            groupState_SAUKOS.UpdateRate = MSPEED

            group_SAUKOS = DirectCast(m_server.CreateSubscription(groupState_SAUKOS), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Global.Opc.Da.Item(7) {}
            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "КОС.САУ._.FAULT_KNS_NBS"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "КОС.САУ._.FAULT_KNS_NDS"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "КОС.САУ._.FAULT_OVERALL"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "КОС.САУ._.BREAKDOWN_OC5"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "КОС.САУ._.WATER_LVL_MAX"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "КНС.ДС.14.FAULT"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "КНС.НБТ.21.FAULT"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "КНС.НБТ.27.FAULT"


            'КНС.ДС.14.FAULT
            'КНС.НБТ.21.FAULT
            'КНС.НБТ.27.FAULT

            items = group_SAUKOS.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_SAUKOS.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1


                    Select Case results(0).Value
                        Case False
                            Me.Invoke(Sub() Label1.Enabled = False)
                        Case True
                            Me.Invoke(Sub() Label1.Enabled = True)
                    End Select

                    Select Case results(1).Value
                        Case False
                            Me.Invoke(Sub() Label2.Enabled = False)
                        Case True
                            Me.Invoke(Sub() Label2.Enabled = True)
                    End Select

                    Select Case results(2).Value
                        Case False
                            Me.Invoke(Sub() Label3.Enabled = False)
                        Case True
                            Me.Invoke(Sub() Label3.Enabled = True)
                    End Select

                    Select Case results(3).Value
                        Case False
                            Me.Invoke(Sub() Label4.Enabled = False)
                        Case True
                            Me.Invoke(Sub() Label4.Enabled = True)
                    End Select

                    Select Case results(4).Value
                        Case False
                            Me.Invoke(Sub() Label5.Enabled = False)
                        Case True
                            Me.Invoke(Sub() Label5.Enabled = True)
                    End Select

                    Select Case results(5).Value
                        Case False
                            Me.Invoke(Sub() Label6.Enabled = False)
                        Case True
                            Me.Invoke(Sub() Label6.Enabled = True)
                    End Select

                    Select Case results(6).Value
                        Case False
                            Me.Invoke(Sub() Label7.Enabled = False)
                        Case True
                            Me.Invoke(Sub() Label7.Enabled = True)
                    End Select

                    Select Case results(7).Value
                        Case False
                            Me.Invoke(Sub() Label8.Enabled = False)
                        Case True
                            Me.Invoke(Sub() Label8.Enabled = True)
                    End Select


                Next

                Threading.Thread.Sleep(MSPEED + MSPEED + 520)

            Loop

        Catch ex As Exception

            '' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub


End Class