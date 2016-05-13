Public Class Form4

    Private Sub Calculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calculate.Click
        Dim Zero, Troll As Integer
        Try
            Troll = Val(Four.Text) / Zero
        Catch Zer0 As System.OverflowException
            NotZero.Visible = True
            Result.Visible = True
        End Try
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class