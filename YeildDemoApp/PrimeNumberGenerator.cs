namespace YeildDemoApp;

public static class PrimeNumberGenerator
{
    public static IEnumerable<long> GetPrimeNumbers()
    {
        long counter = 1;
        while (true)
        {
            if (IsPrimeNumber(counter))
                yield return counter;
            counter++;
        }
    }

    private static bool IsPrimeNumber(long number)
    {
        for (var i = 2; i < number / 2; i++)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}