<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class coinFlip
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
        Me.picHead = New System.Windows.Forms.PictureBox()
        Me.picTail = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblHeads = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTails = New System.Windows.Forms.Label()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picHead
        '
        Me.picHead.Image = Global.WindowsApplication1.My.Resources.Resources.Heads
        Me.picHead.Location = New System.Drawing.Point(92, 124)
        Me.picHead.Name = "picHead"
        Me.picHead.Size = New System.Drawing.Size(107, 145)
        Me.picHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHead.TabIndex = 1
        Me.picHead.TabStop = False
        '
        'picTail
        '
        Me.picTail.Image = Global.WindowsApplication1.My.Resources.Resources.Tails
        Me.picTail.Location = New System.Drawing.Point(739, 124)
        Me.picTail.Name = "picTail"
        Me.picTail.Size = New System.Drawing.Size(122, 145)
        Me.picTail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTail.TabIndex = 0
        Me.picTail.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(205, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(528, 47)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "<--------Heads or Tails?-------->"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(163, 431)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Guess"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(602, 431)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(373, 434)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(100, 20)
        Me.txtGuess.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(338, 401)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Input here ""heads"" or ""tails"""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 504)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Heads"
        '
        'lblHeads
        '
        Me.lblHeads.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeads.Location = New System.Drawing.Point(163, 503)
        Me.lblHeads.Name = "lblHeads"
        Me.lblHeads.Size = New System.Drawing.Size(75, 25)
        Me.lblHeads.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(739, 504)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tails"
        '
        'lblTails
        '
        Me.lblTails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTails.Location = New System.Drawing.Point(779, 496)
        Me.lblTails.Name = "lblTails"
        Me.lblTails.Size = New System.Drawing.Size(75, 25)
        Me.lblTails.TabIndex = 11
        '
        'coinFlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 610)
        Me.Controls.Add(Me.lblTails)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblHeads)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picHead)
        Me.Controls.Add(Me.picTail)
        Me.Name = "coinFlip"
        Me.Text = "randomnumgen"
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picTail As System.Windows.Forms.PictureBox
    Friend WithEvents picHead As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtGuess As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblHeads As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTails As System.Windows.Forms.Label
End Class
