void PingCompletedCallback( Object^ /*sender*/, PingCompletedEventArgs^ e )
{
   
   // If the operation was canceled, display a message to the user.
   if ( e->Cancelled )
   {
      Console::WriteLine( "Ping canceled." );
      
      // Let the main thread resume. 
      // UserToken is the AutoResetEvent object that the main thread 
      // is waiting for.
      (dynamic_cast<AutoResetEvent^>(e->UserState))->Set();
   }

   
   // If an error occurred, display the exception to the user.
   if ( e->Error != nullptr )
   {
      Console::WriteLine( "Ping failed:" );
      Console::WriteLine( e->Error->ToString() );
      
      // Let the main thread resume. 
      (dynamic_cast<AutoResetEvent^>(e->UserState))->Set();
   }

   PingReply ^ reply = e->Reply;
   DisplayReply( reply );
   
   // Let the main thread resume.
   (dynamic_cast<AutoResetEvent^>(e->UserState))->Set();
}

