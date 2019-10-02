Public Class frmMainLevel1
    Declare Function CreateIconIndirect Lib "user32.dll" (ByRef piconinfo As ICONINFO) As Integer

    Structure ICONINFO
        Dim fIcon As Integer
        Dim xHotspot As Integer
        Dim yHotspot As Integer
        Dim hbmMask As Integer
        Dim hbmColor As Integer
    End Structure


    Sub kembaliStart()
        Dim garisStart = panelStart.Location
        garisStart.Offset(50, 50)
        Cursor.Position = PointToScreen(garisStart)
    End Sub

    Sub finish()
        gerbangFinish.Location.Offset(0, 0)
        Cursor.Position = PointToScreen(gerbangFinish.Location)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        kembaliStart()
    End Sub

    Private Sub frmMainLevel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, panelStart.MouseDown
        Dim disable = MsgBox("Disabled!", MsgBoxStyle.OkOnly)
        If disable = Windows.Forms.DialogResult.OK Then
            kembaliStart()
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                Me.Hide()
                frmMenu.Show()
            Case Keys.F2
                frmAturan.Show()
            Case Keys.F3
                End
            Case e.Control And Keys.D
                Call finish()
        End Select
    End Sub

    Private Sub Panel1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.MouseEnter, Panel2.MouseEnter, Panel9.MouseEnter, Panel8.MouseEnter, Panel7.MouseEnter, Panel63.MouseEnter, Panel62.MouseEnter, Panel61.MouseEnter, Panel60.MouseEnter, Panel6.MouseEnter, Panel56.MouseEnter, Panel55.MouseEnter, Panel54.MouseEnter, Panel53.MouseEnter, Panel52.MouseEnter, Panel51.MouseEnter, Panel50.MouseEnter, Panel5.MouseEnter, Panel49.MouseEnter, Panel48.MouseEnter, Panel47.MouseEnter, Panel46.MouseEnter, Panel45.MouseEnter, Panel44.MouseEnter, Panel43.MouseEnter, Panel42.MouseEnter, Panel41.MouseEnter, Panel40.MouseEnter, Panel4.MouseEnter, Panel39.MouseEnter, Panel38.MouseEnter, Panel37.MouseEnter, Panel36.MouseEnter, Panel35.MouseEnter, Panel34.MouseEnter, Panel33.MouseEnter, Panel32.MouseEnter, Panel31.MouseEnter, Panel30.MouseEnter, Panel3.MouseEnter, Panel29.MouseEnter, Panel28.MouseEnter, Panel27.MouseEnter, Panel26.MouseEnter, Panel25.MouseEnter, Panel24.MouseEnter, Panel23.MouseEnter, Panel22.MouseEnter, Panel21.MouseEnter, Panel20.MouseEnter, Panel19.MouseEnter, Panel18.MouseEnter, Panel17.MouseEnter, Panel16.MouseEnter, Panel15.MouseEnter, Panel14.MouseEnter, Panel13.MouseEnter, Panel12.MouseEnter, Panel11.MouseEnter, Panel10.MouseEnter
        kembaliStart()
    End Sub

    Private Sub panelFinish_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles panelFinish.MouseEnter
        Me.Hide()
        frmMainLevel2.Show()
    End Sub
End Class
