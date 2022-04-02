Public Class InfoForm
    Private Sub InfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Application.ProductName
        Label3.Text = Application.ProductVersion
        If MainForm.BackColor = Color.White Then
            Me.BackColor = Color.White
            Me.ForeColor = Color.Black
            Label1.BackColor = Color.White
            Label1.ForeColor = Color.Black
            Label2.BackColor = Color.White
            Label2.ForeColor = Color.Black
            Label3.BackColor = Color.White
            Label3.ForeColor = Color.Black
            Label4.BackColor = Color.White
            Label4.ForeColor = Color.Black
            Button1.BackColor = Color.White
            Button1.ForeColor = Color.Black
        Else
            Me.BackColor = Color.FromArgb(32, 32, 32)
            Me.ForeColor = Color.White
            Label1.BackColor = Color.FromArgb(32, 32, 32)
            Label1.ForeColor = Color.White
            Label2.BackColor = Color.FromArgb(32, 32, 32)
            Label2.ForeColor = Color.White
            Label3.BackColor = Color.FromArgb(32, 32, 32)
            Label3.ForeColor = Color.White
            Label4.BackColor = Color.FromArgb(32, 32, 32)
            Label4.ForeColor = Color.White
            Button1.BackColor = Color.FromArgb(32, 32, 32)
            Button1.ForeColor = Color.White
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class