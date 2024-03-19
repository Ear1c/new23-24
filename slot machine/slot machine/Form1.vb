Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = Not Timer1.Enabled
    End Sub
    Public Sub spin()
        'get random number
        Dim rand As New Random
        Dim r As Integer
        r = rand.Next(ImageList1.Images.Count)
        Label1.Text = r


        'show a picture from image list
        PictureBox1.Image = ImageList1.Images(r)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        spin()
    End Sub
End Class
