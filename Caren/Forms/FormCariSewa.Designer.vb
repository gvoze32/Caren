<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCariSewa
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSewa = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 175)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(896, 488)
        Me.DataGridView1.TabIndex = 35
        '
        'btnSewa
        '
        Me.btnSewa.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnSewa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSewa.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSewa.ForeColor = System.Drawing.Color.White
        Me.btnSewa.Location = New System.Drawing.Point(426, 98)
        Me.btnSewa.Name = "btnSewa"
        Me.btnSewa.Size = New System.Drawing.Size(80, 45)
        Me.btnSewa.TabIndex = 34
        Me.btnSewa.Text = "CARI"
        Me.btnSewa.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(19, 108)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(386, 27)
        Me.TextBox3.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 28)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Masukkan ID sewa yang dicari"
        '
        'FormCariSewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(936, 687)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSewa)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormCariSewa"
        Me.Text = "FormCariSewa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSewa As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
End Class
