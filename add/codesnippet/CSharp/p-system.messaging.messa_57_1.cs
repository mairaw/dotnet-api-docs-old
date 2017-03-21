        // Set the queue's MessageReadPropertyFilter property to enable the
        // message's Authenticated property.
        queue.MessageReadPropertyFilter.Authenticated = true;

        // Peek at the message. Time out after ten seconds in case the message
        // was not delivered.
        orderMessage = queue.Peek(TimeSpan.FromSeconds(10.0)); 

        // Display the value of the message's Authenticated property.
        Console.WriteLine("Message.Authenticated: {0}",
            orderMessage.Authenticated);