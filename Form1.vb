Public Class Form1



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        playButton.Enabled = True

        stopButton.Enabled = False
        pauseButton.Enabled = False
        resetButton.Enabled = False


    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
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
End Class
