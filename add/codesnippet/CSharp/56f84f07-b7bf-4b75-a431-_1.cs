            // Add the following directive to your file:
            // using System.Linq.Expressions;  

            // This parameter expression represents a variable that will hold the two-dimensional array.
            ParameterExpression arrayExpr = Expression.Parameter(typeof(int[,]), "Array");

            // This parameter expression represents a first array index.            
            ParameterExpression firstIndexExpr = Expression.Parameter(typeof(int), "FirstIndex");
            // This parameter expression represents a second array index.            
            ParameterExpression secondIndexExpr = Expression.Parameter(typeof(int), "SecondIndex");

            // The list of indexes.
            List<Expression> indexes = new List<Expression> { firstIndexExpr, secondIndexExpr };


            // This parameter represents the value that will be added to a corresponding array element.
            ParameterExpression valueExpr = Expression.Parameter(typeof(int), "Value");

            // This expression represents an access operation to a multidimensional array.
            // It can be used for assigning to, or reading from, an array element.
            Expression arrayAccessExpr = Expression.ArrayAccess(
                arrayExpr,
                indexes
            );

            // This lambda expression assigns a value provided to it to a specified array element.
            // The array, the index of the array element, and the value to be added to the element
            // are parameters of the lambda expression.
            Expression<Func<int[,], int, int, int, int>> lambdaExpr =
                Expression.Lambda<Func<int[,], int, int, int, int>>(
                    Expression.Assign(arrayAccessExpr, Expression.Add(arrayAccessExpr, valueExpr)),
                    arrayExpr,
                    firstIndexExpr,
                    secondIndexExpr,
                    valueExpr
            );

            // Print out expressions.
            Console.WriteLine("Array Access Expression:");
            Console.WriteLine(arrayAccessExpr.ToString());

            Console.WriteLine("Lambda Expression:");
            Console.WriteLine(lambdaExpr.ToString());

            Console.WriteLine("The result of executing the lambda expression:");

            // The following statement first creates an expression tree,
            // then compiles it, and then executes it.
            // Parameters passed to the Invoke method are passed to the lambda expression.
            int[,] sampleArray = { {10,  20,   30},
                                   {100, 200, 300}};
            Console.WriteLine(lambdaExpr.Compile().Invoke(sampleArray, 1, 1, 5));

            // This code example produces the following output:
            //
            // Array Access Expression:
            // Array[FirstIndex, SecondIndex]

            // Lambda Expression:
            // (Array, FirstIndex, SecondIndex Value) => 
            // (Array[FirstIndex, SecondIndex] = (Array[FirstIndex, SecondIndex] + Value))

            // The result of executing the lambda expression:
            // 205
