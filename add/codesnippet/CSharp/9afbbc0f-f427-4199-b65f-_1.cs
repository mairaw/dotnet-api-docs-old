            // Add the following directive to your file:
            // using System.Linq.Expressions;  

            // This expression perfroms a logical AND operation
            // on its two arguments, but if the first argument is false,
            // then the second arument is not evaluated.
            // Both arguments must be of the boolean type.
            Expression andAlsoExpr = Expression.AndAlso(
                Expression.Constant(false),
                Expression.Constant(true)
            );

            // Print out the expression.
            Console.WriteLine(andAlsoExpr.ToString());

            // The following statement first creates an expression tree,
            // then compiles it, and then executes it. 
            Console.WriteLine(Expression.Lambda<Func<bool>>(andAlsoExpr).Compile()());

            // This code example produces the following output:
            //
            // (False AndAlso True)
            // False
