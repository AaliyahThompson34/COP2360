using System;

// Custom IEnumerator interface (based on your Interfaces.txt example)
public interface IEnumerator
{
    bool MoveNext();
    object Current { get; }
    void Reset();
}

// Countdown class that implements IEnumerator
public class Countdown : IEnumerator
{
    private int count = 10;

    // Moves to the next value
    public bool MoveNext()
    {
        return count-- > 0;
    }

    // Returns the current value
    public object Current
    {
        get { return count; }
    }

    // Reset is not supported in this example
    public void Reset()
    {
        throw new NotSupportedException("Reset is not supported.");
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Countdown using the interface type
        IEnumerator counter = new Countdown();

        Console.WriteLine("Countdown starting:");

        // Use a while loop to iterate through the countdown
        while (counter.MoveNext())
        {
            Console.WriteLine(counter.Current);
        }

        Console.WriteLine("Countdown complete!");
    }
}
