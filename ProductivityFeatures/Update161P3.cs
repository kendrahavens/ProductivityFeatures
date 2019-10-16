

namespace ProductivityFeatures
{
    // Prevent usings inside a namespace code style rule
    // You can now use a new editorconfig code style rule to require or prevent usings inside a namespace
    // This setting will also be exported when you use the “Generate editorconfig” button located in Tools > Options > Text Editor > C# > Code Style
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Update161P3
    {

        // Intellisense completion for unimported types
        // Receive intellisense suggestions for types in dependencies in your project even if you have not yet added the import statement to your file
        // Set string json to equal JsonConvert and when you press tab the Newtonsoft.Json using will be added to your file
        string json;

        // Toggle single line comment/uncomment is now available through the keyboard shortcut (Ctrl + K, /)
        // This command will add or remove a single line comment depending on whether your selection is already commented
        public void SingleLineComment()
        {
            Console.WriteLine("comment this line");
        }
    }
}