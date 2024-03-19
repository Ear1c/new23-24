Imports System.Net.Security

Public Class Form1
    Dim WithEvents cs As New CoinSlot

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.insertdollar()
        Label1.Text = cs.total.ToString("c2")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertquarter()
        Label1.Text = cs.total.ToString("c2")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertdime()
        Label1.Text = cs.total.ToString("c2")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertnickle()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.coinreturn()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_coinreturnevent(d As Integer, q As Integer, dm As Integer, n As Integer) Handles cs.coinreturnevent
        If d > 0 Then
            dollarpb.Visible = True
        Else
            dollarpb.Visible = False
        End If

        If q > 0 Then
            quarterpb.Visible = True
        Else
            quarterpb.Visible = False
        End If

        If dm > 0 Then
            dimepb.Visible = True
        Else
            dimepb.Visible = False
        End If

        If n > 0 Then
            nicklepb.Visible = True
        Else
            nicklepb.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case idtextbox.Text
            Case Productcontrol1.productid
                cs.buy(Productcontrol1)
            Case 2

            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")

        Select Case idtextbox.Text
            Case Productcontrol2.productid
                cs.buy(Productcontrol2)
            Case 2

            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")

        Select Case idtextbox.Text
            Case Productcontrol3.productid
                cs.buy(Productcontrol3)
            Case 2

            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")

        Select Case idtextbox.Text
            Case Productcontrol4.productid
                cs.buy(Productcontrol4)
            Case 2

            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")

        Select Case idtextbox.Text
            Case Productcontrol5.productid
                cs.buy(Productcontrol5)
            Case 2

            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")

        Select Case idtextbox.Text
            Case Productcontrol6.productid
                cs.buy(Productcontrol6)
            Case 2

            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")

        Select Case idtextbox.Text
            Case Productcontrol7.productid
                cs.buy(Productcontrol7)
            Case 2

            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")

        Select Case idtextbox.Text
            Case Productcontrol8.productid
                cs.buy(Productcontrol8)
            Case 2

            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")

        Select Case idtextbox.Text
            Case Productcontrol9.productid
                cs.buy(Productcontrol9)
            Case 2

            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")

        Select Case idtextbox.Text
            Case Productcontrol10.productid
                cs.buy(Productcontrol10)
            Case 2

            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")

        Select Case idtextbox.Text
            Case Productcontrol11.productid
                cs.buy(Productcontrol11)
            Case 2

            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")

        Select Case idtextbox.Text
            Case Productcontrol12.productid
                cs.buy(Productcontrol12)
            Case 2

            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")

        Select Case idtextbox.Text
            Case Productcontrol13.productid
                cs.buy(Productcontrol13)
            Case 2

            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")

        Select Case idtextbox.Text
            Case Productcontrol14.productid
                cs.buy(Productcontrol14)
            Case 2

            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")

        Select Case idtextbox.Text
            Case Productcontrol15.productid
                cs.buy(Productcontrol15)
            Case 2

            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")

        Select Case idtextbox.Text
            Case Productcontrol16.productid
                cs.buy(Productcontrol16)
            Case 2

            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_dispense(p As Image) Handles cs.dispense
        productpb.Image = p
    End Sub
End Class
