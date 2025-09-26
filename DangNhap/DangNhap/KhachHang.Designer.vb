<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKhachHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKhachHang))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtMKH = New System.Windows.Forms.TextBox()
        Me.txtHo = New System.Windows.Forms.TextBox()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.txtDC = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.txtGT = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dgvHTKH = New System.Windows.Forms.DataGridView()
        Me.btn_Them = New System.Windows.Forms.Button()
        Me.btn_Sua = New System.Windows.Forms.Button()
        Me.btn_Xoa = New System.Windows.Forms.Button()
        Me.btn_Thoat = New System.Windows.Forms.Button()
        Me.txtNS = New System.Windows.Forms.TextBox()
        CType(Me.dgvHTKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(62, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 24)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Mã Khách Hàng"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(62, 215)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 24)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Họ"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(62, 286)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 24)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Tên"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(62, 346)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 24)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Địa Chỉ"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(565, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(133, 24)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Số Điện Thoại"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(565, 211)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 24)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Email"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(565, 276)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 24)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Giới Tính"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(565, 339)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 24)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Ngày Sinh"
        '
        'txtMKH
        '
        Me.txtMKH.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMKH.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMKH.Location = New System.Drawing.Point(245, 125)
        Me.txtMKH.Multiline = True
        Me.txtMKH.Name = "txtMKH"
        Me.txtMKH.Size = New System.Drawing.Size(191, 39)
        Me.txtMKH.TabIndex = 8
        '
        'txtHo
        '
        Me.txtHo.BackColor = System.Drawing.Color.Gainsboro
        Me.txtHo.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHo.Location = New System.Drawing.Point(245, 206)
        Me.txtHo.Multiline = True
        Me.txtHo.Name = "txtHo"
        Me.txtHo.Size = New System.Drawing.Size(191, 39)
        Me.txtHo.TabIndex = 9
        '
        'txtTen
        '
        Me.txtTen.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTen.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTen.Location = New System.Drawing.Point(245, 271)
        Me.txtTen.Multiline = True
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(191, 39)
        Me.txtTen.TabIndex = 10
        '
        'txtDC
        '
        Me.txtDC.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDC.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDC.Location = New System.Drawing.Point(245, 331)
        Me.txtDC.Multiline = True
        Me.txtDC.Name = "txtDC"
        Me.txtDC.Size = New System.Drawing.Size(191, 39)
        Me.txtDC.TabIndex = 11
        '
        'txtSDT
        '
        Me.txtSDT.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSDT.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSDT.Location = New System.Drawing.Point(759, 125)
        Me.txtSDT.Multiline = True
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(182, 39)
        Me.txtSDT.TabIndex = 12
        '
        'txt_Email
        '
        Me.txt_Email.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_Email.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Email.Location = New System.Drawing.Point(759, 206)
        Me.txt_Email.Multiline = True
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(182, 39)
        Me.txt_Email.TabIndex = 13
        '
        'txtGT
        '
        Me.txtGT.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGT.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGT.Location = New System.Drawing.Point(759, 271)
        Me.txtGT.Multiline = True
        Me.txtGT.Name = "txtGT"
        Me.txtGT.Size = New System.Drawing.Size(182, 39)
        Me.txtGT.TabIndex = 14
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(337, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(405, 37)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "DANH SÁCH KHÁCH HÀNG"
        '
        'dgvHTKH
        '
        Me.dgvHTKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHTKH.Location = New System.Drawing.Point(66, 414)
        Me.dgvHTKH.Name = "dgvHTKH"
        Me.dgvHTKH.RowHeadersWidth = 51
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal
        Me.dgvHTKH.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHTKH.RowTemplate.Height = 24
        Me.dgvHTKH.Size = New System.Drawing.Size(691, 255)
        Me.dgvHTKH.TabIndex = 17
        '
        'btn_Them
        '
        Me.btn_Them.BackColor = System.Drawing.Color.Aqua
        Me.btn_Them.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Them.Location = New System.Drawing.Point(820, 414)
        Me.btn_Them.Name = "btn_Them"
        Me.btn_Them.Size = New System.Drawing.Size(131, 42)
        Me.btn_Them.TabIndex = 18
        Me.btn_Them.Text = "Thêm"
        Me.btn_Them.UseVisualStyleBackColor = False
        '
        'btn_Sua
        '
        Me.btn_Sua.BackColor = System.Drawing.Color.Lime
        Me.btn_Sua.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Sua.Location = New System.Drawing.Point(820, 486)
        Me.btn_Sua.Name = "btn_Sua"
        Me.btn_Sua.Size = New System.Drawing.Size(131, 46)
        Me.btn_Sua.TabIndex = 19
        Me.btn_Sua.Text = "Sửa"
        Me.btn_Sua.UseVisualStyleBackColor = False
        '
        'btn_Xoa
        '
        Me.btn_Xoa.BackColor = System.Drawing.Color.Red
        Me.btn_Xoa.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Xoa.Location = New System.Drawing.Point(820, 559)
        Me.btn_Xoa.Name = "btn_Xoa"
        Me.btn_Xoa.Size = New System.Drawing.Size(131, 43)
        Me.btn_Xoa.TabIndex = 20
        Me.btn_Xoa.Text = "Xóa"
        Me.btn_Xoa.UseVisualStyleBackColor = False
        '
        'btn_Thoat
        '
        Me.btn_Thoat.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Thoat.Location = New System.Drawing.Point(820, 624)
        Me.btn_Thoat.Name = "btn_Thoat"
        Me.btn_Thoat.Size = New System.Drawing.Size(131, 45)
        Me.btn_Thoat.TabIndex = 21
        Me.btn_Thoat.Text = "Thoát"
        Me.btn_Thoat.UseVisualStyleBackColor = True
        '
        'txtNS
        '
        Me.txtNS.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNS.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNS.Location = New System.Drawing.Point(759, 331)
        Me.txtNS.Multiline = True
        Me.txtNS.Name = "txtNS"
        Me.txtNS.Size = New System.Drawing.Size(182, 39)
        Me.txtNS.TabIndex = 22
        '
        'frmKhachHang
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.DangNhap.My.Resources.Resources.Hinh_anh_chill
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1014, 704)
        Me.Controls.Add(Me.txtNS)
        Me.Controls.Add(Me.btn_Thoat)
        Me.Controls.Add(Me.btn_Xoa)
        Me.Controls.Add(Me.btn_Sua)
        Me.Controls.Add(Me.btn_Them)
        Me.Controls.Add(Me.dgvHTKH)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtGT)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.txtDC)
        Me.Controls.Add(Me.txtTen)
        Me.Controls.Add(Me.txtHo)
        Me.Controls.Add(Me.txtMKH)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmKhachHang"
        Me.Text = "Khách Hàng"
        CType(Me.dgvHTKH, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents txtHoKH As TextBox
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents txtDiaChiKH As TextBox
    Friend WithEvents txtSDTKH As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtGTKH As TextBox
    Friend WithEvents dgvDSKH As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents dtpNS As DateTimePicker
    Friend WithEvents QuanLyBanHangDataSet2 As QuanLyBanHangDataSet2
    Friend WithEvents KHBindingSource As BindingSource
    Friend WithEvents KHTableAdapter As QuanLyBanHangDataSet2TableAdapters.KHTableAdapter
    Friend WithEvents MaKhachHangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiaChiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoDienThoaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GioiTinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayThangNamSinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtMKH As TextBox
    Friend WithEvents txtHo As TextBox
    Friend WithEvents txtTen As TextBox
    Friend WithEvents txtDC As TextBox
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents txtGT As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents dgvHTKH As DataGridView
    Friend WithEvents btn_Them As Button
    Friend WithEvents btn_Sua As Button
    Friend WithEvents btn_Xoa As Button
    Friend WithEvents btn_Thoat As Button
    Friend WithEvents txtNS As TextBox
End Class
