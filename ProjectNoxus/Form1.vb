Public Class Form1

    Private Sub Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start.Click
        Form2.Show()
    End Sub

    Sub PlayLoopingBackgroundSoundResource()
        My.Computer.Audio.Play(My.Resources.FIFASong, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        PlayLoopingBackgroundSoundResource()
    End Sub

    Private Sub AboutUs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUs.Click
        Form4.Show()
    End Sub
End Class
