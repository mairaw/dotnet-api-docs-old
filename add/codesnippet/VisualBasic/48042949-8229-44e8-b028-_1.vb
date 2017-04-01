    'Formats Web request event information.
    Public Overrides Sub FormatCustomEventDetails( _
    ByVal formatter As WebEventFormatter)
        MyBase.FormatCustomEventDetails(formatter)

        ' Add custom data.
        formatter.AppendLine("")
        formatter.AppendLine("Custom Process Statistics:")

        formatter.IndentationLevel += 1

        ' Get the process statistics.
        formatter.AppendLine(GetAppDomainCount())
        formatter.AppendLine(GetManagedHeapSize())
        formatter.AppendLine(GetPeakWorkingSet())
        formatter.AppendLine(GetProcessStartTime())
        formatter.AppendLine(GetRequestsExecuting())
        formatter.AppendLine(GetRequestsQueued())
        formatter.AppendLine(GetRequestsRejected())
        formatter.AppendLine(GetThreadCount())
        formatter.AppendLine(GetWorkingSet())

        formatter.IndentationLevel -= 1

        formatter.AppendLine(eventInfo.ToString())
    End Sub 'FormatCustomEventDetails 
End Class 'SampleWebEventHelper