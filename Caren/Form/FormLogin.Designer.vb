<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Me.txtLogin = New System.Windows.Forms.Label()
        Me.txtAdmin = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.Label()
        Me.tbAdmin = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtLogin
        '
        Me.txtLogin.AutoSize = True
        Me.txtLogin.Font = New System.Drawing.Font("Malgun Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtLogin.ForeColor = System.Drawing.Color.White
        Me.txtLogin.Location = New System.Drawing.Point(200, 45)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(278, 54)
        Me.txtLogin.TabIndex = 0
        Me.txtLogin.Text = "FORM LOGIN"
        '
        'txtAdmin
        '
        Me.txtAdmin.AutoSize = True
        Me.txtAdmin.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtAdmin.ForeColor = System.Drawing.Color.White
        Me.txtAdmin.Location = New System.Drawing.Point(200, 177)
        Me.txtAdmin.Name = "txtAdmin"
        Me.txtAdmin.Size = New System.Drawing.Size(102, 28)
        Me.txtAdmin.TabIndex = 1
        Me.txtAdmin.Text = "ID Admin"
        '
        'txtPassword
        '
        Me.txtPassword.AutoSize = True
        Me.txtPassword.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(200, 232)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(102, 28)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "Password"
        '
        'tbAdmin
        '
        Me.tbAdmin.Location = New System.Drawing.Point(353, 177)
        Me.tbAdmin.Name = "tbAdmin"
        Me.tbAdmin.Size = New System.Drawing.Size(125, 27)
        Me.tbAdmin.TabIndex = 3
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(353, 232)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(125, 27)
        Me.tbPassword.TabIndex = 4
        '
        'btnMasuk
        '
        Me.btnMasuk.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMasuk.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMasuk.ForeColor = System.Drawing.Color.White
        Me.btnMasuk.Location = New System.Drawing.Point(289, 312)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(110, 54)
        Me.btnMasuk.TabIndex = 5
        Me.btnMasuk.Text = "MASUK"
        Me.btnMasuk.UseVisualStyleBackColor = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(668, 450)
        Me.Controls.Add(Me.btnMasuk)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbAdmin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtAdmin)
        Me.Controls.Add(Me.txtLogin)
        Me.Name = "FormLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLogin As Label
    Friend WithEvents txtAdmin As Label
    Friend WithEvents txtPassword As Label
    Friend WithEvents tbAdmin As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents btnMasuk As Button
End Class
