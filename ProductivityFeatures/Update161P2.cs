using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityFeatures
{
    // Move Type to Namespace
    // Place cursor in the class name and type (Ctrl + .)
    // Select 'Move Type to Namespace'
    // In the Move type to namespace dialog select 'NewNamespace'
    // This entire class was moved to the new namespace.
    class Update161P2
    {

        // Right click on this project or the solution in Solution Explorer
        // Select Analyze and Code cleanup
        // Select 'Run Code Cleanup'
        // The spacing below and in all documents selected had code cleanup applied!
        void CodeCleanupProjectsAndSolution(        ){

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
        public Update161P2(int existingField, int createField){}
        public Update161P2() { }
    }
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
