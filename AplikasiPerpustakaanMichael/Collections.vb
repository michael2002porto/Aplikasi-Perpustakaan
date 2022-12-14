Public Class Collections
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        runArrayList()
        runHashTable()
        runStackCollection()
        runQueueCollection()
    End Sub

    Public Sub runArrayList()
        Dim student As New ArrayList()
        student.Add({"Amir", "TI-3A", "Jakarta", "2020"})
        student.Add({"Mira", "TI-3B", "Jakarta", "2021"})

        For Each rowStudent In student
            Dim dataList As String = rowStudent(0) & " | " & rowStudent(1) & " | " & rowStudent(2) & " | " & rowStudent(3)
            ListArrayList.Items.Add(dataList)
        Next
    End Sub

    Public Sub runHashTable()
        Dim students As New Hashtable()
        students.Add("A100", {"Amir", "TI-3A", "Jakarta", "2020"})
        students.Add("A101", {"Mira", "TI-3B", "Jakarta", "2021"})

        Dim keyStudents As ICollection = students.Keys()

        For Each rowkoleksis In keyStudents
            Dim rowStudent As String() = students(rowkoleksis)
            Dim datalist As String = rowStudent(0) & " | " & rowStudent(1) & " | " & rowStudent(2) & " | " & rowStudent(3)
            ListHashtable.Items.Add(dataList)
        Next
    End Sub

    Public Sub runStackCollection()
        Dim stackBuah As Stack = New Stack()
        stackBuah.Push("Apple")
        stackBuah.Push("Pisang")
        stackBuah.Push("Mangga")
        stackBuah.Push("Rambutan")

        For Each item In stackBuah
            ListBoxStack.Items.Add(item)
        Next
    End Sub

    Public Sub runQueueCollection()
        Dim queueBuah As Queue = New Queue()
        queueBuah.Enqueue("Apple")
        queueBuah.Enqueue("Pisang")
        queueBuah.Enqueue("Mangga")
        queueBuah.Enqueue("Rambutan")

        For Each item In queueBuah
            ListBoxQueue.Items.Add(item)
        Next
    End Sub
End Class