   // Create new Uri using a string address.         
   Uri^ address = gcnew Uri( "http://[fe80::200:39ff:fe36:1a2d%4]/temp/example.htm" );

   // Make the address DNS safe. 
   // The following outputs "[fe80::200:39ff:fe36:1a2d]".
   Console::WriteLine( address->Host );

   // The following outputs "fe80::200:39ff:fe36:1a2d%4".
   Console::WriteLine( address->DnsSafeHost );