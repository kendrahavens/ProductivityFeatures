using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ProductivityFeatures
{
    public class Update163P2
    {
        // Quick Info style support for XML comments
        // Place your cursor over the method name. Quick Info will then display the supported styles from the XML comments above your code
        /// <summary>
        /// <see href="https://bing.com">Bing</see>
        /// <list type="bullet">
        /// <item><description><para>Line</para></description></item>
        /// <item><description><para>Line</para></description></item>
        /// </list>
        /// </summary>
        public void GenerateParameter(string x)
        {
            x = "XML Comments";
            Console.WriteLine(x);
        }

        // Wrap chains of fluent calls refactoring
        // Place your cursor on any of the call chains and press (Ctrl + .) to select either `Wrap call chain` or `Wrap and align call chain`
        public void WrapCallChain(string[] args)
        {
            string v = args[0].GetHashCode().ToString()[1].GetTypeCode().GetHashCode().ToString();
        }

        // Introduce a local variable after writing its initializer
        // Write an expression then place your cursor on the expression name and press (Ctrl + .) and select `Introduce local variable`
        public void M()
        {
            // new DateTime()
        }

        // Intellisense imported type filter
        // Previously, we added intellisense completion for unimported types 
        // This feature came with the option to turn it off for users who did not want unimported types always populating their intellisense
        // Now, for users who turn off the completion for unimported types, it's much easier to get it back in your completion list with the new imported type filter added to the intellisense toggles
        // Uncomment `var json = json` to filter the completion list
        public void IntellisenseFilter()
        {
            //var json = json
        }
    }
}