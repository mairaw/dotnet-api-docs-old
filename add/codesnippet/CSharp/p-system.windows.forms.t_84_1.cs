private void ToolStripDropDown1_Closing(Object sender, ToolStripDropDownClosingEventArgs e) {

System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
messageBoxCS.AppendFormat("{0} = {1}", "CloseReason", e.CloseReason );
messageBoxCS.AppendLine();
messageBoxCS.AppendFormat("{0} = {1}", "Cancel", e.Cancel );
messageBoxCS.AppendLine();
MessageBox.Show(messageBoxCS.ToString(), "Closing Event" );
}