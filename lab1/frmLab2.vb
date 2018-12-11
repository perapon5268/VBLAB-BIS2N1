Public Class frmLab2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Acer As Double
        Dim Hp As Double

        Dim misAcer As Double
        Dim misHp As Double

        Dim total As Double
        Dim totalSum As Double

        Acer = Val(txtAcer.Text)
        Hp = Val(txtHP.Text)
        total = Acer + Hp

        misAcer = Acer * 0.05
        misHp = Hp * 0.1
        totalSum = misAcer + misHp

        lblsum.Text = total
        lblMistionA.Text = misAcer
        lblMistionB.Text = misHp
        lblTotalSum.Text = totalSum
    End Sub
End Class