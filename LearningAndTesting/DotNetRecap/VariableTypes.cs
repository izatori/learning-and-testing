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
}