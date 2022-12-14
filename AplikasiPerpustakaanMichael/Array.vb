Public Class Array
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        runArrayBasic()
        runArrayDynamic()
        runArrayMultidimension()
    End Sub

    Public Sub runArrayBasic()
        Dim intData(5) As Integer
        Dim i, j As Integer

        For i = 0 To 4
            intData(i) = i + 10
        Next

        For j = 0 To 4
            ListBoxArray.Items.Add(intData(j))
        Next
    End Sub

    Public Sub runArrayDynamic()
        Dim buah(5) As String
        buah(0) = "Apple"
        buah(1) = "Pisang"
        buah(2) = "Mangga"
        buah(3) = "Jambu"
        buah(4) = "Rambutan"

        ReDim Preserve buah(8)
        buah(5) = "Salak"
        buah(6) = "Durian"
        buah(7) = "Sirsak"

        For i = 0 To 7
            ListBoxArrayDynamic.Items.Add(buah(i))
        Next
    End Sub

    Public Sub runArrayMultidimension()
        Dim buahJumlah(,) As Object = {{"Apple", 3}, {"Pisang", 10}, {"Mangga", 7}, {"Jambu", 5}, {"Rambutan", 15}}

        For i_horizontal = 0 To 4
            Dim buahDanJumlah As String = ""
            For j_vertical = 0 To 1
                buahDanJumlah += buahJumlah(i_horizontal, j_vertical) & " | "
            Next
            ListBoxArrayMulti.Items.Add(buahDanJumlah)
        Next
    End Sub
End Class