Public Class rockpaperscissors

    Dim intObject As Integer   '   To indicate which side is up
    Dim rand As New Random
    Dim totalWins As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRock.Click


        intObject = rand.Next(3)

        If intObject = 0 Then
            lblPhrase.Text = "Draw!"
        ElseIf intObject = 1 Then
            lblPhrase.Text = "You lost!"
        ElseIf intObject = 2 Then
            lblPhrase.Text = "You win!"
            totalWins += 1
        End If
        lblWins.Text = totalWins
    End Sub

    Private Sub btnPaper_Click(sender As Object, e As EventArgs) Handles btnPaper.Click
        intObject = rand.Next(3)

        If intObject = 0 Then
            lblPhrase.Text = "You win!"
            totalWins += 1
        ElseIf intObject = 1 Then
            lblPhrase.Text = "Draw!"
        ElseIf intObject = 2 Then
            lblPhrase.Text = "You lose!"
        End If
        lblWins.Text = totalWins
    End Sub

    Private Sub btnScissors_Click(sender As Object, e As EventArgs) Handles btnScissors.Click
        intObject = rand.Next(3)

        If intObject = 0 Then
            lblPhrase.Text = "You lose!"
        ElseIf intObject = 1 Then
            lblPhrase.Text = "You win!"
            totalWins += 1
        ElseIf intObject = 2 Then
            lblPhrase.Text = "Draw!"
        End If
        lblWins.Text = totalWins
    End Sub
End Class