Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HadotYoutube_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles HadotYoutube.LinkClicked
        HadotYoutube.LinkVisited = True
        Process.Start("https://www.youtube.com/channel/UCHUI_Z6jyYWXFZpMidFDKWQ")
    End Sub

    Private Sub HadotSteam_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles HadotSteam.LinkClicked
        HadotSteam.LinkVisited = True
        Process.Start("http://steamcommunity.com/id/hadot")
    End Sub

    Private Sub HadotTwitter_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles HadotTwitter.LinkClicked
        HadotTwitter.LinkVisited = True
        Process.Start("https://twitter.com/hadothadot")
    End Sub

    Private Sub ThingSteam_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ThingSteam.LinkClicked
        ThingSteam.LinkVisited = True
        Process.Start("http://steamcommunity.com/id/lexevolution")
    End Sub

    Private Sub CloseWindow() Handles Me.Closed
        Form1.Show()
    End Sub


End Class