Public Class Form2
    Dim price As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            price += 10 * NumericUpDown1.Value
            Pricelabel.Text = price
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            price += 12 * NumericUpDown1.Value
            Pricelabel.Text = price
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            price += 15 * NumericUpDown1.Value
            Pricelabel.Text = price
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            price += 17 * NumericUpDown1.Value
            Pricelabel.Text = price
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            price += 20 * NumericUpDown1.Value
            Pricelabel.Text = price
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            price += 5 * NumericUpDown1.Value
            Pricelabel.Text = price
            Label7.Text = "yes"
        Else
            Label7.Text = "no"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Label12.Text = "yes"
            CheckBox3.Checked = False
        Else
            Label12.Text = "no"
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Label11.Text = "yes"
            CheckBox2.Checked = False
        Else
            Label11.Text = "no"
        End If
    End Sub
End Class