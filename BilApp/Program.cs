﻿using System;


class Bil
{
    public int[] wheel = new int[4];
    public string[] Maker = new string[3] { "Volvo", "Ford", "BMW" };
    
    
    public int MakeYear { get; set; }
    public string color { get; set; }
    public int Currentspeed { get; set; }
    public Engine Engine;



    public void Accelerate(int Currentspeed)
    {
        this.Currentspeed += Currentspeed;

        for (int i = 0; i < wheel.Length; i++)
            wheel[i] += Currentspeed;

        //Console.WriteLine("You are speeding up to: " + Currentspeed);
    }
    //Om man vill tilldela olika värden till hjulen
    /*
    public void Accelerate(int Currentspeed, int[] x)
    {
        this.Currentspeed += Currentspeed;

        for (int i = 0; i<wheel.Length; i++)
            wheel[i] += x[i];
          
        //Console.WriteLine("You are speeding up to: " + Currentspeed);
    }
    */
    public void Decelerate(int Currentspeed)
    {
        this.Currentspeed+= Currentspeed;
        
        
        //Console.WriteLine("You are slowing down to: " + Currentspeed);
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
        
        
        Bil Ferrari = new Bil { color = "red",Engine = V6, Currentspeed = 0};
        Bil Prototype = new Bil { color = "black", Engine = V8, Currentspeed = 0, MakeYear = 2012};
        Bil Prototype2 = new Bil { color = "gul", Engine = V6, Currentspeed = 0, MakeYear = 2013};
        
        Person Mikael = new Person { Name = "Mikael", Age = 19, Gender = "Man", Bil = Ferrari };
        Person Murat = new Person { Name = "FknMert", Age = 19, Gender = "Man", Bil = Prototype };


        //Mikael.Bil.Accelerate(25, new[]{12,32,43,23});
        Console.WriteLine(Murat.Bil.TellMeAboutYourCar());

        
        Console.WriteLine(Mikael.Bil.wheel[2]);
        //Console.WriteLine("Your speed is: " + MinBil.Currentspeed);
       
    }
}

