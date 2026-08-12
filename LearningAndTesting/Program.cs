// Includes

// Hello World

using LearningAndTesting.DotNetRecap;

Console.WriteLine("Hello, World!");

// Create an instance of DotNetBasics
var basics = new DotNetBasics();

// Fields, variables and Properties
var retrievedProperty = basics.AccessibleProperty;
Console.WriteLine($"Property Value: {retrievedProperty}");

var retrievedPrivate = basics.GetNotAccessibleField();
Console.WriteLine($"Function-Return Value: {retrievedPrivate}");

