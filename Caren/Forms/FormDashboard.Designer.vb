<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
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
        Me.txtDashboard = New System.Windows.Forms.Label()
        Me.btnMobil = New System.Windows.Forms.Button()
        Me.btnSopir = New System.Windows.Forms.Button()
        Me.btnDenda = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnSewa = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDashboard
        '
        Me.txtDashboard.AutoSize = True
        Me.txtDashboard.Font = New System.Drawing.Font("Malgun Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtDashboard.ForeColor = System.Drawing.Color.White
        Me.txtDashboard.Location = New System.Drawing.Point(265, 57)
        Me.txtDashboard.Name = "txtDashboard"
        Me.txtDashboard.Size = New System.Drawing.Size(275, 54)
        Me.txtDashboard.TabIndex = 1
        Me.txtDashboard.Text = "DASHBOARD"
        '
        'btnMobil
        '
        Me.btnMobil.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnMobil.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMobil.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMobil.ForeColor = System.Drawing.Color.White
        Me.btnMobil.Location = New System.Drawing.Point(162, 287)
        Me.btnMobil.Name = "btnMobil"
        Me.btnMobil.Size = New System.Drawing.Size(110, 54)
        Me.btnMobil.TabIndex = 6
        Me.btnMobil.Text = "MOBIL"
        Me.btnMobil.UseVisualStyleBackColor = False
        '
        'btnSopir
        '
        Me.btnSopir.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnSopir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSopir.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSopir.ForeColor = System.Drawing.Color.White
        Me.btnSopir.Location = New System.Drawing.Point(162, 370)
        Me.btnSopir.Name = "btnSopir"
        Me.btnSopir.Size = New System.Drawing.Size(110, 54)
        Me.btnSopir.TabIndex = 7
        Me.btnSopir.Text = "SOPIR"
        Me.btnSopir.UseVisualStyleBackColor = False
        '
        'btnDenda
        '
        Me.btnDenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnDenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDenda.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDenda.ForeColor = System.Drawing.Color.White
        Me.btnDenda.Location = New System.Drawing.Point(524, 370)
        Me.btnDenda.Name = "btnDenda"
        Me.btnDenda.Size = New System.Drawing.Size(110, 54)
        Me.btnDenda.TabIndex = 8
        Me.btnDenda.Text = "DENDA"
        Me.btnDenda.UseVisualStyleBackColor = False
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCari.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(524, 287)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(110, 54)
        Me.btnCari.TabIndex = 9
        Me.btnCari.Text = "CARI"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'btnSewa
        '
        Me.btnSewa.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnSewa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSewa.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSewa.ForeColor = System.Drawing.Color.White
        Me.btnSewa.Location = New System.Drawing.Point(339, 186)
        Me.btnSewa.Name = "btnSewa"
        Me.btnSewa.Size = New System.Drawing.Size(110, 54)
        Me.btnSewa.TabIndex = 10
        Me.btnSewa.Text = "SEWA"
        Me.btnSewa.UseVisualStyleBackColor = False
        '
        'FormDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(812, 529)
        Me.Controls.Add(Me.btnSewa)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.btnDenda)
        Me.Controls.Add(Me.btnSopir)
        Me.Controls.Add(Me.btnMobil)
        Me.Controls.Add(Me.txtDashboard)
        Me.Name = "FormDashboard"
        Me.Text = "FormDashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDashboard As Label
    Friend WithEvents btnMobil As Button
    Friend WithEvents btnSopir As Button
    Friend WithEvents btnDenda As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents btnSewa As Button
End Class
