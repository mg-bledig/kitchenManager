' kitchen Manager - MG Bledig 24/03/2021

Public Class Form2
    Private WithEvents tm As New Timer
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Countdown timer done!"

        tm.Interval = 60000
        tm.Start()

    End Sub

    Private Sub tm_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tm.Tick
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        ' tm.Stop()
        Close()
    End Sub
End Class
