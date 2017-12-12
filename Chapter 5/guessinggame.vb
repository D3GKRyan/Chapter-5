Public Class guessinggame
    Dim Counter As Integer

    Dim CompGen As Integer
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim userGuess As Integer
        userGuess = CInt(txtInput.Text)
        Counter = Counter + 1
        Try
            If userGuess = CompGen Then
                MessageBox.Show("cheater! you got it. It took you " + Counter.ToString + " tries to guess the number.")
            ElseIf userGuess < CompGen Then
                MessageBox.Show("Your Number is too freaking low you scrub lord.")
            ElseIf userGuess > CompGen Then
                MessageBox.Show("Your number is too freaking high you scrub lord.")
            End If
        Catch ex As Exception
            MessageBox.Show("You are dumb. Enter a number.")
        End Try
    End Sub

    Private Sub guessinggame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Number As New Random
        CompGen = Number.Next(100) + 1
        Counter = 0
        txtInput.Text = ("")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class