namespace Polly.RetryManager
{
    public enum WaitStrategy
    {
        MinimalWait,
        ShortWait,
        LongWait,
        LinearWait,
        CappedLinearWait,
        LinearWaitLong,
        CappedLinearWaitLong
    }
}