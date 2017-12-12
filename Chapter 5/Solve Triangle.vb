Public Class Solve_Triangle


    Sub calcSideC(ByVal Aside As Double, ByVal Bside As Double)
        Dim Cside As Double
        Cside = Math.Sqrt(Aside * Aside + Bside * Bside)
        txtC.Text = Cside.ToString
    End Sub


    Sub calcSideA(ByVal Bside As Double, ByVal Cside As Double)
        Dim Aside As Double
        Aside = Math.Sqrt(Cside * Cside - Bside * Bside)
        txtA.Text = Aside.ToString
    End Sub


    Sub calcSideB(ByVal Aside As Double, ByVal Cside As Double)
        Dim Bside As Double
        Aside = Math.Sqrt(Cside * Cside - Aside * Aside)
        txtB.Text = Bside.ToString
    End Sub


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If radc.Checked = True Then
            calcSideC(CDbl(txtA.Text), CDbl(txtB.Text))
        End If

        If radb.Checked = True Then
            calcSideB(CDbl(txtC.Text), CDbl(txtA.Text))
        End If

        If rada.Checked = True Then
            calcSideA(CDbl(txtC.Text), CDbl(txtB.Text))
        End If
    End Sub
End Class