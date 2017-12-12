Public Class Form1


    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Const intNUM_DAYS As Integer = 5 ' The number of days
        Dim intCount As Integer = 1      ' Loop Counter
        Dim decSales As Decimal = 0      ' To hold daily sales
        Dim decTotal As Decimal = 0      ' To hold the total sales
        Dim strInput As String           ' To hold string input

        ' Get the sales for each day.
        Do While intCount <= intNUM_DAYS
            ' Get a adaily sales amount from the user.
            strInput = InputBox("Enter the sales for day " & intCount.ToString())

            'Convert the input to a Decimal.
            If Decimal.TryParse(strInput, decSales) Then
                ' Add the daily sales to the total sales.
                decTotal += decSales

                ' Add 1 to the loop counter.
                intCount += 1
            Else
                'Display an error message for invalid input.
                MessageBox.Show("Enter a number value you dummy.")
            End If
        Loop

        ' Display the total sales.
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
