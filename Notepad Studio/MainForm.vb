Imports System.IO, System.Net, System.Web, Microsoft.Win32

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://updatemanager.techlast.io/Notepad-Studio/Version.txt")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd
            Dim currentversion As String = Application.ProductVersion
            If newestversion > currentversion Then
                Label1.Text = "Ein Update ist verfügbar!"
                Label1.Enabled = True
            Else
                Label1.Text = ""
                Label1.Enabled = False
            End If
        Catch ex As Exception

        End Try
        If My.Settings.FRT = "Passed" Then

        Else
            FRT1.Show()
            Me.Close()
        End If
        If My.Settings.Theme = "Light Mode" Then
            Me.BackColor = Color.White
            Me.ForeColor = Color.Black
            Panel1.BackColor = Color.White
            Panel1.ForeColor = Color.Black
            Panel2.BackColor = Color.White
            Panel2.ForeColor = Color.Black
            Panel3.BackColor = Color.White
            Panel3.ForeColor = Color.Black
            MenuStrip1.BackColor = Color.White
            MenuStrip1.ForeColor = Color.Black
            DateiToolStripMenuItem.BackColor = Color.White
            DateiToolStripMenuItem.ForeColor = Color.Black
            NeuToolStripMenuItem.BackColor = Color.White
            NeuToolStripMenuItem.ForeColor = Color.Black
            ÖffnenToolStripMenuItem.BackColor = Color.White
            ÖffnenToolStripMenuItem.ForeColor = Color.Black
            SpeichernToolStripMenuItem.BackColor = Color.White
            SpeichernToolStripMenuItem.ForeColor = Color.Black
            DruckenToolStripMenuItem.BackColor = Color.White
            DruckenToolStripMenuItem.ForeColor = Color.Black
            BeendenToolStripMenuItem.BackColor = Color.White
            BeendenToolStripMenuItem.ForeColor = Color.Black
            BearbeitenToolStripMenuItem.BackColor = Color.White
            BearbeitenToolStripMenuItem.ForeColor = Color.Black
            RückgängigToolStripMenuItem.BackColor = Color.White
            RückgängigToolStripMenuItem.ForeColor = Color.Black
            KopierenToolStripMenuItem.BackColor = Color.White
            KopierenToolStripMenuItem.ForeColor = Color.Black
            AusschneidenToolStripMenuItem.BackColor = Color.White
            AusschneidenToolStripMenuItem.ForeColor = Color.Black
            EinfügenToolStripMenuItem.BackColor = Color.White
            EinfügenToolStripMenuItem.ForeColor = Color.Black
            AllesMarkierenToolStripMenuItem.BackColor = Color.White
            AllesMarkierenToolStripMenuItem.ForeColor = Color.Black
            FormatierenToolStripMenuItem.BackColor = Color.White
            FormatierenToolStripMenuItem.ForeColor = Color.Black
            SchriftartToolStripMenuItem.BackColor = Color.White
            SchriftartToolStripMenuItem.ForeColor = Color.Black
            SchriftfarbeToolStripMenuItem.BackColor = Color.White
            SchriftfarbeToolStripMenuItem.ForeColor = Color.Black
            HilfeToolStripMenuItem.BackColor = Color.White
            HilfeToolStripMenuItem.ForeColor = Color.Black
            NachUpdatesSuchenToolStripMenuItem.BackColor = Color.White
            NachUpdatesSuchenToolStripMenuItem.ForeColor = Color.Black
            InfoToolStripMenuItem.BackColor = Color.White
            InfoToolStripMenuItem.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox1.ForeColor = Color.Black
            Button1.Text = "Dunkles Design"
            Button1.BackColor = Color.White
            Button1.ForeColor = Color.Black
        Else
            Me.BackColor = Color.FromArgb(32, 32, 32)
            Me.ForeColor = Color.White
            Panel1.BackColor = Color.FromArgb(32, 32, 32)
            Panel1.ForeColor = Color.White
            Panel2.BackColor = Color.FromArgb(32, 32, 32)
            Panel2.ForeColor = Color.White
            Panel3.BackColor = Color.FromArgb(32, 32, 32)
            Panel3.ForeColor = Color.White
            MenuStrip1.BackColor = Color.FromArgb(32, 32, 32)
            MenuStrip1.ForeColor = Color.White
            DateiToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            DateiToolStripMenuItem.ForeColor = Color.White
            NeuToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            NeuToolStripMenuItem.ForeColor = Color.White
            ÖffnenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            ÖffnenToolStripMenuItem.ForeColor = Color.White
            SpeichernToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            SpeichernToolStripMenuItem.ForeColor = Color.White
            DruckenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            DruckenToolStripMenuItem.ForeColor = Color.White
            BeendenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            BeendenToolStripMenuItem.ForeColor = Color.White
            BearbeitenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            BearbeitenToolStripMenuItem.ForeColor = Color.White
            RückgängigToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            RückgängigToolStripMenuItem.ForeColor = Color.White
            KopierenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            KopierenToolStripMenuItem.ForeColor = Color.White
            AusschneidenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            AusschneidenToolStripMenuItem.ForeColor = Color.White
            EinfügenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            EinfügenToolStripMenuItem.ForeColor = Color.White
            AllesMarkierenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            AllesMarkierenToolStripMenuItem.ForeColor = Color.White
            FormatierenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            FormatierenToolStripMenuItem.ForeColor = Color.White
            SchriftartToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            SchriftartToolStripMenuItem.ForeColor = Color.White
            SchriftfarbeToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            SchriftfarbeToolStripMenuItem.ForeColor = Color.White
            HilfeToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            HilfeToolStripMenuItem.ForeColor = Color.White
            NachUpdatesSuchenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            NachUpdatesSuchenToolStripMenuItem.ForeColor = Color.White
            InfoToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            InfoToolStripMenuItem.ForeColor = Color.White
            TextBox1.BackColor = Color.FromArgb(32, 32, 32)
            TextBox1.ForeColor = Color.White
            Button1.Text = "Helles Design"
            Button1.BackColor = Color.FromArgb(32, 32, 32)
            Button1.ForeColor = Color.White
        End If
    End Sub

    Private Sub NeuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuToolStripMenuItem.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = ""
        Else
            Select Case MessageBox.Show("Möchten Sie Ihren Text speichern?", "Notepad Studio", MessageBoxButtons.YesNoCancel)
                Case Windows.Forms.DialogResult.Yes
                    If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
                        TextBox1.Text = ""
                    End If
                Case Windows.Forms.DialogResult.No
                    TextBox1.Text = ""
                Case Windows.Forms.DialogResult.Cancel

            End Select
        End If
    End Sub

    Private Sub ÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖffnenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub SpeichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeichernToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
        End If
    End Sub

    Private Sub DruckenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DruckenToolStripMenuItem.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(TextBox1.Text, TextBox1.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic)
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RückgängigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RückgängigToolStripMenuItem.Click
        TextBox1.Undo()
    End Sub

    Private Sub KopierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KopierenToolStripMenuItem.Click
        TextBox1.Copy()
    End Sub

    Private Sub AusschneidenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AusschneidenToolStripMenuItem.Click
        TextBox1.Cut()
    End Sub

    Private Sub EinfügenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinfügenToolStripMenuItem.Click
        TextBox1.Paste()
    End Sub

    Private Sub AllesMarkierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllesMarkierenToolStripMenuItem.Click
        TextBox1.SelectAll()
    End Sub

    Private Sub SchriftartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchriftartToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub SchriftfarbeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchriftfarbeToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub NachUpdatesSuchenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NachUpdatesSuchenToolStripMenuItem.Click
        Try
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://updatemanager.techlast.io/Notepad-Studio/Version.txt")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd
            Dim currentversion As String = Application.ProductVersion
            If newestversion > currentversion Then
                Select Case MessageBox.Show("Es ist ein Update verfügbar! Möchten Sie auf die Downloadseite verbunden werden, um das Update herunterzuladen?", "Update Manager", MessageBoxButtons.YesNo)
                    Case Windows.Forms.DialogResult.Yes
                        Process.Start("https://github.com/TECHLAST/Notepad-Studio/release")
                    Case Windows.Forms.DialogResult.No

                End Select
            Else
                MessageBox.Show("Sie verwenden die neuste Version von Notepad Studio!", "Update Manager", MessageBoxButtons.OK)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        InfoForm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Dunkles Design" Then
            Me.BackColor = Color.FromArgb(32, 32, 32)
            Me.ForeColor = Color.White
            Panel1.BackColor = Color.FromArgb(32, 32, 32)
            Panel1.ForeColor = Color.White
            Panel2.BackColor = Color.FromArgb(32, 32, 32)
            Panel2.ForeColor = Color.White
            Panel3.BackColor = Color.FromArgb(32, 32, 32)
            Panel3.ForeColor = Color.White
            MenuStrip1.BackColor = Color.FromArgb(32, 32, 32)
            MenuStrip1.ForeColor = Color.White
            DateiToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            DateiToolStripMenuItem.ForeColor = Color.White
            NeuToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            NeuToolStripMenuItem.ForeColor = Color.White
            ÖffnenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            ÖffnenToolStripMenuItem.ForeColor = Color.White
            SpeichernToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            SpeichernToolStripMenuItem.ForeColor = Color.White
            DruckenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            DruckenToolStripMenuItem.ForeColor = Color.White
            BeendenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            BeendenToolStripMenuItem.ForeColor = Color.White
            BearbeitenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            BearbeitenToolStripMenuItem.ForeColor = Color.White
            RückgängigToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            RückgängigToolStripMenuItem.ForeColor = Color.White
            KopierenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            KopierenToolStripMenuItem.ForeColor = Color.White
            AusschneidenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            AusschneidenToolStripMenuItem.ForeColor = Color.White
            EinfügenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            EinfügenToolStripMenuItem.ForeColor = Color.White
            AllesMarkierenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            AllesMarkierenToolStripMenuItem.ForeColor = Color.White
            FormatierenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            FormatierenToolStripMenuItem.ForeColor = Color.White
            SchriftartToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            SchriftartToolStripMenuItem.ForeColor = Color.White
            SchriftfarbeToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            SchriftfarbeToolStripMenuItem.ForeColor = Color.White
            HilfeToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            HilfeToolStripMenuItem.ForeColor = Color.White
            NachUpdatesSuchenToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            NachUpdatesSuchenToolStripMenuItem.ForeColor = Color.White
            InfoToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32)
            InfoToolStripMenuItem.ForeColor = Color.White
            TextBox1.BackColor = Color.FromArgb(32, 32, 32)
            TextBox1.ForeColor = Color.White
            Button1.Text = "Helles Design"
            Button1.BackColor = Color.FromArgb(32, 32, 32)
            Button1.ForeColor = Color.White
            My.Settings.Theme = "Dark Mode"
            My.Settings.Save()
        Else
            Me.BackColor = Color.White
            Me.ForeColor = Color.Black
            Panel1.BackColor = Color.White
            Panel1.ForeColor = Color.Black
            Panel2.BackColor = Color.White
            Panel2.ForeColor = Color.Black
            Panel3.BackColor = Color.White
            Panel3.ForeColor = Color.Black
            MenuStrip1.BackColor = Color.White
            MenuStrip1.ForeColor = Color.Black
            DateiToolStripMenuItem.BackColor = Color.White
            DateiToolStripMenuItem.ForeColor = Color.Black
            NeuToolStripMenuItem.BackColor = Color.White
            NeuToolStripMenuItem.ForeColor = Color.Black
            ÖffnenToolStripMenuItem.BackColor = Color.White
            ÖffnenToolStripMenuItem.ForeColor = Color.Black
            SpeichernToolStripMenuItem.BackColor = Color.White
            SpeichernToolStripMenuItem.ForeColor = Color.Black
            DruckenToolStripMenuItem.BackColor = Color.White
            DruckenToolStripMenuItem.ForeColor = Color.Black
            BeendenToolStripMenuItem.BackColor = Color.White
            BeendenToolStripMenuItem.ForeColor = Color.Black
            BearbeitenToolStripMenuItem.BackColor = Color.White
            BearbeitenToolStripMenuItem.ForeColor = Color.Black
            RückgängigToolStripMenuItem.BackColor = Color.White
            RückgängigToolStripMenuItem.ForeColor = Color.Black
            KopierenToolStripMenuItem.BackColor = Color.White
            KopierenToolStripMenuItem.ForeColor = Color.Black
            AusschneidenToolStripMenuItem.BackColor = Color.White
            AusschneidenToolStripMenuItem.ForeColor = Color.Black
            EinfügenToolStripMenuItem.BackColor = Color.White
            EinfügenToolStripMenuItem.ForeColor = Color.Black
            AllesMarkierenToolStripMenuItem.BackColor = Color.White
            AllesMarkierenToolStripMenuItem.ForeColor = Color.Black
            FormatierenToolStripMenuItem.BackColor = Color.White
            FormatierenToolStripMenuItem.ForeColor = Color.Black
            SchriftartToolStripMenuItem.BackColor = Color.White
            SchriftartToolStripMenuItem.ForeColor = Color.Black
            SchriftfarbeToolStripMenuItem.BackColor = Color.White
            SchriftfarbeToolStripMenuItem.ForeColor = Color.Black
            HilfeToolStripMenuItem.BackColor = Color.White
            HilfeToolStripMenuItem.ForeColor = Color.Black
            NachUpdatesSuchenToolStripMenuItem.BackColor = Color.White
            NachUpdatesSuchenToolStripMenuItem.ForeColor = Color.Black
            InfoToolStripMenuItem.BackColor = Color.White
            InfoToolStripMenuItem.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox1.ForeColor = Color.Black
            Button1.Text = "Dunkles Design"
            Button1.BackColor = Color.White
            Button1.ForeColor = Color.Black
            My.Settings.Theme = "Light Mode"
            My.Settings.Save()
        End If
    End Sub

    Private Sub TextBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub TextBoxDrop_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox1.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            MyFiles = e.Data.GetData(DataFormats.FileDrop)
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(MyFiles(0))
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Select Case MessageBox.Show("Es ist ein Update verfügbar! Möchten Sie auf die Downloadseite verbunden werden, um das Update herunterzuladen?", "Update Manager", MessageBoxButtons.YesNo)
            Case Windows.Forms.DialogResult.Yes
                Process.Start("https://github.com/TECHLAST/Notepad-Studio/release")
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub MainForm_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        If TextBox1.Text = "" Then

        Else
            Select Case MessageBox.Show("Möchten Sie Ihren Text speichern?", "Notepad Studio", MessageBoxButtons.YesNo)
                Case Windows.Forms.DialogResult.Yes
                    If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
                    End If
                Case Windows.Forms.DialogResult.No
            End Select
        End If
    End Sub
End Class