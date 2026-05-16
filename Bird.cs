
enum Level
{
    LOW,
    MEDIUM,
    HIGH
}

abstract class Animal
{
  // Abstract method (does not have a body)
  public abstract void animalSound();
  // Regular method
  public void sleep()
  {
    Console.WriteLine("Zzz");
  }
}

interface IBird
{
    void eat();
}

class Peacock : Animal, IBird 
{
    public override void animalSound()
    {
        System.Console.WriteLine("Peacock is making a sound");
    }

    public void eat()
    {
        var birdLevel = Level.LOW;
        System.Console.WriteLine("Peacock is eating");
        System.Console.WriteLine((int) birdLevel);
    }
}
