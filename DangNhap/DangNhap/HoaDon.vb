Imports System.Data.SqlClient
Public Class frmHoaDon
    Dim Conn As New SqlConnection
    Private Sub frmHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New SqlConnection("Data Source=NguyenDucLong\NGUYENDUCLONG;Initial Catalog=QuanLyBanHang;Integrated Security=True")
        Conn.Open()
        Laydl()
        Conn.Close()
    End Sub
    Private Sub Laydl()
        Dim da As New SqlDataAdapter("select * from CTHD", Conn)
        Dim dt As New DataTable
        da.Fill(dt)
        txtMHD.DataBindings.Clear()
        txtMHD.DataBindings.Add("Text", dt, "MaHoaDon")
        txtMaSP.DataBindings.Clear()
        txtMaSP.DataBindings.Add("Text", dt, "MaSanPham")
        txtSoLuongSP.DataBindings.Clear()
        txtSoLuongSP.DataBindings.Add("Text", dt, "SoLuongSanPham")
        txtDonGia.DataBindings.Clear()
        txtDonGia.DataBindings.Add("Text", dt, "DonGia")
        dgvHTHD.DataSource = dt
    End Sub

    Private Sub btnIHD_Click(sender As Object, e As EventArgs) Handles btnIHD.Click
        ' Lấy dữ liệu dòng đang được chọn trong DataGridView
        Dim selectedRow As DataGridViewRow = dgvHTHD.CurrentRow

        ' Kiểm tra xem có dòng nào được chọn không
        If selectedRow IsNot Nothing Then
            ' Lấy giá trị của các cột trong hàng được chọn
            Dim MHD As String = selectedRow.Cells("MaHoaDon").Value.ToString()
            Dim MSP As String = selectedRow.Cells("MaSanPham").Value.ToString()
            Dim SLSP As String = selectedRow.Cells("SoLuongSanPham").Value.ToString()
            Dim DG As String = selectedRow.Cells("DonGia").Value.ToString()


            ' In ra dữ liệu dòng của các cột tương ứng
            MessageBox.Show("MaHoaDon: " & MHD)
            MessageBox.Show("MaSanPham: " & MSP)
            MessageBox.Show("SoLuongSanPham: " & SLSP)
            MessageBox.Show("DonGia: " & DG)

            ' Tiếp tục xử lý in hóa đơn với loại sản phẩm đã chọn
            ' ...
        Else
            ' Hiển thị thông báo nếu không có dòng nào được chọn
            MessageBox.Show("Vui lòng chọn một mục.")
        End If
    End Sub

    Private Sub btn_Thoat_Click(sender As Object, e As EventArgs) Handles btn_Thoat.Click
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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