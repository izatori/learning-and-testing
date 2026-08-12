// Includes

// Hello World

using LearningAndTesting.DotNetRecap;

Console.WriteLine("Hello, World!");

// Create an instance of VariableTypes
var varTypes = new VariableTypes();

// Fields, variables and Properties
var retrievedProperty = varTypes.AccessibleProperty;
Console.WriteLine($"Property Value: {retrievedProperty}");

var retrievedPrivate = varTypes.GetNotAccessibleField();
Console.WriteLine($"Function-Return Value: {retrievedPrivate}");

