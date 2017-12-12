Public Class coinFlip
    Dim totalHead As Integer
    Dim totalTail As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intSideUp As Integer   '   To indicate which side is up
        Dim rand As New Random      '   Random number generator.



        'Get a random number is the range of 0 through 1.
        '0 means tails up and 1 means heads up.

        intSideUp = rand.Next(2)

        'Display the side that is up
        If intSideUp = 0 Then
            ' 0 means tails is up, so display the tails
            ' image and hide the heads image.
            picTail.Visible = True
            picHead.Visible = False
            totalTail = totalTail + 1
        Else
            ' 1 means heads is up, so display the heads
            ' image and hide the tails image.
            picHead.Visible = True
            picTail.Visible = False
            totalHead = totalHead + 1


        End If
        lblHeads.Text = totalHead
        lblTails.Text = totalTail

    End Sub

End Class