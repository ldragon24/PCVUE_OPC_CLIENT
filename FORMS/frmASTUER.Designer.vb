<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmASTUER
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lvKos = New System.Windows.Forms.ListView()
        Me.Label202 = New System.Windows.Forms.Label()
        Me.Label203 = New System.Windows.Forms.Label()
        Me.Label204 = New System.Windows.Forms.Label()
        Me.cmbKOS = New System.Windows.Forms.ComboBox()
        Me.dtKOS_N = New System.Windows.Forms.DateTimePicker()
        Me.dtKOS_K = New System.Windows.Forms.DateTimePicker()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbASK = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lvKos, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label202, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label203, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label204, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbKOS, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dtKOS_N, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dtKOS_K, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button10, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbASK, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(907, 586)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lvKos
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.lvKos, 5)
        Me.lvKos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvKos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lvKos.FullRowSelect = True
        Me.lvKos.GridLines = True
        Me.lvKos.Location = New System.Drawing.Point(3, 97)
        Me.lvKos.MultiSelect = False
        Me.lvKos.Name = "lvKos"
        Me.lvKos.Size = New System.Drawing.Size(901, 499)
        Me.lvKos.TabIndex = 21
        Me.lvKos.UseCompatibleStateImageBehavior = False
        Me.lvKos.View = System.Windows.Forms.View.Details
        '
        'Label202
        '
        Me.Label202.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label202.AutoSize = True
        Me.Label202.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label202.Location = New System.Drawing.Point(3, 8)
        Me.Label202.Name = "Label202"
        Me.Label202.Size = New System.Drawing.Size(75, 18)
        Me.Label202.TabIndex = 1
        Me.Label202.Text = "Интервал"
        '
        'Label203
        '
        Me.Label203.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label203.AutoSize = True
        Me.Label203.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label203.Location = New System.Drawing.Point(3, 40)
        Me.Label203.Name = "Label203"
        Me.Label203.Size = New System.Drawing.Size(75, 18)
        Me.Label203.TabIndex = 11
        Me.Label203.Text = "Начало:"
        '
        'Label204
        '
        Me.Label204.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label204.AutoSize = True
        Me.Label204.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label204.Location = New System.Drawing.Point(3, 70)
        Me.Label204.Name = "Label204"
        Me.Label204.Size = New System.Drawing.Size(75, 18)
        Me.Label204.TabIndex = 12
        Me.Label204.Text = "Конец:"
        '
        'cmbKOS
        '
        Me.cmbKOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmbKOS.FormattingEnabled = True
        Me.cmbKOS.Items.AddRange(New Object() {"Полчаса", "Час", "Сутки", "Месяц"})
        Me.cmbKOS.Location = New System.Drawing.Point(84, 3)
        Me.cmbKOS.Name = "cmbKOS"
        Me.cmbKOS.Size = New System.Drawing.Size(169, 26)
        Me.cmbKOS.TabIndex = 13
        Me.cmbKOS.Text = "Месяц"
        '
        'dtKOS_N
        '
        Me.dtKOS_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.dtKOS_N.Location = New System.Drawing.Point(84, 37)
        Me.dtKOS_N.Name = "dtKOS_N"
        Me.dtKOS_N.Size = New System.Drawing.Size(169, 24)
        Me.dtKOS_N.TabIndex = 14
        '
        'dtKOS_K
        '
        Me.dtKOS_K.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.dtKOS_K.Location = New System.Drawing.Point(84, 67)
        Me.dtKOS_K.Name = "dtKOS_K"
        Me.dtKOS_K.Size = New System.Drawing.Size(169, 24)
        Me.dtKOS_K.TabIndex = 20
        '
        'Button10
        '
        Me.Button10.AutoSize = True
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button10.Location = New System.Drawing.Point(760, 3)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(85, 28)
        Me.Button10.TabIndex = 23
        Me.Button10.Text = "В Excel"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(610, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 28)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Обновить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbASK
        '
        Me.cmbASK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbASK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmbASK.FormattingEnabled = True
        Me.cmbASK.Items.AddRange(New Object() {"Насосная станция II подъёма", "АртСкважина № 1", "АртСкважина № 2", "САУ КОС РСЛ-212", "Очистные сооружения дождевых стоков РСЛ-212 (1)", "Очистные сооружения дождевых стоков РСЛ-212 (2)", "Энергоблок РСЛ-212", "РЭБ - Расхдмер ЭРСВ-510Л", "Столовая", "Гараж", "Мойка машин", "Проходная", "Подпитка тепловая сеть", "Подача тепловая сеть", "Обратный тепловая сеть", "Подача ГВС", "Котельная - Сеть ГВС", "Котельная - Тепловая сеть", "Сырая вода (общая)", "ГПА№1 Ввод 1", "ГПА№1 Ввод 2", "ГПА№2 Ввод 1", "ГПА№2 Ввод 2", "ГПА№3 Ввод 1", "ГПА№3 Ввод 2", "ГПА№4 Ввод 1", "ГПА№4 Ввод 2", "ГПА№5 Ввод 1", "ГПА№5 Ввод 2"})
        Me.cmbASK.Location = New System.Drawing.Point(259, 3)
        Me.cmbASK.Name = "cmbASK"
        Me.cmbASK.Size = New System.Drawing.Size(345, 26)
        Me.cmbASK.TabIndex = 24
        Me.cmbASK.Text = "САУ КОС РСЛ-212"
        '
        'frmASTUER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 586)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Name = "frmASTUER"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "АСТУЭР (SQL)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label202 As System.Windows.Forms.Label
    Friend WithEvents Label203 As System.Windows.Forms.Label
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents lvKos As System.Windows.Forms.ListView
    Friend WithEvents Label204 As System.Windows.Forms.Label
    Friend WithEvents cmbKOS As System.Windows.Forms.ComboBox
    Friend WithEvents dtKOS_N As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtKOS_K As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbASK As System.Windows.Forms.ComboBox
End Class
