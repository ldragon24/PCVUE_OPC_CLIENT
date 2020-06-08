Public Class frmSAUT

    Const snd_sync = &H0
    Const snd_async = &H1
    Const snd_nodefault = &H2
    Const snd_memory = &H4
    Const snd_loop = &H8
    Const snd_nostop = &H10

    Dim T_SAUT As System.Threading.Thread
    Dim T_SAUT_A As System.Threading.Thread

    Private Sub btn_SAUT_Click(sender As System.Object, e As System.EventArgs) Handles btn_SAUT.Click

        Select Case btn_SAUT.Text

            Case "Старт"

                btn_SAUT.Text = "Стоп"
                T_SAUT = New System.Threading.Thread(AddressOf T_SAUT_START)
                T_SAUT.Start()

                T_SAUT_A = New System.Threading.Thread(AddressOf T_SAUT_A_ALARM_SOUND)
                T_SAUT_A.Start()


            Case "Стоп"

                btn_SAUT.Text = "Старт"
                m_server.CancelSubscription(groupSAUT)
                m_server.CancelSubscription(groupSAUT_A)
                T_SAUT.Abort()
                T_SAUT_A.Abort()

        End Select

    End Sub

    Sub T_SAUT_A_ALARM_SOUND()

        Dim intj As Integer = 0
        SALARM = False

        Try
