        // Set the queue's MessageReadPropertyFilter property to enable the
        // message's UseJournalQueue property.
        queue.MessageReadPropertyFilter.UseJournalQueue = true;

        // Peek at the message. Time out after ten seconds in case the message
        // was not delivered.
        orderMessage = queue.Peek(TimeSpan.FromSeconds(10.0)); 

        // Display the value of the message's UseJournalQueue property.
        Console.WriteLine("Message.UseJournalQueue: {0}",
            orderMessage.UseJournalQueue);