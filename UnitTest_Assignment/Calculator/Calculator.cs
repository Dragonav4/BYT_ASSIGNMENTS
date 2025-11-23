namespace Calculator;

public class Calculator(double a,double b, string action)
{
    public double Calculate()
    {
        return action switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => b == 0 ? throw new DivideByZeroException() : a / b,
            _ => throw new ArgumentException($"Unknown action: {action}")
        };
    }
}