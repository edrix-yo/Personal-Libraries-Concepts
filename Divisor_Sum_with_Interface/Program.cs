
process divisor = new process();
int resultOfDivisor = divisor.divisorSum(10);

Console.WriteLine(resultOfDivisor);

Console.WriteLine();




public interface AdvancedArithmetic
{
    int divisorSum(int n);
}

public class process : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        int result = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                result += i;
            }
        }

        return result;
    }
}