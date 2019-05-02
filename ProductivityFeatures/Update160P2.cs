using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProductivityFeatures
{
    class Update160P2
    {
        // First thing you may notice are new colors according to Roslyn classification.
        // These colors are similar to the very popular Visual Studio Code colors.
        // You can opt in/out of these new colors in Tools > Options > Environment > Preview Features 
        // with the checkbox "Use enhanced colors for C#".
        // As always, any feedback is appreciated!
        public void NewColors(Update160P2 parameterNewColor)
        {
            var localVariableNewColor = 100;

            // for keyword has new color
            for (int i = 0; i < 10; i++)
            {
                localVariableNewColor--;
                parameterNewColor--; // Overloaded operators get slightly different coloring too!
            }
        }
        public static Update160P2 operator --(Update160P2 x)
        {
            return x;
        }

        // This codefix will wrap/indent/align lists of parameters/arguments
        // Place cursor in a parameter and type (Ctrl + .)
        // There are several wrapping options provided
        // Select the option to wrap every individual parameter to the same column
        public void WrapIndentAlignParameters(int a, int b, int c, int d, string e, string f, string g, string h, DateTime i, DateTime j, DateTime k)
        { }

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

            Console.WriteLine(x);
        }

        // Fix Implicitly-typed variables cannot be constant
        // Uncomment the const line to cause an error
        // Place cursor in "var" and type (Ctrl + .)
        // Select use explicit type instead of var
        public void ImplicitlyTypedVariablesCannotBeConstant()
        {
            //const var v = "";
        }

        // Replace `@$"` with `$@"` when typing interpolated verbatim string
        // When you type an interpolated string it's easy to type the '$@' out of order.
        // This command fixes it as you type.
        // Try typing "string myString = @$" below and watch the fix apply automatically!
        public void CorrectTypingInterpolatedVerbatimString()
        {
            int x = 7;
            string myInterpolatedString = $@"This is my favorite number: {x}";
        }

        // Categorize references by Read/Write
        // Select foo and type (Shift + F12) to open Find All References window
        // Notice the new "Kind" column that lists different categories of references
        public int foo;
        /// <summary>
        /// <see cref="foo">
        /// </summary>
        public void WriteToFoo()
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

        // Automatically close block comment on "/"
        // Typing "/" after "* " in a multi-line comment used to not end 
        // the comment because of the space between "*" and "/".
        // Now when typing "/" the space is automatically deleted so that it ends your comment block.
        public void AutoCloseMultiLineComment()
        {
            ///*
            // * Uncomment this block and type "/" after the "* " below to end the comment block
            // * 
        }

        // You can now open a csproj by double-clicking on a project in solution explorer
        // File names listed in a csproj can also now show up in (Ctrl + t) navigation.
        // Type (Ctrl + t) and search "csproj"
        public void OpenCSprojWithDoubleClick() { }

        // Fix for identified unused expression values and parameters
        // Place cursor in by "x" to read the diagnostic. (no codefix)
        // Place cursor in x1 and type (Ctrl + .) to remove the unused variable.
        public string UnusedParameter(string x)
        {
            string x1 = "x";
            return "x";
        }

        // Place cursor in "x" and type (Ctrl + .)
        // Select "Remove redundant assignment" to eliminate the unused value assignment
        public int UnusedValueAssigmentAndUnusedParameterDiagnostic(string s)
        {
            int x  = 1;
            x = 2;
            return x;
        }

        // 16.0 Preview 2 features not included in this demo project
        #region

        // Add Editorconfig when_multiline option for csharp_prefer_braces

        //Sync Namespace and Folder Name

        // Completion for `#nullable enable|disable`

        #endregion
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
namespace PullUp
{
    public interface IMyInterface
    {

    }
    public class MyClass : IMyInterface
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

