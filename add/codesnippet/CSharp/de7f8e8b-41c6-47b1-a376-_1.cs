                string applicationName = "Queued Component";			
                string typeLibraryName = null;
                RegistrationHelper helper = new RegistrationHelper(); 
                // Call the InstallAssembly method passing it the name of the assembly to 
                // install as a COM+ application, the COM+ application name, and 
                // the name of the type library file.
                // Setting the application name and the type library to NULL (nothing in Visual Basic .NET
                // allows you to use the COM+ application name that is given in the assembly and 
                // the default type library name. The application name in the assembly metadata 
                // takes precedence over the application name you provide to InstallAssembly. 
                helper.InstallAssembly(@"C:..\..\QueuedComponent.dll", ref applicationName, ref typeLibraryName, InstallationFlags.CreateTargetApplication);
                Console.WriteLine("Registration succeeded: Type library {0} created.", typeLibraryName);
                Console.Read();