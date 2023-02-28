using System;

interface IPet
{
    string Name { get; set; }
    int Age { get; set; }
    string MakeSound();
}

class Dog : IPet
{
    public string Name { get; set; }
    public int Age { get; set; }

    public string MakeSound()
    {
        return "Woof!";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.Name = "Fido";
        myDog.Age = 3;

        Console.WriteLine($"My dog {myDog.Name} is {myDog.Age} years old.");
        Console.WriteLine($"He says '{myDog.MakeSound()}'");

        Console.ReadLine();
    }
}
