﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles exercisesBTN.Click
        Form2.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' triggers and click event on loading
        exercisesBTN.PerformClick()

    End Sub


End Class
