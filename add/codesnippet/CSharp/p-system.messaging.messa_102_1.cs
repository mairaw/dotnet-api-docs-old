        // Set the queue's MessageReadPropertyFilter property to enable the
        // message's SenderVersion property.
        queue.MessageReadPropertyFilter.SenderVersion = true;

        // Peek at the message. Time out after ten seconds in case the message
        // was not delivered.
        orderMessage = queue.Peek(TimeSpan.FromSeconds(10.0)); 

        // Display the value of the message's SenderVersion property.
        Console.WriteLine("Message.SenderVersion: {0}",
            orderMessage.SenderVersion);