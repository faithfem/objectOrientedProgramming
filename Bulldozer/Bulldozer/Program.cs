using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulldozer //Below lines are the Bulldozer OBJECT. It will be defined by particulars in the BLUEPRINT/CLASS below
{
    class Program
    {
        static void Main(string[] args)
        {
            var dozer = new Bulldozer();
            dozer.color = "Yellow";
            dozer.size = "Huge";

            //You can create another Bulldozer Object, but if u need 100, u'll have to create 100 properties as well, so...use a CONSTRUCTOR
            var dozer2 = new Bulldozer();
            dozer.color = "Red";
            dozer.size = "Miniscule";


            Console.WriteLine("Bulldozer is " + dozer.color);
            Console.ReadLine(); //NOT EXPLAINED ON VIDEO. NEED THIS SO COMMAND PROMPT DOESN'T DISAPPEAR 
            
        }
    }
    
    public class Bulldozer //Creating a Bulldozer BLUEPRINT(CLASS), which will allow us to create the Bulldozer project below
    {
        //creating the CONSTRUCTOR. Goes at top of our class & has the same name as the class
        public Bulldozer(string _color, string _size) //this is a method. When it's called, it will assign the color & size
        {
            this.color = _color;
            this.size = _size;
        }

        public string color { get; set; } //start by creating the color of the Bulldozer project
        public string size { get; set; }
    }

}
