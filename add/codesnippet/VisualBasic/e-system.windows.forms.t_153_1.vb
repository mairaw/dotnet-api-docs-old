Private Sub TreeView1_BeforeSelect(sender as Object, e as TreeViewCancelEventArgs) _ 
     Handles TreeView1.BeforeSelect

    Dim messageBoxVB as New System.Text.StringBuilder()
    messageBoxVB.AppendFormat("{0} = {1}", "Node", e.Node)
    messageBoxVB.AppendLine()
    messageBoxVB.AppendFormat("{0} = {1}", "Action", e.Action)
    messageBoxVB.AppendLine()
    messageBoxVB.AppendFormat("{0} = {1}", "Cancel", e.Cancel)
    messageBoxVB.AppendLine()
    MessageBox.Show(messageBoxVB.ToString(),"BeforeSelect Event")

End Sub