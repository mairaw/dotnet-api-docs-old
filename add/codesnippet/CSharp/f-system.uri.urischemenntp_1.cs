            Uri address5 = new Uri("nntp://news.contoso.com/123456@contoso.com");
            if (address5.Scheme == Uri.UriSchemeNntp)
                Console.WriteLine("Uri is nntp protocol");