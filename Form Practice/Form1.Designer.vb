<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtOK = New System.Windows.Forms.Button()
        Me.BtCC = New System.Windows.Forms.Button()
        Me.Textbox = New System.Windows.Forms.Label()
        Me.Clock = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BtOK
        '
        Me.BtOK.Location = New System.Drawing.Point(234, 348)
        Me.BtOK.Name = "BtOK"
        Me.BtOK.Size = New System.Drawing.Size(82, 35)
        Me.BtOK.TabIndex = 0
        Me.BtOK.Text = "OK"
        Me.BtOK.UseVisualStyleBackColor = True
        '
        'BtCC
        '
        Me.BtCC.Location = New System.Drawing.Point(508, 348)
        Me.BtCC.Name = "BtCC"
        Me.BtCC.Size = New System.Drawing.Size(80, 35)
        Me.BtCC.TabIndex = 1
        Me.BtCC.Text = "終了"
        Me.BtCC.UseVisualStyleBackColor = True
        '
        'Textbox
        '
        Me.Textbox.Location = New System.Drawing.Point(55, 142)
        Me.Textbox.Name = "Textbox"
        Me.Textbox.Size = New System.Drawing.Size(701, 161)
        Me.Textbox.TabIndex = 2
        Me.Textbox.Text = "確認してボタンを押してください"
        Me.Textbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Clock
        '
        Me.Clock.Location = New System.Drawing.Point(508, 466)
        Me.Clock.Name = "Clock"
        Me.Clock.Size = New System.Drawing.Size(280, 30)
        Me.Clock.TabIndex = 3
        Me.Clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 505)
        Me.Controls.Add(Me.Clock)
        Me.Controls.Add(Me.Textbox)
        Me.Controls.Add(Me.BtCC)
        Me.Controls.Add(Me.BtOK)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtOK As Button
    Friend WithEvents BtCC As Button
    Friend WithEvents Textbox As Label
    Friend WithEvents Clock As Label
    Friend WithEvents Timer As Timer
End Class
