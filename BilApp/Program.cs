using System;


class Bil
{
    public int wheel { get; set; }
    public string[] Maker = new string[3] { "Volvo", "Ford", "BMW" };
    public string color { get; set; }
    public int Currentspeed { get; set; }
    public int HorsePower { get; set;}
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
}
class Engine
{
    public int HorsePower { get; set; }
    public int FuelCons{ get; set; }
    public string EngineName { get; set; }
    public int MakeYear { get; set; }


}

class Program
{
    static void Main()
    {
        
        Engine V6 = new Engine{HorsePower = 200, EngineName = "V6", FuelCons = 1, MakeYear = 2013};
        Bil MinBil = new Bil { color = "red",Engine = V6, wheel = 4, Currentspeed = 0};
        
        MinBil.Accelerate(5);
        
       
        
        Console.WriteLine("Your speed is: " + MinBil.Currentspeed);
        Console.WriteLine(MinBil.Engine.EngineName);
    }
}

