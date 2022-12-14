<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateKoleksi
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
        Me.OpenImageKoleksi = New System.Windows.Forms.OpenFileDialog()
        Me.CheckBoxBudaya = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTeknologi = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSosial = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSains = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonBhsIngg = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonBhsIndo = New System.Windows.Forms.RadioButton()
        Me.ButtonUpdateKoleksi = New System.Windows.Forms.Button()
        Me.TextBoxStock = New System.Windows.Forms.TextBox()
        Me.DateTimePickerTglMasukKoleksi = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxLokasiRak = New System.Windows.Forms.TextBox()
        Me.TextBoxTahunTerbit = New System.Windows.Forms.TextBox()
        Me.TextBoxPenerbit = New System.Windows.Forms.TextBox()
        Me.RichTextBoxDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.ComboBoxJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnUpdateGambar = New System.Windows.Forms.Button()
        Me.PictureBoxKoleksi = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNamaKoleksi = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenImageKoleksi
        '
        Me.OpenImageKoleksi.FileName = "OpenFileDialog1"
        '
        'CheckBoxBudaya
        '
        Me.CheckBoxBudaya.AutoSize = True
        Me.CheckBoxBudaya.Location = New System.Drawing.Point(6, 164)
        Me.CheckBoxBudaya.Name = "CheckBoxBudaya"
        Me.CheckBoxBudaya.Size = New System.Drawing.Size(124, 36)
        Me.CheckBoxBudaya.TabIndex = 27
        Me.CheckBoxBudaya.Text = "Budaya"
        Me.CheckBoxBudaya.UseVisualStyleBackColor = True
        '
        'CheckBoxTeknologi
        '
        Me.CheckBoxTeknologi.AutoSize = True
        Me.CheckBoxTeknologi.Location = New System.Drawing.Point(6, 122)
        Me.CheckBoxTeknologi.Name = "CheckBoxTeknologi"
        Me.CheckBoxTeknologi.Size = New System.Drawing.Size(150, 36)
        Me.CheckBoxTeknologi.TabIndex = 26
        Me.CheckBoxTeknologi.Text = "Teknologi"
        Me.CheckBoxTeknologi.UseVisualStyleBackColor = True
        '
        'CheckBoxSosial
        '
        Me.CheckBoxSosial.AutoSize = True
        Me.CheckBoxSosial.Location = New System.Drawing.Point(6, 80)
        Me.CheckBoxSosial.Name = "CheckBoxSosial"
        Me.CheckBoxSosial.Size = New System.Drawing.Size(107, 36)
        Me.CheckBoxSosial.TabIndex = 25
        Me.CheckBoxSosial.Text = "Sosial"
        Me.CheckBoxSosial.UseVisualStyleBackColor = True
        '
        'CheckBoxSains
        '
        Me.CheckBoxSains.AutoSize = True
        Me.CheckBoxSains.Location = New System.Drawing.Point(6, 38)
        Me.CheckBoxSains.Name = "CheckBoxSains"
        Me.CheckBoxSains.Size = New System.Drawing.Size(101, 36)
        Me.CheckBoxSains.TabIndex = 24
        Me.CheckBoxSains.Text = "Sains"
        Me.CheckBoxSains.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBoxBudaya)
        Me.GroupBox2.Controls.Add(Me.CheckBoxTeknologi)
        Me.GroupBox2.Controls.Add(Me.CheckBoxSosial)
        Me.GroupBox2.Controls.Add(Me.CheckBoxSains)
        Me.GroupBox2.Location = New System.Drawing.Point(574, 941)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(390, 203)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kategori"
        '
        'RadioButtonBhsIngg
        '
        Me.RadioButtonBhsIngg.AutoSize = True
        Me.RadioButtonBhsIngg.Location = New System.Drawing.Point(6, 80)
        Me.RadioButtonBhsIngg.Name = "RadioButtonBhsIngg"
        Me.RadioButtonBhsIngg.Size = New System.Drawing.Size(198, 36)
        Me.RadioButtonBhsIngg.TabIndex = 22
        Me.RadioButtonBhsIngg.TabStop = True
        Me.RadioButtonBhsIngg.Text = "Bahasa Inggris"
        Me.RadioButtonBhsIngg.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonBhsIngg)
        Me.GroupBox1.Controls.Add(Me.RadioButtonBhsIndo)
        Me.GroupBox1.Location = New System.Drawing.Point(574, 801)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 125)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'RadioButtonBhsIndo
        '
        Me.RadioButtonBhsIndo.AutoSize = True
        Me.RadioButtonBhsIndo.Location = New System.Drawing.Point(6, 38)
        Me.RadioButtonBhsIndo.Name = "RadioButtonBhsIndo"
        Me.RadioButtonBhsIndo.Size = New System.Drawing.Size(229, 36)
        Me.RadioButtonBhsIndo.TabIndex = 21
        Me.RadioButtonBhsIndo.TabStop = True
        Me.RadioButtonBhsIndo.Text = "Bahasa Indonesia"
        Me.RadioButtonBhsIndo.UseVisualStyleBackColor = True
        '
        'ButtonUpdateKoleksi
        '
        Me.ButtonUpdateKoleksi.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonUpdateKoleksi.Location = New System.Drawing.Point(435, 1176)
        Me.ButtonUpdateKoleksi.Name = "ButtonUpdateKoleksi"
        Me.ButtonUpdateKoleksi.Size = New System.Drawing.Size(200, 46)
        Me.ButtonUpdateKoleksi.TabIndex = 48
        Me.ButtonUpdateKoleksi.Text = "Update Koleksi"
        Me.ButtonUpdateKoleksi.UseVisualStyleBackColor = True
        '
        'TextBoxStock
        '
        Me.TextBoxStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxStock.Location = New System.Drawing.Point(574, 731)
        Me.TextBoxStock.Name = "TextBoxStock"
        Me.TextBoxStock.Size = New System.Drawing.Size(390, 39)
        Me.TextBoxStock.TabIndex = 45
        '
        'DateTimePickerTglMasukKoleksi
        '
        Me.DateTimePickerTglMasukKoleksi.Location = New System.Drawing.Point(574, 661)
        Me.DateTimePickerTglMasukKoleksi.Name = "DateTimePickerTglMasukKoleksi"
        Me.DateTimePickerTglMasukKoleksi.Size = New System.Drawing.Size(390, 39)
        Me.DateTimePickerTglMasukKoleksi.TabIndex = 44
        Me.DateTimePickerTglMasukKoleksi.UseWaitCursor = True
        '
        'TextBoxLokasiRak
        '
        Me.TextBoxLokasiRak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxLokasiRak.Location = New System.Drawing.Point(574, 591)
        Me.TextBoxLokasiRak.Name = "TextBoxLokasiRak"
        Me.TextBoxLokasiRak.Size = New System.Drawing.Size(390, 39)
        Me.TextBoxLokasiRak.TabIndex = 43
        '
        'TextBoxTahunTerbit
        '
        Me.TextBoxTahunTerbit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxTahunTerbit.Location = New System.Drawing.Point(574, 521)
        Me.TextBoxTahunTerbit.Name = "TextBoxTahunTerbit"
        Me.TextBoxTahunTerbit.Size = New System.Drawing.Size(390, 39)
        Me.TextBoxTahunTerbit.TabIndex = 42
        '
        'TextBoxPenerbit
        '
        Me.TextBoxPenerbit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPenerbit.Location = New System.Drawing.Point(574, 451)
        Me.TextBoxPenerbit.Name = "TextBoxPenerbit"
        Me.TextBoxPenerbit.Size = New System.Drawing.Size(390, 39)
        Me.TextBoxPenerbit.TabIndex = 41
        '
        'RichTextBoxDeskripsi
        '
        Me.RichTextBoxDeskripsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBoxDeskripsi.Location = New System.Drawing.Point(574, 241)
        Me.RichTextBoxDeskripsi.Name = "RichTextBoxDeskripsi"
        Me.RichTextBoxDeskripsi.Size = New System.Drawing.Size(390, 183)
        Me.RichTextBoxDeskripsi.TabIndex = 40
        Me.RichTextBoxDeskripsi.Text = ""
        '
        'ComboBoxJenisKoleksi
        '
        Me.ComboBoxJenisKoleksi.FormattingEnabled = True
        Me.ComboBoxJenisKoleksi.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi Penelitian"})
        Me.ComboBoxJenisKoleksi.Location = New System.Drawing.Point(574, 171)
        Me.ComboBoxJenisKoleksi.Name = "ComboBoxJenisKoleksi"
        Me.ComboBoxJenisKoleksi.Size = New System.Drawing.Size(390, 40)
        Me.ComboBoxJenisKoleksi.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(297, 941)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 32)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Kategori"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(297, 801)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 32)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Bahasa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(297, 731)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 32)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Stock"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(297, 661)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(254, 32)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Tanggal Masuk Koleksi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(297, 591)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 32)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Lokasi Rak"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(297, 521)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 32)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Tahun Terbit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(297, 451)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 32)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Penerbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(297, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 32)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Deskripsi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(297, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 32)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Jenis Koleksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 32)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nama Koleksi"
        '
        'BtnUpdateGambar
        '
        Me.BtnUpdateGambar.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpdateGambar.Location = New System.Drawing.Point(52, 357)
        Me.BtnUpdateGambar.Name = "BtnUpdateGambar"
        Me.BtnUpdateGambar.Size = New System.Drawing.Size(200, 46)
        Me.BtnUpdateGambar.TabIndex = 28
        Me.BtnUpdateGambar.Text = "Update Gambar"
        Me.BtnUpdateGambar.UseVisualStyleBackColor = True
        '
        'PictureBoxKoleksi
        '
        Me.PictureBoxKoleksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxKoleksi.Location = New System.Drawing.Point(52, 101)
        Me.PictureBoxKoleksi.Name = "PictureBoxKoleksi"
        Me.PictureBoxKoleksi.Size = New System.Drawing.Size(200, 250)
        Me.PictureBoxKoleksi.TabIndex = 27
        Me.PictureBoxKoleksi.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(52, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 40)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Update Koleksi"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxNamaKoleksi
        '
        Me.TextBoxNamaKoleksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxNamaKoleksi.Location = New System.Drawing.Point(574, 101)
        Me.TextBoxNamaKoleksi.Name = "TextBoxNamaKoleksi"
        Me.TextBoxNamaKoleksi.Size = New System.Drawing.Size(390, 39)
        Me.TextBoxNamaKoleksi.TabIndex = 25
        '
        'UpdateKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 1282)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonUpdateKoleksi)
        Me.Controls.Add(Me.TextBoxStock)
        Me.Controls.Add(Me.DateTimePickerTglMasukKoleksi)
        Me.Controls.Add(Me.TextBoxLokasiRak)
        Me.Controls.Add(Me.TextBoxTahunTerbit)
        Me.Controls.Add(Me.TextBoxPenerbit)
        Me.Controls.Add(Me.RichTextBoxDeskripsi)
        Me.Controls.Add(Me.ComboBoxJenisKoleksi)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnUpdateGambar)
        Me.Controls.Add(Me.PictureBoxKoleksi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxNamaKoleksi)
        Me.Name = "UpdateKoleksi"
        Me.Text = "UpdateKoleksi"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenImageKoleksi As OpenFileDialog
    Friend WithEvents CheckBoxBudaya As CheckBox
    Friend WithEvents CheckBoxTeknologi As CheckBox
    Friend WithEvents CheckBoxSosial As CheckBox
    Friend WithEvents CheckBoxSains As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButtonBhsIngg As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonBhsIndo As RadioButton
    Friend WithEvents ButtonUpdateKoleksi As Button
    Friend WithEvents TextBoxStock As TextBox
    Friend WithEvents DateTimePickerTglMasukKoleksi As DateTimePicker
    Friend WithEvents TextBoxLokasiRak As TextBox
    Friend WithEvents TextBoxTahunTerbit As TextBox
    Friend WithEvents TextBoxPenerbit As TextBox
    Friend WithEvents RichTextBoxDeskripsi As RichTextBox
    Friend WithEvents ComboBoxJenisKoleksi As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnUpdateGambar As Button
    Friend WithEvents PictureBoxKoleksi As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNamaKoleksi As TextBox
End Class
