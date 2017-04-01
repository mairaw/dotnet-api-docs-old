
    // Connect to a queue on the local computer.
    MessageQueue^ queue = gcnew MessageQueue(".\\exampleQueue");

    // Grant all users in the "Everyone" user group the right to receive
    // messages from the queue.
    queue->SetPermissions("Everyone",
        MessageQueueAccessRights::ReceiveMessage,
        AccessControlEntryType::Allow);

    queue->Close();
