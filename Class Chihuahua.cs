class Chihuahua : Dog//ärver från Dog som i sin tur ärver från Animal
{
    public bool IsTiny { get; set; }

    public Chihuahua(int age, string name, string breed, bool isTiny)
        : base(age, name, true, breed)
    {
        IsTiny = isTiny;
    }

    public void Shaking()//metod som skriver ut när chihuahuan skakar
    {
        Console.WriteLine($"{Name} is shaking.");
    }
}

