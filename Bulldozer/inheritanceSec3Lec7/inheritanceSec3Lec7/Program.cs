using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceSec3Lec7
{
    class Program
    {
        static void Main(string[] args)
        {
            var man = new Man();
            var kart = new Kart();
            var alien = new Alien();

            man.color = "yellow";
            kart.color = "red";
            alien.planet = "Mars";

            Console.WriteLine( "My man is " + man.color + " and my kart is " + kart.color + " while my alien is from " + alien.planet);
            Console.ReadLine();
        }
    }

    // we are using some properties over and over e.g moves and color (too much code). Time to inherit. First create a new class
    public class GeneralObject
    {
        //build a constructor first. Will have all the properties the objects have in common
        public GeneralObject() { 
        }
            public bool moves { get; set; }
            public string color { get; set; }
        
    }


    public class Man : GeneralObject //will look at GenObj & steal all its properties. Properties u didn't have to type again here in this class
    {
        public Man()
        {

        }
        /*public bool moves { get; set; }*/
        public string name { get; set; }
        /*public string color { get; set; }*/
    }

    public class Kart : GeneralObject
    {
        public Kart() {
        }

        /*public bool moves { get; set; }*/
        public string manufacturer { get; set; }
        /*public string color { get; set; }*/
    }

    public class Alien : GeneralObject
    {
        public Alien()
        {
        }

       /*public bool moves { get; set; }*/
       public string planet {get; set;}
        /*public string color { get; set; }*/
    }

}
