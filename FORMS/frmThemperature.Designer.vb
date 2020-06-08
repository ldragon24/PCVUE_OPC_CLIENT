<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemperature
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
        Me.lblThemp = New System.Windows.Forms.Label()
        Me.btn_SAUT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblThemp
        '
        Me.lblThemp.AutoSize = True
        Me.lblThemp.BackColor = System.Drawing.Color.Transparent
        Me.lblThemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblThemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblThemp.ForeColor = System.Drawing.Color.Red
        Me.lblThemp.Location = New System.Drawing.Point(0, 0)
        Me.lblThemp.Name = "lblThemp"
        Me.lblThemp.Size = New System.Drawing.Size(386, 108)
        Me.lblThemp.TabIndex = 0
        Me.lblThemp.Text = "10,00 С"
        '
        'btn_SAUT
        '
        Me.btn_SAUT.Location = New System.Drawing.Point(228, 85)
        Me.btn_SAUT.Name = "btn_SAUT"
        Me.btn_SAUT.Size = New System.Drawing.Size(116, 23)
        Me.btn_SAUT.TabIndex = 5
        Me.btn_SAUT.Text = "Старт"
        Me.btn_SAUT.UseVisualStyleBackColor = True
        Me.btn_SAUT.Visible = False
        '
        'frmThemperature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(391, 116)
        Me.Controls.Add(Me.btn_SAUT)
        Me.Controls.Add(Me.lblThemp)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmThemperature"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Температура окружающего воздуха"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblThemp As System.Windows.Forms.Label
    Friend WithEvents btn_SAUT As System.Windows.Forms.Button
End Class
