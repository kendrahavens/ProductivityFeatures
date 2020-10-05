using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

// Find All References now understands references to symbols within the target string of global SuppressMessageAttribute suppressions
// Place your cursor on the SuppressMessageAttribute target string, press Shift+F12 to Find All References
// Notice how the SuppressMessageAttribute target string will show up in the reference list
[assembly: SuppressMessage("Usage", "CA1801:Review unused parameters", Justification = "<Pending>", Scope = "member", Target = "~M:ProductivityFeatures.Update168(System.String)")]

namespace ProductivityFeatures
{
    // Rename now understands references to symbols within the target string of global SuppressMessageAttribute suppressions
    // Place your cursor on the class name, press Ctrl+R,R to rename the class
    // Notice how the SuppressMessageAttribute reference will now reference the newly named class
    class Update168
    {
        // Remove unnecessary pragma suppressions
        // Place your cursor on the pragma warning, press (Ctrl+.)
        // Select Remove unnecessary suppression
#pragma warning disable IDE0060 // Remove unused parameter
        public static void M(int x)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            // Now used
            Console.WriteLine(x);
        }

        public void M2() => M1();

        // Remove unnecessary SuppressMessageAttribute
        // Place your cursor on the SuppressMessageAttribute, press (Ctrl+.)
        // Select Remove unnecessary suppression
        [SuppressMessage("CodeQuality", "IDE0051:Remove unused private members")]
        int M1() => 0;

        // Remove 'in' keyword code fix
        // Where the argument should not be passed by reference
        // Uncomment the text below: RemoveInKeyword(in value);
        // Place your cursor on the error, press (Ctrl + .)
        // Select Remove 'in' keyword
        void RemoveInKeyword(int value) => throw null;

        void N(int value)
        {
            //RemoveInKeyword(in value);
        }

        // Introduce new C#9 pattern combinators
        // Along with the pattern matching suggestions such as converting ‘==’ to use ‘is’ where applicable,
        // This code fix also suggests the pattern combinators `and`, `or` and `not` when matching multiple different patterns and negating
        // This reduces complexity and makes it more clear
        // Place your cursor inside the statement, press (Ctrl+.) 
        // Select Use pattern matching
        bool IntroducePatternCombinators(string value)
        {
            return value == null
                && value == null
                || value != null;
        }

        // Extract base class
        // Lets you extract members from a selected class to a new base class
        // Place your cursor on the class name or a member, press (Ctrl+.) 
        // Select Extract base class
        public bool ExtractBaseClass(char ch)
        {
            return ch is >= 'A' and <= 'Z' or >= 'A' and <= 'Z';
        }

        // Convert typeof to nameof
        // Place your cursor within typeof(Test).Name, press (Ctrl+.)
        // Select Convert `typeof` to `nameof`
        public void ConvertTypeOf()
        {
            _ = typeof(Test).Name;
        }

        internal class Test
        {
        }

        void IntelliSenseDateTime()
        {
            string name = "Mika";
          
            var date = DateTime.Now;

            // IntelliSense completion in DateTime and TimeSpan string literals
            // Place your cursor inside the DateTime or TimeSpan string literal
            // Type an opening quotation mark to view the list of completions and a description of each character
            string today = DateTime.Now.ToString();

            // IntelliSense completion in DateTime string interpolation
            // Place your cursor inside the string interpolation next to date
            // Type colon to view the list of completions and a description of each character
            Console.WriteLine($"Hello, {name}! It's {date} now.");
        }
    }

    // Make class abstract code fix
    // When you are trying to write an abstract method in a class that is not abstract
    // Uncomment the text below: public abstract void M();
    // Place your cursor on the method error, press (Ctrl+.)
    // Select Make class ‘abstract’
    class MakeClassAbstract
    {
        //public abstract void M();
    }

    // Inline method refactoring
    // Helps you replace usages of a static, instance, and extension method within a single statement body
    // Place your cursor on the LogError method call, press (Ctrl+.)
    // Select Inline <QualifiedMethodName>
    abstract class Person
    {
        public void FirstName()
        {
            try { }
            catch (Exception e)
            {
                LogError(e);
            }
        }
        private static void LogError(Exception e)
        {
            File.WriteAllText(@"c:\Errors\Exception.txt", e.ToString());
        }
    }

    // Other features in Update 16.8:

    // Starting in .NET 5.0, Roslyn analyzers are included with the .NET SDK. Code analysis is enabled, by default, for projects that target .NET 5.0 or later.

    // There is now C# and Visual Basic support for inline parameter name hints that inserts adornments for literals, casted literals, and object instantiations prior to each argument in function calls. 

    // There is now interactive window support for multiple runtimes, such as .NET Framework and.NET Core.

    // There is a new RegisterAdditionalFileAction API that allows analyzer authors to create an analyzer for additional files.

    // Code cleanup has new configuration options that can apply formatting and file header preferences set in your EditorConfig file across a single file or an entire solution.

    // Creating a new C# or Visual Basic file from a template respects EditorConfig code style settings.
}
