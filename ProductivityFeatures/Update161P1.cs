using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProductivityFeatures
{
    class Update161P1
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
            if (1 < 3 || 2 > 4 && true || 1 > 0 || false && 1 == 1){}
        }

        // Find All References 'Kind' column values for Namespaces and Types
        // Select the 'foo' field and type (Shift + F12) to open Find All References window
        // Scroll right to view the "Kind" column
        // Click on the filter on the column header to view new namespace and type awareness
        public void AdditionsToKindColumninFindAllReferences()
        {
            Update160P2 fooType = new Update160P2();
            fooType.foo = 0;
        }
    }

    // Code fix to unseal a class
    // Uncomment the MyClass declaration
    // Place cursor in InternalClass
    // Type (Ctrl + .) to open quick fixes and refactorings menu
    internal sealed class InternalClass { }
    //class MyClass : InternalClass { }

}
