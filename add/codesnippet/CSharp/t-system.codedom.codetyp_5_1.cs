            // Declares a delegate type called TestDelegate with an EventArgs parameter.
            CodeTypeDelegate delegate1 = new CodeTypeDelegate("TestDelegate");            
            delegate1.Parameters.Add( new CodeParameterDeclarationExpression("System.Object", "sender") );
            delegate1.Parameters.Add( new CodeParameterDeclarationExpression("System.EventArgs", "e") );        

            // A C# code generator produces the following source code for the preceeding example code:

            //     public delegate void TestDelegate(object sender, System.EventArgs e);