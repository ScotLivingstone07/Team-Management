Public Class Player
    '=================================================
    ' Class : Player
    ' Project : Team Management
    ' Version : 1.0
    ' Date : 10/05/17
    ' Author : Scot Livingstone 
    ' Description : This class contains the details of the players that are going to be playing for the teams in the applaciton. 
    '================================================= 
    Private name As String
    Private age As Integer
    Private position As String

    '================================================
    ' Procedure : new
    ' Date : 10/05/17
    ' Author : Scot Livingstone
    ' Parameters : name, age and postion
    ' Returns : 
    ' Description : This is for creating a new player
    '================================================ 
    Public Sub New(ByVal parName As String, ByVal parAge As String, ByVal parPosition As String)
        'Set the varibales for the created object
        Me.name = parName
        Me.age = parAge
        Me.position = parPosition

    End Sub
    '================================================
    ' Procedure : getName
    ' Date : 10/05/17
    ' Author : Scot Livingstone
    ' Parameters : 
    ' Returns : name
    ' Description : To get the name of the player
    '================================================ 
    Public Function getName() As String
        'Return the players name'
        Return name
    End Function
    '================================================
    ' Procedure : getDetails
    ' Date : 10/05/17
    ' Author : Scot Livingstone
    ' Parameters : 
    ' Returns : strDetails
    ' Description : This will get the player name, age and postion
    '================================================ 
    Public Function getDetails() As String
        'Declare Details as a string' 
        Dim strDetails As String
        'This will include all of the players details'
        strDetails = name + " " + CType(age, String) + " " + position
        'Return the players details'
        Return strDetails
    End Function
    '================================================
    ' Procedure : getAge
    ' Date : 10/05/17
    ' Author : Scot Livingstone
    ' Parameters : 
    ' Returns : dlbAge
    ' Description : This will get the players age
    '================================================ 
    Public Function getAge()
        'find the age of the player
        Dim dlbAge As Double
        dlbAge = age
        Return dlbAge
    End Function



End Class
