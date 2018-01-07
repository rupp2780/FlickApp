<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateForm
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
        Me.TXT_MacroName = New System.Windows.Forms.TextBox()
        Me.BT_Save = New System.Windows.Forms.Button()
        Me.BT_Exit = New System.Windows.Forms.Button()
        Me.BT_Log = New System.Windows.Forms.Button()
        Me.LB_Commands = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BT_Delete = New System.Windows.Forms.Button()
        Me.BT_Clear = New System.Windows.Forms.Button()
        Me.LabelLeft = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'TXT_MacroName
        '
        Me.TXT_MacroName.Location = New System.Drawing.Point(59, 13)
        Me.TXT_MacroName.Name = "TXT_MacroName"
        Me.TXT_MacroName.Size = New System.Drawing.Size(100, 20)
        Me.TXT_MacroName.TabIndex = 1
        Me.TXT_MacroName.Text = "New Macro"
        '
        'BT_Save
        '
        Me.BT_Save.Location = New System.Drawing.Point(15, 216)
        Me.BT_Save.Name = "BT_Save"
        Me.BT_Save.Size = New System.Drawing.Size(107, 23)
        Me.BT_Save.TabIndex = 2
        Me.BT_Save.Text = "Save"
        Me.BT_Save.UseVisualStyleBackColor = True
        '
        'BT_Exit
        '
        Me.BT_Exit.Location = New System.Drawing.Point(128, 216)
        Me.BT_Exit.Name = "BT_Exit"
        Me.BT_Exit.Size = New System.Drawing.Size(112, 23)
        Me.BT_Exit.TabIndex = 3
        Me.BT_Exit.Text = "Exit"
        Me.BT_Exit.UseVisualStyleBackColor = True
        '
        'BT_Log
        '
        Me.BT_Log.Location = New System.Drawing.Point(165, 13)
        Me.BT_Log.Name = "BT_Log"
        Me.BT_Log.Size = New System.Drawing.Size(75, 23)
        Me.BT_Log.TabIndex = 4
        Me.BT_Log.Text = "Log Clicks"
        Me.BT_Log.UseVisualStyleBackColor = True
        '
        'LB_Commands
        '
        Me.LB_Commands.FormattingEnabled = True
        Me.LB_Commands.Location = New System.Drawing.Point(15, 59)
        Me.LB_Commands.Name = "LB_Commands"
        Me.LB_Commands.Size = New System.Drawing.Size(225, 121)
        Me.LB_Commands.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Press Escape to stop logging"
        '
        'BT_Delete
        '
        Me.BT_Delete.Location = New System.Drawing.Point(15, 187)
        Me.BT_Delete.Name = "BT_Delete"
        Me.BT_Delete.Size = New System.Drawing.Size(107, 23)
        Me.BT_Delete.TabIndex = 10
        Me.BT_Delete.Text = "Delete Action"
        Me.BT_Delete.UseVisualStyleBackColor = True
        '
        'BT_Clear
        '
        Me.BT_Clear.Location = New System.Drawing.Point(128, 186)
        Me.BT_Clear.Name = "BT_Clear"
        Me.BT_Clear.Size = New System.Drawing.Size(112, 23)
        Me.BT_Clear.TabIndex = 11
        Me.BT_Clear.Text = "Clear"
        Me.BT_Clear.UseVisualStyleBackColor = True
        '
        'LabelLeft
        '
        Me.LabelLeft.AutoSize = True
        Me.LabelLeft.Location = New System.Drawing.Point(12, 252)
        Me.LabelLeft.Name = "LabelLeft"
        Me.LabelLeft.Size = New System.Drawing.Size(0, 13)
        Me.LabelLeft.TabIndex = 12
        '
        'CreateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelLeft)
        Me.Controls.Add(Me.BT_Clear)
        Me.Controls.Add(Me.BT_Delete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LB_Commands)
        Me.Controls.Add(Me.BT_Log)
        Me.Controls.Add(Me.BT_Exit)
        Me.Controls.Add(Me.BT_Save)
        Me.Controls.Add(Me.TXT_MacroName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CreateForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "CreateForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_MacroName As TextBox
    Friend WithEvents BT_Save As Button
    Friend WithEvents BT_Exit As Button
    Friend WithEvents BT_Log As Button
    Friend WithEvents LB_Commands As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BT_Delete As Button
    Friend WithEvents BT_Clear As Button
    Friend WithEvents LabelLeft As Label
End Class
