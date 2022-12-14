Public Class TambahKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DateTimePickerTglMasukKoleksi.Format = DateTimePickerFormat.Custom
        DateTimePickerTglMasukKoleksi.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub ButtonTambahGambarKoleksi_Click(sender As Object, e As EventArgs) Handles ButtonTambahGambarKoleksi.Click
        Try
            OpenFileDialog1.Title = "Open Foto"
            OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
            OpenFileDialog1.ShowDialog()

            PictureBoxKoleksi.Load(OpenFileDialog1.FileName)
            PictureBoxKoleksi.SizeMode = PictureBoxSizeMode.StretchImage

            'Perpustakaan.data_perpustakaan.GSFotoKoleksi = OpenFileDialog1.FileName
            Perpustakaan.data_perpustakaan.GSFotoKoleksi = OpenFileDialog1.FileName.ToString()
            Perpustakaan.data_perpustakaan.GSFotoKoleksi = Perpustakaan.data_perpustakaan.GSFotoKoleksi.Replace("\", "/")
        Catch ex As Exception
            MsgBox("Failed upload picture")
        End Try
    End Sub

    Private Sub ButtonTambahKoleksi_Click(sender As Object, e As EventArgs) Handles ButtonTambahKoleksi.Click
        'Set value (isi) variable Class dari textbox, richtextbox, dan radiobutton
        '=========================================================================
        Perpustakaan.data_perpustakaan.GSNamaKoleksi = TextBoxNamaKoleksi.Text

        Perpustakaan.koleksi_buku_list.Add(Perpustakaan.data_perpustakaan.GSNamaKoleksi)

        Perpustakaan.data_perpustakaan.GSJenisKoleksi = ComboBoxJenisKoleksi.SelectedItem()
        Perpustakaan.data_perpustakaan.GSDeskripsi = RichTextBoxDeskripsi.Text
        Perpustakaan.data_perpustakaan.GSPenerbit = TextBoxPenerbit.Text

        If TextBoxTahunTerbit.Text.Length > 0 Then
            Perpustakaan.data_perpustakaan.GSTahunTerbit = TextBoxTahunTerbit.Text
        End If

        Perpustakaan.data_perpustakaan.GSLokasiRak = TextBoxLokasiRak.Text
        Perpustakaan.data_perpustakaan.GSTanggalMasukKoleksi = DateTimePickerTglMasukKoleksi.Value.ToShortDateString

        If TextBoxStock.Text.Length > 0 Then
            Perpustakaan.data_perpustakaan.GSStock = TextBoxStock.Text
        End If

        'bahasa = .SelectedItem()

        'Check Checkbox Value
        '=========================================================================
        If CheckBoxSains.Checked() Then
            Perpustakaan.data_perpustakaan.GSKategoriList.Add(CheckBoxSains.Text)
        End If

        If CheckBoxSosial.Checked() Then
            Perpustakaan.data_perpustakaan.GSKategoriList.Add(CheckBoxSosial.Text)
        End If

        If CheckBoxTeknologi.Checked() Then
            Perpustakaan.data_perpustakaan.GSKategoriList.Add(CheckBoxTeknologi.Text)
        End If

        If CheckBoxBudaya.Checked() Then
            Perpustakaan.data_perpustakaan.GSKategoriList.Add(CheckBoxBudaya.Text)
        End If

        'Add to DataGridView
        '=========================================================================
        Dim convertedKoleksi = Perpustakaan.data_perpustakaan.ConvertKoleksiToString(Perpustakaan.data_perpustakaan.GSKategoriList)
        'Perpustakaan.data_perpustakaan.AddKoleksiDataTable(
        '    Perpustakaan.data_perpustakaan.GSFotoKoleksi,
        '    Perpustakaan.data_perpustakaan.GSNamaKoleksi,
        '    Perpustakaan.data_perpustakaan.GSJenisKoleksi,
        '    Perpustakaan.data_perpustakaan.GSDeskripsi,
        '    Perpustakaan.data_perpustakaan.GSPenerbit,
        '    Perpustakaan.data_perpustakaan.GSTahunTerbit,
        '    Perpustakaan.data_perpustakaan.GSLokasiRak,
        '    Perpustakaan.data_perpustakaan.GSTanggalMasukKoleksi,
        '    Perpustakaan.data_perpustakaan.GSStock,
        '    Perpustakaan.data_perpustakaan.GSBahasa,
        '    convertedKoleksi
        ')
        Perpustakaan.data_perpustakaan.AddDataKoleksiDatabase(
            Perpustakaan.data_perpustakaan.GSFotoKoleksi,
            Perpustakaan.data_perpustakaan.GSNamaKoleksi,
            Perpustakaan.data_perpustakaan.GSJenisKoleksi,
            Perpustakaan.data_perpustakaan.GSPenerbit,
            Perpustakaan.data_perpustakaan.GSDeskripsi,
            Perpustakaan.data_perpustakaan.GSTahunTerbit,
            Perpustakaan.data_perpustakaan.GSLokasiRak,
            Perpustakaan.data_perpustakaan.GSTanggalMasukKoleksi,
            Perpustakaan.data_perpustakaan.GSStock,
            Perpustakaan.data_perpustakaan.GSBahasa,
            convertedKoleksi
        )

        'Buka Form Info Tambah Koleksi
        '=========================================================================
        Dim info_tambah_koleksi = New InfoTambahKoleksi()
        info_tambah_koleksi.Show()

        Me.Close()
    End Sub

    Private Sub RadioButtonBhsIndo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonBhsIndo.CheckedChanged
        Perpustakaan.data_perpustakaan.GSBahasa = RadioButtonBhsIndo.Text
    End Sub

    Private Sub RadioButtonBhsIngg_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonBhsIngg.CheckedChanged
        Perpustakaan.data_perpustakaan.GSBahasa = RadioButtonBhsIngg.Text
    End Sub

    Private Sub TextBoxNamaKoleksi_Leave(sender As Object, e As EventArgs) Handles TextBoxNamaKoleksi.Leave
        If TextBoxNamaKoleksi.Text.Length < 1 Then
            TextBoxNamaKoleksi.Select()
            MessageBox.Show("Please Add At Least 1 String")
        End If
    End Sub

    Private Sub TextBoxTahunTerbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTahunTerbit.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub TextBoxStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxStock.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub
End Class