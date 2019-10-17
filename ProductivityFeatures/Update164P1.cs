namespace ProductivityFeatures
{
    public class Update164P1
    {
        // Configure severity level of a code style rule directly through the editor
        // Place your cursor on the error, warning, or suggestion
        // Type (Ctrl + .) and select `Configure or Suppress issues`
        // Then select the rule and choose the severity level you would like to configure for that rule
        // This will update your existing EditorConfig with the rule's new severity
        // This also works for third party analyzers!
        public void M()
        {
            var v = string.Empty;
        }

        // Add null checks for all parameters
        // Place your cursor on any parameter within the mehtod
        // Press (Ctrl + .) and select the option to `Add null checks for all parameters`
        public void AddNullChecks(string a, string b, string c)
        {
            
        }
    }

    // Go To Base command
    // You can now use the Go To Base command to navigate up the inheritance chain.
    // Go To Base command is available on the context (right-click) menu of the element
    // you want to navigate the inheritance hierarchy or 
    // type the keyboard shortcut (Alt + Home)
    // Place your cursor on class D and press (Alt + Home)
    // If there is more than one result a tool window will open with all of the results
    internal interface I
    {
    }

    class C : I
    {
        // Methods that have no XML documentation can now automatically inherit 
        // XML documentation from the method it is overriding
        // Place your cursor over the undocumented method that implements a documented interface method
        // Quick Info will then display the XML documentation from the interface method
        /// <summary>
        /// This method does something
        /// </summary>
        public virtual void Method()
        {
            
        }

        class D : C, I
        {
            public override void Method() // Hover over `Method` to view inherited quick info
            {
            }
        }
    }
}