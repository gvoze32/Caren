<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSewa
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
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHP = New System.Windows.Forms.TextBox()
        Me.txtNIK = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAdmin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDenda = New System.Windows.Forms.Label()
        Me.txtMerekMobil = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbSopir2 = New System.Windows.Forms.CheckBox()
        Me.cbSupir = New System.Windows.Forms.CheckBox()
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.cmbIDMobil = New System.Windows.Forms.ComboBox()
        Me.txtIDSewa = New System.Windows.Forms.TextBox()
        Me.txtIDCost = New System.Windows.Forms.TextBox()
        Me.txtIDSupir = New System.Windows.Forms.TextBox()
        Me.txtTglAmbil = New System.Windows.Forms.DateTimePicker()
        Me.txtTglKembali = New System.Windows.Forms.DateTimePicker()
        Me.txtIDBayar = New System.Windows.Forms.TextBox()
        Me.txtHargaMobil = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(293, 190)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(191, 27)
        Me.txtNama.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(98, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 28)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Nama                : "
        '
        'txtHP
        '
        Me.txtHP.Location = New System.Drawing.Point(293, 289)
        Me.txtHP.Name = "txtHP"
        Me.txtHP.Size = New System.Drawing.Size(191, 27)
        Me.txtHP.TabIndex = 41
        '
        'txtNIK
        '
        Me.txtNIK.Location = New System.Drawing.Point(293, 241)
        Me.txtNIK.Name = "txtNIK"
        Me.txtNIK.Size = New System.Drawing.Size(191, 27)
        Me.txtNIK.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(98, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 28)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "No HP               : "
        '
        'txtAdmin
        '
        Me.txtAdmin.AutoSize = True
        Me.txtAdmin.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtAdmin.ForeColor = System.Drawing.Color.White
        Me.txtAdmin.Location = New System.Drawing.Point(98, 237)
        Me.txtAdmin.Name = "txtAdmin"
        Me.txtAdmin.Size = New System.Drawing.Size(192, 28)
        Me.txtAdmin.TabIndex = 38
        Me.txtAdmin.Text = "NIK                   : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(98, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 28)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Tanggal Ambil    : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(98, 333)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 28)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Merk Mobil        : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(98, 425)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 28)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Tanggal Kembali : "
        '
        'txtDenda
        '
        Me.txtDenda.AutoSize = True
        Me.txtDenda.Font = New System.Drawing.Font("Malgun Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtDenda.ForeColor = System.Drawing.Color.White
        Me.txtDenda.Location = New System.Drawing.Point(338, 57)
        Me.txtDenda.Name = "txtDenda"
        Me.txtDenda.Size = New System.Drawing.Size(267, 54)
        Me.txtDenda.TabIndex = 50
        Me.txtDenda.Text = "FORM SEWA"
        '
        'txtMerekMobil
        '
        Me.txtMerekMobil.Location = New System.Drawing.Point(493, 336)
        Me.txtMerekMobil.Name = "txtMerekMobil"
        Me.txtMerekMobil.Size = New System.Drawing.Size(96, 27)
        Me.txtMerekMobil.TabIndex = 51
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(293, 526)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(191, 27)
        Me.txtHarga.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(98, 522)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 28)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Harga                : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(98, 474)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 28)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Sopir                 : "
        '
        'cbSopir2
        '
        Me.cbSopir2.AutoSize = True
        Me.cbSopir2.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cbSopir2.ForeColor = System.Drawing.Color.White
        Me.cbSopir2.Location = New System.Drawing.Point(381, 474)
        Me.cbSopir2.Name = "cbSopir2"
        Me.cbSopir2.Size = New System.Drawing.Size(131, 32)
        Me.cbSopir2.TabIndex = 56
        Me.cbSopir2.Text = "Tidak Ada"
        Me.cbSopir2.UseVisualStyleBackColor = True
        '
        'cbSupir
        '
        Me.cbSupir.AutoSize = True
        Me.cbSupir.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cbSupir.ForeColor = System.Drawing.Color.White
        Me.cbSupir.Location = New System.Drawing.Point(292, 473)
        Me.cbSupir.Name = "cbSupir"
        Me.cbSupir.Size = New System.Drawing.Size(72, 32)
        Me.cbSupir.TabIndex = 55
        Me.cbSupir.Text = "Ada"
        Me.cbSupir.UseVisualStyleBackColor = True
        '
        'btnMasuk
        '
        Me.btnMasuk.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMasuk.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMasuk.ForeColor = System.Drawing.Color.White
        Me.btnMasuk.Location = New System.Drawing.Point(639, 609)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(251, 45)
        Me.btnMasuk.TabIndex = 57
        Me.btnMasuk.Text = "Masukkan ke database"
        Me.btnMasuk.UseVisualStyleBackColor = False
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnHitung.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHitung.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHitung.ForeColor = System.Drawing.Color.White
        Me.btnHitung.Location = New System.Drawing.Point(493, 516)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(99, 45)
        Me.btnHitung.TabIndex = 58
        Me.btnHitung.Text = "HITUNG"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'cmbIDMobil
        '
        Me.cmbIDMobil.FormattingEnabled = True
        Me.cmbIDMobil.Location = New System.Drawing.Point(293, 336)
        Me.cmbIDMobil.Name = "cmbIDMobil"
        Me.cmbIDMobil.Size = New System.Drawing.Size(192, 28)
        Me.cmbIDMobil.TabIndex = 59
        '
        'txtIDSewa
        '
        Me.txtIDSewa.Location = New System.Drawing.Point(101, 140)
        Me.txtIDSewa.Name = "txtIDSewa"
        Me.txtIDSewa.Size = New System.Drawing.Size(191, 27)
        Me.txtIDSewa.TabIndex = 61
        '
        'txtIDCost
        '
        Me.txtIDCost.Location = New System.Drawing.Point(298, 140)
        Me.txtIDCost.Name = "txtIDCost"
        Me.txtIDCost.Size = New System.Drawing.Size(191, 27)
        Me.txtIDCost.TabIndex = 62
        '
        'txtIDSupir
        '
        Me.txtIDSupir.Location = New System.Drawing.Point(495, 140)
        Me.txtIDSupir.Name = "txtIDSupir"
        Me.txtIDSupir.Size = New System.Drawing.Size(191, 27)
        Me.txtIDSupir.TabIndex = 63
        '
        'txtTglAmbil
        '
        Me.txtTglAmbil.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglAmbil.Location = New System.Drawing.Point(292, 382)
        Me.txtTglAmbil.Name = "txtTglAmbil"
        Me.txtTglAmbil.Size = New System.Drawing.Size(250, 27)
        Me.txtTglAmbil.TabIndex = 64
        '
        'txtTglKembali
        '
        Me.txtTglKembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglKembali.Location = New System.Drawing.Point(293, 427)
        Me.txtTglKembali.Name = "txtTglKembali"
        Me.txtTglKembali.Size = New System.Drawing.Size(250, 27)
        Me.txtTglKembali.TabIndex = 65
        '
        'txtIDBayar
        '
        Me.txtIDBayar.Location = New System.Drawing.Point(692, 140)
        Me.txtIDBayar.Name = "txtIDBayar"
        Me.txtIDBayar.Size = New System.Drawing.Size(191, 27)
        Me.txtIDBayar.TabIndex = 66
        '
        'txtHargaMobil
        '
        Me.txtHargaMobil.Location = New System.Drawing.Point(595, 336)
        Me.txtHargaMobil.Name = "txtHargaMobil"
        Me.txtHargaMobil.Size = New System.Drawing.Size(96, 27)
        Me.txtHargaMobil.TabIndex = 67
        '
        'FormSewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(936, 687)
        Me.Controls.Add(Me.txtHargaMobil)
        Me.Controls.Add(Me.txtIDBayar)
        Me.Controls.Add(Me.txtTglKembali)
        Me.Controls.Add(Me.txtTglAmbil)
        Me.Controls.Add(Me.txtIDSupir)
        Me.Controls.Add(Me.txtIDCost)
        Me.Controls.Add(Me.txtIDSewa)
        Me.Controls.Add(Me.cmbIDMobil)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.btnMasuk)
        Me.Controls.Add(Me.cbSopir2)
        Me.Controls.Add(Me.cbSupir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMerekMobil)
        Me.Controls.Add(Me.txtDenda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHP)
        Me.Controls.Add(Me.txtNIK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAdmin)
        Me.Name = "FormSewa"
        Me.Text = "FormSewa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHP As TextBox
    Friend WithEvents txtNIK As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAdmin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDenda As Label
    Friend WithEvents txtMerekMobil As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbSopir2 As CheckBox
    Friend WithEvents cbSupir As CheckBox
    Friend WithEvents btnMasuk As Button
    Friend WithEvents btnHitung As Button
    Friend WithEvents cmbIDMobil As ComboBox
    Friend WithEvents txtIDSewa As TextBox
    Friend WithEvents txtIDCost As TextBox
    Friend WithEvents txtIDSupir As TextBox
    Friend WithEvents txtTglAmbil As DateTimePicker
    Friend WithEvents txtTglKembali As DateTimePicker
    Friend WithEvents txtIDBayar As TextBox
    Friend WithEvents txtHargaMobil As TextBox
End Class
