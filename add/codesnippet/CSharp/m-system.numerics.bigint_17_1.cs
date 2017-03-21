      long[] longs = { Int64.MinValue, -10534, -189, 0, 17, 113439,
                       Int64.MaxValue };
      BigInteger constructed, assigned;
      
      foreach (long number in longs)
      {
         constructed = new BigInteger(number);
         assigned = number;
         Console.WriteLine("{0} = {1}: {2}", constructed, assigned, 
                           constructed.Equals(assigned)); 
      }                                                  
      // The example displays the following output:
      //       -2147483648 = -2147483648: True
      //       -10534 = -10534: True
      //       -189 = -189: True
      //       0 = 0: True
      //       17 = 17: True
      //       113439 = 113439: True
      //       2147483647 = 2147483647: True      