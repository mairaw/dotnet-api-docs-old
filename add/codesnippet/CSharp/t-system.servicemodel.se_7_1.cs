            WSHttpBinding b = new WSHttpBinding();
            EndpointAddress ea = new EndpointAddress("http://localhost/Calculator");
            CalculatorClient client = new CalculatorClient(b, ea);
            IssuedTokenClientCredential itcc = client.ClientCredentials.IssuedToken;