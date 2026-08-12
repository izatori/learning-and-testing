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
Console.WriteLine("");

// Implicit and Explicit TypeCasting
int valueAsInteger = 5;
double valueAsDouble = 5.5;

double convertedToDouble = varTypes.CastIntToDoubleImplicit(valueAsInteger);
int convertedToInt = varTypes.CastDoubleToIntExplicit(valueAsDouble);

Console.WriteLine($"Implicit Casting integer as double:  {convertedToDouble}");
Console.WriteLine($"Explicit Casting double as integer: {convertedToInt}");

