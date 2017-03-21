        public static WebResponse GetResponseFromServer(Uri uri)
        {
             RequestCachePolicy policy = 
                new  RequestCachePolicy( RequestCacheLevel.NoCacheNoStore);
            WebRequest request = WebRequest.Create(uri);
            request.CachePolicy = policy;
            WebResponse response = request.GetResponse();
            Console.WriteLine("Policy is {0}.", policy.ToString());
            Console.WriteLine("Is the response from the cache? {0}", response.IsFromCache);  
            return response;
            
        } 