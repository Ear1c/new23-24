Public Class Form1
    Dim movespeed As Integer = 15
    Dim isjumping As Boolean
    Dim points As Integer

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown, MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrright.Start()
            Case Keys.Left
                tmrleft.Start()
            Case Keys.Up
                tmrup.Start()
                isjumping = True
        End Select
    End Sub

    Private Sub tmrright_Tick(sender As Object, e As EventArgs) Handles tmrright.Tick
        Picplayer.Left += movespeed
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp, MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrright.Stop()
            Case Keys.Left
                tmrleft.Stop()
            Case Keys.Up
                tmrup.Stop()
                isjumping = False
        End Select
    End Sub

    Private Sub tmrleft_Tick(sender As Object, e As EventArgs) Handles tmrleft.Tick
        Picplayer.Left -= movespeed
    End Sub

    Private Sub tmrup_Tick(sender As Object, e As EventArgs) Handles tmrup.Tick
        Picplayer.Top -= movespeed
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrgamelogic.Start()
        TextBox1.Select()
    End Sub

    Private Sub tmrgamelogic_Tick(sender As Object, e As EventArgs) Handles tmrgamelogic.Tick
        If Picplayer.Bounds.IntersectsWith(Picground.Bounds) Then
            tmrgravity.Stop()

        Else
            If isjumping = False Then
                tmrgravity.Start()
            End If

        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrgravity.Stop()
                    End If
                End If
                If b.Tag = "win" Then
                    If Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        PictureBox5.Visible = False
                        Label2.Text = +2
                    End If
                    End If
                If b.Tag = "win2" Then
                    If Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        PictureBox6.Visible = False
                        Label2.Text = +1
                    End If
                End If
                If b.Tag = "win3" Then
                    If Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        PictureBox8.Visible = False
                        Label2.Text = +3
                        Label3.Text = "YOU WIN!!!"
                    End If
                End If
                If b.Tag = "lose" Then
                    If Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        PictureBox7.Visible = False
                        Label2.Text = 2
                        Label3.Text = "Lose a point"
                    End If
                End If
            End If
        Next

    End Sub

    Private Sub tmrgravity_Tick(sender As Object, e As EventArgs) Handles tmrgravity.Tick
        Picplayer.Top += movespeed
    End Sub

End Class
