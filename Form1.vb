Imports System.Threading
Imports System.Xml

Public Class Form1
    'Create delay settings
    'Delete macro button
    Public Declare Auto Function SetCursorPos Lib "User32.dll" (ByVal X As Integer, ByVal Y As Integer) As Integer
    Public Declare Auto Function GetCursorPos Lib "User32.dll" (ByRef lpPoint As Point) As Integer
    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Long, ByVal dx As Long, ByVal dy As Long, ByVal cButtons As Long, ByVal dwExtraInfo As Long)

    'Establish Keyboard hook
    Private WithEvents kbHook As New KeyboardHook

    'Set values for setting amt of clicks
    Dim ClickCount As Integer = 0
    Dim ClickTo As Integer = 0

    'Get key when pressed
    Private Sub kbHook_KeyDown(ByVal Key As Keys) Handles kbHook.KeyDown
        Debug.WriteLine(Key)
        If Key.ToString = TXT_StartHK.Text Then 'Set Start key, default F4
            For l_index As Integer = 0 To LB_ShowActions.Items.Count - 1
                Dim l_text = ((LB_ShowActions.Items(l_index).Replace("{X=", "")).Replace("Y=", "")).Replace("}", "")
                Dim original As String = l_text
                Dim cut_at As String = ","
                Dim stringSeparators() As String = {cut_at}
                Dim split = original.Split(stringSeparators, 2, StringSplitOptions.RemoveEmptyEntries)
                Dim string_before As Integer = split(0)
                Dim string_after As Integer = split(1)

                MyMethod(string_before, string_after)

            Next
        ElseIf Key.ToString = TXT_StopHK.Text Then 'Set Stop key, default F3
            Timer1.Stop()
        End If
    End Sub

    'Execute on tick
    Private Sub MyMethod(ByVal x As Integer, ByVal y As Integer)
        SetCursorPos(x, y)
        mouse_event(&H2, 0, 0, 0, 1) 'cursor will go down (like a click)
        mouse_event(&H4, 0, 0, 0, 1) ' cursor goes up again
    End Sub

    'Show form to create new macro
    Private Sub BT_CreateNew_Click(sender As Object, e As EventArgs) Handles BT_CreateNew.Click
        CreateForm.Show()
    End Sub

    'Load macros
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear to avoid duplication
        LB_ShowActions.Items.Clear()
        CB_Macros.Items.Clear()

        'Check if directory exists
        If (Not System.IO.Directory.Exists("c:\temp\SavedMacros")) Then
            System.IO.Directory.CreateDirectory("c:\temp\SavedMacros")
        End If

        'Load saved macros
        Dim files() As String = IO.Directory.GetFiles("c:\temp\SavedMacros")
        For Each file As String In files
            CB_Macros.Items.Add(file.Replace("c:\temp\SavedMacros\", ""))
            Dim Text As String = IO.File.ReadAllText(file)
        Next
    End Sub

    'Load button
    Private Sub BT_Load_Click(sender As Object, e As EventArgs) Handles BT_Load.Click, CB_Macros.SelectionChangeCommitted
        Dim Loadfile As String = "c:\temp\SavedMacros\" & CB_Macros.SelectedItem.ToString
        LB_ShowActions.Items.Clear()

        'Create the XmlDocument.
        Dim doc As New XmlDocument()
        doc.Load(Loadfile)

        'Display all the book titles.
        Dim elemList As XmlNodeList = doc.GetElementsByTagName("value")
        Dim i As Integer
        For i = 0 To elemList.Count - 1
            LB_ShowActions.Items.Add(elemList(i).InnerXml)
        Next i
    End Sub

    'Manual start macro
    Private Sub BT_Start_Click(sender As Object, e As EventArgs) Handles BT_Start.Click
        For l_index As Integer = 0 To LB_ShowActions.Items.Count - 1
            Dim l_text = ((LB_ShowActions.Items(l_index).Replace("{X=", "")).Replace("Y=", "")).Replace("}", "")
            Dim original As String = l_text
            Dim cut_at As String = ","
            Dim stringSeparators() As String = {cut_at}
            Dim split = original.Split(stringSeparators, 2, StringSplitOptions.RemoveEmptyEntries)
            Dim string_before As Integer = split(0)
            Dim string_after As Integer = split(1)

            MyMethod(string_before, string_after)
            Thread.Sleep(200)
        Next

    End Sub

    'Delete saved macro
    Private Sub BT_Delete_Click(sender As Object, e As EventArgs) Handles BT_Delete.Click
        Dim FileToDelete As String
        FileToDelete = "c:\temp\SavedMacros\" & CB_Macros.SelectedItem.ToString

        If System.IO.File.Exists(FileToDelete) = True Then
            Dim result = MessageBox.Show("Are you sure you want to delete " & CB_Macros.SelectedItem.ToString & "?",
                            "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                System.IO.File.Delete(FileToDelete)
            End If
        End If

        'Remove entry from combo box
        CB_Macros.Items.Remove(CB_Macros.SelectedItem)
    End Sub
End Class
