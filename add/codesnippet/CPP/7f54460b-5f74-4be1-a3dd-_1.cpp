// Class-level declaration.
// Create a TraceSwitch.
private:
   static TraceSwitch^ generalSwitch = 
      gcnew TraceSwitch( "General", "Entire Application" );

public:
   static void MyErrorMethod( String^ category )
   {
      #if defined(TRACE)
      // Write the message if the TraceSwitch level is set 
      // to Error or higher.
      Trace::WriteIf( generalSwitch->TraceError, "My error message. " );
      
      // Write a second message if the TraceSwitch level is set
      // to Verbose.
      Trace::WriteLineIf( generalSwitch->TraceVerbose, 
         "My second error message.", category );
      #endif
   }