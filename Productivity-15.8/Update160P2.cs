using System;

namespace ProductivityFeatures
{
    class Update160P2
    {
        // First thing you may notice are new colors according to Roslyn classification.
        // These colors are similar to the very popular Visual Studio Code colors.
        // You can opt in/out of these new colors in Tools > Options > Environment > Preview Features 
        // with the checkbox "Use enhanced colors for C#".
        // As always, any feedback is appreciated!

        // This codefix will wrap/indent/align lists of parameters/arguments
        // Place cursor in a parameter and type (Ctrl + .)
        // There are several wrapping options provided
        // Select the option to wrap every individual parameter to the same column
        public void WrapIndentAlignParameters(int a, int b, int c, int d, string e, string f, string g, string h, DateTime i, DateTime j, DateTime k)
        { }

        // Convert anonymous type to tuple
        // Place cursor in "anonymousType" below and type (Ctrl +.)
        // Select convert to tuple
        public void ConvertAnonymousTypeToTuple()
        {
            var anonymousType = new { Number = 108, String = "Hello" };
        }

        // Use expression/block body for lambda
        // Place cursor after "=>" and type (Ctrl + .)
        // Select use block body for lambda expressions
        public void UseExpressionBlockBodyForLambda()
        {
            del myDelegate = x => x * x;
            int j = myDelegate(5); //j = 25 
        }
        delegate int del(int i);

        // Invert conditional expressions and logical operations
        // Place your cursor in "true"
        // Type (Ctrl + .) and select invert conditional.
        public int InvertConditionalExpressionsAndLogicalOperations()
        {
            int zeroIfTrue = true ? 0 : 1;
            return zeroIfTrue;
        }

        // Convert to compound assignment
        // Place cursor in "10" and type (Ctrl + .)
        // Select use compound assignment
        public void ConvertToCompoundAssignment()
        {
            int x = 1;
            x = x + 10;
        }

        // Fix Implicitly-typed variables cannot be constant
        // Uncomment the const line to cause an error
        // Place cursor in "var" and type (Ctrl + .)
        // Select use explicit type instead of var
        public void ImplicitlyTypedVariablesCannotBeConstant()
        {
            //const var v = "";
        }

        //Command handler to replace `@$"` with `$@"` when typing interpolated verbatim string
        // When you type an interpolated string it's easy to type the '$@' out of order.
        // This command fixes it as you type.
        // Try typing "string myString = @$" below and watch the fix apply automatically!
        public void CorrectTypingInterpolatedVerbatimString()
        {
            int x = 7;
            string myInterpolatedString = $@"This is my favorite number: {x}";
        }

        // Categorize references by Read/Write
        // Select f and hit (Shift + F12) to open Find All References window
        // Notice the new "Kind" column that lists different categories of references
        public int foo;
        /// <summary>
        /// <see cref="foo">
        /// </summary>
        public void WriteToF()
        {
            Console.WriteLine(foo);
            foo = 1;
            foo += 1;
            var y = nameof(foo);

            OutF(out foo);
            RefF(ref foo);
            InF(in foo);

        }
        private static void OutF(out int b) { b = 0; }
        private static void RefF(ref int a) { a = 0; }
        private static void InF(in int a) { }

        // TBD demo
        #region
        // Support for ??= compound operator to the UseCompound fix

        // Add Editorconfig when_multiline option for csharp_prefer_braces

        // Automatically close block comment on “/”
        /*
         * Typed some text and then pressed enter...
         */

        //Sync Namespace and Folder Name

        //Convert to C# 8.0 index and range operator
        // Must initialize with .NET Core 3.0 SDK
        //void IndexAndRangeOperator()
        //{
        //    string[] names =
        //    {
        //        "Archimedes", "Pythagoras", "Euclid", "Socrates", "Plato"
        //    };
        //    foreach(var name in names[1..^1])
        //    {

        //    }

        //}

        // Completion for `#nullable enable|disable`
        // Must have C# 8 installed with .NET Core 3.0 SDK
        //#nullable 
        #endregion


        //Fix for identify unused expression values and parameters
        // Place cursor in by "x" (Doesn't trigger)
        public string UnusedParameter(string x)
        {
            return "x";
        }

    }

    // Allow Extract Interface to remain in same file
    // Place cursor in class name and type (Ctrl R, Ctrl I)
    // In the dialog select destination as "Add to current file"
    public class ExtractInterfaceToSameFile
    {
        public bool A() => false;
        public string B() => String.Empty;
    }

}

// Pull members up refactoring with dialog options
// A dialog will appear to pull the Method up into the interface
// Place your cursor in PullUpMethod and type (Ctrl + .)
namespace PushUpTest
{
    public interface MyInterface
    {
    }
    public class MyClass : MyInterface
    {
        public void PullUpMethod()
        {
            System.Console.WriteLine("Hello World");
        }

        // You can pull up members as well.
        // Place your cursor in pullUpString and type (Ctrl + .)
        public string pullUpString;
    }
}

