namespace Counter.Services;

public interface ICounterService
{
    int Increment(int currentValue, int step);
}
