using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductivityFeatures
{
    class Update158
    {
        // Format Document
        // Press (Ctrl k, d) to format the spacing below.
        public void FixSpacing()
        {
        }

        // Code Cleanup
        // If you'd like Code cleanup to include var and explicit type rules
        // check the option to apply implicit/explicit type preferences
        // in Analyze > Code Cleanup > Configure Code Cleanup.
        // Now press (Ctrl + k, Ctrl + e) to "fix" the types below.
        public void FixMyType()
        {
            var myint = 0;
            var mystring = "Hello, world!";
            var myfloat = 0.2;
            var mybool = true;
            Console.WriteLine(myint.ToString(), mystring, myfloat, mybool);
        }

        // Click in the if statements and type (Ctrl + .) to invert them.
        public void InvertIfElse()
        {
            var tru = true;
            //Bool expressions
            if (tru)
            {
                Console.WriteLine("Truth!");
            }
            else
            {
                Console.WriteLine("Falsehood!");
            }

            // Comparisons
            if (1 > 2)
            {
                Console.WriteLine("Change places!");
            }
            else
            {
                Console.WriteLine("Okay!");
            }

            // Multiple conditions
            if (0 == 0 && true || true)
            {
                Console.WriteLine("AlwaysTrue");
            }
            else
            {
                Console.WriteLine("Unreachable");
            }
        }

        // Multi-caret allows you to place multiple cursors in the file 
        // and edit them all at once.
        // Hold down (Ctrl + Alt) and click with the left mouse 
        // at the beginning of the strings below. Add the word "Hi"
        public void MultiCaret()
        {
            Console.WriteLine("dotnet Bot!");
            Console.WriteLine("Allison!");
            Console.WriteLine("Kendra!");
        }

        // Use a conditional expression to simplify your code.
        // Click inside the if statement and type (Ctrl + .)
        // to refactor the if else into a conditional expression.
        public bool ConditionalExpression(int two)
        {
            if (two % 0 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // You can now add a parameter to a method from a callsite.
        // This example involves the two methods below.
        // Uncomment the parameter in callMethodA and use the codefix (Ctrl + .) 
        // to add a string parameter to the MethodA signature.
        public void CallMethodA()
        {
            MethodA(0 /*, "add this parameter"*/);
        }

        public void MethodA(int zero)
        {
        }

        // Place you cursor beside the grayed out parenthesis in the if statement.
        // Type (Ctrl + .) to remove the extra parenthesis.
        public void RemoveParenthesis()
        {
            if ((true) && !(2 > 1)) { }
        }

        // Place your cursor in the for loop statement.
        // Use (Ctrl + .) to convert it to a foreach loop.
        // Use (Ctrl + .) to convert it back into a for loop.
        public void ForLoopToForEach()
        {
            List<int> intList = new List<int>() {1, 2, 3};

            for (int i = 0; i < intList.Count; i++)
            {
                int num = intList[i];
                Console.WriteLine(intList[num]);
            }
        }

        // Place you cursor in the linq query of shortGreeting.
        // Type (Shift + Alt + plus symbol) to select only the linq query.
        // Type (Ctrl + .) to convert the linq query into a foreach loop.
        public void LinqToForEach()
        {
            var greetings = new List<string>() {"hi", "yo", "hello", "howdy"};

            var shortGreeting =
                from greet in greetings
                where greet.Length < 3
                select greet;
        }

        // Use Go to Enclosing Block to jump to the top of the block your cursor is in.
        // Click inside the curly brace below and type (Shift + Alt + [) 
        // to jump to the top of the class.
    }

    // Don't forget you can now navigate to files that you've recently 
    // viewed with Go To All. Type (Ctrl + t) to bring up the search box.
    // Type (r) to view your recent files. Navigate back to Program.cs via the drop down.
}