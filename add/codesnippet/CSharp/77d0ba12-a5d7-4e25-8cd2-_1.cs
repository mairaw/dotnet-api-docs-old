            // Add the following directive to your file:
            // using System.Linq.Expressions;  

            // This expression divides its first argument by its second argument.
            // Both arguments must be of the same type.
            Expression divideExpr = Expression.Divide(
                Expression.Constant(10.0),
                Expression.Constant(4.0)
            );

            // Print out the expression.
            Console.WriteLine(divideExpr.ToString());

            // The following statement first creates an expression tree,
            // then compiles it, and then executes it.
            Console.WriteLine(
                Expression.Lambda<Func<double>>(divideExpr).Compile()());

            // This code example produces the following output:
            //
            // (10/4)
            // 2.5