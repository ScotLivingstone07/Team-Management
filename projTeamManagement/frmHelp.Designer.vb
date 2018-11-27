<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.lblTeamDetails = New System.Windows.Forms.Label()
        Me.lblTransfer = New System.Windows.Forms.Label()
        Me.lblStats = New System.Windows.Forms.Label()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.rdoPlayer = New System.Windows.Forms.RadioButton()
        Me.rdoTransfer = New System.Windows.Forms.RadioButton()
        Me.rdoDetails = New System.Windows.Forms.RadioButton()
        Me.rdoTeamDetails = New System.Windows.Forms.RadioButton()
        Me.rdoStats = New System.Windows.Forms.RadioButton()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDetails
        '
        Me.lblDetails.Location = New System.Drawing.Point(18, 101)
        Me.lblDetails.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(579, 196)
        Me.lblDetails.TabIndex = 6
        Me.lblDetails.Text = resources.GetString("lblDetails.Text")
        '
        'lblTeamDetails
        '
        Me.lblTeamDetails.Location = New System.Drawing.Point(18, 101)
        Me.lblTeamDetails.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTeamDetails.Name = "lblTeamDetails"
        Me.lblTeamDetails.Size = New System.Drawing.Size(579, 178)
        Me.lblTeamDetails.TabIndex = 7
        Me.lblTeamDetails.Text = resources.GetString("lblTeamDetails.Text")
        '
        'lblTransfer
        '
        Me.lblTransfer.Location = New System.Drawing.Point(18, 101)
        Me.lblTransfer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTransfer.Name = "lblTransfer"
        Me.lblTransfer.Size = New System.Drawing.Size(579, 178)
        Me.lblTransfer.TabIndex = 8
        Me.lblTransfer.Text = resources.GetString("lblTransfer.Text")
        '
        'lblStats
        '
        Me.lblStats.Location = New System.Drawing.Point(18, 101)
        Me.lblStats.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(579, 205)
        Me.lblStats.TabIndex = 9
        Me.lblStats.Text = resources.GetString("lblStats.Text")
        '
        'lblPlayer
        '
        Me.lblPlayer.Location = New System.Drawing.Point(15, 101)
        Me.lblPlayer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(579, 205)
        Me.lblPlayer.TabIndex = 10
        Me.lblPlayer.Text = resources.GetString("lblPlayer.Text")
        '
        'rdoPlayer
        '
        Me.rdoPlayer.AutoSize = True
        Me.rdoPlayer.Location = New System.Drawing.Point(4, 17)
        Me.rdoPlayer.Margin = New System.Windows.Forms.Padding(2)
        Me.rdoPlayer.Name = "rdoPlayer"
        Me.rdoPlayer.Size = New System.Drawing.Size(133, 17)
        Me.rdoPlayer.TabIndex = 11
        Me.rdoPlayer.TabStop = True
        Me.rdoPlayer.Text = "Adding player too team"
        Me.rdoPlayer.UseVisualStyleBackColor = True
        '
        'rdoTransfer
        '
        Me.rdoTransfer.AutoSize = True
        Me.rdoTransfer.Location = New System.Drawing.Point(267, 17)
        Me.rdoTransfer.Margin = New System.Windows.Forms.Padding(2)
        Me.rdoTransfer.Name = "rdoTransfer"
        Me.rdoTransfer.Size = New System.Drawing.Size(109, 17)
        Me.rdoTransfer.TabIndex = 12
        Me.rdoTransfer.TabStop = True
        Me.rdoTransfer.Text = "Transfering player"
        Me.rdoTransfer.UseVisualStyleBackColor = True
        '
        'rdoDetails
        '
        Me.rdoDetails.AutoSize = True
        Me.rdoDetails.Location = New System.Drawing.Point(140, 17)
        Me.rdoDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.rdoDetails.Name = "rdoDetails"
        Me.rdoDetails.Size = New System.Drawing.Size(123, 17)
        Me.rdoDetails.TabIndex = 13
        Me.rdoDetails.TabStop = True
        Me.rdoDetails.Text = "Finding player details"
        Me.rdoDetails.UseVisualStyleBackColor = True
        '
        'rdoTeamDetails
        '
        Me.rdoTeamDetails.AutoSize = True
        Me.rdoTeamDetails.Location = New System.Drawing.Point(140, 39)
        Me.rdoTeamDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.rdoTeamDetails.Name = "rdoTeamDetails"
        Me.rdoTeamDetails.Size = New System.Drawing.Size(118, 17)
        Me.rdoTeamDetails.TabIndex = 14
        Me.rdoTeamDetails.TabStop = True
        Me.rdoTeamDetails.Text = "Finding team details"
        Me.rdoTeamDetails.UseVisualStyleBackColor = True
        '
        'rdoStats
        '
        Me.rdoStats.AutoSize = True
        Me.rdoStats.Location = New System.Drawing.Point(4, 39)
        Me.rdoStats.Margin = New System.Windows.Forms.Padding(2)
        Me.rdoStats.Name = "rdoStats"
        Me.rdoStats.Size = New System.Drawing.Size(125, 17)
        Me.rdoStats.TabIndex = 15
        Me.rdoStats.TabStop = True
        Me.rdoStats.Text = "Recording team stats"
        Me.rdoStats.UseVisualStyleBackColor = True
        '
        'btnMain
        '
        Me.btnMain.Location = New System.Drawing.Point(9, 320)
        Me.btnMain.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(113, 37)
        Me.btnMain.TabIndex = 16
        Me.btnMain.Text = "Team Management"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoPlayer)
        Me.GroupBox1.Controls.Add(Me.rdoDetails)
        Me.GroupBox1.Controls.Add(Me.rdoTeamDetails)
        Me.GroupBox1.Controls.Add(Me.rdoStats)
        Me.GroupBox1.Controls.Add(Me.rdoTransfer)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(381, 89)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select the topic that you need help with"
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 358)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.lblStats)
        Me.Controls.Add(Me.lblTransfer)
        Me.Controls.Add(Me.lblTeamDetails)
        Me.Controls.Add(Me.lblDetails)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmHelp"
        Me.Text = "Help"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDetails As Label
    Friend WithEvents lblTeamDetails As Label
    Friend WithEvents lblTransfer As Label
    Friend WithEvents lblStats As Label
    Friend WithEvents lblPlayer As Label
    Friend WithEvents rdoPlayer As RadioButton
    Friend WithEvents rdoTransfer As RadioButton
    Friend WithEvents rdoDetails As RadioButton
    Friend WithEvents rdoTeamDetails As RadioButton
    Friend WithEvents rdoStats As RadioButton
    Friend WithEvents btnMain As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
