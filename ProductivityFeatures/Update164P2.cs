namespace ProductivityFeatures
{
    public class Update164P2
    {

        string LocalFunctionStatic() 
        {
            string s = "static local function";
            int x = 1;

            // You can now make a local function static and pass in variables defined
            // outside the function to the function’s declaration and calls
            // Place your cursor on the local function name `MakeStatic`
            // Press (Ctrl + .) and select Make local function `static`
            int MakeStatic()
            {
                int x = 1;
                return x += 1;
            }

            // Pass a variable explicitly into a local static function
            // Uncomment 'x +=' below ot cause an error.
            // Place your cursor on the variable name `x` in the static local function
            // Press (Ctrl + .) and select `Pass variable explicitly in local static function`
            static int AddLocal()
            {
                return /*x +=*/ 1;    
                
            }

            return s;
        }
    }
}