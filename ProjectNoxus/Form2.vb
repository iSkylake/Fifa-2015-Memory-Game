Public Class Form2

    Dim Pos, Loc, Verify(3), VeriCon, Correct, Sec As Integer
    Dim VeriPos(24), VeriXY, Index As Boolean

    Sub Plus()
        Point.Text = Val(Point.Text) + 20
        Correct = Correct + 1
        If Correct = 12 Then
            Form3.Show()
            Timer1.Stop()
            Me.Close()
        End If
    End Sub

    Sub Minus()
        Point.Text = Val(Point.Text) - 5
    End Sub

    Function Position() As Integer
        Do
            Randomize()
            Pos = Math.Round(Rnd() * 23 + 1)
            If VeriPos(1) = False And Pos = 1 Then
                VeriPos(1) = True
                Loc = 1
                Return Loc
            ElseIf VeriPos(2) = False And Pos = 2 Then
                VeriPos(2) = True
                Loc = 2
                Return Loc
            ElseIf VeriPos(3) = False And Pos = 3 Then
                VeriPos(3) = True
                Loc = 3
                Return Loc
            ElseIf VeriPos(4) = False And Pos = 4 Then
                VeriPos(4) = True
                Loc = 4
                Return Loc
            ElseIf VeriPos(5) = False And Pos = 5 Then
                VeriPos(5) = True
                Loc = 5
                Return Loc
            ElseIf VeriPos(6) = False And Pos = 6 Then
                VeriPos(6) = True
                Loc = 6
                Return Loc
            ElseIf VeriPos(7) = False And Pos = 7 Then
                VeriPos(7) = True
                Loc = 7
                Return Loc
            ElseIf VeriPos(8) = False And Pos = 8 Then
                VeriPos(8) = True
                Loc = 8
                Return Loc
            ElseIf VeriPos(9) = False And Pos = 9 Then
                VeriPos(9) = True
                Loc = 9
                Return Loc
            ElseIf VeriPos(10) = False And Pos = 10 Then
                VeriPos(10) = True
                Loc = 10
                Return Loc
            ElseIf VeriPos(11) = False And Pos = 11 Then
                VeriPos(11) = True
                Loc = 11
                Return Loc
            ElseIf VeriPos(12) = False And Pos = 12 Then
                VeriPos(12) = True
                Loc = 12
                Return Loc
            ElseIf VeriPos(13) = False And Pos = 13 Then
                VeriPos(13) = True
                Loc = 13
                Return Loc
            ElseIf VeriPos(14) = False And Pos = 14 Then
                VeriPos(14) = True
                Loc = 14
                Return Loc
            ElseIf VeriPos(15) = False And Pos = 15 Then
                VeriPos(15) = True
                Loc = 15
                Return Loc
            ElseIf VeriPos(16) = False And Pos = 16 Then
                VeriPos(16) = True
                Loc = 16
                Return Loc
            ElseIf VeriPos(17) = False And Pos = 17 Then
                VeriPos(17) = True
                Loc = 17
                Return Loc
            ElseIf VeriPos(18) = False And Pos = 18 Then
                VeriPos(18) = True
                Loc = 18
                Return Loc
            ElseIf VeriPos(19) = False And Pos = 19 Then
                VeriPos(19) = True
                Loc = 19
                Return Loc
            ElseIf VeriPos(20) = False And Pos = 20 Then
                VeriPos(20) = True
                Loc = 20
                Return Loc
            ElseIf VeriPos(21) = False And Pos = 21 Then
                VeriPos(21) = True
                Loc = 21
                Return Loc
            ElseIf VeriPos(22) = False And Pos = 22 Then
                VeriPos(22) = True
                Loc = 22
                Return Loc
            ElseIf VeriPos(23) = False And Pos = 23 Then
                VeriPos(23) = True
                Loc = 23
                Return Loc
            ElseIf VeriPos(24) = False And Pos = 24 Then
                VeriPos(24) = True
                Loc = 24
                Return Loc
            End If
        Loop Until Index = True

    End Function

    Function FunX() As Integer
        Select Case Loc
            Case 1, 7, 13, 19 : Return 12
            Case 2, 8, 14, 20 : Return 160
            Case 3, 9, 15, 21 : Return 311
            Case 4, 10, 16, 22 : Return 462
            Case 5, 11, 17, 23 : Return 612
            Case 6, 12, 18, 24 : Return 763
        End Select
    End Function

    Function FunY() As Integer
        Select Case Loc
            Case 1, 2, 3, 4, 5, 6 : Return 98
            Case 7, 8, 9, 10, 11, 12 : Return 236
            Case 13, 14, 15, 16, 17, 18 : Return 374
            Case 19, 20, 21, 22, 23, 24 : Return 513
        End Select
    End Function

    Sub Flip1()
        Select Case Verify(2)
            Case 1 : CardA1.Image = My.Resources.FIFA_2014
                CardA2.Image = My.Resources.FIFA_2014
            Case 2 : CardB1.Image = My.Resources.FIFA_2014
                CardB2.Image = My.Resources.FIFA_2014
            Case 3 : CardC1.Image = My.Resources.FIFA_2014
                CardC2.Image = My.Resources.FIFA_2014
            Case 4 : CardD1.Image = My.Resources.FIFA_2014
                CardD2.Image = My.Resources.FIFA_2014
            Case 5 : CardE1.Image = My.Resources.FIFA_2014
                CardE2.Image = My.Resources.FIFA_2014
            Case 6 : CardF1.Image = My.Resources.FIFA_2014
                CardF2.Image = My.Resources.FIFA_2014
            Case 7 : CardG1.Image = My.Resources.FIFA_2014
                CardG2.Image = My.Resources.FIFA_2014
            Case 8 : CardH1.Image = My.Resources.FIFA_2014
                CardH2.Image = My.Resources.FIFA_2014
            Case 9 : CardI1.Image = My.Resources.FIFA_2014
                CardI2.Image = My.Resources.FIFA_2014
            Case 10 : CardJ1.Image = My.Resources.FIFA_2014
                CardJ2.Image = My.Resources.FIFA_2014
            Case 11 : CardK1.Image = My.Resources.FIFA_2014
                CardK2.Image = My.Resources.FIFA_2014
            Case 12 : CardL1.Image = My.Resources.FIFA_2014
                CardL2.Image = My.Resources.FIFA_2014
        End Select
    End Sub

    Sub Flip2()
        Select Case Verify(3)
            Case 1 : CardA1.Image = My.Resources.FIFA_2014
                CardA2.Image = My.Resources.FIFA_2014
            Case 2 : CardB1.Image = My.Resources.FIFA_2014
                CardB2.Image = My.Resources.FIFA_2014
            Case 3 : CardC1.Image = My.Resources.FIFA_2014
                CardC2.Image = My.Resources.FIFA_2014
            Case 4 : CardD1.Image = My.Resources.FIFA_2014
                CardD2.Image = My.Resources.FIFA_2014
            Case 5 : CardE1.Image = My.Resources.FIFA_2014
                CardE2.Image = My.Resources.FIFA_2014
            Case 6 : CardF1.Image = My.Resources.FIFA_2014
                CardF2.Image = My.Resources.FIFA_2014
            Case 7 : CardG1.Image = My.Resources.FIFA_2014
                CardG2.Image = My.Resources.FIFA_2014
            Case 8 : CardH1.Image = My.Resources.FIFA_2014
                CardH2.Image = My.Resources.FIFA_2014
            Case 9 : CardI1.Image = My.Resources.FIFA_2014
                CardI2.Image = My.Resources.FIFA_2014
            Case 10 : CardJ1.Image = My.Resources.FIFA_2014
                CardJ2.Image = My.Resources.FIFA_2014
            Case 11 : CardK1.Image = My.Resources.FIFA_2014
                CardK2.Image = My.Resources.FIFA_2014
            Case 12 : CardL1.Image = My.Resources.FIFA_2014
                CardL2.Image = My.Resources.FIFA_2014
        End Select
    End Sub

    Sub Enable()
        CardA1.Enabled = True
        CardA2.Enabled = True
        CardB1.Enabled = True
        CardB2.Enabled = True
        CardC1.Enabled = True
        CardC2.Enabled = True
        CardD1.Enabled = True
        CardD2.Enabled = True
        CardE1.Enabled = True
        CardE2.Enabled = True
        CardF1.Enabled = True
        CardF2.Enabled = True
        CardG1.Enabled = True
        CardG2.Enabled = True
        CardH1.Enabled = True
        CardH2.Enabled = True
        CardI1.Enabled = True
        CardI2.Enabled = True
        CardJ1.Enabled = True
        CardJ2.Enabled = True
        CardK1.Enabled = True
        CardK2.Enabled = True
        CardL1.Enabled = True
        CardL2.Enabled = True
    End Sub

    Sub FlipAll()
        Select Case Verify(0)
            Case 1 : CardA1.Visible = False
                CardA2.Visible = False
            Case 2 : CardB1.Visible = False
                CardB2.Visible = False
            Case 3 : CardC1.Visible = False
                CardC2.Visible = False
            Case 4 : CardD1.Visible = False
                CardD2.Visible = False
            Case 5 : CardE1.Visible = False
                CardE2.Visible = False
            Case 6 : CardF1.Visible = False
                CardF2.Visible = False
            Case 7 : CardG1.Visible = False
                CardG2.Visible = False
            Case 8 : CardH1.Visible = False
                CardH2.Visible = False
            Case 9 : CardI1.Visible = False
                CardI2.Visible = False
            Case 10 : CardJ1.Visible = False
                CardJ2.Visible = False
            Case 11 : CardK1.Visible = False
                CardK2.Visible = False
            Case 12 : CardL1.Visible = False
                CardL2.Visible = False
        End Select
    End Sub

    Sub Verification()
        If VeriCon = 0 Then
            Verify(2) = Verify(0)
            VeriCon = 1
        Else
            CardA1.Enabled = True
            Verify(3) = Verify(1)
            VeriCon = 0
            If Verify(2) = Verify(3) Then
                delay(450)
                FlipAll()
                Plus()
            Else
                Enable()
                delay(450)
                Flip1()
                Flip2()
                Minus()
            End If
        End If
    End Sub

    Private Sub Begin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Begin.Click

        CardA1.Visible = True
        CardA2.Visible = True
        CardB1.Visible = True
        CardB2.Visible = True
        CardC1.Visible = True
        CardC2.Visible = True
        CardD1.Visible = True
        CardD2.Visible = True
        CardE1.Visible = True
        CardE2.Visible = True
        CardF1.Visible = True
        CardF2.Visible = True
        CardG1.Visible = True
        CardG2.Visible = True
        CardH1.Visible = True
        CardH2.Visible = True
        CardI1.Visible = True
        CardI2.Visible = True
        CardJ1.Visible = True
        CardJ2.Visible = True
        CardK1.Visible = True
        CardK2.Visible = True
        CardL1.Visible = True
        CardL2.Visible = True
        PointText.Visible = True
        Point.Visible = True
        Time.Visible = True
        Second.Visible = True
        Minute.Visible = True
        Dot.Visible = True
        Timer1.Enabled = True

        Position()
        CardA1.Location = New Point(FunX, FunY)
        Position()
        CardA2.Location = New Point(FunX, FunY)
        Position()
        CardB1.Location = New Point(FunX, FunY)
        Position()
        CardB2.Location = New Point(FunX, FunY)
        Position()
        CardC1.Location = New Point(FunX, FunY)
        Position()
        CardC2.Location = New Point(FunX, FunY)
        Position()
        CardD1.Location = New Point(FunX, FunY)
        Position()
        CardD2.Location = New Point(FunX, FunY)
        Position()
        CardE1.Location = New Point(FunX, FunY)
        Position()
        CardE2.Location = New Point(FunX, FunY)
        Position()
        CardF1.Location = New Point(FunX, FunY)
        Position()
        CardF2.Location = New Point(FunX, FunY)
        Position()
        CardG1.Location = New Point(FunX, FunY)
        Position()
        CardG2.Location = New Point(FunX, FunY)
        Position()
        CardH1.Location = New Point(FunX, FunY)
        Position()
        CardH2.Location = New Point(FunX, FunY)
        Position()
        CardI1.Location = New Point(FunX, FunY)
        Position()
        CardI2.Location = New Point(FunX, FunY)
        Position()
        CardJ1.Location = New Point(FunX, FunY)
        Position()
        CardJ2.Location = New Point(FunX, FunY)
        Position()
        CardK1.Location = New Point(FunX, FunY)
        Position()
        CardK2.Location = New Point(FunX, FunY)
        Position()
        CardL1.Location = New Point(FunX, FunY)
        Position()
        CardL2.Location = New Point(FunX, FunY)

        Begin.Hide()
    End Sub

    Private Sub CardA1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardA1.Click
        CardA1.Image = My.Resources.EstadioNight
        CardA1.Enabled = False
        Verify(0) = 1
        Verify(1) = 1
        Verification()
    End Sub


    Private Sub CardA2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardA2.Click
        CardA2.Image = My.Resources.EstadioNight
        CardA2.Enabled = False
        Verify(0) = 1
        Verify(1) = 1
        Verification()
    End Sub

    Private Sub CardB1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardB1.Click
        CardB1.Image = My.Resources.Balon
        CardB1.Enabled = False
        Verify(0) = 2
        Verify(1) = 2
        Verification()
    End Sub


    Private Sub CardB2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardB2.Click
        CardB2.Image = My.Resources.Balon
        CardB2.Enabled = False
        Verify(0) = 2
        Verify(1) = 2
        Verification()
    End Sub

    Private Sub CardC1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardC1.Click
        CardC1.Image = My.Resources.Balon_Oficial
        CardC1.Enabled = False
        Verify(0) = 3
        Verify(1) = 3
        Verification()
    End Sub

    Private Sub CardC2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardC2.Click
        CardC2.Image = My.Resources.Balon_Oficial
        CardC2.Enabled = False
        Verify(0) = 3
        Verify(1) = 3
        Verification()
    End Sub


    Private Sub CardD1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardD1.Click
        CardD1.Image = My.Resources.Mascota
        CardD1.Enabled = False
        Verify(0) = 4
        Verify(1) = 4
        Verification()
    End Sub


    Private Sub CardD2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardD2.Click
        CardD2.Image = My.Resources.Mascota
        CardD2.Enabled = False
        Verify(0) = 4
        Verify(1) = 4
        Verification()
    End Sub

    Private Sub CardE1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardE1.Click
        CardE1.Image = My.Resources.Inauguracion
        CardE1.Enabled = False
        Verify(0) = 5
        Verify(1) = 5
        Verification()
    End Sub

    Private Sub CardE2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardE2.Click
        CardE2.Image = My.Resources.Inauguracion
        CardE2.Enabled = False
        Verify(0) = 5
        Verify(1) = 5
        Verification()
    End Sub


    Private Sub CardF1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardF1.Click
        CardF1.Image = My.Resources.Estadio
        CardF1.Enabled = False
        Verify(0) = 6
        Verify(1) = 6
        Verification()
    End Sub

    Private Sub CardF2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardF2.Click
        CardF2.Image = My.Resources.Estadio
        CardF2.Enabled = False
        Verify(0) = 6
        Verify(1) = 6
        Verification()
    End Sub


    Private Sub CardG1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardG1.Click
        CardG1.Image = My.Resources.young_cristiano_ronaldo_wallpaper_1408911882
        CardG1.Enabled = False
        Verify(0) = 7
        Verify(1) = 7
        Verification()
    End Sub

    Private Sub CardG2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardG2.Click
        CardG2.Image = My.Resources.young_cristiano_ronaldo_wallpaper_1408911882
        CardG2.Enabled = False
        Verify(0) = 7
        Verify(1) = 7
        Verification()
    End Sub

    Private Sub CardH1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardH1.Click
        CardH1.Image = My.Resources.Gianluigi_Buffon
        CardH1.Enabled = False
        Verify(0) = 8
        Verify(1) = 8
        Verification()
    End Sub


    Private Sub CardH2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardH2.Click
        CardH2.Image = My.Resources.Gianluigi_Buffon
        CardH2.Enabled = False
        Verify(0) = 8
        Verify(1) = 8
        Verification()
    End Sub

    Private Sub CardI1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardI1.Click
        CardI1.Image = My.Resources.Baloteli
        CardI1.Enabled = False
        Verify(0) = 9
        Verify(1) = 9
        Verification()
    End Sub

    Private Sub CardI2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardI2.Click
        CardI2.Image = My.Resources.Baloteli
        CardI2.Enabled = False
        Verify(0) = 9
        Verify(1) = 9
        Verification()
    End Sub


    Private Sub CardJ1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardJ1.Click
        CardJ1.Image = My.Resources.Neymar
        CardJ1.Enabled = False
        Verify(0) = 10
        Verify(1) = 10
        Verification()
    End Sub

    Private Sub CardJ2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardJ2.Click
        CardJ2.Image = My.Resources.Neymar
        CardJ2.Enabled = False
        Verify(0) = 10
        Verify(1) = 10
        Verification()
    End Sub

    Private Sub CardK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardK1.Click
        CardK1.Image = My.Resources.Messi
        CardK1.Enabled = False
        Verify(0) = 11
        Verify(1) = 11
        Verification()
    End Sub

    Private Sub CardK2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardK2.Click
        CardK2.Image = My.Resources.Messi
        CardK2.Enabled = False
        Verify(0) = 11
        Verify(1) = 11
        Verification()
    End Sub

    Private Sub CardL1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardL1.Click
        CardL1.Image = My.Resources.Iker_Casillas
        CardL1.Enabled = False
        Verify(0) = 12
        Verify(1) = 12
        Verification()
    End Sub

    Private Sub CardL2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardL2.Click
        CardL2.Image = My.Resources.Iker_Casillas
        CardL2.Enabled = False
        Verify(0) = 12
        Verify(1) = 12
        Verification()
    End Sub

    Private Declare Function timeGetTime Lib "winmm.dll" () As Long
    Public lngStartTime As Long

    Public Sub delay(ByVal msdelay As Long)
        lngStartTime = timeGetTime()
        Do Until (timeGetTime() - lngStartTime) > msdelay
        Loop
    End Sub

    Private Sub Begin_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Begin.MouseLeave
        Begin.ForeColor = Color.Black
        Begin.Font = New Font("Showcard Gothic", 36, FontStyle.Bold)
        Begin.Location = New Point(299, 545)

    End Sub

    Private Sub Begin_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Begin.MouseMove
        Begin.ForeColor = Color.Red
        Begin.Font = New Font("Showcard Gothic", 48, FontStyle.Bold)
        Begin.Location = New Point(250, 530)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Sec < 59 Then
            Sec = Sec + 1
            Second.Text = Val(Second.Text) + 1
        Else
            Second.Text = 0
            Sec = 0
            Minute.Text = Val(Minute.Text) + 1
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class