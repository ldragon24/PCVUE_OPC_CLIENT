Public Class frmUSTAVKI
    Dim T_VV1 As System.Threading.Thread
    Dim T_VV2 As System.Threading.Thread
    Dim T_F3 As System.Threading.Thread
    Dim T_F4 As System.Threading.Thread
    Dim T_F5 As System.Threading.Thread
    Dim T_F6 As System.Threading.Thread
    Dim T_F7 As System.Threading.Thread
    Dim T_F8 As System.Threading.Thread
    Dim T_F9 As System.Threading.Thread
    Dim T_F2 As System.Threading.Thread
    Dim T_F17 As System.Threading.Thread
    Dim T_F16 As System.Threading.Thread
    Dim T_F15 As System.Threading.Thread
    Dim T_F14 As System.Threading.Thread
    Dim T_F13 As System.Threading.Thread
    Dim T_F12 As System.Threading.Thread

    Dim T_EBv1 As System.Threading.Thread
    Dim T_EBv2 As System.Threading.Thread
    Dim T_EBav As System.Threading.Thread

    Dim T_REBv1 As System.Threading.Thread
    Dim T_REBv2 As System.Threading.Thread
    Dim T_REBav As System.Threading.Thread

    Dim T_AVOv1 As System.Threading.Thread
    Dim T_AVOv2 As System.Threading.Thread


    'EBv1Izm

    Private Sub frmUSTAVKI_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Select Case Me.Text

            Case "Измерения РП 10кВ ВВОД 1"

                T_VV1.Abort()

                m_server.CancelSubscription(group_VOD1Izm)

            Case "Измерения РП 10кВ ВВОД 2"
                T_VV2.Abort()

                m_server.CancelSubscription(group_VOD2Izm)


            Case "Измерения РП 10кВ Фидер 3"

                T_F3.Abort()
                m_server.CancelSubscription(group_F3Izm)

            Case "Измерения РП 10кВ Фидер 4"

                T_F4.Abort()
                m_server.CancelSubscription(group_F4Izm)

            Case "Измерения РП 10кВ Фидер 5"

                T_F5.Abort()
                m_server.CancelSubscription(group_F5Izm)

            Case "Измерения РП 10кВ Фидер 6"

                T_F6.Abort()
                m_server.CancelSubscription(group_F6Izm)

            Case "Измерения РП 10кВ Фидер 7"

                T_F7.Abort()
                m_server.CancelSubscription(group_F7Izm)

            Case "Измерения РП 10кВ Фидер 8"

                T_F8.Abort()
                m_server.CancelSubscription(group_F8Izm)

            Case "Измерения РП 10кВ СВ"

                T_F9.Abort()
                m_server.CancelSubscription(group_F9Izm)

            Case "Измерения РП 10кВ ШТН"

                T_F2.Abort()
                m_server.CancelSubscription(group_F2Izm)

            Case "Измерения РП 10кВ Фидер 17"

                T_F17.Abort()
                m_server.CancelSubscription(group_F17Izm)

            Case "Измерения РП 10кВ Фидер 16"

                T_F16.Abort()
                m_server.CancelSubscription(group_F16Izm)

            Case "Измерения РП 10кВ Фидер 15"

                T_F15.Abort()
                m_server.CancelSubscription(group_F15Izm)

            Case "Измерения РП 10кВ Фидер 14"

                T_F14.Abort()
                m_server.CancelSubscription(group_F14Izm)

            Case "Измерения РП 10кВ Фидер 13"

                T_F13.Abort()
                m_server.CancelSubscription(group_F13Izm)

            Case "Измерения РП 10кВ Фидер 12"

                T_F12.Abort()
                m_server.CancelSubscription(group_F12Izm)

            Case "Измерения КТП ЭБ ВВ1"

                T_EBv1.Abort()
                m_server.CancelSubscription(group_EBv1Izm)

            Case "Измерения КТП ЭБ АВ"

                T_EBav.Abort()
                m_server.CancelSubscription(group_EBavIzm)

            Case "Измерения КТП ЭБ ВВ2"

                T_EBv2.Abort()
                m_server.CancelSubscription(group_EBv2Izm)


            Case "Измерения КТП РЭБ ВВ1"

                T_REBv1.Abort()
                m_server.CancelSubscription(group_REBv1Izm)

            Case "Измерения КТП РЭБ ВВ2"

                T_REBv2.Abort()
                m_server.CancelSubscription(group_REBv2Izm)

            Case "Измерения КТП АВО ВВ1"

                T_AVOv1.Abort()
                m_server.CancelSubscription(group_AVOv1Izm)

            Case "Измерения КТП АВО ВВ2"

                T_AVOv2.Abort()
                m_server.CancelSubscription(group_AVOv2Izm)

            Case "Измерения КТП РЭБ АВ"

                T_REBav.Abort()
                m_server.CancelSubscription(group_REBavIzm)
        End Select

    End Sub

    Private Sub frmUSTAVKI_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Label23.Visible = True
        Label51.Visible = True
        Label25.Visible = True
        Label53.Visible = True

        Select Case Me.Text

            Case "Измерения РП 10кВ ВВОД 1"
               
                T_VV1 = New System.Threading.Thread(AddressOf T_VV1_IZM_START)
                T_VV1.Start()

            Case "Измерения РП 10кВ ВВОД 2"
               
                T_VV2 = New System.Threading.Thread(AddressOf T_VV2_IZM_START)
                T_VV2.Start()

            Case "Измерения РП 10кВ Фидер 3"
                Label23.Visible = False
                Label51.Visible = False
                Label25.Visible = False
                Label53.Visible = False
                T_F3 = New System.Threading.Thread(AddressOf T_F3_IZM_START)
                T_F3.Start()

            Case "Измерения РП 10кВ Фидер 4"
                Label23.Visible = False
                Label51.Visible = False
                Label25.Visible = False
                Label53.Visible = False
                T_F4 = New System.Threading.Thread(AddressOf T_F4_IZM_START)
                T_F4.Start()

            Case "Измерения РП 10кВ Фидер 5"
                Label23.Visible = False
                Label51.Visible = False
                Label25.Visible = False
                Label53.Visible = False
                T_F5 = New System.Threading.Thread(AddressOf T_F5_IZM_START)
                T_F5.Start()

            Case "Измерения РП 10кВ Фидер 6"
                Label23.Visible = False
                Label51.Visible = False
                Label25.Visible = False
                Label53.Visible = False
                T_F6 = New System.Threading.Thread(AddressOf T_F6_IZM_START)
                T_F6.Start()

            Case "Измерения РП 10кВ Фидер 7"
                Label23.Visible = False
                Label51.Visible = False
                Label25.Visible = False
                Label53.Visible = False
                T_F7 = New System.Threading.Thread(AddressOf T_F7_IZM_START)
                T_F7.Start()

            Case "Измерения РП 10кВ Фидер 8"
                Label23.Visible = False
                Label51.Visible = False
                Label25.Visible = False
                Label53.Visible = False
                T_F8 = New System.Threading.Thread(AddressOf T_F8_IZM_START)
                T_F8.Start()

            Case "Измерения РП 10кВ СВ"
                Label23.Visible = False
                Label51.Visible = False
                Label25.Visible = False
                Label53.Visible = False
                T_F9 = New System.Threading.Thread(AddressOf T_F9_IZM_START)
                T_F9.Start()

            Case "Измерения РП 10кВ ШТН"
                Label23.Visible = False
                Label51.Visible = False
                Label25.Visible = False
                Label53.Visible = False
                T_F2 = New System.Threading.Thread(AddressOf T_F2_IZM_START)
                T_F2.Start()

            Case "Измерения РП 10кВ Фидер 17"
                Label23.Visible = False
                Label51.Visible = False
                Label25.Visible = False
                Label53.Visible = False
                T_F17 = New System.Threading.Thread(AddressOf T_F17_IZM_START)
                T_F17.Start()

            Case "Измерения РП 10кВ Фидер 16"
                Label23.Visible = False
                Label51.Visible = False
                Label25.Visible = False
                Label53.Visible = False
                T_F16 = New System.Threading.Thread(AddressOf T_F16_IZM_START)
                T_F16.Start()

            Case "Измерения РП 10кВ Фидер 15"
                Label23.Visible = False
                Label51.Visible = False
                Label25.Visible = False
                Label53.Visible = False
                T_F15 = New System.Threading.Thread(AddressOf T_F15_IZM_START)
                T_F15.Start()

            Case "Измерения РП 10кВ Фидер 14"
                Label23.Visible = False
                Label51.Visible = False
                Label25.Visible = False
                Label53.Visible = False
                T_F14 = New System.Threading.Thread(AddressOf T_F14_IZM_START)
                T_F14.Start()

            Case "Измерения РП 10кВ Фидер 13"
                Label23.Visible = False
                Label51.Visible = False
                Label25.Visible = False
                Label53.Visible = False
                T_F13 = New System.Threading.Thread(AddressOf T_F13_IZM_START)
                T_F13.Start()

            Case "Измерения РП 10кВ Фидер 12"
                Label23.Visible = False
                Label51.Visible = False
                Label25.Visible = False
                Label53.Visible = False
                T_F12 = New System.Threading.Thread(AddressOf T_F12_IZM_START)
                T_F12.Start()


            Case "Измерения КТП ЭБ ВВ1"


                Me.Invoke(Sub() Label1.Text = "IA")
                Me.Invoke(Sub() Label2.Text = "IB")
                Me.Invoke(Sub() Label3.Text = "IC")
                Me.Invoke(Sub() Label4.Text = "3I0")
                Me.Invoke(Sub() Label5.Text = "I1")
                Me.Invoke(Sub() Label6.Text = "I2")
                Me.Invoke(Sub() Label13.Text = "I1_A")
                Me.Invoke(Sub() Label14.Text = "I1_R")

                Me.Invoke(Sub() Label15.Text = "UBB")
                Me.Invoke(Sub() Label16.Text = "UA")
                Me.Invoke(Sub() Label17.Text = "UB")
                Me.Invoke(Sub() Label18.Text = "UC")
                Me.Invoke(Sub() Label19.Text = "3U0")
                Me.Invoke(Sub() Label20.Text = "U1")
                Me.Invoke(Sub() Label21.Text = "F")
                Me.Invoke(Sub() Label22.Text = "COS")

                Label23.Visible = False
                Label24.Visible = False
                Label25.Visible = False
                Label26.Visible = False
                Label27.Visible = False
                Label28.Visible = False
                Label29.Visible = False
                Label30.Visible = False
                Label31.Visible = False
                Label32.Visible = False
                Label33.Visible = False
                Label34.Visible = False
                Label35.Visible = False
                Label36.Visible = False
                Label37.Visible = False

                Label51.Visible = False
                Label52.Visible = False
                Label53.Visible = False
                Label54.Visible = False
                Label55.Visible = False
                Label56.Visible = False
                Label57.Visible = False
                Label58.Visible = False
                Label59.Visible = False
                Label60.Visible = False
                Label61.Visible = False
                Label62.Visible = False
                Label63.Visible = False
                Label64.Visible = False
                Label65.Visible = False

                T_EBv1 = New System.Threading.Thread(AddressOf T_EBv1_IZM_START)
                T_EBv1.Start()

            Case "Измерения КТП ЭБ ВВ2"


                Me.Invoke(Sub() Label1.Text = "IA")
                Me.Invoke(Sub() Label2.Text = "IB")
                Me.Invoke(Sub() Label3.Text = "IC")
                Me.Invoke(Sub() Label4.Text = "3I0")
                Me.Invoke(Sub() Label5.Text = "I1")
                Me.Invoke(Sub() Label6.Text = "I2")
                Me.Invoke(Sub() Label13.Text = "I1_A")
                Me.Invoke(Sub() Label14.Text = "I1_R")

                Me.Invoke(Sub() Label15.Text = "UBB")
                Me.Invoke(Sub() Label16.Text = "UA")
                Me.Invoke(Sub() Label17.Text = "UB")
                Me.Invoke(Sub() Label18.Text = "UC")
                Me.Invoke(Sub() Label19.Text = "3U0")
                Me.Invoke(Sub() Label20.Text = "U1")
                Me.Invoke(Sub() Label21.Text = "F")
                Me.Invoke(Sub() Label22.Text = "COS")

                Label23.Visible = False
                Label24.Visible = False
                Label25.Visible = False
                Label26.Visible = False
                Label27.Visible = False
                Label28.Visible = False
                Label29.Visible = False
                Label30.Visible = False
                Label31.Visible = False
                Label32.Visible = False
                Label33.Visible = False
                Label34.Visible = False
                Label35.Visible = False
                Label36.Visible = False
                Label37.Visible = False

                Label51.Visible = False
                Label52.Visible = False
                Label53.Visible = False
                Label54.Visible = False
                Label55.Visible = False
                Label56.Visible = False
                Label57.Visible = False
                Label58.Visible = False
                Label59.Visible = False
                Label60.Visible = False
                Label61.Visible = False
                Label62.Visible = False
                Label63.Visible = False
                Label64.Visible = False
                Label65.Visible = False

                T_EBv2 = New System.Threading.Thread(AddressOf T_EBv2_IZM_START)
                T_EBv2.Start()
                'EBv1
                'EBv1


            Case "Измерения КТП РЭБ ВВ1"


                Me.Invoke(Sub() Label1.Text = "IA")
                Me.Invoke(Sub() Label2.Text = "IB")
                Me.Invoke(Sub() Label3.Text = "IC")
                Me.Invoke(Sub() Label4.Text = "3I0")
                Me.Invoke(Sub() Label5.Text = "I1")
                Me.Invoke(Sub() Label6.Text = "I2")
                Me.Invoke(Sub() Label13.Text = "I1_A")
                Me.Invoke(Sub() Label14.Text = "I1_R")

                Me.Invoke(Sub() Label15.Text = "UBB")
                Me.Invoke(Sub() Label16.Text = "UA")
                Me.Invoke(Sub() Label17.Text = "UB")
                Me.Invoke(Sub() Label18.Text = "UC")
                Me.Invoke(Sub() Label19.Text = "3U0")
                Me.Invoke(Sub() Label20.Text = "U1")
                Me.Invoke(Sub() Label21.Text = "F")
                Me.Invoke(Sub() Label22.Text = "COS")

                Label23.Visible = False
                Label24.Visible = False
                Label25.Visible = False
                Label26.Visible = False
                Label27.Visible = False
                Label28.Visible = False
                Label29.Visible = False
                Label30.Visible = False
                Label31.Visible = False
                Label32.Visible = False
                Label33.Visible = False
                Label34.Visible = False
                Label35.Visible = False
                Label36.Visible = False
                Label37.Visible = False

                Label51.Visible = False
                Label52.Visible = False
                Label53.Visible = False
                Label54.Visible = False
                Label55.Visible = False
                Label56.Visible = False
                Label57.Visible = False
                Label58.Visible = False
                Label59.Visible = False
                Label60.Visible = False
                Label61.Visible = False
                Label62.Visible = False
                Label63.Visible = False
                Label64.Visible = False
                Label65.Visible = False

                T_REBv1 = New System.Threading.Thread(AddressOf T_REBv1_IZM_START)
                T_REBv1.Start()

            Case "Измерения КТП РЭБ ВВ2"


                Me.Invoke(Sub() Label1.Text = "IA")
                Me.Invoke(Sub() Label2.Text = "IB")
                Me.Invoke(Sub() Label3.Text = "IC")
                Me.Invoke(Sub() Label4.Text = "3I0")
                Me.Invoke(Sub() Label5.Text = "I1")
                Me.Invoke(Sub() Label6.Text = "I2")
                Me.Invoke(Sub() Label13.Text = "I1_A")
                Me.Invoke(Sub() Label14.Text = "I1_R")

                Me.Invoke(Sub() Label15.Text = "UBB")
                Me.Invoke(Sub() Label16.Text = "UA")
                Me.Invoke(Sub() Label17.Text = "UB")
                Me.Invoke(Sub() Label18.Text = "UC")
                Me.Invoke(Sub() Label19.Text = "3U0")
                Me.Invoke(Sub() Label20.Text = "U1")
                Me.Invoke(Sub() Label21.Text = "F")
                Me.Invoke(Sub() Label22.Text = "COS")

                Label23.Visible = False
                Label24.Visible = False
                Label25.Visible = False
                Label26.Visible = False
                Label27.Visible = False
                Label28.Visible = False
                Label29.Visible = False
                Label30.Visible = False
                Label31.Visible = False
                Label32.Visible = False
                Label33.Visible = False
                Label34.Visible = False
                Label35.Visible = False
                Label36.Visible = False
                Label37.Visible = False

                Label51.Visible = False
                Label52.Visible = False
                Label53.Visible = False
                Label54.Visible = False
                Label55.Visible = False
                Label56.Visible = False
                Label57.Visible = False
                Label58.Visible = False
                Label59.Visible = False
                Label60.Visible = False
                Label61.Visible = False
                Label62.Visible = False
                Label63.Visible = False
                Label64.Visible = False
                Label65.Visible = False

                T_REBv2 = New System.Threading.Thread(AddressOf T_REBv2_IZM_START)
                T_REBv2.Start()


            Case "Измерения КТП АВО ВВ1"


                Me.Invoke(Sub() Label1.Text = "IA")
                Me.Invoke(Sub() Label2.Text = "IB")
                Me.Invoke(Sub() Label3.Text = "IC")
                Me.Invoke(Sub() Label4.Text = "3I0")
                Me.Invoke(Sub() Label5.Text = "I1")
                Me.Invoke(Sub() Label6.Text = "I2")
                Me.Invoke(Sub() Label13.Text = "I1_A")
                Me.Invoke(Sub() Label14.Text = "I1_R")

                Me.Invoke(Sub() Label15.Text = "UBB")
                Me.Invoke(Sub() Label16.Text = "UA")
                Me.Invoke(Sub() Label17.Text = "UB")
                Me.Invoke(Sub() Label18.Text = "UC")
                Me.Invoke(Sub() Label19.Text = "3U0")
                Me.Invoke(Sub() Label20.Text = "U1")
                Me.Invoke(Sub() Label21.Text = "F")
                Me.Invoke(Sub() Label22.Text = "COS")

                Label23.Visible = False
                Label24.Visible = False
                Label25.Visible = False
                Label26.Visible = False
                Label27.Visible = False
                Label28.Visible = False
                Label29.Visible = False
                Label30.Visible = False
                Label31.Visible = False
                Label32.Visible = False
                Label33.Visible = False
                Label34.Visible = False
                Label35.Visible = False
                Label36.Visible = False
                Label37.Visible = False

                Label51.Visible = False
                Label52.Visible = False
                Label53.Visible = False
                Label54.Visible = False
                Label55.Visible = False
                Label56.Visible = False
                Label57.Visible = False
                Label58.Visible = False
                Label59.Visible = False
                Label60.Visible = False
                Label61.Visible = False
                Label62.Visible = False
                Label63.Visible = False
                Label64.Visible = False
                Label65.Visible = False

                T_AVOv1 = New System.Threading.Thread(AddressOf T_AVOv1_IZM_START)
                T_AVOv1.Start()

            Case "Измерения КТП АВО ВВ2"


                Me.Invoke(Sub() Label1.Text = "IA")
                Me.Invoke(Sub() Label2.Text = "IB")
                Me.Invoke(Sub() Label3.Text = "IC")
                Me.Invoke(Sub() Label4.Text = "3I0")
                Me.Invoke(Sub() Label5.Text = "I1")
                Me.Invoke(Sub() Label6.Text = "I2")
                Me.Invoke(Sub() Label13.Text = "I1_A")
                Me.Invoke(Sub() Label14.Text = "I1_R")

                Me.Invoke(Sub() Label15.Text = "UBB")
                Me.Invoke(Sub() Label16.Text = "UA")
                Me.Invoke(Sub() Label17.Text = "UB")
                Me.Invoke(Sub() Label18.Text = "UC")
                Me.Invoke(Sub() Label19.Text = "3U0")
                Me.Invoke(Sub() Label20.Text = "U1")
                Me.Invoke(Sub() Label21.Text = "F")
                Me.Invoke(Sub() Label22.Text = "COS")

                Label23.Visible = False
                Label24.Visible = False
                Label25.Visible = False
                Label26.Visible = False
                Label27.Visible = False
                Label28.Visible = False
                Label29.Visible = False
                Label30.Visible = False
                Label31.Visible = False
                Label32.Visible = False
                Label33.Visible = False
                Label34.Visible = False
                Label35.Visible = False
                Label36.Visible = False
                Label37.Visible = False

                Label51.Visible = False
                Label52.Visible = False
                Label53.Visible = False
                Label54.Visible = False
                Label55.Visible = False
                Label56.Visible = False
                Label57.Visible = False
                Label58.Visible = False
                Label59.Visible = False
                Label60.Visible = False
                Label61.Visible = False
                Label62.Visible = False
                Label63.Visible = False
                Label64.Visible = False
                Label65.Visible = False

                T_AVOv2 = New System.Threading.Thread(AddressOf T_AVOv2_IZM_START)
                T_AVOv2.Start()

            Case "Измерения КТП ЭБ АВ"


                Me.Invoke(Sub() Label1.Text = "IA")
                Me.Invoke(Sub() Label2.Text = "IB")
                Me.Invoke(Sub() Label3.Text = "IC")
                Me.Invoke(Sub() Label4.Text = "3I0")
                Me.Invoke(Sub() Label5.Text = "I1")
                Me.Invoke(Sub() Label6.Text = "I2")
                Me.Invoke(Sub() Label13.Text = "I1_A")
                Me.Invoke(Sub() Label14.Text = "I1_R")

                Me.Invoke(Sub() Label15.Text = "UBB")
                Me.Invoke(Sub() Label16.Text = "UA")
                Me.Invoke(Sub() Label17.Text = "UB")
                Me.Invoke(Sub() Label18.Text = "UC")
                Me.Invoke(Sub() Label19.Text = "3U0")
                Me.Invoke(Sub() Label20.Text = "U1")
                Me.Invoke(Sub() Label21.Text = "F")
                Me.Invoke(Sub() Label22.Text = "COS")

                Label23.Visible = False
                Label24.Visible = False
                Label25.Visible = False
                Label26.Visible = False
                Label27.Visible = False
                Label28.Visible = False
                Label29.Visible = False
                Label30.Visible = False
                Label31.Visible = False
                Label32.Visible = False
                Label33.Visible = False
                Label34.Visible = False
                Label35.Visible = False
                Label36.Visible = False
                Label37.Visible = False

                Label51.Visible = False
                Label52.Visible = False
                Label53.Visible = False
                Label54.Visible = False
                Label55.Visible = False
                Label56.Visible = False
                Label57.Visible = False
                Label58.Visible = False
                Label59.Visible = False
                Label60.Visible = False
                Label61.Visible = False
                Label62.Visible = False
                Label63.Visible = False
                Label64.Visible = False
                Label65.Visible = False

                T_EBav = New System.Threading.Thread(AddressOf T_EBav_IZM_START)
                T_EBav.Start()

            Case "Измерения КТП РЭБ АВ"


                Me.Invoke(Sub() Label1.Text = "IA")
                Me.Invoke(Sub() Label2.Text = "IB")
                Me.Invoke(Sub() Label3.Text = "IC")
                Me.Invoke(Sub() Label4.Text = "3I0")
                Me.Invoke(Sub() Label5.Text = "I1")
                Me.Invoke(Sub() Label6.Text = "I2")
                Me.Invoke(Sub() Label13.Text = "I1_A")
                Me.Invoke(Sub() Label14.Text = "I1_R")

                Me.Invoke(Sub() Label15.Text = "UBB")
                Me.Invoke(Sub() Label16.Text = "UA")
                Me.Invoke(Sub() Label17.Text = "UB")
                Me.Invoke(Sub() Label18.Text = "UC")
                Me.Invoke(Sub() Label19.Text = "3U0")
                Me.Invoke(Sub() Label20.Text = "U1")
                Me.Invoke(Sub() Label21.Text = "F")
                Me.Invoke(Sub() Label22.Text = "COS")

                Label23.Visible = False
                Label24.Visible = False
                Label25.Visible = False
                Label26.Visible = False
                Label27.Visible = False
                Label28.Visible = False
                Label29.Visible = False
                Label30.Visible = False
                Label31.Visible = False
                Label32.Visible = False
                Label33.Visible = False
                Label34.Visible = False
                Label35.Visible = False
                Label36.Visible = False
                Label37.Visible = False

                Label51.Visible = False
                Label52.Visible = False
                Label53.Visible = False
                Label54.Visible = False
                Label55.Visible = False
                Label56.Visible = False
                Label57.Visible = False
                Label58.Visible = False
                Label59.Visible = False
                Label60.Visible = False
                Label61.Visible = False
                Label62.Visible = False
                Label63.Visible = False
                Label64.Visible = False
                Label65.Visible = False

                T_REBav = New System.Threading.Thread(AddressOf T_rEBav_IZM_START)
                T_REBav.Start()

        End Select


    End Sub

    Sub T_VV1_IZM_START()

        Try

