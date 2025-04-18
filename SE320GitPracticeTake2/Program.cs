namespace SE320GitPracticeTake2;

class Program
{
    public static void Main(string[] args)
    {
        List<IFeedable> pets = new List<IFeedable>();
        
        Dog dog = new Dog();
        Cat cat = new Cat();
        Bird bird = new Bird();

        Hedgehog hedgehog = new Hedgehog();
        pets.Add(dog);
        pets.Add(cat);
        pets.Add(bird);
        pets.Add(hedgehog);
        
        foreach (IFeedable pet in pets)
            pet.Feed("hamburger");
    }
}