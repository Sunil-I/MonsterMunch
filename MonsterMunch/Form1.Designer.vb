<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.pic_player = New System.Windows.Forms.PictureBox()
        Me.pic_monster = New System.Windows.Forms.PictureBox()
        Me.game_ticker = New System.Windows.Forms.Timer(Me.components)
        Me.health = New System.Windows.Forms.ProgressBar()
        Me.RegenBox = New System.Windows.Forms.PictureBox()
        CType(Me.pic_player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_monster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegenBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_player
        '
        Me.pic_player.BackColor = System.Drawing.Color.Olive
        Me.pic_player.Enabled = False
        Me.pic_player.Location = New System.Drawing.Point(53, 158)
        Me.pic_player.Name = "pic_player"
        Me.pic_player.Size = New System.Drawing.Size(26, 26)
        Me.pic_player.TabIndex = 0
        Me.pic_player.TabStop = False
        '
        'pic_monster
        '
        Me.pic_monster.BackColor = System.Drawing.Color.Brown
        Me.pic_monster.Enabled = False
        Me.pic_monster.Location = New System.Drawing.Point(403, 92)
        Me.pic_monster.Name = "pic_monster"
        Me.pic_monster.Size = New System.Drawing.Size(144, 92)
        Me.pic_monster.TabIndex = 1
        Me.pic_monster.TabStop = False
        '
        'game_ticker
        '
        Me.game_ticker.Enabled = True
        '
        'health
        '
        Me.health.Location = New System.Drawing.Point(3, 440)
        Me.health.Name = "health"
        Me.health.Size = New System.Drawing.Size(594, 23)
        Me.health.TabIndex = 2
        Me.health.Value = 100
        '
        'RegenBox
        '
        Me.RegenBox.BackColor = System.Drawing.Color.BlueViolet
        Me.RegenBox.Location = New System.Drawing.Point(224, 267)
        Me.RegenBox.Name = "RegenBox"
        Me.RegenBox.Size = New System.Drawing.Size(22, 24)
        Me.RegenBox.TabIndex = 3
        Me.RegenBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 475)
        Me.Controls.Add(Me.RegenBox)
        Me.Controls.Add(Me.health)
        Me.Controls.Add(Me.pic_monster)
        Me.Controls.Add(Me.pic_player)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pic_player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_monster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegenBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pic_player As System.Windows.Forms.PictureBox
    Friend WithEvents pic_monster As System.Windows.Forms.PictureBox
    Friend WithEvents game_ticker As System.Windows.Forms.Timer
    Friend WithEvents health As System.Windows.Forms.ProgressBar
    Friend WithEvents RegenBox As System.Windows.Forms.PictureBox

End Class
