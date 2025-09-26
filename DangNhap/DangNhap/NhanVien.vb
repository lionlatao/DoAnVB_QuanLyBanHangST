Imports System.Data.SqlClient
Public Class frmNV
    Dim Conn As New SqlConnection
    Private Sub Laydl()
        Dim da As New SqlDataAdapter("select * from NV", Conn)
        Dim dt As New DataTable
        da.Fill(dt)
        dgvNV.DataSource = dt
        txtMaNhanVien.DataBindings.Clear()
        txtMaNhanVien.DataBindings.Add("Text", dt, "MaNhanVien")
        txtHo.DataBindings.Clear()
        txtHo.DataBindings.Add("Text", dt, "Ho")
        txtTen.DataBindings.Clear()
        txtTen.DataBindings.Add("Text", dt, "Ten")
        txtDiaChi.DataBindings.Clear()
        txtDiaChi.DataBindings.Add("Text", dt, "DiaChi")
        txtSDT.DataBindings.Clear()
        txtSDT.DataBindings.Add("Text", dt, "SoDienThoai")
        txtEmail.DataBindings.Clear()
        txtEmail.DataBindings.Add("Text", dt, "Email")
        txtGioiTinh.DataBindings.Clear()
        txtGioiTinh.DataBindings.Add("Text", dt, "GioiTinh")
        txtChucVu.DataBindings.Clear()
        txtChucVu.DataBindings.Add("Text", dt, "ChucVu")
        txtLuongNhanVien.DataBindings.Clear()
        txtLuongNhanVien.DataBindings.Add("Text", dt, "LuongNhanVien")
    End Sub

    Private Sub frmNV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New SqlConnection("Data Source=NguyenDucLong\NGUYENDUCLONG;Initial Catalog=QuanLyBanHang;Integrated Security=True")
        Conn.Open()
        Laydl()
        Conn.Close()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Conn.Open()
        MessageBox.Show("Bạn đã thêm nhân viên mới !")
        Dim id As String = txtMaNhanVien.Text
        Dim ho As String = txtHo.Text
        Dim tn As String = txtTen.Text
        Dim dc As String = txtDiaChi.Text
        Dim sdt As String = txtSDT.Text
        Dim email As String = txtEmail.Text
        Dim gn As String = txtGioiTinh.Text
        Dim cv As String = txtChucVu.Text
        Dim lnv As String = txtLuongNhanVien.Text
        Dim com As New SqlCommand("insert into NV values('" + id + "', N'" + ho + "',N'" + tn + "', N'" + dc + "', '" + sdt + "', '" + email + "','" + gn + "', N'" + cv + "',N'" + lnv + "')", Conn)
        com.ExecuteNonQuery()
        Laydl()
        Conn.Close()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Conn.Open()
        MessageBox.Show("Cập nhật thành công !")
        Dim id As String = txtMaNhanVien.Text
        Dim ho As String = txtHo.Text
        Dim tn As String = txtTen.Text
        Dim dc As String = txtDiaChi.Text
        Dim sdt As String = txtSDT.Text
        Dim email As String = txtEmail.Text
        Dim gn As String = txtGioiTinh.Text
        Dim cv As String = txtChucVu.Text
        Dim lnv As String = txtLuongNhanVien.Text
        Dim com As New SqlCommand("update NV set Ho=N'" + ho + "',Ten=N'" + tn + "', DiaChi=N'" + dc + "', SoDienThoai='" + sdt + "', Email='" + email + "', GioiTinh=N'" + gn + "', ChucVu=N'" + cv + "', LuongNhanVien='" + lnv + "' where MaNhanVien='" + id + "'", Conn)
        com.ExecuteNonQuery()
        Laydl()
        Conn.Close()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Conn.Open()
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim id As String = txtMaNhanVien.Text
            Dim com As New SqlCommand("delete NV where MaNhanVien='" + id + " ' ", Conn)
            com.ExecuteNonQuery()
            Laydl()
        End If
        Conn.Close()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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