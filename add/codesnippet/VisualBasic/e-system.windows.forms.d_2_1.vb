Private Sub DataGridView1_RowDividerHeightChanged(sender as Object, e as DataGridViewRowEventArgs) _ 
     Handles DataGridView1.RowDividerHeightChanged

    Dim messageBoxVB as New System.Text.StringBuilder()
    messageBoxVB.AppendFormat("{0} = {1}", "Row", e.Row)
    messageBoxVB.AppendLine()
    MessageBox.Show(messageBoxVB.ToString(),"RowDividerHeightChanged Event")

End Sub