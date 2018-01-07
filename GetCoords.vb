Public Class GetCoords

    'Establish Keyboard hook
    Private WithEvents kbHook As New KeyboardHook

    'Close form on Escape button
    Public Sub CloseForm(ByVal Key As Keys) Handles kbHook.KeyDown
        If Key.ToString = "Escape" Then 'Close form on spacebar
            Close()
        Else

        End If
    End Sub

    '
    Private WithEvents MouseDetector As MouseDetector
    Dim _localMousePosition As Point

    'Get mouse location hook
    Private Sub CreateForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MouseDetector = New MouseDetector
    End Sub

    'Remove mouse hook
    Private Sub CreateForm_Disposed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Disposed
        RemoveHandler MouseDetector.MouseLeftButtonClick, AddressOf MouseDetector_MouseLeftButtonClick
        'RemoveHandler MouseDetector.MouseRightButtonClick, AddressOf MouseDetector_MouseRightButtonClick
        MouseDetector.Dispose()
    End Sub

    'Log Left clicks
    Private Sub MouseDetector_MouseLeftButtonClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MouseDetector.MouseLeftButtonClick
        If IsNumeric(CreateForm.LabelLeft.Text) Then
            CreateForm.LB_Commands.Items.Add(Cursor.Position.ToString)
        Else
            CreateForm.LabelLeft.Text = 1
        End If
    End Sub

    ''Log Right clicks
    'Private Sub MouseDetector_MouseRightButtonClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MouseDetector.MouseRightButtonClick
    '    If IsNumeric(CreateForm.LabelRight.Text) Then
    '        CreateForm.LabelRight.Text = CInt(CreateForm.LabelRight.Text) + 1
    '        CreateForm.LB_Commands.Items.Add(Cursor.Position)
    '    Else
    '        CreateForm.LabelRight.Text = 1
    '    End If
    'End Sub
End Class