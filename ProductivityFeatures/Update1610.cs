// Copyright (c) Microsoft. All Rights Reserved.
// Licensed under the Apache License, Version 2.0.

namespace ProductivityFeatures
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;

    class Update1610
    {
        // Remove Unused References
        // Open the Solution Explorer and right click on the project to 'Remove unused references'
        // This feature removes packages that aren't being used anywhere in your code.
        // Select "Keep" for the Newtonsoft.Json reference and "Remove" the Humanizer package

        // Argument completion in method calls
        // Uncomment the FindAreaOfRectangle method and type the first parenthesis
        // Note that argument completion suggests variables in your local scope!
        // Type Tab Tab to accept the suggestion
        public void ArgumentCompletion()
        {
            int a = 0;
            int b = 0;

            //FindAreaOfRectangle
        }
        public int FindAreaOfRectangle(int x, int y) => x * x;

        // Smart Break Line
        // Smart Break Line automatically inserts a set of braces and places the
        // caret within those braces when using Shift+Enter as a commit character.
        // Smart Breal Line works for all type declarations that require braces as well as
        // properties, events, fields, and object creation expressions.
        // Place your cursor at the end of the line and delete the semicolon.
        // Type Shift+Enter
        // Note the curly braces are inserted.
        // Now type Shift+Enter again to go back to a field with a semicolon inserted at the end.

        public string PropertyOrField;

        // Simplify LINQ expression refactoring
        // Place cursor in Linq expression
        // Select Simplify Linq Expression
        public void SimplifyLinqExpression()
        {
            List<string> list = new List<string>();
            if (list.Where(x => x != null).Any())
            {

            }
        }

        // Code style preference for new lines
        // Note the extra blank lines below have a suggestion to remove them
        // You can adjust the severity of this from within the lightbulb menu




        // IntelliSense completion for casts, indexers, and operators
        public void IntellisenseCompletionIndexers()
        {
            var w = new Weight(1, 3);
            // Type "w." to see the overloaded operators appear in intellisense
            //w
        }
    }

    public struct Weight
    {
        public int this[int i] => throw new NotImplementedException();
        public Weight(int numerator, int denominator) => throw new NotImplementedException();
        public static Weight operator +(Weight a) => throw new NotImplementedException();
        public static Weight operator -(Weight a) => throw new NotImplementedException();
        public static Weight operator +(Weight a, Weight b) => throw new NotImplementedException();
        public static Weight operator -(Weight a, Weight b) => throw new NotImplementedException();
        public static Weight operator *(Weight a, Weight b) => throw new NotImplementedException();
        public static Weight operator /(Weight a, Weight b) => throw new NotImplementedException();
        public static Weight operator ==(Weight a, Weight b) => throw new NotImplementedException();
        public static Weight operator !=(Weight a, Weight b) => throw new NotImplementedException();
        public static explicit operator int(Weight b) => throw new NotImplementedException();
        public static explicit operator float(Weight b) => throw new NotImplementedException();
        public override string ToString() => throw new NotImplementedException();
        public override bool Equals(object obj) => throw new NotImplementedException();
        public override int GetHashCode() => throw new NotImplementedException();
    }
}

// EditorConfig UI
// Open the new Editorconfig UI by clicking on the editorconfig file
// in the Solution Explorer. The editorconfig UI enables you to explore rules
// based on categories, shows possible values for each option, and enables searching!

// Visually inspect and navigate the inheritance chain
// Tools > Options > Text Editor > C# > Advanced and select Show inheritance margin
// Note the icons that now appear in the margin
// They are clickable for easy navigation up and down the inheritance chain
public class A { }
public class B : A { }
public class C : B { }

// Other features in 16.10

// Debugger support for Source Generators
// Find All References support for Source Generators
// IntelliSense completion for Enum values
