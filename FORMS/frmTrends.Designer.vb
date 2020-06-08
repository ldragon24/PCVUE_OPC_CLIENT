<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrends
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.zg1 = New ZedGraph.ZedGraphControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DTP_DATE = New System.Windows.Forms.DateTimePicker()
        Me.DTP_TIME = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DTP_DATE_K = New System.Windows.Forms.DateTimePicker()
        Me.DTP_TIME_K = New System.Windows.Forms.DateTimePicker()
        Me.btnRt = New System.Windows.Forms.Button()
        Me.Label259 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.zg1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DTP_DATE, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DTP_TIME, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DTP_DATE_K, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DTP_TIME_K, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRt, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label259, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox5, 3, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1036, 549)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'zg1
        '
        Me.zg1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.zg1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.zg1.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.SetColumnSpan(Me.zg1, 5)
        Me.zg1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.zg1.EditButtons = System.Windows.Forms.MouseButtons.Left
        Me.zg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.zg1.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.zg1.IsAntiAlias = True
        Me.zg1.IsAutoScrollRange = True
        Me.zg1.IsEnableSelection = True
        Me.zg1.IsEnableVPan = False
        Me.zg1.IsScrollY2 = True
        Me.zg1.IsShowHScrollBar = True
        Me.zg1.IsShowVScrollBar = True
        Me.zg1.IsZoomOnMouseCenter = True
        Me.zg1.Location = New System.Drawing.Point(3, 77)
        Me.zg1.Name = "zg1"
        Me.zg1.PanModifierKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)
        Me.zg1.ScrollGrace = 0.1R
        Me.zg1.ScrollMaxX = 1.0R
        Me.zg1.ScrollMaxY = 0.0R
        Me.zg1.ScrollMaxY2 = 0.0R
        Me.zg1.ScrollMinX = -1.0R
        Me.zg1.ScrollMinY = 0.0R
        Me.zg1.ScrollMinY2 = 0.0R
        Me.zg1.Size = New System.Drawing.Size(1038, 469)
        Me.zg1.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Дата"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(146, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Время"
        '
        'DTP_DATE
        '
        Me.DTP_DATE.Location = New System.Drawing.Point(3, 16)
        Me.DTP_DATE.Name = "DTP_DATE"
        Me.DTP_DATE.Size = New System.Drawing.Size(137, 20)
        Me.DTP_DATE.TabIndex = 2
        Me.DTP_DATE.Value = New Date(2014, 3, 3, 0, 0, 0, 0)
        '
        'DTP_TIME
        '
        Me.DTP_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTP_TIME.Location = New System.Drawing.Point(146, 16)
        Me.DTP_TIME.Name = "DTP_TIME"
        Me.DTP_TIME.ShowUpDown = True
        Me.DTP_TIME.Size = New System.Drawing.Size(92, 20)
        Me.DTP_TIME.TabIndex = 3
        Me.DTP_TIME.Value = New Date(2014, 3, 3, 13, 30, 0, 0)
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(244, 16)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(273, 21)
        Me.ComboBox3.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(523, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Построить тренд"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DTP_DATE_K
        '
        Me.DTP_DATE_K.Location = New System.Drawing.Point(3, 45)
        Me.DTP_DATE_K.Name = "DTP_DATE_K"
        Me.DTP_DATE_K.Size = New System.Drawing.Size(137, 20)
        Me.DTP_DATE_K.TabIndex = 6
        Me.DTP_DATE_K.Value = New Date(2014, 3, 3, 0, 0, 0, 0)
        '
        'DTP_TIME_K
        '
        Me.DTP_TIME_K.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTP_TIME_K.Location = New System.Drawing.Point(146, 45)
        Me.DTP_TIME_K.Name = "DTP_TIME_K"
        Me.DTP_TIME_K.ShowUpDown = True
        Me.DTP_TIME_K.Size = New System.Drawing.Size(92, 20)
        Me.DTP_TIME_K.TabIndex = 7
        '
        'btnRt
        '
        Me.btnRt.Location = New System.Drawing.Point(650, 16)
        Me.btnRt.Name = "btnRt"
        Me.btnRt.Size = New System.Drawing.Size(121, 23)
        Me.btnRt.TabIndex = 9
        Me.btnRt.Text = "Текущие показания"
        Me.btnRt.UseVisualStyleBackColor = True
        '
        'Label259
        '
        Me.Label259.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label259.AutoSize = True
        Me.Label259.Location = New System.Drawing.Point(414, 51)
        Me.Label259.Name = "Label259"
        Me.Label259.Size = New System.Drawing.Size(103, 13)
        Me.Label259.TabIndex = 10
        Me.Label259.Text = "Тип опорных точек"
        Me.Label259.Visible = False
        '
        'ComboBox5
        '
        Me.ComboBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Circle", "Default", "Diamond", "HDash", "None", "Plus", "Square", "Star", "Triangle", "TriangleDown", "UserDefined", "VDash", "XCross"})
        Me.ComboBox5.Location = New System.Drawing.Point(523, 47)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox5.TabIndex = 11
        Me.ComboBox5.Text = "None"
        Me.ComboBox5.Visible = False
        '
        'frmTrends
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1036, 549)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Name = "frmTrends"
        Me.ShowIcon = False
        Me.Text = "Трэнды"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents zg1 As ZedGraph.ZedGraphControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DTP_DATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_TIME As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DTP_DATE_K As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_TIME_K As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnRt As System.Windows.Forms.Button
    Friend WithEvents Label259 As System.Windows.Forms.Label
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
End Class
