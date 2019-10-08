using System;

namespace CSharpClass
{
    public class Donkey : Horse
    {
        //string _teeth;
        //string _wireyhair;

        public string Teeth { get; set; }

        public string WireyHair { get; set; }

        public void exportgoods()
        {

        }

        public override void Racing()
        {

            Console.WriteLine("This donkey is not racing");
        }
    }
}