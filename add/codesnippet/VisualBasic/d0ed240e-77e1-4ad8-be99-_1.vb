    ' Invoked in case of events identified by their event code.and 
    ' event detailed code.
    Public Sub New(ByVal msg As String, ByVal eventSource As Object, _
    ByVal eventCode As Integer, ByVal detailedCode As Integer, _
    ByVal userName As String)
        MyBase.New(msg, eventSource, eventCode, _
        detailedCode, userName)
        ' Perform custom initialization.
        customCreatedMsg = _
        String.Format( _
        "Event created at: {0}", DateTime.Now.TimeOfDay.ToString())

    End Sub 'New

