Public Class Koleksi
    Private namaKoleksi As String
    Private dirGambarBuku As String
    Private deskripsiKoleksi As String
    Private penerbit As String
    Private jenisKoleksi As String
    Private tahunTerbit As String
    Private lokasi As String
    Private tanggalMasukKoleksi As String
    Private stock As Integer
    Private bahasa As String
    Private kategori As New List(Of String)
    Private listKoleksi As New List(Of String)

    'Getter and Setter buat Variable Global
    Public Property namaKoleksiProperty() As String
        Get
            Return namaKoleksi
        End Get
        Set(ByVal value As String)
            namaKoleksi = value
        End Set
    End Property
    Public Property dirGambarBukuProperty() As String
        Get
            Return dirGambarBuku
        End Get
        Set(ByVal value As String)
            dirGambarBuku = value
        End Set
    End Property
    Public Property deskripsiKoleksiProperty() As String
        Get
            Return deskripsiKoleksi
        End Get
        Set(ByVal value As String)
            deskripsiKoleksi = value
        End Set
    End Property
    Public Property penerbitProperty() As String
        Get
            Return penerbit
        End Get
        Set(ByVal value As String)
            penerbit = value
        End Set
    End Property
    Public Property jenisKoleksiProperty() As String
        Get
            Return jenisKoleksi
        End Get
        Set(ByVal value As String)
            jenisKoleksi = value
        End Set
    End Property
    Public Property tahunTerbitProperty() As String
        Get
            Return tahunTerbit
        End Get
        Set(ByVal value As String)
            tahunTerbit = value
        End Set
    End Property
    Public Property lokasiProperty() As String
        Get
            Return lokasi
        End Get
        Set(ByVal value As String)
            lokasi = value
        End Set
    End Property
    Public Property tanggalMasukKoleksiProperty() As String
        Get
            Return tanggalMasukKoleksi
        End Get
        Set(ByVal value As String)
            tanggalMasukKoleksi = value
        End Set
    End Property
    Public Property stockProperty() As Integer
        Get
            Return stock
        End Get
        Set(ByVal value As Integer)
            stock = value
        End Set
    End Property
    Public Property bahasaProperty() As String
        Get
            Return bahasa
        End Get
        Set(ByVal value As String)
            bahasa = value
        End Set
    End Property

    'Getter Setter untuk List Kategori
    Public Function AddKategori(value As String)
        kategori.Add(value)
        Return ""
    End Function
    Public ReadOnly Property getKategoriItem() As List(Of String)
        Get
            Return kategori
        End Get
    End Property
    Public Function resetKategori(value As String)
        kategori.Clear()
    End Function

    'Getter and Setter Untuk List Koleksi
    Public Function AddKoleksi(value As String)
        listKoleksi.Add(value)
        Return ""
    End Function
    Public Function RemoveKoleksi(value As String)
        listKoleksi.Remove(value)
        Return ""
    End Function
    Public ReadOnly Property getKoleksiItem() As List(Of String)
        Get
            Return listKoleksi
        End Get
    End Property
End Class
