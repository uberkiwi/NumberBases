<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseConvert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaseConvert))
        Me.Base10 = New System.Windows.Forms.TextBox()
        Me.Base10Label = New System.Windows.Forms.Label()
        Me.Base2Label = New System.Windows.Forms.Label()
        Me.Base2 = New System.Windows.Forms.TextBox()
        Me.Base16Label = New System.Windows.Forms.Label()
        Me.Base16 = New System.Windows.Forms.TextBox()
        Me.RunBtn = New System.Windows.Forms.Button()
        Me.Base10Chk = New System.Windows.Forms.CheckBox()
        Me.Base2Chk = New System.Windows.Forms.CheckBox()
        Me.Base16Chk = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Base10
        '
        Me.Base10.Location = New System.Drawing.Point(64, 11)
        Me.Base10.Name = "Base10"
        Me.Base10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Base10.Size = New System.Drawing.Size(236, 20)
        Me.Base10.TabIndex = 0
        Me.Base10.Text = "0"
        Me.Base10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Base10Label
        '
        Me.Base10Label.AutoSize = True
        Me.Base10Label.Location = New System.Drawing.Point(10, 16)
        Me.Base10Label.Name = "Base10Label"
        Me.Base10Label.Size = New System.Drawing.Size(43, 13)
        Me.Base10Label.TabIndex = 1
        Me.Base10Label.Text = "Base10"
        '
        'Base2Label
        '
        Me.Base2Label.AutoSize = True
        Me.Base2Label.Location = New System.Drawing.Point(14, 42)
        Me.Base2Label.Name = "Base2Label"
        Me.Base2Label.Size = New System.Drawing.Size(37, 13)
        Me.Base2Label.TabIndex = 3
        Me.Base2Label.Text = "Base2"
        '
        'Base2
        '
        Me.Base2.Location = New System.Drawing.Point(64, 37)
        Me.Base2.Name = "Base2"
        Me.Base2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Base2.Size = New System.Drawing.Size(236, 20)
        Me.Base2.TabIndex = 2
        Me.Base2.Text = "0"
        Me.Base2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Base16Label
        '
        Me.Base16Label.AutoSize = True
        Me.Base16Label.Location = New System.Drawing.Point(10, 68)
        Me.Base16Label.Name = "Base16Label"
        Me.Base16Label.Size = New System.Drawing.Size(43, 13)
        Me.Base16Label.TabIndex = 5
        Me.Base16Label.Text = "Base16"
        '
        'Base16
        '
        Me.Base16.Location = New System.Drawing.Point(64, 63)
        Me.Base16.Name = "Base16"
        Me.Base16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Base16.Size = New System.Drawing.Size(236, 20)
        Me.Base16.TabIndex = 4
        Me.Base16.Text = "0"
        Me.Base16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RunBtn
        '
        Me.RunBtn.Location = New System.Drawing.Point(24, 93)
        Me.RunBtn.Name = "RunBtn"
        Me.RunBtn.Size = New System.Drawing.Size(289, 33)
        Me.RunBtn.TabIndex = 6
        Me.RunBtn.Text = "Run"
        Me.RunBtn.UseMnemonic = False
        Me.RunBtn.UseVisualStyleBackColor = True
        '
        'Base10Chk
        '
        Me.Base10Chk.AutoSize = True
        Me.Base10Chk.Location = New System.Drawing.Point(306, 15)
        Me.Base10Chk.Name = "Base10Chk"
        Me.Base10Chk.Size = New System.Drawing.Size(15, 14)
        Me.Base10Chk.TabIndex = 7
        Me.Base10Chk.UseVisualStyleBackColor = True
        '
        'Base2Chk
        '
        Me.Base2Chk.AutoSize = True
        Me.Base2Chk.Location = New System.Drawing.Point(306, 41)
        Me.Base2Chk.Name = "Base2Chk"
        Me.Base2Chk.Size = New System.Drawing.Size(15, 14)
        Me.Base2Chk.TabIndex = 8
        Me.Base2Chk.UseVisualStyleBackColor = True
        '
        'Base16Chk
        '
        Me.Base16Chk.AutoSize = True
        Me.Base16Chk.Location = New System.Drawing.Point(306, 67)
        Me.Base16Chk.Name = "Base16Chk"
        Me.Base16Chk.Size = New System.Drawing.Size(15, 14)
        Me.Base16Chk.TabIndex = 9
        Me.Base16Chk.UseVisualStyleBackColor = True
        '
        'BaseConvert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 136)
        Me.Controls.Add(Me.Base16Chk)
        Me.Controls.Add(Me.Base2Chk)
        Me.Controls.Add(Me.Base10Chk)
        Me.Controls.Add(Me.RunBtn)
        Me.Controls.Add(Me.Base16Label)
        Me.Controls.Add(Me.Base16)
        Me.Controls.Add(Me.Base2Label)
        Me.Controls.Add(Me.Base2)
        Me.Controls.Add(Me.Base10Label)
        Me.Controls.Add(Me.Base10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(350, 175)
        Me.MinimumSize = New System.Drawing.Size(350, 175)
        Me.Name = "BaseConvert"
        Me.Text = "BaseConvert"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Base10 As TextBox
    Friend WithEvents Base10Label As Label
    Friend WithEvents Base2Label As Label
    Friend WithEvents Base2 As TextBox
    Friend WithEvents Base16Label As Label
    Friend WithEvents Base16 As TextBox
    Friend WithEvents RunBtn As Button
    Friend WithEvents Base10Chk As CheckBox
    Friend WithEvents Base2Chk As CheckBox
    Friend WithEvents Base16Chk As CheckBox
End Class
