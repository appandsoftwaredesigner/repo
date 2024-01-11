Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Field1.Text = ""
        Field2.Text = ""
        Field3.Text = ""
        Field4.Text = ""
        Field5.Text = ""
        PictureBox1.Image = Nothing

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim outfile As New IO.StreamWriter("data.txt")
        outfile.Write(Field1.Text)
        outfile.Write("|")
        outfile.Write(Field1.Text)
        outfile.Write("|")
        outfile.Write(Field1.Text)
        outfile.Write("|")
        outfile.Write(Field1.Text)
        outfile.Write("|")
        outfile.Write(Field1.Text)
        outfile.Write("|")
        outfile.Write(Field1.Text)
        outfile.Write("|")
        outfile.WriteLine(PictureBox1.ImageLocation)
        outfile.Close()

    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub
End Class
