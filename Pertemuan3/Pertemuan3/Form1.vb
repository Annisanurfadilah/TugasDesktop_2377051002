Public Class Form1

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        Dim Nama As String = TxtNama.Text
        MessageBox.Show("Hallo " + Nama, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblNPM.Click

    End Sub
End Class
