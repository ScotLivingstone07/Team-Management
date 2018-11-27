Public Class Team
    '=================================================
    ' Class : Team
    ' Project : Team Management
    ' Version : 1.0
    ' Date : 10/05/17
    ' Author : Scot Livingstone
    ' Description : This class contains the details for the team players
    ' including the number of players on the team, adding the players to the team, transfering players to another team,
    ' collecting the details of the players and the team, removing and adding players to the team and also finding the average age of the team. 
    '================================================= 
    Private arrPlayer(6) As Player
    Private count As Integer
    Private played As Integer
    Private won As Integer
    Private lost As Integer
    Public title As String
    '================================================
    ' Procedure : new
    ' Date : 10/05/17
    ' Author : Scot Livingstone
    ' Parameters : name
    ' Returns : 
    ' Description : This will get a new team
    '================================================ 
    Public Sub New(ByRef name As String)
        title = name
        count = 0
    End Sub
    '================================================
    ' Procedure : PlayerCount
    ' Date : 10/05/17
    ' Author : Scot Livingstone
    ' Parameters : 
    ' Returns : count
    ' Description : This will count the players in the team
    '================================================ 
    Public ReadOnly Property PlayerCount() As Integer
        'Return the number of players in a team'
        Get
            Return count
        End Get
    End Property
    '================================================
    ' Procedure : addPlayer
    ' Date : 10/05/17
    ' Author : Scot Livingstone
    ' Parameters : name, age and position
    ' Returns : 
    ' Description : This is to add the player to the array
    '================================================ 
    Public Sub addPlayer(ByVal Name As String, ByVal Age As Integer, ByVal Position As String)
        Dim myplayer As Player = Nothing
        'If the number of players is less than array size then add a player'
        If count < arrPlayer.Length Then
            myplayer = New Player(Name, Age, Position)
            arrPlayer(count) = myplayer
            count = count + 1
        End If
    End Sub
    '================================================
    ' Procedure : addPlayer
    ' Date : 10/05/17
    ' Author : Scot Livingstone
    ' Parameters : other player
    ' Returns : 
    ' Description : This is to add the player to the array
    '================================================ 

    Public Function addPlayer(ByVal otherPlayer As Player) As Player
        Dim myPlayer As Player = otherPlayer
        'If the number of players is less than array size then add a player'
        If count < arrPlayer.Length Then

            arrPlayer(count) = myPlayer
            count = count + 1
        End If
        'return the player'
        Return myPlayer
    End Function
    '================================================
    ' Procedure : TransferTo
    ' Date : 10/05/17
    ' Author : Scot Livingstone
    ' Parameters : postion and otherTeam
    ' Returns : True or False
    ' Description : This is to transfer a player from one team to another
    '================================================ 

    Public Function TransferTo(ByVal position As Integer, ByVal otherTeam As Team) As Boolean
        'This is to tranfer players to the other team in the database'
        Dim delPlayer As Player = arrPlayer(position - 1)
        If Not delPlayer Is Nothing Then
            otherTeam.addPlayer(delPlayer)

            Return True
        Else
            Return False
        End If
    End Function
    '================================================
    ' Procedure : getPlayerDetails
    ' Date : 10/05/17
    ' Author : Scot Livingstone
    ' Parameters : index
    ' Returns : arrPlayer(index.getdetails() or "No players avaiable"
    ' Description : This to find all of the players details
    '================================================ 
    Public Function getPlayerDetails(ByVal index As Integer)
        'Find the player details'
        index = index - 1
        If index < count Then
            Return arrPlayer(index).getDetails()
        Else
            'If there are no players'
            Return "No players available"
        End If

    End Function
    '================================================
    ' Procedure : displayAll
    ' Date : 10/05/17
    ' Author : Scot Livingstone
    ' Parameters : 
    ' Returns : strOutput
    ' Description : This is to display all of the players details
    '================================================ 
    Public Function displayALL() As String
        Dim strOutput As String = Nothing
        If count = 0 Then
            strOutput = "No players available"
        Else
            For index As Integer = 0 To (count - 1)

                strOutput += arrPlayer(index).getDetails & vbNewLine
            Next
        End If
        Return strOutput

    End Function
    '================================================
    ' Procedure : findPLayer
    ' Date : 10/05/17
    ' Author : Scot Livingstone
    ' Parameters : name
    ' Returns : found
    ' Description : This is to find a player in the array
    '================================================ 
    Public Function findPlayer(ByVal name As String) As String
        'Search for a certain player'
        Dim found As String = "No player found"
        Dim index As Integer
        If count > 0 Then
            For index = 0 To (count - 1)
                If name = arrPlayer(index).getName() Then
                    found = name & " found that postion " & index + 1

                End If
            Next
        End If
        'Return that player'
        Return found
    End Function
    '================================================
    ' Procedure : removePlayer
    ' Date : 10/05/17
    ' Author : Scot Livingstone
    ' Parameters : index
    ' Returns : True or False
    ' Description : This is to remove a player form the array
    '================================================ 
    Public Function removeplayer(ByVal index As Integer) As Boolean
        'Remove a player from the database
        index = index - 1
        If (index >= count) Or (count = 0) Then
            Return False
            Exit Function
        End If
        If (index = (count - 1)) Then
            arrPlayer(index) = Nothing    'the player to remove'
            count = count - 1 'Reduce the number of players by one'
            Return True
        Else
            arrPlayer(index) = Nothing
            While (index + 1) < count
                'Set the arrary to the next player '
                arrPlayer(index) = arrPlayer(index + 1)
                index = index + 1
            End While
            count = count - 1 'Reduce the number of players by one'

            Return True

        End If
    End Function
    '================================================
    ' Procedure : findAverage
    ' Date : 10/05/17
    ' Author : Scot Livingstone
    ' Parameters : 
    ' Returns : Average
    ' Description : This is to find the average age of all the players on a team
    '================================================ 
    Public Function findAverage() As Double
        'Find the average age of the players'
        Dim index As Integer = 0
        Dim total, Average As Double

        While (index < count)
            total += arrPlayer(index).getAge()
            index += 1
        End While
        If count <> 0 Then
            Average = total / count
        End If
        Return Average
    End Function
    '================================================
    ' Procedure : getTeamDetails
    ' Date : 10/05/17
    ' Author : Scot Livingstone
    ' Parameters : 
    ' Returns : strDetails
    ' Description : This is to find all the details on each player in a team
    '================================================ 
    Public Function getTeamDetails() As String
        'Declare Details as a string' 
        Dim strTeamDetails As String
        'This will include all of the players details'
        strTeamDetails = "Games played: " + CType(played, String) + " Games Won: " + CType(won, String) + " Games Lost: " + CType(lost, String)
        'Return the players details'
        Return strTeamDetails
    End Function
    '================================================
    ' Procedure : getWin
    ' Date : 10/05/17
    ' Author : Scot Livingstone
    ' Parameters : 
    ' Returns : 
    ' Description : This is to add a game won to the team stats and a game played aswell
    '================================================ 
    Public Sub getWin()
        'add 1 to there won stats
        won += 1
        'add 1 to games played
        played += 1


    End Sub
    '================================================
    ' Procedure : getLost
    ' Date : 10/05/17
    ' Author : Scot Livingstone
    ' Parameters : 
    ' Returns : 
    ' Description : This is to add a lost and a game played to thier team stats
    '================================================ 
    Public Sub getlost()
        lost += 1
        played += 1
    End Sub


End Class
