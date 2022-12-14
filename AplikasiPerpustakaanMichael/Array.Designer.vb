<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Array
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
        Me.ListBoxArray = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBoxArrayDynamic = New System.Windows.Forms.ListBox()
        Me.ListBoxArrayMulti = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBoxArray
        '
        Me.ListBoxArray.FormattingEnabled = True
        Me.ListBoxArray.ItemHeight = 32
        Me.ListBoxArray.Location = New System.Drawing.Point(12, 58)
        Me.ListBoxArray.Name = "ListBoxArray"
        Me.ListBoxArray.Size = New System.Drawing.Size(240, 164)
        Me.ListBoxArray.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Demo Array"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(401, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Demo Array Dynamic"
        '
        'ListBoxArrayDynamic
        '
        Me.ListBoxArrayDynamic.FormattingEnabled = True
        Me.ListBoxArrayDynamic.ItemHeight = 32
        Me.ListBoxArrayDynamic.Location = New System.Drawing.Point(401, 58)
        Me.ListBoxArrayDynamic.Name = "ListBoxArrayDynamic"
        Me.ListBoxArrayDynamic.Size = New System.Drawing.Size(240, 164)
        Me.ListBoxArrayDynamic.TabIndex = 3
        '
        'ListBoxArrayMulti
        '
        Me.ListBoxArrayMulti.FormattingEnabled = True
        Me.ListBoxArrayMulti.ItemHeight = 32
        Me.ListBoxArrayMulti.Location = New System.Drawing.Point(804, 58)
        Me.ListBoxArrayMulti.Name = "ListBoxArrayMulti"
        Me.ListBoxArrayMulti.Size = New System.Drawing.Size(240, 164)
        Me.ListBoxArrayMulti.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(804, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(288, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Demo Array Multidimensi"
        '
        'Array
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBoxArrayMulti)
        Me.Controls.Add(Me.ListBoxArrayDynamic)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxArray)
        Me.Name = "Array"
        Me.Text = "Array"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxArray As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBoxArrayDynamic As ListBox
    Friend WithEvents ListBoxArrayMulti As ListBox
    Friend WithEvents Label3 As Label
End Class
