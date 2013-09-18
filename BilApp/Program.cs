using System;


class Bil
{
    public int wheel { get; set; }
    public string[] Maker = new string[3] { "Volvo", "Ford", "BMW" };
    public string color { get; set; }
    public int speed { get; set; }


}

class Program
{
    static void Main()
    {
        Bil MinBil = new Bil { color = "red", speed = 240, wheel = 4 };

        


    }
}

