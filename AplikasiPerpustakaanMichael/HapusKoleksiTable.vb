Public Class HapusKoleksiTable
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelNamaKoleksi.Text = Perpustakaan.selectedTableKoleksiNama
    End Sub

    Private Sub ButtonHapusKoleksi_Click(sender As Object, e As EventArgs) Handles ButtonHapusKoleksi.Click
        Perpustakaan.data_perpustakaan.DeleteDataKoleksiByIDDatabase(Perpustakaan.selectedTableKoleksi)
        Me.Close()
    End Sub
End Class