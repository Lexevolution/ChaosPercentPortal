Public Class Options
    Public Shared confdir As String
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show()
        Dim config As String() = IO.File.ReadAllLines("ChaosConfig.txt")
        For i = 0 To config.GetUpperBound(0)
            If config(i).Contains("Streamer=") Then
                If config(i) = "Streamer=True" Then
                    StreamerToggle.Checked = True
                Else
                    StreamerToggle.Checked = False
                End If
            End If
        Next

        For i = 0 To config.GetUpperBound(0)
            If config(i).Contains("Popup=") = True Then
                If config(i) = "Popup=True" Then
                    PopupToggle.Checked = True
                Else
                    PopupToggle.Checked = False
                End If
            End If
        Next

    End Sub

    Private Sub StreamerToggle_CheckedChanged(sender As Object, e As EventArgs) Handles StreamerToggle.CheckedChanged
        Dim config As String() = IO.File.ReadAllLines("ChaosConfig.txt")
        If StreamerToggle.Checked = True Then

            For i = 0 To config.GetUpperBound(0)
                If config(i).Contains("Streamer=") Then
                    config(i) = "Streamer=True"
                    IO.File.WriteAllLines("ChaosConfig.txt", config)
                End If
            Next

        Else

            For i = 0 To config.GetUpperBound(0)
                If config(i).Contains("Streamer=") Then
                    config(i) = "Streamer=False"
                    IO.File.WriteAllLines("ChaosConfig.txt", config)
                End If
            Next

        End If
    End Sub

    Private Sub PopupToggle_CheckedChanged(sender As Object, e As EventArgs) Handles PopupToggle.CheckedChanged
        Dim config As String() = IO.File.ReadAllLines("ChaosConfig.txt")
        If PopupToggle.Checked = True Then

            For i = 0 To config.GetUpperBound(0)
                If config(i).Contains("Popup=") Then
                    config(i) = "Popup=True"
                    IO.File.WriteAllLines("ChaosConfig.txt", config)
                End If
            Next

        Else

            For i = 0 To config.GetUpperBound(0)
                If config(i).Contains("Popup=") Then
                    config(i) = "Popup=False"
                    IO.File.WriteAllLines("ChaosConfig.txt", config)
                End If
            Next

        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Hide()
        Form1.Show()
    End Sub

    Private Sub CloseWindow() Handles Me.Closed
        Form1.Show()
    End Sub

    Private Sub TutButton_Click(sender As Object, e As EventArgs) Handles TutButton.Click
        MsgBox("Chaos% is an extension category to Portal. This program enables you to run this category." & vbNewLine & vbNewLine & "This program uses random command(s) to try and mess you up in the game. In 15 second intervals, one of these command sets will go off, then be reset." & vbNewLine & "All you have to do is complete the game in any main category you choose. DO NOT look at this window while playing the game. The point is you won't know what command will happen next." & vbNewLine & vbNewLine & "Click OK to see how to add commands to the command list.", vbOKOnly, "Tutorial")
        MsgBox("To add commands to the list, find 'ChaosConfig.txt' in the same directory as this program." & vbNewLine & "(Please note only the default commands are speedrun viable. Any added will make it not viable.)" & vbNewLine & vbNewLine & "To add commands to the list, make sure there is a one line gap between each command set. Then if you want, add '!!RESET' or '!!WAIT' to the begginning of the command set." & vbNewLine & vbNewLine & "Use !!RESET if you need to reset your commands afterwards. To do that, add your reset command to the reset commands at the bottom of the config." & vbNewLine & "Use !!WAIT if you want your last command in the command set to be run after the other ones." & vbNewLine & vbNewLine & "Click OK to see what each option does.", vbOKOnly, "Tutorial - Commands")
        MsgBox("Streamer mode writes the commands that will be executed in to a text file called 'StreamCommands.txt'. You can use this to display the commands in your livestreaming program.", vbOKOnly, "Tutorial - Options")
    End Sub

End Class