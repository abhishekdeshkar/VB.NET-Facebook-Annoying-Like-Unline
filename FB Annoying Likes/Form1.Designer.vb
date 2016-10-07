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
        Me.fb_web = New System.Windows.Forms.WebBrowser()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_start = New System.Windows.Forms.Button()
        Me.txt_url = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_go = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'fb_web
        '
        Me.fb_web.Location = New System.Drawing.Point(12, 54)
        Me.fb_web.MinimumSize = New System.Drawing.Size(20, 20)
        Me.fb_web.Name = "fb_web"
        Me.fb_web.ScriptErrorsSuppressed = True
        Me.fb_web.Size = New System.Drawing.Size(1318, 740)
        Me.fb_web.TabIndex = 0
        '
        'Timer1
        '
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(12, 12)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(105, 36)
        Me.btn_start.TabIndex = 1
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'txt_url
        '
        Me.txt_url.Location = New System.Drawing.Point(330, 19)
        Me.txt_url.Name = "txt_url"
        Me.txt_url.Size = New System.Drawing.Size(879, 22)
        Me.txt_url.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(278, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "URL"
        '
        'btn_go
        '
        Me.btn_go.Location = New System.Drawing.Point(1215, 12)
        Me.btn_go.Name = "btn_go"
        Me.btn_go.Size = New System.Drawing.Size(105, 36)
        Me.btn_go.TabIndex = 4
        Me.btn_go.Text = "GO"
        Me.btn_go.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.Location = New System.Drawing.Point(136, 9)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(105, 36)
        Me.btn_stop.TabIndex = 5
        Me.btn_stop.Text = "Stop"
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 806)
        Me.Controls.Add(Me.btn_stop)
        Me.Controls.Add(Me.btn_go)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_url)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.fb_web)
        Me.Name = "Form1"
        Me.Text = "FB Annoying Likes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fb_web As WebBrowser
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_start As Button
    Friend WithEvents txt_url As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_go As Button
    Friend WithEvents btn_stop As Button
End Class
