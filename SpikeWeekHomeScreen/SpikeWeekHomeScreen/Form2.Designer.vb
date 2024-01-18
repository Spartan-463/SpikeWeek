<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        outputLBL = New Label()
        testLBX = New ListBox()
        readFileBTN = New Button()
        GroupBox1 = New GroupBox()
        Label5 = New Label()
        exerciseDTP = New DateTimePicker()
        Label4 = New Label()
        weightNUD = New NumericUpDown()
        repsNUD = New NumericUpDown()
        setsNUD = New NumericUpDown()
        exerciseTBX = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        writeLineBTN = New Button()
        readDTP = New DateTimePicker()
        testDGV = New DataGridView()
        RecordNumber = New DataGridViewTextBoxColumn()
        Day = New DataGridViewTextBoxColumn()
        Exercise = New DataGridViewTextBoxColumn()
        Sets = New DataGridViewTextBoxColumn()
        Reps = New DataGridViewTextBoxColumn()
        Weight = New DataGridViewTextBoxColumn()
        recordLBL = New Label()
        lastRecordNumLBL = New Label()
        removeBTN = New Button()
        GroupBox1.SuspendLayout()
        CType(weightNUD, ComponentModel.ISupportInitialize).BeginInit()
        CType(repsNUD, ComponentModel.ISupportInitialize).BeginInit()
        CType(setsNUD, ComponentModel.ISupportInitialize).BeginInit()
        CType(testDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' outputLBL
        ' 
        outputLBL.AutoSize = True
        outputLBL.Location = New Point(217, 11)
        outputLBL.Name = "outputLBL"
        outputLBL.Size = New Size(90, 15)
        outputLBL.TabIndex = 0
        outputLBL.Text = "diagnostic label"
        ' 
        ' testLBX
        ' 
        testLBX.FormattingEnabled = True
        testLBX.ItemHeight = 15
        testLBX.Location = New Point(267, 107)
        testLBX.Name = "testLBX"
        testLBX.Size = New Size(362, 124)
        testLBX.TabIndex = 2
        ' 
        ' readFileBTN
        ' 
        readFileBTN.Location = New Point(267, 67)
        readFileBTN.Name = "readFileBTN"
        readFileBTN.Size = New Size(75, 23)
        readFileBTN.TabIndex = 3
        readFileBTN.Text = "read file"
        readFileBTN.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(exerciseDTP)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(weightNUD)
        GroupBox1.Controls.Add(repsNUD)
        GroupBox1.Controls.Add(setsNUD)
        GroupBox1.Controls.Add(exerciseTBX)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(writeLineBTN)
        GroupBox1.Location = New Point(12, 29)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(213, 232)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Enter Exercises"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 46)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 15)
        Label5.TabIndex = 21
        Label5.Text = "Date"
        ' 
        ' exerciseDTP
        ' 
        exerciseDTP.Location = New Point(43, 45)
        exerciseDTP.Name = "exerciseDTP"
        exerciseDTP.Size = New Size(149, 23)
        exerciseDTP.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 158)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 15)
        Label4.TabIndex = 18
        Label4.Text = "Weight:"
        ' 
        ' weightNUD
        ' 
        weightNUD.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        weightNUD.Location = New Point(75, 158)
        weightNUD.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        weightNUD.Name = "weightNUD"
        weightNUD.Size = New Size(117, 23)
        weightNUD.TabIndex = 17
        ' 
        ' repsNUD
        ' 
        repsNUD.Location = New Point(75, 129)
        repsNUD.Name = "repsNUD"
        repsNUD.Size = New Size(117, 23)
        repsNUD.TabIndex = 16
        ' 
        ' setsNUD
        ' 
        setsNUD.Location = New Point(75, 100)
        setsNUD.Name = "setsNUD"
        setsNUD.Size = New Size(117, 23)
        setsNUD.TabIndex = 15
        ' 
        ' exerciseTBX
        ' 
        exerciseTBX.Location = New Point(75, 71)
        exerciseTBX.Name = "exerciseTBX"
        exerciseTBX.Size = New Size(117, 23)
        exerciseTBX.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 15)
        Label3.TabIndex = 13
        Label3.Text = "Reps"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 12
        Label2.Text = "Sets"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 15)
        Label1.TabIndex = 11
        Label1.Text = "Exercise:"
        ' 
        ' writeLineBTN
        ' 
        writeLineBTN.Location = New Point(95, 187)
        writeLineBTN.Name = "writeLineBTN"
        writeLineBTN.Size = New Size(75, 23)
        writeLineBTN.TabIndex = 10
        writeLineBTN.Text = "write line"
        writeLineBTN.UseVisualStyleBackColor = True
        ' 
        ' readDTP
        ' 
        readDTP.Location = New Point(359, 67)
        readDTP.Name = "readDTP"
        readDTP.Size = New Size(200, 23)
        readDTP.TabIndex = 19
        ' 
        ' testDGV
        ' 
        testDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        testDGV.Columns.AddRange(New DataGridViewColumn() {RecordNumber, Day, Exercise, Sets, Reps, Weight})
        testDGV.Location = New Point(12, 267)
        testDGV.Name = "testDGV"
        testDGV.RowTemplate.Height = 25
        testDGV.Size = New Size(646, 150)
        testDGV.TabIndex = 20
        ' 
        ' RecordNumber
        ' 
        RecordNumber.HeaderText = "RecordNumber"
        RecordNumber.Name = "RecordNumber"
        ' 
        ' Day
        ' 
        Day.HeaderText = "Date"
        Day.Name = "Day"
        ' 
        ' Exercise
        ' 
        Exercise.HeaderText = "Exercise"
        Exercise.Name = "Exercise"
        ' 
        ' Sets
        ' 
        Sets.HeaderText = "Sets"
        Sets.Name = "Sets"
        ' 
        ' Reps
        ' 
        Reps.HeaderText = "Reps"
        Reps.Name = "Reps"
        ' 
        ' Weight
        ' 
        Weight.HeaderText = "Weight"
        Weight.Name = "Weight"
        ' 
        ' recordLBL
        ' 
        recordLBL.AutoSize = True
        recordLBL.Location = New Point(694, 298)
        recordLBL.Name = "recordLBL"
        recordLBL.Size = New Size(91, 15)
        recordLBL.TabIndex = 21
        recordLBL.Text = "diagnostic DGV "
        ' 
        ' lastRecordNumLBL
        ' 
        lastRecordNumLBL.AutoSize = True
        lastRecordNumLBL.Location = New Point(694, 358)
        lastRecordNumLBL.Name = "lastRecordNumLBL"
        lastRecordNumLBL.Size = New Size(41, 15)
        lastRecordNumLBL.TabIndex = 22
        lastRecordNumLBL.Text = "Label6"
        ' 
        ' removeBTN
        ' 
        removeBTN.Location = New Point(678, 376)
        removeBTN.Name = "removeBTN"
        removeBTN.Size = New Size(75, 23)
        removeBTN.TabIndex = 23
        removeBTN.Text = "Remove Line"
        removeBTN.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(792, 419)
        Controls.Add(removeBTN)
        Controls.Add(lastRecordNumLBL)
        Controls.Add(recordLBL)
        Controls.Add(testDGV)
        Controls.Add(readDTP)
        Controls.Add(GroupBox1)
        Controls.Add(readFileBTN)
        Controls.Add(testLBX)
        Controls.Add(outputLBL)
        Name = "Form2"
        Text = "Exercise log"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(weightNUD, ComponentModel.ISupportInitialize).EndInit()
        CType(repsNUD, ComponentModel.ISupportInitialize).EndInit()
        CType(setsNUD, ComponentModel.ISupportInitialize).EndInit()
        CType(testDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents outputLBL As Label
    Friend WithEvents testLBX As ListBox
    Friend WithEvents readFileBTN As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents repsNUD As NumericUpDown
    Friend WithEvents setsNUD As NumericUpDown
    Friend WithEvents exerciseTBX As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents writeLineBTN As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents weightNUD As NumericUpDown
    Friend WithEvents readDTP As DateTimePicker
    Friend WithEvents exerciseDTP As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents testDGV As DataGridView
    Friend WithEvents RecordNumber As DataGridViewTextBoxColumn
    Friend WithEvents Day As DataGridViewTextBoxColumn
    Friend WithEvents Exercise As DataGridViewTextBoxColumn
    Friend WithEvents Sets As DataGridViewTextBoxColumn
    Friend WithEvents Reps As DataGridViewTextBoxColumn
    Friend WithEvents Weight As DataGridViewTextBoxColumn
    Friend WithEvents recordLBL As Label
    Friend WithEvents lastRecordNumLBL As Label
    Friend WithEvents removeBTN As Button
End Class
