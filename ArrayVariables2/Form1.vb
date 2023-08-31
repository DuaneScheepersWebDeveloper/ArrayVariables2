Public Class Form1
    Dim aiData(4) As String
    Dim i As Integer
    Dim itotal As Double

    Private Sub InitializeData()
        ' Initialize aiData array
        aiData(0) = "5"
        aiData(1) = "7"
        aiData(2) = "33"
        aiData(3) = "22"
        aiData(4) = "8"
    End Sub

    'Calculates the total of aiData

    Private Sub CalculateTotal()
        itotal = 0

        For i = 0 To 4
            itotal += Double.Parse(aiData(i))
        Next
    End Sub

    'Calculates the total of all the items in aiData if they are greater than 20
    Private Function SumItemsGreaterThan20() As Double
        Dim sumGreaterThan20 As Double = 0

        For i = 0 To 4
            Dim value As Double
            If Double.TryParse(aiData(i), value) AndAlso value > 20 Then
                sumGreaterThan20 += value
            End If
        Next

        Return sumGreaterThan20
    End Function

    'Finds the largest number of aiData
    Private Function FindLargestItem() As Double
        Dim largest As Double = Double.MinValue ' Initialize to the smallest possible value

        For i = 0 To 4
            Dim value As Double
            If Double.TryParse(aiData(i), value) Then
                If value > largest Then
                    largest = value
                End If
            End If
        Next

        Return largest
    End Function

    'Finds the smallest number of aiData
    Private Function FindSmallestItem() As Double
        Dim smallest As Double = Double.MaxValue ' Initialize to the largest possible value

        For i = 0 To 4
            Dim value As Double
            If Double.TryParse(aiData(i), value) Then
                If value < smallest Then
                    smallest = value
                End If
            End If
        Next

        Return smallest
    End Function

    'Doubles the value with the array
    Private Sub DoubleArrayValues()
        For i = 0 To 4
            Dim value As Double
            If Double.TryParse(aiData(i), value) Then
                aiData(i) = (value * 2).ToString() ' Double the value and update the array element
            End If
        Next
    End Sub

    Public Sub btnEx1_Click(sender As Object, e As EventArgs) Handles btnEx1.Click
        'Output each item in a separate message box one after another
        InitializeData()

        For i = 0 To 4
            MsgBox("Output each item in a separate message box one after another" + Environment.NewLine + "Output:" + aiData(i))
        Next
    End Sub

    Private Sub btnEx2_Click(sender As Object, e As EventArgs) Handles btnEx2.Click
        'Output all of the items in the same message box on separate lines.
        InitializeData()
        Dim output As String = ""

        For i = 0 To 4
            output += aiData(i) + Environment.NewLine
        Next

        MsgBox("Output all of the items in the same message box on separate lines." + Environment.NewLine + "Output:" + output)

    End Sub

    Private Sub btnEx3_Click(sender As Object, e As EventArgs) Handles btnEx3.Click
        'Add up all of the items then output it in a message box
        'Add up all of the items then output it in a message box
        InitializeData()
        CalculateTotal()

        MsgBox("Add up all of the items then output it in a message box" + Environment.NewLine + "Output: " + itotal.ToString())
    End Sub

    Private Sub btnEx4_Click(sender As Object, e As EventArgs) Handles btnEx4.Click
        'Calculate the average of the items then output it in a message box
        InitializeData()
        Dim average As Double

        If aiData.Length > 0 Then
            average = itotal / aiData.Length
            MsgBox("Calculate the average of the items then output it in a message box" + Environment.NewLine + "Average: " + average.ToString())
        Else
            MsgBox("Array is empty.")
        End If
    End Sub

    Private Sub btnEx5_Click(sender As Object, e As EventArgs) Handles btnEx5.Click
        'Add up the items greater than 20 then output the result in a message box.
        InitializeData()
        Dim sumGreaterThan20 As Double = SumItemsGreaterThan20()
        MsgBox("Add up the items greater than 20 then output the result in a message box." + Environment.NewLine + "Sum: " + sumGreaterThan20.ToString())

    End Sub

    Private Sub btnEx6_Click(sender As Object, e As EventArgs) Handles btnEx6.Click
        'Find the largest item then output it in a message box
        InitializeData()
        Dim largestItem As Double = FindLargestItem()

        MsgBox("Find the largest item then output it in a message box" + Environment.NewLine + "Largest Item: " + largestItem.ToString())

    End Sub

    Private Sub btnEx7_Click(sender As Object, e As EventArgs) Handles btnEx7.Click
        'Find the smallest item then output it in a message box
        InitializeData()
        Dim smallestItem As Double = FindSmallestItem()

        MsgBox("Find the smallest item then output it in a message box" + Environment.NewLine + "Smallest Item: " + smallestItem.ToString())

    End Sub

    Private Sub btnEx8_Click(sender As Object, e As EventArgs) Handles btnEx8.Click
        'Replace each item in the array with a new value that is twice as big then output the new values
        InitializeData()
        DoubleArrayValues()

        Dim output As String = "New Values:" + Environment.NewLine
        For i = 0 To 4
            output += aiData(i) + Environment.NewLine
        Next

        MsgBox("Replace each item in the array with a new value that is twice as big then output the new values." + Environment.NewLine + output)
    End Sub
End Class
