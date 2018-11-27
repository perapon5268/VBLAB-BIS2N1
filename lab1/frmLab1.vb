Public Class Form1
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        lblYear.Text = Val(txtSalary.Text) * 12
        lblResult.Text = (txtSalary.Text * 12) * 5 / 100
        lblTotal.Text = lblYear.Text - lblResult.Text

    End Sub


End Class
