Imports System.Data.SqlClient
Public Class frmKhachHang
    Dim Conn As New SqlConnection
    Private Sub Laydl()
        Dim da As New SqlDataAdapter("select * from KH", Conn)
        Dim dt As New DataTable
        da.Fill(dt)
        dgvHTKH.DataSource = dt
        txtMKH.DataBindings.Clear()
        txtMKH.DataBindings.Add("Text", dt, "MaKhachHang")
        txtHo.DataBindings.Clear()
        txtHo.DataBindings.Add("Text", dt, "Ho")
        txtTen.DataBindings.Clear()
        txtTen.DataBindings.Add("Text", dt, "Ten")
        txtDC.DataBindings.Clear()
        txtDC.DataBindings.Add("Text", dt, "DiaChi")
        txtSDT.DataBindings.Clear()
        txtSDT.DataBindings.Add("Text", dt, "SoDienThoai")
        txt_Email.DataBindings.Clear()
        txt_Email.DataBindings.Add("Text", dt, "Email")
        txtGT.DataBindings.Clear()
        txtGT.DataBindings.Add("Text", dt, "GioiTinh")
        txtNS.DataBindings.Clear()
        txtNS.DataBindings.Add("Text", dt, "NgayThangNamSinh")
    End Sub

    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New SqlConnection("Data Source=NguyenDucLong\NGUYENDUCLONG;Initial Catalog=QuanLyBanHang;Integrated Security=True")
        Conn.Open()
        Laydl()
        Conn.Close()
    End Sub

    Private Sub btn_Them_Click(sender As Object, e As EventArgs) Handles btn_Them.Click
        Conn.Open()
        MessageBox.Show("Bạn đã thêm khách hàng mới !")
        Dim id As String = txtMKH.Text
        Dim ho As String = txtHo.Text
        Dim tn As String = txtTen.Text
        Dim dc As String = txtDC.Text
        Dim sdt As String = txtSDT.Text
        Dim email As String = txt_Email.Text
        Dim gt As String = txtGT.Text
        Dim ns As String = txtNS.Text
        Dim com As New SqlCommand("insert into KH values('" + id + "', N'" + ho + "',N'" + tn + "', N'" + dc + "', '" + sdt + "', '" + email + "', N'" + gt + "', '" + ns + "')", Conn)
        com.ExecuteNonQuery()
        Laydl()
        Conn.Close()
    End Sub

    Private Sub btn_Sua_Click(sender As Object, e As EventArgs) Handles btn_Sua.Click
        Conn.Open()
        MessageBox.Show("Cập nhật thành công !")
        Dim id As String = txtMKH.Text
        Dim ho As String = txtHo.Text
        Dim tn As String = txtTen.Text
        Dim dc As String = txtDC.Text
        Dim sdt As String = txtSDT.Text
        Dim email As String = txt_Email.Text
        Dim gt As String = txtGT.Text
        Dim ns As String = txtNS.Text
        Dim com As New SqlCommand("update KH set Ho=N'" + ho + "',Ten=N'" + tn + "', DiaChi=N'" + dc + "', SoDienThoai='" + sdt + "', Email='" + email + "', GioiTinh=N'" + gt + "',NgayThangNamSinh='" + ns + "' where MaKhachHang='" + id + "'", Conn)
        com.ExecuteNonQuery()
        Laydl()
        Conn.Close()
    End Sub

    Private Sub btn_Xoa_Click(sender As Object, e As EventArgs) Handles btn_Xoa.Click
        Conn.Open()
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim id As String = txtMKH.Text
            Dim com As New SqlCommand("delete KH where MaKhachHang='" + id + " ' ", Conn)
            com.ExecuteNonQuery()
            Laydl()
        End If
        Conn.Close()
    End Sub

    Private Sub btn_Thoat_Click(sender As Object, e As EventArgs) Handles btn_Thoat.Click
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