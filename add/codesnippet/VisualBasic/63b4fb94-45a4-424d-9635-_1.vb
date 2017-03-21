    Public Sub DrawVisualStyleElementExplorerBarHeaderClose1(ByVal e As PaintEventArgs)
        If (VisualStyleRenderer.IsElementDefined( _
         VisualStyleElement.ExplorerBar.HeaderClose.Normal)) Then
            Dim renderer As New VisualStyleRenderer _
              (VisualStyleElement.ExplorerBar.HeaderClose.Normal)
            Dim rectangle1 As New Rectangle(10, 50, 50, 50)
            renderer.DrawBackground(e.Graphics, rectangle1)
            e.Graphics.DrawString("VisualStyleElement.ExplorerBar.HeaderClose.Normal", _
              Me.Font, Brushes.Black, New Point(10, 10))
        Else
            e.Graphics.DrawString("This element is not defined in the current visual style.", _
              Me.Font, Brushes.Black, New Point(10, 10))
        End If
    End Sub