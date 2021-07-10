// C# 10 introduces a new pattern that lets you define namespace imports across an entire project using the global keyword.
// It’s recommended that you place your global imports in a separate file (one for each project), possibly named usings.cs or imports.cs.
// Check "Imports.cs" file
global using System;

Console.WriteLine("Hello World!");