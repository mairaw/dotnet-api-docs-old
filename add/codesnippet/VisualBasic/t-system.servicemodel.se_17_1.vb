        ' Create a service host.
        Dim httpUri As New Uri("http://localhost/Calculator")
        Dim sh As New ServiceHost(GetType(Calculator), httpUri)
        
        ' Get a reference to the authentication object.
        Dim myAuthProperties As X509ClientCertificateAuthentication = _
        sh.Credentials.ClientCertificate.Authentication
        
        ' Configure peer trust.
        myAuthProperties.CertificateValidationMode = X509CertificateValidationMode.PeerTrust
        ' Configure chain trust.
        myAuthProperties.CertificateValidationMode = X509CertificateValidationMode.ChainTrust
        ' Configure custom certificate validation.
        myAuthProperties.CertificateValidationMode = X509CertificateValidationMode.Custom
        ' Specify a custom certificate validator (not shown here) that inherits 
        ' from the X509CertificateValidator class. 
        ' creds.ClientCertificate.Authentication.CustomCertificateValidator = _
        '    new MyCertificateValidator()