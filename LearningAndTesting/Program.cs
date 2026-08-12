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
Console.WriteLine();

// Syntax Basics
var syntax = new SyntaxBasics();

// if..else..
Console.WriteLine($"5, 12: {syntax.SubtractHigherFromLower(5, 12)}");
Console.WriteLine($"5, -2: {syntax.SubtractHigherFromLower(5, -2)}");
Console.WriteLine($"15, 12: {syntax.SubtractHigherFromLower(15, 12)}");
Console.WriteLine();

Console.WriteLine($"52 > 51? --> {syntax.IsFirstHigherNumber(52, 51)}");
Console.WriteLine($"22 > 51? --> {syntax.IsFirstHigherNumber(22, 51)}");
Console.WriteLine($"10 > 10? --> {syntax.IsFirstHigherNumber(10, 10)}");
Console.WriteLine();

// switch
Console.WriteLine($"'g' --> {syntax.ConvertColorCharToString('g')}");
Console.WriteLine($"'w' --> {syntax.ConvertColorCharToString('w')}");
Console.WriteLine($"'b' --> {syntax.ConvertColorCharToString('b')}");
Console.WriteLine($"'m' --> {syntax.ConvertColorCharToString('m')}");
Console.WriteLine();

// for-each
char[] testArray = new []{'t', 'e', 's', 't'};
Console.WriteLine($"t, e, s, t --> {syntax.CreateStringFromCharArray(testArray)}");