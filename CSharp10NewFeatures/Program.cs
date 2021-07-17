﻿// C# 10 introduces a new pattern that lets you define namespace imports across an entire project using the global keyword.
// It’s recommended that you place your global imports in a separate file (one for each project), possibly named usings.cs or imports.cs.
// Check "Imports.cs" file
using CSharp10NewFeatures.Records;

Console.WriteLine("Hello C# 10");

// Constant interpolated strings
// In C# 10.0, const strings may be initialized using string interpolation if all the placeholders are themselves constant strings.
// String interpolation can create more readable constant strings as you build constant strings used in your application.
// The placeholder expressions can't be numeric constants because those constants are converted to strings at runtime.
const string version_string = "v1";
const string version_string_full = $"version_{version_string}";

// Record types can seal ToString
// In C# 10.0, you can add the sealed modifier when you override ToString in a record type.
// Sealing the ToString method prevents the compiler from synthesizing a ToString method for any derived record types.
// This ensures all derived record types use the ToString method defined in a common base record type.
// Check "Car.cs" file
Car car = new("volvo", "blue");
Console.WriteLine(car);