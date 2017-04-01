        ' Create a service host.
        Dim httpUri As New Uri("http://localhost/Calculator")
        Dim sh As New ServiceHost(GetType(Calculator), httpUri)
        ' Create a binding that uses a certificate.
        Dim b As New WSHttpBinding(SecurityMode.Message)
        b.Security.Message.ClientCredentialType = MessageCredentialType.Certificate


        ' Get a reference to the authentication object.
        Dim myAuthProperties As X509ClientCertificateAuthentication = _
        sh.Credentials.ClientCertificate.Authentication
        ' Configure IncludeWindowsGroups.
        myAuthProperties.IncludeWindowsGroups = True