private void DataGridView1_RowHeadersWidthSizeModeChanged(Object sender, DataGridViewAutoSizeModeEventArgs e) {

System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
messageBoxCS.AppendFormat("{0} = {1}", "PreviousModeAutoSized", e.PreviousModeAutoSized );
messageBoxCS.AppendLine();
MessageBox.Show(messageBoxCS.ToString(), "RowHeadersWidthSizeModeChanged Event" );
}