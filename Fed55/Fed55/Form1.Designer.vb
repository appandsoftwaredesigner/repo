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
<<<<<<< HEAD
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
=======
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ClickButton = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(302, 127)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 0
        '
        'ClickButton
        '
        Me.ClickButton.Location = New System.Drawing.Point(267, 191)
        Me.ClickButton.Name = "ClickButton"
        Me.ClickButton.Size = New System.Drawing.Size(75, 23)
        Me.ClickButton.TabIndex = 1
        Me.ClickButton.Text = "Click"
        Me.ClickButton.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(302, 259)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 2
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(374, 191)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 3
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(267, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(374, 317)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
>>>>>>> main
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
<<<<<<< HEAD
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
=======
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ClickButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Click"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ClickButton As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ResetButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
>>>>>>> main
End Class
