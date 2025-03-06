Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nama As String = TxtNama.Text
        Dim Jurusan As String = TxtJurusan.Text
        Dim Matkul As String = TxtMatkul.Text
        MessageBox.Show("Hallo " & Nama & vbCrLf &
                "Anda Mengambil Jurusan " & Jurusan & vbCrLf &
                "Matkul " & Matkul,
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

    End Sub
End Class