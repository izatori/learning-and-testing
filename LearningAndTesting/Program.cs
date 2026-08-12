// Includes

// Hello World

using LearningAndTesting.DotNetRecap;

Console.WriteLine("Hello, World!");
Console.WriteLine("");

// Fields, variables and Properties

// Create an instance of VariableTypes
var varTypes = new VariableTypes();

var retrievedProperty = varTypes.AccessibleProperty;
Console.WriteLine($"Property Value: {retrievedProperty}");

var retrievedPrivate = varTypes.GetNotAccessibleField();
Console.WriteLine($"Function-Return Value: {retrievedPrivate}");
Console.WriteLine("");

// Write all common data types
Console.WriteLine("Most common Data Types:");
foreach (string type in varTypes.GetAllDatatypes())
{
    Console.WriteLine(type);
}

