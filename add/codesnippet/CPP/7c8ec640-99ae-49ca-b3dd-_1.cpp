    // Connect to a queue on the local computer, grant exclusive read
    // access to the first application that accesses the queue, and
    // enable connection caching.
    MessageQueue^ queue = gcnew MessageQueue(".\\exampleQueue", true, true);

    queue->Close();