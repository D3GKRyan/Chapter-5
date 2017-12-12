<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCoinFlip = New System.Windows.Forms.Button()
        Me.btnRace = New System.Windows.Forms.Button()
        Me.btnSpeed = New System.Windows.Forms.Button()
        Me.btnguessinggame = New System.Windows.Forms.Button()
        Me.btnPopulation = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to the Jungle baby pick a game!"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(68, 191)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 60)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Rock" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Paper" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Scissors"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnCoinFlip
        '
        Me.btnCoinFlip.Location = New System.Drawing.Point(69, 162)
        Me.btnCoinFlip.Name = "btnCoinFlip"
        Me.btnCoinFlip.Size = New System.Drawing.Size(75, 23)
        Me.btnCoinFlip.TabIndex = 3
        Me.btnCoinFlip.Text = "Coin Flip"
        Me.btnCoinFlip.UseVisualStyleBackColor = True
        '
        'btnRace
        '
        Me.btnRace.Location = New System.Drawing.Point(69, 257)
        Me.btnRace.Name = "btnRace"
        Me.btnRace.Size = New System.Drawing.Size(75, 23)
        Me.btnRace.TabIndex = 4
        Me.btnRace.Text = "Race Cars"
        Me.btnRace.UseVisualStyleBackColor = True
        '
        'btnSpeed
        '
        Me.btnSpeed.Location = New System.Drawing.Point(69, 336)
        Me.btnSpeed.Name = "btnSpeed"
        Me.btnSpeed.Size = New System.Drawing.Size(75, 23)
        Me.btnSpeed.TabIndex = 5
        Me.btnSpeed.Text = "Speed"
        Me.btnSpeed.UseVisualStyleBackColor = True
        '
        'btnguessinggame
        '
        Me.btnguessinggame.Location = New System.Drawing.Point(68, 366)
        Me.btnguessinggame.Name = "btnguessinggame"
        Me.btnguessinggame.Size = New System.Drawing.Size(75, 23)
        Me.btnguessinggame.TabIndex = 6
        Me.btnguessinggame.Text = "Guessing Game"
        Me.btnguessinggame.UseVisualStyleBackColor = True
        '
        'btnPopulation
        '
        Me.btnPopulation.Location = New System.Drawing.Point(68, 297)
        Me.btnPopulation.Name = "btnPopulation"
        Me.btnPopulation.Size = New System.Drawing.Size(75, 23)
        Me.btnPopulation.TabIndex = 7
        Me.btnPopulation.Text = "Population"
        Me.btnPopulation.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 577)
        Me.Controls.Add(Me.btnPopulation)
        Me.Controls.Add(Me.btnguessinggame)
        Me.Controls.Add(Me.btnSpeed)
        Me.Controls.Add(Me.btnRace)
        Me.Controls.Add(Me.btnCoinFlip)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnCoinFlip As System.Windows.Forms.Button
    Friend WithEvents btnRace As System.Windows.Forms.Button
    Friend WithEvents btnSpeed As System.Windows.Forms.Button
    Friend WithEvents btnguessinggame As System.Windows.Forms.Button
    Friend WithEvents btnPopulation As System.Windows.Forms.Button
End Class
