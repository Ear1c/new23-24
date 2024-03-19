Imports System.Security.Cryptography

Public Class Form1
    Dim cs As New CoinSlot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cs.total >= 1 Then
            Reelcontrol1.spin()
            Reelcontrol2.spin()
            Reelcontrol3.spin()
            cs.spin()
            Timer1.Enabled = True
            Label4.Text = cs.total.ToString("C2")
        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.insertdollar()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertquarter()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertdime()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertnickle()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Reelcontrol1.itemvalue
        Label2.Text = Reelcontrol2.itemvalue
        Label3.Text = Reelcontrol3.itemvalue
        Timer1.Enabled = False
        If Reelcontrol1.itemvalue = Reelcontrol2.itemvalue And Reelcontrol2.itemvalue = Reelcontrol3.itemvalue Then
            Me.BackColor = Color.Green
            TextBox1.Visible = True
            TextBox2.Text = +10
        Else
            Me.BackColor = Color.White
            TextBox1.Visible = False
        End If
    End Sub

End Class
