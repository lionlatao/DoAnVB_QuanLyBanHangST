Imports System.Data.SqlClient
Public Class frmGioHang
    Dim Conn As New SqlConnection

    Private Sub Laydl_1()
        Dim da As New SqlDataAdapter("select * from SP", Conn)
        Dim dt As New DataTable
        da.Fill(dt)
        txtMaSanPham.DataBindings.Clear()
        txtMaSanPham.DataBindings.Add("Text", dt, "MaSanPham")
        txtTenSanPham.DataBindings.Clear()
        txtTenSanPham.DataBindings.Add("Text", dt, "TenSanPham")
        txtLoaiSanPham.DataBindings.Clear()
        txtLoaiSanPham.DataBindings.Add("Text", dt, "LoaiSanPham")
        txtGiaTien.DataBindings.Clear()
        txtGiaTien.DataBindings.Add("Text", dt, "GiaTien")
        txtSoLuongCoPhieu.DataBindings.Clear()
        txtSoLuongCoPhieu.DataBindings.Add("Text", dt, "SoLuongCoPhieu")
        dgvSP.DataSource = dt
    End Sub
    Private Sub Laydl_2()
        Dim da As New SqlDataAdapter("select * from GH", Conn)
        Dim dt As New DataTable
        da.Fill(dt)
        txtMaSanPham.DataBindings.Clear()
        txtMaSanPham.DataBindings.Add("Text", dt, "MaSanPham")
        txtTenSanPham.DataBindings.Clear()
        txtTenSanPham.DataBindings.Add("Text", dt, "TenSanPham")
        txtLoaiSanPham.DataBindings.Clear()
        txtLoaiSanPham.DataBindings.Add("Text", dt, "LoaiSanPham")
        txtGiaTien.DataBindings.Clear()
        txtGiaTien.DataBindings.Add("Text", dt, "GiaTien")
        txtSoLuongCoPhieu.DataBindings.Clear()
        txtSoLuongCoPhieu.DataBindings.Add("Text", dt, "SoLuongCoPhieu")
        dgvSPGioHang.DataSource = dt
    End Sub
    Private Sub frmGioHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New SqlConnection("Data Source=NguyenDucLong\NGUYENDUCLONG;Initial Catalog=QuanLyBanHang;Integrated Security=True")
        Conn.Open()
        Laydl_2()
        Laydl_1()
        Conn.Close()
    End Sub

    Private Sub btnThemGH_Click(sender As Object, e As EventArgs) Handles btnThemGH.Click
        Conn.Open()
        MessageBox.Show("Bạn đã thêm mặt hàng này thành công!")
        Dim id As String = txtMaSanPham.Text
        Dim ten As String = txtTenSanPham.Text
        Dim li As String = txtLoaiSanPham.Text
        Dim gt As String = txtGiaTien.Text
        Dim slcp As String = txtSoLuongCoPhieu.Text
        Dim com As New SqlCommand("insert into GH values('" + id + "', N'" + ten + "',N'" + li + "', '" + gt + "', '" + slcp + "')", Conn)
        com.ExecuteNonQuery()
        Laydl_1()
        Conn.Close()
    End Sub

    Private Sub btnXoaGH_Click(sender As Object, e As EventArgs) Handles btnXoaGH.Click
        Conn.Open()
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim id As String = txtMaSanPham.Text
            Dim com As New SqlCommand("delete GH where MaSanPham='" + id + "'", Conn)
            com.ExecuteNonQuery()
            Laydl_2()
        End If
        Conn.Close()
    End Sub

    Private Sub btnThanhToan_Click(sender As Object, e As EventArgs) Handles btnThanhToan.Click
        ' Lấy dữ liệu dòng đang được chọn trong DataGridView
        Dim lc As DataGridViewRow = dgvSPGioHang.CurrentRow

        ' Kiểm tra xem có dòng nào được chọn không
        If lc IsNot Nothing Then
            ' Lấy giá trị của các cột trong dòng được chọn
            Dim MSP As String = lc.Cells("MaSanPham").Value.ToString()
            Dim TSP As String = lc.Cells("TenSanPham").Value.ToString()
            Dim LSP As String = lc.Cells("LoaiSanPham").Value.ToString()
            Dim GT As String = lc.Cells("GiaTien").Value.ToString()
            Dim SLCP As String = lc.Cells("SoLuongCoPhieu").Value.ToString()
            MessageBox.Show("Bạn đã thanh toán sản phẩm này.")
        Else
            ' Hiển thị thông báo nếu không có dòng nào được chọn
            MessageBox.Show("Vui lòng chọn một sản phẩm.")
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát khi chưa thanh toán ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' Kiểm tra kết quả người dùng chọn
        If result = DialogResult.Yes Then
            ' Chuyển sang form khác
            Dim newForm As New frmMain()
            newForm.Show()
            ' Hiện form khác
            Me.Hide()
        End If
    End Sub
End Class