<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.LblNPM = New System.Windows.Forms.Label()
        Me.LblJurusan = New System.Windows.Forms.Label()
        Me.TxtNPM = New System.Windows.Forms.TextBox()
        Me.TxtJurusan = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LblMK = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(28, 26)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(35, 13)
        Me.LblNama.TabIndex = 0
        Me.LblNama.Text = "Nama"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(87, 23)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(100, 20)
        Me.TxtNama.TabIndex = 1
        '
        'BtnProses
        '
        Me.BtnProses.Location = New System.Drawing.Point(12, 151)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(75, 23)
        Me.BtnProses.TabIndex = 2
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'LblNPM
        '
        Me.LblNPM.AutoSize = True
        Me.LblNPM.Location = New System.Drawing.Point(32, 59)
        Me.LblNPM.Name = "LblNPM"
        Me.LblNPM.Size = New System.Drawing.Size(31, 13)
        Me.LblNPM.TabIndex = 3
        Me.LblNPM.Text = "NPM"
        '
        'LblJurusan
        '
        Me.LblJurusan.AutoSize = True
        Me.LblJurusan.Location = New System.Drawing.Point(28, 85)
        Me.LblJurusan.Name = "LblJurusan"
        Me.LblJurusan.Size = New System.Drawing.Size(44, 13)
        Me.LblJurusan.TabIndex = 4
        Me.LblJurusan.Text = "Jurusan"
        '
        'TxtNPM
        '
        Me.TxtNPM.Location = New System.Drawing.Point(87, 52)
        Me.TxtNPM.Name = "TxtNPM"
        Me.TxtNPM.Size = New System.Drawing.Size(100, 20)
        Me.TxtNPM.TabIndex = 5
        '
        'TxtJurusan
        '
        Me.TxtJurusan.Location = New System.Drawing.Point(87, 78)
        Me.TxtJurusan.Name = "TxtJurusan"
        Me.TxtJurusan.Size = New System.Drawing.Size(100, 20)
        Me.TxtJurusan.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(87, 114)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 7
        '
        'LblMK
        '
        Me.LblMK.AutoSize = True
        Me.LblMK.Location = New System.Drawing.Point(32, 117)
        Me.LblMK.Name = "LblMK"
        Me.LblMK.Size = New System.Drawing.Size(23, 13)
        Me.LblMK.TabIndex = 8
        Me.LblMK.Text = "MK"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.LblMK)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TxtJurusan)
        Me.Controls.Add(Me.TxtNPM)
        Me.Controls.Add(Me.LblJurusan)
        Me.Controls.Add(Me.LblNPM)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.LblNama)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNama As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents BtnProses As System.Windows.Forms.Button
    Friend WithEvents LblNPM As System.Windows.Forms.Label
    Friend WithEvents LblJurusan As System.Windows.Forms.Label
    Friend WithEvents TxtNPM As System.Windows.Forms.TextBox
    Friend WithEvents TxtJurusan As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LblMK As System.Windows.Forms.Label

End Class
