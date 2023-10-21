class Cat : Animal
{
    public string FurColor { get; set; }

    public Cat(int age, string name, bool hasTail, string furColor)//skapar objektet
        : base(age, hasTail, name, true, "cat food")
    {
        FurColor = furColor;
    }
   
    public void Purr()
    {
        Console.WriteLine($"{Name} is purring.");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} meows.");
    }
}
