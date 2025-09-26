<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGioHang
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGioHang))
        Me.dgvSPGioHang = New System.Windows.Forms.DataGridView()
        Me.btnThanhToan = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.dgvSP = New System.Windows.Forms.DataGridView()
        Me.txtSoLuongCoPhieu = New System.Windows.Forms.TextBox()
        Me.txtTenSanPham = New System.Windows.Forms.TextBox()
        Me.txtLoaiSanPham = New System.Windows.Forms.TextBox()
        Me.txtGiaTien = New System.Windows.Forms.TextBox()
        Me.txtMaSanPham = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnThemGH = New System.Windows.Forms.Button()
        Me.btnXoaGH = New System.Windows.Forms.Button()
        CType(Me.dgvSPGioHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSPGioHang
        '
        Me.dgvSPGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSPGioHang.Location = New System.Drawing.Point(576, 300)
        Me.dgvSPGioHang.Name = "dgvSPGioHang"
        Me.dgvSPGioHang.RowHeadersWidth = 51
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSPGioHang.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSPGioHang.RowTemplate.Height = 24
        Me.dgvSPGioHang.Size = New System.Drawing.Size(506, 206)
        Me.dgvSPGioHang.TabIndex = 0
        '
        'btnThanhToan
        '
        Me.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnThanhToan.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThanhToan.ForeColor = System.Drawing.Color.Black
        Me.btnThanhToan.Location = New System.Drawing.Point(576, 553)
        Me.btnThanhToan.Name = "btnThanhToan"
        Me.btnThanhToan.Size = New System.Drawing.Size(215, 58)
        Me.btnThanhToan.TabIndex = 1
        Me.btnThanhToan.Text = "Thanh Toán"
        Me.btnThanhToan.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(866, 552)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(216, 58)
        Me.btnThoat.TabIndex = 2
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'dgvSP
        '
        Me.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSP.Location = New System.Drawing.Point(12, 300)
        Me.dgvSP.Name = "dgvSP"
        Me.dgvSP.RowHeadersWidth = 51
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSP.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSP.RowTemplate.Height = 24
        Me.dgvSP.Size = New System.Drawing.Size(500, 206)
        Me.dgvSP.TabIndex = 3
        '
        'txtSoLuongCoPhieu
        '
        Me.txtSoLuongCoPhieu.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSoLuongCoPhieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoLuongCoPhieu.Location = New System.Drawing.Point(821, 178)
        Me.txtSoLuongCoPhieu.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSoLuongCoPhieu.Multiline = True
        Me.txtSoLuongCoPhieu.Name = "txtSoLuongCoPhieu"
        Me.txtSoLuongCoPhieu.Size = New System.Drawing.Size(243, 52)
        Me.txtSoLuongCoPhieu.TabIndex = 22
        '
        'txtTenSanPham
        '
        Me.txtTenSanPham.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTenSanPham.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenSanPham.Location = New System.Drawing.Point(226, 127)
        Me.txtTenSanPham.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTenSanPham.Multiline = True
        Me.txtTenSanPham.Name = "txtTenSanPham"
        Me.txtTenSanPham.Size = New System.Drawing.Size(229, 49)
        Me.txtTenSanPham.TabIndex = 21
        '
        'txtLoaiSanPham
        '
        Me.txtLoaiSanPham.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtLoaiSanPham.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoaiSanPham.Location = New System.Drawing.Point(226, 220)
        Me.txtLoaiSanPham.Margin = New System.Windows.Forms.Padding(5)
        Me.txtLoaiSanPham.Multiline = True
        Me.txtLoaiSanPham.Name = "txtLoaiSanPham"
        Me.txtLoaiSanPham.Size = New System.Drawing.Size(229, 48)
        Me.txtLoaiSanPham.TabIndex = 20
        '
        'txtGiaTien
        '
        Me.txtGiaTien.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtGiaTien.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGiaTien.Location = New System.Drawing.Point(821, 49)
        Me.txtGiaTien.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGiaTien.Multiline = True
        Me.txtGiaTien.Name = "txtGiaTien"
        Me.txtGiaTien.Size = New System.Drawing.Size(243, 52)
        Me.txtGiaTien.TabIndex = 19
        '
        'txtMaSanPham
        '
        Me.txtMaSanPham.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMaSanPham.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaSanPham.Location = New System.Drawing.Point(226, 27)
        Me.txtMaSanPham.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMaSanPham.Multiline = True
        Me.txtMaSanPham.Name = "txtMaSanPham"
        Me.txtMaSanPham.Size = New System.Drawing.Size(229, 45)
        Me.txtMaSanPham.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Cyan
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(540, 201)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(233, 31)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Số Lượng Cổ Phiếu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Cyan
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(540, 72)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 31)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Giá Tiền"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Cyan
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 239)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 31)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Loại Sản Phẩm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Cyan
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 147)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 31)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Tên Sản Phẩm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Cyan
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 31)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Mã Sản Phẩm"
        '
        'btnThemGH
        '
        Me.btnThemGH.BackColor = System.Drawing.Color.Lime
        Me.btnThemGH.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemGH.Location = New System.Drawing.Point(12, 553)
        Me.btnThemGH.Name = "btnThemGH"
        Me.btnThemGH.Size = New System.Drawing.Size(228, 58)
        Me.btnThemGH.TabIndex = 23
        Me.btnThemGH.Text = "Thêm vào giỏ hàng"
        Me.btnThemGH.UseVisualStyleBackColor = False
        '
        'btnXoaGH
        '
        Me.btnXoaGH.BackColor = System.Drawing.Color.Red
        Me.btnXoaGH.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaGH.ForeColor = System.Drawing.Color.Black
        Me.btnXoaGH.Location = New System.Drawing.Point(279, 553)
        Me.btnXoaGH.Name = "btnXoaGH"
        Me.btnXoaGH.Size = New System.Drawing.Size(233, 58)
        Me.btnXoaGH.TabIndex = 24
        Me.btnXoaGH.Text = "Xóa khỏi giỏ hàng"
        Me.btnXoaGH.UseVisualStyleBackColor = False
        '
        'frmGioHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1094, 634)
        Me.Controls.Add(Me.btnXoaGH)
        Me.Controls.Add(Me.btnThemGH)
        Me.Controls.Add(Me.txtSoLuongCoPhieu)
        Me.Controls.Add(Me.txtTenSanPham)
        Me.Controls.Add(Me.txtLoaiSanPham)
        Me.Controls.Add(Me.txtGiaTien)
        Me.Controls.Add(Me.txtMaSanPham)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvSP)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnThanhToan)
        Me.Controls.Add(Me.dgvSPGioHang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGioHang"
        Me.Text = "Giỏ Hàng"
        CType(Me.dgvSPGioHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSPGioHang As DataGridView
    Friend WithEvents btnThanhToan As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents QuanLyBanHangDataSet As QuanLyBanHangDataSet
    Friend WithEvents SPTableAdapter As QuanLyBanHangDataSetTableAdapters.SPTableAdapter
    Friend WithEvents dgvSP As DataGridView
    Friend WithEvents txtSoLuongCoPhieu As TextBox
    Friend WithEvents txtTenSanPham As TextBox
    Friend WithEvents txtLoaiSanPham As TextBox
    Friend WithEvents txtGiaTien As TextBox
    Friend WithEvents txtMaSanPham As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnThemGH As Button
    Friend WithEvents btnXoaGH As Button
    Friend WithEvents QuanLyBanHangDataSet4 As QuanLyBanHangDataSet4
    Friend WithEvents GHTableAdapter As QuanLyBanHangDataSet4TableAdapters.GHTableAdapter
End Class
