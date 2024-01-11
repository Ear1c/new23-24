Public Class Form1
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        PictureBox1.Image = Nothing
        field1.Text = ""
        field2.Text = ""
        field3.Text = ""
        field4.Text = ""
        field5.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        Dim outfile As New IO.StreamWriter("data.txt")
        outfile.Write(field1.Text)
        outfile.Write("|")
        outfile.Write(field2.Text)
        outfile.Write("|")
        outfile.Write(field3.Text)
        outfile.Write("|")
        outfile.Write(field4.Text)
        outfile.Write("|")
        outfile.Write(field5.Text)
        outfile.Write("|")
        outfile.Write(PictureBox1.ImageLocation)
        outfile.WriteLine()
        outfile.Close()
    End Sub
End Class
