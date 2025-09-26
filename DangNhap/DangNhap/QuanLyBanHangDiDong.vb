Imports System.Windows

Public Class frmMain
    Private Sub btnDSSP_Click(sender As Object, e As EventArgs) Handles btnDSSP.Click
        Dim newForm As New frmSanPham()
        newForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnDSNV_Click(sender As Object, e As EventArgs) Handles btnDSNV.Click
        Dim newForm As New frmNV()
        newForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnDSKH_Click(sender As Object, e As EventArgs) Handles btnDSKH.Click
        Dim newForm As New frmKhachHang()
        newForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnDSGH_Click(sender As Object, e As EventArgs) Handles btnDSGH.Click
        Dim newForm As New frmGioHang()
        newForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnHoaDon_Click(sender As Object, e As EventArgs) Handles btnHoaDon.Click
        Dim newForm As New frmHoaDon()
        newForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnQL_Click(sender As Object, e As EventArgs) Handles btnQL.Click
        Dim newForm As New frmQLBHDD()
        newForm.Show()
        Me.Hide()
    End Sub
End Class