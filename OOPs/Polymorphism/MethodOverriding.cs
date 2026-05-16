// method overriding example with virtual + override keywords 
using System;
namespace MyApp2.OOPs.Polymorphism;
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal is speaking");
    } 
}

class Dog: Animal // single inheritance
{
    public override void Speak()
    {
        Console.WriteLine("Dog is barking");
    }
}

