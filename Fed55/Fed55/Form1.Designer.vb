<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ClickerControl3 = New Fed55.ClickerControl()
        Me.ClickerControl2 = New Fed55.ClickerControl()
        Me.ClickerControl1 = New Fed55.ClickerControl()
        Me.SuspendLayout()
        '
        'ClickerControl3
        '
        Me.ClickerControl3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClickerControl3.increment = 100
        Me.ClickerControl3.Location = New System.Drawing.Point(342, 163)
        Me.ClickerControl3.Name = "ClickerControl3"
        Me.ClickerControl3.Size = New System.Drawing.Size(150, 150)
        Me.ClickerControl3.TabIndex = 8
        '
        'ClickerControl2
        '
        Me.ClickerControl2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClickerControl2.increment = 1
        Me.ClickerControl2.Location = New System.Drawing.Point(150, 163)
        Me.ClickerControl2.Name = "ClickerControl2"
        Me.ClickerControl2.Size = New System.Drawing.Size(150, 150)
        Me.ClickerControl2.TabIndex = 7
        '
        'ClickerControl1
        '
        Me.ClickerControl1.BackColor = System.Drawing.Color.DarkMagenta
        Me.ClickerControl1.increment = 1
        Me.ClickerControl1.Location = New System.Drawing.Point(537, 163)
        Me.ClickerControl1.Name = "ClickerControl1"
        Me.ClickerControl1.Size = New System.Drawing.Size(150, 150)
        Me.ClickerControl1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ClickerControl3)
        Me.Controls.Add(Me.ClickerControl2)
        Me.Controls.Add(Me.ClickerControl1)
        Me.Name = "Form1"
        Me.Text = "Click"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ClickerControl1 As ClickerControl
    Friend WithEvents ClickerControl2 As ClickerControl
    Friend WithEvents ClickerControl3 As ClickerControl
End Class
