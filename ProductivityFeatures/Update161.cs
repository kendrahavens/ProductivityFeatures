using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProductivityFeatures
{
    // Prevent usings inside a namespace code style rule
    // You can now use a new editorconfig code style rule to require or prevent usings inside a namespace
    // This setting will also be exported when you use the “Generate editorconfig” button located in Tools > Options > Text Editor > C# > Code Style
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // Move Type to Namespace	
    // Place cursor in the class name and type (Ctrl + .)	
    // Select 'Move Type to Namespace'	
    // In the Move type to namespace dialog select 'NewNamespace'	
    // This entire class was moved to the new namespace.
    class Update161
    {
        // Split if statements into nested if statements
        // Place cursor by the '&&' and type (Ctrl + .)
        // Select 'Split into nested if statements'
        public void SplitIf()
        {
            if (1 < 2 && 2 > 3)
            {

            }
        }

        // Merge nested if statements
        // Place cursor in 'if' keyword
        // Type (Ctrl +.) and select 'Merge with nested if statement'
        public void MergeIf()
        {
            if (1 < 2)
            {
                if (2 > 3)
                {

                }
            }
        }

        // Regex Completion (no completion-suffix work)
        // Place cursor in the quotation marks in the Regex declaration
        // Type (Ctrl + space) to view the list of Regex completions
        public void RegexCompletion()
        {
            Regex r = new Regex("");
        }

        // Wrapping for binary expression
        public void WrapBinaryExpression()
        {
            if (1 < 3 || 2 > 4 && true || 1 > 0 || false && 1 == 1) { }
        }

        // Find All References 'Kind' column values for Namespaces and Types
        // Select the 'foo' field and type (Shift + F12) to open Find All References window
        // Scroll right to view the "Kind" column
        // Click on the filter on the column header to view new namespace and type awareness
        public void AdditionsToKindColumninFindAllReferences()
        {
            Update160 fooType = new Update160();
            fooType.foo = 0;
        }

        // Right click on this project or the solution in Solution Explorer
        // Select Analyze and Code cleanup
        // Select 'Run Code Cleanup'
        // The spacing below and in all documents selected had code cleanup applied!
        void CodeCleanupProjectsAndSolution()
        {

        }

        // Select the entire comment below
        // Type (Ctrl+Shift,/) to toggle the line comment
        // Type the same command again to toggle the comments back!
        void ToggleBlockComment()
        {
            /*string hi = "Hello, World!";*/
        }

        // Initialize a private field from constructor and vice versa
        // SELECT the 'addToConstructor' field and type (Ctrl + .)
        // Select 'Add parameter to constructor'
        // Note that all available constructors are now listed
        private int existingField;
        private int addToConstructor;

        // Place your cusor in the 'createField' parameter and type (Ctrl + .)
        // Select 'Create and initialize field' to create a field from the constructor
        public Update161(int existingField, int createField) { }
        public Update161() { }

        // Intellisense completion for unimported types
        // Receive intellisense suggestions for types in dependencies in your project even if you have not yet added the import statement to your file
        // Set string json to equal JsonConvert and when you press tab the Newtonsoft.Json using will be added to your file
        string json;

        // Toggle single line comment/uncomment is now available through the keyboard shortcut (Ctrl + K, /)
        // This command will add or remove a single line comment depending on whether your selection is already commented
        public void SingleLineComment()
        {
            Console.WriteLine("comment this line");
        }
    }

    // Code fix to unseal a class
    // Uncomment the MyClass declaration
    // Place cursor in InternalClass
    // Type (Ctrl + .) to open quick fixes and refactorings menu
    internal sealed class InternalClass { }
    //class MyClass : InternalClass { }
}

namespace NewNamespace
{
    // Make readonly struct fields writable
    // Place your cursor in 'MyStruct'
    // Type (Ctrl+.) to trigger the Quik Actions and Refactoings menu
    // Select make readonly fields writable
    struct MyStruct
    {
        readonly int Value;

        public MyStruct(int value)
        {
            Value = value;
        }

        public void Test()
        {
            this = new MyStruct(5);
        }
    }
}
