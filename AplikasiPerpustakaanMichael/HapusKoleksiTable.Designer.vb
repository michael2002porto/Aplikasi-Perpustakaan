<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusKoleksiTable
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
        Me.LabelNamaKoleksi = New System.Windows.Forms.Label()
        Me.ButtonHapusKoleksi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelNamaKoleksi
        '
        Me.LabelNamaKoleksi.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelNamaKoleksi.AutoSize = True
        Me.LabelNamaKoleksi.Font = New System.Drawing.Font("Segoe UI", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelNamaKoleksi.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelNamaKoleksi.Location = New System.Drawing.Point(276, 200)
        Me.LabelNamaKoleksi.Name = "LabelNamaKoleksi"
        Me.LabelNamaKoleksi.Size = New System.Drawing.Size(261, 50)
        Me.LabelNamaKoleksi.TabIndex = 3
        Me.LabelNamaKoleksi.Text = "Nama Koleksi"
        Me.LabelNamaKoleksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonHapusKoleksi
        '
        Me.ButtonHapusKoleksi.Location = New System.Drawing.Point(323, 361)
        Me.ButtonHapusKoleksi.Name = "ButtonHapusKoleksi"
        Me.ButtonHapusKoleksi.Size = New System.Drawing.Size(150, 46)
        Me.ButtonHapusKoleksi.TabIndex = 5
        Me.ButtonHapusKoleksi.Text = "Hapus"
        Me.ButtonHapusKoleksi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(227, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Apakah ingin menghapus koleksi"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HapusKoleksiTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonHapusKoleksi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelNamaKoleksi)
        Me.Name = "HapusKoleksiTable"
        Me.Text = "HapusKoleksiTable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNamaKoleksi As Label
    Friend WithEvents ButtonHapusKoleksi As Button
    Friend WithEvents Label1 As Label
End Class
