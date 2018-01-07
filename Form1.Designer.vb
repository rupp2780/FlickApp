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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BT_CreateNew = New System.Windows.Forms.Button()
        Me.CB_Macros = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LB_ShowActions = New System.Windows.Forms.ListBox()
        Me.TXT_StartHK = New System.Windows.Forms.TextBox()
        Me.TXT_Delay = New System.Windows.Forms.GroupBox()
        Me.TB_Delay = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BT_Stop = New System.Windows.Forms.Button()
        Me.BT_Start = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_StopHK = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BT_Delete = New System.Windows.Forms.Button()
        Me.BT_Load = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TXT_Delay.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BT_CreateNew
        '
        Me.BT_CreateNew.Location = New System.Drawing.Point(6, 46)
        Me.BT_CreateNew.Name = "BT_CreateNew"
        Me.BT_CreateNew.Size = New System.Drawing.Size(64, 23)
        Me.BT_CreateNew.TabIndex = 0
        Me.BT_CreateNew.Text = "New"
        Me.BT_CreateNew.UseVisualStyleBackColor = True
        '
        'CB_Macros
        '
        Me.CB_Macros.FormattingEnabled = True
        Me.CB_Macros.Location = New System.Drawing.Point(6, 19)
        Me.CB_Macros.Name = "CB_Macros"
        Me.CB_Macros.Size = New System.Drawing.Size(207, 21)
        Me.CB_Macros.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Actions:"
        '
        'LB_ShowActions
        '
        Me.LB_ShowActions.FormattingEnabled = True
        Me.LB_ShowActions.Location = New System.Drawing.Point(6, 96)
        Me.LB_ShowActions.Name = "LB_ShowActions"
        Me.LB_ShowActions.Size = New System.Drawing.Size(207, 121)
        Me.LB_ShowActions.TabIndex = 5
        '
        'TXT_StartHK
        '
        Me.TXT_StartHK.Location = New System.Drawing.Point(45, 15)
        Me.TXT_StartHK.Name = "TXT_StartHK"
        Me.TXT_StartHK.Size = New System.Drawing.Size(149, 20)
        Me.TXT_StartHK.TabIndex = 6
        Me.TXT_StartHK.Text = "F3"
        '
        'TXT_Delay
        '
        Me.TXT_Delay.Controls.Add(Me.TB_Delay)
        Me.TXT_Delay.Controls.Add(Me.Label5)
        Me.TXT_Delay.Controls.Add(Me.BT_Stop)
        Me.TXT_Delay.Controls.Add(Me.BT_Start)
        Me.TXT_Delay.Controls.Add(Me.Label4)
        Me.TXT_Delay.Controls.Add(Me.TXT_StopHK)
        Me.TXT_Delay.Controls.Add(Me.Label3)
        Me.TXT_Delay.Controls.Add(Me.TXT_StartHK)
        Me.TXT_Delay.Location = New System.Drawing.Point(256, 12)
        Me.TXT_Delay.Name = "TXT_Delay"
        Me.TXT_Delay.Size = New System.Drawing.Size(225, 225)
        Me.TXT_Delay.TabIndex = 7
        Me.TXT_Delay.TabStop = False
        Me.TXT_Delay.Text = "Hotkeys"
        '
        'TB_Delay
        '
        Me.TB_Delay.Location = New System.Drawing.Point(45, 66)
        Me.TB_Delay.Name = "TB_Delay"
        Me.TB_Delay.Size = New System.Drawing.Size(149, 20)
        Me.TB_Delay.TabIndex = 13
        Me.TB_Delay.Text = "500"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Delay:"
        '
        'BT_Stop
        '
        Me.BT_Stop.Location = New System.Drawing.Point(6, 146)
        Me.BT_Stop.Name = "BT_Stop"
        Me.BT_Stop.Size = New System.Drawing.Size(213, 23)
        Me.BT_Stop.TabIndex = 11
        Me.BT_Stop.Text = "Stop"
        Me.BT_Stop.UseVisualStyleBackColor = True
        '
        'BT_Start
        '
        Me.BT_Start.Location = New System.Drawing.Point(6, 117)
        Me.BT_Start.Name = "BT_Start"
        Me.BT_Start.Size = New System.Drawing.Size(213, 23)
        Me.BT_Start.TabIndex = 10
        Me.BT_Start.Text = "Start"
        Me.BT_Start.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Stop:"
        '
        'TXT_StopHK
        '
        Me.TXT_StopHK.Location = New System.Drawing.Point(45, 41)
        Me.TXT_StopHK.Name = "TXT_StopHK"
        Me.TXT_StopHK.Size = New System.Drawing.Size(149, 20)
        Me.TXT_StopHK.TabIndex = 8
        Me.TXT_StopHK.Text = "F4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Start:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BT_Delete)
        Me.GroupBox1.Controls.Add(Me.LB_ShowActions)
        Me.GroupBox1.Controls.Add(Me.BT_CreateNew)
        Me.GroupBox1.Controls.Add(Me.BT_Load)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CB_Macros)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 225)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Saved Macros"
        '
        'BT_Delete
        '
        Me.BT_Delete.Location = New System.Drawing.Point(148, 46)
        Me.BT_Delete.Name = "BT_Delete"
        Me.BT_Delete.Size = New System.Drawing.Size(65, 23)
        Me.BT_Delete.TabIndex = 6
        Me.BT_Delete.Text = "Delete"
        Me.BT_Delete.UseVisualStyleBackColor = True
        '
        'BT_Load
        '
        Me.BT_Load.Location = New System.Drawing.Point(76, 46)
        Me.BT_Load.Name = "BT_Load"
        Me.BT_Load.Size = New System.Drawing.Size(65, 23)
        Me.BT_Load.TabIndex = 1
        Me.BT_Load.Text = "Load"
        Me.BT_Load.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 259)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TXT_Delay)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Click Macro"
        Me.TXT_Delay.ResumeLayout(False)
        Me.TXT_Delay.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BT_CreateNew As Button
    Friend WithEvents CB_Macros As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LB_ShowActions As ListBox
    Friend WithEvents TXT_StartHK As TextBox
    Friend WithEvents TXT_Delay As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_StopHK As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BT_Stop As Button
    Friend WithEvents BT_Start As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TB_Delay As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BT_Delete As Button
    Friend WithEvents BT_Load As Button
End Class
