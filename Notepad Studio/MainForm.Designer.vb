<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DruckenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RückgängigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AusschneidenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinfügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllesMarkierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchriftartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchriftfarbeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NachUpdatesSuchenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1017, 24)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(259, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ein Update ist verfügbar!"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.BearbeitenToolStripMenuItem, Me.FormatierenToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1017, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.ÖffnenToolStripMenuItem, Me.SpeichernToolStripMenuItem, Me.DruckenToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.NeuToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.NeuToolStripMenuItem.Text = "Neu"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ÖffnenToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ÖffnenToolStripMenuItem.Text = "Öffnen"
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.SpeichernToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SpeichernToolStripMenuItem.Text = "Speichern"
        '
        'DruckenToolStripMenuItem
        '
        Me.DruckenToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.DruckenToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.DruckenToolStripMenuItem.Name = "DruckenToolStripMenuItem"
        Me.DruckenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.DruckenToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.DruckenToolStripMenuItem.Text = "Drucken"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.BeendenToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.BearbeitenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RückgängigToolStripMenuItem, Me.KopierenToolStripMenuItem, Me.AusschneidenToolStripMenuItem, Me.EinfügenToolStripMenuItem, Me.AllesMarkierenToolStripMenuItem})
        Me.BearbeitenToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BearbeitenToolStripMenuItem.Text = "Bearbeiten"
        '
        'RückgängigToolStripMenuItem
        '
        Me.RückgängigToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.RückgängigToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.RückgängigToolStripMenuItem.Name = "RückgängigToolStripMenuItem"
        Me.RückgängigToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.RückgängigToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.RückgängigToolStripMenuItem.Text = "Rückgängig"
        '
        'KopierenToolStripMenuItem
        '
        Me.KopierenToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.KopierenToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.KopierenToolStripMenuItem.Name = "KopierenToolStripMenuItem"
        Me.KopierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.KopierenToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.KopierenToolStripMenuItem.Text = "Kopieren"
        '
        'AusschneidenToolStripMenuItem
        '
        Me.AusschneidenToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.AusschneidenToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AusschneidenToolStripMenuItem.Name = "AusschneidenToolStripMenuItem"
        Me.AusschneidenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.AusschneidenToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AusschneidenToolStripMenuItem.Text = "Ausschneiden"
        '
        'EinfügenToolStripMenuItem
        '
        Me.EinfügenToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.EinfügenToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.EinfügenToolStripMenuItem.Name = "EinfügenToolStripMenuItem"
        Me.EinfügenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.EinfügenToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.EinfügenToolStripMenuItem.Text = "Einfügen"
        '
        'AllesMarkierenToolStripMenuItem
        '
        Me.AllesMarkierenToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.AllesMarkierenToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AllesMarkierenToolStripMenuItem.Name = "AllesMarkierenToolStripMenuItem"
        Me.AllesMarkierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AllesMarkierenToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AllesMarkierenToolStripMenuItem.Text = "Alles markieren"
        '
        'FormatierenToolStripMenuItem
        '
        Me.FormatierenToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.FormatierenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SchriftartToolStripMenuItem, Me.SchriftfarbeToolStripMenuItem})
        Me.FormatierenToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FormatierenToolStripMenuItem.Name = "FormatierenToolStripMenuItem"
        Me.FormatierenToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.FormatierenToolStripMenuItem.Text = "Formatieren"
        '
        'SchriftartToolStripMenuItem
        '
        Me.SchriftartToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.SchriftartToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.SchriftartToolStripMenuItem.Name = "SchriftartToolStripMenuItem"
        Me.SchriftartToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SchriftartToolStripMenuItem.Text = "Schriftart"
        '
        'SchriftfarbeToolStripMenuItem
        '
        Me.SchriftfarbeToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.SchriftfarbeToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.SchriftfarbeToolStripMenuItem.Name = "SchriftfarbeToolStripMenuItem"
        Me.SchriftfarbeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SchriftfarbeToolStripMenuItem.Text = "Schriftfarbe"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NachUpdatesSuchenToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.HilfeToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "Hilfe"
        '
        'NachUpdatesSuchenToolStripMenuItem
        '
        Me.NachUpdatesSuchenToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.NachUpdatesSuchenToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.NachUpdatesSuchenToolStripMenuItem.Name = "NachUpdatesSuchenToolStripMenuItem"
        Me.NachUpdatesSuchenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.NachUpdatesSuchenToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.NachUpdatesSuchenToolStripMenuItem.Text = "Nach Updates suchen"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.InfoToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 664)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(53, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Dunkles Design"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 664)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(200, 24)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(817, 664)
        Me.Panel3.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.AllowDrop = True
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(817, 664)
        Me.TextBox1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Textdatei (*.txt) | *.txt"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Unbenannt.txt"
        Me.SaveFileDialog1.Filter = "Textdatei (*.txt) | *.txt"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'FontDialog1
        '
        Me.FontDialog1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1017, 688)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notepad Studio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÖffnenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpeichernToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DruckenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RückgängigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KopierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AusschneidenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EinfügenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllesMarkierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SchriftartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SchriftfarbeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NachUpdatesSuchenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Label1 As Label
End Class
