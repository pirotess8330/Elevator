<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelection
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.selectFloors = New System.Windows.Forms.ComboBox
        Me.selectElevators = New System.Windows.Forms.ComboBox
        Me.selectOKbtn = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Floors"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Elevators"
        '
        'selectFloors
        '
        Me.selectFloors.FormattingEnabled = True
        Me.selectFloors.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.selectFloors.Location = New System.Drawing.Point(54, 120)
        Me.selectFloors.Name = "selectFloors"
        Me.selectFloors.Size = New System.Drawing.Size(54, 21)
        Me.selectFloors.TabIndex = 2
        Me.selectFloors.Text = "2"
        '
        'selectElevators
        '
        Me.selectElevators.FormattingEnabled = True
        Me.selectElevators.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.selectElevators.Location = New System.Drawing.Point(168, 120)
        Me.selectElevators.Name = "selectElevators"
        Me.selectElevators.Size = New System.Drawing.Size(59, 21)
        Me.selectElevators.TabIndex = 3
        Me.selectElevators.Text = "1"
        '
        'selectOKbtn
        '
        Me.selectOKbtn.Location = New System.Drawing.Point(101, 168)
        Me.selectOKbtn.Name = "selectOKbtn"
        Me.selectOKbtn.Size = New System.Drawing.Size(75, 23)
        Me.selectOKbtn.TabIndex = 4
        Me.selectOKbtn.Text = "Ok"
        Me.selectOKbtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 39)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "To start the simulation, select the number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of floors and the number of elevators" & _
            " and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "press OK."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 223)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.selectOKbtn)
        Me.Controls.Add(Me.selectElevators)
        Me.Controls.Add(Me.selectFloors)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Building"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents selectFloors As System.Windows.Forms.ComboBox
    Friend WithEvents selectElevators As System.Windows.Forms.ComboBox
    Friend WithEvents selectOKbtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
