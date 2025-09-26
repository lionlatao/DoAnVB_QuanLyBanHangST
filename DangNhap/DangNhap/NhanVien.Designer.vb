<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNV
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNV))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMaNhanVien = New System.Windows.Forms.TextBox()
        Me.txtHo = New System.Windows.Forms.TextBox()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtGioiTinh = New System.Windows.Forms.TextBox()
        Me.txtChucVu = New System.Windows.Forms.TextBox()
        Me.txtLuongNhanVien = New System.Windows.Forms.TextBox()
        Me.dgvNV = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        CType(Me.dgvNV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(471, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Danh Sách Nhân Viên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.GreenYellow
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(57, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Nhân Viên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.GreenYellow
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(57, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Họ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.GreenYellow
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(57, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tên"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.GreenYellow
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(58, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Địa Chỉ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.GreenYellow
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(57, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 27)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Số Điện Thoại"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.GreenYellow
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(732, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 27)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.GreenYellow
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(732, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 27)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Giới Tính"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.GreenYellow
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(732, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 27)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Chức Vụ"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.GreenYellow
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(732, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(185, 27)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Lương Nhân Viên"
        '
        'txtMaNhanVien
        '
        Me.txtMaNhanVien.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMaNhanVien.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaNhanVien.Location = New System.Drawing.Point(249, 77)
        Me.txtMaNhanVien.Multiline = True
        Me.txtMaNhanVien.Name = "txtMaNhanVien"
        Me.txtMaNhanVien.Size = New System.Drawing.Size(259, 49)
        Me.txtMaNhanVien.TabIndex = 10
        '
        'txtHo
        '
        Me.txtHo.BackColor = System.Drawing.Color.Gainsboro
        Me.txtHo.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHo.Location = New System.Drawing.Point(249, 141)
        Me.txtHo.Multiline = True
        Me.txtHo.Name = "txtHo"
        Me.txtHo.Size = New System.Drawing.Size(259, 44)
        Me.txtHo.TabIndex = 11
        '
        'txtTen
        '
        Me.txtTen.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTen.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTen.Location = New System.Drawing.Point(249, 205)
        Me.txtTen.Multiline = True
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(259, 44)
        Me.txtTen.TabIndex = 12
        '
        'txtDiaChi
        '
        Me.txtDiaChi.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDiaChi.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaChi.Location = New System.Drawing.Point(249, 280)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(259, 44)
        Me.txtDiaChi.TabIndex = 13
        '
        'txtSDT
        '
        Me.txtSDT.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSDT.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSDT.Location = New System.Drawing.Point(249, 350)
        Me.txtSDT.Multiline = True
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(259, 44)
        Me.txtSDT.TabIndex = 14
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(971, 98)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(251, 48)
        Me.txtEmail.TabIndex = 15
        '
        'txtGioiTinh
        '
        Me.txtGioiTinh.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtGioiTinh.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGioiTinh.Location = New System.Drawing.Point(971, 167)
        Me.txtGioiTinh.Multiline = True
        Me.txtGioiTinh.Name = "txtGioiTinh"
        Me.txtGioiTinh.Size = New System.Drawing.Size(251, 48)
        Me.txtGioiTinh.TabIndex = 16
        '
        'txtChucVu
        '
        Me.txtChucVu.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtChucVu.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChucVu.Location = New System.Drawing.Point(971, 241)
        Me.txtChucVu.Multiline = True
        Me.txtChucVu.Name = "txtChucVu"
        Me.txtChucVu.Size = New System.Drawing.Size(251, 44)
        Me.txtChucVu.TabIndex = 17
        '
        'txtLuongNhanVien
        '
        Me.txtLuongNhanVien.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtLuongNhanVien.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLuongNhanVien.Location = New System.Drawing.Point(971, 310)
        Me.txtLuongNhanVien.Multiline = True
        Me.txtLuongNhanVien.Name = "txtLuongNhanVien"
        Me.txtLuongNhanVien.Size = New System.Drawing.Size(251, 40)
        Me.txtLuongNhanVien.TabIndex = 18
        '
        'dgvNV
        '
        Me.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNV.Location = New System.Drawing.Point(63, 420)
        Me.dgvNV.Name = "dgvNV"
        Me.dgvNV.RowHeadersWidth = 51
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red
        Me.dgvNV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNV.RowTemplate.Height = 24
        Me.dgvNV.Size = New System.Drawing.Size(943, 337)
        Me.dgvNV.TabIndex = 19
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.Cyan
        Me.btnThem.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(1065, 420)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(168, 56)
        Me.btnThem.TabIndex = 20
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.Lime
        Me.btnSua.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Location = New System.Drawing.Point(1065, 514)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(168, 56)
        Me.btnSua.TabIndex = 21
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.Red
        Me.btnXoa.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(1065, 611)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(168, 56)
        Me.btnXoa.TabIndex = 22
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(1065, 701)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(168, 56)
        Me.btnThoat.TabIndex = 23
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'frmNV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.BackgroundImage = Global.DangNhap.My.Resources.Resources.maxresdefault
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1283, 772)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvNV)
        Me.Controls.Add(Me.txtLuongNhanVien)
        Me.Controls.Add(Me.txtChucVu)
        Me.Controls.Add(Me.txtGioiTinh)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtTen)
        Me.Controls.Add(Me.txtHo)
        Me.Controls.Add(Me.txtMaNhanVien)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNV"
        Me.Text = "Nhân Viên"
        CType(Me.dgvNV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMaNhanVien As TextBox
    Friend WithEvents txtHo As TextBox
    Friend WithEvents txtTen As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtGioiTinh As TextBox
    Friend WithEvents txtChucVu As TextBox
    Friend WithEvents txtLuongNhanVien As TextBox
    Friend WithEvents dgvNV As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThoat As Button
End Class
