﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RoadMover = New System.Windows.Forms.Timer(Me.components)
        Me.Car = New System.Windows.Forms.PictureBox()
        Me.Left_mover = New System.Windows.Forms.Timer(Me.components)
        Me.Right_mover = New System.Windows.Forms.Timer(Me.components)
        Me.EnemyCar1 = New System.Windows.Forms.PictureBox()
        Me.EnemyCar2 = New System.Windows.Forms.PictureBox()
        Me.EnemyCar3 = New System.Windows.Forms.PictureBox()
        Me.Enemy1_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy2_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy3_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.End_Text = New System.Windows.Forms.Label()
        Me.Score_text = New System.Windows.Forms.Label()
        Me.Replay_Button = New System.Windows.Forms.Button()
        Me.Speed_Text = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(113, -24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 152)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(113, 171)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 152)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Location = New System.Drawing.Point(113, 358)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 152)
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Location = New System.Drawing.Point(113, 555)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(16, 152)
        Me.PictureBox7.TabIndex = 3
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.White
        Me.PictureBox8.Location = New System.Drawing.Point(333, 555)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(16, 152)
        Me.PictureBox8.TabIndex = 7
        Me.PictureBox8.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Location = New System.Drawing.Point(333, 358)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(16, 152)
        Me.PictureBox6.TabIndex = 6
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Location = New System.Drawing.Point(333, 171)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 152)
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(333, -24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 152)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'RoadMover
        '
        Me.RoadMover.Enabled = True
        Me.RoadMover.Interval = 10
        '
        'Car
        '
        Me.Car.Image = CType(resources.GetObject("Car.Image"), System.Drawing.Image)
        Me.Car.Location = New System.Drawing.Point(203, 490)
        Me.Car.Name = "Car"
        Me.Car.Size = New System.Drawing.Size(44, 81)
        Me.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Car.TabIndex = 8
        Me.Car.TabStop = False
        '
        'Left_mover
        '
        Me.Left_mover.Interval = 10
        '
        'Right_mover
        '
        Me.Right_mover.Interval = 10
        '
        'EnemyCar1
        '
        Me.EnemyCar1.Image = CType(resources.GetObject("EnemyCar1.Image"), System.Drawing.Image)
        Me.EnemyCar1.Location = New System.Drawing.Point(2, 218)
        Me.EnemyCar1.Name = "EnemyCar1"
        Me.EnemyCar1.Size = New System.Drawing.Size(44, 86)
        Me.EnemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar1.TabIndex = 9
        Me.EnemyCar1.TabStop = False
        '
        'EnemyCar2
        '
        Me.EnemyCar2.Image = CType(resources.GetObject("EnemyCar2.Image"), System.Drawing.Image)
        Me.EnemyCar2.Location = New System.Drawing.Point(343, 9)
        Me.EnemyCar2.Name = "EnemyCar2"
        Me.EnemyCar2.Size = New System.Drawing.Size(44, 86)
        Me.EnemyCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar2.TabIndex = 9
        Me.EnemyCar2.TabStop = False
        '
        'EnemyCar3
        '
        Me.EnemyCar3.Image = CType(resources.GetObject("EnemyCar3.Image"), System.Drawing.Image)
        Me.EnemyCar3.Location = New System.Drawing.Point(133, 84)
        Me.EnemyCar3.Name = "EnemyCar3"
        Me.EnemyCar3.Size = New System.Drawing.Size(44, 84)
        Me.EnemyCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar3.TabIndex = 9
        Me.EnemyCar3.TabStop = False
        '
        'Enemy1_Mover
        '
        Me.Enemy1_Mover.Enabled = True
        Me.Enemy1_Mover.Interval = 10
        '
        'Enemy2_Mover
        '
        Me.Enemy2_Mover.Enabled = True
        Me.Enemy2_Mover.Interval = 10
        '
        'Enemy3_Mover
        '
        Me.Enemy3_Mover.Enabled = True
        Me.Enemy3_Mover.Interval = 10
        '
        'End_Text
        '
        Me.End_Text.AutoSize = True
        Me.End_Text.BackColor = System.Drawing.Color.Snow
        Me.End_Text.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.End_Text.ForeColor = System.Drawing.Color.Red
        Me.End_Text.Location = New System.Drawing.Point(133, 171)
        Me.End_Text.Name = "End_Text"
        Me.End_Text.Size = New System.Drawing.Size(216, 45)
        Me.End_Text.TabIndex = 10
        Me.End_Text.Text = "GAME OVER!"
        Me.End_Text.Visible = False
        '
        'Score_text
        '
        Me.Score_text.AutoSize = True
        Me.Score_text.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Score_text.ForeColor = System.Drawing.Color.Gold
        Me.Score_text.Location = New System.Drawing.Point(12, 9)
        Me.Score_text.Name = "Score_text"
        Me.Score_text.Size = New System.Drawing.Size(78, 25)
        Me.Score_text.TabIndex = 11
        Me.Score_text.Text = "Score 0"
        '
        'Replay_Button
        '
        Me.Replay_Button.BackColor = System.Drawing.Color.Peru
        Me.Replay_Button.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Replay_Button.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Replay_Button.Location = New System.Drawing.Point(162, 251)
        Me.Replay_Button.Name = "Replay_Button"
        Me.Replay_Button.Size = New System.Drawing.Size(132, 53)
        Me.Replay_Button.TabIndex = 12
        Me.Replay_Button.Text = "Replay"
        Me.Replay_Button.UseVisualStyleBackColor = False
        Me.Replay_Button.Visible = False
        '
        'Speed_Text
        '
        Me.Speed_Text.AutoSize = True
        Me.Speed_Text.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Speed_Text.ForeColor = System.Drawing.Color.Gold
        Me.Speed_Text.Location = New System.Drawing.Point(374, 9)
        Me.Speed_Text.Name = "Speed_Text"
        Me.Speed_Text.Size = New System.Drawing.Size(83, 25)
        Me.Speed_Text.TabIndex = 11
        Me.Speed_Text.Text = "Speed 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(464, 601)
        Me.Controls.Add(Me.Replay_Button)
        Me.Controls.Add(Me.Speed_Text)
        Me.Controls.Add(Me.Score_text)
        Me.Controls.Add(Me.End_Text)
        Me.Controls.Add(Me.EnemyCar3)
        Me.Controls.Add(Me.EnemyCar2)
        Me.Controls.Add(Me.EnemyCar1)
        Me.Controls.Add(Me.Car)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(480, 640)
        Me.MinimumSize = New System.Drawing.Size(480, 640)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RoadMover As Timer
    Friend WithEvents Car As PictureBox
    Friend WithEvents Left_mover As Timer
    Friend WithEvents Right_mover As Timer
    Friend WithEvents EnemyCar1 As PictureBox
    Friend WithEvents EnemyCar2 As PictureBox
    Friend WithEvents EnemyCar3 As PictureBox
    Friend WithEvents Enemy1_Mover As Timer
    Friend WithEvents Enemy2_Mover As Timer
    Friend WithEvents Enemy3_Mover As Timer
    Friend WithEvents End_Text As Label
    Friend WithEvents Score_text As Label
    Friend WithEvents Replay_Button As Button
    Friend WithEvents Speed_Text As Label
End Class
