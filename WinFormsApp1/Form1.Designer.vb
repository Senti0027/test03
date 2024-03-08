<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_03 = New System.Windows.Forms.Button()
        Me.txt_03 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_03
        '
        Me.btn_03.Location = New System.Drawing.Point(247, 36)
        Me.btn_03.Name = "btn_03"
        Me.btn_03.Size = New System.Drawing.Size(200, 37)
        Me.btn_03.TabIndex = 0
        Me.btn_03.Text = "第三題"
        Me.btn_03.UseVisualStyleBackColor = True
        '
        'txt_03
        '
        Me.txt_03.Location = New System.Drawing.Point(252, 176)
        Me.txt_03.Multiline = True
        Me.txt_03.Name = "txt_03"
        Me.txt_03.Size = New System.Drawing.Size(176, 109)
        Me.txt_03.TabIndex = 1
        Me.txt_03.Text = "Move your body let it dance again"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_03)
        Me.Controls.Add(Me.btn_03)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_03 As Button
    Friend WithEvents txt_03 As TextBox
End Class
