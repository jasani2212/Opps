// See https://aka.ms/new-console-template for more information
//Inheritance

class Animal
{
    protected void eat()
    {
        Console.WriteLine("heyy I can Eat");
    }
}
class Dog : Animal
{
    static void Main(string[] args)
    {

        Dog obj = new Dog();

        obj.eat();

        Console.ReadLine();
    }
}
