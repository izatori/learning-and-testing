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
}