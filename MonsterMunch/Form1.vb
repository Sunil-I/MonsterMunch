Public Class Form1
    Private this = Me
    Private intMonVelX As Integer = 5
    Private intMonVelY As Integer = 5
    Private intMonVelMax As Integer = 10

    Private Sub game_ticker_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles game_ticker.Tick
        Call MoveMonster()
        Call MonsterHitPlayer()
        Call HitRegenBox()
    End Sub


    Private Sub MoveMonster()
        ' Accelerates the monster on the X plane
        If pic_monster.Left < pic_player.Left Then
            If intMonVelX < intMonVelMax Then
                intMonVelX += 1
            End If
        Else
            If intMonVelX > -intMonVelMax Then
                intMonVelX -= 1
            End If
        End If
        ' Accelerates the monster on the Y plane
        If pic_monster.Top < pic_player.Top Then
            If intMonVelY < intMonVelMax Then
                intMonVelY += 1
            End If
        Else
            If intMonVelY > -intMonVelMax Then
                intMonVelY -= 1
            End If
        End If
        ' Moves the monster
        pic_monster.Left += intMonVelX
        pic_monster.Top += intMonVelY
    End Sub

    Private Sub MonsterHitPlayer()
        If pic_player.Bounds.IntersectsWith(pic_monster.Bounds) Then
            this.backcolor = Color.Red
            If health.Value - 4 < health.Minimum Then
                health.Value = 0
                game_ticker.Enabled = False
                MsgBox("you are dead")
            Else
                health.Value = health.Value - 5
            End If
        Else
            this.backcolor = Color.White

        End If


    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        pic_player.Top = e.Y - pic_player.Width / 2
        pic_player.Left = e.X - pic_player.Height / 2
    End Sub

    Private Sub HitRegenBox()
        If pic_player.Bounds.IntersectsWith(RegenBox.Bounds) Then
            If health.Value < health.Maximum Then
                health.Value = health.Value + 1
            End If
        End If
    End Sub
End Class
