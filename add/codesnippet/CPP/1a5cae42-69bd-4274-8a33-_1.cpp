        // Connect to a queue on the local computer.
        MessageQueue^ queue = gcnew MessageQueue(".\\exampleQueue");

        // Create a new instance of MessageQueuePermissionEntry.
        MessageQueuePermissionEntry^ entry = gcnew MessageQueuePermissionEntry(
            MessageQueuePermissionAccess::Receive,
            queue->Path);

        queue->Close(); 