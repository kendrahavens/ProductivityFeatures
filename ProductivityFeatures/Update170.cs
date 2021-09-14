// Copyright (c) Microsoft. All Rights Reserved.
// Licensed under the Apache License, Version 2.0.

// C# 10.0 File-scoped namespace refactoring
// Make sure the <LangVersion> in your csproj is set to preview
// Place cursor in namespace and type (Ctrl+.)
// Select Convert to file scoped namespace and
// enjoy reclaiming the indented space!
namespace ProductivityFeatures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Update170
    {
        // Refactoring to prefer null check over type check
        // Place Cursor in if statement
        // Type (Ctrl+.) and select Prefer null check over type check
        public void NullCheckOverTypeCheck(string y)
        {
            if (y is string)
            {

            }
        }

        // XML comments will now automatically generate an <exception>
        // tag when a method explicitly throws exceptions
        // Type "///" and press enter to accept the summary autocomplete
        
        
        public void M(int y)
        {
            throw new Exception();
            throw new DivideByZeroException();
        }
    }
}

// Other updates
// Navigate to decompiled sources is now on by default
// Nullable reference types is now enabled by default for new .NET projects
// Inheritance Margin is now enabled by default