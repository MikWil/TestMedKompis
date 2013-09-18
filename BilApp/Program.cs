using System;


    class Bil
    {
        public int wheel = 4;
        public string Maker { get; set; }
        public string color { get; set; }
        public int speed { get; set; }


    }

    class Program
    {
        static void Main(string[] args)
        {


            Bil MinBil = new Bil();
            Console.WriteLine(MinBil.Maker);
            



            
           

        }
    }

