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
        Me.btnGreetings = New System.Windows.Forms.Button()
        Me.lblCountryName = New System.Windows.Forms.Label()
        Me.txtCountryName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGreetings
        '
        Me.btnGreetings.Location = New System.Drawing.Point(112, 149)
        Me.btnGreetings.Name = "btnGreetings"
        Me.btnGreetings.Size = New System.Drawing.Size(159, 65)
        Me.btnGreetings.TabIndex = 0
        Me.btnGreetings.Text = "Greetings"
        Me.btnGreetings.UseVisualStyleBackColor = True
        '
        'lblCountryName
        '
        Me.lblCountryName.AutoSize = True
        Me.lblCountryName.Location = New System.Drawing.Point(58, 52)
        Me.lblCountryName.Name = "lblCountryName"
        Me.lblCountryName.Size = New System.Drawing.Size(108, 20)
        Me.lblCountryName.TabIndex = 1
        Me.lblCountryName.Text = "Country name"
        '
        'txtCountryName
        '
        Me.txtCountryName.Location = New System.Drawing.Point(184, 49)
        Me.txtCountryName.Name = "txtCountryName"
        Me.txtCountryName.Size = New System.Drawing.Size(100, 26)
        Me.txtCountryName.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtCountryName)
        Me.Controls.Add(Me.lblCountryName)
        Me.Controls.Add(Me.btnGreetings)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGreetings As Button
    Friend WithEvents lblCountryName As Label
    Friend WithEvents txtCountryName As TextBox
End Class
