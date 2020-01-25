using System;

namespace ProductivityFeatures
{
    // https://docs.microsoft.com/en-us/visualstudio/productinfo/vs-roadmap
    // for release notes
    class Update165P2
    {
        public static void ExtractLocal()
        {
            var s = "";

            // Select all += lines and extract local function
            // using the lightbulb (ctrl + .)
            s += "Hello";
            s += "Extract";
            s += "Local";
            s += "Function";

            Console.WriteLine(s);
        }

        // Make this method static using the lightbulb after 
        // putting cursor on name. Works in static classes
        public void MakeStatic()
        {

        }

        public static void SimplifyInterpolation(int i)
        {
            // Interpolated strings have a simplified notation
            // for common cases, including padding. Interpolation
            // simplification is a configurable diagnostic with
            // a code fix.
            var s = $"... {i.ToString("bar").PadLeft(3)} ...";
            Console.WriteLine(s);
        }

        public static void ShowCompletionForUnimportedTypes()
        {
            // Type "Task" below and show completion.
            // Feature now enabled by default

            // Also works for extension methods.
            // Type double quotes for empty string "" 
            // and try to invoke .All by typing 
            // ".A", completion should show All from
            // System.Linq
        }

        public static string ConvertIfToSwitchStatementOrExpression(int i)
        {
            // Put cursor on if and invoke lightbulb (ctrl + .)
            // to convert to switch expression or switch statement
            if (i == 0)
            {
                return "0";
            }
            else if (i == 1)
            {
                return "1";
            }
            else if (i == 2)
            {
                return "2";
            }
            else if (i == 3)
            {
                return "3";
            }
            else if (i == 4)
            {
                return "4";
            }
            else if (i == 5)
            {
                return "5";
            }
            else if (i == 6)
            {
                return "6";
            }
            else if (i == 7)
            {
                return "7";
            }
            else if (i == 8)
            {
                return "8";
            }
            else if (i == 9)
            {
                return "9";
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        // NuGet packages for refactorings, previously only VSIX 

        // Editorconfig now supports the below for marking generated code
        // generated_code = true
    }
}
