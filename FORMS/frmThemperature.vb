Public Class frmThemperature
    Dim T_THEMP As System.Threading.Thread

    Private Sub btn_SAUT_Click(sender As System.Object, e As System.EventArgs) Handles btn_SAUT.Click

        Select Case btn_SAUT.Text

            Case "Старт"

                btn_SAUT.Text = "Стоп"
                T_THEMP = New System.Threading.Thread(AddressOf T_SAUT_THEMP)
                T_THEMP.Start()

            Case "Стоп"

                btn_SAUT.Text = "Старт"
                m_server.CancelSubscription(group_SAUTh)
                T_THEMP.Abort()

        End Select

    End Sub

    Private Sub frmThemperature_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        T_THEMP.Abort()
        m_server.CancelSubscription(group_SAUTh)

    End Sub

    Private Sub frmThemperature_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Select Case btn_SAUT.Text

            Case "Старт"

                btn_SAUT.Text = "Стоп"
                T_THEMP = New System.Threading.Thread(AddressOf T_SAUT_THEMP)
                T_THEMP.Start()

            Case "Стоп"

                btn_SAUT.Text = "Старт"
                m_server.CancelSubscription(group_SAUTh)
                T_THEMP.Abort()

        End Select


    End Sub


    'group_SAUTh
    'groupState_SAUTh

    Sub T_SAUT_THEMP()

        Try
ARG:
            groupState_SAUTh.Name = "САУ_Темп"
            groupState_SAUTh.Active = True
            groupState_SAUTh.UpdateRate = 500

            group_SAUTh = DirectCast(m_server.CreateSubscription(groupState_SAUTh), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Global.Opc.Da.Item(0) {}
            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "САУ_Т._.kat4.TA_Out"

            items = group_SAUTh.AddItems(items)
            Do

                Dim results As ItemValueResult() = Nothing
                results = group_SAUTh.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Dim mest As Double

                    Me.Invoke(Sub() mest = Math.Round(results(0).Value, 2))

                    If mest <= 0 Then Me.Invoke(Sub() lblThemp.ForeColor = Color.Blue)

                    If mest < 10 Then Me.Invoke(Sub() lblThemp.ForeColor = Color.LightBlue)

                    If mest >= 10 Then Me.Invoke(Sub() lblThemp.ForeColor = Color.LightGreen)

                    If mest >= 20 Then Me.Invoke(Sub() lblThemp.ForeColor = Color.Pink)

                    If mest >= 30 Then Me.Invoke(Sub() lblThemp.ForeColor = Color.Red)

                    If mest >= 35 Then Me.Invoke(Sub() lblThemp.ForeColor = Color.RosyBrown)

                    If mest >= 40 Then Me.Invoke(Sub() lblThemp.ForeColor = Color.White)


                    Me.Invoke(Sub() lblThemp.Text = "" & mest & " C")

                Next

                Threading.Thread.Sleep(500)

            Loop

        Catch ex As Exception

            '' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try



    End Sub

End Class