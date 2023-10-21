class Fish : Animal
{
    public string WaterType { get; set; }

    public Fish(int age, string name, string waterType)
        : base(age, false, name, false, "fish food")
    {
        WaterType = waterType;
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} is swimming in {WaterType} water.");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} does not make a sound.");
    }
}