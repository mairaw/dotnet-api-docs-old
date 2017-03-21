      Process^ myProcess = gcnew Process;

      // Get the process start information of notepad.
      ProcessStartInfo^ myProcessStartInfo = gcnew ProcessStartInfo( "notepad.exe" );

      // Assign 'StartInfo' of notepad to 'StartInfo' of 'myProcess' Object*.
      myProcess->StartInfo = myProcessStartInfo;

      // Create a notepad.
      myProcess->Start();
      System::Threading::Thread::Sleep( 1000 );
      ProcessModule^ myProcessModule;

      // Get all the modules associated with 'myProcess'.
      ProcessModuleCollection^ myProcessModuleCollection = myProcess->Modules;
      Console::WriteLine( "'FileversionInfo' of the modules associated with 'notepad' are:" );
      
      // Display the 'FileVersionInfo' of each of the modules.
      for ( int i = 0; i < myProcessModuleCollection->Count; i++ )
      {
         myProcessModule = myProcessModuleCollection[ i ];
         Console::WriteLine( "{0} : {1}", myProcessModule->ModuleName, myProcessModule->FileVersionInfo );
      }
      myProcessModule = myProcess->MainModule;

      // Display the 'FileVersionInfo' of main module.
      Console::WriteLine( "The process's main module's FileVersionInfo is: {0}", myProcessModule->FileVersionInfo );
      myProcess->CloseMainWindow();