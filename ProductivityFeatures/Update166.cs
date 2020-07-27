// Add file header
// If you'd like to add a file header to a file
// Add the following file header rule to your editorConfig file: file_header_template =
// Set the value of the rule to equal the header syntax you would like applied
// Place your cursor on the first line of a file and type (Ctrl + .) 
// Select Add file banner
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityFeatures
{
    class Update166
    {
        // Convert between regular string literals and verbatim string literals
        // Place your cursor on the regular string or verbatim string and type (Ctrl + .)
        // Select Convert to verbatim string or Convert to regular string
        void StringLiterals()
        {
            Console.WriteLine("Hello World!\r\nclass C\r\n{\r\n\tvoidM()\r\n\t{\r\n\t}\r\n}");
        }
        void SimplifyConditionalExpressions(string someString, int anotherInt)
        {
            // Simplify conditional expressions
            // Place your cursor on the conditional expression and type (Ctrl + .)
            // Select Simplify conditional expression
            var a = Foo() && Bar() ? true : false;
            var b = Foo() && Bar() ? false : true;
        }

        bool Foo() { return true; }
        bool Bar() { return false; }

        // Quick Info style support for XML documentation for <returns> and <value>
        // Place your cursor over the documented code
        // Quick Info will then display the XML documentation for <returns> and <value>
        /// <summary>
        /// Summary
        /// </summary>
        /// <returns>
        /// <para>Line 1</para>
        /// <para>Line 2</para>
        /// </returns>
        /// <value>
        /// <para>Line 1</para>
        /// <para>Line 2</para>
        /// </value>
        public void XMLDocumentation()
        {
        }

        // Add explicit cast when an expression cannot be implicitly cast
        // Uncomment the text below: string b = a;
        // Place your cursor on the error and type (Ctrl + .) 
        // Select Add explicit cast
        static void AddExplicitCast(string[] args)
        {
            object a = "1";
            // string b = a;
        }
    }
}
