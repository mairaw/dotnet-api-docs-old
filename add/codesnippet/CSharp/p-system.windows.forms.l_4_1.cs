private void ListView1_AfterLabelEdit(Object sender, LabelEditEventArgs e) {

System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
messageBoxCS.AppendFormat("{0} = {1}", "Label", e.Label );
messageBoxCS.AppendLine();
messageBoxCS.AppendFormat("{0} = {1}", "Item", e.Item );
messageBoxCS.AppendLine();
messageBoxCS.AppendFormat("{0} = {1}", "CancelEdit", e.CancelEdit );
messageBoxCS.AppendLine();
MessageBox.Show(messageBoxCS.ToString(), "AfterLabelEdit Event" );
}