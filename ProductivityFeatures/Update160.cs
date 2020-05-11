using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProductivityFeatures
{
    class Update160
    {
        // IntelliCode provides AI-assisted development in intellisense completion, 
        // refactorings, team-based completions and more. (See http://aka.ms/intellicode for latest features)
        // IntelliCode was an extension in Visual Studio 2017 and is built 
        // into Visual Studio 2019 and enabled by default.
        public string IntelliCode()
        {
            string a = "";
            // Uncomment the line below and place your cursor after "a."
            // Type Ctrl+space to open the intellisense call completion list.
            // Note that the first suggestions are no longer an alphabetical list,
            // but have ⭐ or "starred" suggestions. This star means the suggestions
            // have used AI to learn from your current coding context.

            //var b = a.

            // Note that Intellicode adapts to new code contexts.
            // Uncomment the variable declaration below and place your cursor after "a."
            // Type Ctrl+space to open the intellisense call completion list.
            // Now that a char array is expected the top intellisense completion is ToCharArray

            //char[] c = a.

            // IntelliCode can also recognize local code patterns.
            // Uncomment the variable declaration below and place your cursor after "a."
            // Type Ctrl+space to open the intellisense call completion list.
            // Since the lines direclty above a call repeat a pattern, IntelliCode
            // will suggest ToLower as the first call completion instead of Length.
            var d = a.ToLower();
            var e = a.ToLower();
            // var f = a.

            // IntelliCode can offer better completions on not only calls,
            // but arguments and parameters as well.
            // Is it also not limited to primitive types, 
            // but can even train to offer suggestions on your own code base.

            return a;
        }

        // IntelliCode can also provide automatically generated 
        // refactorings based off of the repeated edits that the user makes.
        // Suggested Edits can be turned on in 
        // Tools > Options > IntelliCode > Preview Fetaures > C# refactorings
        public void IntelliCodeRepeatedEditsRefactoring()
        {
            // Add .ToUpper() after all of the strings.
            // After the first 2 or 3 changes IntelliCode can pick up on what repeated edits
            // you are making and offer a codefix to complete them
            Console.WriteLine("hello");
            Console.WriteLine("goodbye");
            Console.WriteLine("hi");
            Console.WriteLine("so long");
            Console.WriteLine("greetings");

        }

        public void RegexParsingSupport()
        {
            // Classification and Brace/Reference Matching 
            // Place cursor in a parenthesis or bracket below to see the highlighted matching
            Match match = new Regex(@"(A|[B]|C)Test\1").Match("ATestC");

            // Parser recovery enables multiple diagnostics and classification despite errors.
            // Delete a parenthesis in the Regex below to view the parenthesis warning.
            Regex removeDuplicates =
                new Regex(@"(?<=,|^)(?'word'[^,]*)(,\'word')+(?=,|$)");

            // Enabled for specifically commented strings 
            // Delete the extra "r" in "rregex" in the comment below this line to get regex support.
            // language=rregex,ExplicitCapture
            const string xmlTagMatcher = @"<([A-Z][A-Z0-9]*)\b[^>]*>(.*?)</1>";
            UseMatcher(xmlTagMatcher);
        }
        public void UseMatcher(string xmlTagMatcher) => throw new NotImplementedException();

        // Place cursor in foreach keyword and type (Ctrl + .)
        // Select 'Convert to Linq' to convert to a query
        public void ForeachLoopToLinqQuery()
        {
            var greetings = new List<string>()
                { "hi", "yo", "hello", "howdy" };

            IEnumerable<string> enumerable()
            {
                foreach (var greet in greetings)
                {
                    if (greet.Length < 3)
                    {
                        yield return greet;
                    }
                }

                yield break;
            }

            var shortGreeting = enumerable();
        }

        // Place cursor in foreach keyword and type (Ctrl + .)
        // Select 'Convert to Linq(call form)' to convert to a method
        public void ForeachLoopToLinqMethod()
        {
            var greetings = new List<string>()
                { "hi", "yo", "hello", "howdy" };

            IEnumerable<string> enumerable()
            {
                foreach (var greet in greetings)
                {
                    if (greet.Length < 3)
                    {
                        yield return greet;
                    }
                }

                yield break;
            }

            var shortGreeting = enumerable();
        }

        // A codefix for adding the needed "using" will appear on copy/pasted code
        // Uncomment the text into the method below: string json = JsonConvert.SerializeObject(greetings);
        // With your cursor in "JsonConvert" type (Ctrl + .)
        // Select to add the Using Newtonsoft.Json
        public void UsingRefAddedCopyPaste()
        {
            //string json = JsonConvert.SerializeObject("some json");
        }

        // Place cursor before the opening parenthesis in (3, "string");
        // Type (Ctrl + .)
        // Select Convert to struct
        public void ConvertTupleToNamedStruct()
        {
            var tuple = (3, "string");

            Console.WriteLine(tuple.Item2);
        }

        // Dead code analysis has improved to more accurately detect and remove unused code.
        // Place your cursor in the method name below and type (Ctrl + .)
        // Select remove unused member and it will delete the entire method and comment
        private void DeadCodeAnalysOnPrivateMembers()
        {
            Console.WriteLine("Never run.");
        }

        // Place cursor in the GetNumberAsync() in var x declaration.
        // Type (Ctrl + .) and select Add await.
        public async Task ForgotImpliedAwaitAsync()
        {
            var x = GetNumberAsync();

            await GetNumberAsync();
        }
        private Task<object> GetNumberAsync()
        {
            throw new NotImplementedException();
        }

        // Place cursor in local HelloWorld method.
        // Type (Ctrl + .) and select Convert to method
        public void ConvertLocalFunctionToMethod()
        {
            string HelloWorld()
            {
                return "HelloWorld!";
            }
            Console.WriteLine(HelloWorld());
        }

        // Uncomment the text in the method below to cause an error.
        // To fix the error in the method below
        // Place your cursor in MyInternalClass and Type (Ctrl + .) 
        // Select Generate method MyInternalClass.Deconstruct.
        public void GenerateDeconstructMethod()
        {
            //(int x, int y) = new MyInternalClass();
        }
        private class MyInternalClass
        {
            public MyInternalClass()
            {
            }
        }

        // Place cursor in new and type (Ctrl + .)
        // Select Convert to tuple
        public void ConvertAnonymousTypetoTuple()
        {
            var myTuple = new { a = 1, b = 2 };
            var t2 = (3, "string");

            Console.WriteLine(t2.Item2, myTuple);
        }

        // Place cursor in 'new' keyword and type (Ctrl + .)
        // Select Convert to class
        public void ConvertAnonymousTypetoClass()
        {
            var myClass = new { str = "Hi" };

            Console.WriteLine(myClass.str);
        }

        // 16.0 Preview 1 features not included in this demo project
        #region
        //public void FindAllReferenceCodeLensRazorSupport() { }

        //public void ExportSettingstoEditorconfig() { }

        //public void CodeMetricsNETCore() { }
        #endregion

        // First thing you may notice are new colors according to Roslyn classification.
        // These colors are similar to the very popular Visual Studio Code colors.
        // You can opt in/out of these new colors in Tools > Options > Environment > Preview Features 
        // with the checkbox "Use enhanced colors for C#".
        // As always, any feedback is appreciated!
        public void NewColors(Update160 parameterNewColor)
        {
            int localVariableNewColor = 100;

            // for keyword has new color
            for (int i = 0; i < 10; i++)
            {
                localVariableNewColor--;
                parameterNewColor--; // Overloaded operators get slightly different coloring too!
            }
        }
        public static Update160 operator --(Update160 x)
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
            string y = nameof(foo);

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
            int x = 1;
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
// Select 'Pull members up to base type'
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

        // You can pull up properties as well.
        // Place your cursor in PullUpString and type (Ctrl + .)
        // Select 'Pull members up to base type'
        public string PullUpString { get; set; }
    }

}
