Public Class frmMenu

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMulai.Click
        Me.Hide()
        frmMainLevel1.Show()
    End Sub

    Private Sub btnAturan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAturan.Click
        frmAturan.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        judul.BackColor = Color.Transparent
        subjudul.BackColor = Color.Transparent
    End Sub
End Class