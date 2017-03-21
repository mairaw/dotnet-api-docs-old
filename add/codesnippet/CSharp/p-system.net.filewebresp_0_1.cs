   public static void GetPage(String url) 
    {
      try 
        {     
            Uri fileUrl = new Uri("file://"+url);
            // Create a 'FileWebrequest' object with the specified Uri.
            FileWebRequest myFileWebRequest = (FileWebRequest)WebRequest.Create(fileUrl); 
            // Send the 'fileWebRequest' and wait for response.    
            FileWebResponse myFileWebResponse = (FileWebResponse)myFileWebRequest.GetResponse(); 
            // Print the ContentLength and ContentType properties received as headers in the response object.
            Console.WriteLine("\nContent length :{0}, Content Type : {1}",myFileWebResponse.ContentLength,myFileWebResponse.ContentType);  
            // Release resources of response object.
            myFileWebResponse.Close();
        } 
      catch(WebException e) 
        {
            Console.WriteLine("\r\nWebException thrown.The Reason for failure is : {0}",e.Status); 
        }
      catch(Exception e)
        {
            Console.WriteLine("\nThe following Exception was raised : {0}",e.Message);
        }
   }