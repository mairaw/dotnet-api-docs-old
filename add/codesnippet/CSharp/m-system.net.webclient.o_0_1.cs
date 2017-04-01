			// Create a new WebClient instance.
			WebClient myWebClient = new WebClient();
			// Download home page data. 
			Console.WriteLine("Accessing {0} ...",  uriString);						
			// Open a stream to point to the data stream coming from the Web resource.
			Stream myStream = myWebClient.OpenRead(uriString);

			Console.WriteLine("\nDisplaying Data :\n");
			StreamReader sr = new StreamReader(myStream);
			Console.WriteLine(sr.ReadToEnd());


			// Close the stream. 
			myStream.Close();