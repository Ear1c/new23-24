Public Class Form1
    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub FileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem1.Click
        TextBox1.Clear()
    End Sub

    Private Sub SavedToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SavedToolStripMenuItem1.Click
        Dim outFile As New IO.StreamWriter("out.txt")
        outFile.Write(TextBox1.Text)
        outFile.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        Dim inFile As New IO.StreamReader("out.txt")
        If IO.File.Exists("out.txt") Then
            TextBox1.Text = inFile.ReadToEnd
            inFile.Close()
        End If

    End Sub
End Class
