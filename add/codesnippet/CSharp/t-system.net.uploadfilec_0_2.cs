    private static void UploadFileCallback (Object sender, UploadFileCompletedEventArgs e)
    {
        System.Threading.AutoResetEvent waiter = (System.Threading.AutoResetEvent)e.UserState;;
        try
        {
            string reply = System.Text.Encoding.UTF8.GetString (e.Result);

            Console.WriteLine (reply);
        }
        finally
        {
            // If this thread throws an exception, make sure that
            // you let the main application thread resume.
            waiter.Set ();
        }
    }
