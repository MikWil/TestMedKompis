using System;


class Bil
{
    public int wheel { get; set; }
    public string[] Maker = new string[3] { "Volvo", "Ford", "BMW" };
    public string color { get; set; }
    public int Currentspeed { get; set; }
    public int HorsePower { get; set;}



    public void Accelerate(int Currentspeed)
    {
        Currentspeed++;

        Console.WriteLine("You are speeding up to: " + Currentspeed);
    }
    public void Decelerate(int Currnetspeed)
    {
        Currnetspeed++;
        Console.WriteLine("You are slowing down to: " + Currnetspeed);
    }
}

class Program
{
    static void Main()
    {
        Bil MinBil = new Bil { color = "red", HorsePower = 240, wheel = 4, Currentspeed = 0};

        MinBil.Accelerate(0);
        Console.WriteLine(MinBil.Currentspeed);

    }
}

