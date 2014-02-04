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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.simBar = New System.Windows.Forms.ToolStrip
        Me.playButton = New System.Windows.Forms.ToolStripButton
        Me.pauseButton = New System.Windows.Forms.ToolStripButton
        Me.stopButton = New System.Windows.Forms.ToolStripButton
        Me.resetButton = New System.Windows.Forms.ToolStripButton
        Me.MenuStrip1.SuspendLayout()
        Me.simBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(633, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'simBar
        '
        Me.simBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.playButton, Me.pauseButton, Me.stopButton, Me.resetButton})
        Me.simBar.Location = New System.Drawing.Point(0, 24)
        Me.simBar.Name = "simBar"
        Me.simBar.Size = New System.Drawing.Size(633, 25)
        Me.simBar.TabIndex = 1
        Me.simBar.Text = "ToolStrip1"
        '
        'playButton
        '
        Me.playButton.Image = CType(resources.GetObject("playButton.Image"), System.Drawing.Image)
        Me.playButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(47, 22)
        Me.playButton.Text = "Play"
        '
        'pauseButton
        '
        Me.pauseButton.Image = CType(resources.GetObject("pauseButton.Image"), System.Drawing.Image)
        Me.pauseButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pauseButton.Name = "pauseButton"
        Me.pauseButton.Size = New System.Drawing.Size(56, 22)
        Me.pauseButton.Text = "Pause"
        '
        'stopButton
        '
        Me.stopButton.Image = CType(resources.GetObject("stopButton.Image"), System.Drawing.Image)
        Me.stopButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(49, 22)
        Me.stopButton.Text = "Stop"
        '
        'resetButton
        '
        Me.resetButton.Image = CType(resources.GetObject("resetButton.Image"), System.Drawing.Image)
        Me.resetButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(55, 22)
        Me.resetButton.Text = "Reset"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 533)
        Me.Controls.Add(Me.simBar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.simBar.ResumeLayout(False)
        Me.simBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents simBar As System.Windows.Forms.ToolStrip
    Friend WithEvents playButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents pauseButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents stopButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents resetButton As System.Windows.Forms.ToolStripButton

End Class
