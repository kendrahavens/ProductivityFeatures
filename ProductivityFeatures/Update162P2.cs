// Sort Usings command is back, separate from the Remove Usings command
// You can now find the Sort Usings command in Edit > Intellisense
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ProductivityFeatures
{
    class Update162P2
    {

        // Convert a switch statement to a switch expression
        // In your project file make sure the language version is set to preview 
        // since switch expressions are a new C# 8.0 feature.
        // Place your cursor in the switch keyword, type (Ctrl + .)
        // Select Convert switch statement to expression
        public void SwitchExpression()
        {
            int line = 1;
            int foo;

            switch (line)
            {
                case 0: foo = 5; break;
                case 1: foo = 4; break;
                default: foo = 0; break;

            }
            Console.WriteLine(foo);
        }

        // Generate a parameter
        // Uncomment the x declaration below to cause an error.
        // Place your cursor in the variable name and type (Ctrl + .) and select Generate a variable
        public void GenerateParameter()
        {
            //x = 53;
        }
    }
}
