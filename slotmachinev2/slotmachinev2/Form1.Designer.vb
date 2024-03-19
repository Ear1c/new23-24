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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Reelcontrol3 = New slotmachinev2.reelcontrol1()
        Me.Reelcontrol2 = New slotmachinev2.reelcontrol1()
        Me.Reelcontrol1 = New slotmachinev2.reelcontrol1()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(216, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(307, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(463, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(619, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'Button4
        '
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(11, 345)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 67)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "nickles"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(11, 272)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 67)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "dimes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(12, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 67)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "quarters"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(12, 126)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(97, 67)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "dollars"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(115, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Label4"
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(497, 345)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(213, 22)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Text = "You win!!"
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(391, 345)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(387, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "what you've won"
        '
        'Reelcontrol3
        '
        Me.Reelcontrol3.itemvalue = 0
        Me.Reelcontrol3.Location = New System.Drawing.Point(622, 126)
        Me.Reelcontrol3.Name = "Reelcontrol3"
        Me.Reelcontrol3.Size = New System.Drawing.Size(150, 150)
        Me.Reelcontrol3.spintime = 2000
        Me.Reelcontrol3.TabIndex = 4
        '
        'Reelcontrol2
        '
        Me.Reelcontrol2.itemvalue = 0
        Me.Reelcontrol2.Location = New System.Drawing.Point(466, 126)
        Me.Reelcontrol2.Name = "Reelcontrol2"
        Me.Reelcontrol2.Size = New System.Drawing.Size(150, 150)
        Me.Reelcontrol2.spintime = 2000
        Me.Reelcontrol2.TabIndex = 3
        '
        'Reelcontrol1
        '
        Me.Reelcontrol1.itemvalue = 0
        Me.Reelcontrol1.Location = New System.Drawing.Point(310, 126)
        Me.Reelcontrol1.Name = "Reelcontrol1"
        Me.Reelcontrol1.Size = New System.Drawing.Size(150, 150)
        Me.Reelcontrol1.spintime = 2000
        Me.Reelcontrol1.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(488, 98)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 15
        Me.TextBox3.Text = "Match 3 = 10$"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Reelcontrol3)
        Me.Controls.Add(Me.Reelcontrol2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Reelcontrol1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Reelcontrol1 As reelcontrol1
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Reelcontrol2 As reelcontrol1
    Friend WithEvents Reelcontrol3 As reelcontrol1
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
