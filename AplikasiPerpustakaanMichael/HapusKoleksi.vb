Public Class HapusKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelNamaKoleksi.Text = Perpustakaan.ListBoxKoleksi.SelectedItem()
    End Sub

    Private Sub ButtonHapusKoleksi_Click(sender As Object, e As EventArgs) Handles ButtonHapusKoleksi.Click
        Perpustakaan.koleksi_buku_list.Remove(Perpustakaan.ListBoxKoleksi.SelectedItem())
        Me.Close()
    End Sub
End Class