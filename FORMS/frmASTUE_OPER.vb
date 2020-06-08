Public Class frmASTUE_OPER
    Dim T_ASTUE As System.Threading.Thread


    Private Sub btn_ASTUE_Click(sender As System.Object, e As System.EventArgs) Handles btn_ASTUE.Click
        Select Case btn_ASTUE.Text

            Case "Старт"

                btn_ASTUE.Text = "Стоп"
                T_ASTUE = New System.Threading.Thread(AddressOf T_ASTUE_START)
                T_ASTUE.Start()

            Case "Стоп"

                btn_ASTUE.Text = "Старт"
                m_server.CancelSubscription(groupASTUE)
                T_ASTUE.Abort()

        End Select
    End Sub

    Sub T_ASTUE_START()

        Try
ARG:
            groupStateASTUE.Name = "АСТУЭ"
            groupStateASTUE.Active = True
            groupStateASTUE.UpdateRate = MSPEED

            groupASTUE = DirectCast(m_server.CreateSubscription(groupStateASTUE), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(95) {}

            '##########################################################
            'ГПА №1
            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "АСТУЭ.ГПА1.ВВ1.EP"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "АСТУЭ.ГПА1.ВВ1.EQ"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "АСТУЭ.ГПА1.ВВ1.P"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "АСТУЭ.ГПА1.ВВ1.Q"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "АСТУЭ.ГПА1.ВВ2.EP"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "АСТУЭ.ГПА1.ВВ2.EQ"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "АСТУЭ.ГПА1.ВВ2.P"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "АСТУЭ.ГПА1.ВВ2.Q"

            '##########################################################
            'ГПА №2
            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "АСТУЭ.ГПА2.ВВ1.EP"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "АСТУЭ.ГПА2.ВВ1.EQ"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "АСТУЭ.ГПА2.ВВ1.P"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "АСТУЭ.ГПА2.ВВ1.Q"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "АСТУЭ.ГПА2.ВВ2.EP"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "АСТУЭ.ГПА2.ВВ2.EQ"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "АСТУЭ.ГПА2.ВВ2.P"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "АСТУЭ.ГПА2.ВВ2.Q"

            '##########################################################
            'ГПА №3
            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "АСТУЭ.ГПА3.ВВ1.EP"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "АСТУЭ.ГПА3.ВВ1.EQ"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "АСТУЭ.ГПА3.ВВ1.P"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "АСТУЭ.ГПА3.ВВ1.Q"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "АСТУЭ.ГПА3.ВВ2.EP"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "АСТУЭ.ГПА3.ВВ2.EQ"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "АСТУЭ.ГПА3.ВВ2.P"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "АСТУЭ.ГПА3.ВВ2.Q"


            '##########################################################
            'ГПА №4
            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "АСТУЭ.ГПА4.ВВ1.EP"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "АСТУЭ.ГПА4.ВВ1.EQ"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "АСТУЭ.ГПА4.ВВ1.P"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "АСТУЭ.ГПА4.ВВ1.Q"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "АСТУЭ.ГПА4.ВВ2.EP"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "АСТУЭ.ГПА4.ВВ2.EQ"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "АСТУЭ.ГПА4.ВВ2.P"

            items(31) = New Global.Opc.Da.Item()
            items(31).ItemName = "АСТУЭ.ГПА4.ВВ2.Q"

            '##########################################################
            'ГПА №5
            items(32) = New Global.Opc.Da.Item()
            items(32).ItemName = "АСТУЭ.ГПА5.ВВ1.EP"

            items(33) = New Global.Opc.Da.Item()
            items(33).ItemName = "АСТУЭ.ГПА5.ВВ1.EQ"

            items(34) = New Global.Opc.Da.Item()
            items(34).ItemName = "АСТУЭ.ГПА5.ВВ1.P"

            items(35) = New Global.Opc.Da.Item()
            items(35).ItemName = "АСТУЭ.ГПА5.ВВ1.Q"

            items(36) = New Global.Opc.Da.Item()
            items(36).ItemName = "АСТУЭ.ГПА5.ВВ2.EP"

            items(37) = New Global.Opc.Da.Item()
            items(37).ItemName = "АСТУЭ.ГПА5.ВВ2.EQ"

            items(38) = New Global.Opc.Da.Item()
            items(38).ItemName = "АСТУЭ.ГПА5.ВВ2.P"

            items(39) = New Global.Opc.Da.Item()
            items(39).ItemName = "АСТУЭ.ГПА5.ВВ2.Q"

            '################################################################
            'Активная энергия???
            items(40) = New Global.Opc.Da.Item()
            items(40).ItemName = "РП10.С1.1_ВВОД.EP_POS"
            'Реактивная энергия???
            items(41) = New Global.Opc.Da.Item()
            items(41).ItemName = "РП10.С1.1_ВВОД.EQ_POS"
            'Активная мощность???
            items(42) = New Global.Opc.Da.Item()
            items(42).ItemName = "РП10.С1.1_ВВОД.P"
            'Реактивная мощность???
            items(43) = New Global.Opc.Da.Item()
            items(43).ItemName = "РП10.С1.1_ВВОД.Q"
            '################################################################
            'Активная энергия???
            items(44) = New Global.Opc.Da.Item()
            items(44).ItemName = "РП10.С1.3_ФИД.EP_POS"
            'Реактивная энергия???
            items(45) = New Global.Opc.Da.Item()
            items(45).ItemName = "РП10.С1.3_ФИД.EQ_POS"
            'Активная мощность???
            items(46) = New Global.Opc.Da.Item()
            items(46).ItemName = "РП10.С1.3_ФИД.P"
            'Реактивная мощность???
            items(47) = New Global.Opc.Da.Item()
            items(47).ItemName = "РП10.С1.3_ФИД.Q"
            '################################################################
            'Активная энергия???
            items(48) = New Global.Opc.Da.Item()
            items(48).ItemName = "РП10.С1.4_ФИД.EP_POS"
            'Реактивная энергия???
            items(49) = New Global.Opc.Da.Item()
            items(49).ItemName = "РП10.С1.4_ФИД.EQ_POS"
            'Активная мощность???
            items(50) = New Global.Opc.Da.Item()
            items(50).ItemName = "РП10.С1.4_ФИД.P"
            'Реактивная мощность???
            items(51) = New Global.Opc.Da.Item()
            items(51).ItemName = "РП10.С1.4_ФИД.Q"
            '################################################################
            'Активная энергия???
            items(52) = New Global.Opc.Da.Item()
            items(52).ItemName = "РП10.С1.5_ФИД.EP_POS"
            'Реактивная энергия???
            items(53) = New Global.Opc.Da.Item()
            items(53).ItemName = "РП10.С1.5_ФИД.EQ_POS"
            'Активная мощность???
            items(54) = New Global.Opc.Da.Item()
            items(54).ItemName = "РП10.С1.5_ФИД.P"
            'Реактивная мощность???
            items(55) = New Global.Opc.Da.Item()
            items(55).ItemName = "РП10.С1.5_ФИД.Q"
            '################################################################
            'Активная энергия???
            items(56) = New Global.Opc.Da.Item()
            items(56).ItemName = "РП10.С1.6_ФИД.EP_POS"
            'Реактивная энергия???
            items(57) = New Global.Opc.Da.Item()
            items(57).ItemName = "РП10.С1.6_ФИД.EQ_POS"
            'Активная мощность???
            items(58) = New Global.Opc.Da.Item()
            items(58).ItemName = "РП10.С1.6_ФИД.P"
            'Реактивная мощность???
            items(59) = New Global.Opc.Da.Item()
            items(59).ItemName = "РП10.С1.6_ФИД.Q"
            '################################################################
            'Активная энергия???
            items(60) = New Global.Opc.Da.Item()
            items(60).ItemName = "РП10.С1.7_ФИД.EP_POS"
            'Реактивная энергия???
            items(61) = New Global.Opc.Da.Item()
            items(61).ItemName = "РП10.С1.7_ФИД.EQ_POS"
            'Активная мощность???
            items(62) = New Global.Opc.Da.Item()
            items(62).ItemName = "РП10.С1.7_ФИД.P"
            'Реактивная мощность???
            items(63) = New Global.Opc.Da.Item()
            items(63).ItemName = "РП10.С1.7_ФИД.Q"
            '################################################################
            'Активная энергия???
            items(64) = New Global.Opc.Da.Item()
            items(64).ItemName = "РП10.С1.8_ФИД.EP_POS"
            'Реактивная энергия???
            items(65) = New Global.Opc.Da.Item()
            items(65).ItemName = "РП10.С1.8_ФИД.EQ_POS"
            'Активная мощность???
            items(66) = New Global.Opc.Da.Item()
            items(66).ItemName = "РП10.С1.8_ФИД.P"
            'Реактивная мощность???
            items(67) = New Global.Opc.Da.Item()
            items(67).ItemName = "РП10.С1.8_ФИД.Q"

            '################################################################
            'Активная энергия???
            items(68) = New Global.Opc.Da.Item()
            items(68).ItemName = "РП10.С2.10_ВВОД.EP_POS"
            'Реактивная энергия???
            items(69) = New Global.Opc.Da.Item()
            items(69).ItemName = "РП10.С2.10_ВВОД.EQ_POS"
            'Активная мощность???
            items(70) = New Global.Opc.Da.Item()
            items(70).ItemName = "РП10.С2.10_ВВОД.P"
            'Реактивная мощность???
            items(71) = New Global.Opc.Da.Item()
            items(71).ItemName = "РП10.С2.10_ВВОД.Q"
            '################################################################
            'Активная энергия???
            items(72) = New Global.Opc.Da.Item()
            items(72).ItemName = "РП10.С2.12_ФИД.EP_POS"
            'Реактивная энергия???
            items(73) = New Global.Opc.Da.Item()
            items(73).ItemName = "РП10.С2.12_ФИД.EQ_POS"
            'Активная мощность???
            items(74) = New Global.Opc.Da.Item()
            items(74).ItemName = "РП10.С2.12_ФИД.P"
            'Реактивная мощность???
            items(75) = New Global.Opc.Da.Item()
            items(75).ItemName = "РП10.С2.12_ФИД.Q"
            '################################################################
            'Активная энергия???
            items(76) = New Global.Opc.Da.Item()
            items(76).ItemName = "РП10.С2.13_ФИД.EP_POS"
            'Реактивная энергия???
            items(77) = New Global.Opc.Da.Item()
            items(77).ItemName = "РП10.С2.13_ФИД.EQ_POS"
            'Активная мощность???
            items(78) = New Global.Opc.Da.Item()
            items(78).ItemName = "РП10.С2.13_ФИД.P"
            'Реактивная мощность???
            items(79) = New Global.Opc.Da.Item()
            items(79).ItemName = "РП10.С2.13_ФИД.Q"
            '################################################################
            'Активная энергия???
            items(80) = New Global.Opc.Da.Item()
            items(80).ItemName = "РП10.С2.14_ФИД.EP_POS"
            'Реактивная энергия???
            items(81) = New Global.Opc.Da.Item()
            items(81).ItemName = "РП10.С2.14_ФИД.EQ_POS"
            'Активная мощность???
            items(82) = New Global.Opc.Da.Item()
            items(82).ItemName = "РП10.С2.14_ФИД.P"
            'Реактивная мощность???
            items(83) = New Global.Opc.Da.Item()
            items(83).ItemName = "РП10.С2.14_ФИД.Q"
            '################################################################
            'Активная энергия???
            items(84) = New Global.Opc.Da.Item()
            items(84).ItemName = "РП10.С2.15_ФИД.EP_POS"
            'Реактивная энергия???
            items(85) = New Global.Opc.Da.Item()
            items(85).ItemName = "РП10.С2.15_ФИД.EQ_POS"
            'Активная мощность???
            items(86) = New Global.Opc.Da.Item()
            items(86).ItemName = "РП10.С2.15_ФИД.P"
            'Реактивная мощность???
            items(87) = New Global.Opc.Da.Item()
            items(87).ItemName = "РП10.С2.15_ФИД.Q"
            '################################################################
            'Активная энергия???
            items(88) = New Global.Opc.Da.Item()
            items(88).ItemName = "РП10.С2.16_ФИД.EP_POS"
            'Реактивная энергия???
            items(89) = New Global.Opc.Da.Item()
            items(89).ItemName = "РП10.С2.16_ФИД.EQ_POS"
            'Активная мощность???
            items(90) = New Global.Opc.Da.Item()
            items(90).ItemName = "РП10.С2.16_ФИД.P"
            'Реактивная мощность???
            items(91) = New Global.Opc.Da.Item()
            items(91).ItemName = "РП10.С2.16_ФИД.Q"
            '################################################################
            'Активная энергия???
            items(92) = New Global.Opc.Da.Item()
            items(92).ItemName = "РП10.С2.17_ФИД.EP_POS"
            'Реактивная энергия???
            items(93) = New Global.Opc.Da.Item()
            items(93).ItemName = "РП10.С2.17_ФИД.EQ_POS"
            'Активная мощность???
            items(94) = New Global.Opc.Da.Item()
            items(94).ItemName = "РП10.С2.17_ФИД.P"
            'Реактивная мощность???
            items(95) = New Global.Opc.Da.Item()
            items(95).ItemName = "РП10.С2.17_ФИД.Q"

            items = groupASTUE.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = groupASTUE.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1
                    '##########################################################
                    'ГПА №1

                    If results(0).Quality.ToString = "good" Then Me.Invoke(Sub() Label125.Text = Math.Round(results(0).Value, 2) & " кВт") Else Me.Invoke(Sub() Label125.Text = "?")
                    If results(1).Quality.ToString = "good" Then Me.Invoke(Sub() Label126.Text = Math.Round(results(1).Value, 2) & " кВар") Else Me.Invoke(Sub() Label126.Text = "?")
                    If results(2).Quality.ToString = "good" Then Me.Invoke(Sub() Label127.Text = Math.Round(results(2).Value, 2) & " МВтч") Else Me.Invoke(Sub() Label127.Text = "?")
                    If results(3).Quality.ToString = "good" Then Me.Invoke(Sub() Label128.Text = Math.Round(results(3).Value, 2) & " МВАрч") Else Me.Invoke(Sub() Label128.Text = "?")

                    If results(4).Quality.ToString = "good" Then Me.Invoke(Sub() Label133.Text = Math.Round(results(4).Value, 2) & " кВт") Else Me.Invoke(Sub() Label133.Text = "?")
                    If results(5).Quality.ToString = "good" Then Me.Invoke(Sub() Label134.Text = Math.Round(results(5).Value, 2) & " кВар") Else Me.Invoke(Sub() Label134.Text = "?")
                    If results(6).Quality.ToString = "good" Then Me.Invoke(Sub() Label135.Text = Math.Round(results(6).Value, 2) & " МВтч") Else Me.Invoke(Sub() Label135.Text = "?")
                    If results(7).Quality.ToString = "good" Then Me.Invoke(Sub() Label136.Text = Math.Round(results(7).Value, 2) & " МВАрч") Else Me.Invoke(Sub() Label136.Text = "?")

                    '##########################################################
                    'ГПА №2 
                    If results(8).Quality.ToString = "good" Then Me.Invoke(Sub() Label141.Text = Math.Round(results(8).Value, 2) & " кВт") Else Me.Invoke(Sub() Label141.Text = "?")
                    If results(9).Quality.ToString = "good" Then Me.Invoke(Sub() Label142.Text = Math.Round(results(9).Value, 2) & " кВар") Else Me.Invoke(Sub() Label142.Text = "?")
                    If results(10).Quality.ToString = "good" Then Me.Invoke(Sub() Label143.Text = Math.Round(results(10).Value, 2) & " МВтч") Else Me.Invoke(Sub() Label143.Text = "?")
                    If results(11).Quality.ToString = "good" Then Me.Invoke(Sub() Label144.Text = Math.Round(results(11).Value, 2) & " МВАрч") Else Me.Invoke(Sub() Label144.Text = "?")

                    If results(12).Quality.ToString = "good" Then Me.Invoke(Sub() Label149.Text = Math.Round(results(12).Value, 2) & " кВт") Else Me.Invoke(Sub() Label149.Text = "?")
                    If results(13).Quality.ToString = "good" Then Me.Invoke(Sub() Label150.Text = Math.Round(results(13).Value, 2) & " кВар") Else Me.Invoke(Sub() Label150.Text = "?")
                    If results(14).Quality.ToString = "good" Then Me.Invoke(Sub() Label151.Text = Math.Round(results(14).Value, 2) & " МВтч") Else Me.Invoke(Sub() Label151.Text = "?")
                    If results(15).Quality.ToString = "good" Then Me.Invoke(Sub() Label152.Text = Math.Round(results(15).Value, 2) & " МВАрч") Else Me.Invoke(Sub() Label152.Text = "?")

                    '##########################################################
                    'ГПА №3
                    If results(16).Quality.ToString = "good" Then Me.Invoke(Sub() Label157.Text = Math.Round(results(16).Value, 2) & " кВт") Else Me.Invoke(Sub() Label157.Text = "?")
                    If results(17).Quality.ToString = "good" Then Me.Invoke(Sub() Label158.Text = Math.Round(results(17).Value, 2) & " кВар") Else Me.Invoke(Sub() Label158.Text = "?")
                    If results(18).Quality.ToString = "good" Then Me.Invoke(Sub() Label159.Text = Math.Round(results(18).Value, 2) & " КВтч") Else Me.Invoke(Sub() Label159.Text = "?")
                    If results(19).Quality.ToString = "good" Then Me.Invoke(Sub() Label160.Text = Math.Round(results(19).Value, 2) & " КВАрч") Else Me.Invoke(Sub() Label160.Text = "?")

                    If results(20).Quality.ToString = "good" Then Me.Invoke(Sub() Label165.Text = Math.Round(results(20).Value, 2) & " кВт") Else Me.Invoke(Sub() Label165.Text = "?")
                    If results(21).Quality.ToString = "good" Then Me.Invoke(Sub() Label166.Text = Math.Round(results(21).Value, 2) & " кВар") Else Me.Invoke(Sub() Label166.Text = "?")
                    If results(22).Quality.ToString = "good" Then Me.Invoke(Sub() Label167.Text = Math.Round(results(22).Value, 2) & " КВтч") Else Me.Invoke(Sub() Label167.Text = "?")
                    If results(23).Quality.ToString = "good" Then Me.Invoke(Sub() Label168.Text = Math.Round(results(23).Value, 2) & " КВАрч") Else Me.Invoke(Sub() Label168.Text = "?")

                    '##########################################################
                    'ГПА №4
                    If results(24).Quality.ToString = "good" Then Me.Invoke(Sub() Label173.Text = Math.Round(results(24).Value, 2) & " кВт") Else Me.Invoke(Sub() Label173.Text = "?")
                    If results(25).Quality.ToString = "good" Then Me.Invoke(Sub() Label174.Text = Math.Round(results(25).Value, 2) & " кВар") Else Me.Invoke(Sub() Label174.Text = "?")
                    If results(26).Quality.ToString = "good" Then Me.Invoke(Sub() Label175.Text = Math.Round(results(26).Value, 2) & " КВтч") Else Me.Invoke(Sub() Label175.Text = "?")
                    If results(27).Quality.ToString = "good" Then Me.Invoke(Sub() Label176.Text = Math.Round(results(27).Value, 2) & " КВАрч") Else Me.Invoke(Sub() Label176.Text = "?")

                    If results(28).Quality.ToString = "good" Then Me.Invoke(Sub() Label181.Text = Math.Round(results(28).Value, 2) & " кВт") Else Me.Invoke(Sub() Label181.Text = "?")
                    If results(29).Quality.ToString = "good" Then Me.Invoke(Sub() Label182.Text = Math.Round(results(29).Value, 2) & " кВар") Else Me.Invoke(Sub() Label182.Text = "?")
                    If results(30).Quality.ToString = "good" Then Me.Invoke(Sub() Label183.Text = Math.Round(results(30).Value, 2) & " КВтч") Else Me.Invoke(Sub() Label183.Text = "?")
                    If results(31).Quality.ToString = "good" Then Me.Invoke(Sub() Label184.Text = Math.Round(results(31).Value, 2) & " КВАрч") Else Me.Invoke(Sub() Label184.Text = "?")

                    '##########################################################
                    'ГПА №5
                    If results(32).Quality.ToString = "good" Then Me.Invoke(Sub() Label189.Text = Math.Round(results(32).Value, 2) & " кВт") Else Me.Invoke(Sub() Label189.Text = "?")
                    If results(33).Quality.ToString = "good" Then Me.Invoke(Sub() Label190.Text = Math.Round(results(33).Value, 2) & " кВар") Else Me.Invoke(Sub() Label190.Text = "?")
                    If results(34).Quality.ToString = "good" Then Me.Invoke(Sub() Label191.Text = Math.Round(results(34).Value, 2) & " КВтч") Else Me.Invoke(Sub() Label191.Text = "?")
                    If results(35).Quality.ToString = "good" Then Me.Invoke(Sub() Label192.Text = Math.Round(results(35).Value, 2) & " КВАрч") Else Me.Invoke(Sub() Label192.Text = "?")

                    If results(36).Quality.ToString = "good" Then Me.Invoke(Sub() Label197.Text = Math.Round(results(36).Value, 2) & " кВт") Else Me.Invoke(Sub() Label197.Text = "?")
                    If results(37).Quality.ToString = "good" Then Me.Invoke(Sub() Label198.Text = Math.Round(results(37).Value, 2) & " кВар") Else Me.Invoke(Sub() Label198.Text = "?")
                    If results(38).Quality.ToString = "good" Then Me.Invoke(Sub() Label199.Text = Math.Round(results(38).Value, 2) & " КВтч") Else Me.Invoke(Sub() Label199.Text = "?")
                    If results(39).Quality.ToString = "good" Then Me.Invoke(Sub() Label200.Text = Math.Round(results(39).Value, 2) & " КВАрч") Else Me.Invoke(Sub() Label200.Text = "?")

                    '##########################################################
                    '1 ВВОД
                    If results(42).Quality.ToString = "good" Then Me.Invoke(Sub() Label39.Text = results(42).Value & " кВт") Else Me.Invoke(Sub() Label39.Text = "?")
                    If results(43).Quality.ToString = "good" Then Me.Invoke(Sub() Label40.Text = results(43).Value & " кВар") Else Me.Invoke(Sub() Label40.Text = "?")
                    If results(40).Quality.ToString = "good" Then Me.Invoke(Sub() Label41.Text = results(40).Value & " МВтч") Else Me.Invoke(Sub() Label41.Text = "?")
                    If results(41).Quality.ToString = "good" Then Me.Invoke(Sub() Label42.Text = results(41).Value & " МВАрч") Else Me.Invoke(Sub() Label42.Text = "?")

                    '##########################################################
                    '3 Фидер
                    Me.Invoke(Sub() Label43.Text = results(46).Value & " кВт")
                    Me.Invoke(Sub() Label44.Text = results(47).Value & " кВар")
                    Me.Invoke(Sub() Label45.Text = results(44).Value & " МВтч")
                    Me.Invoke(Sub() Label46.Text = results(45).Value & " МВАрч")

                    '##########################################################
                    '4 Фидер
                    Me.Invoke(Sub() Label47.Text = results(50).Value & " кВт")
                    Me.Invoke(Sub() Label48.Text = results(51).Value & " кВар")
                    Me.Invoke(Sub() Label49.Text = results(48).Value & " МВтч")
                    Me.Invoke(Sub() Label50.Text = results(49).Value & " МВАрч")
                    '##########################################################
                    '5 Фидер
                    Me.Invoke(Sub() Label51.Text = results(54).Value & " кВт")
                    Me.Invoke(Sub() Label52.Text = results(55).Value & " кВар")
                    Me.Invoke(Sub() Label53.Text = results(52).Value & " МВтч")
                    Me.Invoke(Sub() Label54.Text = results(53).Value & " МВАрч")
                    '##########################################################
                    '6 Фидер
                    Me.Invoke(Sub() Label55.Text = results(58).Value & " кВт")
                    Me.Invoke(Sub() Label56.Text = results(59).Value & " кВар")
                    Me.Invoke(Sub() Label57.Text = results(56).Value & " МВтч")
                    Me.Invoke(Sub() Label58.Text = results(57).Value & " МВАрч")
                    '##########################################################
                    '7 Фидер
                    Me.Invoke(Sub() Label59.Text = results(62).Value & " кВт")
                    Me.Invoke(Sub() Label60.Text = results(63).Value & " кВар")
                    Me.Invoke(Sub() Label61.Text = results(60).Value & " МВтч")
                    Me.Invoke(Sub() Label62.Text = results(61).Value & " МВАрч")
                    '##########################################################
                    '8 Фидер
                    Me.Invoke(Sub() Label63.Text = results(66).Value & " кВт")
                    Me.Invoke(Sub() Label64.Text = results(67).Value & " кВар")
                    Me.Invoke(Sub() Label65.Text = results(64).Value & " МВтч")
                    Me.Invoke(Sub() Label66.Text = results(65).Value & " МВАрч")
                    '##########################################################
                    '2 ввод
                    Me.Invoke(Sub() Label96.Text = results(70).Value & " кВт")
                    Me.Invoke(Sub() Label97.Text = results(71).Value & " кВар")
                    Me.Invoke(Sub() Label98.Text = results(68).Value & " МВтч")
                    Me.Invoke(Sub() Label99.Text = results(69).Value & " МВАрч")
                    '12 фидер
                    Me.Invoke(Sub() Label92.Text = results(74).Value & " кВт")
                    Me.Invoke(Sub() Label93.Text = results(75).Value & " кВар")
                    Me.Invoke(Sub() Label94.Text = results(72).Value & " МВтч")
                    Me.Invoke(Sub() Label95.Text = results(73).Value & " МВАрч")
                    '13 фидер
                    Me.Invoke(Sub() Label88.Text = results(78).Value & " кВт")
                    Me.Invoke(Sub() Label89.Text = results(79).Value & " кВар")
                    Me.Invoke(Sub() Label90.Text = results(76).Value & " МВтч")
                    Me.Invoke(Sub() Label91.Text = results(77).Value & " МВАрч")
                    '14 фидер
                    Me.Invoke(Sub() Label84.Text = results(82).Value & " кВт")
                    Me.Invoke(Sub() Label85.Text = results(83).Value & " кВар")
                    Me.Invoke(Sub() Label86.Text = results(80).Value & " МВтч")
                    Me.Invoke(Sub() Label87.Text = results(81).Value & " МВАрч")
                    '15 фидер
                    Me.Invoke(Sub() Label80.Text = results(86).Value & " кВт")
                    Me.Invoke(Sub() Label81.Text = results(87).Value & " кВар")
                    Me.Invoke(Sub() Label82.Text = results(84).Value & " МВтч")
                    Me.Invoke(Sub() Label83.Text = results(85).Value & " МВАрч")
                    '16 фидер
                    Me.Invoke(Sub() Label76.Text = results(90).Value & " кВт")
                    Me.Invoke(Sub() Label77.Text = results(91).Value & " кВар")
                    Me.Invoke(Sub() Label78.Text = results(88).Value & " МВтч")
                    Me.Invoke(Sub() Label79.Text = results(89).Value & " МВАрч")
                    '17 фидер
                    Me.Invoke(Sub() Label72.Text = results(94).Value & " кВт")
                    Me.Invoke(Sub() Label73.Text = results(95).Value & " кВар")
                    Me.Invoke(Sub() Label74.Text = results(92).Value & " МВтч")
                    Me.Invoke(Sub() Label75.Text = results(93).Value & " МВАрч")

                Next

                Threading.Thread.Sleep(10000)
            Loop

        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Private Sub frmASTUE_OPER_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        T_ASTUE.Abort()
        m_server.CancelSubscription(groupASTUE)
    End Sub

    Private Sub frmASTUE_OPER_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Call FONT_SIZE(Me)

        Select Case btn_ASTUE.Text

            Case "Старт"

                btn_ASTUE.Text = "Стоп"
                T_ASTUE = New System.Threading.Thread(AddressOf T_ASTUE_START)
                T_ASTUE.Start()

            Case "Стоп"

                btn_ASTUE.Text = "Старт"
                m_server.CancelSubscription(groupASTUE)
                T_ASTUE.Abort()

        End Select

    End Sub

    Private Sub Label13_Click(sender As System.Object, e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub frmASTUE_OPER_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Call FONT_SIZE(Me)
    End Sub
End Class