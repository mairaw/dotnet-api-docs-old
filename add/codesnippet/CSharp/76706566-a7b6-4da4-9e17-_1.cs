        // Create the server channel.
        System.Collections.IDictionary properties = 
            new System.Collections.Hashtable();
        properties["name"] = "ipc";
        properties["priority"] = "20";
        properties["portName"] = "localhost:9090";
        IpcChannel serverChannel = new IpcChannel(properties, null, null); 