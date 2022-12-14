Imports Google.Protobuf.WellKnownTypes

Public Class UpdateKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Perpustakaan.data_perpustakaan.GSFotoKoleksi.ToString.Length > 0 Then
            PictureBoxKoleksi.Load(Perpustakaan.data_perpustakaan.GSFotoKoleksi)
            PictureBoxKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        DateTimePickerTglMasukKoleksi.Format = DateTimePickerFormat.Custom
        DateTimePickerTglMasukKoleksi.CustomFormat = "yyyy/MM/dd"
        TextBoxNamaKoleksi.Text = Perpustakaan.data_perpustakaan.GSNamaKoleksi
        ComboBoxJenisKoleksi.SelectedItem() = Perpustakaan.data_perpustakaan.GSJenisKoleksi
        RichTextBoxDeskripsi.Text = Perpustakaan.data_perpustakaan.GSDeskripsi
        TextBoxPenerbit.Text = Perpustakaan.data_perpustakaan.GSPenerbit
        TextBoxTahunTerbit.Text = Perpustakaan.data_perpustakaan.GSTahunTerbit
        TextBoxLokasiRak.Text = Perpustakaan.data_perpustakaan.GSLokasiRak
        DateTimePickerTglMasukKoleksi.Value = Perpustakaan.data_perpustakaan.GSTanggalMasukKoleksi
        TextBoxStock.Text = Perpustakaan.data_perpustakaan.GSStock

        If String.Compare(Perpustakaan.data_perpustakaan.GSBahasa, "Indonesia") Then
            RadioButtonBhsIndo.Checked = True
        ElseIf String.Compare(Perpustakaan.data_perpustakaan.GSBahasa, "Inggris") Then
            RadioButtonBhsIngg.Checked = True
        End If

        For Each kategoriItem In Perpustakaan.data_perpustakaan.getKategoriItem
            If String.Compare(kategoriItem, "Sains") = 0 Then
                CheckBoxSains.Checked = True
            ElseIf String.Compare(kategoriItem, "Sosial") = 0 Then
                CheckBoxSosial.Checked = True
            ElseIf String.Compare(kategoriItem, "Teknologi") = 0 Then
                CheckBoxTeknologi.Checked = True
            ElseIf String.Compare(kategoriItem, "Budaya") = 0 Then
                CheckBoxBudaya.Checked = True
            End If
        Next
        Perpustakaan.data_perpustakaan.resetKategori()
    End Sub

    Private Sub BtnUpdateGambar_Click(sender As Object, e As EventArgs) Handles BtnUpdateGambar.Click
        Try
            OpenImageKoleksi.Title = "Open Gambar Koleksi"
            OpenImageKoleksi.Filter = "All Format |*.* | Image |*.bmp|Image JPG |*.jpg|Image JPEG|*.jpeg|Image PNG |*.png|Image GIF |*.gif"
            OpenImageKoleksi.ShowDialog()

            Dim pickoleksiDir As String = OpenImageKoleksi.FileName

            PictureBoxKoleksi.Load(pickoleksiDir)
            PictureBoxKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
            Perpustakaan.data_perpustakaan.GSFotoKoleksi = pickoleksiDir.ToString()
            Perpustakaan.data_perpustakaan.GSFotoKoleksi = Perpustakaan.data_perpustakaan.GSFotoKoleksi.Replace("\", "/")
        Catch ex As Exception
            MsgBox("Failed upload picture")
        End Try
    End Sub

    Private Sub ButtonUpdateKoleksi_Click(sender As Object, e As EventArgs) Handles ButtonUpdateKoleksi.Click
        Perpustakaan.data_perpustakaan.GSNamaKoleksi = TextBoxNamaKoleksi.Text.ToString()
        Perpustakaan.data_perpustakaan.GSJenisKoleksi = ComboBoxJenisKoleksi.SelectedItem().ToString()
        Perpustakaan.data_perpustakaan.GSDeskripsi = RichTextBoxDeskripsi.Text.ToString()
        Perpustakaan.data_perpustakaan.GSPenerbit = TextBoxPenerbit.Text.ToString()
        Perpustakaan.data_perpustakaan.GSTahunTerbit = Integer.Parse(TextBoxTahunTerbit.Text)

        Perpustakaan.data_perpustakaan.GSLokasiRak = TextBoxLokasiRak.Text.ToString()
        Perpustakaan.data_perpustakaan.GSTanggalMasukKoleksi = DateTimePickerTglMasukKoleksi.Value.ToString("yyyy/MM/dd")
        Perpustakaan.data_perpustakaan.GSStock = Integer.Parse(TextBoxStock.Text)

        If RadioButtonBhsIndo.Checked Then
            Perpustakaan.data_perpustakaan.GSBahasa = "Indonesia"
        ElseIf RadioButtonBhsIngg.Checked Then
            Perpustakaan.data_perpustakaan.GSBahasa = "Inggris"
        End If

        If CheckBoxSains.Checked Then
            Perpustakaan.data_perpustakaan.AddKategori("Sains")
        End If
        If CheckBoxSosial.Checked Then
            Perpustakaan.data_perpustakaan.AddKategori("Sosial")
        End If
        If CheckBoxTeknologi.Checked Then
            Perpustakaan.data_perpustakaan.AddKategori("Teknologi")
        End If
        If CheckBoxBudaya.Checked Then
            Perpustakaan.data_perpustakaan.AddKategori("Budaya")
        End If

        Perpustakaan.data_perpustakaan.AddKoleksi(TextBoxNamaKoleksi.Text.ToString())

        Dim convertedKoleksi = Perpustakaan.data_perpustakaan.ConvertKoleksiToString(Perpustakaan.data_perpustakaan.getKategoriItem)
        Perpustakaan.data_perpustakaan.UpdateDataKoleksiByIDDatabase(
            Perpustakaan.selectedTableKoleksi,
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
        Dim infoTambah = New InfoTambahKoleksi()
        infoTambah.Show()

        Me.Close()
    End Sub
End Class