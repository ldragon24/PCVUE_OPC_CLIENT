Public Class frmSetup

    Dim dSID As Integer
    Dim AlDsid As Boolean = False
    Dim TRDEDR As Boolean = False

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If Len(txtOPCA.Text) = 0 Then

            MsgBox("Нечего сохранять, для начала введите IP адрес сервера, затем запросите OPC сервера и сделайте выбор OPC сервера", MsgBoxStyle.Exclamation, "")

        Else

            Dim objIniFile As New IniFile(PrPath & "config.ini")
            objIniFile.WriteString("General", "OPCA", txtOPCA.Text)
            objIniFile.WriteString("General", "IPS1", txtIpS1.Text)

        End If

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        If Len(txtOPCR.Text) = 0 Then

            MsgBox("Нечего сохранять, для начала введите IP адрес сервера, затем запросите OPC сервера и сделайте выбор OPC сервера", MsgBoxStyle.Exclamation, "")

        Else

            Dim objIniFile As New IniFile(PrPath & "config.ini")
            objIniFile.WriteString("General", "OPCR", txtOPCR.Text)
            objIniFile.WriteString("General", "IPS2", txtIpS2.Text)

        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Dim objIniFile As New IniFile(PrPath & "config.ini")
        objIniFile.WriteString("General", "SQLASUE", TextBox1.Text)
        objIniFile.WriteString("General", "SQLASUEUSER", TextBox4.Text)
        objIniFile.WriteString("General", "SQLASUEPWD", TextBox5.Text)
        objIniFile.WriteString("General", "SQLASUEDB", TextBox3.Text)

        SQL_SERVER_ASUE = TextBox1.Text
        SQL_USER_ASUE = TextBox4.Text
        SQL_PWD_ASUE = TextBox5.Text
        SQL_DB_ASUE = TextBox3.Text


    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Dim objIniFile As New IniFile(PrPath & "config.ini")
        objIniFile.WriteString("General", "SQLASKUER", TextBox10.Text)
        objIniFile.WriteString("General", "SQLASKUERUSER", TextBox7.Text)
        objIniFile.WriteString("General", "SQLASKUERPWD", TextBox6.Text)
        objIniFile.WriteString("General", "SQLASKUERDB", TextBox8.Text)

        SQL_SERVER_ASKUER = TextBox10.Text
        SQL_USER_ASKUER = TextBox7.Text
        SQL_PWD_ASKUER = TextBox6.Text
        SQL_DB_ASKUER = TextBox8.Text


    End Sub

    Private Sub frmSetup_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim LNGIniFile As New IniFile(PrPath & "config.ini")

        TextBox1.Text = LNGIniFile.GetString("General", "SQLASUE", "192.168.6.13\EMCSSQL")
        TextBox4.Text = LNGIniFile.GetString("General", "SQLASUEUSER", "sa")
        TextBox5.Text = LNGIniFile.GetString("General", "SQLASUEPWD", "abc")
        TextBox3.Text = LNGIniFile.GetString("General", "SQLASUEDB", "EMCSDB")

        TextBox10.Text = LNGIniFile.GetString("General", "SQLASKUER", "192.168.6.13\HDSEMCS")
        TextBox7.Text = LNGIniFile.GetString("General", "SQLASKUERUSER", "sa")
        TextBox6.Text = LNGIniFile.GetString("General", "SQLASKUERPWD", "abc")
        TextBox8.Text = LNGIniFile.GetString("General", "SQLASKUERDB", "TI2_Lukoyanovskaya")

        txtOPCA.Text = LNGIniFile.GetString("General", "OPCA", "opcda://192.168.6.11/SV.OPCDAServer")
        txtOPCR.Text = LNGIniFile.GetString("General", "OPCR", "opcda://192.168.6.12/SV.OPCDAServer")

        txtIpS1.Text = LNGIniFile.GetString("General", "IPS1", "192.168.6.11")
        txtIpS2.Text = LNGIniFile.GetString("General", "IPS2", "192.168.6.12")

        nmTrends.Value = LNGIniFile.GetString("General", "TSPEED", "500")

        NumericUpDown1.Value = LNGIniFile.GetString("General", "MSPEED", "1000")
        NumericUpDown2.Value = LNGIniFile.GetString("General", "TDOT", "6000")

        'TDOT

        ComboBox1.Text = LNGIniFile.GetString("General", "Start", "Контроль системы")

        'objIniFile.WriteString("General", "Start", ComboBox1.Text)

        Select Case tmpALARM

            Case False

                Button9.Text = "Выключена"
                Button9.ForeColor = Color.Red

            Case True

                Button9.Text = "Включена"
                Button9.ForeColor = Color.Blue

        End Select


        BrowseTV.Nodes.Clear()
        BrowseTV.BeginUpdate()

        Dim m_localNetwork As New TreeNode(m_url.ToString, 0, 0)

        m_localNetwork.Tag = m_url.ToString
        m_localNetwork.Name = m_url.ToString
        m_localNetwork.Text = m_url.ToString
        Me.Invoke(Sub() BrowseTV.Nodes.Add(m_localNetwork))

        Browse(m_localNetwork)
        BrowseTV.EndUpdate()
        'lvAlarm

        lvAlarm.Columns.Add("id", 50, HorizontalAlignment.Left)
        lvAlarm.Columns.Add("ТЭГ OPC Сервера", 300, HorizontalAlignment.Left)
        lvAlarm.Columns.Add("Расшифровка (описание)", 300, HorizontalAlignment.Left)
        ResList(lvAlarm)

        Call LOAD_ALARMS_DB()
        Call LOAD_CMB_TRD()

    End Sub

    Private m_localNetwork As TreeNode = Nothing

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click


        BrowseTV.Nodes.Clear()
        BrowseTV.BeginUpdate()

        Dim m_localNetwork As New TreeNode(m_url.ToString, 0, 0)

        m_localNetwork.Tag = m_url.ToString
        m_localNetwork.Name = m_url.ToString
        m_localNetwork.Text = m_url.ToString
        Me.Invoke(Sub() BrowseTV.Nodes.Add(m_localNetwork))

        Browse(m_localNetwork)
        BrowseTV.EndUpdate()

    End Sub

    Private Sub AddProperty(ByVal sTAG As String)
        'groupTagRead
        groupStateTagRead.Name = "TAG1"
        groupStateTagRead.Active = True
        ' groupStateRP10.UpdateRate = 5000

        groupTagRead = DirectCast(m_server.CreateSubscription(groupStateTagRead), Opc.Da.Subscription)

        Dim items As Global.Opc.Da.Item() = New Opc.Da.Item(1) {}

        items(0) = New Global.Opc.Da.Item()
        items(0).ItemName = sTAG

        items(1) = New Global.Opc.Da.Item()
        items(1).ItemName = sTAG & ".Description"


        Dim results As ItemValueResult() = Nothing
        results = groupTagRead.Read(items)
        For Each item As Item In items
            item.ClientHandle = item.ItemName
        Next

        results = m_server.Read(items)

        For i As Integer = 0 To results.Length - 1

            Label13.Text = results(0).Value
            Label14.Text = results(0).Quality.ToString
            Label15.Text = results(0).Timestamp.ToString

            Label18.Text = results(1).Value


        Next

        m_server.CancelSubscription(groupTagRead)


    End Sub

    Public Delegate Sub ElementSelected_EventHandler(element As BrowseElement)
    Public Event ElementSelected As ElementSelected_EventHandler

    Private Sub BrowseTV_AfterSelect(sender As Object, e As System.Windows.Forms.TreeViewEventArgs) Handles BrowseTV.AfterSelect
        Dim node As TreeNode = BrowseTV.SelectedNode


        If IsBrowseElementNode(node) Then
            RaiseEvent ElementSelected(DirectCast(node.Tag, BrowseElement))

            '    OnElementSelected(DirectCast(node.Tag, BrowseElement))

            Label6.Text = DirectCast(node.Tag, BrowseElement).ItemName
            AddProperty(DirectCast(node.Tag, BrowseElement).ItemName)

        Else
            RaiseEvent ElementSelected(Nothing)
        End If




    End Sub

    Private Sub BrowseTV_BeforeExpand(sender As Object, e As System.Windows.Forms.TreeViewCancelEventArgs) Handles BrowseTV.BeforeExpand
        Dim node As TreeNode = e.Node

        If IsBrowseElementNode(node) Then
            ' browse for children if not already fetched.
            If node.Nodes.Count >= 1 AndAlso node.Nodes(0).Text = "" Then
                Browse(node)
            End If

            Return
        End If
    End Sub

    Private Function IsBrowseElementNode(node As TreeNode) As Boolean
        If node Is Nothing OrElse node.Tag Is Nothing Then
            Return False
        End If
        Return (node.Tag.[GetType]() Is GetType(BrowseElement))
    End Function


    Private Function FindServer(node As TreeNode) As Opc.Da.Server
        If node IsNot Nothing Then
            If IsServerNode(node) Then
                Return DirectCast(node.Tag, Opc.Da.Server)
            End If

            Return FindServer(node.Parent)
        End If

        Return Nothing
    End Function

    Private Function IsServerNode(node As TreeNode) As Boolean
        If node Is Nothing OrElse node.Tag Is Nothing Then
            Return False
        End If
        Return GetType(Opc.Da.Server).IsInstanceOfType(node.Tag)
    End Function
    Private m_filters As BrowseFilters = Nothing

    Private Sub Browse(node As TreeNode)
        Try
            ' get the server for the current node.
            Dim server As Opc.Da.Server = m_server

            ' get the current element to use for a browse.
            Dim parent As BrowseElement = Nothing
            Dim itemID As ItemIdentifier = Nothing

            If node.Tag IsNot Nothing AndAlso node.Tag.[GetType]() Is GetType(BrowseElement) Then
                parent = DirectCast(node.Tag, BrowseElement)
                itemID = New ItemIdentifier(parent.ItemPath, parent.ItemName)
            End If

            ' clear the node children.
            node.Nodes.Clear()

            ' add properties
            If parent IsNot Nothing AndAlso parent.Properties IsNot Nothing Then
                For Each [property] As ItemProperty In parent.Properties
                    AddItemProperty(node, [property])
                Next
            End If


            Dim filters As BrowseFilters = Nothing
            m_filters = If((Filters Is Nothing), New BrowseFilters(), Filters)

            ' begin a browse.
            Dim position As Opc.Da.BrowsePosition = Nothing
            Dim elements As BrowseElement() = server.Browse(itemID, m_filters, position)

            ' add children.
            If elements IsNot Nothing Then
                For Each element As BrowseElement In elements
                    AddBrowseElement(node, element)
                Next

                node.Expand()
            End If

            ' loop until all elements have been fetched.
            While position IsNot Nothing
                Dim result As DialogResult = MessageBox.Show("More items meeting search criteria exist. Continue browse?", "Browse Items", MessageBoxButtons.YesNo)

                If result = DialogResult.No Then
                    Exit While
                End If

                ' fetch next batch of elements,.
                elements = server.BrowseNext(position)

                ' add children.
                If elements IsNot Nothing Then
                    For Each element As BrowseElement In elements
                        AddBrowseElement(node, element)
                    Next

                    node.Expand()
                End If
            End While

            ' send notification that property list changed.

            If node.Tag.[GetType]() Is GetType(BrowseElement) Then
                RaiseEvent ElementSelected(DirectCast(node.Tag, BrowseElement))
            Else
                RaiseEvent ElementSelected(Nothing)
            End If

        Catch e As Exception
            MessageBox.Show(e.Message)
        End Try
    End Sub

    Private Sub AddItemProperty(parent As TreeNode, [property] As ItemProperty)
        If [property].ResultID.Succeeded() Then
            ' create the new node.
            Dim node As New TreeNode([property].Description)

            ' select the icon.
            If [property].ItemName IsNot Nothing AndAlso [property].ItemName <> "" Then
                '    node.ImageIndex = InlineAssignHelper(node.SelectedImageIndex, Resources.IMAGE_GREEN_SCROLL)
            Else
                '  node.ImageIndex = InlineAssignHelper(node.SelectedImageIndex, Resources.IMAGE_EXPLODING_BOX)
            End If

            node.Tag = [property]

            If [property].Value IsNot Nothing Then
                Dim child As New TreeNode(Opc.Convert.ToString([property].Value))
                '     child.ImageIndex = InlineAssignHelper(child.SelectedImageIndex, Resources.IMAGE_LIST_BOX)
                child.Tag = [property].Value
                node.Nodes.Add(child)

                If [property].Value.[GetType]().IsArray Then
                    For Each element As Object In DirectCast([property].Value, Array)
                        Dim arrayChild As New TreeNode(Opc.Convert.ToString(element))
                        '        arrayChild.ImageIndex = InlineAssignHelper(arrayChild.SelectedImageIndex, Resources.IMAGE_LIST_BOX)
                        arrayChild.Tag = element
                        child.Nodes.Add(arrayChild)
                    Next
                End If
            End If

            ' add to parent.
            parent.Nodes.Add(node)
        End If
    End Sub

    Private Sub AddBrowseElement(parent As TreeNode, element As BrowseElement)
        ' create the new node.
        Dim node As New TreeNode(element.Name)

        ' select the icon.
        If element.IsItem Then
            ' node.ImageIndex = InlineAssignHelper(node.SelectedImageIndex, Resources.IMAGE_GREEN_SCROLL)
        Else
            ' node.ImageIndex = InlineAssignHelper(node.SelectedImageIndex, Resources.IMAGE_CLOSED_YELLOW_FOLDER)
        End If

        node.Tag = element

        ' add a dummy node to force display of '+' symbol.
        If element.HasChildren Then
            node.Nodes.Add(New TreeNode())
        End If

        ' add properties
        If element.Properties IsNot Nothing Then
            For Each [property] As ItemProperty In element.Properties
                AddItemProperty(node, [property])
            Next
        End If

        ' add to parent.
        parent.Nodes.Add(node)
    End Sub

 
    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click

        Dim discovery As IDiscovery = New OpcCom.ServerEnumerator

        Dim localservers() As Opc.Server = discovery.GetAvailableServers(Specification.COM_DA_20)
        Dim hostservers() As Opc.Server = discovery.GetAvailableServers(Specification.COM_DA_20, txtIpS1.Text, Nothing)

        For i = 0 To hostservers.Count - 1

            txtOPCA.Items.Add(hostservers(i).Url)

        Next

    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click

        Dim discovery As IDiscovery = New OpcCom.ServerEnumerator

        Dim localservers() As Opc.Server = discovery.GetAvailableServers(Specification.COM_DA_20)
        Dim hostservers() As Opc.Server = discovery.GetAvailableServers(Specification.COM_DA_20, txtIpS2.Text, Nothing)

        For i = 0 To hostservers.Count - 1

            txtOPCR.Items.Add(hostservers(i).Url)

        Next

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If Len(nmTrends.Value) = 0 Then

            MsgBox("Нечего сохранять, для начала укажите скорость обновления трендов", MsgBoxStyle.Exclamation, "")

        Else

            Dim objIniFile As New IniFile(PrPath & "config.ini")
            objIniFile.WriteString("General", "TSPEED", nmTrends.Value)
            TSPEED = nmTrends.Value
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click

        If Len(ComboBox1.Text) = 0 Then

            MsgBox("Нечего сохранять, для начала сделайте выбор модуля", MsgBoxStyle.Exclamation, "")

        Else

            Dim objIniFile As New IniFile(PrPath & "config.ini")
            objIniFile.WriteString("General", "Start", ComboBox1.Text)

            sTartI = ComboBox1.Text

        End If


    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click

        Dim objIniFile As New IniFile(PrPath & "config.ini")

        If Button9.Text = "Включена" Then
            objIniFile.WriteString("General", "ALARM", "false")
            Button9.Text = "Выключена"
            Button9.ForeColor = Color.Red
            T_ALARM.Suspend()
            tmpALARM = False
            frmIndexer.lblAlarm.Text = "Звуковая сигнализация выключена"
            frmIndexer.lblAlarm.ForeColor = Color.Red

        Else
            objIniFile.WriteString("General", "ALARM", "true")
            Button9.Text = "Включена"
            Button9.ForeColor = Color.Blue
            T_ALARM.Resume()
            tmpALARM = True
            frmIndexer.lblAlarm.Text = "Звуковая сигнализация включена"
            frmIndexer.lblAlarm.ForeColor = Color.Blue

        End If


    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            lvAlarm.CheckBoxes = True
            lvAlarm.MultiSelect = True
        End If

        If CheckBox2.Checked = False Then
            lvAlarm.CheckBoxes = False
            lvAlarm.MultiSelect = False
        End If
    End Sub

    Private Sub LOAD_ALARMS_DB()
        Dim sSQL As String
        Dim cmd As OleDbCommand
        Dim rs As OleDbDataReader

        sSQL = "SELECT count(*) as t_n FROM Vars"
        cmd = New OleDbCommand(sSQL, DB7)
        rs = cmd.ExecuteReader

        Dim sCOUNT As Integer

        While rs.Read

            sCOUNT = rs.Item("t_n")

        End While

        rs.Close()
        rs = Nothing

        If sCOUNT = 0 Then Exit Sub


        Me.Invoke(Sub() lvAlarm.Sorting = SortOrder.None)
        Me.Invoke(Sub() lvAlarm.ListViewItemSorter = Nothing)
        Me.Invoke(Sub() lvAlarm.Items.Clear())


        sSQL = "SELECT * FROM Vars"
        cmd = New OleDbCommand(sSQL, DB7)
        rs = cmd.ExecuteReader

        Dim intCount2 As Decimal = 0
        While rs.Read

            Me.Invoke(Sub() lvAlarm.Items.Add(rs.Item("id")))
            Me.Invoke(Sub() lvAlarm.Items(CInt(intCount2)).SubItems.Add(rs.Item("Name")))
            Me.Invoke(Sub() lvAlarm.Items(CInt(intCount2)).SubItems.Add(rs.Item("Label")))

            intCount2 = intCount2 + 1
            ' Else
            'End If
        End While

        ResList(lvAlarm)

        rs.Close()
        rs = Nothing

    End Sub

    Private Sub lvAlarm_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles lvAlarm.ColumnClick
        SORTING_LV(lvAlarm, e)
    End Sub

    Private Sub lvAlarm_DoubleClick(sender As Object, e As System.EventArgs) Handles lvAlarm.DoubleClick

        If lvAlarm.Items.Count = 0 Then Exit Sub

        Dim z As Integer

        For z = 0 To lvAlarm.SelectedItems.Count - 1
            dSID = (lvAlarm.SelectedItems(z).Text)
        Next


        Dim sSQL As String
        Dim cmd As OleDbCommand
        Dim rs As OleDbDataReader

        sSQL = "SELECT count(*) as t_n FROM Vars where id=" & dSID
        cmd = New OleDbCommand(sSQL, DB7)
        rs = cmd.ExecuteReader

        Dim sCOUNT As Integer

        While rs.Read

            sCOUNT = rs.Item("t_n")

        End While

        rs.Close()
        rs = Nothing

        If sCOUNT = 0 Then Exit Sub

        AlDsid = True

        sSQL = "SELECT * FROM Vars where id=" & dSID
        cmd = New OleDbCommand(sSQL, DB7)
        rs = cmd.ExecuteReader

        While rs.Read

            TextBox2.Text = rs.Item("Name")
            TextBox9.Text = rs.Item("Label")

        End While

        ResList(lvAlarm)

        rs.Close()
        rs = Nothing

    End Sub

    Private Sub btnDirAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnDirAdd.Click

        Dim sSQL As String

        Select Case AlDsid

            Case True
                AlDsid = False

                Try
                    sSQL = "UPDATE Vars SET Name=@item1, Label=@item2 Where id=" & dSID

                    Dim cmdInsert As New OleDbCommand
                    Dim iSqlStatus As Integer

                    cmdInsert.Parameters.Clear()

                    With cmdInsert
                        .CommandText = sSQL
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@value1", TextBox2.Text)
                        .Parameters.AddWithValue("@value2", TextBox9.Text)
                        .Connection = DB7

                    End With

                    iSqlStatus = cmdInsert.ExecuteNonQuery

                    If Not iSqlStatus = 0 Then
                        'Return False
                    Else
                        'Return True
                    End If

                Catch ex As Exception
                    'MsgBox(ex.Message, "Error")
                Finally
                    'HandleConnection(DB8)
                End Try

            Case False
                AlDsid = False

                Try

                    sSQL = "INSERT INTO [Vars]([Name],[Label]) VALUES(@item1,@item2)"

                    Dim cmdInsert As New OleDbCommand
                    Dim iSqlStatus As Integer

                    cmdInsert.Parameters.Clear()

                    With cmdInsert
                        .CommandText = sSQL
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@value1", TextBox2.Text)
                        .Parameters.AddWithValue("@value2", TextBox9.Text)
                        .Connection = DB7

                    End With

                    iSqlStatus = cmdInsert.ExecuteNonQuery

                    If Not iSqlStatus = 0 Then
                        'Return False
                    Else
                        'Return True
                    End If

                Catch ex As Exception
                    'MsgBox(ex.Message, "Error")
                Finally
                    'HandleConnection(DB8)
                End Try

        End Select

        Call LOAD_ALARMS_DB()

        TextBox2.Text = ""
        TextBox9.Text = ""

    End Sub

    Private Sub btnCancell_Click(sender As System.Object, e As System.EventArgs) Handles btnCancell.Click
        AlDsid = False
        TextBox2.Text = ""
        TextBox9.Text = ""

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        For z = 0 To lvAlarm.SelectedItems.Count - 1
            dSID = (lvAlarm.SelectedItems(z).Text)
        Next



        Select Case CheckBox2.Checked

            Case True

                Dim intj As Integer = 0

                lvAlarm.Select()

                For intj = 0 To lvAlarm.Items.Count - 1

                    lvAlarm.Items(intj).Selected = True
                    lvAlarm.Items(intj).EnsureVisible()

                    If lvAlarm.Items(intj).Checked = True Then

                        '  Call DELETE_SPR(lvAlarm.SelectedItems(intj).Text)

                        cmd = New OleDbCommand("Delete FROM Vars WHERE id=" & lvAlarm.SelectedItems(intj).Text, DB7)
                        dr = cmd.ExecuteReader
                        dr = Nothing

                    End If

                Next

            Case False

                cmd = New OleDbCommand("Delete FROM Vars WHERE id=" & dSID, DB7)
                dr = cmd.ExecuteReader
                dr = Nothing

        End Select

        Call LOAD_ALARMS_DB()


    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        If Len(nmTrends.Value) = 0 Then

            MsgBox("Нечего сохранять, для начала укажите скорость обновления мнемосхем", MsgBoxStyle.Exclamation, "")

        Else

            Dim objIniFile As New IniFile(PrPath & "config.ini")
            objIniFile.WriteString("General", "MSPEED", NumericUpDown1.Value)
            MSPEED = NumericUpDown1.Value
        End If
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        If Len(nmTrends.Value) = 0 Then

            MsgBox("Нечего сохранять, для начала укажите количество точек для трендов", MsgBoxStyle.Exclamation, "")

        Else

            Dim objIniFile As New IniFile(PrPath & "config.ini")
            objIniFile.WriteString("General", "TDOT", NumericUpDown2.Value)
            TDOT = NumericUpDown2.Value
        End If
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click

        If ListBox1.Items.Count = 4 Then Exit Sub

        ListBox1.Items.Add(Label6.Text)

    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click

        For z = 0 To ListBox1.SelectedItems.Count - 1

            ListBox1.Items.Remove(ListBox1.SelectedItem)

        Next

    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click

        Dim sSQL As String

        If Len(TextBox11.Text) = 0 Then

            MsgBox("Нет наименования тренда", MsgBoxStyle.Exclamation, "")
            Exit Sub

        End If

        If TRDEDR = True Then

            Dim cmd As OleDbCommand
            Dim dr As OleDbDataReader

            cmd = New OleDbCommand("DELETE FROM Trends where Name='" & TextBox11.Text & "'", DB7)
            dr = cmd.ExecuteReader
            dr = Nothing
        End If

        For z = 0 To ListBox1.Items.Count - 1

            ListBox1.SelectedIndex = z

            Try

                sSQL = "INSERT INTO [Trends]([TEG],[Name]) VALUES(@item1,@item2)"

                Dim cmdInsert As New OleDbCommand
                Dim iSqlStatus As Integer

                cmdInsert.Parameters.Clear()

                With cmdInsert
                    .CommandText = sSQL
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@value1", ListBox1.SelectedItem)
                    .Parameters.AddWithValue("@value2", TextBox11.Text)
                    .Connection = DB7

                End With

                iSqlStatus = cmdInsert.ExecuteNonQuery

                If Not iSqlStatus = 0 Then
                    'Return False
                Else
                    'Return True
                End If

            Catch ex As Exception
                'MsgBox(ex.Message, "Error")
            Finally
                'HandleConnection(DB8)
            End Try
        Next

        ListBox1.Items.Clear()
        TextBox11.Text = ""

        Call LOAD_CMB_TRD()

        TRDEDR = False

    End Sub

    Private Sub LOAD_CMB_TRD()
        'TextBox11

        Dim sSQL As String
        Dim cmd As OleDbCommand
        Dim rs As OleDbDataReader

        sSQL = "SELECT count(*) as t_n FROM Trends"

        cmd = New OleDbCommand(sSQL, DB7)
        rs = cmd.ExecuteReader

        Dim sCOUNT As Integer

        While rs.Read

            sCOUNT = rs.Item("t_n")

        End While

        rs.Close()
        rs = Nothing

        If sCOUNT = 0 Then Exit Sub

        sSQL = "SELECT Name FROM Trends Group by Name"

        cmd = New OleDbCommand(sSQL, DB7)
        rs = cmd.ExecuteReader

        TextBox11.Items.Clear()

        While rs.Read

            TextBox11.Items.Add(rs.Item("Name"))

        End While

        rs.Close()
        rs = Nothing



    End Sub

    Private Sub TextBox11_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TextBox11.SelectedIndexChanged

        TRDEDR = True

        Dim sSQL As String
        Dim cmd As OleDbCommand
        Dim rs As OleDbDataReader

        sSQL = "SELECT count(*) as t_n FROM Trends where Name='" & TextBox11.Text & "'"

        cmd = New OleDbCommand(sSQL, DB7)
        rs = cmd.ExecuteReader

        Dim sCOUNT As Integer

        While rs.Read

            sCOUNT = rs.Item("t_n")

        End While

        rs.Close()
        rs = Nothing

        If sCOUNT = 0 Then Exit Sub

        sSQL = "SELECT TEG FROM Trends where Name='" & TextBox11.Text & "'"

        cmd = New OleDbCommand(sSQL, DB7)
        rs = cmd.ExecuteReader

        ListBox1.Items.Clear()

        While rs.Read

            ListBox1.Items.Add(rs.Item("TEG"))

        End While

        rs.Close()
        rs = Nothing


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
