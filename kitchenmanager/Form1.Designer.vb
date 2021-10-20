<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtRemaining = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tBar1 = New System.Windows.Forms.ToolStrip()
        Me.btnCountDown = New System.Windows.Forms.ToolStripButton()
        Me.btnCountUp = New System.Windows.Forms.ToolStripButton()
        Me.btnPause = New System.Windows.Forms.ToolStripButton()
        Me.btnReset = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.tssLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssCurtime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.nudHour = New System.Windows.Forms.NumericUpDown()
        Me.nudMinute = New System.Windows.Forms.NumericUpDown()
        Me.nudSecond = New System.Windows.Forms.NumericUpDown()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.tBar1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.nudHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSecond, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'txtRemaining
        '
        Me.txtRemaining.BackColor = System.Drawing.Color.Black
        Me.txtRemaining.Font = New System.Drawing.Font("Lucida Console", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemaining.ForeColor = System.Drawing.Color.Lime
        Me.txtRemaining.Location = New System.Drawing.Point(15, 89)
        Me.txtRemaining.Name = "txtRemaining"
        Me.txtRemaining.ReadOnly = True
        Me.txtRemaining.Size = New System.Drawing.Size(241, 55)
        Me.txtRemaining.TabIndex = 4
        Me.txtRemaining.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(12, 156)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(0, 13)
        Me.lblDuration.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Hour"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Minute"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Second"
        '
        'tBar1
        '
        Me.tBar1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.tBar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCountDown, Me.btnCountUp, Me.btnPause, Me.btnReset, Me.btnExit})
        Me.tBar1.Location = New System.Drawing.Point(0, 0)
        Me.tBar1.Name = "tBar1"
        Me.tBar1.Size = New System.Drawing.Size(390, 37)
        Me.tBar1.TabIndex = 0
        Me.tBar1.TabStop = True
        '
        'btnCountDown
        '
        Me.btnCountDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCountDown.Image = Global.KitchenManager.My.Resources.Resources.down_multi_size
        Me.btnCountDown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCountDown.Name = "btnCountDown"
        Me.btnCountDown.Size = New System.Drawing.Size(34, 34)
        Me.btnCountDown.Text = "Count down"
        '
        'btnCountUp
        '
        Me.btnCountUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCountUp.Image = Global.KitchenManager.My.Resources.Resources.up_multi_size
        Me.btnCountUp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCountUp.Name = "btnCountUp"
        Me.btnCountUp.Size = New System.Drawing.Size(34, 34)
        Me.btnCountUp.Text = "Count up"
        '
        'btnPause
        '
        Me.btnPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPause.Image = Global.KitchenManager.My.Resources.Resources.Button_Pause
        Me.btnPause.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(34, 34)
        Me.btnPause.Text = "Pause"
        '
        'btnReset
        '
        Me.btnReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnReset.Image = Global.KitchenManager.My.Resources.Resources.Everaldo_Crystal_Clear_App_Quick_restart
        Me.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(34, 34)
        Me.btnReset.Text = "Reset"
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.Image = Global.KitchenManager.My.Resources.Resources.exit_multi_size
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(34, 34)
        Me.btnExit.Text = "Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TLabel1, Me.TProgressBar1, Me.tssLabel1, Me.tssCurtime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 191)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(390, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TLabel1
        '
        Me.TLabel1.AutoSize = False
        Me.TLabel1.Name = "TLabel1"
        Me.TLabel1.Size = New System.Drawing.Size(191, 17)
        Me.TLabel1.Spring = True
        Me.TLabel1.Text = "Ready"
        Me.TLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TProgressBar1
        '
        Me.TProgressBar1.Name = "TProgressBar1"
        Me.TProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.TProgressBar1.Step = 1
        '
        'tssLabel1
        '
        Me.tssLabel1.Name = "tssLabel1"
        Me.tssLabel1.Size = New System.Drawing.Size(82, 17)
        Me.tssLabel1.Text = "Current Time: "
        '
        'tssCurtime
        '
        Me.tssCurtime.Name = "tssCurtime"
        Me.tssCurtime.Size = New System.Drawing.Size(0, 17)
        '
        'nudHour
        '
        Me.nudHour.AccessibleDescription = "Hour"
        Me.nudHour.Location = New System.Drawing.Point(12, 65)
        Me.nudHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.nudHour.Name = "nudHour"
        Me.nudHour.Size = New System.Drawing.Size(100, 20)
        Me.nudHour.TabIndex = 1
        '
        'nudMinute
        '
        Me.nudMinute.AccessibleDescription = "Minute"
        Me.nudMinute.Location = New System.Drawing.Point(118, 65)
        Me.nudMinute.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudMinute.Name = "nudMinute"
        Me.nudMinute.Size = New System.Drawing.Size(100, 20)
        Me.nudMinute.TabIndex = 2
        '
        'nudSecond
        '
        Me.nudSecond.AccessibleDescription = "Second"
        Me.nudSecond.Location = New System.Drawing.Point(224, 65)
        Me.nudSecond.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudSecond.Name = "nudSecond"
        Me.nudSecond.Size = New System.Drawing.Size(100, 20)
        Me.nudSecond.TabIndex = 3
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 213)
        Me.Controls.Add(Me.nudSecond)
        Me.Controls.Add(Me.nudMinute)
        Me.Controls.Add(Me.nudHour)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.txtRemaining)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.tBar1.ResumeLayout(False)
        Me.tBar1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.nudHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSecond, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtRemaining As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblDuration As System.Windows.Forms.Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tBar1 As ToolStrip
    Friend WithEvents btnCountUp As ToolStripButton
    Friend WithEvents btnCountDown As ToolStripButton
    Friend WithEvents btnPause As ToolStripButton
    Friend WithEvents btnReset As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TLabel1 As ToolStripStatusLabel
    Friend WithEvents TProgressBar1 As ToolStripProgressBar
    Friend WithEvents nudHour As NumericUpDown
    Friend WithEvents nudMinute As NumericUpDown
    Friend WithEvents nudSecond As NumericUpDown
    Friend WithEvents tssCurtime As ToolStripStatusLabel
    Friend WithEvents Timer3 As Timer
    Friend WithEvents tssLabel1 As ToolStripStatusLabel
End Class
