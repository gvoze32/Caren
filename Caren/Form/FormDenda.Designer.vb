<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDenda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDenda = New System.Windows.Forms.Label()
        Me.txtAdmin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnSewa = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDenda
        '
        Me.txtDenda.AutoSize = True
        Me.txtDenda.Font = New System.Drawing.Font("Malgun Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtDenda.ForeColor = System.Drawing.Color.White
        Me.txtDenda.Location = New System.Drawing.Point(298, 52)
        Me.txtDenda.Name = "txtDenda"
        Me.txtDenda.Size = New System.Drawing.Size(296, 54)
        Me.txtDenda.TabIndex = 2
        Me.txtDenda.Text = "FORM DENDA"
        '
        'txtAdmin
        '
        Me.txtAdmin.AutoSize = True
        Me.txtAdmin.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtAdmin.ForeColor = System.Drawing.Color.White
        Me.txtAdmin.Location = New System.Drawing.Point(79, 231)
        Me.txtAdmin.Name = "txtAdmin"
        Me.txtAdmin.Size = New System.Drawing.Size(190, 28)
        Me.txtAdmin.TabIndex = 3
        Me.txtAdmin.Text = "Total Denda       : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(79, 382)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(366, 28)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Masukkan nama kategori yang dicari"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(79, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total Bayar        : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(79, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 28)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Status Denda"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(274, 179)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 32)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Ada"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(363, 180)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(131, 32)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "Tidak Ada"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(274, 235)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 27)
        Me.TextBox1.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(274, 283)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(191, 27)
        Me.TextBox2.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(79, 426)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(386, 27)
        Me.TextBox3.TabIndex = 13
        '
        'btnSewa
        '
        Me.btnSewa.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnSewa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSewa.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSewa.ForeColor = System.Drawing.Color.White
        Me.btnSewa.Location = New System.Drawing.Point(486, 416)
        Me.btnSewa.Name = "btnSewa"
        Me.btnSewa.Size = New System.Drawing.Size(80, 45)
        Me.btnSewa.TabIndex = 14
        Me.btnSewa.Text = "CARI"
        Me.btnSewa.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(79, 470)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(762, 188)
        Me.DataGridView1.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Caren.My.Resources.Resources.add
        Me.Button1.Location = New System.Drawing.Point(781, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 60)
        Me.Button1.TabIndex = 16
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.Caren.My.Resources.Resources.edit
        Me.Button2.Location = New System.Drawing.Point(781, 230)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 60)
        Me.Button2.TabIndex = 17
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.Caren.My.Resources.Resources.save
        Me.Button3.Location = New System.Drawing.Point(781, 296)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 60)
        Me.Button3.TabIndex = 18
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.Caren.My.Resources.Resources.delete
        Me.Button4.Location = New System.Drawing.Point(781, 362)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 60)
        Me.Button4.TabIndex = 19
        Me.Button4.UseVisualStyleBackColor = False
        '
        'FormDenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(936, 687)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSewa)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAdmin)
        Me.Controls.Add(Me.txtDenda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormDenda"
        Me.Text = "FormDenda"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDenda As Label
    Friend WithEvents txtAdmin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnSewa As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
