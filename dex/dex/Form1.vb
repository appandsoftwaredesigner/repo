Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class Form1
    Dim records(50) As String
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
        Dim outfile As New StreamWriter("data.txt")
        outfile.Write(Field1.Text)
        outfile.Write("|")
        outfile.Write(Field2.Text)
        outfile.Write("|")
        outfile.Write(Field3.Text)
        outfile.Write("|")
        outfile.Write(Field4.Text)
        outfile.Write("|")
        outfile.Write(Field5.Text)
        outfile.Write("|")
        outfile.WriteLine(PictureBox1.ImageLocation)
        outfile.Close()

    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        If IO.File.Exists("data.txt") Then
            Dim infile As New StreamReader("data.txt")
            records(0) = infile.ReadLine
            records(1) = infile.ReadLine
            infile.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub
End Class
