<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmulatorenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComputerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KonsolenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AmigaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.C64ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtariToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NintendoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SegaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SonyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SNESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.N64ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameCubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MegaDriveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PSPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaystationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Playstation2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.EmulatorenToolStripMenuItem, Me.GamesToolStripMenuItem, Me.CheatsToolStripMenuItem, Me.ExtrasToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(506, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'EmulatorenToolStripMenuItem
        '
        Me.EmulatorenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComputerToolStripMenuItem, Me.KonsolenToolStripMenuItem})
        Me.EmulatorenToolStripMenuItem.Name = "EmulatorenToolStripMenuItem"
        Me.EmulatorenToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.EmulatorenToolStripMenuItem.Text = "Emulatoren"
        '
        'GamesToolStripMenuItem
        '
        Me.GamesToolStripMenuItem.Name = "GamesToolStripMenuItem"
        Me.GamesToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.GamesToolStripMenuItem.Text = "Games"
        '
        'CheatsToolStripMenuItem
        '
        Me.CheatsToolStripMenuItem.Name = "CheatsToolStripMenuItem"
        Me.CheatsToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.CheatsToolStripMenuItem.Text = "Cheats"
        '
        'ExtrasToolStripMenuItem
        '
        Me.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem"
        Me.ExtrasToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ExtrasToolStripMenuItem.Text = "Extras"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "Hilfe"
        '
        'ComputerToolStripMenuItem
        '
        Me.ComputerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AmigaToolStripMenuItem, Me.C64ToolStripMenuItem})
        Me.ComputerToolStripMenuItem.Name = "ComputerToolStripMenuItem"
        Me.ComputerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ComputerToolStripMenuItem.Text = "Computer"
        '
        'KonsolenToolStripMenuItem
        '
        Me.KonsolenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtariToolStripMenuItem, Me.NintendoToolStripMenuItem, Me.SegaToolStripMenuItem, Me.SonyToolStripMenuItem})
        Me.KonsolenToolStripMenuItem.Name = "KonsolenToolStripMenuItem"
        Me.KonsolenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KonsolenToolStripMenuItem.Text = "Konsolen"
        '
        'AmigaToolStripMenuItem
        '
        Me.AmigaToolStripMenuItem.Name = "AmigaToolStripMenuItem"
        Me.AmigaToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.AmigaToolStripMenuItem.Text = "Amiga"
        '
        'C64ToolStripMenuItem
        '
        Me.C64ToolStripMenuItem.Name = "C64ToolStripMenuItem"
        Me.C64ToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.C64ToolStripMenuItem.Text = "C-64"
        '
        'AtariToolStripMenuItem
        '
        Me.AtariToolStripMenuItem.Name = "AtariToolStripMenuItem"
        Me.AtariToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AtariToolStripMenuItem.Text = "Atari"
        '
        'NintendoToolStripMenuItem
        '
        Me.NintendoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NESToolStripMenuItem, Me.SNESToolStripMenuItem, Me.N64ToolStripMenuItem, Me.GameCubeToolStripMenuItem})
        Me.NintendoToolStripMenuItem.Name = "NintendoToolStripMenuItem"
        Me.NintendoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NintendoToolStripMenuItem.Text = "Nintendo"
        '
        'SegaToolStripMenuItem
        '
        Me.SegaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterSystemToolStripMenuItem, Me.MegaDriveToolStripMenuItem})
        Me.SegaToolStripMenuItem.Name = "SegaToolStripMenuItem"
        Me.SegaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SegaToolStripMenuItem.Text = "Sega"
        '
        'SonyToolStripMenuItem
        '
        Me.SonyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PSPToolStripMenuItem, Me.PlaystationToolStripMenuItem, Me.Playstation2ToolStripMenuItem})
        Me.SonyToolStripMenuItem.Name = "SonyToolStripMenuItem"
        Me.SonyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SonyToolStripMenuItem.Text = "Sony"
        '
        'NESToolStripMenuItem
        '
        Me.NESToolStripMenuItem.Name = "NESToolStripMenuItem"
        Me.NESToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NESToolStripMenuItem.Text = "NES"
        '
        'SNESToolStripMenuItem
        '
        Me.SNESToolStripMenuItem.Name = "SNESToolStripMenuItem"
        Me.SNESToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SNESToolStripMenuItem.Text = "SNES"
        '
        'N64ToolStripMenuItem
        '
        Me.N64ToolStripMenuItem.Name = "N64ToolStripMenuItem"
        Me.N64ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.N64ToolStripMenuItem.Text = "N64"
        '
        'GameCubeToolStripMenuItem
        '
        Me.GameCubeToolStripMenuItem.Name = "GameCubeToolStripMenuItem"
        Me.GameCubeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GameCubeToolStripMenuItem.Text = "GameCube"
        '
        'MasterSystemToolStripMenuItem
        '
        Me.MasterSystemToolStripMenuItem.Name = "MasterSystemToolStripMenuItem"
        Me.MasterSystemToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.MasterSystemToolStripMenuItem.Text = "Master System"
        '
        'MegaDriveToolStripMenuItem
        '
        Me.MegaDriveToolStripMenuItem.Name = "MegaDriveToolStripMenuItem"
        Me.MegaDriveToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.MegaDriveToolStripMenuItem.Text = "Mega Drive"
        '
        'PSPToolStripMenuItem
        '
        Me.PSPToolStripMenuItem.Name = "PSPToolStripMenuItem"
        Me.PSPToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.PSPToolStripMenuItem.Text = "PSP"
        '
        'PlaystationToolStripMenuItem
        '
        Me.PlaystationToolStripMenuItem.Name = "PlaystationToolStripMenuItem"
        Me.PlaystationToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.PlaystationToolStripMenuItem.Text = "Playstation"
        '
        'Playstation2ToolStripMenuItem
        '
        Me.Playstation2ToolStripMenuItem.Name = "Playstation2ToolStripMenuItem"
        Me.Playstation2ToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.Playstation2ToolStripMenuItem.Text = "Playstation 2"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(12, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 124)
        Me.Panel1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(419, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Beenden"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(20, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Informationen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(20, 47)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Emulatoren"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(20, 76)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Roms"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.RetroGames.My.Resources.Resources.z_File_ROM
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(302, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 250)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 317)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retro Games Datenbank"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmulatorenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComputerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AmigaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C64ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KonsolenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AtariToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NintendoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SNESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents N64ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GameCubeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SegaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MegaDriveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SonyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PSPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlaystationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Playstation2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheatsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