ARG:
            groupState_VOD1Izm.Name = "VOD1Izm"
            groupState_VOD1Izm.Active = True
            groupState_VOD1Izm.UpdateRate = MSPEED

            group_VOD1Izm = DirectCast(m_server.CreateSubscription(groupState_VOD1Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(30) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С1.1_ВВОД.I1"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С1.1_ВВОД.I2"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С1.1_ВВОД.I3"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С1.1_ВВОД.Im1"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С1.1_ВВОД.Im2"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С1.1_ВВОД.Im3"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С1.1_ВВОД.U_12"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С1.1_ВВОД.U_23"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С1.1_ВВОД.U_31"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С1.1_ВВОД.P"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С1.1_ВВОД.Q"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С1.1_ВВОД.S"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С1.1_ВВОД.PM"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С1.1_ВВОД.QM"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С1.1_ВВОД.COS_PHI"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.С1.1_ВВОД.EP_POS"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.С1.1_ВВОД.EP_NEG"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РП10.С1.1_ВВОД.EQ_POS"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РП10.С1.1_ВВОД.EQ_NEG"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "РП10.С1.1_ВВОД.CNT_CMT"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "РП10.С1.1_ВВОД.CNT_PHCMT"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "РП10.С1.1_ВВОД.CNT_DO"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С1.1_ВВОД.Itrip1"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С1.1_ВВОД.Itrip2"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С1.1_ВВОД.Itrip3"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С1.1_ВВОД.SUM_TRIP_I1"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С1.1_ВВОД.SUM_TRIP_I2"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С1.1_ВВОД.SUM_TRIP_I3"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С1.1_ВВОД.SUM_TRIP_I4"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С1.1_ВВОД.SUM_TRIP_I5"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С1.1_ВВОД.OPER_TIME"

            items = group_VOD1Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_VOD1Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = results(0).Value & " A")
                    Me.Invoke(Sub() Label8.Text = results(1).Value & " A")
                    Me.Invoke(Sub() Label9.Text = results(2).Value & " A")
                    Me.Invoke(Sub() Label10.Text = results(3).Value & " A")
                    Me.Invoke(Sub() Label11.Text = results(4).Value & " A")
                    Me.Invoke(Sub() Label12.Text = results(5).Value & " A")
                    Me.Invoke(Sub() Label41.Text = results(6).Value & " кВ")
                    Me.Invoke(Sub() Label42.Text = results(7).Value & " кВ")
                    Me.Invoke(Sub() Label43.Text = results(8).Value & " кВ")
                    Me.Invoke(Sub() Label44.Text = results(9).Value & " кВт")
                    Me.Invoke(Sub() Label45.Text = results(10).Value & " кВар")
                    Me.Invoke(Sub() Label46.Text = results(11).Value & " кВА")
                    Me.Invoke(Sub() Label47.Text = results(12).Value & " кВт")
                    Me.Invoke(Sub() Label48.Text = results(13).Value & " кВар")
                    Me.Invoke(Sub() Label49.Text = results(14).Value & " ")
                    Me.Invoke(Sub() Label50.Text = results(15).Value & " МВтч")
                    Me.Invoke(Sub() Label51.Text = results(16).Value & " МВтч")
                    Me.Invoke(Sub() Label52.Text = results(17).Value & " МВАрч")
                    Me.Invoke(Sub() Label53.Text = results(18).Value & " МВАрч")
                    Me.Invoke(Sub() Label54.Text = results(19).Value & " ")
                    Me.Invoke(Sub() Label55.Text = results(20).Value)
                    Me.Invoke(Sub() Label56.Text = results(21).Value)
                    Me.Invoke(Sub() Label57.Text = results(22).Value & " А")
                    Me.Invoke(Sub() Label58.Text = results(23).Value & " А")
                    Me.Invoke(Sub() Label59.Text = results(24).Value & " А")
                    Me.Invoke(Sub() Label60.Text = results(25).Value & " кА")
                    Me.Invoke(Sub() Label61.Text = results(26).Value & " кА")
                    Me.Invoke(Sub() Label62.Text = results(27).Value & " кА")
                    Me.Invoke(Sub() Label63.Text = results(28).Value & " кА")
                    Me.Invoke(Sub() Label64.Text = results(29).Value & " кА")
                    Me.Invoke(Sub() Label65.Text = results(30).Value & " мс.")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_VV2_IZM_START()

        Try

ARG:
            groupState_VOD2Izm.Name = "VOD2Izm"
            groupState_VOD2Izm.Active = True
            groupState_VOD2Izm.UpdateRate = MSPEED

            group_VOD2Izm = DirectCast(m_server.CreateSubscription(groupState_VOD2Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(31) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С2.10_ВВОД.I1"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С2.10_ВВОД.I2"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С2.10_ВВОД.I3"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С2.10_ВВОД.Im1"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С2.10_ВВОД.Im2"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С2.10_ВВОД.Im3"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С2.10_ВВОД.U_12"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С2.10_ВВОД.U_23"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С2.10_ВВОД.U_31"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С2.10_ВВОД.P"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С2.10_ВВОД.Q"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С2.10_ВВОД.S"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С2.10_ВВОД.PM"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С2.10_ВВОД.QM"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С2.10_ВВОД.COS_PHI"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.С2.10_ВВОД.EP_POS"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.С2.10_ВВОД.EP_NEG"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РП10.С2.10_ВВОД.EQ_POS"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РП10.С2.10_ВВОД.EQ_NEG"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "РП10.С2.10_ВВОД.CNT_CMT"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "РП10.С2.10_ВВОД.CNT_PHCMT"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "РП10.С2.10_ВВОД.CNT_DO"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С2.10_ВВОД.Itrip1"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С2.10_ВВОД.Itrip2"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С2.10_ВВОД.Itrip3"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С2.10_ВВОД.SUM_TRIP_I1"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С2.10_ВВОД.SUM_TRIP_I2"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С2.10_ВВОД.SUM_TRIP_I3"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С2.10_ВВОД.SUM_TRIP_I4"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С2.10_ВВОД.SUM_TRIP_I5"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С2.10_ВВОД.OPER_TIME"

            items(31) = New Global.Opc.Da.Item()
            items(31).ItemName = "РП10.С1.1_ВВОД.FREQ"


            'РП10.С1.1_ВВОД.FREQ
            items = group_VOD2Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_VOD2Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = results(0).Value & " A")
                    Me.Invoke(Sub() Label8.Text = results(1).Value & " A")
                    Me.Invoke(Sub() Label9.Text = results(2).Value & " A")
                    Me.Invoke(Sub() Label10.Text = results(3).Value & " A")
                    Me.Invoke(Sub() Label11.Text = results(4).Value & " A")
                    Me.Invoke(Sub() Label12.Text = results(5).Value & " A")
                    Me.Invoke(Sub() Label41.Text = results(6).Value & " кВ")
                    Me.Invoke(Sub() Label42.Text = results(7).Value & " кВ")
                    Me.Invoke(Sub() Label43.Text = results(8).Value & " кВ")

                    Me.Invoke(Sub() Label44.Text = results(9).Value & " кВт")


                    Me.Invoke(Sub() Label45.Text = results(10).Value & " кВар")
                    Me.Invoke(Sub() Label46.Text = results(11).Value & " кВА")
                    Me.Invoke(Sub() Label47.Text = results(12).Value & " кВт")
                    Me.Invoke(Sub() Label48.Text = results(13).Value & " кВар")
                    Me.Invoke(Sub() Label49.Text = results(14).Value & " ")
                    Me.Invoke(Sub() Label50.Text = results(15).Value & " МВтч")
                    Me.Invoke(Sub() Label51.Text = results(16).Value & " МВтч")
                    Me.Invoke(Sub() Label52.Text = results(17).Value & " МВАрч")
                    Me.Invoke(Sub() Label53.Text = results(18).Value & " МВАрч")
                    Me.Invoke(Sub() Label54.Text = results(19).Value & " ")
                    Me.Invoke(Sub() Label55.Text = results(20).Value)
                    Me.Invoke(Sub() Label56.Text = results(21).Value)
                    Me.Invoke(Sub() Label57.Text = results(22).Value & " А")
                    Me.Invoke(Sub() Label58.Text = results(23).Value & " А")
                    Me.Invoke(Sub() Label59.Text = results(24).Value & " А")
                    Me.Invoke(Sub() Label60.Text = results(25).Value & " кА")
                    Me.Invoke(Sub() Label61.Text = results(26).Value & " кА")
                    Me.Invoke(Sub() Label62.Text = results(27).Value & " кА")
                    Me.Invoke(Sub() Label63.Text = results(28).Value & " кА")
                    Me.Invoke(Sub() Label64.Text = results(29).Value & " кА")
                    Me.Invoke(Sub() Label65.Text = results(30).Value & " мс.")
                    '  Me.Invoke(Sub() Label44.Text = results(31).Value & " Гц")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_F3_IZM_START()

        Try

ARG:
            groupState_F3Izm.Name = "F3Izm"
            groupState_F3Izm.Active = True
            groupState_F3Izm.UpdateRate = MSPEED

            group_F3Izm = DirectCast(m_server.CreateSubscription(groupState_F3Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(30) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С1.3_ФИД.I1"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С1.3_ФИД.I2"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С1.3_ФИД.I3"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С1.3_ФИД.Im1"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С1.3_ФИД.Im2"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С1.3_ФИД.Im3"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С1.3_ФИД.U_12"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С1.3_ФИД.U_23"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С1.3_ФИД.U_31"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С1.3_ФИД.P"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С1.3_ФИД.Q"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С1.3_ФИД.S"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С1.3_ФИД.PM"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С1.3_ФИД.QM"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С1.3_ФИД.COS_PHI"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.С1.3_ФИД.EP_POS"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.С1.3_ФИД.EP_NEG"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РП10.С1.3_ФИД.EQ_POS"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РП10.С1.3_ФИД.EQ_NEG"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "РП10.С1.3_ФИД.CNT_CMT"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "РП10.С1.3_ФИД.CNT_PHCMT"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "РП10.С1.3_ФИД.CNT_DO"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С1.3_ФИД.Itrip1"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С1.3_ФИД.Itrip2"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С1.3_ФИД.Itrip3"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С1.3_ФИД.SUM_TRIP_I1"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С1.3_ФИД.SUM_TRIP_I2"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С1.3_ФИД.SUM_TRIP_I3"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С1.3_ФИД.SUM_TRIP_I4"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С1.3_ФИД.SUM_TRIP_I5"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С1.3_ФИД.OPER_TIME"

            items = group_F3Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_F3Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = results(0).Value & " A")
                    Me.Invoke(Sub() Label8.Text = results(1).Value & " A")
                    Me.Invoke(Sub() Label9.Text = results(2).Value & " A")
                    Me.Invoke(Sub() Label10.Text = results(3).Value & " A")
                    Me.Invoke(Sub() Label11.Text = results(4).Value & " A")
                    Me.Invoke(Sub() Label12.Text = results(5).Value & " A")
                    Me.Invoke(Sub() Label41.Text = results(6).Value & " кВ")
                    Me.Invoke(Sub() Label42.Text = results(7).Value & " кВ")
                    Me.Invoke(Sub() Label43.Text = results(8).Value & " кВ")
                    Me.Invoke(Sub() Label44.Text = results(9).Value & " кВт")
                    Me.Invoke(Sub() Label45.Text = results(10).Value & " кВар")
                    Me.Invoke(Sub() Label46.Text = results(11).Value & " кВА")
                    Me.Invoke(Sub() Label47.Text = results(12).Value & " кВт")
                    Me.Invoke(Sub() Label48.Text = results(13).Value & " кВар")
                    Me.Invoke(Sub() Label49.Text = results(14).Value & " ")
                    Me.Invoke(Sub() Label50.Text = results(15).Value & " МВтч")
                    Me.Invoke(Sub() Label51.Text = results(16).Value & " МВтч")
                    Me.Invoke(Sub() Label52.Text = results(17).Value & " МВАрч")
                    Me.Invoke(Sub() Label53.Text = results(18).Value & " МВАрч")
                    Me.Invoke(Sub() Label54.Text = results(19).Value & " ")
                    Me.Invoke(Sub() Label55.Text = results(20).Value)
                    Me.Invoke(Sub() Label56.Text = results(21).Value)
                    Me.Invoke(Sub() Label57.Text = results(22).Value & " А")
                    Me.Invoke(Sub() Label58.Text = results(23).Value & " А")
                    Me.Invoke(Sub() Label59.Text = results(24).Value & " А")
                    Me.Invoke(Sub() Label60.Text = results(25).Value & " кА")
                    Me.Invoke(Sub() Label61.Text = results(26).Value & " кА")
                    Me.Invoke(Sub() Label62.Text = results(27).Value & " кА")
                    Me.Invoke(Sub() Label63.Text = results(28).Value & " кА")
                    Me.Invoke(Sub() Label64.Text = results(29).Value & " кА")
                    Me.Invoke(Sub() Label65.Text = results(30).Value & " мс.")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_F4_IZM_START()

        Try

ARG:
            groupState_F4Izm.Name = "F4Izm"
            groupState_F4Izm.Active = True
            groupState_F4Izm.UpdateRate = MSPEED

            group_F4Izm = DirectCast(m_server.CreateSubscription(groupState_F4Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(30) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С1.4_ФИД.I1"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С1.4_ФИД.I2"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С1.4_ФИД.I3"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С1.4_ФИД.Im1"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С1.4_ФИД.Im2"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С1.4_ФИД.Im3"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С1.4_ФИД.U_12"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С1.4_ФИД.U_23"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С1.4_ФИД.U_31"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С1.4_ФИД.P"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С1.4_ФИД.Q"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С1.4_ФИД.S"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С1.4_ФИД.PM"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С1.4_ФИД.QM"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С1.4_ФИД.COS_PHI"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.С1.4_ФИД.EP_POS"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.С1.4_ФИД.EP_NEG"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РП10.С1.4_ФИД.EQ_POS"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РП10.С1.4_ФИД.EQ_NEG"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "РП10.С1.4_ФИД.CNT_CMT"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "РП10.С1.4_ФИД.CNT_PHCMT"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "РП10.С1.4_ФИД.CNT_DO"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С1.4_ФИД.Itrip1"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С1.4_ФИД.Itrip2"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С1.4_ФИД.Itrip3"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С1.4_ФИД.SUM_TRIP_I1"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С1.4_ФИД.SUM_TRIP_I2"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С1.4_ФИД.SUM_TRIP_I3"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С1.4_ФИД.SUM_TRIP_I4"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С1.4_ФИД.SUM_TRIP_I5"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С1.4_ФИД.OPER_TIME"

            items = group_F4Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_F4Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = results(0).Value & " A")
                    Me.Invoke(Sub() Label8.Text = results(1).Value & " A")
                    Me.Invoke(Sub() Label9.Text = results(2).Value & " A")
                    Me.Invoke(Sub() Label10.Text = results(3).Value & " A")
                    Me.Invoke(Sub() Label11.Text = results(4).Value & " A")
                    Me.Invoke(Sub() Label12.Text = results(5).Value & " A")
                    Me.Invoke(Sub() Label41.Text = results(6).Value & " кВ")
                    Me.Invoke(Sub() Label42.Text = results(7).Value & " кВ")
                    Me.Invoke(Sub() Label43.Text = results(8).Value & " кВ")
                    Me.Invoke(Sub() Label44.Text = results(9).Value & " кВт")
                    Me.Invoke(Sub() Label45.Text = results(10).Value & " кВар")
                    Me.Invoke(Sub() Label46.Text = results(11).Value & " кВА")
                    Me.Invoke(Sub() Label47.Text = results(12).Value & " кВт")
                    Me.Invoke(Sub() Label48.Text = results(13).Value & " кВар")
                    Me.Invoke(Sub() Label49.Text = results(14).Value & " ")
                    Me.Invoke(Sub() Label50.Text = results(15).Value & " МВтч")
                    Me.Invoke(Sub() Label51.Text = results(16).Value & " МВтч")
                    Me.Invoke(Sub() Label52.Text = results(17).Value & " МВАрч")
                    Me.Invoke(Sub() Label53.Text = results(18).Value & " МВАрч")
                    Me.Invoke(Sub() Label54.Text = results(19).Value & " ")
                    Me.Invoke(Sub() Label55.Text = results(20).Value)
                    Me.Invoke(Sub() Label56.Text = results(21).Value)
                    Me.Invoke(Sub() Label57.Text = results(22).Value & " А")
                    Me.Invoke(Sub() Label58.Text = results(23).Value & " А")
                    Me.Invoke(Sub() Label59.Text = results(24).Value & " А")
                    Me.Invoke(Sub() Label60.Text = results(25).Value & " кА")
                    Me.Invoke(Sub() Label61.Text = results(26).Value & " кА")
                    Me.Invoke(Sub() Label62.Text = results(27).Value & " кА")
                    Me.Invoke(Sub() Label63.Text = results(28).Value & " кА")
                    Me.Invoke(Sub() Label64.Text = results(29).Value & " кА")
                    Me.Invoke(Sub() Label65.Text = results(30).Value & " мс.")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_F5_IZM_START()

        Try

ARG:
            groupState_F5Izm.Name = "F5Izm"
            groupState_F5Izm.Active = True
            groupState_F5Izm.UpdateRate = MSPEED

            group_F5Izm = DirectCast(m_server.CreateSubscription(groupState_F5Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(30) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С1.5_ФИД.I1"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С1.5_ФИД.I2"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С1.5_ФИД.I3"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С1.5_ФИД.Im1"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С1.5_ФИД.Im2"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С1.5_ФИД.Im3"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С1.5_ФИД.U_12"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С1.5_ФИД.U_23"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С1.5_ФИД.U_31"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С1.5_ФИД.P"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С1.5_ФИД.Q"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С1.5_ФИД.S"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С1.5_ФИД.PM"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С1.5_ФИД.QM"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С1.5_ФИД.COS_PHI"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.С1.5_ФИД.EP_POS"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.С1.5_ФИД.EP_NEG"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РП10.С1.5_ФИД.EQ_POS"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РП10.С1.5_ФИД.EQ_NEG"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "РП10.С1.5_ФИД.CNT_CMT"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "РП10.С1.5_ФИД.CNT_PHCMT"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "РП10.С1.5_ФИД.CNT_DO"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С1.5_ФИД.Itrip1"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С1.5_ФИД.Itrip2"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С1.5_ФИД.Itrip3"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С1.5_ФИД.SUM_TRIP_I1"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С1.5_ФИД.SUM_TRIP_I2"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С1.5_ФИД.SUM_TRIP_I3"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С1.5_ФИД.SUM_TRIP_I4"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С1.5_ФИД.SUM_TRIP_I5"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С1.5_ФИД.OPER_TIME"

            items = group_F5Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_F5Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = results(0).Value & " A")
                    Me.Invoke(Sub() Label8.Text = results(1).Value & " A")
                    Me.Invoke(Sub() Label9.Text = results(2).Value & " A")
                    Me.Invoke(Sub() Label10.Text = results(3).Value & " A")
                    Me.Invoke(Sub() Label11.Text = results(4).Value & " A")
                    Me.Invoke(Sub() Label12.Text = results(5).Value & " A")
                    Me.Invoke(Sub() Label41.Text = results(6).Value & " кВ")
                    Me.Invoke(Sub() Label42.Text = results(7).Value & " кВ")
                    Me.Invoke(Sub() Label43.Text = results(8).Value & " кВ")
                    Me.Invoke(Sub() Label44.Text = results(9).Value & " кВт")
                    Me.Invoke(Sub() Label45.Text = results(10).Value & " кВар")
                    Me.Invoke(Sub() Label46.Text = results(11).Value & " кВА")
                    Me.Invoke(Sub() Label47.Text = results(12).Value & " кВт")
                    Me.Invoke(Sub() Label48.Text = results(13).Value & " кВар")
                    Me.Invoke(Sub() Label49.Text = results(14).Value & " ")
                    Me.Invoke(Sub() Label50.Text = results(15).Value & " МВтч")
                    Me.Invoke(Sub() Label51.Text = results(16).Value & " МВтч")
                    Me.Invoke(Sub() Label52.Text = results(17).Value & " МВАрч")
                    Me.Invoke(Sub() Label53.Text = results(18).Value & " МВАрч")
                    Me.Invoke(Sub() Label54.Text = results(19).Value & " ")
                    Me.Invoke(Sub() Label55.Text = results(20).Value)
                    Me.Invoke(Sub() Label56.Text = results(21).Value)
                    Me.Invoke(Sub() Label57.Text = results(22).Value & " А")
                    Me.Invoke(Sub() Label58.Text = results(23).Value & " А")
                    Me.Invoke(Sub() Label59.Text = results(24).Value & " А")
                    Me.Invoke(Sub() Label60.Text = results(25).Value & " кА")
                    Me.Invoke(Sub() Label61.Text = results(26).Value & " кА")
                    Me.Invoke(Sub() Label62.Text = results(27).Value & " кА")
                    Me.Invoke(Sub() Label63.Text = results(28).Value & " кА")
                    Me.Invoke(Sub() Label64.Text = results(29).Value & " кА")
                    Me.Invoke(Sub() Label65.Text = results(30).Value & " мс.")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_F6_IZM_START()

        Try

ARG:
            groupState_F6Izm.Name = "F6Izm"
            groupState_F6Izm.Active = True
            groupState_F6Izm.UpdateRate = MSPEED

            group_F6Izm = DirectCast(m_server.CreateSubscription(groupState_F6Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(30) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С1.6_ФИД.I1"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С1.6_ФИД.I2"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С1.6_ФИД.I3"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С1.6_ФИД.Im1"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С1.6_ФИД.Im2"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С1.6_ФИД.Im3"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С1.6_ФИД.U_12"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С1.6_ФИД.U_23"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С1.6_ФИД.U_31"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С1.6_ФИД.P"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С1.6_ФИД.Q"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С1.6_ФИД.S"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С1.6_ФИД.PM"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С1.6_ФИД.QM"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С1.6_ФИД.COS_PHI"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.С1.6_ФИД.EP_POS"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.С1.6_ФИД.EP_NEG"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РП10.С1.6_ФИД.EQ_POS"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РП10.С1.6_ФИД.EQ_NEG"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "РП10.С1.6_ФИД.CNT_CMT"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "РП10.С1.6_ФИД.CNT_PHCMT"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "РП10.С1.6_ФИД.CNT_DO"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С1.6_ФИД.Itrip1"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С1.6_ФИД.Itrip2"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С1.6_ФИД.Itrip3"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С1.6_ФИД.SUM_TRIP_I1"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С1.6_ФИД.SUM_TRIP_I2"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С1.6_ФИД.SUM_TRIP_I3"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С1.6_ФИД.SUM_TRIP_I4"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С1.6_ФИД.SUM_TRIP_I5"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С1.6_ФИД.OPER_TIME"

            items = group_F6Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_F6Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = results(0).Value & " A")
                    Me.Invoke(Sub() Label8.Text = results(1).Value & " A")
                    Me.Invoke(Sub() Label9.Text = results(2).Value & " A")
                    Me.Invoke(Sub() Label10.Text = results(3).Value & " A")
                    Me.Invoke(Sub() Label11.Text = results(4).Value & " A")
                    Me.Invoke(Sub() Label12.Text = results(5).Value & " A")
                    Me.Invoke(Sub() Label41.Text = results(6).Value & " кВ")
                    Me.Invoke(Sub() Label42.Text = results(7).Value & " кВ")
                    Me.Invoke(Sub() Label43.Text = results(8).Value & " кВ")
                    Me.Invoke(Sub() Label44.Text = results(9).Value & " кВт")
                    Me.Invoke(Sub() Label45.Text = results(10).Value & " кВар")
                    Me.Invoke(Sub() Label46.Text = results(11).Value & " кВА")
                    Me.Invoke(Sub() Label47.Text = results(12).Value & " кВт")
                    Me.Invoke(Sub() Label48.Text = results(13).Value & " кВар")
                    Me.Invoke(Sub() Label49.Text = results(14).Value & " ")
                    Me.Invoke(Sub() Label50.Text = results(15).Value & " МВтч")
                    Me.Invoke(Sub() Label51.Text = results(16).Value & " МВтч")
                    Me.Invoke(Sub() Label52.Text = results(17).Value & " МВАрч")
                    Me.Invoke(Sub() Label53.Text = results(18).Value & " МВАрч")
                    Me.Invoke(Sub() Label54.Text = results(19).Value & " ")
                    Me.Invoke(Sub() Label55.Text = results(20).Value)
                    Me.Invoke(Sub() Label56.Text = results(21).Value)
                    Me.Invoke(Sub() Label57.Text = results(22).Value & " А")
                    Me.Invoke(Sub() Label58.Text = results(23).Value & " А")
                    Me.Invoke(Sub() Label59.Text = results(24).Value & " А")
                    Me.Invoke(Sub() Label60.Text = results(25).Value & " кА")
                    Me.Invoke(Sub() Label61.Text = results(26).Value & " кА")
                    Me.Invoke(Sub() Label62.Text = results(27).Value & " кА")
                    Me.Invoke(Sub() Label63.Text = results(28).Value & " кА")
                    Me.Invoke(Sub() Label64.Text = results(29).Value & " кА")
                    Me.Invoke(Sub() Label65.Text = results(30).Value & " мс.")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_F7_IZM_START()

        Try

ARG:
            groupState_F7Izm.Name = "F7Izm"
            groupState_F7Izm.Active = True
            groupState_F7Izm.UpdateRate = MSPEED

            group_F7Izm = DirectCast(m_server.CreateSubscription(groupState_F7Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(30) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С1.7_ФИД.I1"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С1.7_ФИД.I2"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С1.7_ФИД.I3"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С1.7_ФИД.Im1"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С1.7_ФИД.Im2"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С1.7_ФИД.Im3"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С1.7_ФИД.U_12"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С1.7_ФИД.U_23"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С1.7_ФИД.U_31"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С1.7_ФИД.P"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С1.7_ФИД.Q"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С1.7_ФИД.S"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С1.7_ФИД.PM"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С1.7_ФИД.QM"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С1.7_ФИД.COS_PHI"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.С1.7_ФИД.EP_POS"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.С1.7_ФИД.EP_NEG"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РП10.С1.7_ФИД.EQ_POS"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РП10.С1.7_ФИД.EQ_NEG"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "РП10.С1.7_ФИД.CNT_CMT"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "РП10.С1.7_ФИД.CNT_PHCMT"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "РП10.С1.7_ФИД.CNT_DO"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С1.7_ФИД.Itrip1"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С1.7_ФИД.Itrip2"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С1.7_ФИД.Itrip3"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С1.7_ФИД.SUM_TRIP_I1"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С1.7_ФИД.SUM_TRIP_I2"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С1.7_ФИД.SUM_TRIP_I3"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С1.7_ФИД.SUM_TRIP_I4"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С1.7_ФИД.SUM_TRIP_I5"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С1.7_ФИД.OPER_TIME"

            items = group_F7Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_F7Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = results(0).Value & " A")
                    Me.Invoke(Sub() Label8.Text = results(1).Value & " A")
                    Me.Invoke(Sub() Label9.Text = results(2).Value & " A")
                    Me.Invoke(Sub() Label10.Text = results(3).Value & " A")
                    Me.Invoke(Sub() Label11.Text = results(4).Value & " A")
                    Me.Invoke(Sub() Label12.Text = results(5).Value & " A")
                    Me.Invoke(Sub() Label41.Text = results(6).Value & " кВ")
                    Me.Invoke(Sub() Label42.Text = results(7).Value & " кВ")
                    Me.Invoke(Sub() Label43.Text = results(8).Value & " кВ")
                    Me.Invoke(Sub() Label44.Text = results(9).Value & " кВт")
                    Me.Invoke(Sub() Label45.Text = results(10).Value & " кВар")
                    Me.Invoke(Sub() Label46.Text = results(11).Value & " кВА")
                    Me.Invoke(Sub() Label47.Text = results(12).Value & " кВт")
                    Me.Invoke(Sub() Label48.Text = results(13).Value & " кВар")
                    Me.Invoke(Sub() Label49.Text = results(14).Value & " ")
                    Me.Invoke(Sub() Label50.Text = results(15).Value & " МВтч")
                    Me.Invoke(Sub() Label51.Text = results(16).Value & " МВтч")
                    Me.Invoke(Sub() Label52.Text = results(17).Value & " МВАрч")
                    Me.Invoke(Sub() Label53.Text = results(18).Value & " МВАрч")
                    Me.Invoke(Sub() Label54.Text = results(19).Value & " ")
                    Me.Invoke(Sub() Label55.Text = results(20).Value)
                    Me.Invoke(Sub() Label56.Text = results(21).Value)
                    Me.Invoke(Sub() Label57.Text = results(22).Value & " А")
                    Me.Invoke(Sub() Label58.Text = results(23).Value & " А")
                    Me.Invoke(Sub() Label59.Text = results(24).Value & " А")
                    Me.Invoke(Sub() Label60.Text = results(25).Value & " кА")
                    Me.Invoke(Sub() Label61.Text = results(26).Value & " кА")
                    Me.Invoke(Sub() Label62.Text = results(27).Value & " кА")
                    Me.Invoke(Sub() Label63.Text = results(28).Value & " кА")
                    Me.Invoke(Sub() Label64.Text = results(29).Value & " кА")
                    Me.Invoke(Sub() Label65.Text = results(30).Value & " мс.")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_F8_IZM_START()

        Try

ARG:
            groupState_F8Izm.Name = "F8Izm"
            groupState_F8Izm.Active = True
            groupState_F8Izm.UpdateRate = MSPEED

            group_F8Izm = DirectCast(m_server.CreateSubscription(groupState_F8Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(30) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С1.8_ФИД.I1"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С1.8_ФИД.I2"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С1.8_ФИД.I3"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С1.8_ФИД.Im1"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С1.8_ФИД.Im2"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С1.8_ФИД.Im3"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С1.8_ФИД.U_12"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С1.8_ФИД.U_23"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С1.8_ФИД.U_31"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С1.8_ФИД.P"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С1.8_ФИД.Q"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С1.8_ФИД.S"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С1.8_ФИД.PM"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С1.8_ФИД.QM"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С1.8_ФИД.COS_PHI"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.С1.8_ФИД.EP_POS"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.С1.8_ФИД.EP_NEG"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РП10.С1.8_ФИД.EQ_POS"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РП10.С1.8_ФИД.EQ_NEG"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "РП10.С1.8_ФИД.CNT_CMT"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "РП10.С1.8_ФИД.CNT_PHCMT"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "РП10.С1.8_ФИД.CNT_DO"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С1.8_ФИД.Itrip1"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С1.8_ФИД.Itrip2"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С1.8_ФИД.Itrip3"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С1.8_ФИД.SUM_TRIP_I1"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С1.8_ФИД.SUM_TRIP_I2"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С1.8_ФИД.SUM_TRIP_I3"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С1.8_ФИД.SUM_TRIP_I4"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С1.8_ФИД.SUM_TRIP_I5"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С1.8_ФИД.OPER_TIME"

            items = group_F8Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_F8Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = results(0).Value & " A")
                    Me.Invoke(Sub() Label8.Text = results(1).Value & " A")
                    Me.Invoke(Sub() Label9.Text = results(2).Value & " A")
                    Me.Invoke(Sub() Label10.Text = results(3).Value & " A")
                    Me.Invoke(Sub() Label11.Text = results(4).Value & " A")
                    Me.Invoke(Sub() Label12.Text = results(5).Value & " A")
                    Me.Invoke(Sub() Label41.Text = results(6).Value & " кВ")
                    Me.Invoke(Sub() Label42.Text = results(7).Value & " кВ")
                    Me.Invoke(Sub() Label43.Text = results(8).Value & " кВ")
                    Me.Invoke(Sub() Label44.Text = results(9).Value & " кВт")
                    Me.Invoke(Sub() Label45.Text = results(10).Value & " кВар")
                    Me.Invoke(Sub() Label46.Text = results(11).Value & " кВА")
                    Me.Invoke(Sub() Label47.Text = results(12).Value & " кВт")
                    Me.Invoke(Sub() Label48.Text = results(13).Value & " кВар")
                    Me.Invoke(Sub() Label49.Text = results(14).Value & " ")
                    Me.Invoke(Sub() Label50.Text = results(15).Value & " МВтч")
                    Me.Invoke(Sub() Label51.Text = results(16).Value & " МВтч")
                    Me.Invoke(Sub() Label52.Text = results(17).Value & " МВАрч")
                    Me.Invoke(Sub() Label53.Text = results(18).Value & " МВАрч")
                    Me.Invoke(Sub() Label54.Text = results(19).Value & " ")
                    Me.Invoke(Sub() Label55.Text = results(20).Value)
                    Me.Invoke(Sub() Label56.Text = results(21).Value)
                    Me.Invoke(Sub() Label57.Text = results(22).Value & " А")
                    Me.Invoke(Sub() Label58.Text = results(23).Value & " А")
                    Me.Invoke(Sub() Label59.Text = results(24).Value & " А")
                    Me.Invoke(Sub() Label60.Text = results(25).Value & " кА")
                    Me.Invoke(Sub() Label61.Text = results(26).Value & " кА")
                    Me.Invoke(Sub() Label62.Text = results(27).Value & " кА")
                    Me.Invoke(Sub() Label63.Text = results(28).Value & " кА")
                    Me.Invoke(Sub() Label64.Text = results(29).Value & " кА")
                    Me.Invoke(Sub() Label65.Text = results(30).Value & " мс.")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_F9_IZM_START()

        Try

ARG:
            groupState_F9Izm.Name = "F9Izm"
            groupState_F9Izm.Active = True
            groupState_F9Izm.UpdateRate = MSPEED

            group_F9Izm = DirectCast(m_server.CreateSubscription(groupState_F9Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(30) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С1.9_СВ.I1"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С1.9_СВ.I2"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С1.9_СВ.I3"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С1.9_СВ.Im1"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С1.9_СВ.Im2"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С1.9_СВ.Im3"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С1.9_СВ.U_12"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С1.9_СВ.U_23"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С1.9_СВ.U_31"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С1.9_СВ.P"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С1.9_СВ.Q"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С1.9_СВ.S"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С1.9_СВ.PM"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С1.9_СВ.QM"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С1.9_СВ.COS_PHI"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.С1.9_СВ.EP_POS"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.С1.9_СВ.EP_NEG"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РП10.С1.9_СВ.EQ_POS"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РП10.С1.9_СВ.EQ_NEG"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "РП10.С1.9_СВ.CNT_CMT"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "РП10.С1.9_СВ.CNT_PHCMT"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "РП10.С1.9_СВ.CNT_DO"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С1.9_СВ.Itrip1"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С1.9_СВ.Itrip2"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С1.9_СВ.Itrip3"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С1.9_СВ.SUM_TRIP_I1"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С1.9_СВ.SUM_TRIP_I2"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С1.9_СВ.SUM_TRIP_I3"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С1.9_СВ.SUM_TRIP_I4"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С1.9_СВ.SUM_TRIP_I5"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С1.9_СВ.OPER_TIME"

            items = group_F9Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_F9Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = results(0).Value & " A")
                    Me.Invoke(Sub() Label8.Text = results(1).Value & " A")
                    Me.Invoke(Sub() Label9.Text = results(2).Value & " A")
                    Me.Invoke(Sub() Label10.Text = results(3).Value & " A")
                    Me.Invoke(Sub() Label11.Text = results(4).Value & " A")
                    Me.Invoke(Sub() Label12.Text = results(5).Value & " A")
                    Me.Invoke(Sub() Label41.Text = results(6).Value & " кВ")
                    Me.Invoke(Sub() Label42.Text = results(7).Value & " кВ")
                    Me.Invoke(Sub() Label43.Text = results(8).Value & " кВ")
                    Me.Invoke(Sub() Label44.Text = results(9).Value & " кВт")
                    Me.Invoke(Sub() Label45.Text = results(10).Value & " кВар")
                    Me.Invoke(Sub() Label46.Text = results(11).Value & " кВА")
                    Me.Invoke(Sub() Label47.Text = results(12).Value & " кВт")
                    Me.Invoke(Sub() Label48.Text = results(13).Value & " кВар")
                    Me.Invoke(Sub() Label49.Text = results(14).Value & " ")
                    Me.Invoke(Sub() Label50.Text = results(15).Value & " МВтч")
                    Me.Invoke(Sub() Label51.Text = results(16).Value & " МВтч")
                    Me.Invoke(Sub() Label52.Text = results(17).Value & " МВАрч")
                    Me.Invoke(Sub() Label53.Text = results(18).Value & " МВАрч")
                    Me.Invoke(Sub() Label54.Text = results(19).Value & " ")
                    Me.Invoke(Sub() Label55.Text = results(20).Value)
                    Me.Invoke(Sub() Label56.Text = results(21).Value)
                    Me.Invoke(Sub() Label57.Text = results(22).Value & " А")
                    Me.Invoke(Sub() Label58.Text = results(23).Value & " А")
                    Me.Invoke(Sub() Label59.Text = results(24).Value & " А")
                    Me.Invoke(Sub() Label60.Text = results(25).Value & " кА")
                    Me.Invoke(Sub() Label61.Text = results(26).Value & " кА")
                    Me.Invoke(Sub() Label62.Text = results(27).Value & " кА")
                    Me.Invoke(Sub() Label63.Text = results(28).Value & " кА")
                    Me.Invoke(Sub() Label64.Text = results(29).Value & " кА")
                    Me.Invoke(Sub() Label65.Text = results(30).Value & " мс.")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_F2_IZM_START()

        Try

ARG:
            groupState_F2Izm.Name = "F2Izm"
            groupState_F2Izm.Active = True
            groupState_F2Izm.UpdateRate = MSPEED

            group_F2Izm = DirectCast(m_server.CreateSubscription(groupState_F2Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(30) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С1.2_ШТН.I1"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С1.2_ШТН.I2"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С1.2_ШТН.I3"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С1.2_ШТН.Im1"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С1.2_ШТН.Im2"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С1.2_ШТН.Im3"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С1.2_ШТН.U_12"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С1.2_ШТН.U_23"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С1.2_ШТН.U_31"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С1.2_ШТН.P"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С1.2_ШТН.Q"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С1.2_ШТН.S"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С1.2_ШТН.PM"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С1.2_ШТН.QM"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С1.2_ШТН.COS_PHI"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.С1.2_ШТН.EP_POS"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.С1.2_ШТН.EP_NEG"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РП10.С1.2_ШТН.EQ_POS"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РП10.С1.2_ШТН.EQ_NEG"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "РП10.С1.2_ШТН.CNT_CMT"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "РП10.С1.2_ШТН.CNT_PHCMT"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "РП10.С1.2_ШТН.CNT_DO"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С1.2_ШТН.Itrip1"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С1.2_ШТН.Itrip2"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С1.2_ШТН.Itrip3"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С1.2_ШТН.SUM_TRIP_I1"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С1.2_ШТН.SUM_TRIP_I2"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С1.2_ШТН.SUM_TRIP_I3"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С1.2_ШТН.SUM_TRIP_I4"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С1.2_ШТН.SUM_TRIP_I5"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С1.2_ШТН.OPER_TIME"

            items = group_F2Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_F2Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = results(0).Value & " A")
                    Me.Invoke(Sub() Label8.Text = results(1).Value & " A")
                    Me.Invoke(Sub() Label9.Text = results(2).Value & " A")
                    Me.Invoke(Sub() Label10.Text = results(3).Value & " A")
                    Me.Invoke(Sub() Label11.Text = results(4).Value & " A")
                    Me.Invoke(Sub() Label12.Text = results(5).Value & " A")
                    Me.Invoke(Sub() Label41.Text = results(6).Value & " кВ")
                    Me.Invoke(Sub() Label42.Text = results(7).Value & " кВ")
                    Me.Invoke(Sub() Label43.Text = results(8).Value & " кВ")
                    Me.Invoke(Sub() Label44.Text = results(9).Value & " кВт")
                    Me.Invoke(Sub() Label45.Text = results(10).Value & " кВар")
                    Me.Invoke(Sub() Label46.Text = results(11).Value & " кВА")
                    Me.Invoke(Sub() Label47.Text = results(12).Value & " кВт")
                    Me.Invoke(Sub() Label48.Text = results(13).Value & " кВар")
                    Me.Invoke(Sub() Label49.Text = results(14).Value & " ")
                    Me.Invoke(Sub() Label50.Text = results(15).Value & " МВтч")
                    Me.Invoke(Sub() Label51.Text = results(16).Value & " МВтч")
                    Me.Invoke(Sub() Label52.Text = results(17).Value & " МВАрч")
                    Me.Invoke(Sub() Label53.Text = results(18).Value & " МВАрч")
                    Me.Invoke(Sub() Label54.Text = results(19).Value & " ")
                    Me.Invoke(Sub() Label55.Text = results(20).Value)
                    Me.Invoke(Sub() Label56.Text = results(21).Value)
                    Me.Invoke(Sub() Label57.Text = results(22).Value & " А")
                    Me.Invoke(Sub() Label58.Text = results(23).Value & " А")
                    Me.Invoke(Sub() Label59.Text = results(24).Value & " А")
                    Me.Invoke(Sub() Label60.Text = results(25).Value & " кА")
                    Me.Invoke(Sub() Label61.Text = results(26).Value & " кА")
                    Me.Invoke(Sub() Label62.Text = results(27).Value & " кА")
                    Me.Invoke(Sub() Label63.Text = results(28).Value & " кА")
                    Me.Invoke(Sub() Label64.Text = results(29).Value & " кА")
                    Me.Invoke(Sub() Label65.Text = results(30).Value & " мс.")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_F17_IZM_START()

        Try

ARG:
            groupState_F17Izm.Name = "F17Izm"
            groupState_F17Izm.Active = True
            groupState_F17Izm.UpdateRate = MSPEED

            group_F17Izm = DirectCast(m_server.CreateSubscription(groupState_F17Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(30) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С2.17_ФИД.I1"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С2.17_ФИД.I2"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С2.17_ФИД.I3"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С2.17_ФИД.Im1"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С2.17_ФИД.Im2"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С2.17_ФИД.Im3"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С2.17_ФИД.U_12"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С2.17_ФИД.U_23"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С2.17_ФИД.U_31"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С2.17_ФИД.P"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С2.17_ФИД.Q"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С2.17_ФИД.S"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С2.17_ФИД.PM"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С2.17_ФИД.QM"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С2.17_ФИД.COS_PHI"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.С2.17_ФИД.EP_POS"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.С2.17_ФИД.EP_NEG"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РП10.С2.17_ФИД.EQ_POS"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РП10.С2.17_ФИД.EQ_NEG"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "РП10.С2.17_ФИД.CNT_CMT"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "РП10.С2.17_ФИД.CNT_PHCMT"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "РП10.С2.17_ФИД.CNT_DO"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С2.17_ФИД.Itrip1"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С2.17_ФИД.Itrip2"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С2.17_ФИД.Itrip3"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С2.17_ФИД.SUM_TRIP_I1"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С2.17_ФИД.SUM_TRIP_I2"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С2.17_ФИД.SUM_TRIP_I3"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С2.17_ФИД.SUM_TRIP_I4"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С2.17_ФИД.SUM_TRIP_I5"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С2.17_ФИД.OPER_TIME"

            items = group_F17Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_F17Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = results(0).Value & " A")
                    Me.Invoke(Sub() Label8.Text = results(1).Value & " A")
                    Me.Invoke(Sub() Label9.Text = results(2).Value & " A")
                    Me.Invoke(Sub() Label10.Text = results(3).Value & " A")
                    Me.Invoke(Sub() Label11.Text = results(4).Value & " A")
                    Me.Invoke(Sub() Label12.Text = results(5).Value & " A")
                    Me.Invoke(Sub() Label41.Text = results(6).Value & " кВ")
                    Me.Invoke(Sub() Label42.Text = results(7).Value & " кВ")
                    Me.Invoke(Sub() Label43.Text = results(8).Value & " кВ")
                    Me.Invoke(Sub() Label44.Text = results(9).Value & " кВт")
                    Me.Invoke(Sub() Label45.Text = results(10).Value & " кВар")
                    Me.Invoke(Sub() Label46.Text = results(11).Value & " кВА")
                    Me.Invoke(Sub() Label47.Text = results(12).Value & " кВт")
                    Me.Invoke(Sub() Label48.Text = results(13).Value & " кВар")
                    Me.Invoke(Sub() Label49.Text = results(14).Value & " ")
                    Me.Invoke(Sub() Label50.Text = results(15).Value & " МВтч")
                    Me.Invoke(Sub() Label51.Text = results(16).Value & " МВтч")
                    Me.Invoke(Sub() Label52.Text = results(17).Value & " МВАрч")
                    Me.Invoke(Sub() Label53.Text = results(18).Value & " МВАрч")
                    Me.Invoke(Sub() Label54.Text = results(19).Value & " ")
                    Me.Invoke(Sub() Label55.Text = results(20).Value)
                    Me.Invoke(Sub() Label56.Text = results(21).Value)
                    Me.Invoke(Sub() Label57.Text = results(22).Value & " А")
                    Me.Invoke(Sub() Label58.Text = results(23).Value & " А")
                    Me.Invoke(Sub() Label59.Text = results(24).Value & " А")
                    Me.Invoke(Sub() Label60.Text = results(25).Value & " кА")
                    Me.Invoke(Sub() Label61.Text = results(26).Value & " кА")
                    Me.Invoke(Sub() Label62.Text = results(27).Value & " кА")
                    Me.Invoke(Sub() Label63.Text = results(28).Value & " кА")
                    Me.Invoke(Sub() Label64.Text = results(29).Value & " кА")
                    Me.Invoke(Sub() Label65.Text = results(30).Value & " мс.")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_F16_IZM_START()

        Try

ARG:
            groupState_F16Izm.Name = "F16Izm"
            groupState_F16Izm.Active = True
            groupState_F16Izm.UpdateRate = MSPEED

            group_F16Izm = DirectCast(m_server.CreateSubscription(groupState_F16Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(30) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С2.16_ФИД.I1"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С2.16_ФИД.I2"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С2.16_ФИД.I3"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С2.16_ФИД.Im1"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С2.16_ФИД.Im2"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С2.16_ФИД.Im3"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С2.16_ФИД.U_12"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С2.16_ФИД.U_23"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С2.16_ФИД.U_31"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С2.16_ФИД.P"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С2.16_ФИД.Q"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С2.16_ФИД.S"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С2.16_ФИД.PM"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С2.16_ФИД.QM"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С2.16_ФИД.COS_PHI"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.С2.16_ФИД.EP_POS"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.С2.16_ФИД.EP_NEG"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РП10.С2.16_ФИД.EQ_POS"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РП10.С2.16_ФИД.EQ_NEG"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "РП10.С2.16_ФИД.CNT_CMT"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "РП10.С2.16_ФИД.CNT_PHCMT"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "РП10.С2.16_ФИД.CNT_DO"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С2.16_ФИД.Itrip1"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С2.16_ФИД.Itrip2"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С2.16_ФИД.Itrip3"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С2.16_ФИД.SUM_TRIP_I1"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С2.16_ФИД.SUM_TRIP_I2"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С2.16_ФИД.SUM_TRIP_I3"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С2.16_ФИД.SUM_TRIP_I4"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С2.16_ФИД.SUM_TRIP_I5"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С2.16_ФИД.OPER_TIME"

            items = group_F16Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_F16Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = results(0).Value & " A")
                    Me.Invoke(Sub() Label8.Text = results(1).Value & " A")
                    Me.Invoke(Sub() Label9.Text = results(2).Value & " A")
                    Me.Invoke(Sub() Label10.Text = results(3).Value & " A")
                    Me.Invoke(Sub() Label11.Text = results(4).Value & " A")
                    Me.Invoke(Sub() Label12.Text = results(5).Value & " A")
                    Me.Invoke(Sub() Label41.Text = results(6).Value & " кВ")
                    Me.Invoke(Sub() Label42.Text = results(7).Value & " кВ")
                    Me.Invoke(Sub() Label43.Text = results(8).Value & " кВ")
                    Me.Invoke(Sub() Label44.Text = results(9).Value & " кВт")
                    Me.Invoke(Sub() Label45.Text = results(10).Value & " кВар")
                    Me.Invoke(Sub() Label46.Text = results(11).Value & " кВА")
                    Me.Invoke(Sub() Label47.Text = results(12).Value & " кВт")
                    Me.Invoke(Sub() Label48.Text = results(13).Value & " кВар")
                    Me.Invoke(Sub() Label49.Text = results(14).Value & " ")
                    Me.Invoke(Sub() Label50.Text = results(15).Value & " МВтч")
                    Me.Invoke(Sub() Label51.Text = results(16).Value & " МВтч")
                    Me.Invoke(Sub() Label52.Text = results(17).Value & " МВАрч")
                    Me.Invoke(Sub() Label53.Text = results(18).Value & " МВАрч")
                    Me.Invoke(Sub() Label54.Text = results(19).Value & " ")
                    Me.Invoke(Sub() Label55.Text = results(20).Value)
                    Me.Invoke(Sub() Label56.Text = results(21).Value)
                    Me.Invoke(Sub() Label57.Text = results(22).Value & " А")
                    Me.Invoke(Sub() Label58.Text = results(23).Value & " А")
                    Me.Invoke(Sub() Label59.Text = results(24).Value & " А")
                    Me.Invoke(Sub() Label60.Text = results(25).Value & " кА")
                    Me.Invoke(Sub() Label61.Text = results(26).Value & " кА")
                    Me.Invoke(Sub() Label62.Text = results(27).Value & " кА")
                    Me.Invoke(Sub() Label63.Text = results(28).Value & " кА")
                    Me.Invoke(Sub() Label64.Text = results(29).Value & " кА")
                    Me.Invoke(Sub() Label65.Text = results(30).Value & " мс.")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_F15_IZM_START()

        Try

ARG:
            groupState_F15Izm.Name = "F15Izm"
            groupState_F15Izm.Active = True
            groupState_F15Izm.UpdateRate = MSPEED

            group_F15Izm = DirectCast(m_server.CreateSubscription(groupState_F15Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(30) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С2.15_ФИД.I1"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С2.15_ФИД.I2"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С2.15_ФИД.I3"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С2.15_ФИД.Im1"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С2.15_ФИД.Im2"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С2.15_ФИД.Im3"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С2.15_ФИД.U_12"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С2.15_ФИД.U_23"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С2.15_ФИД.U_31"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С2.15_ФИД.P"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С2.15_ФИД.Q"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С2.15_ФИД.S"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С2.15_ФИД.PM"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С2.15_ФИД.QM"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С2.15_ФИД.COS_PHI"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.С2.15_ФИД.EP_POS"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.С2.15_ФИД.EP_NEG"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РП10.С2.15_ФИД.EQ_POS"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РП10.С2.15_ФИД.EQ_NEG"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "РП10.С2.15_ФИД.CNT_CMT"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "РП10.С2.15_ФИД.CNT_PHCMT"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "РП10.С2.15_ФИД.CNT_DO"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С2.15_ФИД.Itrip1"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С2.15_ФИД.Itrip2"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С2.15_ФИД.Itrip3"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С2.15_ФИД.SUM_TRIP_I1"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С2.15_ФИД.SUM_TRIP_I2"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С2.15_ФИД.SUM_TRIP_I3"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С2.15_ФИД.SUM_TRIP_I4"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С2.15_ФИД.SUM_TRIP_I5"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С2.15_ФИД.OPER_TIME"

            items = group_F15Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_F15Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = results(0).Value & " A")
                    Me.Invoke(Sub() Label8.Text = results(1).Value & " A")
                    Me.Invoke(Sub() Label9.Text = results(2).Value & " A")
                    Me.Invoke(Sub() Label10.Text = results(3).Value & " A")
                    Me.Invoke(Sub() Label11.Text = results(4).Value & " A")
                    Me.Invoke(Sub() Label12.Text = results(5).Value & " A")
                    Me.Invoke(Sub() Label41.Text = results(6).Value & " кВ")
                    Me.Invoke(Sub() Label42.Text = results(7).Value & " кВ")
                    Me.Invoke(Sub() Label43.Text = results(8).Value & " кВ")
                    Me.Invoke(Sub() Label44.Text = results(9).Value & " кВт")
                    Me.Invoke(Sub() Label45.Text = results(10).Value & " кВар")
                    Me.Invoke(Sub() Label46.Text = results(11).Value & " кВА")
                    Me.Invoke(Sub() Label47.Text = results(12).Value & " кВт")
                    Me.Invoke(Sub() Label48.Text = results(13).Value & " кВар")
                    Me.Invoke(Sub() Label49.Text = results(14).Value & " ")
                    Me.Invoke(Sub() Label50.Text = results(15).Value & " МВтч")
                    Me.Invoke(Sub() Label51.Text = results(16).Value & " МВтч")
                    Me.Invoke(Sub() Label52.Text = results(17).Value & " МВАрч")
                    Me.Invoke(Sub() Label53.Text = results(18).Value & " МВАрч")
                    Me.Invoke(Sub() Label54.Text = results(19).Value & " ")
                    Me.Invoke(Sub() Label55.Text = results(20).Value)
                    Me.Invoke(Sub() Label56.Text = results(21).Value)
                    Me.Invoke(Sub() Label57.Text = results(22).Value & " А")
                    Me.Invoke(Sub() Label58.Text = results(23).Value & " А")
                    Me.Invoke(Sub() Label59.Text = results(24).Value & " А")
                    Me.Invoke(Sub() Label60.Text = results(25).Value & " кА")
                    Me.Invoke(Sub() Label61.Text = results(26).Value & " кА")
                    Me.Invoke(Sub() Label62.Text = results(27).Value & " кА")
                    Me.Invoke(Sub() Label63.Text = results(28).Value & " кА")
                    Me.Invoke(Sub() Label64.Text = results(29).Value & " кА")
                    Me.Invoke(Sub() Label65.Text = results(30).Value & " мс.")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_F14_IZM_START()

        Try

ARG:
            groupState_F14Izm.Name = "F14Izm"
            groupState_F14Izm.Active = True
            groupState_F14Izm.UpdateRate = MSPEED

            group_F14Izm = DirectCast(m_server.CreateSubscription(groupState_F14Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(30) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С2.14_ФИД.I1"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С2.14_ФИД.I2"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С2.14_ФИД.I3"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С2.14_ФИД.Im1"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С2.14_ФИД.Im2"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С2.14_ФИД.Im3"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С2.14_ФИД.U_12"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С2.14_ФИД.U_23"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С2.14_ФИД.U_31"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С2.14_ФИД.P"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С2.14_ФИД.Q"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С2.14_ФИД.S"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С2.14_ФИД.PM"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С2.14_ФИД.QM"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С2.14_ФИД.COS_PHI"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.С2.14_ФИД.EP_POS"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.С2.14_ФИД.EP_NEG"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РП10.С2.14_ФИД.EQ_POS"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РП10.С2.14_ФИД.EQ_NEG"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "РП10.С2.14_ФИД.CNT_CMT"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "РП10.С2.14_ФИД.CNT_PHCMT"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "РП10.С2.14_ФИД.CNT_DO"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С2.14_ФИД.Itrip1"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С2.14_ФИД.Itrip2"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С2.14_ФИД.Itrip3"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С2.14_ФИД.SUM_TRIP_I1"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С2.14_ФИД.SUM_TRIP_I2"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С2.14_ФИД.SUM_TRIP_I3"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С2.14_ФИД.SUM_TRIP_I4"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С2.14_ФИД.SUM_TRIP_I5"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С2.14_ФИД.OPER_TIME"

            items = group_F14Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_F14Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = results(0).Value & " A")
                    Me.Invoke(Sub() Label8.Text = results(1).Value & " A")
                    Me.Invoke(Sub() Label9.Text = results(2).Value & " A")
                    Me.Invoke(Sub() Label10.Text = results(3).Value & " A")
                    Me.Invoke(Sub() Label11.Text = results(4).Value & " A")
                    Me.Invoke(Sub() Label12.Text = results(5).Value & " A")
                    Me.Invoke(Sub() Label41.Text = results(6).Value & " кВ")
                    Me.Invoke(Sub() Label42.Text = results(7).Value & " кВ")
                    Me.Invoke(Sub() Label43.Text = results(8).Value & " кВ")
                    Me.Invoke(Sub() Label44.Text = results(9).Value & " кВт")
                    Me.Invoke(Sub() Label45.Text = results(10).Value & " кВар")
                    Me.Invoke(Sub() Label46.Text = results(11).Value & " кВА")
                    Me.Invoke(Sub() Label47.Text = results(12).Value & " кВт")
                    Me.Invoke(Sub() Label48.Text = results(13).Value & " кВар")
                    Me.Invoke(Sub() Label49.Text = results(14).Value & " ")
                    Me.Invoke(Sub() Label50.Text = results(15).Value & " МВтч")
                    Me.Invoke(Sub() Label51.Text = results(16).Value & " МВтч")
                    Me.Invoke(Sub() Label52.Text = results(17).Value & " МВАрч")
                    Me.Invoke(Sub() Label53.Text = results(18).Value & " МВАрч")
                    Me.Invoke(Sub() Label54.Text = results(19).Value & " ")
                    Me.Invoke(Sub() Label55.Text = results(20).Value)
                    Me.Invoke(Sub() Label56.Text = results(21).Value)
                    Me.Invoke(Sub() Label57.Text = results(22).Value & " А")
                    Me.Invoke(Sub() Label58.Text = results(23).Value & " А")
                    Me.Invoke(Sub() Label59.Text = results(24).Value & " А")
                    Me.Invoke(Sub() Label60.Text = results(25).Value & " кА")
                    Me.Invoke(Sub() Label61.Text = results(26).Value & " кА")
                    Me.Invoke(Sub() Label62.Text = results(27).Value & " кА")
                    Me.Invoke(Sub() Label63.Text = results(28).Value & " кА")
                    Me.Invoke(Sub() Label64.Text = results(29).Value & " кА")
                    Me.Invoke(Sub() Label65.Text = results(30).Value & " мс.")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_F13_IZM_START()

        Try

ARG:
            groupState_F13Izm.Name = "F13Izm"
            groupState_F13Izm.Active = True
            groupState_F13Izm.UpdateRate = MSPEED

            group_F13Izm = DirectCast(m_server.CreateSubscription(groupState_F13Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(30) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С2.13_ФИД.I1"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С2.13_ФИД.I2"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С2.13_ФИД.I3"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С2.13_ФИД.Im1"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С2.13_ФИД.Im2"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С2.13_ФИД.Im3"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С2.13_ФИД.U_12"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С2.13_ФИД.U_23"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С2.13_ФИД.U_31"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С2.13_ФИД.P"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С2.13_ФИД.Q"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С2.13_ФИД.S"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С2.13_ФИД.PM"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С2.13_ФИД.QM"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С2.13_ФИД.COS_PHI"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.С2.13_ФИД.EP_POS"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.С2.13_ФИД.EP_NEG"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РП10.С2.13_ФИД.EQ_POS"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РП10.С2.13_ФИД.EQ_NEG"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "РП10.С2.13_ФИД.CNT_CMT"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "РП10.С2.13_ФИД.CNT_PHCMT"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "РП10.С2.13_ФИД.CNT_DO"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С2.13_ФИД.Itrip1"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С2.13_ФИД.Itrip2"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С2.13_ФИД.Itrip3"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С2.13_ФИД.SUM_TRIP_I1"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С2.13_ФИД.SUM_TRIP_I2"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С2.13_ФИД.SUM_TRIP_I3"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С2.13_ФИД.SUM_TRIP_I4"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С2.13_ФИД.SUM_TRIP_I5"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С2.13_ФИД.OPER_TIME"

            items = group_F13Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_F13Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = results(0).Value & " A")
                    Me.Invoke(Sub() Label8.Text = results(1).Value & " A")
                    Me.Invoke(Sub() Label9.Text = results(2).Value & " A")
                    Me.Invoke(Sub() Label10.Text = results(3).Value & " A")
                    Me.Invoke(Sub() Label11.Text = results(4).Value & " A")
                    Me.Invoke(Sub() Label12.Text = results(5).Value & " A")
                    Me.Invoke(Sub() Label41.Text = results(6).Value & " кВ")
                    Me.Invoke(Sub() Label42.Text = results(7).Value & " кВ")
                    Me.Invoke(Sub() Label43.Text = results(8).Value & " кВ")
                    Me.Invoke(Sub() Label44.Text = results(9).Value & " кВт")
                    Me.Invoke(Sub() Label45.Text = results(10).Value & " кВар")
                    Me.Invoke(Sub() Label46.Text = results(11).Value & " кВА")
                    Me.Invoke(Sub() Label47.Text = results(12).Value & " кВт")
                    Me.Invoke(Sub() Label48.Text = results(13).Value & " кВар")
                    Me.Invoke(Sub() Label49.Text = results(14).Value & " ")
                    Me.Invoke(Sub() Label50.Text = results(15).Value & " МВтч")
                    Me.Invoke(Sub() Label51.Text = results(16).Value & " МВтч")
                    Me.Invoke(Sub() Label52.Text = results(17).Value & " МВАрч")
                    Me.Invoke(Sub() Label53.Text = results(18).Value & " МВАрч")
                    Me.Invoke(Sub() Label54.Text = results(19).Value & " ")
                    Me.Invoke(Sub() Label55.Text = results(20).Value)
                    Me.Invoke(Sub() Label56.Text = results(21).Value)
                    Me.Invoke(Sub() Label57.Text = results(22).Value & " А")
                    Me.Invoke(Sub() Label58.Text = results(23).Value & " А")
                    Me.Invoke(Sub() Label59.Text = results(24).Value & " А")
                    Me.Invoke(Sub() Label60.Text = results(25).Value & " кА")
                    Me.Invoke(Sub() Label61.Text = results(26).Value & " кА")
                    Me.Invoke(Sub() Label62.Text = results(27).Value & " кА")
                    Me.Invoke(Sub() Label63.Text = results(28).Value & " кА")
                    Me.Invoke(Sub() Label64.Text = results(29).Value & " кА")
                    Me.Invoke(Sub() Label65.Text = results(30).Value & " мс.")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_F12_IZM_START()

        Try

ARG:
            groupState_F12Izm.Name = "F12Izm"
            groupState_F12Izm.Active = True
            groupState_F12Izm.UpdateRate = MSPEED

            group_F12Izm = DirectCast(m_server.CreateSubscription(groupState_F12Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(30) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "РП10.С2.12_ФИД.I1"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "РП10.С2.12_ФИД.I2"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "РП10.С2.12_ФИД.I3"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "РП10.С2.12_ФИД.Im1"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "РП10.С2.12_ФИД.Im2"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "РП10.С2.12_ФИД.Im3"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "РП10.С2.12_ФИД.U_12"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "РП10.С2.12_ФИД.U_23"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "РП10.С2.12_ФИД.U_31"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "РП10.С2.12_ФИД.P"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "РП10.С2.12_ФИД.Q"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "РП10.С2.12_ФИД.S"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "РП10.С2.12_ФИД.PM"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "РП10.С2.12_ФИД.QM"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "РП10.С2.12_ФИД.COS_PHI"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "РП10.С2.12_ФИД.EP_POS"

            items(16) = New Global.Opc.Da.Item()
            items(16).ItemName = "РП10.С2.12_ФИД.EP_NEG"

            items(17) = New Global.Opc.Da.Item()
            items(17).ItemName = "РП10.С2.12_ФИД.EQ_POS"

            items(18) = New Global.Opc.Da.Item()
            items(18).ItemName = "РП10.С2.12_ФИД.EQ_NEG"

            items(19) = New Global.Opc.Da.Item()
            items(19).ItemName = "РП10.С2.12_ФИД.CNT_CMT"

            items(20) = New Global.Opc.Da.Item()
            items(20).ItemName = "РП10.С2.12_ФИД.CNT_PHCMT"

            items(21) = New Global.Opc.Da.Item()
            items(21).ItemName = "РП10.С2.12_ФИД.CNT_DO"

            items(22) = New Global.Opc.Da.Item()
            items(22).ItemName = "РП10.С2.12_ФИД.Itrip1"

            items(23) = New Global.Opc.Da.Item()
            items(23).ItemName = "РП10.С2.12_ФИД.Itrip2"

            items(24) = New Global.Opc.Da.Item()
            items(24).ItemName = "РП10.С2.12_ФИД.Itrip3"

            items(25) = New Global.Opc.Da.Item()
            items(25).ItemName = "РП10.С2.12_ФИД.SUM_TRIP_I1"

            items(26) = New Global.Opc.Da.Item()
            items(26).ItemName = "РП10.С2.12_ФИД.SUM_TRIP_I2"

            items(27) = New Global.Opc.Da.Item()
            items(27).ItemName = "РП10.С2.12_ФИД.SUM_TRIP_I3"

            items(28) = New Global.Opc.Da.Item()
            items(28).ItemName = "РП10.С2.12_ФИД.SUM_TRIP_I4"

            items(29) = New Global.Opc.Da.Item()
            items(29).ItemName = "РП10.С2.12_ФИД.SUM_TRIP_I5"

            items(30) = New Global.Opc.Da.Item()
            items(30).ItemName = "РП10.С2.12_ФИД.OPER_TIME"

            items = group_F12Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_F12Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = results(0).Value & " A")
                    Me.Invoke(Sub() Label8.Text = results(1).Value & " A")
                    Me.Invoke(Sub() Label9.Text = results(2).Value & " A")
                    Me.Invoke(Sub() Label10.Text = results(3).Value & " A")
                    Me.Invoke(Sub() Label11.Text = results(4).Value & " A")
                    Me.Invoke(Sub() Label12.Text = results(5).Value & " A")
                    Me.Invoke(Sub() Label41.Text = results(6).Value & " кВ")
                    Me.Invoke(Sub() Label42.Text = results(7).Value & " кВ")
                    Me.Invoke(Sub() Label43.Text = results(8).Value & " кВ")
                    Me.Invoke(Sub() Label44.Text = results(9).Value & " кВт")
                    Me.Invoke(Sub() Label45.Text = results(10).Value & " кВар")
                    Me.Invoke(Sub() Label46.Text = results(11).Value & " кВА")
                    Me.Invoke(Sub() Label47.Text = results(12).Value & " кВт")
                    Me.Invoke(Sub() Label48.Text = results(13).Value & " кВар")
                    Me.Invoke(Sub() Label49.Text = results(14).Value & " ")
                    Me.Invoke(Sub() Label50.Text = results(15).Value & " МВтч")
                    Me.Invoke(Sub() Label51.Text = results(16).Value & " МВтч")
                    Me.Invoke(Sub() Label52.Text = results(17).Value & " МВАрч")
                    Me.Invoke(Sub() Label53.Text = results(18).Value & " МВАрч")
                    Me.Invoke(Sub() Label54.Text = results(19).Value & " ")
                    Me.Invoke(Sub() Label55.Text = results(20).Value)
                    Me.Invoke(Sub() Label56.Text = results(21).Value)
                    Me.Invoke(Sub() Label57.Text = results(22).Value & " А")
                    Me.Invoke(Sub() Label58.Text = results(23).Value & " А")
                    Me.Invoke(Sub() Label59.Text = results(24).Value & " А")
                    Me.Invoke(Sub() Label60.Text = results(25).Value & " кА")
                    Me.Invoke(Sub() Label61.Text = results(26).Value & " кА")
                    Me.Invoke(Sub() Label62.Text = results(27).Value & " кА")
                    Me.Invoke(Sub() Label63.Text = results(28).Value & " кА")
                    Me.Invoke(Sub() Label64.Text = results(29).Value & " кА")
                    Me.Invoke(Sub() Label65.Text = results(30).Value & " мс.")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_EBv1_IZM_START()

        Try

ARG:
            groupState_EBv1Izm.Name = "EBv1Izm"
            groupState_EBv1Izm.Active = True
            groupState_EBv1Izm.UpdateRate = MSPEED

            group_EBv1Izm = DirectCast(m_server.CreateSubscription(groupState_EBv1Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(15) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "КТП_ЭБ.С1.ВВ1.IA"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "КТП_ЭБ.С1.ВВ1.IB"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "КТП_ЭБ.С1.ВВ1.IC"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "КТП_ЭБ.С1.ВВ1.3I0"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "КТП_ЭБ.С1.ВВ1.I1"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "КТП_ЭБ.С1.ВВ1.I2"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "КТП_ЭБ.С1.ВВ1.I1_A"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "КТП_ЭБ.С1.ВВ1.I1_R"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "КТП_ЭБ.С1.ВВ1.UBB"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "КТП_ЭБ.С1.ВВ1.UA"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "КТП_ЭБ.С1.ВВ1.UB"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "КТП_ЭБ.С1.ВВ1.UC"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "КТП_ЭБ.С1.ВВ1.3U0"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "КТП_ЭБ.С1.ВВ1.U1"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "КТП_ЭБ.С1.ВВ1.F"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "КТП_ЭБ.С1.ВВ1.COS"


            items = group_EBv1Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_EBv1Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = Math.Round(results(0).Value, 2) & " A")
                    Me.Invoke(Sub() Label8.Text = Math.Round(results(1).Value, 2) & " A")
                    Me.Invoke(Sub() Label9.Text = Math.Round(results(2).Value, 2) & " A")
                    Me.Invoke(Sub() Label10.Text = Math.Round(results(3).Value, 2) & " A")
                    Me.Invoke(Sub() Label11.Text = Math.Round(results(4).Value, 2) & " A")
                    Me.Invoke(Sub() Label12.Text = Math.Round(results(5).Value, 2) & " A")
                    Me.Invoke(Sub() Label41.Text = Math.Round(results(6).Value, 2) & " A")
                    Me.Invoke(Sub() Label42.Text = Math.Round(results(7).Value, 2) & " A")
                    Me.Invoke(Sub() Label43.Text = Math.Round(results(8).Value, 2) & " В")
                    Me.Invoke(Sub() Label44.Text = Math.Round(results(9).Value, 2) & " В")
                    Me.Invoke(Sub() Label45.Text = Math.Round(results(10).Value, 2) & " В")
                    Me.Invoke(Sub() Label46.Text = Math.Round(results(11).Value, 2) & " В")
                    Me.Invoke(Sub() Label47.Text = Math.Round(results(12).Value, 2) & " В")
                    Me.Invoke(Sub() Label48.Text = Math.Round(results(13).Value, 2) & " В")
                    Me.Invoke(Sub() Label49.Text = Math.Round(results(14).Value, 2) & " Гц")
                    Me.Invoke(Sub() Label50.Text = Math.Round(results(15).Value, 2) & " ")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_EBv2_IZM_START()

        Try

ARG:
            groupState_EBv2Izm.Name = "EBv2Izm"
            groupState_EBv2Izm.Active = True
            groupState_EBv2Izm.UpdateRate = MSPEED

            group_EBv2Izm = DirectCast(m_server.CreateSubscription(groupState_EBv2Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(15) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "КТП_ЭБ.С2.ВВ2.IA"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "КТП_ЭБ.С2.ВВ2.IB"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "КТП_ЭБ.С2.ВВ2.IC"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "КТП_ЭБ.С2.ВВ2.3I0"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "КТП_ЭБ.С2.ВВ2.I1"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "КТП_ЭБ.С2.ВВ2.I2"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "КТП_ЭБ.С2.ВВ2.I1_A"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "КТП_ЭБ.С2.ВВ2.I1_R"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "КТП_ЭБ.С2.ВВ2.UBB"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "КТП_ЭБ.С2.ВВ2.UA"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "КТП_ЭБ.С2.ВВ2.UB"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "КТП_ЭБ.С2.ВВ2.UC"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "КТП_ЭБ.С2.ВВ2.3U0"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "КТП_ЭБ.С2.ВВ2.U1"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "КТП_ЭБ.С2.ВВ2.F"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "КТП_ЭБ.С2.ВВ2.COS"


            items = group_EBv2Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_EBv2Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = Math.Round(results(0).Value, 2) & " A")
                    Me.Invoke(Sub() Label8.Text = Math.Round(results(1).Value, 2) & " A")
                    Me.Invoke(Sub() Label9.Text = Math.Round(results(2).Value, 2) & " A")
                    Me.Invoke(Sub() Label10.Text = Math.Round(results(3).Value, 2) & " A")
                    Me.Invoke(Sub() Label11.Text = Math.Round(results(4).Value, 2) & " A")
                    Me.Invoke(Sub() Label12.Text = Math.Round(results(5).Value, 2) & " A")
                    Me.Invoke(Sub() Label41.Text = Math.Round(results(6).Value, 2) & " A")
                    Me.Invoke(Sub() Label42.Text = Math.Round(results(7).Value, 2) & " A")
                    Me.Invoke(Sub() Label43.Text = Math.Round(results(8).Value, 2) & " В")
                    Me.Invoke(Sub() Label44.Text = Math.Round(results(9).Value, 2) & " В")
                    Me.Invoke(Sub() Label45.Text = Math.Round(results(10).Value, 2) & " В")
                    Me.Invoke(Sub() Label46.Text = Math.Round(results(11).Value, 2) & " В")
                    Me.Invoke(Sub() Label47.Text = Math.Round(results(12).Value, 2) & " В")
                    Me.Invoke(Sub() Label48.Text = Math.Round(results(13).Value, 2) & " В")
                    Me.Invoke(Sub() Label49.Text = Math.Round(results(14).Value, 2) & " Гц")
                    Me.Invoke(Sub() Label50.Text = Math.Round(results(15).Value, 2) & " ")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_REBv1_IZM_START()

        Try

ARG:
            groupState_REBv1Izm.Name = "REBv1Izm"
            groupState_REBv1Izm.Active = True
            groupState_REBv1Izm.UpdateRate = MSPEED

            group_REBv1Izm = DirectCast(m_server.CreateSubscription(groupState_REBv1Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(15) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "КТП_РЭБ.С1.ВВ1.IA"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "КТП_РЭБ.С1.ВВ1.IB"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "КТП_РЭБ.С1.ВВ1.IC"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "КТП_РЭБ.С1.ВВ1.3I0"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "КТП_РЭБ.С1.ВВ1.I1"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "КТП_РЭБ.С1.ВВ1.I2"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "КТП_РЭБ.С1.ВВ1.I1_A"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "КТП_РЭБ.С1.ВВ1.I1_R"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "КТП_РЭБ.С1.ВВ1.UBB"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "КТП_РЭБ.С1.ВВ1.UA"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "КТП_РЭБ.С1.ВВ1.UB"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "КТП_РЭБ.С1.ВВ1.UC"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "КТП_РЭБ.С1.ВВ1.3U0"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "КТП_РЭБ.С1.ВВ1.U1"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "КТП_РЭБ.С1.ВВ1.F"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "КТП_РЭБ.С1.ВВ1.COS"


            items = group_REBv1Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_REBv1Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = Math.Round(results(0).Value, 2) & " A")
                    Me.Invoke(Sub() Label8.Text = Math.Round(results(1).Value, 2) & " A")
                    Me.Invoke(Sub() Label9.Text = Math.Round(results(2).Value, 2) & " A")
                    Me.Invoke(Sub() Label10.Text = Math.Round(results(3).Value, 2) & " A")
                    Me.Invoke(Sub() Label11.Text = Math.Round(results(4).Value, 2) & " A")
                    Me.Invoke(Sub() Label12.Text = Math.Round(results(5).Value, 2) & " A")
                    Me.Invoke(Sub() Label41.Text = Math.Round(results(6).Value, 2) & " A")
                    Me.Invoke(Sub() Label42.Text = Math.Round(results(7).Value, 2) & " A")
                    Me.Invoke(Sub() Label43.Text = Math.Round(results(8).Value, 2) & " В")
                    Me.Invoke(Sub() Label44.Text = Math.Round(results(9).Value, 2) & " В")
                    Me.Invoke(Sub() Label45.Text = Math.Round(results(10).Value, 2) & " В")
                    Me.Invoke(Sub() Label46.Text = Math.Round(results(11).Value, 2) & " В")
                    Me.Invoke(Sub() Label47.Text = Math.Round(results(12).Value, 2) & " В")
                    Me.Invoke(Sub() Label48.Text = Math.Round(results(13).Value, 2) & " В")
                    Me.Invoke(Sub() Label49.Text = Math.Round(results(14).Value, 2) & " Гц")
                    Me.Invoke(Sub() Label50.Text = Math.Round(results(15).Value, 2) & " ")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_REBv2_IZM_START()

        Try

ARG:
            groupState_REBv2Izm.Name = "REBv2Izm"
            groupState_REBv2Izm.Active = True
            groupState_REBv2Izm.UpdateRate = MSPEED

            group_REBv2Izm = DirectCast(m_server.CreateSubscription(groupState_REBv2Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(15) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "КТП_РЭБ.С2.ВВ2.IA"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "КТП_РЭБ.С2.ВВ2.IB"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "КТП_РЭБ.С2.ВВ2.IC"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "КТП_РЭБ.С2.ВВ2.3I0"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "КТП_РЭБ.С2.ВВ2.I1"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "КТП_РЭБ.С2.ВВ2.I2"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "КТП_РЭБ.С2.ВВ2.I1_A"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "КТП_РЭБ.С2.ВВ2.I1_R"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "КТП_РЭБ.С2.ВВ2.UBB"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "КТП_РЭБ.С2.ВВ2.UA"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "КТП_РЭБ.С2.ВВ2.UB"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "КТП_РЭБ.С2.ВВ2.UC"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "КТП_РЭБ.С2.ВВ2.3U0"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "КТП_РЭБ.С2.ВВ2.U1"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "КТП_РЭБ.С2.ВВ2.F"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "КТП_РЭБ.С2.ВВ2.COS"


            items = group_REBv2Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_REBv2Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = Math.Round(results(0).Value, 2) & " A")
                    Me.Invoke(Sub() Label8.Text = Math.Round(results(1).Value, 2) & " A")
                    Me.Invoke(Sub() Label9.Text = Math.Round(results(2).Value, 2) & " A")
                    Me.Invoke(Sub() Label10.Text = Math.Round(results(3).Value, 2) & " A")
                    Me.Invoke(Sub() Label11.Text = Math.Round(results(4).Value, 2) & " A")
                    Me.Invoke(Sub() Label12.Text = Math.Round(results(5).Value, 2) & " A")
                    Me.Invoke(Sub() Label41.Text = Math.Round(results(6).Value, 2) & " A")
                    Me.Invoke(Sub() Label42.Text = Math.Round(results(7).Value, 2) & " A")
                    Me.Invoke(Sub() Label43.Text = Math.Round(results(8).Value, 2) & " В")
                    Me.Invoke(Sub() Label44.Text = Math.Round(results(9).Value, 2) & " В")
                    Me.Invoke(Sub() Label45.Text = Math.Round(results(10).Value, 2) & " В")
                    Me.Invoke(Sub() Label46.Text = Math.Round(results(11).Value, 2) & " В")
                    Me.Invoke(Sub() Label47.Text = Math.Round(results(12).Value, 2) & " В")
                    Me.Invoke(Sub() Label48.Text = Math.Round(results(13).Value, 2) & " В")
                    Me.Invoke(Sub() Label49.Text = Math.Round(results(14).Value, 2) & " Гц")
                    Me.Invoke(Sub() Label50.Text = Math.Round(results(15).Value, 2) & " ")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_AVOv1_IZM_START()

        Try

ARG:
            groupState_AVOv1Izm.Name = "AVOv1Izm"
            groupState_AVOv1Izm.Active = True
            groupState_AVOv1Izm.UpdateRate = MSPEED

            group_AVOv1Izm = DirectCast(m_server.CreateSubscription(groupState_AVOv1Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(15) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "КТП_АВО.С1.ВВ1.IA"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "КТП_АВО.С1.ВВ1.IB"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "КТП_АВО.С1.ВВ1.IC"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "КТП_АВО.С1.ВВ1.3I0"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "КТП_АВО.С1.ВВ1.I1"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "КТП_АВО.С1.ВВ1.I2"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "КТП_АВО.С1.ВВ1.I1_A"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "КТП_АВО.С1.ВВ1.I1_R"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "КТП_АВО.С1.ВВ1.UBB"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "КТП_АВО.С1.ВВ1.UA"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "КТП_АВО.С1.ВВ1.UB"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "КТП_АВО.С1.ВВ1.UC"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "КТП_АВО.С1.ВВ1.3U0"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "КТП_АВО.С1.ВВ1.U1"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "КТП_АВО.С1.ВВ1.F"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "КТП_АВО.С1.ВВ1.COS"


            items = group_AVOv1Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_AVOv1Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = Math.Round(results(0).Value, 2) & " A")
                    Me.Invoke(Sub() Label8.Text = Math.Round(results(1).Value, 2) & " A")
                    Me.Invoke(Sub() Label9.Text = Math.Round(results(2).Value, 2) & " A")
                    Me.Invoke(Sub() Label10.Text = Math.Round(results(3).Value, 2) & " A")
                    Me.Invoke(Sub() Label11.Text = Math.Round(results(4).Value, 2) & " A")
                    Me.Invoke(Sub() Label12.Text = Math.Round(results(5).Value, 2) & " A")
                    Me.Invoke(Sub() Label41.Text = Math.Round(results(6).Value, 2) & " A")
                    Me.Invoke(Sub() Label42.Text = Math.Round(results(7).Value, 2) & " A")
                    Me.Invoke(Sub() Label43.Text = Math.Round(results(8).Value, 2) & " В")
                    Me.Invoke(Sub() Label44.Text = Math.Round(results(9).Value, 2) & " В")
                    Me.Invoke(Sub() Label45.Text = Math.Round(results(10).Value, 2) & " В")
                    Me.Invoke(Sub() Label46.Text = Math.Round(results(11).Value, 2) & " В")
                    Me.Invoke(Sub() Label47.Text = Math.Round(results(12).Value, 2) & " В")
                    Me.Invoke(Sub() Label48.Text = Math.Round(results(13).Value, 2) & " В")
                    Me.Invoke(Sub() Label49.Text = Math.Round(results(14).Value, 2) & " Гц")
                    Me.Invoke(Sub() Label50.Text = Math.Round(results(15).Value, 2) & " ")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_AVOv2_IZM_START()

        Try

ARG:
            groupState_AVOv2Izm.Name = "AVOv2Izm"
            groupState_AVOv2Izm.Active = True
            groupState_AVOv2Izm.UpdateRate = MSPEED

            group_AVOv2Izm = DirectCast(m_server.CreateSubscription(groupState_AVOv2Izm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(15) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "КТП_АВО.С2.ВВ2.IA"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "КТП_АВО.С2.ВВ2.IB"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "КТП_АВО.С2.ВВ2.IC"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "КТП_АВО.С2.ВВ2.3I0"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "КТП_АВО.С2.ВВ2.I1"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "КТП_АВО.С2.ВВ2.I2"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "КТП_АВО.С2.ВВ2.I1_A"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "КТП_АВО.С2.ВВ2.I1_R"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "КТП_АВО.С2.ВВ2.UBB"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "КТП_АВО.С2.ВВ2.UA"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "КТП_АВО.С2.ВВ2.UB"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "КТП_АВО.С2.ВВ2.UC"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "КТП_АВО.С2.ВВ2.3U0"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "КТП_АВО.С2.ВВ2.U1"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "КТП_АВО.С2.ВВ2.F"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "КТП_АВО.С2.ВВ2.COS"


            items = group_AVOv2Izm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_AVOv2Izm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = Math.Round(results(0).Value, 2) & " A")
                    Me.Invoke(Sub() Label8.Text = Math.Round(results(1).Value, 2) & " A")
                    Me.Invoke(Sub() Label9.Text = Math.Round(results(2).Value, 2) & " A")
                    Me.Invoke(Sub() Label10.Text = Math.Round(results(3).Value, 2) & " A")
                    Me.Invoke(Sub() Label11.Text = Math.Round(results(4).Value, 2) & " A")
                    Me.Invoke(Sub() Label12.Text = Math.Round(results(5).Value, 2) & " A")
                    Me.Invoke(Sub() Label41.Text = Math.Round(results(6).Value, 2) & " A")
                    Me.Invoke(Sub() Label42.Text = Math.Round(results(7).Value, 2) & " A")
                    Me.Invoke(Sub() Label43.Text = Math.Round(results(8).Value, 2) & " В")
                    Me.Invoke(Sub() Label44.Text = Math.Round(results(9).Value, 2) & " В")
                    Me.Invoke(Sub() Label45.Text = Math.Round(results(10).Value, 2) & " В")
                    Me.Invoke(Sub() Label46.Text = Math.Round(results(11).Value, 2) & " В")
                    Me.Invoke(Sub() Label47.Text = Math.Round(results(12).Value, 2) & " В")
                    Me.Invoke(Sub() Label48.Text = Math.Round(results(13).Value, 2) & " В")
                    Me.Invoke(Sub() Label49.Text = Math.Round(results(14).Value, 2) & " Гц")
                    Me.Invoke(Sub() Label50.Text = Math.Round(results(15).Value, 2) & " ")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_EBav_IZM_START()

        Try

ARG:
            groupState_EBavIzm.Name = "EBavIzm"
            groupState_EBavIzm.Active = True
            groupState_EBavIzm.UpdateRate = MSPEED

            group_EBavIzm = DirectCast(m_server.CreateSubscription(groupState_EBavIzm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(15) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "КТП_ЭБ.С1.АВ.IA"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "КТП_ЭБ.С1.АВ.IB"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "КТП_ЭБ.С1.АВ.IC"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "КТП_ЭБ.С1.АВ.3I0"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "КТП_ЭБ.С1.АВ.I1"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "КТП_ЭБ.С1.АВ.I2"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "КТП_ЭБ.С1.АВ.I1_A"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "КТП_ЭБ.С1.АВ.I1_R"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "КТП_ЭБ.С1.АВ.UBB"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "КТП_ЭБ.С1.АВ.UA"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "КТП_ЭБ.С1.АВ.UB"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "КТП_ЭБ.С1.АВ.UC"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "КТП_ЭБ.С1.АВ.3U0"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "КТП_ЭБ.С1.АВ.U1"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "КТП_ЭБ.С1.АВ.F"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "КТП_ЭБ.С1.АВ.COS"


            items = group_EBavIzm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_EBavIzm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = Math.Round(results(0).Value, 2) & " A")
                    Me.Invoke(Sub() Label8.Text = Math.Round(results(1).Value, 2) & " A")
                    Me.Invoke(Sub() Label9.Text = Math.Round(results(2).Value, 2) & " A")
                    Me.Invoke(Sub() Label10.Text = Math.Round(results(3).Value, 2) & " A")
                    Me.Invoke(Sub() Label11.Text = Math.Round(results(4).Value, 2) & " A")
                    Me.Invoke(Sub() Label12.Text = Math.Round(results(5).Value, 2) & " A")
                    Me.Invoke(Sub() Label41.Text = Math.Round(results(6).Value, 2) & " A")
                    Me.Invoke(Sub() Label42.Text = Math.Round(results(7).Value, 2) & " A")
                    Me.Invoke(Sub() Label43.Text = Math.Round(results(8).Value, 2) & " В")
                    Me.Invoke(Sub() Label44.Text = Math.Round(results(9).Value, 2) & " В")
                    Me.Invoke(Sub() Label45.Text = Math.Round(results(10).Value, 2) & " В")
                    Me.Invoke(Sub() Label46.Text = Math.Round(results(11).Value, 2) & " В")
                    Me.Invoke(Sub() Label47.Text = Math.Round(results(12).Value, 2) & " В")
                    Me.Invoke(Sub() Label48.Text = Math.Round(results(13).Value, 2) & " В")
                    Me.Invoke(Sub() Label49.Text = Math.Round(results(14).Value, 2) & " Гц")
                    Me.Invoke(Sub() Label50.Text = Math.Round(results(15).Value, 2) & " ")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub

    Sub T_REBav_IZM_START()

        Try

ARG:
            groupState_rEBavIzm.Name = "rEBavIzm"
            groupState_rEBavIzm.Active = True
            groupState_rEBavIzm.UpdateRate = MSPEED

            group_REBavIzm = DirectCast(m_server.CreateSubscription(groupState_rEBavIzm), Opc.Da.Subscription)

            Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(15) {}

            '##########################################################

            items(0) = New Global.Opc.Da.Item()
            items(0).ItemName = "КТП_РЭБ.С1.АВ.IA"

            items(1) = New Global.Opc.Da.Item()
            items(1).ItemName = "КТП_РЭБ.С1.АВ.IB"

            items(2) = New Global.Opc.Da.Item()
            items(2).ItemName = "КТП_РЭБ.С1.АВ.IC"

            items(3) = New Global.Opc.Da.Item()
            items(3).ItemName = "КТП_РЭБ.С1.АВ.3I0"

            items(4) = New Global.Opc.Da.Item()
            items(4).ItemName = "КТП_РЭБ.С1.АВ.I1"

            items(5) = New Global.Opc.Da.Item()
            items(5).ItemName = "КТП_РЭБ.С1.АВ.I2"

            items(6) = New Global.Opc.Da.Item()
            items(6).ItemName = "КТП_РЭБ.С1.АВ.I1_A"

            items(7) = New Global.Opc.Da.Item()
            items(7).ItemName = "КТП_РЭБ.С1.АВ.I1_R"

            items(8) = New Global.Opc.Da.Item()
            items(8).ItemName = "КТП_РЭБ.С1.АВ.UBB"

            items(9) = New Global.Opc.Da.Item()
            items(9).ItemName = "КТП_РЭБ.С1.АВ.UA"

            items(10) = New Global.Opc.Da.Item()
            items(10).ItemName = "КТП_РЭБ.С1.АВ.UB"

            items(11) = New Global.Opc.Da.Item()
            items(11).ItemName = "КТП_РЭБ.С1.АВ.UC"

            items(12) = New Global.Opc.Da.Item()
            items(12).ItemName = "КТП_РЭБ.С1.АВ.3U0"

            items(13) = New Global.Opc.Da.Item()
            items(13).ItemName = "КТП_РЭБ.С1.АВ.U1"

            items(14) = New Global.Opc.Da.Item()
            items(14).ItemName = "КТП_РЭБ.С1.АВ.F"

            items(15) = New Global.Opc.Da.Item()
            items(15).ItemName = "КТП_РЭБ.С1.АВ.COS"


            items = group_REBavIzm.AddItems(items)

            Do

                Dim results As ItemValueResult() = Nothing
                results = group_REBavIzm.Read(items)
                For Each item As Item In items
                    item.ClientHandle = item.ItemName
                Next

                results = m_server.Read(items)

                For i As Integer = 0 To results.Length - 1

                    Me.Invoke(Sub() Label7.Text = Math.Round(results(0).Value, 2) & " A")
                    Me.Invoke(Sub() Label8.Text = Math.Round(results(1).Value, 2) & " A")
                    Me.Invoke(Sub() Label9.Text = Math.Round(results(2).Value, 2) & " A")
                    Me.Invoke(Sub() Label10.Text = Math.Round(results(3).Value, 2) & " A")
                    Me.Invoke(Sub() Label11.Text = Math.Round(results(4).Value, 2) & " A")
                    Me.Invoke(Sub() Label12.Text = Math.Round(results(5).Value, 2) & " A")
                    Me.Invoke(Sub() Label41.Text = Math.Round(results(6).Value, 2) & " A")
                    Me.Invoke(Sub() Label42.Text = Math.Round(results(7).Value, 2) & " A")
                    Me.Invoke(Sub() Label43.Text = Math.Round(results(8).Value, 2) & " В")
                    Me.Invoke(Sub() Label44.Text = Math.Round(results(9).Value, 2) & " В")
                    Me.Invoke(Sub() Label45.Text = Math.Round(results(10).Value, 2) & " В")
                    Me.Invoke(Sub() Label46.Text = Math.Round(results(11).Value, 2) & " В")
                    Me.Invoke(Sub() Label47.Text = Math.Round(results(12).Value, 2) & " В")
                    Me.Invoke(Sub() Label48.Text = Math.Round(results(13).Value, 2) & " В")
                    Me.Invoke(Sub() Label49.Text = Math.Round(results(14).Value, 2) & " Гц")
                    Me.Invoke(Sub() Label50.Text = Math.Round(results(15).Value, 2) & " ")

                Next

                Threading.Thread.Sleep(MSPEED)
            Loop


        Catch ex As Exception

            ' Me.Invoke(Sub() Me.Close())
            GoTo ARG
        End Try

    End Sub
End Class