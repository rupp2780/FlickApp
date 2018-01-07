Imports System.Xml

Public Class CreateForm


    'Exit form
    Private Sub BT_Exit_Click(sender As Object, e As EventArgs) Handles BT_Exit.Click
        Form1.LB_ShowActions.Items.Clear()
        Form1.CB_Macros.Items.Clear()
        'Load saved macros
        Dim files() As String = IO.Directory.GetFiles("c:\temp\SavedMacros")
        For Each file As String In files
            Form1.CB_Macros.Items.Add(file.Replace("c:\temp\SavedMacros\", ""))
            Dim Text As String = IO.File.ReadAllText(file)
        Next
        Close()
        Form1.Activate()
    End Sub

    'Open coord logging form
    Private Sub BT_Log_Click(sender As Object, e As EventArgs) Handles BT_Log.Click
        GetCoords.Show()
    End Sub

    'Remove selected listbox item
    Private Sub BT_Delete_Click(sender As Object, e As EventArgs) Handles BT_Delete.Click
        LB_Commands.Items.Remove(LB_Commands.SelectedItem)
    End Sub

    Private Sub BT_Save_Click(sender As Object, e As EventArgs) Handles BT_Save.Click
        Dim fileName As String = "C:\Temp\SavedMacros\" & TXT_MacroName.Text & ".txt"
        Dim doc As New XmlDocument()
        Dim root As XmlNode = doc.CreateElement("data")

        'Create field for macro name
        Dim Name As XmlNode = doc.CreateElement("name")
        Name.InnerText = TXT_MacroName.Text
        root.AppendChild(Name)

        For Each str As String In LB_Commands.Items
            Dim xn As XmlNode = doc.CreateElement("value")
            xn.InnerText = str
            root.AppendChild(xn)
        Next
        doc.AppendChild(root)

        doc.Save(fileName)
        MessageBox.Show("Command(s) successfully saved!")
    End Sub

    Private Sub BT_Clear_Click(sender As Object, e As EventArgs) Handles BT_Clear.Click
        LB_Commands.Items.Clear()
    End Sub
End Class