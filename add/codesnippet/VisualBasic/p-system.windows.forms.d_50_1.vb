Private Sub ChangeParentRowLabels(ByVal myGrid As DataGrid)
    Static currentLabelStyle As Integer
    If currentLabelStyle = 4 Then currentLabelStyle = 0
    Select Case currentLabelStyle
    Case 0 
       myGrid.ParentRowsLabelStyle = DataGridParentRowsLabelStyle.None
    Case 1
       myGrid.ParentRowsLabelStyle = DataGridParentRowsLabelStyle.TableName
    Case 2
       myGrid.ParentRowsLabelStyle = DataGridParentRowsLabelStyle.ColumnName
    Case 3
       myGrid.ParentRowsLabelStyle = DataGridParentRowsLabelStyle.Both
    Case Else
       myGrid.ParentRowsLabelStyle = DataGridParentRowsLabelStyle.Both
    End Select
 End Sub
 