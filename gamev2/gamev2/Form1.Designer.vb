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
        Me.tmrright = New System.Windows.Forms.Timer(Me.components)
        Me.tmrleft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrup = New System.Windows.Forms.Timer(Me.components)
        Me.tmrgamelogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrgravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Picplayer = New System.Windows.Forms.PictureBox()
        Me.Picground = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Mover4 = New gamev2.mover()
        Me.Mover3 = New gamev2.mover()
        Me.Mover2 = New gamev2.mover()
        Me.Mover1 = New gamev2.mover()
        Me.Picair = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrright
        '
        Me.tmrright.Interval = 20
        '
        'tmrleft
        '
        Me.tmrleft.Interval = 20
        '
        'tmrup
        '
        Me.tmrup.Interval = 20
        '
        'tmrgamelogic
        '
        Me.tmrgamelogic.Interval = 20
        '
        'tmrgravity
        '
        Me.tmrgravity.Interval = 20
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.gamev2.My.Resources.Resources.OIP__29_
        Me.PictureBox5.Location = New System.Drawing.Point(157, 233)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "win"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox4.Location = New System.Drawing.Point(25, 266)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(140, 11)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(157, 100)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(140, 11)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(590, 124)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(140, 11)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(486, 282)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 11)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'Picplayer
        '
        Me.Picplayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Picplayer.Image = Global.gamev2.My.Resources.Resources.OIP__28_
        Me.Picplayer.Location = New System.Drawing.Point(92, 351)
        Me.Picplayer.Name = "Picplayer"
        Me.Picplayer.Size = New System.Drawing.Size(46, 47)
        Me.Picplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picplayer.TabIndex = 0
        Me.Picplayer.TabStop = False
        '
        'Picground
        '
        Me.Picground.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Picground.Location = New System.Drawing.Point(-6, 404)
        Me.Picground.Name = "Picground"
        Me.Picground.Size = New System.Drawing.Size(813, 50)
        Me.Picground.TabIndex = 2
        Me.Picground.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-6, 432)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 9
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.gamev2.My.Resources.Resources.OIP__29_
        Me.PictureBox6.Location = New System.Drawing.Point(25, 399)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 13
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "win2"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.gamev2.My.Resources.Resources.OIP__30_
        Me.PictureBox7.Location = New System.Drawing.Point(486, 416)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(100, 80)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 14
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "lose"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.gamev2.My.Resources.Resources.OIP__29_
        Me.PictureBox8.Location = New System.Drawing.Point(590, 257)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 15
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "win3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "points"
        '
        'Mover4
        '
        Me.Mover4.BackColor = System.Drawing.Color.Transparent
        Me.Mover4.interval = 500
        Me.Mover4.Location = New System.Drawing.Point(590, 107)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(140, 11)
        Me.Mover4.speed = 10
        Me.Mover4.sprite = Me.PictureBox8
        Me.Mover4.TabIndex = 12
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.Color.Transparent
        Me.Mover3.interval = 500
        Me.Mover3.Location = New System.Drawing.Point(157, 83)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(140, 11)
        Me.Mover3.speed = 10
        Me.Mover3.sprite = Me.PictureBox5
        Me.Mover3.TabIndex = 11
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.Transparent
        Me.Mover2.interval = 500
        Me.Mover2.Location = New System.Drawing.Point(25, 249)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(140, 11)
        Me.Mover2.speed = 10
        Me.Mover2.sprite = Me.PictureBox6
        Me.Mover2.TabIndex = 10
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Transparent
        Me.Mover1.interval = 500
        Me.Mover1.Location = New System.Drawing.Point(486, 266)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(140, 11)
        Me.Mover1.speed = 10
        Me.Mover1.sprite = Me.PictureBox7
        Me.Mover1.TabIndex = 8
        '
        'Picair
        '
        Me.Picair.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Picair.Location = New System.Drawing.Point(-6, -7)
        Me.Picair.Name = "Picair"
        Me.Picair.Size = New System.Drawing.Size(813, 373)
        Me.Picair.TabIndex = 1
        Me.Picair.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(359, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Mover4)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Picplayer)
        Me.Controls.Add(Me.Picground)
        Me.Controls.Add(Me.Picair)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Picplayer As PictureBox
    Friend WithEvents Picground As PictureBox
    Friend WithEvents tmrright As Timer
    Friend WithEvents tmrleft As Timer
    Friend WithEvents tmrup As Timer
    Friend WithEvents tmrgamelogic As Timer
    Friend WithEvents tmrgravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Mover1 As mover
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Mover2 As mover
    Friend WithEvents Mover3 As mover
    Friend WithEvents Mover4 As mover
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Picair As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
