Public Class frmHelp
    '----------------------------------------------------------------------------------------
    ' Module : frmHelp
    ' Project : Team Management
    ' Version : 1.0
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Description : This screen will will show the user how to use the team management form if they are having any problems
    '---------------------------------------------------------------------------------------- 
    '----------------------------------------------------------------------------------------
    ' Procedure : frmHelp_load
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : When this page loads it will hide all of the labels
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblDetails.Hide()
        lblPlayer.Hide()
        lblStats.Hide()
        lblTeamDetails.Hide()
        lblTransfer.Hide()

    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : rdoPlayer_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : When this radio button is selected it will show the user how to add a player
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub rdoPlayer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoPlayer.Click
        lblPlayer.Show()
        lblDetails.Hide()
        lblStats.Hide()
        lblTeamDetails.Hide()
        lblTransfer.Hide()
    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : rdoDetails_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : When this radio button is selected it will show the user how display a players details
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub rdoDetails_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoDetails.Click
        lblDetails.Show()
        lblPlayer.Hide()
        lblStats.Hide()
        lblTeamDetails.Hide()
        lblTransfer.Hide()

    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : rdoTransfer_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : When this radio button is selected it will show the user how to transfer a player
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub rdoTransfer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoTransfer.Click
        lblDetails.Hide()
        lblPlayer.Hide()
        lblStats.Hide()
        lblTeamDetails.Hide()
        lblTransfer.Show()
    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : rdoTeamDetails_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : When this radio button is selected it will show the user how to display the team details
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub rdoTeamDetails_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoTeamDetails.Click
        lblDetails.Hide()
        lblPlayer.Hide()
        lblStats.Hide()
        lblTeamDetails.Show()
        lblTransfer.Hide()
    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : rdoStats_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : When this radio button is selected it will show the user how to record the team stats
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub rdoStats_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoStats.Click
        lblDetails.Hide()
        lblPlayer.Hide()
        lblStats.Show()
        lblTeamDetails.Hide()
        lblTransfer.Hide()
    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : btnMain_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : This button will bring the user back to the team management form
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        frmTeamManagement.Show()
        Me.Hide()

    End Sub

    Private Sub lblPlayer_Click(sender As Object, e As EventArgs) Handles lblPlayer.Click

    End Sub
End Class