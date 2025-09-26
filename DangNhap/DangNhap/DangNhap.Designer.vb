<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLBHDD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQLBHDD))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTK = New System.Windows.Forms.TextBox()
        Me.txtMK = New System.Windows.Forms.TextBox()
        Me.btnDN = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.lnkQMK = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Cyan
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tài Khoản"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Cyan
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mật Khẩu"
        '
        'txtTK
        '
        Me.txtTK.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtTK.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTK.Location = New System.Drawing.Point(343, 96)
        Me.txtTK.Multiline = True
        Me.txtTK.Name = "txtTK"
        Me.txtTK.Size = New System.Drawing.Size(267, 48)
        Me.txtTK.TabIndex = 2
        '
        'txtMK
        '
        Me.txtMK.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtMK.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMK.Location = New System.Drawing.Point(343, 204)
        Me.txtMK.Multiline = True
        Me.txtMK.Name = "txtMK"
        Me.txtMK.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMK.Size = New System.Drawing.Size(267, 48)
        Me.txtMK.TabIndex = 3
        '
        'btnDN
        '
        Me.btnDN.BackColor = System.Drawing.Color.Cyan
        Me.btnDN.Font = New System.Drawing.Font("Arial Black", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDN.ForeColor = System.Drawing.Color.Black
        Me.btnDN.Location = New System.Drawing.Point(116, 372)
        Me.btnDN.Name = "btnDN"
        Me.btnDN.Size = New System.Drawing.Size(207, 66)
        Me.btnDN.TabIndex = 4
        Me.btnDN.Text = "Đăng Nhập"
        Me.btnDN.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.LightYellow
        Me.btnThoat.Font = New System.Drawing.Font("Arial Black", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.Black
        Me.btnThoat.Location = New System.Drawing.Point(390, 372)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(220, 66)
        Me.btnThoat.TabIndex = 5
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'lnkQMK
        '
        Me.lnkQMK.AutoSize = True
        Me.lnkQMK.BackColor = System.Drawing.Color.LightGray
        Me.lnkQMK.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkQMK.LinkColor = System.Drawing.Color.Blue
        Me.lnkQMK.Location = New System.Drawing.Point(565, 26)
        Me.lnkQMK.Name = "lnkQMK"
        Me.lnkQMK.Size = New System.Drawing.Size(154, 24)
        Me.lnkQMK.TabIndex = 6
        Me.lnkQMK.TabStop = True
        Me.lnkQMK.Text = "Quên mật khẩu?"
        '
        'frmQLBHDD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DangNhap.My.Resources.Resources.background_vu_tru_mau_tim_dep_mat_780x520
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(745, 463)
        Me.Controls.Add(Me.lnkQMK)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDN)
        Me.Controls.Add(Me.txtMK)
        Me.Controls.Add(Me.txtTK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQLBHDD"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTK As TextBox
    Friend WithEvents txtMK As TextBox
    Friend WithEvents btnDN As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents lnkQMK As LinkLabel
End Class
