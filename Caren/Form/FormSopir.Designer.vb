<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSopir
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
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.DGSopir = New System.Windows.Forms.DataGridView()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.txtNoHp = New System.Windows.Forms.TextBox()
        Me.txtNamaSopir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDenda = New System.Windows.Forms.Label()
        Me.txtSopir = New System.Windows.Forms.Label()
        Me.txtIDSopir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DGSopir, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnHapus.Location = New System.Drawing.Point(789, 313)
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
        Me.btnSimpan.Location = New System.Drawing.Point(789, 247)
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
        Me.btnUbah.Location = New System.Drawing.Point(789, 181)
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
        Me.btnTambah.Location = New System.Drawing.Point(789, 115)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(60, 60)
        Me.btnTambah.TabIndex = 32
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'DGSopir
        '
        Me.DGSopir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSopir.Location = New System.Drawing.Point(87, 458)
        Me.DGSopir.Name = "DGSopir"
        Me.DGSopir.RowHeadersWidth = 51
        Me.DGSopir.RowTemplate.Height = 29
        Me.DGSopir.Size = New System.Drawing.Size(762, 188)
        Me.DGSopir.TabIndex = 31
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCari.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(432, 48)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(80, 45)
        Me.btnCari.TabIndex = 30
        Me.btnCari.Text = "CARI"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(21, 53)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(386, 34)
        Me.txtCari.TabIndex = 29
        '
        'txtNoHp
        '
        Me.txtNoHp.Location = New System.Drawing.Point(282, 247)
        Me.txtNoHp.Name = "txtNoHp"
        Me.txtNoHp.Size = New System.Drawing.Size(191, 27)
        Me.txtNoHp.TabIndex = 28
        '
        'txtNamaSopir
        '
        Me.txtNamaSopir.Location = New System.Drawing.Point(282, 199)
        Me.txtNamaSopir.Name = "txtNamaSopir"
        Me.txtNamaSopir.Size = New System.Drawing.Size(191, 27)
        Me.txtNamaSopir.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(87, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 28)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nomor HP          : "
        '
        'txtDenda
        '
        Me.txtDenda.AutoSize = True
        Me.txtDenda.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtDenda.ForeColor = System.Drawing.Color.White
        Me.txtDenda.Location = New System.Drawing.Point(87, 195)
        Me.txtDenda.Name = "txtDenda"
        Me.txtDenda.Size = New System.Drawing.Size(192, 28)
        Me.txtDenda.TabIndex = 21
        Me.txtDenda.Text = "Nama Sopir        : "
        '
        'txtSopir
        '
        Me.txtSopir.AutoSize = True
        Me.txtSopir.Font = New System.Drawing.Font("Malgun Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtSopir.ForeColor = System.Drawing.Color.White
        Me.txtSopir.Location = New System.Drawing.Point(328, 39)
        Me.txtSopir.Name = "txtSopir"
        Me.txtSopir.Size = New System.Drawing.Size(271, 54)
        Me.txtSopir.TabIndex = 20
        Me.txtSopir.Text = "FORM SOPIR"
        '
        'txtIDSopir
        '
        Me.txtIDSopir.Location = New System.Drawing.Point(282, 152)
        Me.txtIDSopir.Name = "txtIDSopir"
        Me.txtIDSopir.Size = New System.Drawing.Size(191, 27)
        Me.txtIDSopir.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(87, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 28)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "ID Sopir             : "
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBatal.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Image = Global.Caren.My.Resources.Resources.cancel
        Me.btnBatal.Location = New System.Drawing.Point(789, 379)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(60, 60)
        Me.btnBatal.TabIndex = 43
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(87, 313)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 123)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukkan nama kategori yang dicari"
        '
        'FormSopir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(936, 687)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.txtIDSopir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.DGSopir)
        Me.Controls.Add(Me.txtNoHp)
        Me.Controls.Add(Me.txtNamaSopir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDenda)
        Me.Controls.Add(Me.txtSopir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormSopir"
        Me.Text = "FormSopir"
        CType(Me.DGSopir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents DGSopir As DataGridView
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents txtNoHp As TextBox
    Friend WithEvents txtNamaSopir As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDenda As Label
    Friend WithEvents txtSopir As Label
    Friend WithEvents txtIDSopir As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
