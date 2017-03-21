        ' Create a new Uri from a string address.
        Dim uriAddress As New Uri("HTTP://www.ConToso.com:80//thick%20and%20thin.htm")
        
        ' Write the new Uri to the console and note the difference in the two values.
        ' ToString() gives the canonical version.  OriginalString gives the orginal 
        ' string that was passed to the constructor.
        ' The following outputs "http://www.contoso.com/thick and thin.htm".
        Console.WriteLine(uriAddress.ToString())
        
        ' The following outputs "HTTP://www.ConToso.com:80//thick%20and%20thin.htm".
        Console.WriteLine(uriAddress.OriginalString)
    
    End Sub 'SampleOriginalString