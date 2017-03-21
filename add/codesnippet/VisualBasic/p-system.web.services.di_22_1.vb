         Dim myUrl As String = "http://localhost/Sample_vb.vsdisco"
         Dim myProtocol As New DiscoveryClientProtocol()
         ' Get the discovery document myDiscoveryDocument.
         Dim myDiscoveryDocument As DiscoveryDocument = myProtocol.Discover(myUrl)
         ' Get the references of myDiscoveryDocument.
         Dim myEnumerator As IEnumerator = myDiscoveryDocument.References.GetEnumerator()
         While myEnumerator.MoveNext()
            Dim myNewReference As DiscoveryDocumentReference = _ 
                                  CType(myEnumerator.Current, DiscoveryDocumentReference)
            ' Set the ClientProtocol of myNewReference.
            Dim myNewProtocol As DiscoveryClientProtocol = myNewReference.ClientProtocol
            ' Verify for all the valid references.
            myNewReference.ResolveAll()

            ' Get the document of myNewReference.
            Dim myNewDiscoveryDocument As DiscoveryDocument = myNewReference.Document
            Dim myNewEnumerator As IEnumerator = _ 
                                     myNewDiscoveryDocument.References.GetEnumerator()
            Console.WriteLine("The valid discovery document is : " + ControlChars.NewLine)
            While myNewEnumerator.MoveNext()
               ' Display the references of myNewDiscoveryDocument on the console.
               Console.WriteLine(CType(myNewEnumerator.Current, DiscoveryDocumentReference).Ref)
            End While
         End While