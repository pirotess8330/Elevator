Public Class form1

    Public floors As Integer
    Public elevators As Integer '= selectElevators.Text

    Public minSize As Size
    Public lpSize As Size
    Public lpHeight As Integer

    Private Sub form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click

    End Sub

    Private Sub form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        p2.frmSelection.Close()
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '//----------------------------------------------
        '// Reset simButtons
        '//----------------------------------------------

        playButton.Enabled = True
        stopButton.Enabled = False
        pauseButton.Enabled = False
        resetButton.Enabled = False

        floors = frmSelection.selectFloors.Text
        elevators = frmSelection.selectElevators.Text

        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim k As Integer = 0
        Dim l As Integer = 0
        '//---------------------
        '//
        '//---------------------
        For i = 1 To floors
            Controls("pFloor" & i).Visible = True
            '//---------------------
            '// Make Visible Elevator Doors
            '//---------------------
            For j = 1 To elevators
                Controls("pFloor" & i).Controls("pElevDoor" & i & j).Visible = True
            Next j
            '//---------------------
            '// Make Visible Elevator Light Panels
            '//---------------------
            For k = 1 To elevators
                Controls("pFloor" & i).Controls("lightPanel" & i & k).Visible = True
            Next k
            '//---------------------
            '// Configure top floor
            '//---------------------
            If i = floors Then
                Call topFloorSinglePanels(floors, elevators)
                ' Dim one As Size
                ' For l = 1 To elevators
                ' Controls("pFloor" & i).Controls("lightPanel" & i & l).Panel.MinimumSize = 1
                '    Controls("pFloor" & i).Controls("lightPanel" & i & l).
                ' Controls("pFloor" & i).Controls("lightPanel" & i & l).Height = 13
                ' Next l
            End If

        Next i
        '//---------------------
        '// Enable Elevator Panel menus
        '//---------------------
        Dim m As Integer ' Counter for Dim
        For m = 1 To elevators
            Controls("pFloor" & 1).Controls("ToolStripContainer" & m).Visible = True
        Next m



    End Sub

    Private Sub topFloorSinglePanels(ByVal topFloor As Integer, ByVal e As Integer)
        ' Only need one set configuration to reset

        ' Save a the current top floor lightPanel
        minSize = Controls("pFloor" & topFloor).Controls("lightPanel" & topFloor & 1).MinimumSize
        lpSize = Controls("pFloor" & topFloor).Controls("lightPanel" & topFloor & 1).Size
        lpHeight = Controls("pFloor" & topFloor).Controls("lightPanel" & topFloor & 1).Height


    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        p2.frmSelection.Close()

    End Sub

    Private Sub simBar_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles simBar.ItemClicked
        ' Returns the control name click on the simBar
        Dim simBarItem As String

        simBarItem = e.ClickedItem.Name

        Select Case simBarItem
            Case "playButton"
                Call simMenuSelection(False, True, True, False)
            Case "stopButton"
                Dim answer As Integer = MsgBox("Stopping the simulation will require you to reset and start over." + (Chr(13) & Chr(10)) + (Chr(13) & Chr(10)) + "                 Are you sure?", MsgBoxStyle.YesNo, "Stop Warning")
                If (answer.ToString = 6) Then 'No, Don't pause
                    Call simMenuSelection(False, False, False, True)
                End If
            Case "pauseButton"
                Call simMenuSelection(True, False, True, False)
            Case "resetButton"
                Call simMenuSelection(True, False, False, False)
            Case Else
        End Select



    End Sub
    '
    ' Function works with the menus on the simBar to enable or disabled depending on selection
    Private Sub simMenuSelection(ByVal pl As Boolean, ByVal ps As Boolean, ByVal s As Boolean, ByVal r As Boolean)
        playButton.Enabled = pl
        pauseButton.Enabled = ps
        stopButton.Enabled = s
        resetButton.Enabled = r
    End Sub

    Private Sub playButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playButton.Click

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pElevDoor11.Panel2.Paint, pElevDoor51.Panel2.Paint, pElevDoor41.Panel2.Paint, pElevDoor31.Panel2.Paint, pElevDoor21.Panel2.Paint, pElevDoor81.Panel2.Paint, pElevDoor71.Panel2.Paint, pElevDoor61.Panel2.Paint, pElevDoor91.Panel2.Paint, pElevDoor13.Panel2.Paint, pElevDoor23.Panel2.Paint, pElevDoor33.Panel2.Paint, pElevDoor43.Panel2.Paint, pElevDoor53.Panel2.Paint, pElevDoor63.Panel2.Paint, pElevDoor73.Panel2.Paint, pElevDoor83.Panel2.Paint, pElevDoor93.Panel2.Paint, pElevDoor103.Panel2.Paint, pElevDoor12.Panel2.Paint, pElevDoor22.Panel2.Paint, pElevDoor32.Panel2.Paint, pElevDoor42.Panel2.Paint, pElevDoor52.Panel2.Paint, pElevDoor62.Panel2.Paint, pElevDoor72.Panel2.Paint, pElevDoor82.Panel2.Paint, pElevDoor92.Panel2.Paint, pElevDoor102.Panel2.Paint, pElevDoor101.Panel2.Paint, pElevDoor15.Panel2.Paint, pElevDoor25.Panel2.Paint, pElevDoor35.Panel2.Paint, pElevDoor45.Panel2.Paint, pElevDoor55.Panel2.Paint, pElevDoor65.Panel2.Paint, pElevDoor75.Panel2.Paint, pElevDoor85.Panel2.Paint, pElevDoor95.Panel2.Paint, pElevDoor105.Panel2.Paint, pElevDoor14.Panel2.Paint, pElevDoor24.Panel2.Paint, pElevDoor34.Panel2.Paint, pElevDoor44.Panel2.Paint, pElevDoor54.Panel2.Paint, pElevDoor64.Panel2.Paint, pElevDoor74.Panel2.Paint, pElevDoor84.Panel2.Paint, pElevDoor94.Panel2.Paint, pElevDoor104.Panel2.Paint

    End Sub

    Private Sub ebDown10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ebDown10.CheckedChanged

        Floor10.Panel2.BackgroundImage = dudeGoingDown()

    End Sub

    Private Sub ebUp9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ebUp9.CheckedChanged
        Floor9.Panel1.BackgroundImage = dudeGoingUp()
    End Sub

    Private Sub ebDown9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ebDown9.CheckedChanged
        Floor9.Panel2.BackgroundImage = dudeGoingDown()
    End Sub

    Private Sub ebUp8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ebUp8.CheckedChanged

        Floor8.Panel1.BackgroundImage = dudeGoingUp()
    End Sub

    Private Sub ebDown8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ebDown8.CheckedChanged
        Floor8.Panel2.BackgroundImage = dudeGoingDown()



    End Sub

    Private Sub ebUp7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ebUp7.CheckedChanged
        Floor7.Panel1.BackgroundImage = dudeGoingUp()
    End Sub

    Private Sub ebDown7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ebDown7.CheckedChanged
        Floor7.Panel2.BackgroundImage = dudeGoingDown()
    End Sub

    Private Sub ebUp6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ebUp6.CheckedChanged
        Floor6.Panel1.BackgroundImage = dudeGoingUp()
    End Sub

    Private Sub ebDown6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ebDown6.CheckedChanged
        Floor6.Panel2.BackgroundImage = dudeGoingDown()
    End Sub

    Private Sub ebUp5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ebUp5.CheckedChanged
        Floor5.Panel1.BackgroundImage = dudeGoingUp()
    End Sub

    Private Sub ebDown5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ebDown5.CheckedChanged
        Floor5.Panel2.BackgroundImage = dudeGoingDown()
    End Sub

    Private Sub ebUp4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ebUp4.CheckedChanged
        Floor4.Panel1.BackgroundImage = dudeGoingUp()
    End Sub

    Private Sub ebDown4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ebDown4.CheckedChanged
        Floor4.Panel2.BackgroundImage = dudeGoingDown()
    End Sub

    Private Sub ebUp3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ebUp3.CheckedChanged
        Floor3.Panel1.BackgroundImage = dudeGoingUp()
    End Sub

    Private Sub ebDown3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ebDown3.CheckedChanged
        Floor3.Panel2.BackgroundImage = dudeGoingDown()
    End Sub

    Private Sub ebUp2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ebUp2.CheckedChanged
        Floor2.Panel1.BackgroundImage = dudeGoingUp()
    End Sub

    Private Sub ebDown2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ebDown2.CheckedChanged
        Floor2.Panel2.BackgroundImage = dudeGoingDown()
    End Sub

    Private Sub ebUp1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ebUp1.CheckedChanged
        Floor1.Panel1.BackgroundImage = dudeGoingUp()
    End Sub

    Private Function dudeGoingUp()
        Return p2.My.Resources.Resources.personImgUp
    End Function

    Private Function dudeGoingDown()
        Return p2.My.Resources.Resources.personImgDown
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cuTimer.Tick

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub pFloor4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pFloor4.Paint

    End Sub

    Private Sub lightPanel1_3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles lightPanel13.Paint

    End Sub

    Private Sub lightPanel4_4_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles lightPanel44.Panel1.Paint

    End Sub

    Private Sub pFloor7_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pFloor7.Paint


    End Sub

    Private Sub lightPanel6_4_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles lightPanel64.Panel2.Paint

    End Sub

    Private Sub stFloor1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If sender.BackColor = Color.Transparent Then
            sender.BackColor = setBackColorOrange()
        End If
        ' Send message to CU that a floor has been selected.

    End Sub

    Private Function setBackColorOrange()
        Return Color.Orange
    End Function

    Private Function setBackColorTransparent()
        Return Color.Transparent
    End Function
    Private Function setBackColorGreen()
        Return Color.Transparent
    End Function


    Private Sub stFloor11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor11.Click

        MsgBox(sender.GetType().ToString, MsgBoxStyle.OkOnly)

        If sender.BackColor = Color.Transparent Then
            sender.BackColor = setBackColorOrange()
        End If

    End Sub

    Private Sub stFloor12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor12.Click
        MsgBox(sender.ToString, MsgBoxStyle.OkOnly)
    End Sub

    Private Sub stFloor13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor13.Click

    End Sub

    Private Sub stFloor14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor14.Click

    End Sub

    Private Sub stFloor15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor15.Click

    End Sub

    Private Sub stFloor16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor16.Click

    End Sub

    Private Sub stFloor17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor17.Click

    End Sub

    Private Sub stFloor18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor18.Click

    End Sub

    Private Sub stFloor19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor19.Click

    End Sub


    Private Sub stFloor21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor21.Click


    End Sub
    Private Sub stFloor22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor22.Click


    End Sub
    Private Sub stFloor23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor23.Click


    End Sub
    Private Sub stFloor24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor24.Click


    End Sub
    Private Sub stFloor25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor25.Click


    End Sub
    Private Sub stFloor26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor26.Click


    End Sub
    Private Sub stFloor27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor27.Click


    End Sub

    Private Sub stFloor28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor28.Click


    End Sub

    Private Sub stFloor29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor29.Click


    End Sub
    Private Sub stFloor210_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor210.Click


    End Sub

    Private Sub stFloor31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor31.Click


    End Sub

    Private Sub stFloor32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor32.Click


    End Sub

    Private Sub stFloor33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor33.Click


    End Sub

    Private Sub stFloor34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor34.Click


    End Sub

    Private Sub stFloor35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor35.Click


    End Sub

    Private Sub stFloor36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor36.Click


    End Sub

    Private Sub stFloor37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor37.Click


    End Sub

    Private Sub stFloor38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor38.Click


    End Sub

    Private Sub stFloor39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor39.Click


    End Sub

    Private Sub stFloor310_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor310.Click


    End Sub

    Private Sub stFloor41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor41.Click


    End Sub

    Private Sub stFloor42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor42.Click


    End Sub

    Private Sub stFloor43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor43.Click


    End Sub

    Private Sub stFloor44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor44.Click


    End Sub

    Private Sub stFloor45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor45.Click


    End Sub

    Private Sub stFloor46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor46.Click


    End Sub

    Private Sub stFloor47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor47.Click


    End Sub

    Private Sub stFloor48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor48.Click


    End Sub

    Private Sub stFloor49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor49.Click


    End Sub

    Private Sub stFloor410_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor410.Click


    End Sub

    Private Sub stFloor51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor51.Click


    End Sub
    Private Sub stFloor52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor52.Click


    End Sub
    Private Sub stFloor53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor53.Click


    End Sub
    Private Sub stFloor54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor54.Click


    End Sub
    Private Sub stFloor55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor55.Click


    End Sub
    Private Sub stFloor56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor56.Click


    End Sub
    Private Sub stFloor57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor57.Click


    End Sub
    Private Sub stFloor58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor58.Click


    End Sub
    Private Sub stFloor59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor59.Click


    End Sub
    Private Sub stFloor510_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stFloor510.Click


    End Sub

End Class
