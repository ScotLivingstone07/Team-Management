<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeamManagement
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoTeamTwo = New System.Windows.Forms.RadioButton()
        Me.rdoTeamOne = New System.Windows.Forms.RadioButton()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.lblTeamDetails = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lblPlayerDetails = New System.Windows.Forms.Label()
        Me.btnPlayerDetails = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.npdIndex = New System.Windows.Forms.NumericUpDown()
        Me.btnTeamDetails = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.btnWon = New System.Windows.Forms.Button()
        Me.btnLost = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.npdIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoTeamTwo)
        Me.GroupBox2.Controls.Add(Me.rdoTeamOne)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(337, 117)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select a Team"
        '
        'rdoTeamTwo
        '
        Me.rdoTeamTwo.AutoSize = True
        Me.rdoTeamTwo.Location = New System.Drawing.Point(72, 60)
        Me.rdoTeamTwo.Name = "rdoTeamTwo"
        Me.rdoTeamTwo.Size = New System.Drawing.Size(76, 17)
        Me.rdoTeamTwo.TabIndex = 1
        Me.rdoTeamTwo.TabStop = True
        Me.rdoTeamTwo.Text = "Team Two"
        Me.rdoTeamTwo.UseVisualStyleBackColor = True
        '
        'rdoTeamOne
        '
        Me.rdoTeamOne.AutoSize = True
        Me.rdoTeamOne.Location = New System.Drawing.Point(72, 28)
        Me.rdoTeamOne.Name = "rdoTeamOne"
        Me.rdoTeamOne.Size = New System.Drawing.Size(75, 17)
        Me.rdoTeamOne.TabIndex = 0
        Me.rdoTeamOne.TabStop = True
        Me.rdoTeamOne.Text = "Team One"
        Me.rdoTeamOne.UseVisualStyleBackColor = True
        '
        'btnTransfer
        '
        Me.btnTransfer.Location = New System.Drawing.Point(4, 127)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(342, 72)
        Me.btnTransfer.TabIndex = 41
        Me.btnTransfer.Text = "Transfer Player"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'lblTeamDetails
        '
        Me.lblTeamDetails.AutoSize = True
        Me.lblTeamDetails.Location = New System.Drawing.Point(126, 101)
        Me.lblTeamDetails.Name = "lblTeamDetails"
        Me.lblTeamDetails.Size = New System.Drawing.Size(69, 13)
        Me.lblTeamDetails.TabIndex = 39
        Me.lblTeamDetails.Text = "Team Details"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(6, 123)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(86, 41)
        Me.btnRemove.TabIndex = 36
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(6, 19)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(114, 48)
        Me.btnAverage.TabIndex = 35
        Me.btnAverage.Text = "Average "
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.txtPosition)
        Me.GroupBox1.Controls.Add(Me.btnFind)
        Me.GroupBox1.Controls.Add(Me.lblPosition)
        Me.GroupBox1.Controls.Add(Me.lblAge)
        Me.GroupBox1.Controls.Add(Me.btnRemove)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.btnCreate)
        Me.GroupBox1.Location = New System.Drawing.Point(352, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(494, 179)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create Players"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(98, 31)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(86, 39)
        Me.btnUpdate.TabIndex = 37
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(220, 36)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(166, 20)
        Me.txtName.TabIndex = 17
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(220, 74)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(166, 20)
        Me.txtAge.TabIndex = 16
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(221, 110)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(166, 20)
        Me.txtPosition.TabIndex = 15
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(6, 74)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(86, 43)
        Me.btnFind.TabIndex = 1
        Me.btnFind.Text = "Find Player"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(218, 95)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(44, 13)
        Me.lblPosition.TabIndex = 11
        Me.lblPosition.Text = "Position"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(218, 57)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(26, 13)
        Me.lblAge.TabIndex = 12
        Me.lblAge.Text = "Age"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(218, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "Name"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(6, 31)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(86, 39)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create Player"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lblPlayerDetails
        '
        Me.lblPlayerDetails.AutoSize = True
        Me.lblPlayerDetails.Location = New System.Drawing.Point(41, 73)
        Me.lblPlayerDetails.Name = "lblPlayerDetails"
        Me.lblPlayerDetails.Size = New System.Drawing.Size(71, 13)
        Me.lblPlayerDetails.TabIndex = 38
        Me.lblPlayerDetails.Text = "Player Details"
        '
        'btnPlayerDetails
        '
        Me.btnPlayerDetails.Location = New System.Drawing.Point(5, 18)
        Me.btnPlayerDetails.Name = "btnPlayerDetails"
        Me.btnPlayerDetails.Size = New System.Drawing.Size(107, 48)
        Me.btnPlayerDetails.TabIndex = 32
        Me.btnPlayerDetails.Text = "Details"
        Me.btnPlayerDetails.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.npdIndex)
        Me.GroupBox3.Controls.Add(Me.btnPlayerDetails)
        Me.GroupBox3.Controls.Add(Me.lblPlayerDetails)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 205)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(342, 202)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Players Details"
        '
        'npdIndex
        '
        Me.npdIndex.Location = New System.Drawing.Point(141, 18)
        Me.npdIndex.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.npdIndex.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.npdIndex.Name = "npdIndex"
        Me.npdIndex.Size = New System.Drawing.Size(33, 20)
        Me.npdIndex.TabIndex = 39
        Me.npdIndex.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnTeamDetails
        '
        Me.btnTeamDetails.Location = New System.Drawing.Point(6, 73)
        Me.btnTeamDetails.Name = "btnTeamDetails"
        Me.btnTeamDetails.Size = New System.Drawing.Size(114, 48)
        Me.btnTeamDetails.TabIndex = 40
        Me.btnTeamDetails.Text = "Details"
        Me.btnTeamDetails.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(851, 20)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(99, 45)
        Me.btnHelp.TabIndex = 43
        Me.btnHelp.Text = "Help "
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnStats)
        Me.GroupBox4.Controls.Add(Me.btnWon)
        Me.GroupBox4.Controls.Add(Me.btnLost)
        Me.GroupBox4.Controls.Add(Me.btnAverage)
        Me.GroupBox4.Controls.Add(Me.btnTeamDetails)
        Me.GroupBox4.Controls.Add(Me.lblTeamDetails)
        Me.GroupBox4.Location = New System.Drawing.Point(358, 205)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(488, 176)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Team Details"
        '
        'btnStats
        '
        Me.btnStats.Location = New System.Drawing.Point(6, 127)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(114, 43)
        Me.btnStats.TabIndex = 43
        Me.btnStats.Text = "Team Stats"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'btnWon
        '
        Me.btnWon.Location = New System.Drawing.Point(362, 15)
        Me.btnWon.Name = "btnWon"
        Me.btnWon.Size = New System.Drawing.Size(110, 51)
        Me.btnWon.TabIndex = 42
        Me.btnWon.Text = "Won"
        Me.btnWon.UseVisualStyleBackColor = True
        '
        'btnLost
        '
        Me.btnLost.Location = New System.Drawing.Point(362, 72)
        Me.btnLost.Name = "btnLost"
        Me.btnLost.Size = New System.Drawing.Size(110, 52)
        Me.btnLost.TabIndex = 41
        Me.btnLost.Text = "Lost"
        Me.btnLost.UseVisualStyleBackColor = True
        '
        'frmTeamManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 424)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmTeamManagement"
        Me.Text = "frmTeamManagement"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.npdIndex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdoTeamTwo As RadioButton
    Friend WithEvents rdoTeamOne As RadioButton
    Friend WithEvents btnTransfer As Button
    Friend WithEvents lblTeamDetails As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAverage As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents btnFind As Button
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents lblPlayerDetails As Label
    Friend WithEvents btnPlayerDetails As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents npdIndex As NumericUpDown
    Friend WithEvents btnTeamDetails As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnWon As Button
    Friend WithEvents btnLost As Button
    Friend WithEvents btnStats As Button
End Class
