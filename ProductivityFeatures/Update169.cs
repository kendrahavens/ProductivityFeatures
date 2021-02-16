using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ProductivityFeatures
{
    class Update169
    {
        // Using directives will now automatically get added
        // When copying and pasting types to a new file
        // You will first need to enable this in Tools > Options > Text Editor > C# or Basic > Advanced
        // Select Add missing using directives on paste
        // Uncomment the text below: Regex r = new Regex("");
        // Notice the using directive automatically added at the top

        // Regex r = new Regex("");

        static void M(string[] args)
        {
            // Preprocessor symbols now have IntelliSense completion
            // Uncomment the text below: #if
            // Place your cursor after the #if directive, press space, and start typing a preproecessor symbol or start typing the following text: N
            // Notice the new completion options for symbols that are currently defined in scope

// #if 

            // Diagnostic tooltip for pragma warnings or numbers for suppressions
            // Hover your cursor over the diagnostic ID or number within the pragma warning
            // Notice the new diagnostic tooltip
#pragma warning disable CS0219
            var i = 0;
#pragma warning restore 219
            var I2 = 0;
        }

        // Use 'new()' in non-contentious scenarios refactoring
        // Place your cursor on the field declaration, press (Ctrl+.)
        // Select Use 'new(...)' 
        List<int> foos = new List<int>();

        public void RedundantEquality(bool b)
        {
            // Remove redundant equality code fix
            // Place your cursor on the redundant equality operator, press (Ctrl+.) 
            // Select Remove redundant equality
            if (b == true)
            {
                return;
            }
        }

        public void ConvertString()
        {
            // Convert a regular string and a verbatim string to an interpolated string
            // That will preserve curly braces that were intended to go in the output
            // This refactoring is not offered if the string is assigned to a constant
            // Place your cursor on the regular string literal, press (Ctrl+.)
            // Select Convert to interpolated string
            var code = @"
        namespace Mynamespace
        {
            public class Program
            {
                public static void Main() {Console.WriteLine();}
            }
        }";
        }

        // Remove unnecessary discard code fix
        // Place your cursor on the faded discard, press (Ctrl+.)
        // Select Remove unnecessary discard
        public void M(object o)
        {
            var v = o switch
            {
                { } _ => 0
            };
        }

        // Semantic colorization for C# 9.0 record types
        // You can customize colors in Tools > Options > Environment > Fonts and Colors
        // In Display items scroll to User Types – Records
        // Under item foreground, select the color that you would like applied to records
        public record Person
        {
            public string LastName { get; }
            public string FirstName { get; }

            public Person(string first, string last) => (FirstName, LastName) = (first, last);
        }

        // Other features in Update 16.9:

        // Comment out new line when return is pressed while cursor is within a comment

        // Inline type hints for variables with inferred types and lambda parameter types

        // Inline hints keyboard shortcut Alt+F1 to view hints at anytime

        // The .NET Code Style (IDE) analyzers can now be enforced on build via project properties

        // IntelliSense completion that automatically inserts a semicolon as a commit character for object creation and method symbol completion

        // Go To All will not display duplicate results across netcoreapp3.1 and netcoreapp2.0 as well as results for partial types that exist only to wrap another nested type

        // Solution Explorer now displays the new .NET 5.0 Source Generators underneath the Analyzer node so you can easily navigate and view the generated code
    }
}
