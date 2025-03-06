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
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.Label()
        Me.txtFakultas = New System.Windows.Forms.Label()
        Me.txtJurusan = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.cmbFakultas = New System.Windows.Forms.ComboBox()
        Me.cmbJurusan = New System.Windows.Forms.ComboBox()
        Me.txtNpm = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(25, 22)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(31, 13)
        Me.lblNama.TabIndex = 0
        Me.lblNama.Text = "NPM"
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Location = New System.Drawing.Point(25, 53)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(35, 13)
        Me.Nama.TabIndex = 2
        Me.Nama.Text = "Nama"
        '
        'txtFakultas
        '
        Me.txtFakultas.AutoSize = True
        Me.txtFakultas.Location = New System.Drawing.Point(25, 88)
        Me.txtFakultas.Name = "txtFakultas"
        Me.txtFakultas.Size = New System.Drawing.Size(47, 13)
        Me.txtFakultas.TabIndex = 3
        Me.txtFakultas.Text = "Fakultas"
        '
        'txtJurusan
        '
        Me.txtJurusan.AutoSize = True
        Me.txtJurusan.Location = New System.Drawing.Point(25, 119)
        Me.txtJurusan.Name = "txtJurusan"
        Me.txtJurusan.Size = New System.Drawing.Size(44, 13)
        Me.txtJurusan.TabIndex = 4
        Me.txtJurusan.Text = "Jurusan"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(12, 147)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Process"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'cmbFakultas
        '
        Me.cmbFakultas.FormattingEnabled = True
        Me.cmbFakultas.Location = New System.Drawing.Point(117, 80)
        Me.cmbFakultas.Name = "cmbFakultas"
        Me.cmbFakultas.Size = New System.Drawing.Size(121, 21)
        Me.cmbFakultas.TabIndex = 9
        '
        'cmbJurusan
        '
        Me.cmbJurusan.FormattingEnabled = True
        Me.cmbJurusan.Location = New System.Drawing.Point(117, 111)
        Me.cmbJurusan.Name = "cmbJurusan"
        Me.cmbJurusan.Size = New System.Drawing.Size(121, 21)
        Me.cmbJurusan.TabIndex = 10
        '
        'txtNpm
        '
        Me.txtNpm.Location = New System.Drawing.Point(117, 22)
        Me.txtNpm.Name = "txtNpm"
        Me.txtNpm.Size = New System.Drawing.Size(100, 20)
        Me.txtNpm.TabIndex = 11
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(117, 53)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(100, 20)
        Me.txtNama.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNpm)
        Me.Controls.Add(Me.cmbJurusan)
        Me.Controls.Add(Me.cmbFakultas)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtJurusan)
        Me.Controls.Add(Me.txtFakultas)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.lblNama)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents Nama As System.Windows.Forms.Label
    Friend WithEvents txtFakultas As System.Windows.Forms.Label
    Friend WithEvents txtJurusan As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents cmbFakultas As System.Windows.Forms.ComboBox
    Friend WithEvents cmbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents txtNpm As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox

End Class
