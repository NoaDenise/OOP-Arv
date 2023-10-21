class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(int age, string name, bool hasTail, string breed)
        : base(age, hasTail, name, true, "dog food")
    {
        Breed = breed;
    }

    public void WagsTail()
    {
        Console.WriteLine($"{Name} wags its tail.");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the {Breed} barks.");
    }
}
