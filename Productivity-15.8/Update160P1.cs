using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProductivityFeatures
{
    public class Update160P1
    {

        public void RegexParsingSupport()
        {
            // 1. Classification and Brace/Reference Matching 
            Match match = new Regex(@"(A|[B]|C)Test\1").Match("ATestC");

            //2. Parser recovery enables multiple diagnostics and classification despite errors 
            Regex removeDuplicates =
                new Regex(@"(?<=,|^)(?'word'[^,]*)(,\'word')+(?=,|$)");

            //3. Enabled for specifically commented strings 
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
                foreach(var greet in greetings)
                {
                    if(greet.Length < 3)
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
                foreach(var greet in greetings)
                {
                    if(greet.Length < 3)
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
            //object c = null;
            var myTuple = new { a = 1, b = 2 };
            var t2 = (3, "string");

            Console.WriteLine(t2.Item2);
        }

        // Place cursor in 'new' keyword and type (Ctrl + .)
        // Select Convert to class
        public void ConvertAnonymousTypetoClass()
        {
            var myClass = new { str = "Hi" };

            Console.WriteLine(myClass.str);
        }

        // TBD demo
        #region
        //public void FindAllReferenceCodeLensRazorSupport() { }

        //public void ExportSettingstoEditorconfig() { }

        //public void BreakBuildOnFormattingIssue() { }

        //public void CodeMetricsNETCore() { }
        #endregion
    }
}
