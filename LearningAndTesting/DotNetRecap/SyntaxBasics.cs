namespace LearningAndTesting.DotNetRecap;

public class SyntaxBasics
{
    // Conditionals
    
    // if..else..
    
    // This Function Should return zero in case of any number given below zero
    public int SubtractHigherFromLower(int x, int y)
    {
        if (x < 0 || y < 0) // if x or y are less than zero return zero
        {
            return 0;
        }
        else if (x > y) // if x is larger than y return x - y
        {
            return x - y;
        }
        else if (y > x) // if y is larger than x return y - x
        {
            return y - x;
        }
        else // x and y are zero and above and both the same so must be zero
        {
            return 0; // Note: unnecessary
        }
    }
    
    // Short-Hand if else statement
    public string IsFirstHigherNumber(int first, int second)
    {
        return (first > second) ? "yes" : "no";
    }
    
    // switch
    public string ConvertColorCharToString(char c)
    {
        switch (c)
        {
            case 'w': return "white";
            case 'b': return "black";
            case 'g': return "green";
            case 'y': return "yellow";
            default: return "unknown";
        }
    }
    
    // foreach loop
    public string CreateStringFromCharArray(char[] chars)
    {
        string createdString = "";
        
        foreach (char c in chars)
        {
            createdString += c;
        }
        
        return createdString;
    }
}