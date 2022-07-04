<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDenda
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
        Me.txtDenda = New System.Windows.Forms.Label()
        Me.txtAdmin = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalDenda = New System.Windows.Forms.TextBox()
        Me.txtTotalBayar = New System.Windows.Forms.TextBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.DGDenda = New System.Windows.Forms.DataGridView()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIDDenda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        CType(Me.DGDenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDenda
        '
        Me.txtDenda.AutoSize = True
        Me.txtDenda.Font = New System.Drawing.Font("Malgun Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtDenda.ForeColor = System.Drawing.Color.White
        Me.txtDenda.Location = New System.Drawing.Point(298, 46)
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
        Me.txtAdmin.Location = New System.Drawing.Point(79, 213)
        Me.txtAdmin.Name = "txtAdmin"
        Me.txtAdmin.Size = New System.Drawing.Size(191, 28)
        Me.txtAdmin.TabIndex = 3
        Me.txtAdmin.Text = "Denda               : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(79, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total Bayar        : "
        '
        'txtTotalDenda
        '
        Me.txtTotalDenda.Location = New System.Drawing.Point(274, 217)
        Me.txtTotalDenda.Name = "txtTotalDenda"
        Me.txtTotalDenda.Size = New System.Drawing.Size(191, 27)
        Me.txtTotalDenda.TabIndex = 11
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.Location = New System.Drawing.Point(274, 265)
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.Size = New System.Drawing.Size(191, 27)
        Me.txtTotalBayar.TabIndex = 12
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(21, 60)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(386, 34)
        Me.txtCari.TabIndex = 13
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCari.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(435, 55)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(80, 45)
        Me.btnCari.TabIndex = 14
        Me.btnCari.Text = "CARI"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'DGDenda
        '
        Me.DGDenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDenda.Location = New System.Drawing.Point(79, 470)
        Me.DGDenda.Name = "DGDenda"
        Me.DGDenda.RowHeadersWidth = 51
        Me.DGDenda.RowTemplate.Height = 29
        Me.DGDenda.Size = New System.Drawing.Size(762, 188)
        Me.DGDenda.TabIndex = 15
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUbah.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUbah.ForeColor = System.Drawing.Color.White
        Me.btnUbah.Image = Global.Caren.My.Resources.Resources.edit
        Me.btnUbah.Location = New System.Drawing.Point(781, 165)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(60, 60)
        Me.btnUbah.TabIndex = 17
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSimpan.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Image = Global.Caren.My.Resources.Resources.save
        Me.btnSimpan.Location = New System.Drawing.Point(781, 231)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(60, 60)
        Me.btnSimpan.TabIndex = 18
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHapus.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Image = Global.Caren.My.Resources.Resources.delete
        Me.btnHapus.Location = New System.Drawing.Point(781, 297)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(60, 60)
        Me.btnHapus.TabIndex = 19
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBatal.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Image = Global.Caren.My.Resources.Resources.cancel
        Me.btnBatal.Location = New System.Drawing.Point(781, 363)
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
        Me.GroupBox1.Location = New System.Drawing.Point(79, 325)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 123)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukkan nama kategori yang dicari"
        '
        'txtIDDenda
        '
        Me.txtIDDenda.Location = New System.Drawing.Point(274, 169)
        Me.txtIDDenda.Name = "txtIDDenda"
        Me.txtIDDenda.Size = New System.Drawing.Size(191, 27)
        Me.txtIDDenda.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(79, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 28)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "ID Denda           : "
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnHitung.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHitung.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHitung.ForeColor = System.Drawing.Color.White
        Me.btnHitung.Location = New System.Drawing.Point(484, 253)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(99, 45)
        Me.btnHitung.TabIndex = 59
        Me.btnHitung.Text = "HITUNG"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'FormDenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(936, 687)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtIDDenda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.DGDenda)
        Me.Controls.Add(Me.txtTotalBayar)
        Me.Controls.Add(Me.txtTotalDenda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAdmin)
        Me.Controls.Add(Me.txtDenda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormDenda"
        Me.Text = "FormDenda"
        CType(Me.DGDenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDenda As Label
    Friend WithEvents txtAdmin As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalDenda As TextBox
    Friend WithEvents txtTotalBayar As TextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents DGDenda As DataGridView
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIDDenda As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHitung As Button
End Class
