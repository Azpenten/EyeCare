Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("C:\Users\Player\source\repos\EyeCare\Notify.wav", AudioPlayMode.Background)
        Me.TopMost = True
    End Sub
End Class