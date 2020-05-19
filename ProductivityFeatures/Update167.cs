using System;
using System.Diagnostics.CodeAnalysis;

namespace ProductivityFeatures
{
    // Add debugger display attribute
    // This allows you to pin properties within the debugger programmatically in your code 
    // Place your cursor on the class name, type (Ctrl + .)
    // Select Add `DebuggerDisplay` attribute 
    // This will add the debugger display attribute to the top of your class 
    // and generate an auto method that returns ToString()
    // You can then edit the return to the property value you want pinned in the debugger
    class Update167
    {
        // Generate comparison operators for types that implement IComparable
        // Place your cursor either inside the class or on IComparable, type (Ctrl + .)
        // Select Generate comparison operators
        struct GenerateComparison : IComparable<GenerateComparison>
        {
            public int CompareTo([AllowNull] GenerateComparison other)
            {
                throw new NotImplementedException();
            }
        }

        // Generate IEquatable operators when generating .Equals for structs
        // Place your cursor within the struct, type (Ctrl + .)
        // Select Generate Equals(object).
        public readonly struct GenerateIEquatable
        {
            public int A { get; }
            public int B { get; }
        }

        // Create and initialize properties or fields for all unused constructor parameters
        // Place your cursor on one of the remaining parameters, "id" or "lastName"
        // Type (Ctrl + .)
        // To create and initialize fields, select Create and assign remaining as fields
        // To create and initialize properties, select Create and assign remaining as properties
        private readonly string name;
        private readonly int age;

        public Update167(int id, string name, int age, string lastName)
        {
            // Code fix for accidental assignments to the same variable
            // Place your cursor on the warning, type (Ctrl + .)
            // Select Assign to <QualifiedName>.value
            name = name;

            // Code fix for accidental comparisons to the same variable
            // Place your cursor on the warning, type (Ctrl + .)
            // Select Compare to <QualifiedName>.value
            if (age == age);

            Console.WriteLine(id + lastName);
        }

        // IntelliSense completion in DateTime and TimeSpan string literals
        // Place your cursor inside the DateTime or TimeSpan string literal
        // Type (Ctrl + space) to view the list of completions and a description of each character
        string date = DateTime.Now.ToString("mm:");

        // Add parameter in Change Signature dialog
        // Place your cursor within the method’s signature, type (Ctrl + .)
        // Select Change signature 
        // Within the Change Signature dialog select Add to add a parameter
        public void AddParameter(int value)
        {   
        }
    }
}
