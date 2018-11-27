Public Class frmSplashScreen
    '----------------------------------------------------------------------------------------
    ' Module : frmSplashScreen
    ' Project : Team Management
    ' Version : 1.0
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Description : This screen is the first screen that the user will see. 
    ' This screen will show the name Of the applaction And the logo before loading into the applaction
    '---------------------------------------------------------------------------------------- 
    '----------------------------------------------------------------------------------------
    ' Procedure : tmrSplashScreen_Tick
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : When the timer ends this page will hide and the team management page will show making the timer end.
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub tmrSplashScreen_Tick(sender As Object, e As EventArgs) Handles tmrSplashScreen.Tick
        Me.Hide()
        frmTeamManagement.Show()
        tmrSplashScreen.Enabled = False

    End Sub

End Class