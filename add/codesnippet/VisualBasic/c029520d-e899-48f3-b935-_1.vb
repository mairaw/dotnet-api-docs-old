    Public Sub DrawVisualStyleElement_Button_RadioButton8(ByVal e As PaintEventArgs)
        If (VisualStyleRenderer.IsElementDefined( _
         VisualStyleElement.Button.RadioButton.CheckedDisabled)) Then
            Dim renderer As New VisualStyleRenderer _
              (VisualStyleElement.Button.RadioButton.CheckedDisabled)
            Dim rectangle1 As New Rectangle(10, 50, 50, 50)
            renderer.DrawBackground(e.Graphics, rectangle1)
            e.Graphics.DrawString("VisualStyleElement.Button.RadioButton.CheckedDisabled", _
              Me.Font, Brushes.Black, New Point(10, 10))
        Else
            e.Graphics.DrawString("This element is not defined in the current visual style.", _
              Me.Font, Brushes.Black, New Point(10, 10))
        End If
    End Sub