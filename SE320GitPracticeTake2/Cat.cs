namespace SE320GitPracticeTake2;

public class Cat : IFeedable
{
    public void Blep()
    {
        Console.WriteLine("Blep");
    }

    public void Feed(string foodName)
    {
        Console.WriteLine("Feeding: Cat picks at " + foodName);
    }
}