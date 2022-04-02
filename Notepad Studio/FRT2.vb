Public Class FRT2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FRT1.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = True
        Me.BackColor = Color.White
        Me.ForeColor = Color.Black
        Button1.BackColor = Color.White
        Button1.ForeColor = Color.Black
        Button2.BackColor = Color.White
        Button2.ForeColor = Color.Black
        Button3.BackColor = Color.White
        Button3.ForeColor = Color.Black
        Button4.BackColor = Color.White
        Button4.ForeColor = Color.Black
        Label1.BackColor = Color.White
        Label1.ForeColor = Color.Black
        Label2.BackColor = Color.White
        Label2.ForeColor = Color.Black
        My.Settings.Theme = "Light Mode"
        My.Settings.Save()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button1.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = False
        Me.BackColor = Color.FromArgb(32, 32, 32)
        Me.ForeColor = Color.White
        Button1.BackColor = Color.FromArgb(32, 32, 32)
        Button1.ForeColor = Color.White
        Button2.BackColor = Color.FromArgb(32, 32, 32)
        Button2.ForeColor = Color.White
        Button3.BackColor = Color.FromArgb(32, 32, 32)
        Button3.ForeColor = Color.White
        Button4.BackColor = Color.FromArgb(32, 32, 32)
        Button4.ForeColor = Color.White
        Label1.BackColor = Color.FromArgb(32, 32, 32)
        Label1.ForeColor = Color.White
        Label2.BackColor = Color.FromArgb(32, 32, 32)
        Label2.ForeColor = Color.White
        My.Settings.Theme = "Dark Mode"
        My.Settings.Save()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.FRT = "Passed"
        My.Settings.Save()
        MainForm.Show()
        Me.Close()
    End Sub
End Class