ARG:
            'groupSAUT_A
            groupStateSAUT_A.Name = "САУ_Т_ALARM"
            groupStateSAUT_A.Active = True
            groupStateSAUT_A.UpdateRate = MSPEED

            groupSAUT_A = DirectCast(m_server.CreateSubscription(groupStateSAUT_A), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Global.Opc.Da.Item(39) {}

            'СИГНАЛИЗАЦИЯ
            'САУ_Т._.kat4.FIRE_RUN
            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "САУ_Т._.kat4.FIRE_RUN"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "САУ_Т._.kat1.Boil_Fail"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "САУ_Т._.kat2.Boil_Fail"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "САУ_Т._.kat3.Boil_Fail"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "САУ_Т._.kat1.BURN_Fail"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "САУ_Т._.kat2.BURN_Fail"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "САУ_Т._.kat3.BURN_Fail"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "САУ_Т._.kat4.Pump1_GVS_A"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "САУ_Т._.kat4.Pump1_heat_A"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "САУ_Т._.kat4.Pump2_GVS_A"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "САУ_Т._.kat4.Pump2_heat_A"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "САУ_Т._.kat4.TW_Rew_cal1"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "САУ_Т._.kat4.TW_Rew_cal2"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "САУ_Т._.kat4.TW_For_GVS"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "САУ_Т._.kat4.P_GAS_HIGH_A"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "САУ_Т._.kat4.P_GAS_LOW_A"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "САУ_Т._.kat4.NKPR_CH_A"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "САУ_Т._.kat4.NKPR_CH_Bad"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "САУ_Т._.kat4.PDK_CO_A"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "САУ_Т._.kat4.PDK_CO_Bad"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "САУ_Т._.kat4.PW_For_GVS"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "САУ_Т._.kat4.PW_Rew_GVS_Apump"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "САУ_Т._.kat4.PW_Rew_GVS_Bfilt"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "САУ_Т._.kat4.PW_Rew_GVS_Bpump"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "САУ_Т._.kat4.TW_REW_GVS"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "САУ_Т._.kat4.P_Rew_Col_Bad"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "САУ_Т._.kat4.P_For_heat_Bad"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "САУ_Т._.kat4.P_Rew_Heat_bad"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "САУ_Т._.kat4.P_Rew_Heat_pump_bad"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "САУ_Т._.kat4.TA_In_bad"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "САУ_Т._.kat4.PW_First_Bad"

            items(31) = New Global.Opc.Da.Item()
            items(31).ItemName = "САУ_Т._.kat4.Volt1_Abs"

            items(32) = New Global.Opc.Da.Item()
            items(32).ItemName = "САУ_Т._.kat4.Volt2_Abs"

            items(33) = New Global.Opc.Da.Item()
            items(33).ItemName = "САУ_Т._.kat4.AVR_Work"

            items(34) = New Global.Opc.Da.Item()
            items(34).ItemName = "САУ_Т._.kat4.P_For_Col_A"

            items(35) = New Global.Opc.Da.Item()
            items(35).ItemName = "САУ_Т._.kat4.P_Rew_Col_A"

            items(36) = New Global.Opc.Da.Item()
            items(36).ItemName = "САУ_Т._.kat4.P_For_heat_A"

            items(37) = New Global.Opc.Da.Item()
            items(37).ItemName = "САУ_Т._.kat4.P_Rew_Heat_A"

            ' Д. обр. воды отоп. после насос. не в нор
            items(38) = New Global.Opc.Da.Item()
            items(38).ItemName = "САУ_Т._.kat4.P_Rew_Heat_pump_A"

            items(39) = New Global.Opc.Da.Item()
            items(39).ItemName = "САУ_Т._.kat4.TW_PID"

            items = groupSAUT_A.AddItems(items)
            Do

                Dim results As ItemValueResult() = Nothing
                results = groupSAUT_A.Read(items)

                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                intj = 0

                For i As Integer = 0 To results.Length - 1

                    Select Case results(i).Value

                        Case True

                            intj = intj + 1

                        Case Else


                    End Select


                Next


                If intj = 0 Then
                    Me.Invoke(Sub() SALARM = False)
                Else
                    Me.Invoke(Sub() SALARM = True)
                End If


                Threading.Thread.Sleep(MSPEED + 400)

            Loop

        Catch ex As Exception

            '' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try


    End Sub

    Sub T_SAUT_START()

        Try
ARG:
            'groupSAUT
            groupStateSAUT.Name = "САУ_Т"
            groupStateSAUT.Active = True
            groupStateSAUT.UpdateRate = MSPEED

            groupSAUT = DirectCast(m_server.CreateSubscription(groupStateSAUT), Opc.Da.Subscription)


            Dim items As Global.Opc.Da.Item() = New Global.Opc.Da.Item(83) {}
            'Кател № 1
            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "САУ_Т._.kat1.Burn_ON"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "САУ_Т._.kat1.Pump_ON"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "САУ_Т._.kat1.P_Burn"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "САУ_Т._.kat1.TW_IN"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "САУ_Т._.kat1.TW_OUT"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "САУ_Т._.kat1.TG_OUT"

            'Кател № 2
            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "САУ_Т._.kat2.Burn_ON"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "САУ_Т._.kat2.Pump_ON"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "САУ_Т._.kat2.P_Burn"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "САУ_Т._.kat2.TW_IN"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "САУ_Т._.kat2.TW_OUT"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "САУ_Т._.kat2.TG_OUT"

            'Кател № 3
            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "САУ_Т._.kat3.Burn_ON"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "САУ_Т._.kat3.Pump_ON"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "САУ_Т._.kat3.P_Burn"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "САУ_Т._.kat3.TW_IN"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "САУ_Т._.kat3.TW_OUT"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "САУ_Т._.kat3.TG_OUT"

            'Калорифер
            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "САУ_Т._.kat4.Cal1_ON"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "САУ_Т._.kat4.Cal2_ON"

            'Насосы ГВС
            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "САУ_Т._.kat4.Pump1_GVS_ON"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "САУ_Т._.kat4.Pump2_GVS_ON"

            'Насос отопления 
            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "САУ_Т._.kat4.Pump1_Heat_ON"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "САУ_Т._.kat4.Pump2_Heat_ON"

            'Температура воздуха
            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "САУ_Т._.kat4.TA_In"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "САУ_Т._.kat4.TA_Out"


            'Вода отопления, температура
            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "САУ_Т._.kat4.TT_For"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "САУ_Т._.kat4.TT_Rew"
            'САУ_Т._.kat4.TW_Rew


            'Давление
            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "САУ_Т._.kat4.PT_For"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "САУ_Т._.kat4.PT_Rew_Afilt"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "САУ_Т._.kat4.PT_Rew_Apump"

            items(31) = New Global.Opc.Da.Item()
            items(31).ItemName = "САУ_Т._.kat4.PT_Rew_Bfilt"

            items(32) = New Global.Opc.Da.Item()
            items(32).ItemName = "САУ_Т._.kat4.PT_Rew_Bpump"

            'СИГНАЛИЗАЦИЯ
            'САУ_Т._.kat4.FIRE_RUN
            items(33) = New Global.Opc.Da.Item()
            items(33).ItemName = "САУ_Т._.kat4.FIRE_RUN"

            items(34) = New Global.Opc.Da.Item()
            items(34).ItemName = "САУ_Т._.kat1.Boil_Fail"

            items(35) = New Global.Opc.Da.Item()
            items(35).ItemName = "САУ_Т._.kat2.Boil_Fail"

            items(36) = New Global.Opc.Da.Item()
            items(36).ItemName = "САУ_Т._.kat3.Boil_Fail"


            items(37) = New Global.Opc.Da.Item()
            items(37).ItemName = "САУ_Т._.kat1.BURN_Fail"

            items(38) = New Global.Opc.Da.Item()
            items(38).ItemName = "САУ_Т._.kat2.BURN_Fail"

            items(39) = New Global.Opc.Da.Item()
            items(39).ItemName = "САУ_Т._.kat3.BURN_Fail"


            items(40) = New Global.Opc.Da.Item()
            items(40).ItemName = "САУ_Т._.kat4.Pump1_GVS_A"

            items(41) = New Global.Opc.Da.Item()
            items(41).ItemName = "САУ_Т._.kat4.Pump1_heat_A"

            items(42) = New Global.Opc.Da.Item()
            items(42).ItemName = "САУ_Т._.kat4.Pump2_GVS_A"

            items(43) = New Global.Opc.Da.Item()
            items(43).ItemName = "САУ_Т._.kat4.Pump2_heat_A"

            items(44) = New Global.Opc.Da.Item()
            items(44).ItemName = "САУ_Т._.kat4.TW_Rew_cal1"

            items(45) = New Global.Opc.Da.Item()
            items(45).ItemName = "САУ_Т._.kat4.TW_Rew_cal2"

            items(46) = New Global.Opc.Da.Item()
            items(46).ItemName = "САУ_Т._.kat4.TW_For_GVS"

            items(47) = New Global.Opc.Da.Item()
            items(47).ItemName = "САУ_Т._.kat4.P_GAS_HIGH_A"

            items(48) = New Global.Opc.Da.Item()
            items(48).ItemName = "САУ_Т._.kat4.P_GAS_LOW_A"

            items(49) = New Global.Opc.Da.Item()
            items(49).ItemName = "САУ_Т._.kat4.NKPR_CH_A"

            items(50) = New Global.Opc.Da.Item()
            items(50).ItemName = "САУ_Т._.kat4.NKPR_CH_Bad"

            items(51) = New Global.Opc.Da.Item()
            items(51).ItemName = "САУ_Т._.kat4.PDK_CO_A"

            items(52) = New Global.Opc.Da.Item()
            items(52).ItemName = "САУ_Т._.kat4.PDK_CO_Bad"

            items(53) = New Global.Opc.Da.Item()
            items(53).ItemName = "САУ_Т._.kat4.PW_For_GVS"

            items(54) = New Global.Opc.Da.Item()
            items(54).ItemName = "САУ_Т._.kat4.PW_Rew_GVS_Apump"

            items(55) = New Global.Opc.Da.Item()
            items(55).ItemName = "САУ_Т._.kat4.PW_Rew_GVS_Bfilt"

            items(56) = New Global.Opc.Da.Item()
            items(56).ItemName = "САУ_Т._.kat4.PW_Rew_GVS_Bpump"

            items(57) = New Global.Opc.Da.Item()
            items(57).ItemName = "САУ_Т._.kat4.TW_REW_GVS"

            items(58) = New Global.Opc.Da.Item()
            items(58).ItemName = "САУ_Т._.kat4.Vent_Boil_Open"

            items(59) = New Global.Opc.Da.Item()
            items(59).ItemName = "САУ_Т._.kat4.Vent_Gas_Open"

            items(60) = New Global.Opc.Da.Item()
            items(60).ItemName = "САУ_Т._.kat4.Vent_GT_Open"

            items(61) = New Global.Opc.Da.Item()
            items(61).ItemName = "САУ_Т._.kat4.Vent_Heat_Open"

            items(62) = New Global.Opc.Da.Item()
            items(62).ItemName = "САУ_Т._.kat4.TW_For"

            items(63) = New Global.Opc.Da.Item()
            items(63).ItemName = "САУ_Т._.kat4.TW_Rew"

            items(64) = New Global.Opc.Da.Item()
            items(64).ItemName = "САУ_Т._.kat4.PW_For"

            items(65) = New Global.Opc.Da.Item()
            items(65).ItemName = "САУ_Т._.kat4.PW_Rew"
            'САУ_Т._.kat4.Vent_Heat_Open

            items(66) = New Global.Opc.Da.Item()
            items(66).ItemName = "САУ_Т._.kat4.T_For_Col_Bad"

            items(67) = New Global.Opc.Da.Item()
            items(67).ItemName = "САУ_Т._.kat4.T_Rew_Col_Bad"

            items(68) = New Global.Opc.Da.Item()
            items(68).ItemName = "САУ_Т._.kat4.P_For_Col_Bad"

            items(69) = New Global.Opc.Da.Item()
            items(69).ItemName = "САУ_Т._.kat4.P_Rew_Col_Bad"

            items(70) = New Global.Opc.Da.Item()
            items(70).ItemName = "САУ_Т._.kat4.P_For_heat_Bad"

            items(71) = New Global.Opc.Da.Item()
            items(71).ItemName = "САУ_Т._.kat4.P_Rew_Heat_bad"

            items(72) = New Global.Opc.Da.Item()
            items(72).ItemName = "САУ_Т._.kat4.P_Rew_Heat_pump_bad"

            items(73) = New Global.Opc.Da.Item()
            items(73).ItemName = "САУ_Т._.kat4.TA_In_bad"

            items(74) = New Global.Opc.Da.Item()
            items(74).ItemName = "САУ_Т._.kat4.PW_First_Bad"

            items(75) = New Global.Opc.Da.Item()
            items(75).ItemName = "САУ_Т._.kat4.Volt1_Abs"

            items(76) = New Global.Opc.Da.Item()
            items(76).ItemName = "САУ_Т._.kat4.Volt2_Abs"

            items(77) = New Global.Opc.Da.Item()
            items(77).ItemName = "САУ_Т._.kat4.AVR_Work"

            items(78) = New Global.Opc.Da.Item()
            items(78).ItemName = "САУ_Т._.kat4.P_For_Col_A"

            items(79) = New Global.Opc.Da.Item()
            items(79).ItemName = "САУ_Т._.kat4.P_Rew_Col_A"

            items(80) = New Global.Opc.Da.Item()
            items(80).ItemName = "САУ_Т._.kat4.P_For_heat_A"

            items(81) = New Global.Opc.Da.Item()
            items(81).ItemName = "САУ_Т._.kat4.P_Rew_Heat_A"

            ' Д. обр. воды отоп. после насос. не в нор
            items(82) = New Global.Opc.Da.Item()
            items(82).ItemName = "САУ_Т._.kat4.P_Rew_Heat_pump_A"

            items(83) = New Global.Opc.Da.Item()
            items(83).ItemName = "САУ_Т._.kat4.TW_PID"
            'САУ_Т._.kat4.TW_PID

            items = groupSAUT.AddItems(items)
            Do

                Dim results As ItemValueResult() = Nothing
                results = groupSAUT.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1


                    'Select Case results(0).Quality.ToString

                    '    Case "good"

                    '        Label5.Enabled = True

                    '    Case Else

                    '        Label5.Enabled = False

                    'End Select

                    '################################################################################################################
                    'Кател № 1
                    '  Me.Invoke(Sub() Label54.Text = results(0).Timestamp)

                    Select Case results(0).Value

                        Case False
                            Me.Invoke(Sub() Me.Label36.Text = "ОТКЛ")
                            Me.Invoke(Sub() Me.Label36.ForeColor = Color.Red)
                            ' Me.Invoke(Sub() Me.PictureBox1.BackColor = Color.Blue)
                        Case True
                            Me.Invoke(Sub() Me.Label36.Text = "ВКЛ")
                            Me.Invoke(Sub() Me.Label36.ForeColor = Color.Green)
                            '   Me.Invoke(Sub() Me.PictureBox1.BackColor = Color.Green)
                    End Select

                    ' Me.Invoke(Sub() Label55.Text = results(1).Timestamp)

                    Select Case results(1).Value

                        Case False
                            Me.Invoke(Sub() Me.Label22.Text = "ОТКЛ")
                            Me.Invoke(Sub() Me.Label22.ForeColor = Color.Red)

                        Case True
                            Me.Invoke(Sub() Me.Label22.Text = "ВКЛ")
                            Me.Invoke(Sub() Me.Label22.ForeColor = Color.Green)

                    End Select

                    Dim MG1 As Double = results(2).Value

                    Me.Invoke(Sub() Label73.Text = Math.Round(MG1, 2) & " %P")
                    ' Me.Invoke(Sub() Label74.Text = results(2).Timestamp)

                    Dim MGI As Double = results(3).Value
                    Dim MGo As Double = results(4).Value
                    Dim MGg As Double = results(5).Value

                    Me.Invoke(Sub() Label83.Text = Math.Round(MGI, 2) & " C")
                    Me.Invoke(Sub() Label84.Text = Math.Round(MGo, 2) & " C")
                    Me.Invoke(Sub() Label94.Text = Math.Round(MGg, 2) & " C")


                    '################################################################################################################
                    'Кател № 2
                    '  Me.Invoke(Sub() Label56.Text = results(6).Timestamp)

                    Select Case results(6).Value

                        Case False
                            Me.Invoke(Sub() Me.Label25.Text = "ОТКЛ")
                            Me.Invoke(Sub() Me.Label25.ForeColor = Color.Red)
                            '   Me.Invoke(Sub() Me.PictureBox2.BackColor = Color.Blue)
                        Case True
                            Me.Invoke(Sub() Me.Label25.Text = "ВКЛ")
                            Me.Invoke(Sub() Me.Label25.ForeColor = Color.Green)
                            '   Me.Invoke(Sub() Me.PictureBox2.BackColor = Color.Green)
                    End Select

                    ' Me.Invoke(Sub() Label57.Text = results(7).Timestamp)

                    Select Case results(7).Value

                        Case False
                            Me.Invoke(Sub() Me.Label26.Text = "ОТКЛ")
                            Me.Invoke(Sub() Me.Label26.ForeColor = Color.Red)
                        Case True
                            Me.Invoke(Sub() Me.Label26.Text = "ВКЛ")
                            Me.Invoke(Sub() Me.Label26.ForeColor = Color.Green)
                    End Select

                    Dim MG2 As Double = results(8).Value

                    Me.Invoke(Sub() Label76.Text = Math.Round(MG2, 2) & " %P")
                    ' Me.Invoke(Sub() Label77.Text = results(8).Timestamp)

                    Dim MGI2 As Double = results(9).Value
                    Dim MGo2 As Double = results(10).Value
                    Dim MGg2 As Double = results(11).Value

                    Me.Invoke(Sub() Label87.Text = Math.Round(MGI2, 2) & " C")
                    Me.Invoke(Sub() Label88.Text = Math.Round(MGo2, 2) & " C")
                    Me.Invoke(Sub() Label95.Text = Math.Round(MGg2, 2) & " C")

                    '################################################################################################################
                    'Кател № 3
                    'Me.Invoke(Sub() Label58.Text = results(12).Timestamp)

                    Select Case results(12).Value

                        Case False
                            Me.Invoke(Sub() Me.Label29.Text = "ОТКЛ")
                            Me.Invoke(Sub() Me.Label29.ForeColor = Color.Red)
                            ' Me.Invoke(Sub() Me.PictureBox3.BackColor = Color.Blue)
                        Case True
                            Me.Invoke(Sub() Me.Label29.Text = "ВКЛ")
                            Me.Invoke(Sub() Me.Label29.ForeColor = Color.Green)
                            ' Me.Invoke(Sub() Me.PictureBox3.BackColor = Color.Green)
                    End Select

                    ' Me.Invoke(Sub() Label59.Text = results(13).Timestamp)

                    Select Case results(13).Value

                        Case False
                            Me.Invoke(Sub() Me.Label30.Text = "ОТКЛ")
                            Me.Invoke(Sub() Me.Label30.ForeColor = Color.Red)
                        Case True
                            Me.Invoke(Sub() Me.Label30.Text = "ВКЛ")
                            Me.Invoke(Sub() Me.Label30.ForeColor = Color.Green)
                    End Select

                    Dim MG3 As Double = results(14).Value
                    Me.Invoke(Sub() Label79.Text = Math.Round(MG3, 2) & " %P")
                    ' Me.Invoke(Sub() Label80.Text = results(14).Timestamp)

                    Dim MGI3 As Double = results(15).Value
                    Dim MGo3 As Double = results(16).Value
                    Dim MGg3 As Double = results(17).Value

                    Me.Invoke(Sub() Label91.Text = Math.Round(MGI3, 2) & " C")
                    Me.Invoke(Sub() Label92.Text = Math.Round(MGo3, 2) & " C")
                    Me.Invoke(Sub() Label97.Text = Math.Round(MGg3, 2) & " C")


                    '################################################################################################################
                    'Калориферы

                    '  Me.Invoke(Sub() Label60.Text = results(18).Timestamp)

                    Select Case results(18).Value

                        Case False
                            Me.Invoke(Sub() Label32.Text = "ОТКЛ")
                            Me.Invoke(Sub() Label32.ForeColor = Color.Red)
                        Case True
                            Me.Invoke(Sub() Label32.Text = "ВКЛ")
                            Me.Invoke(Sub() Label32.ForeColor = Color.Green)
                    End Select

                    ' Me.Invoke(Sub() Label61.Text = results(19).Timestamp)

                    Select Case results(18).Value

                        Case False
                            Me.Invoke(Sub() Label34.Text = "ОТКЛ")
                            Me.Invoke(Sub() Label34.ForeColor = Color.Red)

                        Case True
                            Me.Invoke(Sub() Label34.Text = "ВКЛ")
                            Me.Invoke(Sub() Label34.ForeColor = Color.Green)
                    End Select

                    '################################################################################################################
                    'Насосы ГВС
                    'Насос 1 ГВС

                    Select Case results(20).Value

                        Case False
                            Me.Invoke(Sub() Label37.Text = "ОТКЛ")
                            Me.Invoke(Sub() Label37.ForeColor = Color.Red)
                        Case True
                            Me.Invoke(Sub() Label37.Text = "ВКЛ")
                            Me.Invoke(Sub() Label37.ForeColor = Color.Green)
                    End Select


                    'Насос 2 ГВС
                    Select Case results(21).Value

                        Case False
                            Me.Invoke(Sub() Label40.Text = "ОТКЛ")
                            Me.Invoke(Sub() Label40.ForeColor = Color.Red)
                        Case True
                            Me.Invoke(Sub() Label40.Text = "ВКЛ")
                            Me.Invoke(Sub() Label40.ForeColor = Color.Green)
                    End Select


                    '################################################################################################################
                    'Насосы отопления

                    '  Me.Invoke(Sub() Label64.Text = results(21).Timestamp)

                    Select Case results(22).Value

                        Case False
                            Me.Invoke(Sub() Label42.Text = "ОТКЛ")
                            Me.Invoke(Sub() Label42.ForeColor = Color.Red)
                        Case True
                            Me.Invoke(Sub() Label42.Text = "ВКЛ")
                            Me.Invoke(Sub() Label42.ForeColor = Color.Green)
                    End Select

                    '   Me.Invoke(Sub() Label65.Text = results(22).Timestamp)

                    Select Case results(23).Value

                        Case False
                            Me.Invoke(Sub() Label44.Text = "ОТКЛ")
                            Me.Invoke(Sub() Label44.ForeColor = Color.Red)
                        Case True
                            Me.Invoke(Sub() Label44.Text = "ВКЛ")
                            Me.Invoke(Sub() Label44.ForeColor = Color.Green)
                    End Select

                    '################################################################################################################
                    'Температура воздуха

                    Dim MGt2 As Double = results(24).Value
                    Dim MGti2 As Double = results(25).Value


                    Me.Invoke(Sub() Label110.Text = Math.Round(MGt2, 1) & " C")
                    ' Me.Invoke(Sub() Label111.Text = results(24).Timestamp)

                    Me.Invoke(Sub() Label113.Text = Math.Round(MGti2, 1) & " C")
                    '  Me.Invoke(Sub() Label114.Text = results(25).Timestamp)

                    '################################################################################################################
                    'Вода отопления, температура

                    Dim MGt3 As Double = results(26).Value
                    Dim MGti3 As Double = results(27).Value


                    Me.Invoke(Sub() Label265.Text = Math.Round(MGt3, 2) & " C")
                    Me.Invoke(Sub() Label266.Text = Math.Round(MGti3, 2) & " C")


                    '################################################################################################################
                    'Давление

                    Dim MGd1 As Double = results(28).Value
                    Dim MGd2 As Double = results(29).Value
                    Dim MGd3 As Double = results(30).Value
                    Dim MGd4 As Double = results(31).Value
                    Dim MGd5 As Double = results(32).Value

                    Me.Invoke(Sub() Label105.Text = Math.Round(MGd1, 2) & " Бар")
                    Me.Invoke(Sub() Label106.Text = Math.Round(MGd2, 2) & " Бар")
                    Me.Invoke(Sub() Label107.Text = Math.Round(MGd3, 2) & " Бар")
                    Me.Invoke(Sub() Label108.Text = Math.Round(MGd4, 2) & " Бар")
                    Me.Invoke(Sub() Label109.Text = Math.Round(MGd5, 2) & " Бар")

                    '################################################################################################################
                    'Сигнализация

                    ' SALARM = False

                    Select Case results(33).Value

                        Case False
                            Me.Invoke(Sub() Label4.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label4.Enabled = True)

                    End Select


                    Select Case results(34).Value

                        Case False
                            Me.Invoke(Sub() Label5.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label5.Enabled = True)

                    End Select

                    Select Case results(35).Value

                        Case False
                            Me.Invoke(Sub() Label6.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label6.Enabled = True)

                    End Select

                    Select Case results(36).Value

                        Case False
                            Me.Invoke(Sub() Label7.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label7.Enabled = True)

                    End Select


                    Select Case results(37).Value

                        Case False
                            Me.Invoke(Sub() Label8.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label8.Enabled = True)

                    End Select

                    Select Case results(38).Value

                        Case False
                            Me.Invoke(Sub() Label9.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label9.Enabled = True)

                    End Select

                    Select Case results(39).Value

                        Case False
                            Me.Invoke(Sub() Label10.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label10.Enabled = True)

                    End Select


                    Select Case results(40).Value

                        Case False
                            Me.Invoke(Sub() Label11.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label11.Enabled = True)

                    End Select

                    Select Case results(41).Value

                        Case False
                            Me.Invoke(Sub() Label12.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label12.Enabled = True)

                    End Select

                    Select Case results(42).Value

                        Case False
                            Me.Invoke(Sub() Label13.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label13.Enabled = True)

                    End Select


                    Select Case results(43).Value

                        Case False
                            Me.Invoke(Sub() Label14.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label14.Enabled = True)

                    End Select


                    '################################################

                    Dim Mct1 As Double = results(44).Value
                    Dim Mct2 As Double = results(45).Value
                    Dim Mct3 As Double = results(46).Value

                    Me.Invoke(Sub() Label1.Text = Math.Round(Mct1, 2) & " C")
                    Me.Invoke(Sub() Label2.Text = Math.Round(Mct2, 2) & " C")
                    Me.Invoke(Sub() Label16.Text = Math.Round(Mct3, 2) & " C")


                    '################################################
                    Select Case results(47).Value

                        Case False
                            Me.Invoke(Sub() Label17.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label17.Enabled = True)

                    End Select
                    Select Case results(48).Value
                        Case False
                            Me.Invoke(Sub() Label18.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label18.Enabled = True)

                    End Select

                    Dim Mdt1 As Double = results(53).Value
                    Dim Mdt2 As Double = results(54).Value
                    Dim Mdt3 As Double = results(55).Value
                    Dim Mdt4 As Double = results(56).Value
                    Dim Mdt5 As Double = results(57).Value

                    Me.Invoke(Sub() Label19.Text = Math.Round(Mdt1, 2) & " Бар")
                    Me.Invoke(Sub() Label20.Text = Math.Round(Mdt2, 2) & " Бар")
                    Me.Invoke(Sub() Label24.Text = Math.Round(Mdt3, 2) & " Бар")
                    Me.Invoke(Sub() Label23.Text = Math.Round(Mdt4, 2) & " Бар")
                    Me.Invoke(Sub() Label21.Text = Math.Round(Mdt5, 2) & " С")

                    Select Case results(49).Value
                        Case False
                            Me.Invoke(Sub() Label28.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label28.Enabled = True)

                    End Select

                    Select Case results(50).Value
                        Case False
                            Me.Invoke(Sub() Label31.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label31.Enabled = True)

                    End Select

                    Select Case results(51).Value
                        Case False
                            Me.Invoke(Sub() Label33.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label33.Enabled = True)

                    End Select

                    Select Case results(52).Value
                        Case False
                            Me.Invoke(Sub() Label35.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label35.Enabled = True)

                    End Select


                    '######################################################
                    Select Case results(59).Value
                        Case True
                            Me.Invoke(Sub() GazO.Visible = True)
                            Me.Invoke(Sub() GazC.Visible = False)

                        Case False
                            Me.Invoke(Sub() GazC.Visible = True)
                            Me.Invoke(Sub() GazO.Visible = False)
                    End Select


                    Select Case results(60).Value
                        Case False
                            Me.Invoke(Sub() DTO.Visible = False)
                            Me.Invoke(Sub() DTC.Visible = True)

                        Case True
                            Me.Invoke(Sub() DTC.Visible = True)
                            Me.Invoke(Sub() DTO.Visible = False)
                    End Select

                    Select Case results(58).Value
                        Case False
                            Me.Invoke(Sub() BoilO.Visible = False)
                            Me.Invoke(Sub() BoilC.Visible = True)

                        Case True
                            Me.Invoke(Sub() BoilC.Visible = True)
                            Me.Invoke(Sub() BoilO.Visible = False)
                    End Select

                    Select Case results(61).Value
                        Case False
                            Me.Invoke(Sub() HeatO.Visible = False)
                            Me.Invoke(Sub() HeatC.Visible = True)

                        Case True
                            Me.Invoke(Sub() HeatC.Visible = False)
                            Me.Invoke(Sub() HeatO.Visible = True)
                    End Select



                    Dim Mft1 As Double = results(62).Value
                    Dim MFt2 As Double = results(63).Value
                    Dim MFt3 As Double = results(64).Value
                    Dim MFt4 As Double = results(65).Value

                    Me.Invoke(Sub() Label41.Text = Math.Round(Mft1, 2) & " C")
                    Me.Invoke(Sub() Label39.Text = Math.Round(MFt2, 2) & " C")
                    Me.Invoke(Sub() Label43.Text = Math.Round(MFt3, 2) & " Бар")
                    Me.Invoke(Sub() Label38.Text = Math.Round(MFt4, 2) & " Бар")




                    'Сигнализация
                    'Температура прямой воды в коллекторе не в норме
                    Select Case results(66).Value
                        Case False
                            Me.Invoke(Sub() Label27.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label27.Enabled = True)

                    End Select

                    'Температура обратной воды в коллекторе не в норме
                    Select Case results(67).Value
                        Case False
                            Me.Invoke(Sub() Label45.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label45.Enabled = True)

                    End Select

                    'Давление прямой воды в коллекторе не в норме
                    Select Case results(68).Value
                        Case False
                            Me.Invoke(Sub() Label46.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label46.Enabled = True)

                    End Select

                    'Давление обратной воды в коллекторе не в норме
                    Select Case results(69).Value
                        Case False
                            Me.Invoke(Sub() Label47.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label47.Enabled = True)

                    End Select

                    'Д. прям. воды отоп. не в норме
                    Select Case results(70).Value
                        Case False
                            Me.Invoke(Sub() Label48.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label48.Enabled = True)

                    End Select

                    'Д. обр. воды отоп. перед насос. не в нор
                    Select Case results(71).Value
                        Case False
                            Me.Invoke(Sub() Label49.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label49.Enabled = True)

                    End Select

                    'Д. обр. воды отоп. после насос. не в нор
                    Select Case results(72).Value
                        Case False
                            Me.Invoke(Sub() Label50.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label50.Enabled = True)

                    End Select

                    'Т. воздуха внутри кот. не в норме
                    Select Case results(73).Value
                        Case False
                            Me.Invoke(Sub() Label51.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label51.Enabled = True)

                    End Select

                    'Д. исходной воды не в норме
                    Select Case results(74).Value
                        Case False
                            Me.Invoke(Sub() Label52.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label52.Enabled = True)

                    End Select

                    'Напряжение на вводе №1 отсутствует
                    Select Case results(75).Value
                        Case False
                            Me.Invoke(Sub() Label53.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label53.Enabled = True)

                    End Select

                    'Напряжение на вводе №2 отсутствует
                    Select Case results(76).Value
                        Case False
                            Me.Invoke(Sub() Label54.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label54.Enabled = True)

                    End Select

                    'АВР сработал
                    Select Case results(77).Value
                        Case False
                            Me.Invoke(Sub() Label55.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label55.Enabled = True)

                    End Select

                    'Д. прям. воды в колл. Ав.
                    Select Case results(78).Value
                        Case False
                            Me.Invoke(Sub() Label56.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label56.Enabled = True)

                    End Select

                    'Д. обр. воды в колл. Ав.
                    Select Case results(79).Value
                        Case False
                            Me.Invoke(Sub() Label57.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label57.Enabled = True)

                    End Select

                    'Д. прям. воды отоп. Ав.
                    Select Case results(80).Value
                        Case False
                            Me.Invoke(Sub() Label58.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label58.Enabled = True)

                    End Select

                    'Д. обр. воды отоп. перед .насо. Ав.
                    Select Case results(81).Value
                        Case False
                            Me.Invoke(Sub() Label59.Enabled = False)

                        Case True
                            Me.Invoke(Sub() Label59.Enabled = True)

                    End Select

                    'Д. обр. воды отоп. после насос. не в нор


                    Select Case results(82).Value
                        Case False

                            Me.Invoke(Sub() Label60.Enabled = False)

                        Case True

                            Me.Invoke(Sub() Label60.Enabled = True)


                    End Select




                    Me.Invoke(Sub() TW_PID.Text = "расч. уставка Т. прям. воды отоп: " & results(83).Value)
                    'САУ_Т._.kat4.TW_PID
                Next

                Threading.Thread.Sleep(MSPEED + 400)

            Loop

        Catch ex As Exception

            '' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Private Sub frmSAUT_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        T_SAUT.Abort()

        m_server.CancelSubscription(groupSAUT)

        m_server.CancelSubscription(groupSAUT_A)
        T_SAUT_A.Abort()


    End Sub


    Private Sub frmSAUT_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        T_SAUT = New System.Threading.Thread(AddressOf T_SAUT_START)
        T_SAUT.Start()

        T_SAUT_A = New System.Threading.Thread(AddressOf T_SAUT_A_ALARM_SOUND)
        T_SAUT_A.Start()

        Select Case btn_SAUT.Text

            Case "Старт"

                btn_SAUT.Text = "Стоп"

            Case "Стоп"

                btn_SAUT.Text = "Старт"
                m_server.CancelSubscription(groupSAUT)
                m_server.CancelSubscription(groupSAUT_A)
                T_SAUT.Abort()
                T_SAUT_A.Abort()

        End Select


    End Sub

End Class