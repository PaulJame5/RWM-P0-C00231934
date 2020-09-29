
public class FactorialFilter
{
   public static int Factorial(int number)
    {
        if(number < 0)
        {
            return -1;
        }

        if(number == 0)
        {
            return 1;
        }

        int result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }

    public static int[] Factorials(int[] numbers)
    {
        int[] result = new int[numbers.Length];

        for(int i = 0; i < numbers.Length; i++)
        {
            result[i] = Factorial(numbers[i]);
        }
        return result;
    }
}
