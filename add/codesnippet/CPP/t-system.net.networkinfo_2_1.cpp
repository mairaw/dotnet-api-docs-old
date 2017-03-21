void DisplayIPv6NetworkInterfaces()
{
   array<NetworkInterface^>^nics = NetworkInterface::GetAllNetworkInterfaces();
   IPGlobalProperties ^ properties = IPGlobalProperties::GetIPGlobalProperties();
   Console::WriteLine( "IPv6 interface information for {0}.{1}", 
       properties->HostName, properties->DomainName );

   int count = 0;

   System::Collections::IEnumerator^ myEnum24 = nics->GetEnumerator();
   while ( myEnum24->MoveNext() )
   {
      NetworkInterface ^ adapter = safe_cast<NetworkInterface ^>(myEnum24->Current);

      // Only display informatin for interfaces that support IPv6.
      if ( adapter->Supports( NetworkInterfaceComponent::IPv6 ) == false )
      {
         continue;
      }
      
      count++;
      
      Console::WriteLine();
      Console::WriteLine( adapter->Description );

      // Underline the description.
      Console::WriteLine( String::Empty->PadLeft( adapter->Description->Length, '=' ) );
      IPInterfaceProperties ^ adapterProperties = adapter->GetIPProperties();

      // Try to get the IPv6 interface properties.
      IPv6InterfaceProperties ^ p = adapterProperties->GetIPv6Properties();
      if ( !p )
      {
         Console::WriteLine( "No IPv6 information is available for this interface." );
         continue;
      }

      // Display the IPv6 specific data.
      Console::WriteLine( "  Index ............................. : {0}", 
         p->Index );
      Console::WriteLine( "  MTU ............................... : {0}", 
         p->Mtu );
   }
   if (count == 0)
   {
       Console::WriteLine("  No IPv6 interfaces were found.");
       Console::WriteLine();
   }
}