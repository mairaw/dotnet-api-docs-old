         // Create an OutputBinding for the Add operation.
         OutputBinding myOutputBinding = new OutputBinding();
         myOutputBinding.Extensions.Add(mySoapBodyBinding);

         // Add the OutputBinding to the OperationBinding. 
         addOperationBinding.Output = myOutputBinding;