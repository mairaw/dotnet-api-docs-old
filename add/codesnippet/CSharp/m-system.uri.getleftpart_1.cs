            // Create Uri
            Uri uriAddress = new Uri("http://www.contoso.com/index.htm#search");
            Console.WriteLine(uriAddress.Fragment);
            Console.WriteLine("Uri {0} the default port ", uriAddress.IsDefaultPort ? "uses" : "does not use");
             
            Console.WriteLine("The path of this Uri is {0}", uriAddress.GetLeftPart(UriPartial.Path));
            Console.WriteLine("Hash code {0}", uriAddress.GetHashCode());