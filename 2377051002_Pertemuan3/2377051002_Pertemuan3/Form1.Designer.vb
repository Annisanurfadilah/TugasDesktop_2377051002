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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtJurusan = New System.Windows.Forms.TextBox()
        Me.LblJurusan = New System.Windows.Forms.Label()
        Me.TxtMatkul = New System.Windows.Forms.TextBox()
        Me.LblMatkul = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(27, 43)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(35, 13)
        Me.LblNama.TabIndex = 0
        Me.LblNama.Text = "Nama"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(100, 43)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(100, 20)
        Me.TxtNama.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Proses"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtJurusan
        '
        Me.TxtJurusan.Location = New System.Drawing.Point(100, 87)
        Me.TxtJurusan.Name = "TxtJurusan"
        Me.TxtJurusan.Size = New System.Drawing.Size(100, 20)
        Me.TxtJurusan.TabIndex = 6
        '
        'LblJurusan
        '
        Me.LblJurusan.AutoSize = True
        Me.LblJurusan.Location = New System.Drawing.Point(22, 87)
        Me.LblJurusan.Name = "LblJurusan"
        Me.LblJurusan.Size = New System.Drawing.Size(44, 13)
        Me.LblJurusan.TabIndex = 5
        Me.LblJurusan.Text = "Jurusan"
        '
        'TxtMatkul
        '
        Me.TxtMatkul.Location = New System.Drawing.Point(100, 132)
        Me.TxtMatkul.Name = "TxtMatkul"
        Me.TxtMatkul.Size = New System.Drawing.Size(100, 20)
        Me.TxtMatkul.TabIndex = 8
        '
        'LblMatkul
        '
        Me.LblMatkul.AutoSize = True
        Me.LblMatkul.Location = New System.Drawing.Point(27, 132)
        Me.LblMatkul.Name = "LblMatkul"
        Me.LblMatkul.Size = New System.Drawing.Size(39, 13)
        Me.LblMatkul.TabIndex = 7
        Me.LblMatkul.Text = "Matkul"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TxtMatkul)
        Me.Controls.Add(Me.LblMatkul)
        Me.Controls.Add(Me.TxtJurusan)
        Me.Controls.Add(Me.LblJurusan)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.LblNama)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNama As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtJurusan As System.Windows.Forms.TextBox
    Friend WithEvents LblJurusan As System.Windows.Forms.Label
    Friend WithEvents TxtMatkul As System.Windows.Forms.TextBox
    Friend WithEvents LblMatkul As System.Windows.Forms.Label

End Class
