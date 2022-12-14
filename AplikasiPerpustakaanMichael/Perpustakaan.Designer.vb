<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Perpustakaan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBoxKoleksi = New System.Windows.Forms.ListBox()
        Me.ButtonTambahKoleksi = New System.Windows.Forms.Button()
        Me.ButtonHapusKoleksi = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxKoleksi
        '
        Me.ListBoxKoleksi.FormattingEnabled = True
        Me.ListBoxKoleksi.ItemHeight = 32
        Me.ListBoxKoleksi.Location = New System.Drawing.Point(12, 95)
        Me.ListBoxKoleksi.Name = "ListBoxKoleksi"
        Me.ListBoxKoleksi.Size = New System.Drawing.Size(776, 484)
        Me.ListBoxKoleksi.TabIndex = 0
        '
        'ButtonTambahKoleksi
        '
        Me.ButtonTambahKoleksi.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonTambahKoleksi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonTambahKoleksi.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonTambahKoleksi.Location = New System.Drawing.Point(12, 43)
        Me.ButtonTambahKoleksi.Name = "ButtonTambahKoleksi"
        Me.ButtonTambahKoleksi.Size = New System.Drawing.Size(46, 46)
        Me.ButtonTambahKoleksi.TabIndex = 1
        Me.ButtonTambahKoleksi.Text = "+"
        Me.ButtonTambahKoleksi.UseVisualStyleBackColor = False
        '
        'ButtonHapusKoleksi
        '
        Me.ButtonHapusKoleksi.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonHapusKoleksi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonHapusKoleksi.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonHapusKoleksi.Location = New System.Drawing.Point(64, 43)
        Me.ButtonHapusKoleksi.Name = "ButtonHapusKoleksi"
        Me.ButtonHapusKoleksi.Size = New System.Drawing.Size(46, 46)
        Me.ButtonHapusKoleksi.TabIndex = 2
        Me.ButtonHapusKoleksi.Text = "-"
        Me.ButtonHapusKoleksi.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem, Me.ArrayToolStripMenuItem, Me.CollectionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1958, 40)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(108, 36)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(311, 44)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'ArrayToolStripMenuItem
        '
        Me.ArrayToolStripMenuItem.Name = "ArrayToolStripMenuItem"
        Me.ArrayToolStripMenuItem.Size = New System.Drawing.Size(89, 36)
        Me.ArrayToolStripMenuItem.Text = "Array"
        '
        'CollectionsToolStripMenuItem
        '
        Me.CollectionsToolStripMenuItem.Name = "CollectionsToolStripMenuItem"
        Me.CollectionsToolStripMenuItem.Size = New System.Drawing.Size(151, 36)
        Me.CollectionsToolStripMenuItem.Text = "Collections"
        '
        'DataGridKoleksi
        '
        Me.DataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksi.Location = New System.Drawing.Point(881, 95)
        Me.DataGridKoleksi.Name = "DataGridKoleksi"
        Me.DataGridKoleksi.RowHeadersWidth = 82
        Me.DataGridKoleksi.RowTemplate.Height = 41
        Me.DataGridKoleksi.Size = New System.Drawing.Size(1065, 479)
        Me.DataGridKoleksi.TabIndex = 5
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(1640, 580)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(150, 46)
        Me.BtnSelect.TabIndex = 6
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(1796, 580)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(150, 46)
        Me.BtnRemove.TabIndex = 7
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(1484, 580)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(150, 46)
        Me.BtnUpdate.TabIndex = 8
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'Perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1958, 638)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.DataGridKoleksi)
        Me.Controls.Add(Me.ButtonHapusKoleksi)
        Me.Controls.Add(Me.ButtonTambahKoleksi)
        Me.Controls.Add(Me.ListBoxKoleksi)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Perpustakaan"
        Me.Text = "Perpustakaan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxKoleksi As ListBox
    Friend WithEvents ButtonTambahKoleksi As Button
    Friend WithEvents ButtonHapusKoleksi As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CollectionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridKoleksi As DataGridView
    Friend WithEvents BtnSelect As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents BtnUpdate As Button
End Class
