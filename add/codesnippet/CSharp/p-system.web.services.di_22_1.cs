         string myUrl = "http://localhost/Sample_cs.vsdisco";
         DiscoveryClientProtocol myProtocol = new DiscoveryClientProtocol();
         // Get the discovery document myDiscoveryDocument.
         DiscoveryDocument myDiscoveryDocument = myProtocol.Discover(myUrl);
         // Get the references of myDiscoveryDocument.
         IEnumerator myEnumerator = myDiscoveryDocument.References.GetEnumerator();
         while(myEnumerator.MoveNext())
         {
            DiscoveryDocumentReference myNewReference = 
                           (DiscoveryDocumentReference)myEnumerator.Current;
            // Set the ClientProtocol of myNewReference.
            DiscoveryClientProtocol myNewProtocol = myNewReference.ClientProtocol;
            // Verify for all the valid references.
            myNewReference.ResolveAll();

            // Get the document of myNewReference.
            DiscoveryDocument myNewDiscoveryDocument = 
                                                 myNewReference.Document;

            IEnumerator myNewEnumerator = 
                           myNewDiscoveryDocument.References.GetEnumerator();
            Console.WriteLine("The valid discovery document is : \n");
            while(myNewEnumerator.MoveNext())
            {
               // Display the references of myNewDiscoveryDocument on the console.
               Console.WriteLine(((DiscoveryDocumentReference)myNewEnumerator.Current).Ref);
            }
         }