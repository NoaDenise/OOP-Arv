class Bulldog : Dog
{
    public string SpecialTrait { get; set; }

    public Bulldog(int age, string name, string breed, string specialTrait)
        : base(age, name, true, breed)
    {
        SpecialTrait = specialTrait;
    }

    public void GuardHouse()//metod för att skriva ut att hunden vaktar huset
    {
        Console.WriteLine($"{Name} is guarding the house.");
    }
}