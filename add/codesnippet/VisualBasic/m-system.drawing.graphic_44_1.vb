    Private Sub DrawIconRectangle(ByVal e As PaintEventArgs)

        ' Create icon.
        Dim newIcon As New Icon("SampIcon.ico")

        ' Create rectangle for icon.
        Dim rect As New Rectangle(100, 100, 200, 200)

        ' Draw icon to screen.
        e.Graphics.DrawIcon(newIcon, rect)
    End Sub