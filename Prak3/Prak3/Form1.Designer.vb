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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtHasil = New System.Windows.Forms.TextBox()
        Me.rbKurang = New System.Windows.Forms.RadioButton()
        Me.rbTambah = New System.Windows.Forms.RadioButton()
        Me.rbBagi = New System.Windows.Forms.RadioButton()
        Me.rbKali = New System.Windows.Forms.RadioButton()
        Me.txtNilai2 = New System.Windows.Forms.TextBox()
        Me.txtNilai1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnHitung)
        Me.Panel1.Controls.Add(Me.txtHasil)
        Me.Panel1.Controls.Add(Me.rbKurang)
        Me.Panel1.Controls.Add(Me.rbTambah)
        Me.Panel1.Controls.Add(Me.rbBagi)
        Me.Panel1.Controls.Add(Me.rbKali)
        Me.Panel1.Controls.Add(Me.txtNilai2)
        Me.Panel1.Controls.Add(Me.txtNilai1)
        Me.Panel1.Location = New System.Drawing.Point(12, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 248)
        Me.Panel1.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(69, 208)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(128, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(69, 129)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(128, 23)
        Me.btnHitung.TabIndex = 1
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'txtHasil
        '
        Me.txtHasil.Location = New System.Drawing.Point(12, 173)
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(244, 20)
        Me.txtHasil.TabIndex = 6
        '
        'rbKurang
        '
        Me.rbKurang.AutoSize = True
        Me.rbKurang.Location = New System.Drawing.Point(198, 55)
        Me.rbKurang.Name = "rbKurang"
        Me.rbKurang.Size = New System.Drawing.Size(28, 17)
        Me.rbKurang.TabIndex = 5
        Me.rbKurang.TabStop = True
        Me.rbKurang.Text = "-"
        Me.rbKurang.UseVisualStyleBackColor = True
        '
        'rbTambah
        '
        Me.rbTambah.AutoSize = True
        Me.rbTambah.Location = New System.Drawing.Point(143, 55)
        Me.rbTambah.Name = "rbTambah"
        Me.rbTambah.Size = New System.Drawing.Size(31, 17)
        Me.rbTambah.TabIndex = 4
        Me.rbTambah.TabStop = True
        Me.rbTambah.Text = "+"
        Me.rbTambah.UseVisualStyleBackColor = True
        '
        'rbBagi
        '
        Me.rbBagi.AutoSize = True
        Me.rbBagi.Location = New System.Drawing.Point(84, 55)
        Me.rbBagi.Name = "rbBagi"
        Me.rbBagi.Size = New System.Drawing.Size(30, 17)
        Me.rbBagi.TabIndex = 3
        Me.rbBagi.TabStop = True
        Me.rbBagi.Text = "/"
        Me.rbBagi.UseVisualStyleBackColor = True
        '
        'rbKali
        '
        Me.rbKali.AutoSize = True
        Me.rbKali.Location = New System.Drawing.Point(30, 55)
        Me.rbKali.Name = "rbKali"
        Me.rbKali.Size = New System.Drawing.Size(32, 17)
        Me.rbKali.TabIndex = 2
        Me.rbKali.TabStop = True
        Me.rbKali.Text = "X"
        Me.rbKali.UseVisualStyleBackColor = True
        '
        'txtNilai2
        '
        Me.txtNilai2.Location = New System.Drawing.Point(12, 90)
        Me.txtNilai2.Name = "txtNilai2"
        Me.txtNilai2.Size = New System.Drawing.Size(244, 20)
        Me.txtNilai2.TabIndex = 1
        '
        'txtNilai1
        '
        Me.txtNilai1.Location = New System.Drawing.Point(12, 17)
        Me.txtNilai1.Name = "txtNilai1"
        Me.txtNilai1.Size = New System.Drawing.Size(244, 20)
        Me.txtNilai1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 308)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbKurang As System.Windows.Forms.RadioButton
    Friend WithEvents rbTambah As System.Windows.Forms.RadioButton
    Friend WithEvents rbBagi As System.Windows.Forms.RadioButton
    Friend WithEvents rbKali As System.Windows.Forms.RadioButton
    Friend WithEvents txtNilai2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNilai1 As System.Windows.Forms.TextBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents txtHasil As System.Windows.Forms.TextBox

End Class
