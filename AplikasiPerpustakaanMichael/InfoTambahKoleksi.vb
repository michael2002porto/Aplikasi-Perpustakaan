Public Class InfoTambahKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not String.IsNullOrEmpty(Perpustakaan.data_perpustakaan.GSFotoKoleksi) Then
            PictureBoxKoleksi.Load(Perpustakaan.data_perpustakaan.GSFotoKoleksi)
            PictureBoxKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LabelNamaKoleksi.Text = Perpustakaan.data_perpustakaan.GSNamaKoleksi
        LabelJenisKoleksi.Text = Perpustakaan.data_perpustakaan.GSJenisKoleksi
        LabelDeskripsi.Text = Perpustakaan.data_perpustakaan.GSDeskripsi
        LabelPenerbit.Text = Perpustakaan.data_perpustakaan.GSPenerbit
        LabelTahunTerbit.Text = Perpustakaan.data_perpustakaan.GSTahunTerbit
        LabelLokasiRak.Text = Perpustakaan.data_perpustakaan.GSLokasiRak
        LabelTanggalMasukKoleksi.Text = Perpustakaan.data_perpustakaan.GSTanggalMasukKoleksi
        LabelStock.Text = Perpustakaan.data_perpustakaan.GSStock
        LabelBahasa.Text = Perpustakaan.data_perpustakaan.GSBahasa

        ListBoxKategori.Items.Clear()

        For Each kat In Perpustakaan.data_perpustakaan.GSKategoriList
            ListBoxKategori.Items.Add(kat)
        Next

        Perpustakaan.data_perpustakaan.GSKategoriList.Clear()
    End Sub

    Private Sub ButtonTutupInfoTambahKoleksi_Click(sender As Object, e As EventArgs) Handles ButtonTutupInfoTambahKoleksi.Click
        Me.Close()
    End Sub

    Private Sub InfoTambahKoleksi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Perpustakaan.data_perpustakaan.GSFotoKoleksi = Nothing
        Perpustakaan.data_perpustakaan.GSNamaKoleksi = Nothing
        Perpustakaan.data_perpustakaan.GSJenisKoleksi = Nothing
        Perpustakaan.data_perpustakaan.GSDeskripsi = Nothing
        Perpustakaan.data_perpustakaan.GSPenerbit = Nothing
        Perpustakaan.data_perpustakaan.GSTahunTerbit = Nothing
        Perpustakaan.data_perpustakaan.GSLokasiRak = Nothing
        Perpustakaan.data_perpustakaan.GSTanggalMasukKoleksi = Nothing
        Perpustakaan.data_perpustakaan.GSStock = Nothing
        Perpustakaan.data_perpustakaan.GSBahasa = Nothing
    End Sub
End Class