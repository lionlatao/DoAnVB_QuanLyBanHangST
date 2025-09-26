Imports System.Data.SqlClient
Imports System.Net.NetworkInformation

Public Class frmSanPham
    Dim Conn As New SqlConnection
    Private Sub Laydl()
        Dim da As New SqlDataAdapter("select * from SP", Conn)
        Dim dt As New DataTable
        da.Fill(dt)
        txtMSP.DataBindings.Clear()
        txtMSP.DataBindings.Add("Text", dt, "MaSanPham")
        txtTSP.DataBindings.Clear()
        txtTSP.DataBindings.Add("Text", dt, "TenSanPham")
        txtLSP.DataBindings.Clear()
        txtLSP.DataBindings.Add("Text", dt, "LoaiSanPham")
        txtGT.DataBindings.Clear()
        txtGT.DataBindings.Add("Text", dt, "GiaTien")
        txtSLCP.DataBindings.Clear()
        txtSLCP.DataBindings.Add("Text", dt, "SoLuongCoPhieu")
        dgv_HTSP.DataSource = dt


    End Sub
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New SqlConnection("Data Source=NguyenDucLong\NGUYENDUCLONG;Initial Catalog=QuanLyBanHang;Integrated Security=True")
        Conn.Open()
        Laydl()
        Conn.Close()
    End Sub
    Private Sub btn_Them_Click(sender As Object, e As EventArgs) Handles btn_Them.Click
        Conn.Open()
        MessageBox.Show("Thêm sản phẩm này thành công !")
        Dim id As String = txtMSP.Text
        Dim ten As String = txtTSP.Text
        Dim li As String = txtLSP.Text
        Dim gt As String = txtGT.Text
        Dim slcp As String = txtSLCP.Text
        Dim com As New SqlCommand("insert into SP values('" + id + "', N'" + ten + "',N'" + li + "', N'" + gt + "', '" + slcp + "')", Conn)
        com.ExecuteNonQuery()
        Laydl()
        Conn.Close()
    End Sub

    Private Sub btn_Sua_Click(sender As Object, e As EventArgs) Handles btn_Sua.Click
        Conn.Open()
        MessageBox.Show("Cập nhật thành công !")
        Dim id As String = txtMSP.Text
        Dim ten As String = txtTSP.Text
        Dim li As String = txtLSP.Text
        Dim gt As String = txtGT.Text
        Dim slcp As String = txtSLCP.Text
        Dim com As New SqlCommand("update SP set TenSanPham=N'" + ten + "',LoaiSanPham=N'" + li + "', GiaTien='" + gt + "', SoLuongCoPhieu='" + slcp + "' where MaSanPham='" + id + "'", Conn)
        com.ExecuteNonQuery()
        Laydl()
        Conn.Close()
    End Sub

    Private Sub btn_Xoa_Click(sender As Object, e As EventArgs) Handles btn_Xoa.Click
        Conn.Open()
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.Yes Then
            Dim id As String = txtMSP.Text
            Dim com As New SqlCommand("delete SP where MaSanPham='" + id + "'", Conn)
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