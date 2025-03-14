﻿Public Class Form1

    Private Sub rdKali_CheckedChanged(sender As Object, e As EventArgs) Handles rbKali.CheckedChanged

    End Sub

    Private Sub txtNilai1_TextChanged(sender As Object, e As EventArgs) Handles txtNilai1.TextChanged

    End Sub

    Private Sub txtNilai1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
        End If
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNilai2_TextChanged(sender As Object, e As EventArgs) Handles txtNilai2.TextChanged
        If Asc(e.KeyChar) <> 8 Then
        End If
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

        End If
        e.Handled = True
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim nilai1 As Integer = CInt(txtNilai1.Text)
        Dim nilai2 As Integer = CInt(txtNilai2.Text)
        Dim hasil As Integer

        If (rbKali.Checked) Then
            hasil = nilai1 * nilai2
        ElseIf (rbBagi.Checked) Then
            hasil = nilai1 / nilai2
        ElseIf (rbTambah.Checked) Then
            hasil = nilai1 + nilai2
        ElseIf (rbKurang.Checked) Then
            hasil = nilai1 - nilai2
        End If
        txtHasil.Text = hasil
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtNilai1.Text = ""
        txtNilai2.Text = ""
        rbKali.Checked = False
        rbBagi.Checked = False
        rbTambah.Checked = False
        rbKurang.Checked = False
        txtHasil.Text = ""
        txtNilai1.Focus()
    End Sub
End Class