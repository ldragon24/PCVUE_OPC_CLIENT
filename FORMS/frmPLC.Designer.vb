<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPLC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPLC))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pl4 = New System.Windows.Forms.Label()
        Me.pl5 = New System.Windows.Forms.Label()
        Me.pl6 = New System.Windows.Forms.Label()
        Me.pl7 = New System.Windows.Forms.Label()
        Me.pl8 = New System.Windows.Forms.Label()
        Me.pl9 = New System.Windows.Forms.Label()
        Me.pl10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Дата"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(166, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Время"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(12, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Потеря синхронизации"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(12, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Потеря времени"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(12, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(256, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Потеря информации"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(12, 383)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Потеря связи"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(118, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 24)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "-"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(48, 116)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 147)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'pl4
        '
        Me.pl4.AutoSize = True
        Me.pl4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.pl4.ForeColor = System.Drawing.Color.Green
        Me.pl4.Location = New System.Drawing.Point(87, 0)
        Me.pl4.Name = "pl4"
        Me.pl4.Size = New System.Drawing.Size(22, 26)
        Me.pl4.TabIndex = 7
        Me.pl4.Text = "4"
        '
        'pl5
        '
        Me.pl5.AutoSize = True
        Me.pl5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.pl5.ForeColor = System.Drawing.Color.Green
        Me.pl5.Location = New System.Drawing.Point(115, 0)
        Me.pl5.Name = "pl5"
        Me.pl5.Size = New System.Drawing.Size(22, 26)
        Me.pl5.TabIndex = 7
        Me.pl5.Text = "5"
        '
        'pl6
        '
        Me.pl6.AutoSize = True
        Me.pl6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.pl6.ForeColor = System.Drawing.Color.Green
        Me.pl6.Location = New System.Drawing.Point(143, 0)
        Me.pl6.Name = "pl6"
        Me.pl6.Size = New System.Drawing.Size(22, 26)
        Me.pl6.TabIndex = 7
        Me.pl6.Text = "6"
        '
        'pl7
        '
        Me.pl7.AutoSize = True
        Me.pl7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.pl7.ForeColor = System.Drawing.Color.Green
        Me.pl7.Location = New System.Drawing.Point(171, 0)
        Me.pl7.Name = "pl7"
        Me.pl7.Size = New System.Drawing.Size(22, 26)
        Me.pl7.TabIndex = 7
        Me.pl7.Text = "7"
        '
        'pl8
        '
        Me.pl8.AutoSize = True
        Me.pl8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.pl8.ForeColor = System.Drawing.Color.Green
        Me.pl8.Location = New System.Drawing.Point(199, 0)
        Me.pl8.Name = "pl8"
        Me.pl8.Size = New System.Drawing.Size(22, 26)
        Me.pl8.TabIndex = 7
        Me.pl8.Text = "8"
        '
        'pl9
        '
        Me.pl9.AutoSize = True
        Me.pl9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.pl9.ForeColor = System.Drawing.Color.Green
        Me.pl9.Location = New System.Drawing.Point(227, 0)
        Me.pl9.Name = "pl9"
        Me.pl9.Size = New System.Drawing.Size(22, 26)
        Me.pl9.TabIndex = 7
        Me.pl9.Text = "9"
        '
        'pl10
        '
        Me.pl10.AutoSize = True
        Me.pl10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.pl10.ForeColor = System.Drawing.Color.Green
        Me.pl10.Location = New System.Drawing.Point(255, 0)
        Me.pl10.Name = "pl10"
        Me.pl10.Size = New System.Drawing.Size(32, 26)
        Me.pl10.TabIndex = 7
        Me.pl10.Text = "10"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 26)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(31, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 26)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(59, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 26)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "3"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 10
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pl10, 9, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pl9, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pl8, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pl4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pl5, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pl6, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pl7, 6, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 75)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(290, 35)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'frmPLC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 419)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPLC"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmPLC"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pl4 As System.Windows.Forms.Label
    Friend WithEvents pl5 As System.Windows.Forms.Label
    Friend WithEvents pl6 As System.Windows.Forms.Label
    Friend WithEvents pl7 As System.Windows.Forms.Label
    Friend WithEvents pl8 As System.Windows.Forms.Label
    Friend WithEvents pl9 As System.Windows.Forms.Label
    Friend WithEvents pl10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
