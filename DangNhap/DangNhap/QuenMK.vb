Imports System.Data.SqlClient
Public Class frmQuenMK
    Dim conn As New SqlConnection
    Private Sub frmQuenMK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Data Source=NguyenDucLong\NGUYENDUCLONG;Initial Catalog=QuanLyBanHang;Integrated Security=True")
        conn.Open()
    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Lấy giá trị mật khẩu mới từ TextBox
        Dim newPassword As String = txtMKM.Text
        Dim user As String = txtTK.Text
        ' Kiểm tra xem mật khẩu mới có hợp lệ không (ví dụ: đủ độ dài, chứa ký tự đặc biệt, v.v.)
        If Not IsPasswordValid(newPassword) Then
            MessageBox.Show("Mật khẩu mới không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Kết nối tới cơ sở dữ liệu
        Dim connectionString As String = "Data Source=NguyenDucLong\NGUYENDUCLONG;Initial Catalog=QuanLyBanHang;Integrated Security=True;User ID=TaiKhoan;Password=MatKhau;"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Cập nhật mật khẩu trong cơ sở dữ liệu
            Dim query As String = "UPDATE DN SET MatKhau = @newPassword WHERE TaiKhoan = @user"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@newPassword", newPassword)
                command.Parameters.AddWithValue("@user", user)

                command.ExecuteNonQuery()
            End Using
        End Using

        ' Hiển thị thông báo thành công
        MessageBox.Show("Mật khẩu đã được cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Xóa nội dung TextBox sau khi cập nhật thành công
        txtMKM.Text = ""
    End Sub
    Private Function IsPasswordValid(password As String) As Boolean
        ' Kiểm tra điều kiện mật khẩu hợp lệ tại đây
        ' Ví dụ: đủ độ dài, chứa ký tự đặc biệt, v.v.
        ' Trả về True nếu hợp lệ, False nếu không hợp lệ
        Return password.Length >= 6
    End Function
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim frmQuenMK As New frmQLBHDD()
        frmQuenMK.Show()
        Me.Hide()
    End Sub
End Class