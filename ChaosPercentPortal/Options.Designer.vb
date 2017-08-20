<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.BackButton = New System.Windows.Forms.Button()
        Me.StreamerToggle = New System.Windows.Forms.CheckBox()
        Me.OptionsTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TutButton = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PopupToggle = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(12, 326)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 0
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'StreamerToggle
        '
        Me.StreamerToggle.AutoSize = True
        Me.StreamerToggle.Location = New System.Drawing.Point(130, 100)
        Me.StreamerToggle.Name = "StreamerToggle"
        Me.StreamerToggle.Size = New System.Drawing.Size(98, 17)
        Me.StreamerToggle.TabIndex = 1
        Me.StreamerToggle.Text = "Streamer Mode"
        Me.StreamerToggle.UseVisualStyleBackColor = True
        '
        'OptionsTitle
        '
        Me.OptionsTitle.AutoSize = True
        Me.OptionsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsTitle.Location = New System.Drawing.Point(79, 9)
        Me.OptionsTitle.Name = "OptionsTitle"
        Me.OptionsTitle.Size = New System.Drawing.Size(196, 55)
        Me.OptionsTitle.TabIndex = 2
        Me.OptionsTitle.Text = "Options"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "(Required for the Chaos% run to be viable.)"
        '
        'TutButton
        '
        Me.TutButton.Location = New System.Drawing.Point(153, 326)
        Me.TutButton.Name = "TutButton"
        Me.TutButton.Size = New System.Drawing.Size(75, 23)
        Me.TutButton.TabIndex = 4
        Me.TutButton.Text = "Tutorial"
        Me.TutButton.UseVisualStyleBackColor = True
        '
        'AboutButton
        '
        Me.AboutButton.Location = New System.Drawing.Point(297, 326)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(75, 23)
        Me.AboutButton.TabIndex = 5
        Me.AboutButton.Text = "About"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "(All options are saved automatically.)"
        '
        'PopupToggle
        '
        Me.PopupToggle.AutoSize = True
        Me.PopupToggle.Location = New System.Drawing.Point(125, 165)
        Me.PopupToggle.Name = "PopupToggle"
        Me.PopupToggle.Size = New System.Drawing.Size(106, 17)
        Me.PopupToggle.TabIndex = 8
        Me.PopupToggle.Text = "Show All Popups"
        Me.PopupToggle.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.PopupToggle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.TutButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OptionsTitle)
        Me.Controls.Add(Me.StreamerToggle)
        Me.Controls.Add(Me.BackButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Options"
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents StreamerToggle As CheckBox
    Friend WithEvents OptionsTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TutButton As Button
    Friend WithEvents AboutButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PopupToggle As CheckBox
End Class
