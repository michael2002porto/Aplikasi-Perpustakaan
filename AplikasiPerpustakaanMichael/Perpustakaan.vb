Imports System.ComponentModel.Design.ObjectSelectorEditor

Public Class Perpustakaan
    Public Shared koleksi_buku_list As New List(Of String)

    Public Shared data_perpustakaan As DataPerpustakaan

    Public Shared selectedTableKoleksi, selectedTableKoleksiNama As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        data_perpustakaan = New DataPerpustakaan()
        ReloadDataTableDatabase()
    End Sub

    Private Sub ButtonTambahKoleksi_Click(sender As Object, e As EventArgs) Handles ButtonTambahKoleksi.Click
        Dim tambah_koleksi = New TambahKoleksi()
        tambah_koleksi.Show()
    End Sub

    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        Dim tambah_koleksi = New TambahKoleksi()
        tambah_koleksi.Show()
    End Sub

    Private Sub Perpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()

        ListBoxKoleksi.Items.Clear()
        For Each kat In koleksi_buku_list
            ListBoxKoleksi.Items.Add(kat)
        Next

        'UpdateDataTableArrayList()
    End Sub

    Private Sub ButtonHapusKoleksi_Click(sender As Object, e As EventArgs) Handles ButtonHapusKoleksi.Click
        If ListBoxKoleksi.SelectedItem() IsNot Nothing Then
            Dim hapus_koleksi = New HapusKoleksi()
            hapus_koleksi.Show()
        Else
            MessageBox.Show("Pilih koleksi yang ingin dihapus")
        End If
    End Sub

    Private Sub ArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrayToolStripMenuItem.Click
        Dim array = New Array()
        array.Show()
    End Sub

    Private Sub CollectionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollectionsToolStripMenuItem.Click
        Dim collections = New Collections()
        collections.Show()
    End Sub

    'Private Sub ListBoxKoleksi_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBoxKoleksi.MouseDoubleClick
    '    'Buka Form Info Tambah Koleksi
    '    '=========================================================================
    '    Dim info_tambah_koleksi = New InfoTambahKoleksi()
    '    info_tambah_koleksi.Show()
    'End Sub

    Public Sub UpdateDataTableArrayList()
        DataGridKoleksi.Rows.Clear()
        For Each rowKoleksi In data_perpustakaan.getKoleksiDataTable()
            Dim dataTable As String() = {
                rowKoleksi(0),
                rowKoleksi(1),
                rowKoleksi(2),
                rowKoleksi(3),
                rowKoleksi(4),
                rowKoleksi(5),
                rowKoleksi(6),
                rowKoleksi(7),
                rowKoleksi(8),
                rowKoleksi(9),
                rowKoleksi(10)
            }
            DataGridKoleksi.Rows.Add(dataTable)
        Next
    End Sub

    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
        'selectedTableKoleksi = DataGridKoleksi.CurrentRow.Index
        Try
            Dim index As Integer = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridKoleksi.Rows(index)

            selectedTableKoleksi = selectedRow.Cells(0).Value
            selectedTableKoleksiNama = selectedRow.Cells(1).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Try
            If selectedTableKoleksi Is Nothing Or selectedTableKoleksiNama Is Nothing Then
                Throw New System.Exception("Please select data grid")
            End If
            'Dim dataSelected = data_perpustakaan.getKoleksiDataTable.Item(selectedTableKoleksi)
            Dim dataSelected = data_perpustakaan.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

            data_perpustakaan.GSNamaKoleksi = dataSelected(1)
            data_perpustakaan.GSFotoKoleksi = dataSelected(2)
            data_perpustakaan.GSDeskripsi = dataSelected(3)
            data_perpustakaan.GSPenerbit = dataSelected(4)
            data_perpustakaan.GSJenisKoleksi = dataSelected(5)
            data_perpustakaan.GSTahunTerbit = dataSelected(6)
            data_perpustakaan.GSLokasiRak = dataSelected(7)
            data_perpustakaan.GSTanggalMasukKoleksi = dataSelected(8)
            data_perpustakaan.GSStock = dataSelected(9)
            data_perpustakaan.GSBahasa = dataSelected(10)

            Dim data_koleksi As List(Of String) = data_perpustakaan.ConvertStringToKoleksi(dataSelected(11))

            For Each info_tambah In data_koleksi
                data_perpustakaan.AddKategori(info_tambah)
            Next

            Dim infoTambah = New InfoTambahKoleksi()
            infoTambah.Show()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            If selectedTableKoleksi Is Nothing Or selectedTableKoleksiNama Is Nothing Then
                Throw New System.Exception("Please select data grid")
            End If
            Dim selectedKoleksi As List(Of String) = data_perpustakaan.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

            data_perpustakaan.GSNamaKoleksi = selectedKoleksi(1)
            data_perpustakaan.GSFotoKoleksi = selectedKoleksi(2)
            data_perpustakaan.GSDeskripsi = selectedKoleksi(3)
            data_perpustakaan.GSPenerbit = selectedKoleksi(4)
            data_perpustakaan.GSJenisKoleksi = selectedKoleksi(5)
            data_perpustakaan.GSTahunTerbit = selectedKoleksi(6)
            data_perpustakaan.GSLokasiRak = selectedKoleksi(7)
            data_perpustakaan.GSTanggalMasukKoleksi = selectedKoleksi(8)
            data_perpustakaan.GSStock = selectedKoleksi(9)
            data_perpustakaan.GSBahasa = selectedKoleksi(10)
            Dim data_kategori As List(Of String) = data_perpustakaan.ConvertStringToKoleksi(selectedKoleksi(11))

            For Each info_kategori In data_kategori
                data_perpustakaan.AddKategori(info_kategori)
            Next

            Dim formUpdate = New UpdateKoleksi()
            formUpdate.Show()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Try
            If selectedTableKoleksi Is Nothing Or selectedTableKoleksiNama Is Nothing Then
                Throw New System.Exception("Please select data grid")
            End If

            Dim formHapus = New HapusKoleksiTable()
            formHapus.Show()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKoleksi.DataSource = data_perpustakaan.GetDataKoleksiDatabase()
        DataGridKoleksi.ClearSelection()
        selectedTableKoleksi = Nothing
    End Sub
End Class
