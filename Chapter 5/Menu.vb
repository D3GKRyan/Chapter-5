Public Class Menu

    Private Sub btnCoinFlip_Click(sender As Object, e As EventArgs) Handles btnCoinFlip.Click
        Dim box = New coinFlip()
        box.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim box = New rockpaperscissors()
        box.Show()
    End Sub

    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim box = New race_cars()
        box.Show()
    End Sub

    Private Sub btnSpeed_Click(sender As Object, e As EventArgs) Handles btnSpeed.Click
        Dim box = New speed()
        box.Show()

    End Sub

    Private Sub btnguessinggame_Click(sender As Object, e As EventArgs) Handles btnguessinggame.Click
        Dim box = New guessinggame()
        box.Show()

    End Sub

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Dim box = New population()
        box.Show()
    End Sub
End Class