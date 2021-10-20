' kitchen Manager - MG Bledig 24/03/2021

Public Class Form1
    Public flgUp As Boolean = False ' to tell pause the count up timer must be paused/re-started
    Public flgDown As Boolean = False ' to tell pause the count down timer must be paused/re-started

    Dim StartTime As DateTime 'old current time
    Dim PauseTime As DateTime 'keep track of the time when the timer is paused
    Dim TotalTimePaused As TimeSpan 'The total amount of time paused

    ' These two variables will be responsible for calculating the time left on our little "alarm clock."
    Private timeEnd As DateTime
    Private timeDiff As TimeSpan ' Calculates the exact ending time
    Private CompTime As System.Int32


    Private Sub btnCountUp_Click(sender As Object, e As EventArgs) Handles btnCountUp.Click
        flgUp = True ' So pause knows to pause/re-start counting up timer
        DisableButtons()
        HideLabels()
        HideInput()
        btnPause.Enabled = True ' Enable the pause button
        btnPause.Visible = True ' Show pause button

        StartTime = DateTime.Now() ' Remember the start time
        TProgressBar1.Visible = False ' Hide the progress bar
        Timer2.Start()
        My.Computer.Audio.Play(My.Resources.beep_07, AudioPlayMode.WaitToComplete) ' Sound a beep to signal the start of timer
        TLabel1.Text = "Timer in progress..."
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        ' Subtract the current "Now" time from the start time
        ' and then subtract the total time paused
        Dim ElapsedTime As TimeSpan = DateAndTime.Now.Subtract(StartTime).Subtract(TotalTimePaused)
        ' Add this to the code if you want to show milliseconds + "." + ElapsedTime.Milliseconds.ToString.PadLeft(3, "0"c) see commented out sample below
        ' lblDuration.Text = ElapsedTime.Hours.ToString.PadLeft(2, "0"c) + ":" + ElapsedTime.Minutes.ToString.PadLeft(2, "0"c) + ":" + ElapsedTime.Seconds.ToString.PadLeft(2, "0"c) + "." + ElapsedTime.Milliseconds.ToString.PadLeft(3, "0"c)

        If (timeDiff.Ticks < 0) Then
            lblDuration.Text = ElapsedTime.Hours.ToString.PadLeft(2, "0"c) + ":" + ElapsedTime.Minutes.ToString.PadLeft(2, "0"c) + ":" + ElapsedTime.Seconds.ToString.PadLeft(2, "0"c) + " " + "over"
        Else
            lblDuration.Text = ElapsedTime.Hours.ToString.PadLeft(2, "0"c) + ":" + ElapsedTime.Minutes.ToString.PadLeft(2, "0"c) + ":" + ElapsedTime.Seconds.ToString.PadLeft(2, "0"c)
        End If
    End Sub

    Private Sub btnCountDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCountDown.Click
        flgDown = True ' We are counting down, so rase the counting down flag so the pause button knows to pause count down timer
        HideLabels()
        HideInput()
        DisableButtons()

        btnPause.Visible = True ' Show the pause button
        btnPause.Enabled = True ' Enable the pause button

        timeEnd = DateTime.Now ' This initializes the timeEnd variable, not the actual ending time!

        Dim hour As Double = System.Convert.ToDouble(nudHour.Value)
        Dim minute As Double = System.Convert.ToDouble(nudMinute.Value)
        Dim second As Double = System.Convert.ToDouble(nudSecond.Value)

        timeEnd = timeEnd.AddHours(hour)
        timeEnd = timeEnd.AddMinutes(minute)
        timeEnd = timeEnd.AddSeconds(second)

        Dim TotSecs As Double = System.Convert.ToDouble(hour * 3600 + minute * 60 + second) ' Convert time values entered into seconds

        TProgressBar1.Value = 0 ' Make sure TProgressBar1.Value starts at zero
        TProgressBar1.Maximum = TotSecs ' Calabrate progress bar percentage to match time value entered by user
        TProgressBar1.Visible = True

        Timer1.Start()

        My.Computer.Audio.Play(My.Resources.beep_07, AudioPlayMode.WaitToComplete) ' Sound a beep to signal the start of timer
        TLabel1.Text = "Timer in progress..."
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' Count down timer

        ' Dim voice = CreateObject("SAPI.spvoice") ' Create a voice object for announcing remaining time

        ' Dim percentageDone As Integer ' used to keep track of percentage done for voicing purposes

        timeDiff = timeEnd + TotalTimePaused - DateTime.Now ' timeDiff calculates the exact ending time by subtracting the current time value with the TimeEnd object created earlier

        ' formats the current time value and displays it inside the txtRemaining textbox
        Dim output As TimeSpan = New TimeSpan(timeDiff.Hours, timeDiff.Minutes, timeDiff.Seconds)
        txtRemaining.Text = output.ToString

        TProgressBar1.PerformStep() ' increment progressbar

        ' calculate the percentage done by the progress bar
        ' percentageDone = ((TProgressBar1.Value / TProgressBar1.Maximum) * 100)

        ' If percentageDone = 49% Then ' Announce it
        ' voice.speak(timeDiff.Minutes & "Minutes remaining")
        ' End If

        If (timeDiff.Ticks < 0) Then
            Timer1.Stop()
            flgDown = False ' Set flag to false because timer is done
            TLabel1.Text = "TIME IS UP!"
            My.Computer.Audio.Play(My.Resources.Alarm, AudioPlayMode.BackgroundLoop)

            StartTime = DateTime.Now() ' Remember the start time

            flgUp = True ' because counting up timer is carrying on timing
            Timer2.Start()

            Using frm2 = New Form2
                If frm2.ShowDialog() = DialogResult.OK Then
                    Timer2.Stop() ' Stop count up timer
                    My.Computer.Audio.Stop() ' The alarm
                    ShowLabels()
                    ShowInput()

                    txtRemaining.Text = String.Empty
                    lblDuration.Text = "                    "
                    TLabel1.Text = "Ready"
                    TLabel1.ForeColor = Color.Black

                    inableButtons()
                    btnReset.Visible = True ' Show reset so user can reset fields to 0 if needed
                    btnPause.Visible = False ' Nothing to pause, so hide
                    btnCountDown.Text = "Repeat" ' For if user wants to repeat then just click on repeat
                    nudHour.Select()
                Else
                    My.Computer.Audio.Stop() ' The alarm
                End If
            End Using
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "MGB Kitchen Manager - Version 1.0"

        Timer3.Enabled = True

        ' Keep window always on top
        ' Me.TopMost = True

        btnPause.Visible = False

        ' The countdown will start from whatever values the user enters in the countdown timer

        TProgressBar1.Visible = False ' Don't show the progress bar until the timer starts
        Initialise_Fields()

        nudHour.Select()
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        If flgUp Then ' Count up timer is active
            If Timer2.Enabled = False Then
                btnPause.Text = "Pause"
                btnPause.Image = My.Resources.Button_Pause
                TLabel1.Text = "Timer in progress..."
                TLabel1.ForeColor = Color.Black
                btnReset.Visible = False
                My.Computer.Audio.Play(My.Resources.beep_07, AudioPlayMode.WaitToComplete) ' Sound a beep to signal the start of timer
                TotalTimePaused = TotalTimePaused.Add(DateAndTime.Now.Subtract(PauseTime))
                Timer2.Enabled = True
            Else
                My.Computer.Audio.Play(My.Resources.beep_07, AudioPlayMode.WaitToComplete) ' Sound a beep to signal the start of timer
                btnPause.Text = "Resume"
                btnPause.Image = My.Resources.Button_Play
                TLabel1.Text = "Timer paused"
                TLabel1.ForeColor = Color.Red
                btnReset.Visible = True

                Timer2.Enabled = False
                PauseTime = DateAndTime.Now
            End If

            ' We counting down
        ElseIf flgDown Then
            If Timer1.Enabled = False Then
                btnPause.Text = "Pause"
                btnPause.Image = My.Resources.Button_Pause
                TLabel1.Text = "Timer paused"
                TLabel1.ForeColor = Color.Red
                btnReset.Visible = False
                My.Computer.Audio.Play(My.Resources.beep_07, AudioPlayMode.WaitToComplete) ' Sound a beep to signal the start of timer
                TotalTimePaused = TotalTimePaused.Add(DateAndTime.Now.Subtract(PauseTime))
                TLabel1.Text = "Timer in progress..."
                TLabel1.ForeColor = Color.Black
                Timer1.Enabled = True
            Else
                My.Computer.Audio.Play(My.Resources.beep_07, AudioPlayMode.WaitToComplete) ' Sound a beep to signal the start of timer
                btnPause.Text = "Resume"
                btnPause.Image = My.Resources.Button_Play
                btnReset.Visible = True
                TLabel1.Text = "Timer paused"
                TLabel1.ForeColor = Color.Red
                Timer1.Enabled = False
                PauseTime = DateAndTime.Now
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Timer1.Stop()
        Timer2.Stop()
        StartTime = Nothing
        timeEnd = Nothing
        timeDiff = Nothing
        PauseTime = Nothing
        TotalTimePaused = Nothing
        TProgressBar1.Visible = False ' Hide the progress bar
        TProgressBar1.Value = 0 ' Set it back to it's default value
        Timer1.Enabled = False
        Timer2.Enabled = False
        flgUp = False
        flgDown = False ' Set flag to false because timer is done
        btnCountDown.Text = "Count down"
        btnPause.Text = "Pause"
        btnPause.Image = My.Resources.Button_Pause
        ShowLabels()
        Initialise_Fields()
        inableButtons()

        nudHour.Visible = True
        nudMinute.Visible = True
        nudSecond.Visible = True

        nudHour.Value = 0
        nudMinute.Value = 0
        nudSecond.Value = 0
        nudHour.Select()
        My.Computer.Audio.Play(My.Resources.beep_07, AudioPlayMode.WaitToComplete) ' Sound a beep to signal the start of timer
    End Sub

    Private Sub Initialise_Fields()
        txtRemaining.Text = String.Empty
        lblDuration.Text = "                    "
        TLabel1.Text = "Ready"
        TLabel1.ForeColor = Color.Black
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub DisableButtons()
        btnCountUp.Visible = False
        btnCountDown.Visible = False
        btnReset.Visible = False
    End Sub

    Private Sub inableButtons()
        btnCountUp.Visible = True
        btnCountDown.Visible = True
        btnPause.Visible = False
    End Sub

    Private Sub HideLabels()
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
    End Sub

    Private Sub ShowLabels()
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
    End Sub

    Private Sub HideInput()
        nudHour.Visible = False
        nudMinute.Visible = False
        nudSecond.Visible = False
    End Sub

    Private Sub ShowInput()
        nudHour.Visible = True
        nudMinute.Visible = True
        nudSecond.Visible = True
    End Sub

    Private Sub Timer3_Tick_(sender As Object, e As EventArgs) Handles Timer3.Tick
        ' For showing the current time

        tssCurtime.Text = TimeOfDay
    End Sub
End Class
