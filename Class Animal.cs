class Animal//klassen som alla andra klasser ärver från
{
    public int Age { get; set; }
    public bool HasTail { get; set; }
    public string Name { get; set; }
    public bool IsMammal { get; set; }
    public string Food { get; set; }

    public Animal(int age, bool hasTail, string name, bool isMammal, string food)
    {
        Age = age;
        HasTail = hasTail;
        Name = name;
        IsMammal = isMammal;
        Food = food;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating {Food}.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} roars! ");
    }
}