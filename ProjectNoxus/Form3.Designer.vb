<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ScoreBoard = New System.Windows.Forms.PictureBox
        Me.ScoreTitle = New System.Windows.Forms.Label
        Me.FifaScore = New System.Windows.Forms.Label
        Me.ScoreYear = New System.Windows.Forms.Label
        Me.ScorePoint = New System.Windows.Forms.Label
        Me.ScoreMin = New System.Windows.Forms.Label
        Me.ScoreSec = New System.Windows.Forms.Label
        Me.Logo = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.ScoreBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScoreBoard
        '
        Me.ScoreBoard.BackColor = System.Drawing.Color.White
        Me.ScoreBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ScoreBoard.Image = Global.WindowsApplication1.My.Resources.Resources.ScoreBoard
        Me.ScoreBoard.Location = New System.Drawing.Point(44, 109)
        Me.ScoreBoard.Name = "ScoreBoard"
        Me.ScoreBoard.Size = New System.Drawing.Size(434, 94)
        Me.ScoreBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ScoreBoard.TabIndex = 0
        Me.ScoreBoard.TabStop = False
        '
        'ScoreTitle
        '
        Me.ScoreTitle.AutoSize = True
        Me.ScoreTitle.BackColor = System.Drawing.Color.White
        Me.ScoreTitle.Font = New System.Drawing.Font("Wide Latin", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreTitle.Location = New System.Drawing.Point(50, 44)
        Me.ScoreTitle.Name = "ScoreTitle"
        Me.ScoreTitle.Size = New System.Drawing.Size(415, 36)
        Me.ScoreTitle.TabIndex = 1
        Me.ScoreTitle.Text = "SCOREBOARD"
        '
        'FifaScore
        '
        Me.FifaScore.AutoSize = True
        Me.FifaScore.BackColor = System.Drawing.Color.White
        Me.FifaScore.Font = New System.Drawing.Font("Wide Latin", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FifaScore.Location = New System.Drawing.Point(101, 157)
        Me.FifaScore.Name = "FifaScore"
        Me.FifaScore.Size = New System.Drawing.Size(71, 16)
        Me.FifaScore.TabIndex = 2
        Me.FifaScore.Text = "FIFA"
        '
        'ScoreYear
        '
        Me.ScoreYear.AutoSize = True
        Me.ScoreYear.BackColor = System.Drawing.Color.White
        Me.ScoreYear.Font = New System.Drawing.Font("Wide Latin", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreYear.ForeColor = System.Drawing.Color.Red
        Me.ScoreYear.Location = New System.Drawing.Point(353, 157)
        Me.ScoreYear.Name = "ScoreYear"
        Me.ScoreYear.Size = New System.Drawing.Size(67, 16)
        Me.ScoreYear.TabIndex = 3
        Me.ScoreYear.Text = "2014"
        '
        'ScorePoint
        '
        Me.ScorePoint.AutoSize = True
        Me.ScorePoint.BackColor = System.Drawing.Color.Blue
        Me.ScorePoint.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScorePoint.ForeColor = System.Drawing.Color.White
        Me.ScorePoint.Location = New System.Drawing.Point(231, 155)
        Me.ScorePoint.Name = "ScorePoint"
        Me.ScorePoint.Size = New System.Drawing.Size(27, 18)
        Me.ScorePoint.TabIndex = 4
        Me.ScorePoint.Text = "0"
        '
        'ScoreMin
        '
        Me.ScoreMin.AutoSize = True
        Me.ScoreMin.BackColor = System.Drawing.Color.Blue
        Me.ScoreMin.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreMin.ForeColor = System.Drawing.Color.White
        Me.ScoreMin.Location = New System.Drawing.Point(207, 124)
        Me.ScoreMin.Name = "ScoreMin"
        Me.ScoreMin.Size = New System.Drawing.Size(27, 18)
        Me.ScoreMin.TabIndex = 5
        Me.ScoreMin.Text = "0"
        '
        'ScoreSec
        '
        Me.ScoreSec.AutoSize = True
        Me.ScoreSec.BackColor = System.Drawing.Color.Blue
        Me.ScoreSec.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreSec.ForeColor = System.Drawing.Color.White
        Me.ScoreSec.Location = New System.Drawing.Point(282, 124)
        Me.ScoreSec.Name = "ScoreSec"
        Me.ScoreSec.Size = New System.Drawing.Size(27, 18)
        Me.ScoreSec.TabIndex = 6
        Me.ScoreSec.Text = "0"
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.Image = Global.WindowsApplication1.My.Resources.Resources.Logo
        Me.Logo.Location = New System.Drawing.Point(12, 269)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(90, 89)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 7
        Me.Logo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.FIFA_2014
        Me.PictureBox1.Location = New System.Drawing.Point(417, 243)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.FifaBack7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(524, 370)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.ScoreSec)
        Me.Controls.Add(Me.ScoreMin)
        Me.Controls.Add(Me.ScorePoint)
        Me.Controls.Add(Me.ScoreYear)
        Me.Controls.Add(Me.FifaScore)
        Me.Controls.Add(Me.ScoreTitle)
        Me.Controls.Add(Me.ScoreBoard)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.ScoreBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ScoreBoard As System.Windows.Forms.PictureBox
    Friend WithEvents ScoreTitle As System.Windows.Forms.Label
    Friend WithEvents FifaScore As System.Windows.Forms.Label
    Friend WithEvents ScoreYear As System.Windows.Forms.Label
    Friend WithEvents ScorePoint As System.Windows.Forms.Label
    Friend WithEvents ScoreMin As System.Windows.Forms.Label
    Friend WithEvents ScoreSec As System.Windows.Forms.Label
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
