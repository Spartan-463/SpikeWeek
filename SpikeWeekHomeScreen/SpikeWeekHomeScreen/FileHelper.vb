Imports System.IO

Public Class FileHelper
    ' Properties
    Public Property fileLength As Integer
    Public Property name As String
    Dim output As StreamWriter
    Dim inStream As StreamReader
    Dim filename As String
    Dim recordNumber As Integer = 0

    ' Constructor
    Public Sub New(name As String)
        Me.name = name
    End Sub

    ' giveFileLength
    Public Function getFileLength()
        Dim count As Integer
        Dim tempString As String
        tempString = inStream.ReadLine
        While (tempString IsNot Nothing)
            count += count + 1
            tempString = inStream.ReadLine
        End While
        inStream.Close()
        Return count

    End Function

    ' initialize file   String:name

    Public Function getData() 'gives list of strings 
        Dim fileData As New List(Of String)

        inStream = New StreamReader(filename)
        Dim tempString As String
        tempString = inStream.ReadLine
        While (tempString IsNot Nothing)
            fileData.Add(tempString)
            tempString = inStream.ReadLine
        End While
        inStream.Close()
        Return fileData

    End Function
    Public Function getData(DateString As String) 'gives list of strings 
        Dim fileData As New List(Of String)

        inStream = New StreamReader(filename)
        Dim tempString As String
        tempString = inStream.ReadLine
        While (tempString IsNot Nothing)
            If (DateString.Equals(tempString.Substring((tempString.IndexOf(",") + 1), 10))) Then 'Then this line did not work
                'If (DateString.Equals(tempString.Substring(0, 10))) Then ' using 3 as it is the index after ,
                fileData.Add(tempString)
            End If
            tempString = inStream.ReadLine
        End While
        inStream.Close()

        Return fileData

    End Function

    Public Function intializeFile()
        'all files are stored in the users documents folder
        filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\" + name + ".txt"
        output = New StreamWriter(filename, True)
        output.Close()

        Return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

    End Function

    Public Sub writeData(input As String)
        ' writes to file with a string begining on a new line with the record number
        output = New StreamWriter(filename, True)
        output.WriteLine(CStr(recordNumber) + "," + input)

        output.Close()
        recordNumber = recordNumber + 1

    End Sub



End Class
