    public static void SendTo1()
    {
        IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
        IPEndPoint endPoint = new IPEndPoint(hostEntry.AddressList[0], 11000);

        Socket s = new Socket(endPoint.Address.AddressFamily,
            SocketType.Dgram,
            ProtocolType.Udp);
      
        byte[] msg = Encoding.ASCII.GetBytes("This is a test");
        Console.WriteLine("Sending data.");
        // This call blocks. 
        s.SendTo(msg, endPoint);
        s.Close();
    }