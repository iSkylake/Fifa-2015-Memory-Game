Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ScoreMin.Text = Form2.Minute.Text
        ScoreSec.Text = Form2.Second.Text
        ScorePoint.Text = Form2.Point.Text
    End Sub
End Class