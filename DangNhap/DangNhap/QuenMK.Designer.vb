<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuenMK
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTK = New System.Windows.Forms.TextBox()
        Me.txtMKM = New System.Windows.Forms.TextBox()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Cyan
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nhập tên tài khoản:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Cyan
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nhập mật khẩu mới:"
        '
        'txtTK
        '
        Me.txtTK.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTK.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTK.ForeColor = System.Drawing.Color.Black
        Me.txtTK.Location = New System.Drawing.Point(340, 46)
        Me.txtTK.Multiline = True
        Me.txtTK.Name = "txtTK"
        Me.txtTK.Size = New System.Drawing.Size(232, 50)
        Me.txtTK.TabIndex = 3
        '
        'txtMKM
        '
        Me.txtMKM.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMKM.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMKM.ForeColor = System.Drawing.Color.Black
        Me.txtMKM.Location = New System.Drawing.Point(340, 137)
        Me.txtMKM.Multiline = True
        Me.txtMKM.Name = "txtMKM"
        Me.txtMKM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMKM.Size = New System.Drawing.Size(232, 49)
        Me.txtMKM.TabIndex = 4
        '
        'btnCapNhat
        '
        Me.btnCapNhat.BackColor = System.Drawing.Color.Fuchsia
        Me.btnCapNhat.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapNhat.Location = New System.Drawing.Point(88, 290)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(198, 57)
        Me.btnCapNhat.TabIndex = 6
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(358, 290)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(198, 57)
        Me.btnThoat.TabIndex = 7
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'frmQuenMK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DangNhap.My.Resources.Resources.background_vu_tru_mau_tim_dep_mat_780x520
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(649, 377)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtMKM)
        Me.Controls.Add(Me.txtTK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmQuenMK"
        Me.Text = "Quên mật khẩu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMKM As TextBox
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnThoat As Button
    Protected Friend WithEvents Label1 As Label
    Protected Friend WithEvents txtTK As TextBox
End Class
