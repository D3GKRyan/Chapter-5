<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Solve_Triangle
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
        Me.rada = New System.Windows.Forms.RadioButton()
        Me.radb = New System.Windows.Forms.RadioButton()
        Me.radc = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'rada
        '
        Me.rada.AutoSize = True
        Me.rada.Location = New System.Drawing.Point(48, 96)
        Me.rada.Name = "rada"
        Me.rada.Size = New System.Drawing.Size(101, 17)
        Me.rada.TabIndex = 0
        Me.rada.TabStop = True
        Me.rada.Text = "Solve for A Side"
        Me.rada.UseVisualStyleBackColor = True
        '
        'radb
        '
        Me.radb.AutoSize = True
        Me.radb.Location = New System.Drawing.Point(48, 125)
        Me.radb.Name = "radb"
        Me.radb.Size = New System.Drawing.Size(101, 17)
        Me.radb.TabIndex = 1
        Me.radb.TabStop = True
        Me.radb.Text = "Solve for B Side"
        Me.radb.UseVisualStyleBackColor = True
        '
        'radc
        '
        Me.radc.AutoSize = True
        Me.radc.Location = New System.Drawing.Point(48, 158)
        Me.radc.Name = "radc"
        Me.radc.Size = New System.Drawing.Size(101, 17)
        Me.radc.TabIndex = 2
        Me.radc.TabStop = True
        Me.radc.Text = "Solve for C Side"
        Me.radc.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(74, 250)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(206, 98)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 20)
        Me.txtA.TabIndex = 4
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(206, 125)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 20)
        Me.txtB.TabIndex = 5
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(206, 158)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(100, 20)
        Me.txtC.TabIndex = 6
        '
        'Solve_Triangle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 370)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.radc)
        Me.Controls.Add(Me.radb)
        Me.Controls.Add(Me.rada)
        Me.Name = "Solve_Triangle"
        Me.Text = "Solve_Triangle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rada As System.Windows.Forms.RadioButton
    Friend WithEvents radb As System.Windows.Forms.RadioButton
    Friend WithEvents radc As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox
End Class
