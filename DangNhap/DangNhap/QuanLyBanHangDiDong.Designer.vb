<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDSKH = New System.Windows.Forms.Button()
        Me.btnQL = New System.Windows.Forms.Button()
        Me.btnDSSP = New System.Windows.Forms.Button()
        Me.btnHoaDon = New System.Windows.Forms.Button()
        Me.btnDSNV = New System.Windows.Forms.Button()
        Me.btnDSGH = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDSKH)
        Me.Panel1.Controls.Add(Me.btnQL)
        Me.Panel1.Controls.Add(Me.btnDSSP)
        Me.Panel1.Controls.Add(Me.btnHoaDon)
        Me.Panel1.Controls.Add(Me.btnDSNV)
        Me.Panel1.Controls.Add(Me.btnDSGH)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(969, 513)
        Me.Panel1.TabIndex = 12
        '
        'btnDSKH
        '
        Me.btnDSKH.BackgroundImage = Global.DangNhap.My.Resources.Resources.Hinh_anh_chill
        Me.btnDSKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDSKH.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDSKH.ForeColor = System.Drawing.Color.Yellow
        Me.btnDSKH.Location = New System.Drawing.Point(638, 0)
        Me.btnDSKH.Name = "btnDSKH"
        Me.btnDSKH.Size = New System.Drawing.Size(331, 256)
        Me.btnDSKH.TabIndex = 14
        Me.btnDSKH.Text = "Danh Sách Khách Hàng"
        Me.btnDSKH.UseVisualStyleBackColor = True
        '
        'btnQL
        '
        Me.btnQL.BackgroundImage = Global.DangNhap.My.Resources.Resources.background_vu_tru_mau_tim_dep_mat_780x520
        Me.btnQL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQL.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQL.ForeColor = System.Drawing.Color.Yellow
        Me.btnQL.Location = New System.Drawing.Point(638, 251)
        Me.btnQL.Name = "btnQL"
        Me.btnQL.Size = New System.Drawing.Size(331, 262)
        Me.btnQL.TabIndex = 17
        Me.btnQL.Text = "Quay Lại"
        Me.btnQL.UseVisualStyleBackColor = True
        '
        'btnDSSP
        '
        Me.btnDSSP.BackgroundImage = Global.DangNhap.My.Resources.Resources.maxresdefault__1_
        Me.btnDSSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDSSP.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDSSP.ForeColor = System.Drawing.Color.Yellow
        Me.btnDSSP.Location = New System.Drawing.Point(0, 0)
        Me.btnDSSP.Name = "btnDSSP"
        Me.btnDSSP.Size = New System.Drawing.Size(316, 256)
        Me.btnDSSP.TabIndex = 12
        Me.btnDSSP.Text = "Danh Sách Sản Phẩm"
        Me.btnDSSP.UseVisualStyleBackColor = True
        '
        'btnHoaDon
        '
        Me.btnHoaDon.BackgroundImage = Global.DangNhap.My.Resources.Resources.Hinh_Nen_Dep_P1_Sitetin__17_
        Me.btnHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHoaDon.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHoaDon.ForeColor = System.Drawing.Color.Yellow
        Me.btnHoaDon.Location = New System.Drawing.Point(310, 251)
        Me.btnHoaDon.Name = "btnHoaDon"
        Me.btnHoaDon.Size = New System.Drawing.Size(331, 262)
        Me.btnHoaDon.TabIndex = 16
        Me.btnHoaDon.Text = "Hóa Đơn"
        Me.btnHoaDon.UseVisualStyleBackColor = True
        '
        'btnDSNV
        '
        Me.btnDSNV.BackgroundImage = Global.DangNhap.My.Resources.Resources.maxresdefault
        Me.btnDSNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDSNV.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDSNV.ForeColor = System.Drawing.Color.Yellow
        Me.btnDSNV.Location = New System.Drawing.Point(310, 0)
        Me.btnDSNV.Name = "btnDSNV"
        Me.btnDSNV.Size = New System.Drawing.Size(331, 256)
        Me.btnDSNV.TabIndex = 15
        Me.btnDSNV.Text = "Danh Sách Nhân Viên"
        Me.btnDSNV.UseVisualStyleBackColor = True
        '
        'btnDSGH
        '
        Me.btnDSGH.BackgroundImage = Global.DangNhap.My.Resources.Resources.Anh_chill_canh_dep_1
        Me.btnDSGH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDSGH.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDSGH.ForeColor = System.Drawing.Color.Yellow
        Me.btnDSGH.Location = New System.Drawing.Point(0, 251)
        Me.btnDSGH.Name = "btnDSGH"
        Me.btnDSGH.Size = New System.Drawing.Size(316, 262)
        Me.btnDSGH.TabIndex = 13
        Me.btnDSGH.Text = "Giỏ Hàng"
        Me.btnDSGH.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 514)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Quản Lý Bán Hàng Di Động"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDSKH As Button
    Friend WithEvents btnDSSP As Button
    Friend WithEvents btnQL As Button
    Friend WithEvents btnHoaDon As Button
    Friend WithEvents btnDSNV As Button
    Friend WithEvents btnDSGH As Button
End Class
