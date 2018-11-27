Public Class frmTeamManagement
    '----------------------------------------------------------------------------------------
    ' Module : frmTeamManagement 
    ' Project : Team Management
    ' Version : 1.0
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Description : This is the main form of the applaction.
    ' On This form the user will be able to management the teams that are stored for example the will be able to transfer players across from each team.
    ' The user will also be able to see stats from the teams aswell.
    '---------------------------------------------------------------------------------------- 
    Dim TeamOne As New Team("Team One")
    Dim TeamTwo As New Team("Team Two")


    Dim CurrentTeam As Team
    '----------------------------------------------------------------------------------------
    ' Procedure : btnCreate_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : This button will take the infroamtion from the three text boxes name,postion,age and will create the player.
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        If rdoTeamOne.Checked = False And rdoTeamTwo.Checked = False Then
            MessageBox.Show("Please select a team")
            Exit Sub
        End If
        If txtName.Text = Nothing Or txtAge.Text = Nothing Or txtPosition.Text = Nothing Then
            MessageBox.Show("Please enter data into the text boxes")
            Exit Sub
        End If

        If Not IsNumeric(txtAge.Text) Or IsNumeric(txtName.Text) Or IsNumeric(txtPosition.Text) Then
            MessageBox.Show("Please enter the correct data")
            Exit Sub
        End If

        Dim name As String
        Dim age As Integer
        Dim position As String
        name = txtName.Text 'getting the name from the textbox
        age = CType(txtAge.Text, Integer) 'getting age from textbox
        position = txtPosition.Text 'getting the postion from the textbox


        CurrentTeam.addPlayer(name, age, position)

        'Display the number of players on that team
        lblTeamDetails.Text = CurrentTeam.PlayerCount.ToString
        txtName.Clear()
        txtAge.Clear()
        txtPosition.Clear()

    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : btnPlayerDetails_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : This button will display the player selected details.
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub btnPlayerDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayerDetails.Click
        If rdoTeamOne.Checked = False And rdoTeamTwo.Checked = False Then
            MessageBox.Show("Please select a team")
            Exit Sub
        End If
        'Display the players details which are on the team that has been selected
        lblPlayerDetails.Text = CurrentTeam.getPlayerDetails(CType(npdIndex.Value, Integer))
    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : btnFind_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : This button will find the players details that are on the team selected.
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If rdoTeamOne.Checked = False And rdoTeamTwo.Checked = False Then
            MessageBox.Show("Please select a team")
            Exit Sub
        End If

        'Find the player that is on the team that has been selected'
        lblPlayerDetails.Text = CurrentTeam.findPlayer(txtName.Text)

    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : btnRemove_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : This button will remove the player selected from the team that they are on.
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If rdoTeamOne.Checked = False And rdoTeamTwo.Checked = False Then
            MessageBox.Show("Please select a team")
            Exit Sub
        End If
        'Used a variable index to hold the player that is selected

        If Not CurrentTeam.PlayerCount > 0 Then
            MessageBox.Show("No player to remove")
            Exit Sub
        End If
        If CurrentTeam.PlayerCount < npdIndex.Value Then
            MessageBox.Show("No player to remove")
            Exit Sub
        End If


        Dim index As Integer = CInt(npdIndex.Value)
        Dim temp As Boolean

        temp = CurrentTeam.removeplayer(index)

        If (temp) Then
            MessageBox.Show("Player removed")
            lblTeamDetails.Text = CurrentTeam.PlayerCount.ToString

        Else
            MessageBox.Show("No player to remove")
        End If


    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : btnDisplayAll_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : This button will display all of the players details that are on that selected team.
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub btnDisplayAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeamDetails.Click
        If rdoTeamOne.Checked = False And rdoTeamTwo.Checked = False Then
            MessageBox.Show("Please select a team")
            Exit Sub
        End If
        'Display all of the details on all the players on the team'
        lblTeamDetails.Text = CurrentTeam.displayALL

    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : btnAverage_Click  
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : This button will collete the age of every player in the team and will find the average age of that team
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub btnAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAverage.Click
        If rdoTeamOne.Checked = False And rdoTeamTwo.Checked = False Then
            MessageBox.Show("Please select a team")
            Exit Sub
        End If
        Dim dblTeamAverage As Double
        'Find the average age of all the players in the team
        dblTeamAverage = CurrentTeam.findAverage()
        'Display the average age in the output label
        lblTeamDetails.Text = "The average age of the team " &
        CurrentTeam.title & " is: " & Format(dblTeamAverage, "0.00")
    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : rdoTeamOne_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : This radio button when clicked will mean that the user has selected team one for the applaction.
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub rdoTeamOne_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoTeamOne.Click
        ' Set the current team to team one
        CurrentTeam = TeamOne
        'Count and display number of players on the team
        lblTeamDetails.Text = CurrentTeam.PlayerCount.ToString
    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : rdoTeamTwo_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : When the user clicks this radio button it will mean that they have selected to view team two.
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub rdoTeamTwo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoTeamTwo.Click
        ' Set the current team to team two
        CurrentTeam = TeamTwo
        'Count and display number of players on the team
        lblTeamDetails.Text = CurrentTeam.PlayerCount.ToString
    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : btnTransfer_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : This button will transfer the selected player from the slected team to the non selected team.
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
        If rdoTeamOne.Checked = False And rdoTeamTwo.Checked = False Then
            MessageBox.Show("Please select a team")
            Exit Sub
        End If
        Dim index As Integer = CInt(npdIndex.Value)
        Dim temp As Boolean = Nothing
        Dim transTeam As Team
        If rdoTeamOne.Checked Then
            transTeam = TeamTwo 'The team the player will move to'
        Else
            transTeam = TeamOne 'The team the player will move to'
        End If
        ' Make sure team is not full
        If transTeam.PlayerCount() < 6 Then
            'Show that the player has been removed 
            If CurrentTeam.TransferTo(npdIndex.Value, transTeam) Then
                lblPlayerDetails.Text = " Transfer has been successful"
                lblTeamDetails.Text = CurrentTeam.PlayerCount.ToString
                temp = CurrentTeam.removeplayer(Index)
            Else
                lblPlayerDetails.Text = " Transfer unsuccessful"
            End If
        End If
    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : btnHelp_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : This button will bring up the help form for the user to see.
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        frmHelp.Show()
        Me.Hide()

    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : btnUpdate_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : This button will update the details of the selected player.
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If rdoTeamOne.Checked = False And rdoTeamTwo.Checked = False Then
            MessageBox.Show("Please select a team")
            Exit Sub
        End If
        If txtName.Text = Nothing And txtAge.Text = Nothing And txtPosition.Text = Nothing Then
            MessageBox.Show("Please enter data into the text boxes")
            Exit Sub
        End If
        If Not IsNumeric(txtAge.Text) And IsNumeric(txtName.Text) And IsNumeric(txtPosition.Text) Then
            MessageBox.Show("Please enter the correct data")
            Exit Sub
        End If
        'Used a variable index to hold the player that is selected
        Dim index As Integer = CType(npdIndex.Value, Integer)
        Dim temp As Boolean = Nothing
        Dim name, postion As String
        Dim age As Integer

        'Remove the player from the team that was selected


        temp = CurrentTeam.removeplayer(index)

        If (temp) Then
            MessageBox.Show("Player updated")
            lblTeamDetails.Text = CurrentTeam.PlayerCount.ToString
        Else
            MessageBox.Show("No player to update")
        End If



        name = txtName.Text 'getting the name from the textbox
        postion = txtPosition.Text 'getting the postion from the textbox
        age = CType(txtAge.Text, Integer) 'getting age from textbox


        CurrentTeam.addPlayer(name, age, postion)

    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : btnWon_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : This button will add a win to the team details.
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub btnWon_Click(sender As Object, e As EventArgs) Handles btnWon.Click
        If rdoTeamOne.Checked = False And rdoTeamTwo.Checked = False Then
            MessageBox.Show("Please select a team")
            Exit Sub
        End If
        Dim otherTeam As Team
        'Check which team is not selected
        If rdoTeamOne.Checked Then
            otherTeam = TeamTwo
        End If
        If rdoTeamTwo.Checked Then
            otherTeam = TeamOne
        End If

        'if the team has more than 5 players add a win to selected team and a lost to another team
        If CurrentTeam.PlayerCount() > 4 Then
            CurrentTeam.getWin()
            otherTeam.getlost()
            'if there are less than 5 players show an error
        Else
            MessageBox.Show("Not enough players in the team")
        End If


    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : btnLost_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : This button will add a lost to the team details.
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub btnLost_Click(sender As Object, e As EventArgs) Handles btnLost.Click
        If rdoTeamOne.Checked = False And rdoTeamTwo.Checked = False Then
            MessageBox.Show("Please select a team")
            Exit Sub
        End If
        Dim otherTeam As Team
        'Check which team is not selected
        If rdoTeamOne.Checked Then
            otherTeam = TeamTwo
        End If
        If rdoTeamTwo.Checked Then
            otherTeam = TeamOne
        End If
        'if the team has more than 5 players add a lost to selected team and a win to another team
        If CurrentTeam.PlayerCount() > 4 Then
            CurrentTeam.getlost()
            otherTeam.getWin()

            'if there are less than 5 players show an error
        Else
            MessageBox.Show("Not enough players in the team")
        End If

    End Sub
    '----------------------------------------------------------------------------------------
    ' Procedure : btnStats_Click
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Parameters : None
    ' Description : This button will show the games played, games won and games lost of the team
    ' 
    '---------------------------------------------------------------------------------------- 
    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        If rdoTeamOne.Checked = False And rdoTeamTwo.Checked = False Then
            MessageBox.Show("Please select a team")
            Exit Sub
        End If
        'Display all of the details on all the players on the team'
        lblTeamDetails.Text = CurrentTeam.getTeamDetails
    End Sub
End Class