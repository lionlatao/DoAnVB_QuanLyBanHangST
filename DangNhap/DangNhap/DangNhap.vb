Imports System.Data.SqlClient
Public Class frmQLBHDD
    Dim conn As New SqlConnection
    Private Sub frmQLBHDD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Data Source=NguyenDucLong\NGUYENDUCLONG;Initial Catalog=QuanLyBanHang;Integrated Security=True")
        conn.Open()
    End Sub
    Private Sub btnDN_Click(sender As Object, e As EventArgs) Handles btnDN.Click
        Dim us As String = txtTK.Text
        Dim pa As String = txtMK.Text
        Dim da As New SqlDataAdapter("select * from DN where TaiKhoan='" + txtTK.Text + "' and MatKhau='" + txtMK.Text + "'", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            frmMain.Show()
            Me.Hide()
            conn.Close()
        Else
            MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub lnkQMK_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkQMK.LinkClicked
        ' Tạo một đối tượng mới của form Quên MK
        Dim formQMK As New frmQuenMK()

        ' Hiển thị form Quên MK
        formQMK.Show()

        Me.Hide()
    End Sub
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        End
    End Sub
End Class
