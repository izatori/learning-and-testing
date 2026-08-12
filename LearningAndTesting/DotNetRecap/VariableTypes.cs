namespace LearningAndTesting.DotNetRecap;

public class VariableTypes
{
    // Fields, variables and properties
    private readonly int _notAccessibleField = 1; // Field --> class variable --> _camelCase
    public int AccessibleProperty { get; set; } = 2; // Property --> public class variable --> PascalCase
    // Note: { get; set; } get: necessary to retrieve val from outside, set: necessary to change val from outside
    
    public int GetNotAccessibleField()
    {
        var notAccessibleVariable = _notAccessibleField; // Variable --> camelCase
        return notAccessibleVariable;
    }

    public string[] GetAllDatatypes()
    {
        string[] dataTypes = new[]
        {
            "int (integer standard, e.g. 5)",
            "long (integer long, e.g. 5)",
            "float (floating point standard, e.g. 5.2)",
            "double (floating point large, e.g. 5.2D)",
            "char (single character, e.g. 'A')",
            "string (character string, e.g. \"Text\")",
            "bool (boolean, e.g. false)"
        };
        return dataTypes;
    }
    
    // Type casting implicit and explicit
    
    public double CastIntToDoubleImplicit(int valueToCast)
    {
        return valueToCast;
    }
    
    public int CastDoubleToIntExplicit(double valueToCast)
    {
        return (int) valueToCast;
    }
}