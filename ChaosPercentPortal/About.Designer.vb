<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HadotYoutube = New System.Windows.Forms.LinkLabel()
        Me.HadotSteam = New System.Windows.Forms.LinkLabel()
        Me.HadotTwitter = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ThingSteam = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "About"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Originally created by hadot:"
        '
        'HadotYoutube
        '
        Me.HadotYoutube.AutoSize = True
        Me.HadotYoutube.Location = New System.Drawing.Point(81, 90)
        Me.HadotYoutube.Name = "HadotYoutube"
        Me.HadotYoutube.Size = New System.Drawing.Size(47, 13)
        Me.HadotYoutube.TabIndex = 2
        Me.HadotYoutube.TabStop = True
        Me.HadotYoutube.Text = "Youtube"
        '
        'HadotSteam
        '
        Me.HadotSteam.AutoSize = True
        Me.HadotSteam.Location = New System.Drawing.Point(158, 90)
        Me.HadotSteam.Name = "HadotSteam"
        Me.HadotSteam.Size = New System.Drawing.Size(37, 13)
        Me.HadotSteam.TabIndex = 3
        Me.HadotSteam.TabStop = True
        Me.HadotSteam.Text = "Steam"
        '
        'HadotTwitter
        '
        Me.HadotTwitter.AutoSize = True
        Me.HadotTwitter.Location = New System.Drawing.Point(227, 90)
        Me.HadotTwitter.Name = "HadotTwitter"
        Me.HadotTwitter.Size = New System.Drawing.Size(39, 13)
        Me.HadotTwitter.TabIndex = 4
        Me.HadotTwitter.TabStop = True
        Me.HadotTwitter.Text = "Twitter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Recreated by thingamajig0:"
        '
        'ThingSteam
        '
        Me.ThingSteam.AutoSize = True
        Me.ThingSteam.Location = New System.Drawing.Point(158, 158)
        Me.ThingSteam.Name = "ThingSteam"
        Me.ThingSteam.Size = New System.Drawing.Size(37, 13)
        Me.ThingSteam.TabIndex = 6
        Me.ThingSteam.TabStop = True
        Me.ThingSteam.Text = "Steam"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(122, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Check for Updates"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Version: 1.0.1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(238, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "(Not implemented yet...)"
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ThingSteam)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.HadotTwitter)
        Me.Controls.Add(Me.HadotSteam)
        Me.Controls.Add(Me.HadotYoutube)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "About"
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents HadotYoutube As LinkLabel
    Friend WithEvents HadotSteam As LinkLabel
    Friend WithEvents HadotTwitter As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents ThingSteam As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
