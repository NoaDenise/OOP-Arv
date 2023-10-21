namespace OOP_Arv
{ //Noa Denise Ishac NET23
    internal class Program
    {
        static void Main(string[] args)
        {
            //skapar instanser av klasserna
            Animal lion = new Animal(5, true, "The lion", true, "meat");
            Fish goldfish = new Fish(2, "Doris the fish", "freshwater");
            Cat siamese = new Cat(3, "The cat", true, "Bengal");
            Bulldog bulldog = new Bulldog(4, "Max", "Bulldog", "loyal");
            Chihuahua chihuahua = new Chihuahua(2, "Lilly", "Chihuahua", true);
            
            //skriver ut alla ljud 
            lion.MakeSound();
            goldfish.MakeSound();
            siamese.MakeSound();
            bulldog.MakeSound();
            chihuahua.MakeSound();



        }
    }
}