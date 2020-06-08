<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Switch_electro
    Inherits System.Windows.Forms.UserControl

    'Пользовательский элемент управления (UserControl) переопределяет метод Dispose для очистки списка компонентов.
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
        Me.QF = New System.Windows.Forms.PictureBox()
        CType(Me.QF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QF
        '
        Me.QF.BackColor = System.Drawing.Color.Transparent
        Me.QF.BackgroundImage = Global.ASUE_OPER.My.Resources.Resources.OffState
        Me.QF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.QF.Location = New System.Drawing.Point(3, 3)
        Me.QF.Name = "QF"
        Me.QF.Size = New System.Drawing.Size(16, 61)
        Me.QF.TabIndex = 182
        Me.QF.TabStop = False
        Me.QF.Visible = False
        '
        'Switch_electro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.QF)
        Me.Name = "Switch_electro"
        Me.Size = New System.Drawing.Size(22, 65)
        CType(Me.QF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QF As System.Windows.Forms.PictureBox

End Class
