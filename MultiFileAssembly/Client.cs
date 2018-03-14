using System;
using MultiFileAssembly;

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Sound();

		Cat cat = new Cat();
		cat.Sound();
		
        Console.ReadLine();
    }
}