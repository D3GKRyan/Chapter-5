Public Class race_cars

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intCount1 As Integer
        Dim RAND As New Random

        For intCount1 = 16 To RAND.Next(300) + 300
            picCar1.Left = intCount1
        Next

        For intCount1 = 16 To RAND.Next(300) + 300
            PictureBox2.Left = intCount1
        Next

        For intCount1 = 16 To RAND.Next(300) + 300
            PictureBox3.Left = intCount1
        Next

        If picCar1.Left > PictureBox2.Left And PictureBox3.Left Then
            lblWinner.Text = "Lambo Wambo won the death defying race."
        ElseIf PictureBox2.Left > picCar1.Left And PictureBox3.Left Then
            lblWinner.Text = "The vroom vroom bam bam go kart won the death defying race."
        ElseIf PictureBox3.Left > picCar1.Left And PictureBox2.Left Then
            lblWinner.Text = "The perplexuous perfect pink pretty lambo wambo won the death defying race."
        End If
    End Sub
End Class