using System;


class Bil
{
    public int wheel { get; set; }
    public string[] Maker = new string[3] { "Volvo", "Ford", "BMW" };
    public string color { get; set; }
    public int Currentspeed { get; set; }
    public Engine Engine;


    public void Accelerate(int Currentspeed)
    {
        this.Currentspeed += Currentspeed;

        Console.WriteLine("You are speeding up to: " + Currentspeed);
    }
    public void Decelerate(int Currentspeed)
    {
        this.Currentspeed+= Currentspeed;
        Console.WriteLine("You are slowing down to: " + Currentspeed);
    }
    public string TellMeAboutYourCar()
    {
        return "I own a car that has a " + color + " color" + "\nAnd it has " + Engine.HorsePower + "HP.";

    }
}
class Engine
{
    public int HorsePower { get; set; }
    public int FuelCons{ get; set; }
    public string EngineName { get; set; }
    public int MakeYear { get; set; }


}
class Person
{
    public string Name;
    public int Age;
    public string Gender;
    public Bil Bil;
}

class Program
{
    static void Main()
    {

        
        Engine V8 = new Engine { HorsePower = 250, EngineName = "V8", FuelCons = 2, MakeYear = 2010 };
        Engine V6 = new Engine{HorsePower = 200, EngineName = "V6", FuelCons = 1, MakeYear = 2013};
        
        
        Bil Ferrari = new Bil { color = "red",Engine = V6, wheel = 4, Currentspeed = 0};
        Bil Prototype = new Bil { color = "black", Engine = V8, wheel = 4, Currentspeed = 0 };
        Bil Prototype2 = new Bil { color = "gul", Engine = V6, wheel = 4, Currentspeed = 0 };
        
        Person Mikael = new Person { Name = "Mikael", Age = 19, Gender = "Man", Bil = Ferrari };
        Person Murat = new Person { Name = "FknMert", Age = 19, Gender = "Man", Bil = Prototype };
        Console.WriteLine(Murat.Bil.TellMeAboutYourCar());
        Console.WriteLine(Mikael.Bil.TellMeAboutYourCar());
        //Console.WriteLine("Your speed is: " + MinBil.Currentspeed);
       
    }
}

