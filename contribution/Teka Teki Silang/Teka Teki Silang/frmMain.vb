Public Class frmMain
    Dim salah As Integer = 0
    Dim nama As String
    Dim predikat As String

    Sub jmlsalah()
        MsgBox("Jawaban Salah!")
        salah = salah + 1
    End Sub

    Sub terjawab()
        If per1_2.Text = "A" And per4_2.Text = "A" And per6_2.Text = "E" And per7_2.Text = "N" And per8_2.Text = "U" And per11_2.Text = "U" And per13_1.Text = "A" And per14_2.Text = "A" And per1a_2.Text = "A" And per2_2.Text = "E" And per3_2.Text = "A" And per4a_2.Text = "R" And per5_2.Text = "I" And per8a_2.Text = "U" And per9_2.Text = "U" And per10_2.Text = "O" And per11a_2.Text = "A" And per12_2.Text = "R" Then
            Timer1.Enabled = False
            MsgBox("Selamat " + nama + " kamu berhasil menyelesaikan TTS ini." & vbCrLf + "Predikat kamu '" + predikat + "' dengan kesalahan sebanyak " + CStr(salah) + " Kali")
            Me.Close()
            frmMenu.Show()
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nama = InputBox("Masukkan nama kamu ...")
        If nama = "" Or nama = " " Then
            MsgBox("Harap Masukkan Nama")
            Me.Close()
            frmMenu.Show()
        End If
    End Sub

    Private Sub listMendatar_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listMendatar.SelectedIndexChanged
        Dim box, jawab As String
        If listMendatar.SelectedIndex = 0 Then
            If per1_2.Text = "A" Then
                MsgBox("Sudah Terjawab")
                Return
            End If
            box = InputBox("Malaysia ...")
            jawab = (box.ToLower)
            If jawab = "malaka" And Windows.Forms.DialogResult.OK Then
                per1_1.Text = "M"
                per1_2.Text = "A"
                per1_3.Text = "L"
                per1_4.Text = "A"
                per1_5.Text = "K"
                per1_6.Text = "A"
            ElseIf box = "" Or box = " " Then
                Me.Show()
            ElseIf box <> "malaka" And Windows.Forms.DialogResult.OK Then
                Call jmlsalah()
            End If

        ElseIf listMendatar.SelectedIndex = 1 Then
            If per4_2.Text = "A" Then
                MsgBox("Sudah Terjawab")
                Return
            End If
            box = InputBox("Istilah dalam olahraga golf ...")
            jawab = box.ToLower
            If jawab = "par" And Windows.Forms.DialogResult.OK Then
                per4_1.Text = "P"
                per4_2.Text = "A"
                per4_3.Text = "R"
            ElseIf box = "" Or box = " " Then
                Me.Show()
            ElseIf box <> "par" And Windows.Forms.DialogResult.OK Then
                Call jmlsalah()
            End If

        ElseIf listMendatar.SelectedIndex = 2 Then
            If per6_2.Text = "E" Then
                MsgBox("Sudah Terjawab")
                Return
            End If
            box = InputBox("Jenis alat musik ...")
            jawab = box.ToLower
            If jawab = "rebana" And Windows.Forms.DialogResult.OK Then
                per6_1.Text = "R"
                per6_2.Text = "E"
                per6_3.Text = "B"
                per6_4.Text = "A"
                per6_5.Text = "N"
                per6_6.Text = "A"
            ElseIf box = "" Or box = " " Then
                Me.Show()
            ElseIf box <> "rebana" And Windows.Forms.DialogResult.OK Then
                Call jmlsalah()
            End If

        ElseIf listMendatar.SelectedIndex = 3 Then
            If per7_2.Text = "N" Then
                MsgBox("Sudah Terjawab")
                Return
            End If
            box = InputBox("Beragam jenis ...")
            jawab = box.ToLower
            If jawab = "aneka" And Windows.Forms.DialogResult.OK Then
                per7_1.Text = "A"
                per7_2.Text = "N"
                per7_3.Text = "E"
                per7_4.Text = "K"
                per7_5.Text = "A"
            ElseIf box = "" Or box = " " Then
                Me.Show()
            ElseIf box <> "aneka" And Windows.Forms.DialogResult.OK Then
                Call jmlsalah()
            End If

        ElseIf listMendatar.SelectedIndex = 4 Then
            If per8_2.Text = "U" Then
                MsgBox("Sudah Terjawab")
                Return
            End If
            box = InputBox("Pungutan Liar ...")
            jawab = box.ToLower
            If jawab = "pungli" And Windows.Forms.DialogResult.OK Then
                per8_1.Text = "P"
                per8_2.Text = "U"
                per8_3.Text = "N"
                per8_4.Text = "G"
                per8_5.Text = "L"
                per8_6.Text = "I"
            ElseIf box = "" Or box = " " Then
                Me.Show()
            ElseIf box <> "pungli" And Windows.Forms.DialogResult.OK Then
                Call jmlsalah()
            End If

        ElseIf listMendatar.SelectedIndex = 5 Then
            If per11_2.Text = "U" Then
                MsgBox("Sudah Terjawab")
                Return
            End If
            box = InputBox("Jumpa ...")
            jawab = box.ToLower
            If jawab = "sua" And Windows.Forms.DialogResult.OK Then
                per11_1.Text = "S"
                per11_2.Text = "U"
                per11_3.Text = "A"
            ElseIf box = "" Or box = " " Then
                Me.Show()
            ElseIf box <> "sua" And Windows.Forms.DialogResult.OK Then
                Call jmlsalah()
            End If

        ElseIf listMendatar.SelectedIndex = 6 Then
            If per13_1.Text = "A" Then
                MsgBox("Sudah Terjawab")
                Return
            End If
            box = InputBox("Pembenaran")
            jawab = box.ToLower
            If jawab = "alasan" And Windows.Forms.DialogResult.OK Then
                per13_1.Text = "A"
                per13_2.Text = "L"
                per13_3.Text = "A"
                per13_4.Text = "S"
                per13_5.Text = "A"
                per13_6.Text = "N"
            ElseIf box = "" Or box = " " Then
                Me.Show()
            ElseIf box <> "alasan" And Windows.Forms.DialogResult.OK Then
                Call jmlsalah()
            End If

        ElseIf listMendatar.SelectedIndex = 7 Then
            If per14_2.Text = "A" Then
                MsgBox("Sudah Terjawab")
                Return
            End If
            box = InputBox("Terkenal dengan dodolnya ...")
            jawab = box.ToLower
            If jawab = "garut" And Windows.Forms.DialogResult.OK Then
                per14_1.Text = "G"
                per14_2.Text = "A"
                per14_3.Text = "R"
                per14_4.Text = "U"
                per14_5.Text = "T"
            ElseIf box = "" Or box = " " Then
                Me.Show()
            ElseIf box <> "garut" And Windows.Forms.DialogResult.OK Then
                Call jmlsalah()
            End If
        End If
    End Sub

    Private Sub listMenurun_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listMenurun.SelectedIndexChanged
        Dim box, jawab As String
        If listMenurun.SelectedIndex = 0 Then
            If per1a_2.Text = "A" Then
                MsgBox("Sudah Terjawab")
                Return
            End If
            box = InputBox("Kebutuhan Makhluk hidup ...")
            jawab = (box.ToLower)
            If jawab = "makan" And Windows.Forms.DialogResult.OK Then
                per1_1.Text = "M"
                per1a_2.Text = "A"
                per1a_3.Text = "K"
                per7_1.Text = "A"
                per1a_5.Text = "N"
            ElseIf box = "" Or box = " " Then
                Me.Show()
            ElseIf box <> "makan" And Windows.Forms.DialogResult.OK Then
                Call jmlsalah()
            End If

        ElseIf listMenurun.SelectedIndex = 1 Then
            If per2_2.Text = "E" Then
                MsgBox("Sudah Terjawab")
                Return
            End If
            box = InputBox("Jenis ikan air tawar ...")
            jawab = (box.ToLower)
            If jawab = "lele" And Windows.Forms.DialogResult.OK Then
                per1_3.Text = "L"
                per2_2.Text = "E"
                per2_3.Text = "L"
                per7_3.Text = "E"
            ElseIf box = "" Or box = " " Then
                Me.Show()
            ElseIf box <> "lele" And Windows.Forms.DialogResult.OK Then
                Call jmlsalah()
            End If

        ElseIf listMenurun.SelectedIndex = 2 Then
            If per3_2.Text = "A" Then
                MsgBox("Sudah Terjawab")
                Return
            End If
            box = InputBox("Jenis tumbuhan yang hidup di laut ...")
            jawab = (box.ToLower)
            If jawab = "karang" And Windows.Forms.DialogResult.OK Then
                per1_5.Text = "K"
                per3_2.Text = "A"
                per6_1.Text = "R"
                per7_5.Text = "A"
                per3_5.Text = "N"
                per8_4.Text = "G"
            ElseIf box = "" Or box = " " Then
                Me.Show()
            ElseIf box <> "karang" And Windows.Forms.DialogResult.OK Then
                Call jmlsalah()
            End If

        ElseIf listMenurun.SelectedIndex = 3 Then
            If per4a_2.Text = "R" Then
                MsgBox("Sudah Terjawab")
                Return
            End If
            box = InputBox("Sebutan untuk raja di Jawa ...")
            jawab = (box.ToLower)
            If jawab = "prabu" And Windows.Forms.DialogResult.OK Then
                per4_1.Text = "P"
                per4a_2.Text = "R"
                per6_4.Text = "A"
                per4a_4.Text = "B"
                per4a_5.Text = "U"
            ElseIf box = "" Or box = " " Then
                Me.Show()
            ElseIf box <> "prabu" And Windows.Forms.DialogResult.OK Then
                Call jmlsalah()
            End If

        ElseIf listMenurun.SelectedIndex = 4 Then
            If per5_2.Text = "I" Then
                MsgBox("Sudah Terjawab")
                Return
            End If
            box = InputBox("Senang ...")
            jawab = (box.ToLower)
            If jawab = "riang" And Windows.Forms.DialogResult.OK Then
                per4_3.Text = "R"
                per5_2.Text = "I"
                per6_6.Text = "A"
                per5_4.Text = "N"
                per5_5.Text = "G"
            ElseIf box = "" Or box = " " Then
                Me.Show()
            ElseIf box <> "riang" And Windows.Forms.DialogResult.OK Then
                Call jmlsalah()
            End If

        ElseIf listMenurun.SelectedIndex = 5 Then
            If per8a_2.Text = "U" Then
                MsgBox("Sudah Terjawab")
                Return
            End If
            box = InputBox("Juga ...")
            jawab = (box.ToLower)
            If jawab = "pula" And Windows.Forms.DialogResult.OK Then
                per8_1.Text = "P"
                per8a_2.Text = "U"
                per13_2.Text = "L"
                per8a_4.Text = "A"
            ElseIf box = "" Or box = " " Then
                Me.Show()
            ElseIf box <> "pula" And Windows.Forms.DialogResult.OK Then
                Call jmlsalah()
            End If

        ElseIf listMenurun.SelectedIndex = 6 Then
            If per9_2.Text = "U" Then
                MsgBox("Sudah Terjawab")
                Return
            End If
            box = InputBox("Pulau ...")
            jawab = (box.ToLower)
            If jawab = "nusa" And Windows.Forms.DialogResult.OK Then
                per8_3.Text = "N"
                per9_2.Text = "U"
                per13_4.Text = "S"
                per9_4.Text = "A"
            ElseIf box = "" Or box = " " Then
                Me.Show()
            ElseIf box <> "" And Windows.Forms.DialogResult.OK Then
                Call jmlsalah()
            End If

        ElseIf listMenurun.SelectedIndex = 7 Then
            If per10_2.Text = "O" Then
                MsgBox("Sudah Terjawab")
                Return
            End If
            box = InputBox("Panjang (Inggris) ...")
            jawab = (box.ToLower)
            If jawab = "long" And Windows.Forms.DialogResult.OK Then
                per8_5.Text = "L"
                per10_2.Text = "O"
                per13_6.Text = "N"
                per14_1.Text = "G"
            ElseIf box = "" Or box = " " Then
                Me.Show()
            ElseIf box <> "long" And Windows.Forms.DialogResult.OK Then
                Call jmlsalah()
            End If

        ElseIf listMenurun.SelectedIndex = 8 Then
            If per11a_2.Text = "A" Then
                MsgBox("Sudah Terjawab")
                Return
            End If
            box = InputBox("Tim Penyelamat ...")
            jawab = (box.ToLower)
            If jawab = "sar" And Windows.Forms.DialogResult.OK Then
                per11_1.Text = "S"
                per11a_2.Text = "A"
                per14_3.Text = "R"
            ElseIf box = "" Or box = " " Then
                Me.Show()
            ElseIf box <> "sar" And Windows.Forms.DialogResult.OK Then
                Call jmlsalah()
            End If

        ElseIf listMenurun.SelectedIndex = 9 Then
            If per12_2.Text = "R" Then
                MsgBox("Sudah Terjawab")
                Return
            End If
            box = InputBox("Seni (Inggris) ...")
            jawab = (box.ToLower)
            If jawab = "art" And Windows.Forms.DialogResult.OK Then
                per11_3.Text = "A"
                per12_2.Text = "R"
                per14_5.Text = "T"
            ElseIf box = "" Or box = " " Then
                Me.Show()
            ElseIf box <> "art" And Windows.Forms.DialogResult.OK Then
                Call jmlsalah()
            End If
        End If
    End Sub

    Private Sub KeluarPermainanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarPermainanToolStripMenuItem.Click
        End
    End Sub

    Private Sub MenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuToolStripMenuItem.Click
        Me.Close()
        frmMenu.Show()
    End Sub
End Class