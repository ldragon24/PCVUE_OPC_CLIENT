<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJournal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJournal))
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DTP_R_K = New System.Windows.Forms.DateTimePicker()
        Me.LV_REPORT = New System.Windows.Forms.ListView()
        Me.DTP_R_N = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.Button4, 4, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.DTP_R_K, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.LV_REPORT, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.DTP_R_N, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBox2, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Button5, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Button6, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Button1, 3, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(904, 574)
        Me.TableLayoutPanel3.TabIndex = 10
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.Location = New System.Drawing.Point(622, 42)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(276, 37)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Выбрать последние 4000 событий"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DTP_R_K
        '
        Me.DTP_R_K.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DTP_R_K.Location = New System.Drawing.Point(154, 42)
        Me.DTP_R_K.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DTP_R_K.MinDate = New Date(2012, 1, 1, 0, 0, 0, 0)
        Me.DTP_R_K.Name = "DTP_R_K"
        Me.DTP_R_K.Size = New System.Drawing.Size(171, 24)
        Me.DTP_R_K.TabIndex = 2
        Me.DTP_R_K.Value = New Date(2013, 2, 24, 0, 0, 0, 0)
        '
        'LV_REPORT
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.LV_REPORT, 5)
        Me.LV_REPORT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV_REPORT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LV_REPORT.FullRowSelect = True
        Me.LV_REPORT.GridLines = True
        Me.LV_REPORT.Location = New System.Drawing.Point(3, 85)
        Me.LV_REPORT.MultiSelect = False
        Me.LV_REPORT.Name = "LV_REPORT"
        Me.LV_REPORT.Size = New System.Drawing.Size(898, 486)
        Me.LV_REPORT.TabIndex = 5
        Me.LV_REPORT.UseCompatibleStateImageBehavior = False
        Me.LV_REPORT.View = System.Windows.Forms.View.Details
        '
        'DTP_R_N
        '
        Me.DTP_R_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DTP_R_N.Location = New System.Drawing.Point(3, 42)
        Me.DTP_R_N.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DTP_R_N.MinDate = New Date(2012, 1, 1, 0, 0, 0, 0)
        Me.DTP_R_N.Name = "DTP_R_N"
        Me.DTP_R_N.Size = New System.Drawing.Size(145, 24)
        Me.DTP_R_N.TabIndex = 1
        Me.DTP_R_N.Value = New Date(2013, 2, 22, 0, 0, 0, 0)
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(331, 42)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(204, 26)
        Me.ComboBox2.Sorted = True
        Me.ComboBox2.TabIndex = 3
        Me.ComboBox2.Text = "2БТП._.В3.E"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Начало:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(331, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(204, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Параметр"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(154, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Конец:"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.Location = New System.Drawing.Point(622, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 33)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "В Excel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.AutoSize = True
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button6.Location = New System.Drawing.Point(541, 42)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 37)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Фильтр"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(541, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmJournal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 574)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.DoubleBuffered = True
        Me.Name = "frmJournal"
        Me.ShowIcon = False
        Me.Text = "Журнал событий"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DTP_R_K As System.Windows.Forms.DateTimePicker
    Friend WithEvents LV_REPORT As System.Windows.Forms.ListView
    Friend WithEvents DTP_R_N As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
