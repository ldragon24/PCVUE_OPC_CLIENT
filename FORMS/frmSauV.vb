Public Class frmSauV
    Dim T_SAUV As System.Threading.Thread

    Private Sub btn_SAUV_Click(sender As System.Object, e As System.EventArgs) Handles btn_SAUV.Click

        Select Case btn_SAUV.Text

            Case "Старт"

                btn_SAUV.Text = "Стоп"
                T_SAUV = New System.Threading.Thread(AddressOf T_SAUv_START)
                T_SAUV.Start()

            Case "Стоп"

                btn_SAUV.Text = "Старт"
                m_server.CancelSubscription(groupSAUV)
                T_SAUV.Abort()

        End Select

    End Sub

    Sub T_SAUv_START()

        Try
ARG:

            groupStateSAUV.Name = "САУ_В"
            groupStateSAUV.Active = True
            groupStateSAUV.UpdateRate = MSPEED

            groupSAUV = DirectCast(m_server.CreateSubscription(groupStateSAUV), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(26) {}
            'Кател № 1
            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "САУ_В.АртСкв.Насос1.ON"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "САУ_В.АртСкв.Насос2.ON"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "САУ_В.ANPU25.Затвор.Close_OPC"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "САУ_В.РЧВ.Затвор.Open"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "САУ_В.РЧВ.УРОВ.CL_WAT_LVL_17"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "САУ_В.РЧВ.УРОВ.CL_WAT_LVL_08"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "САУ_В.Бакт5.Устан_2.ON"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "САУ_В.ANPU25.Рез1.LVL220_OPC"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "САУ_В.ANPU25.Рез1.LVL364_OPC"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "САУ_В.ANPU25.Рез2.LVL220_OPC"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "САУ_В.ANPU25.Рез2.LVL364_OPC"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "САУ_В.Cor3._.ON"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "САУ_В.ANPU25.Затвор.Auto_OPC"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "САУ_В._.Par.Level1"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "САУ_В._.Par.Level2"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "САУ_В._.Par.Pressure"

            'Расх. Хоз.-пит. воды
            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "САУ_В._.Par.Flow"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "САУ_В.АртСкв.Насос1.AUTO"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "САУ_В.АртСкв.Насос2.AUTO"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "САУ_В.РЧВ.УРОВ.CL_WAT_LVL_05"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "САУ_В.Бакт5.Устан_1.ON"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "САУ_В.Бакт5.Устан_2.ON"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "САУ_В.Бакт5.Устан_3.ON"


            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "САУ_В._._.PUMP_ST2_FAULT"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "САУ_В.АртСкв.1.W_BORE_FAIL"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "САУ_В.АртСкв.2.W_BORE_FAIL"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "САУ_В.ПОМЕЩ.Т.TM8"

            items = groupSAUV.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = groupSAUV.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    ' Me.Invoke(Sub() Label50.Text = results(0).Timestamp)

                    Select Case results(1).Value

                        Case False
                            Me.Invoke(Sub() Label115.Text = "Выкл")
                            Me.Invoke(Sub() Label115.ForeColor = Color.Red)
                        Case True
                            Me.Invoke(Sub() Label115.Text = "Вкл")
                            Me.Invoke(Sub() Label115.ForeColor = Color.Green)
                    End Select

                    '  Me.Invoke(Sub() Label49.Text = results(1).Timestamp)

                    Select Case results(0).Value

                        Case False
                            Me.Invoke(Sub() Label2.Text = "Выкл")
                            Me.Invoke(Sub() Label2.ForeColor = Color.Red)
                        Case True
                            Me.Invoke(Sub() Label2.Text = "Вкл")
                            Me.Invoke(Sub() Label2.ForeColor = Color.Green)
                    End Select

                    'АНПУ 25 Затвор

                    '  Me.Invoke(Sub() Label48.Text = results(2).Timestamp)


                    Select Case results(2).Quality.ToString


                        Case "good"

                            Select Case results(2).Value
                                Case False
                                    Me.Invoke(Sub() anpuO.Visible = True)
                                    Me.Invoke(Sub() anpuC.Visible = False)

                                Case True
                                    Me.Invoke(Sub() anpuO.Visible = False)
                                    Me.Invoke(Sub() anpuC.Visible = True)
                            End Select


                        Case Else

                            If anpuO.Visible = True Then

                                anpuO.BackColor = Color.Pink

                            Else

                                anpuC.BackColor = Color.Pink

                            End If

                    End Select

                    'РЧВ Затвор

                    Select Case results(3).Quality.ToString
                        Case "good"
                            Select Case results(3).Value
                                Case True
                                    Me.Invoke(Sub() rhvO.Visible = True)
                                    Me.Invoke(Sub() rhvC.Visible = False)
                                Case False
                                    Me.Invoke(Sub() rhvO.Visible = False)
                                    Me.Invoke(Sub() rhvC.Visible = True)
                            End Select
                        Case Else
                            If rhvO.Visible = True Then

                                rhvO.BackColor = Color.Pink
                            Else
                                rhvC.BackColor = Color.Pink
                            End If
                    End Select


                    Select Case results(4).Value

                        Case False
                            Me.Invoke(Sub() l17.ForeColor = Color.Red)
                            Me.Invoke(Sub() l17.Enabled = False)
                        Case True
                            Me.Invoke(Sub() l17.ForeColor = Color.Green)
                            Me.Invoke(Sub() l17.Enabled = True)
                            '     Me.Invoke(Sub() Label53.Text = results(4).Timestamp)
                    End Select

                    Select Case results(5).Value

                        Case False
                            Me.Invoke(Sub() l08.ForeColor = Color.Red)
                            Me.Invoke(Sub() l08.Enabled = False)
                        Case True
                            Me.Invoke(Sub() l08.ForeColor = Color.Green)
                            Me.Invoke(Sub() l08.Enabled = True)
                            '    Me.Invoke(Sub() Label53.Text = results(5).Timestamp)
                    End Select

                    Select Case results(19).Value

                        Case False
                            Me.Invoke(Sub() l05.ForeColor = Color.Red)
                            Me.Invoke(Sub() l05.Enabled = False)

                        Case True
                            Me.Invoke(Sub() l05.ForeColor = Color.Green)
                            Me.Invoke(Sub() l05.Enabled = True)
                            '    Me.Invoke(Sub() Label53.Text = results(5).Timestamp)
                    End Select


                    'БАКТ 5

                    '  Me.Invoke(Sub() Label46.Text = results(6).Timestamp)

                    Select Case results(6).Value

                        Case False
                            Me.Invoke(Sub() Label18.Text = "Не в работе")
                            Me.Invoke(Sub() Label18.ForeColor = Color.Red)
                        Case True
                            Me.Invoke(Sub() Label18.Text = "В работе")
                            Me.Invoke(Sub() Label18.ForeColor = Color.Green)
                    End Select


                    'АНПУ 25 Резервуары Уровень

                    Select Case results(7).Value

                        Case False
                            Me.Invoke(Sub() r1_220.ForeColor = Color.Red)

                        Case True
                            Me.Invoke(Sub() r1_220.ForeColor = Color.Green)
                            Me.Invoke(Sub() Label51.Text = results(7).Timestamp)
                    End Select

                    If results(7).Quality.ToString = "good" Then r1_220.BackColor = Color.Transparent Else r1_220.BackColor = Color.Pink

                    Select Case results(8).Value

                        Case False
                            Me.Invoke(Sub() r1_364.ForeColor = Color.Red)

                        Case True
                            Me.Invoke(Sub() r1_364.ForeColor = Color.Green)
                            Me.Invoke(Sub() Label51.Text = results(8).Timestamp)
                    End Select

                    If results(8).Quality.ToString = "good" Then r1_364.BackColor = Color.Transparent Else r1_364.BackColor = Color.Pink


                    Select Case results(9).Value

                        Case False
                            Me.Invoke(Sub() r2_220.ForeColor = Color.Red)

                        Case True
                            Me.Invoke(Sub() r2_220.ForeColor = Color.Green)
                            Me.Invoke(Sub() Label52.Text = results(9).Timestamp)
                    End Select

                    If results(9).Quality.ToString = "good" Then r2_220.BackColor = Color.Transparent Else r2_220.BackColor = Color.Pink


                    Select Case results(10).Value

                        Case False
                            Me.Invoke(Sub() r2_364.ForeColor = Color.Red)

                        Case True
                            Me.Invoke(Sub() r2_364.ForeColor = Color.Green)
                            Me.Invoke(Sub() Label52.Text = results(10).Timestamp)
                    End Select

                    'Насосы

                    ' Me.Invoke(Sub() Label45.Text = results(11).Timestamp)

                    Select Case results(11).Value

                        Case False
                            Me.Invoke(Sub() Label20.Text = "Не в работе")
                            Me.Invoke(Sub() Label20.ForeColor = Color.Red)
                        Case True
                            Me.Invoke(Sub() Label20.Text = "В работе")
                            Me.Invoke(Sub() Label20.ForeColor = Color.Green)
                    End Select

                    '  Me.Invoke(Sub() Label263.Text = results(12).Timestamp)

                    Select Case results(12).Quality.ToString

                        Case "good"

                            Select Case results(12).Value

                                Case False
                                    '  Me.Invoke(Sub() Label3.Text = "Ручное")
                                    Me.Invoke(Sub() Label3.ForeColor = Color.Red)
                                    Me.Invoke(Sub() Label3.Enabled = True)
                                    Me.Invoke(Sub() Label262.Enabled = False)
                                Case True
                                    '  Me.Invoke(Sub() Label262.Text = "Автоматическое")
                                    Me.Invoke(Sub() Label262.ForeColor = Color.Green)
                                    Me.Invoke(Sub() Label3.Enabled = False)
                                    Me.Invoke(Sub() Label262.Enabled = True)
                            End Select

                        Case Else
                            Me.Invoke(Sub() Label3.BackColor = Color.Pink)
                            Me.Invoke(Sub() Label262.BackColor = Color.Pink)

                    End Select
                    

                    Select Case results(17).Value

                        Case False
                            Me.Invoke(Sub() ln1.Text = "Р")
                            Me.Invoke(Sub() ln1.ForeColor = Color.Red)
                        Case True
                            Me.Invoke(Sub() ln1.Text = "А")
                            Me.Invoke(Sub() ln1.ForeColor = Color.Green)
                    End Select

                    Select Case results(18).Value

                        Case False
                            Me.Invoke(Sub() ln2.Text = "Р")
                            Me.Invoke(Sub() ln2.ForeColor = Color.Red)
                        Case True
                            Me.Invoke(Sub() ln2.Text = "А")
                            Me.Invoke(Sub() ln2.ForeColor = Color.Green)
                    End Select

                    Select Case results(20).Value

                        Case False
                            Me.Invoke(Sub() Label1.Text = "Выкл")
                            Me.Invoke(Sub() Label1.ForeColor = Color.Red)
                        Case True
                            Me.Invoke(Sub() Label1.Text = "Вкл")
                            Me.Invoke(Sub() Label1.ForeColor = Color.Green)
                    End Select

                    Select Case results(21).Value

                        Case False
                            Me.Invoke(Sub() Label4.Text = "Выкл")
                            Me.Invoke(Sub() Label4.ForeColor = Color.Red)
                        Case True
                            Me.Invoke(Sub() Label4.Text = "Вкл")
                            Me.Invoke(Sub() Label4.ForeColor = Color.Green)
                    End Select

                    Select Case results(22).Value

                        Case False
                            Me.Invoke(Sub() Label5.Text = "Выкл")
                            Me.Invoke(Sub() Label5.ForeColor = Color.Red)
                        Case True
                            Me.Invoke(Sub() Label5.Text = "Вкл")
                            Me.Invoke(Sub() Label5.ForeColor = Color.Green)
                    End Select

                    Dim MG1 As Double = results(13).Value
                    Dim MG2 As Double = results(14).Value
                    Dim MG3 As Double = results(15).Value
                    Dim MG4 As Double = results(16).Value

                    Me.Invoke(Sub() Label67.Text = Math.Round(MG1, 2) & " м")
                    '  Me.Invoke(Sub() Label66.Text = results(13).Timestamp)

                    Me.Invoke(Sub() Label70.Text = Math.Round(MG2, 2) & " м")
                    '   Me.Invoke(Sub() Label69.Text = results(14).Timestamp)

                    Me.Invoke(Sub() Label71.Text = Math.Round(MG3, 2) & " Мпа")
                    '  Me.Invoke(Sub() Label68.Text = results(15).Timestamp)

                    Me.Invoke(Sub() Label119.Text = Math.Round(MG4, 2) & " л\с")
                    '   Me.Invoke(Sub() Label120.Text = results(16).Timestamp)


                    '  SALARM = False
                    Select Case results(23).Value
                        Case False
                            Me.Invoke(Sub() Label16.Enabled = False)
                        Case True
                            Me.Invoke(Sub() Label16.Enabled = True)

                    End Select

                    Select Case results(24).Value
                        Case False
                            Me.Invoke(Sub() Label15.Enabled = False)
                        Case True
                            Me.Invoke(Sub() Label15.Enabled = True)

                    End Select

                    Select Case results(25).Value
                        Case False
                            Me.Invoke(Sub() Label6.Enabled = False)
                        Case True
                            Me.Invoke(Sub() Label6.Enabled = True)

                    End Select

                    Select Case results(26).Value
                        Case False
                            Me.Invoke(Sub() Label7.Enabled = False)
                        Case True
                            Me.Invoke(Sub() Label7.Enabled = True)

                    End Select

                Next

                Threading.Thread.Sleep(MSPEED + 300)
            Loop

        Catch ex As Exception
            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Private Sub frmSauV_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        T_SAUV.Abort()
        m_server.CancelSubscription(groupSAUV)
        ' SALARM = False
    End Sub

    Private Sub LOAD_()
        Select Case btn_SAUV.Text

            Case "Старт"

                btn_SAUV.Text = "Стоп"
                T_SAUV = New System.Threading.Thread(AddressOf T_SAUv_START)
                T_SAUV.Start()

            Case "Стоп"

                btn_SAUV.Text = "Старт"
                m_server.CancelSubscription(groupSAUV)
                T_SAUV.Abort()

        End Select
    End Sub

    Private Sub frmSauV_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Call LOAD_()

    End Sub

End Class