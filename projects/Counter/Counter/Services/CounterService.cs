namespace Counter.Services;

public class CounterService : ICounterService
{
    public int Increment(int currentValue, int step)
    {
        return currentValue + step;
    }
}
