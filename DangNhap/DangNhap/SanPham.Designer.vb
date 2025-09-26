<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSanPham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSanPham))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMSP = New System.Windows.Forms.TextBox()
        Me.txtTSP = New System.Windows.Forms.TextBox()
        Me.txtLSP = New System.Windows.Forms.TextBox()
        Me.txtGT = New System.Windows.Forms.TextBox()
        Me.txtSLCP = New System.Windows.Forms.TextBox()
        Me.dgv_HTSP = New System.Windows.Forms.DataGridView()
        Me.btn_Them = New System.Windows.Forms.Button()
        Me.btn_Sua = New System.Windows.Forms.Button()
        Me.btn_Xoa = New System.Windows.Forms.Button()
        Me.btn_Thoat = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.dgv_HTSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Cyan
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Mã Sản Phẩm"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Cyan
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 24)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Tên Sản Phẩm"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Cyan
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(37, 275)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 24)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Loại Sản Phẩm"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Cyan
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(457, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 24)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Giá Tiền"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Cyan
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(457, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(175, 24)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Số Lượng Cổ Phiếu"
        '
        'txtMSP
        '
        Me.txtMSP.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMSP.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMSP.Location = New System.Drawing.Point(198, 101)
        Me.txtMSP.Multiline = True
        Me.txtMSP.Name = "txtMSP"
        Me.txtMSP.Size = New System.Drawing.Size(202, 37)
        Me.txtMSP.TabIndex = 5
        '
        'txtTSP
        '
        Me.txtTSP.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTSP.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTSP.Location = New System.Drawing.Point(198, 173)
        Me.txtTSP.Multiline = True
        Me.txtTSP.Name = "txtTSP"
        Me.txtTSP.Size = New System.Drawing.Size(202, 37)
        Me.txtTSP.TabIndex = 6
        '
        'txtLSP
        '
        Me.txtLSP.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLSP.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLSP.Location = New System.Drawing.Point(198, 258)
        Me.txtLSP.Multiline = True
        Me.txtLSP.Name = "txtLSP"
        Me.txtLSP.Size = New System.Drawing.Size(202, 37)
        Me.txtLSP.TabIndex = 7
        '
        'txtGT
        '
        Me.txtGT.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGT.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGT.Location = New System.Drawing.Point(642, 118)
        Me.txtGT.Multiline = True
        Me.txtGT.Name = "txtGT"
        Me.txtGT.Size = New System.Drawing.Size(205, 40)
        Me.txtGT.TabIndex = 8
        '
        'txtSLCP
        '
        Me.txtSLCP.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSLCP.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSLCP.Location = New System.Drawing.Point(642, 223)
        Me.txtSLCP.Multiline = True
        Me.txtSLCP.Name = "txtSLCP"
        Me.txtSLCP.Size = New System.Drawing.Size(205, 40)
        Me.txtSLCP.TabIndex = 9
        '
        'dgv_HTSP
        '
        Me.dgv_HTSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_HTSP.Location = New System.Drawing.Point(56, 333)
        Me.dgv_HTSP.Name = "dgv_HTSP"
        Me.dgv_HTSP.RowHeadersWidth = 51
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgv_HTSP.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_HTSP.RowTemplate.Height = 24
        Me.dgv_HTSP.Size = New System.Drawing.Size(590, 237)
        Me.dgv_HTSP.TabIndex = 10
        '
        'btn_Them
        '
        Me.btn_Them.BackColor = System.Drawing.Color.Cyan
        Me.btn_Them.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Them.Location = New System.Drawing.Point(695, 333)
        Me.btn_Them.Name = "btn_Them"
        Me.btn_Them.Size = New System.Drawing.Size(131, 43)
        Me.btn_Them.TabIndex = 11
        Me.btn_Them.Text = "Thêm"
        Me.btn_Them.UseVisualStyleBackColor = False
        '
        'btn_Sua
        '
        Me.btn_Sua.BackColor = System.Drawing.Color.Lime
        Me.btn_Sua.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Sua.Location = New System.Drawing.Point(695, 395)
        Me.btn_Sua.Name = "btn_Sua"
        Me.btn_Sua.Size = New System.Drawing.Size(131, 47)
        Me.btn_Sua.TabIndex = 12
        Me.btn_Sua.Text = "Sửa"
        Me.btn_Sua.UseVisualStyleBackColor = False
        '
        'btn_Xoa
        '
        Me.btn_Xoa.BackColor = System.Drawing.Color.Red
        Me.btn_Xoa.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Xoa.Location = New System.Drawing.Point(695, 461)
        Me.btn_Xoa.Name = "btn_Xoa"
        Me.btn_Xoa.Size = New System.Drawing.Size(131, 44)
        Me.btn_Xoa.TabIndex = 13
        Me.btn_Xoa.Text = "Xóa"
        Me.btn_Xoa.UseVisualStyleBackColor = False
        '
        'btn_Thoat
        '
        Me.btn_Thoat.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Thoat.Location = New System.Drawing.Point(695, 526)
        Me.btn_Thoat.Name = "btn_Thoat"
        Me.btn_Thoat.Size = New System.Drawing.Size(131, 44)
        Me.btn_Thoat.TabIndex = 14
        Me.btn_Thoat.Text = "Thoát"
        Me.btn_Thoat.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Red
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(333, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(313, 37)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Danh Sách Sản Phẩm"
        '
        'frmSanPham
        '
        Me.BackColor = System.Drawing.Color.Cyan
        Me.BackgroundImage = Global.DangNhap.My.Resources.Resources.maxresdefault__1_
        Me.ClientSize = New System.Drawing.Size(898, 582)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btn_Thoat)
        Me.Controls.Add(Me.btn_Xoa)
        Me.Controls.Add(Me.btn_Sua)
        Me.Controls.Add(Me.btn_Them)
        Me.Controls.Add(Me.dgv_HTSP)
        Me.Controls.Add(Me.txtSLCP)
        Me.Controls.Add(Me.txtGT)
        Me.Controls.Add(Me.txtLSP)
        Me.Controls.Add(Me.txtTSP)
        Me.Controls.Add(Me.txtMSP)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSanPham"
        Me.Text = "Sản Phẩm"
        CType(Me.dgv_HTSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMaSanPham As TextBox
    Friend WithEvents txtGiaTien As TextBox
    Friend WithEvents txtLoaiSanPham As TextBox
    Friend WithEvents txtTenSanPham As TextBox
    Friend WithEvents txtSoLuongCoPhieu As TextBox
    Friend WithEvents dgvSanPham As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents QuanLyBanHangDataSet As QuanLyBanHangDataSet
    Friend WithEvents SPBindingSource As BindingSource
    Friend WithEvents SPTableAdapter As QuanLyBanHangDataSetTableAdapters.SPTableAdapter
    Friend WithEvents MaSanPhamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenSanPhamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoaiSanPhamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GiaTienDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongCoPhieuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMSP As TextBox
    Friend WithEvents txtTSP As TextBox
    Friend WithEvents txtLSP As TextBox
    Friend WithEvents txtGT As TextBox
    Friend WithEvents txtSLCP As TextBox
    Friend WithEvents dgv_HTSP As DataGridView
    Friend WithEvents btn_Them As Button
    Friend WithEvents btn_Sua As Button
    Friend WithEvents btn_Xoa As Button
    Friend WithEvents btn_Thoat As Button
    Friend WithEvents Label12 As Label
End Class
