<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmALARM
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
        Me.LV_REPORT_ALARM = New System.Windows.Forms.ListView()
        Me.btnRp10V1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LV_REPORT_ALARM
        '
        Me.LV_REPORT_ALARM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV_REPORT_ALARM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LV_REPORT_ALARM.FullRowSelect = True
        Me.LV_REPORT_ALARM.GridLines = True
        Me.LV_REPORT_ALARM.Location = New System.Drawing.Point(0, 0)
        Me.LV_REPORT_ALARM.MultiSelect = False
        Me.LV_REPORT_ALARM.Name = "LV_REPORT_ALARM"
        Me.LV_REPORT_ALARM.Size = New System.Drawing.Size(569, 341)
        Me.LV_REPORT_ALARM.TabIndex = 6
        Me.LV_REPORT_ALARM.UseCompatibleStateImageBehavior = False
        Me.LV_REPORT_ALARM.View = System.Windows.Forms.View.Details
        '
        'btnRp10V1
        '
        Me.btnRp10V1.Location = New System.Drawing.Point(494, 318)
        Me.btnRp10V1.Name = "btnRp10V1"
        Me.btnRp10V1.Size = New System.Drawing.Size(75, 23)
        Me.btnRp10V1.TabIndex = 113
        Me.btnRp10V1.Text = "Старт"
        Me.btnRp10V1.UseVisualStyleBackColor = True
        Me.btnRp10V1.Visible = False
        '
        'frmALARM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(569, 341)
        Me.Controls.Add(Me.btnRp10V1)
        Me.Controls.Add(Me.LV_REPORT_ALARM)
        Me.DoubleBuffered = True
        Me.Name = "frmALARM"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Текущие аварийные сигналы системы АСУЭ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LV_REPORT_ALARM As System.Windows.Forms.ListView
    Friend WithEvents btnRp10V1 As System.Windows.Forms.Button
End Class
