<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMobil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.DGMobil = New System.Windows.Forms.DataGridView()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.txtHargaSewa = New System.Windows.Forms.TextBox()
        Me.txtTipeMobil = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAdmin = New System.Windows.Forms.Label()
        Me.txtDenda = New System.Windows.Forms.Label()
        Me.txtMerekMobil = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIDMobil = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DGMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHapus.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Image = Global.Caren.My.Resources.Resources.delete
        Me.btnHapus.Location = New System.Drawing.Point(789, 304)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(60, 60)
        Me.btnHapus.TabIndex = 35
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSimpan.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Image = Global.Caren.My.Resources.Resources.save
        Me.btnSimpan.Location = New System.Drawing.Point(789, 238)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(60, 60)
        Me.btnSimpan.TabIndex = 34
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUbah.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUbah.ForeColor = System.Drawing.Color.White
        Me.btnUbah.Image = Global.Caren.My.Resources.Resources.edit
        Me.btnUbah.Location = New System.Drawing.Point(789, 172)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(60, 60)
        Me.btnUbah.TabIndex = 33
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTambah.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Image = Global.Caren.My.Resources.Resources.add
        Me.btnTambah.Location = New System.Drawing.Point(789, 106)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(60, 60)
        Me.btnTambah.TabIndex = 32
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'DGMobil
        '
        Me.DGMobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMobil.Location = New System.Drawing.Point(87, 544)
        Me.DGMobil.Name = "DGMobil"
        Me.DGMobil.RowHeadersWidth = 51
        Me.DGMobil.RowTemplate.Height = 29
        Me.DGMobil.Size = New System.Drawing.Size(762, 188)
        Me.DGMobil.TabIndex = 31
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCari.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(428, 50)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(80, 45)
        Me.btnCari.TabIndex = 30
        Me.btnCari.Text = "CARI"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(21, 55)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(386, 34)
        Me.txtCari.TabIndex = 29
        '
        'txtHargaSewa
        '
        Me.txtHargaSewa.Location = New System.Drawing.Point(282, 275)
        Me.txtHargaSewa.Name = "txtHargaSewa"
        Me.txtHargaSewa.Size = New System.Drawing.Size(191, 27)
        Me.txtHargaSewa.TabIndex = 28
        '
        'txtTipeMobil
        '
        Me.txtTipeMobil.Location = New System.Drawing.Point(282, 225)
        Me.txtTipeMobil.Name = "txtTipeMobil"
        Me.txtTipeMobil.Size = New System.Drawing.Size(191, 27)
        Me.txtTipeMobil.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(87, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 28)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Harga               : "
        '
        'txtAdmin
        '
        Me.txtAdmin.AutoSize = True
        Me.txtAdmin.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtAdmin.ForeColor = System.Drawing.Color.White
        Me.txtAdmin.Location = New System.Drawing.Point(87, 221)
        Me.txtAdmin.Name = "txtAdmin"
        Me.txtAdmin.Size = New System.Drawing.Size(184, 28)
        Me.txtAdmin.TabIndex = 21
        Me.txtAdmin.Text = "Tipe                 : "
        '
        'txtDenda
        '
        Me.txtDenda.AutoSize = True
        Me.txtDenda.Font = New System.Drawing.Font("Malgun Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtDenda.ForeColor = System.Drawing.Color.White
        Me.txtDenda.Location = New System.Drawing.Point(331, 46)
        Me.txtDenda.Name = "txtDenda"
        Me.txtDenda.Size = New System.Drawing.Size(281, 54)
        Me.txtDenda.TabIndex = 20
        Me.txtDenda.Text = "FORM MOBIL"
        '
        'txtMerekMobil
        '
        Me.txtMerekMobil.Location = New System.Drawing.Point(282, 174)
        Me.txtMerekMobil.Name = "txtMerekMobil"
        Me.txtMerekMobil.Size = New System.Drawing.Size(191, 27)
        Me.txtMerekMobil.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(87, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 28)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Merk                : "
        '
        'txtIDMobil
        '
        Me.txtIDMobil.Location = New System.Drawing.Point(282, 126)
        Me.txtIDMobil.Name = "txtIDMobil"
        Me.txtIDMobil.Size = New System.Drawing.Size(191, 27)
        Me.txtIDMobil.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(87, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 28)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "ID Mobil           : "
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBatal.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Image = Global.Caren.My.Resources.Resources.cancel
        Me.btnBatal.Location = New System.Drawing.Point(789, 370)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(60, 60)
        Me.btnBatal.TabIndex = 42
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(87, 388)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 123)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukkan nama mobil yang dicari:"
        '
        'FormMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(936, 781)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.txtIDMobil)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMerekMobil)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.DGMobil)
        Me.Controls.Add(Me.txtHargaSewa)
        Me.Controls.Add(Me.txtTipeMobil)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAdmin)
        Me.Controls.Add(Me.txtDenda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormMobil"
        Me.Text = "FormMobil"
        CType(Me.DGMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents DGMobil As DataGridView
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents txtHargaSewa As TextBox
    Friend WithEvents txtTipeMobil As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAdmin As Label
    Friend WithEvents txtDenda As Label
    Friend WithEvents txtMerekMobil As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIDMobil As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
