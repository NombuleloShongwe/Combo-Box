<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"iPhone", "Samsung", "Huawei"})
        ComboBox1.Location = New Point(297, 34)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 338)
        Button1.Name = "Button1"
        Button1.Size = New Size(152, 34)
        Button1.TabIndex = 1
        Button1.Text = "Add Item"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(201, 338)
        Button2.Name = "Button2"
        Button2.Size = New Size(152, 34)
        Button2.TabIndex = 2
        Button2.Text = "Remove Items"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(412, 338)
        Button3.Name = "Button3"
        Button3.Size = New Size(173, 34)
        Button3.TabIndex = 3
        Button3.Text = "Remove Selected"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(620, 338)
        Button4.Name = "Button4"
        Button4.Size = New Size(156, 34)
        Button4.TabIndex = 4
        Button4.Text = "Clear"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Name = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button

End Class
