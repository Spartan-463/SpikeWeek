Public Class Form2
    Dim fileHelper As New FileHelper("exerciseLog")
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        outputLBL.Text = fileHelper.intializeFile()
    End Sub


    Private Sub readFileBTN_Click(sender As Object, e As EventArgs) Handles readFileBTN.Click
        testLBX.Items.Clear()
        ' testDGV.AutoResizeColumns()
        testDGV.Rows.Clear()
        testDGV.Refresh()
        Dim tempList = fileHelper.getData(readDTP.Value.ToString("yyyy-MM-dd"))
        If (tempList.Count = 0) Then
            testLBX.Items.Add("No exercise logged on this date")

        Else
            For Each item As String In tempList
                testLBX.Items.Add(item)
            Next
        End If


        'experimenting with DGV


        If (tempList.Count = 0) Then
            testLBX.Items.Add("No exercise logged on this date")

        Else
            Dim col As String()
            For Each item As String In tempList
                col = item.Split(",")
                'testDGV.Rows.Add(col(0), col(1), col(2), col(3), col(4), col(5))
                testDGV.Rows.Add(col(0), col(1), col(2), col(3), col(4))
            Next
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub writeLineBTN_Click(sender As Object, e As EventArgs) Handles writeLineBTN.Click
        If (exerciseTBX.Text IsNot "") Then
            'fileHelper.updateFile("2023-02-09,bicep curls")
            fileHelper.writeData(exerciseDTP.Value.ToString("yyyy-MM-dd") + "," + exerciseTBX.Text + "," + CStr(setsNUD.Value) + "," + CStr(repsNUD.Value) + "," + CStr(weightNUD.Value))
        End If
    End Sub

    Private Sub testDGV_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles testDGV.RowStateChanged
        Try
            If e.StateChanged = DataGridViewElementStates.Selected Then

                Dim selectedRow As DataGridViewRow = e.Row

                Dim cellValue As String = selectedRow.Cells("RecordNumber").Value.ToString()
                recordLBL.Text = cellValue

            ElseIf e.StateChanged = DataGridViewElementStates.None Then

                recordLBL.Text = "not selected"
            End If

        Catch ex As Exception
        End Try
    End Sub


End Class