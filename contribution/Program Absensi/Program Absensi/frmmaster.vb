Public Class frmmaster

    Private Sub AbsenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuabsen.Click
        frmabsen.Show()
    End Sub

    Private Sub HistoryAbsenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuhistory.Click
        frmlistabsen.Show()
    End Sub

    Private Sub HapusSiswaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menutambah.Click
        frminsert.Show()
    End Sub

    Private Sub HapusSiswaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuhapus.Click
        frmhapus.Show()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menulogin.Click
        frmlogin.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If idlog = 0 Then
            menulogout.Enabled = False
            menuabsen.Visible = False
            menuhistory.Visible = False
            menuhapus.Visible = False
            menutambah.Visible = False
            menutambahuser.Visible = False
        Else
            If lvl = "SU" Then
                menulogin.Enabled = False
                menulogout.Enabled = True
                menuabsen.Visible = True
                menuhistory.Visible = True
                menuhapus.Visible = True
                menutambah.Visible = True
                menutambahuser.Visible = True
            Else
                menulogin.Enabled = False
                menulogout.Enabled = True
                menuabsen.Visible = True
                menuhistory.Visible = True
                menuhapus.Visible = True
                menutambah.Visible = True
            End If
        End If
    End Sub

    Private Sub frmmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub menulogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menulogout.Click
        idlog = 0
        menulogin.Enabled = True
    End Sub

    Private Sub menutambahuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menutambahuser.Click
        frmtambah.Show()
    End Sub
End Class