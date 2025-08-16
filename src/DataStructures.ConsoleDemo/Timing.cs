using System.Diagnostics;

namespace DataStructures.ConsoleDemo;

public class Timing
{
    public TimeSpan StartingTime;
    public TimeSpan Duration;

    public Timing()
    {
        StartingTime = new TimeSpan(0);
        Duration = new TimeSpan(0);
    }
    
    public void StopTime()
    {
        Duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(StartingTime);
    }

    public void StartTime()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        StartingTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
    }

    public TimeSpan Result()
    {
        return Duration;
    }
}