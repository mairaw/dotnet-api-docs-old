Private Sub ToolStripRenderer1_RenderOverflowButtonBackground(sender as Object, e as ToolStripItemRenderEventArgs) _ 
     Handles ToolStripRenderer1.RenderOverflowButtonBackground

    Dim messageBoxVB as New System.Text.StringBuilder()
    messageBoxVB.AppendFormat("{0} = {1}", "Graphics", e.Graphics)
    messageBoxVB.AppendLine()
    messageBoxVB.AppendFormat("{0} = {1}", "Item", e.Item)
    messageBoxVB.AppendLine()
    messageBoxVB.AppendFormat("{0} = {1}", "ToolStrip", e.ToolStrip)
    messageBoxVB.AppendLine()
    MessageBox.Show(messageBoxVB.ToString(),"RenderOverflowButtonBackground Event")

End Sub