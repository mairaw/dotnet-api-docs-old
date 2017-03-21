        // Connect to a queue on the local computer.
        MessageQueue^ queue = gcnew MessageQueue(".\\exampleQueue");

        // Create a new instance of MessageQueuePermission.
        MessageQueuePermission^ permission = gcnew MessageQueuePermission();

        // Get an instance of MessageQueuePermissionEntryCollection from the
        // permission's PermissionEntries property.
        MessageQueuePermissionEntryCollection^ collection =
            permission->PermissionEntries;

        // Create a new instance of MessageQueuePermissionEntry.
        MessageQueuePermissionEntry^ entry = gcnew MessageQueuePermissionEntry(
            MessageQueuePermissionAccess::Receive, 
            queue->MachineName, 
            queue->Label, 
            queue->Category.ToString());

        // Add the entry to the collection.
        collection->Add(entry);

        // Create another new instance of MessageQueuePermissionEntry.
        MessageQueuePermissionEntry^ newEntry = 
            gcnew MessageQueuePermissionEntry(
            MessageQueuePermissionAccess::Send, 
            queue->MachineName, 
            queue->Label, 
            queue->Category.ToString());

        // Insert the new entry into the collection before the original entry.
        collection->Insert(0, newEntry);

        queue->Close();