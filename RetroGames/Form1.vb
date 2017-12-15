Public Class Main

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub SNESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SNESToolStripMenuItem.Click
        EmuSNES.Show()
    End Sub
End Class
