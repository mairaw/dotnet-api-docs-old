   private void MyUnion()
   {
      // Create a DnsPermission instance that is the union of the current DnsPermission
      // instance and the specified DnsPermission instance.     
      DnsPermission permission = (DnsPermission)dnsPermission1.Union(dnsPermission2);
      // Print the attributes and the values of the union instance of DnsPermission.
      PrintKeysAndValues(permission.ToXml().Attributes);
   }
   public void useDns() {
      // Create a DnsPermission instance.
      dnsPermission1 = new DnsPermission(PermissionState.Unrestricted);
      dnsPermission2 = new DnsPermission(PermissionState.None);
      // Check for permission.
      dnsPermission1.Demand();
      dnsPermission2.Demand();
      Console.WriteLine("Attributes and Values of first DnsPermission instance :");
      PrintKeysAndValues(dnsPermission1.ToXml().Attributes);
      Console.WriteLine("Attributes and Values of second DnsPermission instance :");
      PrintKeysAndValues(dnsPermission2.ToXml().Attributes);
      Console.WriteLine("Union of both instances : ");
      MyUnion();
      Console.WriteLine("Intersection of both instances : ");
      MyIntersection();
   }

   private void PrintKeysAndValues(Hashtable myList) {
      // Get the enumerator that can iterate through the hash tabble.
      IDictionaryEnumerator myEnumerator = myList.GetEnumerator();
      Console.WriteLine("\t-KEY-\t-VALUE-");
      while (myEnumerator.MoveNext())
         Console.WriteLine("\t{0}:\t{1}", myEnumerator.Key, myEnumerator.Value);
      Console.WriteLine();
   }