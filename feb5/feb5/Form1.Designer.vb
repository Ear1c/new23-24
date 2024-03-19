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
        Me.ClickerControl1 = New feb5.clickerControl()
        Me.ClickerControl2 = New feb5.clickerControl()
        Me.ClickerControl3 = New feb5.clickerControl()
        Me.ClickerControl4 = New feb5.clickerControl()
        Me.ClickerControl5 = New feb5.clickerControl()
        Me.SuspendLayout()
        '
        'ClickerControl1
        '
        Me.ClickerControl1.Location = New System.Drawing.Point(109, 52)
        Me.ClickerControl1.Name = "ClickerControl1"
        Me.ClickerControl1.Size = New System.Drawing.Size(118, 95)
        Me.ClickerControl1.TabIndex = 0
        '
        'ClickerControl2
        '
        Me.ClickerControl2.Location = New System.Drawing.Point(109, 153)
        Me.ClickerControl2.Name = "ClickerControl2"
        Me.ClickerControl2.Size = New System.Drawing.Size(118, 95)
        Me.ClickerControl2.TabIndex = 1
        '
        'ClickerControl3
        '
        Me.ClickerControl3.Location = New System.Drawing.Point(233, 52)
        Me.ClickerControl3.Name = "ClickerControl3"
        Me.ClickerControl3.Size = New System.Drawing.Size(118, 95)
        Me.ClickerControl3.TabIndex = 2
        '
        'ClickerControl4
        '
        Me.ClickerControl4.Location = New System.Drawing.Point(233, 153)
        Me.ClickerControl4.Name = "ClickerControl4"
        Me.ClickerControl4.Size = New System.Drawing.Size(118, 95)
        Me.ClickerControl4.TabIndex = 3
        '
        'ClickerControl5
        '
        Me.ClickerControl5.Location = New System.Drawing.Point(357, 153)
        Me.ClickerControl5.Name = "ClickerControl5"
        Me.ClickerControl5.Size = New System.Drawing.Size(118, 95)
        Me.ClickerControl5.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ClickerControl5)
        Me.Controls.Add(Me.ClickerControl4)
        Me.Controls.Add(Me.ClickerControl3)
        Me.Controls.Add(Me.ClickerControl2)
        Me.Controls.Add(Me.ClickerControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClickerControl1 As clickerControl
    Friend WithEvents ClickerControl2 As clickerControl
    Friend WithEvents ClickerControl3 As clickerControl
    Friend WithEvents ClickerControl4 As clickerControl
    Friend WithEvents ClickerControl5 As clickerControl
End Class
