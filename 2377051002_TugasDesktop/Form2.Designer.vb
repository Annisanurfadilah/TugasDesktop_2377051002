<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnProses = New System.Windows.Forms.Button()
        Me.lblJenisKelamin = New System.Windows.Forms.Label()
        Me.rbP = New System.Windows.Forms.RadioButton()
        Me.rbL = New System.Windows.Forms.RadioButton()
        Me.cbJurusan = New System.Windows.Forms.ComboBox()
        Me.cbFakultas = New System.Windows.Forms.ComboBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.lblJurusan = New System.Windows.Forms.Label()
        Me.lblFakultas = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblNIP = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(31, 319)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(112, 31)
        Me.btnProses.TabIndex = 23
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'lblJenisKelamin
        '
        Me.lblJenisKelamin.AutoSize = True
        Me.lblJenisKelamin.Location = New System.Drawing.Point(27, 138)
        Me.lblJenisKelamin.Name = "lblJenisKelamin"
        Me.lblJenisKelamin.Size = New System.Drawing.Size(106, 20)
        Me.lblJenisKelamin.TabIndex = 22
        Me.lblJenisKelamin.Text = "Jenis Kelamin"
        '
        'rbP
        '
        Me.rbP.AutoSize = True
        Me.rbP.Location = New System.Drawing.Point(284, 134)
        Me.rbP.Name = "rbP"
        Me.rbP.Size = New System.Drawing.Size(116, 24)
        Me.rbP.TabIndex = 21
        Me.rbP.TabStop = True
        Me.rbP.Text = "Perempuan"
        Me.rbP.UseVisualStyleBackColor = True
        '
        'rbL
        '
        Me.rbL.AutoSize = True
        Me.rbL.Location = New System.Drawing.Point(151, 134)
        Me.rbL.Name = "rbL"
        Me.rbL.Size = New System.Drawing.Size(97, 24)
        Me.rbL.TabIndex = 20
        Me.rbL.TabStop = True
        Me.rbL.Text = "Laki-Laki"
        Me.rbL.UseVisualStyleBackColor = True
        '
        'cbJurusan
        '
        Me.cbJurusan.FormattingEnabled = True
        Me.cbJurusan.Items.AddRange(New Object() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
        Me.cbJurusan.Location = New System.Drawing.Point(151, 255)
        Me.cbJurusan.Name = "cbJurusan"
        Me.cbJurusan.Size = New System.Drawing.Size(295, 28)
        Me.cbJurusan.TabIndex = 19
        '
        'cbFakultas
        '
        Me.cbFakultas.FormattingEnabled = True
        Me.cbFakultas.Items.AddRange(New Object() {"FMIPA", "FEB", "FKIP"})
        Me.cbFakultas.Location = New System.Drawing.Point(151, 189)
        Me.cbFakultas.Name = "cbFakultas"
        Me.cbFakultas.Size = New System.Drawing.Size(295, 28)
        Me.cbFakultas.TabIndex = 18
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(151, 76)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(295, 26)
        Me.txtNama.TabIndex = 17
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(151, 19)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(295, 26)
        Me.txtNIP.TabIndex = 16
        '
        'lblJurusan
        '
        Me.lblJurusan.AutoSize = True
        Me.lblJurusan.Location = New System.Drawing.Point(27, 255)
        Me.lblJurusan.Name = "lblJurusan"
        Me.lblJurusan.Size = New System.Drawing.Size(66, 20)
        Me.lblJurusan.TabIndex = 15
        Me.lblJurusan.Text = "Jurusan"
        '
        'lblFakultas
        '
        Me.lblFakultas.AutoSize = True
        Me.lblFakultas.Location = New System.Drawing.Point(27, 197)
        Me.lblFakultas.Name = "lblFakultas"
        Me.lblFakultas.Size = New System.Drawing.Size(70, 20)
        Me.lblFakultas.TabIndex = 14
        Me.lblFakultas.Text = "Fakultas"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(27, 82)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(51, 20)
        Me.lblNama.TabIndex = 13
        Me.lblNama.Text = "Nama"
        '
        'lblNIP
        '
        Me.lblNIP.AutoSize = True
        Me.lblNIP.Location = New System.Drawing.Point(27, 22)
        Me.lblNIP.Name = "lblNIP"
        Me.lblNIP.Size = New System.Drawing.Size(35, 20)
        Me.lblNIP.TabIndex = 12
        Me.lblNIP.Text = "NIP"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 383)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.lblJenisKelamin)
        Me.Controls.Add(Me.rbP)
        Me.Controls.Add(Me.rbL)
        Me.Controls.Add(Me.cbJurusan)
        Me.Controls.Add(Me.cbFakultas)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNIP)
        Me.Controls.Add(Me.lblJurusan)
        Me.Controls.Add(Me.lblFakultas)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblNIP)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents lblJenisKelamin As System.Windows.Forms.Label
    Friend WithEvents rbP As System.Windows.Forms.RadioButton
    Friend WithEvents rbL As System.Windows.Forms.RadioButton
    Friend WithEvents cbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents cbFakultas As System.Windows.Forms.ComboBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtNIP As System.Windows.Forms.TextBox
    Friend WithEvents lblJurusan As System.Windows.Forms.Label
    Friend WithEvents lblFakultas As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblNIP As System.Windows.Forms.Label
End Class
