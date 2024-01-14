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
        Button2 = New Button()
        Button7 = New Button()
        GroupBox1 = New GroupBox()
        Button4 = New Button()
        Button3 = New Button()
        Button5 = New Button()
        exercisesBTN = New Button()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(166, 266)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(165, 44)
        Button2.TabIndex = 1
        Button2.Text = "Goals, Achievments && Achievements"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(345, 266)
        Button7.Margin = New Padding(3, 2, 3, 2)
        Button7.Name = "Button7"
        Button7.Size = New Size(165, 44)
        Button7.TabIndex = 6
        Button7.Text = "Settings"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(exercisesBTN)
        GroupBox1.Location = New Point(118, 109)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(422, 144)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Food && Activity"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(227, 79)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(165, 44)
        Button4.TabIndex = 8
        Button4.Text = "Sleep"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(227, 31)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(165, 44)
        Button3.TabIndex = 7
        Button3.Text = "Body"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(48, 79)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(165, 44)
        Button5.TabIndex = 6
        Button5.Text = "Nutrition"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' exercisesBTN
        ' 
        exercisesBTN.Location = New Point(48, 31)
        exercisesBTN.Margin = New Padding(3, 2, 3, 2)
        exercisesBTN.Name = "exercisesBTN"
        exercisesBTN.Size = New Size(165, 44)
        exercisesBTN.TabIndex = 5
        exercisesBTN.Text = "Exercises"
        exercisesBTN.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(118, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(401, 37)
        Label1.TabIndex = 8
        Label1.Text = "Welcome to Health App v00.1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(Button7)
        Controls.Add(Button2)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Home Screen"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents exercisesBTN As Button
    Friend WithEvents Label1 As Label
End Class
