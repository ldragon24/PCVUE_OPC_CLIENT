Public Class frmChpt
    Dim T_CHPT As System.Threading.Thread

    Private Sub frmChpt_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        T_CHPT.Abort()
        m_server.CancelSubscription(group_CHPT)

    End Sub

    Private Sub frmChpt_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        T_CHPT = New System.Threading.Thread(AddressOf T_CHPT_START)
        T_CHPT.Start()

    End Sub

    Private Sub T_CHPT_START()


        Try
ARG:

            groupState_CHPT.Name = "ЩПТ"
            groupState_CHPT.Active = True
            groupState_CHPT.UpdateRate = MSPEED

            group_CHPT = DirectCast(m_server.CreateSubscription(groupState_CHPT), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(122) {}

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "ЩПТ._.АБ.I"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "ЩПТ._.С1.I"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "ЩПТ._.С2.I"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "ЩПТ._.С1.U"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "ЩПТ._.С3.U"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "ЩПТ._.С4.U"


            '####################################
            'ЩПТ.НИПОМ.ПЛК.EARTH_BUS
            'ЩПТ.НИПОМ.ПЛК.EARTH_FID
            'ЩПТ.НИПОМ.ПЛК.U_LOW
            'ЩПТ.НИПОМ.ПЛК.U_HIGH
            'ЩПТ.НИПОМ.ПЛК.I_ZAR_AB_HIGH
            'ЩПТ.НИПОМ.ПЛК.I_RAZR_AB_HIGH
            'ЩПТ.НИПОМ.ПЛК.T_AB_HIGH
            'ЩПТ.НИПОМ.ПЛК.RAZRAD_AB

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "ЩПТ.НИПОМ.ПЛК.EARTH_BUS"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "ЩПТ.НИПОМ.ПЛК.EARTH_FID"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "ЩПТ.НИПОМ.ПЛК.U_LOW"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "ЩПТ.НИПОМ.ПЛК.U_HIGH"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "ЩПТ.НИПОМ.ПЛК.I_ZAR_AB_HIGH"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "ЩПТ.НИПОМ.ПЛК.I_RAZR_AB_HIGH"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "ЩПТ.НИПОМ.ПЛК.T_AB_HIGH"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "ЩПТ.НИПОМ.ПЛК.RAZRAD_AB"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "ЩПТ.С1.ВЗП1.GENERAL_BREAKDOWN"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "ЩПТ.С1.ВЗП1.AB_LOW_U"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "ЩПТ.С1.ВЗП1.SPECIAL_REGIME"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "ЩПТ.С2.ВЗП2.GENERAL_BREAKDOWN"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "ЩПТ.С2.ВЗП2.AB_LOW_U"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "ЩПТ.С2.ВЗП2.SPECIAL_REGIME"

            '##################################################
            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "ЩПТ.С1.QF1.CLOSE"

            '##################################################
            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "ЩПТ.С1.QF3.CLOSE"

            '##################################################
            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "ЩПТ.С1.QF5.CLOSE"

            '##################################################
            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "ЩПТ.С1.QF10.CLOSE"

            '##################################################
            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "ЩПТ.С1.QF11.CLOSE"

            '##################################################
            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "ЩПТ.С1.QF12.CLOSE"

            '##################################################
            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "ЩПТ.С1.QF13.CLOSE"

            '##################################################
            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "ЩПТ.С1.QF14.CLOSE"

            '##################################################
            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "ЩПТ.С1.QF15.CLOSE"

            '##################################################
            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "ЩПТ.С1.QF16.CLOSE"

            '##################################################
            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "ЩПТ.С1.QF17.CLOSE"

            '##################################################
            items(31) = New Global.Opc.Da.Item()
            items(31).ItemName = "ЩПТ.С1.QF18.CLOSE"

            '##################################################
            items(32) = New Global.Opc.Da.Item()
            items(32).ItemName = "ЩПТ.С1.QF19.CLOSE"

            '##################################################
            items(33) = New Global.Opc.Da.Item()
            items(33).ItemName = "ЩПТ.С1.QF20.CLOSE"

            '##################################################
            items(34) = New Global.Opc.Da.Item()
            items(34).ItemName = "ЩПТ.С1.QF21.CLOSE"

            '##################################################
            items(35) = New Global.Opc.Da.Item()
            items(35).ItemName = "ЩПТ.С1.QF22.CLOSE"

            '##################################################
            items(36) = New Global.Opc.Da.Item()
            items(36).ItemName = "ЩПТ.С2.QF2.CLOSE"
            '##################################################
            items(37) = New Global.Opc.Da.Item()
            items(37).ItemName = "ЩПТ.С2.QF4.CLOSE"
            '##################################################
            items(38) = New Global.Opc.Da.Item()
            items(38).ItemName = "ЩПТ.С2.QF6.CLOSE"
            '##################################################
            items(39) = New Global.Opc.Da.Item()
            items(39).ItemName = "ЩПТ.С2.QF23.CLOSE"
            '##################################################
            items(40) = New Global.Opc.Da.Item()
            items(40).ItemName = "ЩПТ.С2.QF24.CLOSE"
            '##################################################
            items(41) = New Global.Opc.Da.Item()
            items(41).ItemName = "ЩПТ.С2.QF25.CLOSE"
            '##################################################
            items(42) = New Global.Opc.Da.Item()
            items(42).ItemName = "ЩПТ.С2.QF26.CLOSE"
            '##################################################
            items(43) = New Global.Opc.Da.Item()
            items(43).ItemName = "ЩПТ.С2.QF27.CLOSE"
            '##################################################
            items(44) = New Global.Opc.Da.Item()
            items(44).ItemName = "ЩПТ.С2.QF28.CLOSE"
            '##################################################
            items(45) = New Global.Opc.Da.Item()
            items(45).ItemName = "ЩПТ.С2.QF29.CLOSE"
            '##################################################
            items(46) = New Global.Opc.Da.Item()
            items(46).ItemName = "ЩПТ.С2.QF30.CLOSE"
            '##################################################
            items(47) = New Global.Opc.Da.Item()
            items(47).ItemName = "ЩПТ.С2.QF31.CLOSE"
            '##################################################
            items(48) = New Global.Opc.Da.Item()
            items(48).ItemName = "ЩПТ.С2.QF32.CLOSE"
            '##################################################
            items(49) = New Global.Opc.Da.Item()
            items(49).ItemName = "ЩПТ.С2.QF33.CLOSE"
            '##################################################
            items(50) = New Global.Opc.Da.Item()
            items(50).ItemName = "ЩПТ.С2.QF34.CLOSE"
            '##################################################
            items(51) = New Global.Opc.Da.Item()
            items(51).ItemName = "ЩПТ.С2.QF35.CLOSE"

            '##################################################
            items(52) = New Global.Opc.Da.Item()
            items(52).ItemName = "ЩПТ.С3.QF41.CLOSE"

            '##################################################
            items(53) = New Global.Opc.Da.Item()
            items(53).ItemName = "ЩПТ.С3.QF42.CLOSE"

            '##################################################
            items(54) = New Global.Opc.Da.Item()
            items(54).ItemName = "ЩПТ.С3.QF43.CLOSE"

            '##################################################
            items(55) = New Global.Opc.Da.Item()
            items(55).ItemName = "ЩПТ.С3.QF44.CLOSE"

            '##################################################
            items(56) = New Global.Opc.Da.Item()
            items(56).ItemName = "ЩПТ.С3.QF45.CLOSE"

            '##################################################
            items(57) = New Global.Opc.Da.Item()
            items(57).ItemName = "ЩПТ.С3.QF46.CLOSE"

            '##################################################
            items(58) = New Global.Opc.Da.Item()
            items(58).ItemName = "ЩПТ.С3.QF47.CLOSE"

            '##################################################
            items(59) = New Global.Opc.Da.Item()
            items(59).ItemName = "ЩПТ.С3.QF48.CLOSE"




            '##################################################
            items(60) = New Global.Opc.Da.Item()
            items(60).ItemName = "ЩПТ.С4.QF51.CLOSE"

            '##################################################
            items(61) = New Global.Opc.Da.Item()
            items(61).ItemName = "ЩПТ.С4.QF52.CLOSE"

            '##################################################
            items(62) = New Global.Opc.Da.Item()
            items(62).ItemName = "ЩПТ.С4.QF53.CLOSE"

            '##################################################
            items(63) = New Global.Opc.Da.Item()
            items(63).ItemName = "ЩПТ.С4.QF54.CLOSE"

            '##################################################
            items(64) = New Global.Opc.Da.Item()
            items(64).ItemName = "ЩПТ.С4.QF55.CLOSE"

            '##################################################
            items(65) = New Global.Opc.Da.Item()
            items(65).ItemName = "ЩПТ.С4.QF56.CLOSE"

            '##################################################
            items(66) = New Global.Opc.Da.Item()
            items(66).ItemName = "ЩПТ.С4.QF57.CLOSE"

            '##################################################
            items(67) = New Global.Opc.Da.Item()
            items(67).ItemName = "ЩПТ.С4.QF58.CLOSE"

            '##################################################
            items(68) = New Global.Opc.Da.Item()
            items(68).ItemName = "ЩПТ.С4.QF59.CLOSE"



            'ЦВЕТА ЛИНИЙ
            items(69) = New Global.Opc.Da.Item()
            items(69).ItemName = "ЩПТ.С1.QF1.VOLT_COLOR"

            '##################################################
            items(70) = New Global.Opc.Da.Item()
            items(70).ItemName = "ЩПТ.С2.QF2.VOLT_COLOR"


            items(71) = New Global.Opc.Da.Item()
            items(71).ItemName = "ЩПТ.С1.QF5.VOLT_COLOR"

            items(72) = New Global.Opc.Da.Item()
            items(72).ItemName = "ЩПТ.С2.QF6.VOLT_COLOR"

            '##################################################
            items(73) = New Global.Opc.Da.Item()
            items(73).ItemName = "ЩПТ.С1.QF10.VOLT_COLOR"

            '##################################################
            items(74) = New Global.Opc.Da.Item()
            items(74).ItemName = "ЩПТ.С1.QF11.VOLT_COLOR"

            '##################################################
            items(75) = New Global.Opc.Da.Item()
            items(75).ItemName = "ЩПТ.С1.QF12.VOLT_COLOR"

            '##################################################
            items(76) = New Global.Opc.Da.Item()
            items(76).ItemName = "ЩПТ.С1.QF13.VOLT_COLOR"

            '##################################################
            items(77) = New Global.Opc.Da.Item()
            items(77).ItemName = "ЩПТ.С1.QF14.VOLT_COLOR"

            '##################################################
            items(78) = New Global.Opc.Da.Item()
            items(78).ItemName = "ЩПТ.С1.QF15.VOLT_COLOR"

            '##################################################
            items(79) = New Global.Opc.Da.Item()
            items(79).ItemName = "ЩПТ.С1.QF16.VOLT_COLOR"

            '##################################################
            items(80) = New Global.Opc.Da.Item()
            items(80).ItemName = "ЩПТ.С1.QF17.VOLT_COLOR"

            '##################################################
            items(81) = New Global.Opc.Da.Item()
            items(81).ItemName = "ЩПТ.С1.QF18.VOLT_COLOR"

            '##################################################
            items(82) = New Global.Opc.Da.Item()
            items(82).ItemName = "ЩПТ.С1.QF19.VOLT_COLOR"

            '##################################################
            items(83) = New Global.Opc.Da.Item()
            items(83).ItemName = "ЩПТ.С1.QF20.VOLT_COLOR"

            '##################################################
            items(84) = New Global.Opc.Da.Item()
            items(84).ItemName = "ЩПТ.С1.QF21.VOLT_COLOR"

            '##################################################
            items(85) = New Global.Opc.Da.Item()
            items(85).ItemName = "ЩПТ.С1.QF22.VOLT_COLOR"


            '##################################################
            items(86) = New Global.Opc.Da.Item()
            items(86).ItemName = "ЩПТ.С2.QF2.VOLT_COLOR"
            '##################################################
            items(87) = New Global.Opc.Da.Item()
            items(87).ItemName = "ЩПТ.С2.QF4.VOLT_COLOR"
            '##################################################
            items(88) = New Global.Opc.Da.Item()
            items(88).ItemName = "ЩПТ.С2.QF23.VOLT_COLOR"

            items(89) = New Global.Opc.Da.Item()
            items(89).ItemName = "ЩПТ.С2.QF23.VOLT_COLOR"
            '##################################################
            items(90) = New Global.Opc.Da.Item()
            items(90).ItemName = "ЩПТ.С2.QF24.VOLT_COLOR"
            '##################################################
            items(91) = New Global.Opc.Da.Item()
            items(91).ItemName = "ЩПТ.С2.QF25.VOLT_COLOR"
            '##################################################
            items(92) = New Global.Opc.Da.Item()
            items(92).ItemName = "ЩПТ.С2.QF26.VOLT_COLOR"
            '##################################################
            items(93) = New Global.Opc.Da.Item()
            items(93).ItemName = "ЩПТ.С2.QF27.VOLT_COLOR"
            '##################################################
            items(94) = New Global.Opc.Da.Item()
            items(94).ItemName = "ЩПТ.С2.QF28.VOLT_COLOR"
            '##################################################
            items(95) = New Global.Opc.Da.Item()
            items(95).ItemName = "ЩПТ.С2.QF29.VOLT_COLOR"
            '##################################################
            items(96) = New Global.Opc.Da.Item()
            items(96).ItemName = "ЩПТ.С2.QF30.VOLT_COLOR"
            '##################################################
            items(97) = New Global.Opc.Da.Item()
            items(97).ItemName = "ЩПТ.С2.QF31.VOLT_COLOR"
            '##################################################
            items(98) = New Global.Opc.Da.Item()
            items(98).ItemName = "ЩПТ.С2.QF32.VOLT_COLOR"
            '##################################################
            items(99) = New Global.Opc.Da.Item()
            items(99).ItemName = "ЩПТ.С2.QF33.VOLT_COLOR"
            '##################################################
            items(100) = New Global.Opc.Da.Item()
            items(100).ItemName = "ЩПТ.С2.QF34.VOLT_COLOR"
            '##################################################
            items(101) = New Global.Opc.Da.Item()
            items(101).ItemName = "ЩПТ.С2.QF35.VOLT_COLOR"

            '##################################################
            items(102) = New Global.Opc.Da.Item()
            items(102).ItemName = "ЩПТ.С3.QF41.VOLT_COLOR"

            '##################################################
            items(103) = New Global.Opc.Da.Item()
            items(103).ItemName = "ЩПТ.С3.QF42.VOLT_COLOR"

            '##################################################
            items(104) = New Global.Opc.Da.Item()
            items(104).ItemName = "ЩПТ.С3.QF43.VOLT_COLOR"

            '##################################################
            items(105) = New Global.Opc.Da.Item()
            items(105).ItemName = "ЩПТ.С3.QF44.VOLT_COLOR"

            '##################################################
            items(106) = New Global.Opc.Da.Item()
            items(106).ItemName = "ЩПТ.С3.QF45.VOLT_COLOR"

            '##################################################
            items(107) = New Global.Opc.Da.Item()
            items(107).ItemName = "ЩПТ.С3.QF46.VOLT_COLOR"

            '##################################################
            items(108) = New Global.Opc.Da.Item()
            items(108).ItemName = "ЩПТ.С3.QF47.VOLT_COLOR"

            '##################################################
            items(109) = New Global.Opc.Da.Item()
            items(109).ItemName = "ЩПТ.С3.QF48.VOLT_COLOR"

            '##################################################
            items(110) = New Global.Opc.Da.Item()
            items(110).ItemName = "ЩПТ.С4.QF51.VOLT_COLOR"

            '##################################################
            items(111) = New Global.Opc.Da.Item()
            items(111).ItemName = "ЩПТ.С4.QF52.VOLT_COLOR"

            '##################################################
            items(112) = New Global.Opc.Da.Item()
            items(112).ItemName = "ЩПТ.С4.QF53.VOLT_COLOR"

            '##################################################
            items(113) = New Global.Opc.Da.Item()
            items(113).ItemName = "ЩПТ.С4.QF54.VOLT_COLOR"

            '##################################################
            items(114) = New Global.Opc.Da.Item()
            items(114).ItemName = "ЩПТ.С4.QF55.VOLT_COLOR"

            '##################################################
            items(115) = New Global.Opc.Da.Item()
            items(115).ItemName = "ЩПТ.С4.QF56.VOLT_COLOR"

            '##################################################
            items(116) = New Global.Opc.Da.Item()
            items(116).ItemName = "ЩПТ.С4.QF57.VOLT_COLOR"

            '##################################################
            items(117) = New Global.Opc.Da.Item()
            items(117).ItemName = "ЩПТ.С4.QF58.VOLT_COLOR"

            '##################################################
            items(118) = New Global.Opc.Da.Item()
            items(118).ItemName = "ЩПТ.С4.QF59.VOLT_COLOR"


            '##################################################
            items(119) = New Global.Opc.Da.Item()
            items(119).ItemName = "ЩПТ.С1.QF3.VOLT_COLOR"

            items(120) = New Global.Opc.Da.Item()
            items(120).ItemName = "ЩПТ.С2.QF4.VOLT_COLOR"
            '##################################################

            items(121) = New Global.Opc.Da.Item()
            items(121).ItemName = "ОЩСУ.С1.QF11.VOLT_COLOR"

            items(122) = New Global.Opc.Da.Item()
            items(122).ItemName = "ОЩСУ.С2.QF61.VOLT_COLOR"

            items = group_CHPT.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_CHPT.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1


                    'Блок надписей (вольты, амперы)
                    Me.Invoke(Sub() lbl_I_ab.Text = Math.Round(results(0).Value, 2) & " A")
                    Me.Invoke(Sub() lblF1.Text = Math.Round(results(1).Value, 2) & " A")
                    Me.Invoke(Sub() lblF2.Text = Math.Round(results(2).Value, 2) & " A")
                    Me.Invoke(Sub() lblAB_U.Text = Math.Round(results(3).Value, 2) & " B")
                    Me.Invoke(Sub() lbl_I_c3.Text = Math.Round(results(4).Value, 2) & " B")
                    Me.Invoke(Sub() lbl_I_c4.Text = Math.Round(results(5).Value, 2) & " B")

                    'Сигнализация НИПОМ
                    Me.Invoke(Sub() Label1.Enabled = results(6).Value)
                    Me.Invoke(Sub() Label2.Enabled = results(7).Value)
                    Me.Invoke(Sub() Label3.Enabled = results(8).Value)
                    Me.Invoke(Sub() Label4.Enabled = results(9).Value)
                    Me.Invoke(Sub() Label5.Enabled = results(10).Value)
                    Me.Invoke(Sub() Label6.Enabled = results(11).Value)
                    Me.Invoke(Sub() Label7.Enabled = results(12).Value)
                    Me.Invoke(Sub() Label8.Enabled = results(13).Value)

                    'Сигнализация ВЗП-1
                    Me.Invoke(Sub() Label9.Enabled = results(14).Value)
                    Me.Invoke(Sub() Label10.Enabled = results(15).Value)
                    Me.Invoke(Sub() Label11.Enabled = results(16).Value)

                    'Сигнализация ВЗП-2
                    Me.Invoke(Sub() Label12.Enabled = results(17).Value)
                    Me.Invoke(Sub() Label13.Enabled = results(18).Value)
                    Me.Invoke(Sub() Label14.Enabled = results(19).Value)

                    'Выключатели
                   
                    'Секция 1
                    '   Sost(results(20).Quality.ToString, results(20).Value, QF1_vkl, QF1_vykl, lblQF1)
                    ' Sost(results(21).Quality.ToString, results(21).Value, QF3_vkl, QF3_vykl, lblQF3)
                    '  Sost(results(22).Quality.ToString, results(22).Value, QF5_vkl, QF5_vykl, lblQF5)


                    Sost3(results(20).Quality.ToString, results(20).Value, QF1_vykl, lblQF1)
                    Sost3(results(21).Quality.ToString, results(21).Value, QF3_vykl, lblQF3)
                    Sost3(results(22).Quality.ToString, results(22).Value, QF5_vykl, lblQF5)
                    Sost3(results(23).Quality.ToString, results(23).Value, QF10_vykl, lblQF10)


                    Sost(results(24).Quality.ToString, results(24).Value, QF11_vkl, QF11_vykl, lblQF11)
                    Sost(results(25).Quality.ToString, results(25).Value, QF12_vkl, QF12_vykl, lblQF12)
                    Sost(results(26).Quality.ToString, results(26).Value, QF13_vkl, QF13_vykl, lblQF13)
                    Sost(results(27).Quality.ToString, results(27).Value, QF14_vkl, QF14_vykl, lblQF14)
                    Sost(results(28).Quality.ToString, results(28).Value, QF15_vkl, QF15_vykl, lblQF15)
                    Sost(results(29).Quality.ToString, results(29).Value, QF16_vkl, QF16_vykl, lblQF16)
                    Sost(results(30).Quality.ToString, results(30).Value, QF17_vkl, QF17_vykl, lblQF17)
                    Sost(results(31).Quality.ToString, results(31).Value, QF18_vkl, QF18_vykl, lblQF18)
                    Sost(results(32).Quality.ToString, results(32).Value, QF19_vkl, QF19_vykl, lblQF19)
                    Sost(results(33).Quality.ToString, results(33).Value, QF20_vkl, QF20_vykl, lblQF20)
                    Sost(results(34).Quality.ToString, results(34).Value, QF21_vkl, QF21_vykl, lblQF21)
                    Sost(results(35).Quality.ToString, results(35).Value, QF22_vkl, QF22_vykl, lblQF22)


                    'Секция 2

                    Sost(results(36).Quality.ToString, results(36).Value, QF2_vkl, QF2_vykl, lblQF2)
                    Sost(results(37).Quality.ToString, results(37).Value, QF4_vkl, QF4_vykl, lblQF4)
                    Sost(results(38).Quality.ToString, results(38).Value, QF6_vkl, QF6_vykl, lblQF6)
                    Sost(results(39).Quality.ToString, results(39).Value, QF23_vkl, QF23_vykl, lblQF23)
                    Sost(results(40).Quality.ToString, results(40).Value, QF24_vkl, QF24_vykl, lblQF24)
                    Sost(results(41).Quality.ToString, results(41).Value, QF25_vkl, QF25_vykl, lblQF25)
                    Sost(results(42).Quality.ToString, results(42).Value, QF26_vkl, QF26_vykl, lblQF26)
                    Sost(results(43).Quality.ToString, results(43).Value, QF27_vkl, QF27_vykl, lblQF27)
                    Sost(results(44).Quality.ToString, results(44).Value, QF28_vkl, QF28_vykl, lblQF28)
                    Sost(results(45).Quality.ToString, results(45).Value, QF29_vkl, QF29_vykl, lblQF29)
                    Sost(results(46).Quality.ToString, results(46).Value, QF30_vkl, QF30_vykl, lblQF30)
                    Sost(results(47).Quality.ToString, results(47).Value, QF31_vkl, QF31_vykl, lblQF31)
                    Sost(results(48).Quality.ToString, results(48).Value, QF32_vkl, QF32_vykl, lblQF32)
                    Sost(results(49).Quality.ToString, results(49).Value, QF33_vkl, QF33_vykl, lblQF33)
                    Sost(results(50).Quality.ToString, results(50).Value, QF34_vkl, QF34_vykl, lblQF34)
                    Sost(results(51).Quality.ToString, results(51).Value, QF35_vkl, QF35_vykl, lblQF35)

                    

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    Sost2(results(52).Quality.ToString, results(52).Value, QF41, lblQF41)
                    Sost2(results(53).Quality.ToString, results(53).Value, QF42, lblQF42)
                    Sost2(results(54).Quality.ToString, results(54).Value, QF43, lblQF43)
                    Sost2(results(55).Quality.ToString, results(55).Value, QF44, lblQF44)
                    Sost2(results(56).Quality.ToString, results(56).Value, QF45, lblQF45)
                    Sost2(results(57).Quality.ToString, results(57).Value, QF46, lblQF46)
                    Sost2(results(58).Quality.ToString, results(58).Value, QF47, lblQF47)
                    Sost2(results(59).Quality.ToString, results(59).Value, QF48, lblQF48)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    Sost2(results(60).Quality.ToString, results(60).Value, QF51, lblQF51)
                    Sost2(results(61).Quality.ToString, results(61).Value, QF52, lblQF52)
                    Sost2(results(62).Quality.ToString, results(62).Value, QF53, lblQF53)
                    Sost2(results(63).Quality.ToString, results(63).Value, QF54, lblQF54)
                    Sost2(results(64).Quality.ToString, results(64).Value, QF55, lblQF55)
                    Sost2(results(65).Quality.ToString, results(65).Value, QF56, lblQF56)
                    Sost2(results(66).Quality.ToString, results(66).Value, QF57, lblQF57)
                    Sost2(results(67).Quality.ToString, results(67).Value, QF58, lblQF58)
                    Sost2(results(68).Quality.ToString, results(68).Value, QF59, lblQF59)


                    '######################################################################

                    Me.Invoke(Sub() LineColor(results(69).Value, L1_1))
                    Me.Invoke(Sub() L1_2.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_3.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_4.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_5.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_6.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_7.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_8.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_9.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_10.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_11.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_12.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_13.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_14.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_15.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_16.BorderColor = L1_1.BorderColor)
                    Me.Invoke(Sub() L1_17.BorderColor = L1_1.BorderColor)


                    Me.Invoke(Sub() LineColor(results(70).Value, L2_1))
                    Me.Invoke(Sub() L2_2.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_3.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_4.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_5.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_6.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_7.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_8.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_9.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_10.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_11.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_12.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_13.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_14.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_15.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_16.BorderColor = L2_1.BorderColor)
                    Me.Invoke(Sub() L2_17.BorderColor = L2_1.BorderColor)


                    Me.Invoke(Sub() LineColor(results(71).Value, L3_1))
                    Me.Invoke(Sub() L3_2.BorderColor = L3_1.BorderColor)
                    Me.Invoke(Sub() L3_3.BorderColor = L3_1.BorderColor)
                    Me.Invoke(Sub() L3_4.BorderColor = L3_1.BorderColor)
                    Me.Invoke(Sub() L3_5.BorderColor = L3_1.BorderColor)
                    Me.Invoke(Sub() L3_6.BorderColor = L3_1.BorderColor)
                    Me.Invoke(Sub() L3_7.BorderColor = L3_1.BorderColor)
                    Me.Invoke(Sub() L3_8.BorderColor = L3_1.BorderColor)
                    Me.Invoke(Sub() L3_9.BorderColor = L3_1.BorderColor)
                    Me.Invoke(Sub() L3_10.BorderColor = L3_1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(72).Value, L4_1))
                    Me.Invoke(Sub() L4_2.BorderColor = L4_1.BorderColor)
                    Me.Invoke(Sub() L4_3.BorderColor = L4_1.BorderColor)
                    Me.Invoke(Sub() L4_4.BorderColor = L4_1.BorderColor)
                    Me.Invoke(Sub() L4_5.BorderColor = L4_1.BorderColor)
                    Me.Invoke(Sub() L4_6.BorderColor = L4_1.BorderColor)
                    Me.Invoke(Sub() L4_7.BorderColor = L4_1.BorderColor)
                    Me.Invoke(Sub() L4_8.BorderColor = L4_1.BorderColor)
                    Me.Invoke(Sub() L4_9.BorderColor = L4_1.BorderColor)
                    Me.Invoke(Sub() L4_10.BorderColor = L4_1.BorderColor)
                    Me.Invoke(Sub() L4_11.BorderColor = L4_1.BorderColor)

                    Me.Invoke(Sub() LineColor(results(73).Value, LineShape39))
                    Me.Invoke(Sub() LineColor(results(74).Value, LineShape38))
                    Me.Invoke(Sub() LineColor(results(75).Value, LineShape37))
                    Me.Invoke(Sub() LineColor(results(76).Value, LineShape36))
                    Me.Invoke(Sub() LineColor(results(77).Value, LineShape35))
                    Me.Invoke(Sub() LineColor(results(78).Value, LineShape30))
                    Me.Invoke(Sub() LineColor(results(79).Value, LineShape31))
                    Me.Invoke(Sub() LineColor(results(80).Value, LineShape32))
                    Me.Invoke(Sub() LineColor(results(81).Value, LineShape33))
                    Me.Invoke(Sub() LineColor(results(82).Value, LineShape34))
                    Me.Invoke(Sub() LineColor(results(83).Value, LineShape27))
                    Me.Invoke(Sub() LineColor(results(84).Value, LineShape28))
                    Me.Invoke(Sub() LineColor(results(85).Value, LineShape29))

                    Me.Invoke(Sub() LineColor(results(89).Value, LineShape65))
                    Me.Invoke(Sub() LineColor(results(90).Value, LineShape64))
                    Me.Invoke(Sub() LineColor(results(91).Value, LineShape63))
                    Me.Invoke(Sub() LineColor(results(92).Value, LineShape62))
                    Me.Invoke(Sub() LineColor(results(93).Value, LineShape61))
                    Me.Invoke(Sub() LineColor(results(94).Value, LineShape56))
                    Me.Invoke(Sub() LineColor(results(95).Value, LineShape57))
                    Me.Invoke(Sub() LineColor(results(96).Value, LineShape58))
                    Me.Invoke(Sub() LineColor(results(97).Value, LineShape59))
                    Me.Invoke(Sub() LineColor(results(98).Value, LineShape60))
                    Me.Invoke(Sub() LineColor(results(99).Value, LineShape53))
                    Me.Invoke(Sub() LineColor(results(100).Value, LineShape54))
                    Me.Invoke(Sub() LineColor(results(101).Value, LineShape55))


                    Me.Invoke(Sub() LineColor(results(102).Value, LineShape66))
                    Me.Invoke(Sub() LineColor(results(103).Value, LineShape67))
                    Me.Invoke(Sub() LineColor(results(104).Value, LineShape68))
                    Me.Invoke(Sub() LineColor(results(105).Value, LineShape72))
                    Me.Invoke(Sub() LineColor(results(106).Value, LineShape73))
                    Me.Invoke(Sub() LineColor(results(107).Value, LineShape81))
                    Me.Invoke(Sub() LineColor(results(108).Value, LineShape80))
                    Me.Invoke(Sub() LineColor(results(109).Value, LineShape79))

                    Me.Invoke(Sub() LineColor(results(110).Value, LineShape90))
                    Me.Invoke(Sub() LineColor(results(111).Value, LineShape89))
                    Me.Invoke(Sub() LineColor(results(112).Value, LineShape88))
                    Me.Invoke(Sub() LineColor(results(113).Value, LineShape87))
                    Me.Invoke(Sub() LineColor(results(114).Value, LineShape86))
                    Me.Invoke(Sub() LineColor(results(115).Value, LineShape85))
                    Me.Invoke(Sub() LineColor(results(116).Value, LineShape82))
                    Me.Invoke(Sub() LineColor(results(117).Value, LineShape83))
                    Me.Invoke(Sub() LineColor(results(118).Value, LineShape84))


                    Me.Invoke(Sub() LineColor(results(119).Value, Q3_1))
                    Me.Invoke(Sub() LineColor(results(119).Value, Q3_2))


                    Me.Invoke(Sub() LineColor(results(120).Value, Q4_1))
                    Me.Invoke(Sub() LineColor(results(120).Value, Q4_2))


                    Me.Invoke(Sub() LineColor(results(121).Value, LineShape23))
                    Me.Invoke(Sub() LineColor(results(122).Value, LineShape26))


                Next

                Threading.Thread.Sleep(MSPEED + 350)
            Loop

        Catch ex As Exception
            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try


    End Sub

    Private Sub Sost(ByVal Quality As String, ByVal Value As Boolean, ByVal qf_V As PictureBox, ByVal qf_Vy As PictureBox, ByVal lbl As System.Windows.Forms.Label)

        Select Case Quality
            Case "good"
                Select Case Value
                    Case True
                        Me.Invoke(Sub() qf_V.Visible = True)
                        Me.Invoke(Sub() qf_Vy.Visible = False)
                    Case Else
                        Me.Invoke(Sub() qf_V.Visible = False)
                        Me.Invoke(Sub() qf_Vy.Visible = True)
                End Select
                Me.Invoke(Sub() lbl.Visible = False)
            Case Else
                Me.Invoke(Sub() lbl.Visible = True)
                Me.Invoke(Sub() qf_V.Visible = False)
                Me.Invoke(Sub() qf_Vy.Visible = False)
        End Select


    End Sub


    Private Sub Sost2(ByVal Quality As String, ByVal Value As Boolean, ByVal qf As Switch_electro, ByVal lbl As System.Windows.Forms.Label)

        Select Case Quality
            Case "good"

                Select Case Value
                    Case True
                        qf.IsActivated = True
                    Case Else
                        qf.IsActivated = False
                End Select

                Me.Invoke(Sub() lbl.Visible = False)
                Me.Invoke(Sub() qf.Visible = True)

            Case Else
                Me.Invoke(Sub() lbl.Visible = True)
                Me.Invoke(Sub() qf.Visible = False)

        End Select

    End Sub

    Private Sub Sost3(ByVal Quality As String, ByVal Value As Boolean, ByVal qf As PictureBox, ByVal lbl As System.Windows.Forms.Label)

        Select Case Quality
            Case "good"

                Select Case Value
                    Case True
                        qf.BackgroundImage = My.Resources.OnState
                    Case Else
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

    Private Sub QF4_vykl_Click(sender As System.Object, e As System.EventArgs) Handles QF4_vykl.Click

    End Sub

    Private Sub QF4_vkl_Click(sender As System.Object, e As System.EventArgs) Handles QF4_vkl.Click

    End Sub

    Private Sub QF2_vykl_Click(sender As System.Object, e As System.EventArgs) Handles QF2_vykl.Click

    End Sub

    Private Sub QF2_vkl_Click(sender As System.Object, e As System.EventArgs) Handles QF2_vkl.Click

    End Sub
End Class