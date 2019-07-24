<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPage_Log = New System.Windows.Forms.TabPage()
        Me.CheckBox_Output_level = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox_Output = New System.Windows.Forms.TextBox()
        Me.TabPage_Settings = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage_Log.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage_Log)
        Me.TabControl1.Controls.Add(Me.TabPage_Settings)
        Me.TabControl1.Location = New System.Drawing.Point(24, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(573, 319)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(565, 293)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "主界面"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(138, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage_Log
        '
        Me.TabPage_Log.Controls.Add(Me.Button3)
        Me.TabPage_Log.Controls.Add(Me.CheckBox_Output_level)
        Me.TabPage_Log.Controls.Add(Me.Button1)
        Me.TabPage_Log.Controls.Add(Me.TextBox_Output)
        Me.TabPage_Log.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Log.Name = "TabPage_Log"
        Me.TabPage_Log.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Log.Size = New System.Drawing.Size(565, 293)
        Me.TabPage_Log.TabIndex = 0
        Me.TabPage_Log.Text = "运行日志"
        Me.TabPage_Log.UseVisualStyleBackColor = True
        '
        'CheckBox_Output_level
        '
        Me.CheckBox_Output_level.AutoSize = True
        Me.CheckBox_Output_level.Location = New System.Drawing.Point(357, 35)
        Me.CheckBox_Output_level.Name = "CheckBox_Output_level"
        Me.CheckBox_Output_level.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox_Output_level.TabIndex = 3
        Me.CheckBox_Output_level.Text = "输出详细信息"
        Me.CheckBox_Output_level.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(357, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox_Output
        '
        Me.TextBox_Output.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox_Output.Location = New System.Drawing.Point(6, 6)
        Me.TextBox_Output.Multiline = True
        Me.TextBox_Output.Name = "TextBox_Output"
        Me.TextBox_Output.ReadOnly = True
        Me.TextBox_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_Output.Size = New System.Drawing.Size(336, 227)
        Me.TextBox_Output.TabIndex = 0
        '
        'TabPage_Settings
        '
        Me.TabPage_Settings.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Settings.Name = "TabPage_Settings"
        Me.TabPage_Settings.Size = New System.Drawing.Size(565, 293)
        Me.TabPage_Settings.TabIndex = 2
        Me.TabPage_Settings.Text = "设置"
        Me.TabPage_Settings.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(416, 97)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 337)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form_Main"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage_Log.ResumeLayout(False)
        Me.TabPage_Log.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage_Log As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox_Output As TextBox
    Friend WithEvents TabPage_Settings As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox_Output_level As CheckBox
    Friend WithEvents Button3 As Button
End Class
