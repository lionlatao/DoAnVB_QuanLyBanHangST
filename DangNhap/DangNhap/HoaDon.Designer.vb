<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHoaDon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoaDon))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtMHD = New System.Windows.Forms.TextBox()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.txtSoLuongSP = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.dgvHTHD = New System.Windows.Forms.DataGridView()
        Me.btnIHD = New System.Windows.Forms.Button()
        Me.btn_Thoat = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.dgvHTHD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 24)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Mã Hóa Đơn"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(23, 245)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 24)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Mã Sản Phẩm"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(472, 127)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(186, 24)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Số Lượng Sản Phẩm"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(472, 243)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 24)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Đơn Giá"
        '
        'txtMHD
        '
        Me.txtMHD.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMHD.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMHD.Location = New System.Drawing.Point(174, 107)
        Me.txtMHD.Multiline = True
        Me.txtMHD.Name = "txtMHD"
        Me.txtMHD.Size = New System.Drawing.Size(192, 44)
        Me.txtMHD.TabIndex = 8
        '
        'txtMaSP
        '
        Me.txtMaSP.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMaSP.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaSP.Location = New System.Drawing.Point(174, 222)
        Me.txtMaSP.Multiline = True
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(192, 45)
        Me.txtMaSP.TabIndex = 11
        '
        'txtSoLuongSP
        '
        Me.txtSoLuongSP.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSoLuongSP.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoLuongSP.Location = New System.Drawing.Point(677, 107)
        Me.txtSoLuongSP.Multiline = True
        Me.txtSoLuongSP.Name = "txtSoLuongSP"
        Me.txtSoLuongSP.Size = New System.Drawing.Size(197, 48)
        Me.txtSoLuongSP.TabIndex = 12
        '
        'txtDonGia
        '
        Me.txtDonGia.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDonGia.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDonGia.Location = New System.Drawing.Point(677, 222)
        Me.txtDonGia.Multiline = True
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(197, 45)
        Me.txtDonGia.TabIndex = 14
        '
        'dgvHTHD
        '
        Me.dgvHTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHTHD.Location = New System.Drawing.Point(150, 303)
        Me.dgvHTHD.Name = "dgvHTHD"
        Me.dgvHTHD.RowHeadersWidth = 51
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvHTHD.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHTHD.RowTemplate.Height = 24
        Me.dgvHTHD.Size = New System.Drawing.Size(598, 240)
        Me.dgvHTHD.TabIndex = 17
        '
        'btnIHD
        '
        Me.btnIHD.BackColor = System.Drawing.Color.Yellow
        Me.btnIHD.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIHD.Location = New System.Drawing.Point(215, 565)
        Me.btnIHD.Name = "btnIHD"
        Me.btnIHD.Size = New System.Drawing.Size(203, 52)
        Me.btnIHD.TabIndex = 18
        Me.btnIHD.Text = "In hóa đơn"
        Me.btnIHD.UseVisualStyleBackColor = False
        '
        'btn_Thoat
        '
        Me.btn_Thoat.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Thoat.Location = New System.Drawing.Point(476, 565)
        Me.btn_Thoat.Name = "btn_Thoat"
        Me.btn_Thoat.Size = New System.Drawing.Size(200, 52)
        Me.btn_Thoat.TabIndex = 19
        Me.btn_Thoat.Text = "Thoát"
        Me.btn_Thoat.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(344, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(294, 37)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Hóa Đơn Mua Hàng"
        '
        'frmHoaDon
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = Global.DangNhap.My.Resources.Resources.Hinh_Nen_Dep_P1_Sitetin__17_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(908, 629)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btn_Thoat)
        Me.Controls.Add(Me.btnIHD)
        Me.Controls.Add(Me.dgvHTHD)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtSoLuongSP)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.txtMHD)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHoaDon"
        Me.Text = "Hóa Đơn"
        CType(Me.dgvHTHD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvHTHoaDon As DataGridView
    Friend WithEvents btnInHoaDon As Button
    Friend WithEvents txtMaHoaDon As TextBox
    Friend WithEvents txtMaKhachHang As TextBox
    Friend WithEvents txtMaNhanVien As TextBox
    Friend WithEvents txtTongTien As TextBox
    Friend WithEvents dtpNgayMua As DateTimePicker
    Friend WithEvents btnThoat As Button
    Friend WithEvents txtMSP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSLSP As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDG As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents QuanLyBanHangDataSet3 As QuanLyBanHangDataSet3
    Friend WithEvents CTHDBindingSource As BindingSource
    Friend WithEvents CTHDTableAdapter As QuanLyBanHangDataSet3TableAdapters.CTHDTableAdapter
    Friend WithEvents CTHDBindingSource1 As BindingSource
    Friend WithEvents HDBindingSource As BindingSource
    Friend WithEvents HDTableAdapter As QuanLyBanHangDataSet3TableAdapters.HDTableAdapter
    Friend WithEvents HDBindingSource1 As BindingSource
    Friend WithEvents QuanLyBanHangDataSet3BindingSource As BindingSource
    Friend WithEvents CTHDBindingSource2 As BindingSource
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtMHD As TextBox
    Friend WithEvents txtMKH As TextBox
    Friend WithEvents txtMNV As TextBox
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents txtSoLuongSP As TextBox
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents txtTST As TextBox
    Friend WithEvents dgvHTHD As DataGridView
    Friend WithEvents btnIHD As Button
    Friend WithEvents btn_Thoat As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents txtNMH As TextBox
End Class
