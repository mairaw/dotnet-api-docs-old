            // Creates a reference to the System.DateTime type.
            CodeTypeReference^ typeRef1 = gcnew CodeTypeReference("System.DateTime");

            // Creates a typeof expression for the specified type reference.
            CodeTypeOfExpression^ typeof1 = gcnew CodeTypeOfExpression(typeRef1);

            // Create a C# code provider
            CodeDomProvider^ provider = CodeDomProvider::CreateProvider("CSharp");

            // Generate code and send the output to the console
            provider->GenerateCodeFromExpression(typeof1, Console::Out, gcnew CodeGeneratorOptions());
            // The code generator produces the following source code for the preceeding example code:
            //    typeof(System.DateTime)