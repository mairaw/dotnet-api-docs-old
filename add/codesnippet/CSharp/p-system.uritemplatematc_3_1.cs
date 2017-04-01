            UriTemplate template = new UriTemplate("weather/{state}/*?forecast=today");
            Uri baseAddress = new Uri("http://localhost");
            Uri fullUri = new Uri("http://localhost/weather/WA/Seattle?forecast=today");

            Console.WriteLine("Matching {0} to {1}", template.ToString(), fullUri.ToString());

            // Match a URI to a template
            UriTemplateMatch results = template.Match(baseAddress, fullUri);
            if (results != null)
            {
                Console.WriteLine("WildcardPathSegments:");
                foreach (string segment in results.WildcardPathSegments)
                {
                    Console.WriteLine("     {0}", segment);
                }
                Console.WriteLine();
            }
            // Code output:
            // WildcardPathSegments:
            //   seattle