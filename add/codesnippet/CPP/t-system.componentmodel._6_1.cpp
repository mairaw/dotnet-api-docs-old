      // The following code shows how to publish a service using a callback function.
      // Creates a service creator callback.
      ServiceCreatorCallback^ callback1 =
         gcnew ServiceCreatorCallback( this, &Sample::myCallBackMethod );
      
      // Adds the service using its type and the service creator callback.
      serviceContainer->AddService( myService::typeid, callback1 );