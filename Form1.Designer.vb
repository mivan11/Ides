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
        Me.Ides = New System.Windows.Forms.Button()
        Me.WB = New System.Windows.Forms.WebBrowser()
        Me.Tekst = New System.Windows.Forms.TextBox()
        Me.nazad = New System.Windows.Forms.Button()
        Me.naprijed = New System.Windows.Forms.Button()
        Me.osvjezi = New System.Windows.Forms.Button()
        Me.pocetna = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Ides
        '
        Me.Ides.Location = New System.Drawing.Point(1036, 4)
        Me.Ides.Name = "Ides"
        Me.Ides.Size = New System.Drawing.Size(100, 37)
        Me.Ides.TabIndex = 0
        Me.Ides.TabStop = False
        Me.Ides.Text = "Pretraži"
        Me.Ides.UseVisualStyleBackColor = True
        '
        'WB
        '
        Me.WB.Location = New System.Drawing.Point(0, 45)
        Me.WB.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WB.Name = "WB"
        Me.WB.Size = New System.Drawing.Size(1420, 1080)
        Me.WB.TabIndex = 1
        '
        'Tekst
        '
        Me.Tekst.Location = New System.Drawing.Point(223, 13)
        Me.Tekst.Name = "Tekst"
        Me.Tekst.Size = New System.Drawing.Size(796, 20)
        Me.Tekst.TabIndex = 2
        '
        'nazad
        '
        Me.nazad.Location = New System.Drawing.Point(10, 5)
        Me.nazad.Name = "nazad"
        Me.nazad.Size = New System.Drawing.Size(100, 37)
        Me.nazad.TabIndex = 3
        Me.nazad.Text = "Nazad"
        Me.nazad.UseVisualStyleBackColor = True
        '
        'naprijed
        '
        Me.naprijed.Location = New System.Drawing.Point(114, 5)
        Me.naprijed.Name = "naprijed"
        Me.naprijed.Size = New System.Drawing.Size(100, 37)
        Me.naprijed.TabIndex = 4
        Me.naprijed.Text = "Naprijed"
        Me.naprijed.UseVisualStyleBackColor = True
        '
        'osvjezi
        '
        Me.osvjezi.Location = New System.Drawing.Point(1147, 4)
        Me.osvjezi.Name = "osvjezi"
        Me.osvjezi.Size = New System.Drawing.Size(100, 37)
        Me.osvjezi.TabIndex = 5
        Me.osvjezi.Text = "Osvježi"
        Me.osvjezi.UseVisualStyleBackColor = True
        '
        'pocetna
        '
        Me.pocetna.Location = New System.Drawing.Point(1254, 4)
        Me.pocetna.Name = "pocetna"
        Me.pocetna.Size = New System.Drawing.Size(100, 37)
        Me.pocetna.TabIndex = 6
        Me.pocetna.Text = "Vrati na početnu"
        Me.pocetna.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.pocetna)
        Me.Controls.Add(Me.osvjezi)
        Me.Controls.Add(Me.naprijed)
        Me.Controls.Add(Me.nazad)
        Me.Controls.Add(Me.Tekst)
        Me.Controls.Add(Me.WB)
        Me.Controls.Add(Me.Ides)
        Me.Name = "Form1"
        Me.Text = "Ideš"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ides As Button
    Friend WithEvents WB As WebBrowser
    Friend WithEvents Tekst As TextBox
    Friend WithEvents nazad As Button
    Friend WithEvents naprijed As Button
    Friend WithEvents osvjezi As Button
    Friend WithEvents pocetna As Button
End Class
