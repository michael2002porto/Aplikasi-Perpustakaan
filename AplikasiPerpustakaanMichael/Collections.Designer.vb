<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Collections
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListArrayList = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListHashtable = New System.Windows.Forms.ListBox()
        Me.ListBoxStack = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBoxQueue = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Demo Array List"
        '
        'ListArrayList
        '
        Me.ListArrayList.FormattingEnabled = True
        Me.ListArrayList.ItemHeight = 32
        Me.ListArrayList.Location = New System.Drawing.Point(12, 58)
        Me.ListArrayList.Name = "ListArrayList"
        Me.ListArrayList.Size = New System.Drawing.Size(385, 164)
        Me.ListArrayList.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(499, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Demo Hashtable"
        '
        'ListHashtable
        '
        Me.ListHashtable.FormattingEnabled = True
        Me.ListHashtable.ItemHeight = 32
        Me.ListHashtable.Location = New System.Drawing.Point(499, 58)
        Me.ListHashtable.Name = "ListHashtable"
        Me.ListHashtable.Size = New System.Drawing.Size(385, 164)
        Me.ListHashtable.TabIndex = 4
        '
        'ListBoxStack
        '
        Me.ListBoxStack.FormattingEnabled = True
        Me.ListBoxStack.ItemHeight = 32
        Me.ListBoxStack.Location = New System.Drawing.Point(996, 58)
        Me.ListBoxStack.Name = "ListBoxStack"
        Me.ListBoxStack.Size = New System.Drawing.Size(240, 164)
        Me.ListBoxStack.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(996, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Demo Stack"
        '
        'ListBoxQueue
        '
        Me.ListBoxQueue.FormattingEnabled = True
        Me.ListBoxQueue.ItemHeight = 32
        Me.ListBoxQueue.Location = New System.Drawing.Point(1355, 58)
        Me.ListBoxQueue.Name = "ListBoxQueue"
        Me.ListBoxQueue.Size = New System.Drawing.Size(240, 164)
        Me.ListBoxQueue.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1355, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 32)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Demo Queue"
        '
        'Collections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1609, 450)
        Me.Controls.Add(Me.ListBoxQueue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBoxStack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListHashtable)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListArrayList)
        Me.Name = "Collections"
        Me.Text = "Collections"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListArrayList As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListHashtable As ListBox
    Friend WithEvents ListBoxStack As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBoxQueue As ListBox
    Friend WithEvents Label4 As Label
End Class
