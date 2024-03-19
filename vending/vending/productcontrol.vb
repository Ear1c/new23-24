Public Class productcontrol
    Public Property productid As String
    Public Property price As Decimal
    Public Property productcount As Integer
    Public Property picture As Image

    Private Sub productcontrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = picture
        idlabel.Text = productid
        pricelabel.Text = price.ToString("c2")
    End Sub
    Public Sub buy()
        If productcount > 0 Then
            productcount = productcount - 1
        End If
        If productcount = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
