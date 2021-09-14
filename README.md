# Visual Studio recent productivity features

## Summary
This repo contains a simple console app that demonstrates several codefixes and refactorings in recent Visual Studio versions.

- Clone the repo and follow the comments in the code.
- Check out the [Visual Studio Productivity guide](https://aka.ms/productivityguide) for more features!

## Features included in tutorial

### Features added in Visual Studio 2022 update 17.0
- C# 10.0 File-scoped namespace refactoring
- Refactoring to prefer null check over type check
- XML comments will now automatically generate an \<exception\> tag when a method explicitly throws exceptions
- Navigate to decompiled sources is now on by default
- Nullable reference types is now enabled by default for new .NET projects
- Inheritance Margin is now enabled by default

### Features added in Visual Studio 2019 update 16.10
- Remove unused references
- EditorConfig UI
- Visually inspect and navigate the inheritance chain with inheritance margins
- Argument completion in method calls
- Smart Break Line for all type declarations that require braces as well as properties, events, fields, and object creation expressions.
- Simplify LINQ expression refactoring
- Code style preference for new lines
- IntelliSense completion for casts, indexers, and operators
- Debugger support for Source Generators
- Find All References support for Source Generators
- IntelliSense completion for Enum values

### Features added in Visual Studio 2019 update 16.9
- Automatically add using directives when copying and pasting from a file
- Preprocessor symbols now have IntelliSense completion
- Diagnostic tooltip for pragma warnings or numbers for suppressions
- Use 'new()' in non-contentious scenarios refactoring
- Remove redundant equality code fix
- Convert a regular string and a verbatim string to an interpolated string
- Remove unnecessary discard code fix
- Semantic colorization for C# 9.0 record types
- Comment out new line when return is pressed while cursor is within a comment
- Inline type hints for variables with inferred types and lambda parameter types
- IntelliSense completion that automatically inserts a semicolon as a commit character
- The .NET Code Style (IDE) analyzers can now be enforced on build via project properties
- Go To All will not display duplicate results across netcoreapp3.1 and netcoreapp2.0 as well as results for partial types that exist only to wrap another nested type
- Solution Explorer now displays the new .NET 5.0 Source Generators underneath the Analyzer node so you can easily navigate and view the generated code

### Features added in Visual Studio 2019 update 16.8
- Remove unnecessary pragma suppressions and SuppressMessageAttribute (Ctrl + .)
- Remove 'in' keyword code fix (Ctrl + .)
- Introduces new C#9 pattern combinators (Ctrl + .)
- Make class abstract code fix (Ctrl + .)
- Interactive window support for multiple runtimes, such as .NET Framework and.NET Core
- New RegisterAdditionalFileAction API that allows analyzer authors to create an analyzer for additional files
- Rename and Find All References now understands references to symbols within the target string of global SuppressMessageAttribute suppressions (Ctrl + R, R) (Shift + F12)

### Features added in Visual Studio 2019 update 16.7
- Add debugger display attribute code fix (Ctrl + .)
- Generate comparison operators for types that implement IComparable (Ctrl + .)
- Generate Equals(object) will generate IEquatable, equals, and not equals operators (Ctrl + .)
- Create and assign properties or fields for all unused constructor parameters (Ctrl + .)
- Code fix for accidental assignments or comparisons to the same variable (Ctrl + .)
- IntelliSense completion in DateTime and TimeSpan string literals (Ctrl + Space)
- Add parameter in Change Signature dialog (Ctrl + .)
- Warning and code fix when a suppression operator is present but has no effect (Ctrl + .)
- Generate properties when generating a constructor (Ctrl + .)

### Features added in Visual Studio 2019 update 16.6
- Add explicit cast (Ctrl + .)
- Convert between regular and verbatim string literals (Ctrl + .)
- Simplify conditional expressions (Ctrl + .)
- Quick info XML style support that contain returns and value tags  (Hover over type to see quick info)
- Add file header (Ctrl + .)
=======

### Features added in Visual Studio 2019 update 16.5
- Extract local function (Ctrl + .)
- Simplify interpolated string (Ctrl + .)
- Completion for unimported types and extension methods (Ctrl + space)
- Convert if statement to switch statement or expression (Ctrl + .)
- Make method static (Ctrl + .)

### Features added in Visual Studio 2019 update 16.4
- Configure severity level of a code style rule directly through the editor
- Add null checks for all parameters
- Go to Base (Alt + Home)
- Make a local function static (Ctrl + .)
- Pass variable explicitly in local static function (Ctrl + .)

### Features added in Visual Studio 2019 update 16.3
- Rename a file when renaming a class, interface, or enum (Ctrl + R, R)

### Features added in Visual Studio 2019 update 16.2
- Convert switch statement to switch expresssion (Ctrl + .)
- Generate parameter (Ctrl + .)

### Features added in Visual Studio 2019 update 16.1
- Move Type to Namespace (Ctrl + .)
- Run code cleanup on solution/projects from Solution Explorer (Right-click)
- Toggle block comments (Ctrl + Shift + /)
- Initialize a private field from constructor and vice versa (Ctrl + .)
- Make readonly struct fields writable (Ctrl + .)
- Split/Merge nested if statements (Ctrl + .)
- Regex Completion (Ctrl + space)
- Wrap binary expressions (Ctrl + .)
- Find All References 'Kind' column values for Namespaces and Types
- Code fix to unseal a class (Ctrl + .)

### Features added in Visual Studio 2019 update 16.0
- IntelliCode smart completions enabled by default
- IntelliCode repeated edits refactorings (in preview)
- New Roslyn classification colorization!
- Wrap, indent, align parameters (Ctrl + .)
- Use expression/block body for lambda (Ctrl + .)
- Invert conditional expressions and logical operations (Ctrl + .)
- Convert to compound assignment (Ctrl + .)
- Implicitly-typed variables cannot be constant code fix (Ctrl + .)
- Replace `@$"` with `$@"` when typing interpolated verbatim string (automatic)
- Categorize references by Read/Write in Find All References window (Shift + F12)
- Automatically close block comment on "/" (automatic)
- Open a csproj by double-clicking on a project in solution explorer (.NET Core only)
- Fix for identified unused expression values and parameters (Ctrl + .)
- Allow Extract Interface to remain in same file (Ctrl R, Ctrl I)
- Pull members up refactoring with dialog options (Ctrl + .)
- Regex parsing support
- Foreach to LINQ query (Ctrl + .)
- Foreach to LINQ method/call form (Ctrl + .)
- Add missing usings on copy paste (Ctrl + .)
- Dead code analysis for unused private members (Ctrl + .)
- Add implied await code fix (Ctrl + .)
- Convert local function to method (Ctrl + .)
- Generate deconstructor (Ctrl + .)
- Convert anonymous type to tuple (Ctrl + .)
- Convert anonymous type to class (Ctrl + .)

### Features added in Visual Studio 2017 update 15.8
- Format Document (Ctrl + k, d)
- Code clean-up (Ctrl + k, Ctrl + e)
- Invert if (Ctrl + .)
- Multi-caret (Ctrl + alt + click)
- Convert to conditional expression (Ctrl + .)
- Add parameter at callsite (Ctrl + .)
- Erase extra parenthesis (Ctrl + .)
- For loop to foreach (Ctrl + .)
- Linq to ForEach (Ctrl + .)
- Navigate to Enclosing Block (Shift + Alt + \[)
- Go to All Recent Files (Ctrl + t, r)

