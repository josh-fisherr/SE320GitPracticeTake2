namespace SE320GitPracticeTake2;

public class Bird:  IFeedable
{
    public void Chirp()
    {
        Console.WriteLine("Squawk!");
    }

    public void Feed(string foodName)
    {
        Console.WriteLine("Feeding: Bird pecks at " + foodName);
    }
    
}