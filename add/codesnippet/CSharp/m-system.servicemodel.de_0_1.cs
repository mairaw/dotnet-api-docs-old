                // Create a service host.
                Uri httpUri = new Uri("http://localhost/Calculator");
                ServiceHost sh = new ServiceHost(typeof(Calculator), httpUri);

                // Create a binding that uses a WindowsServiceCredential .
                WSHttpBinding b = new WSHttpBinding(SecurityMode.Message);
                b.Security.Message.ClientCredentialType = MessageCredentialType.Windows;

                // Add an endpoint.
                sh.AddServiceEndpoint(typeof(ICalculator), b, "WindowsCalculator");

                // Clone these credentials.
                ServiceCredentials cloneCredential =
                    sh.Credentials.Clone();
