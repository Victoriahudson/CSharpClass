using System;

namespace CSharpClass
{
    public class Horse
    {
        int _hooves;
        //string _tail;
        //string _softhair;
        //string _largebody;

        public Horse(int hooves, string tail,
         string softhair, string largebody)
           { 
               this._hooves = hooves;
               Tail = tail;
               SoftHair = softhair;
               LargeBody = largebody;

           }
        public Horse()
        : this(4, "bushy tail", "silky", "musculer")
        {

        }

        public int Hooves
        {
            get { return _hooves; }
            set { _hooves = value; }
        }

        public string Tail { get; set; }

        public string SoftHair { get; set; }

        public string LargeBody { get; set; }


        public virtual void Racing()

        {
            Console.WriteLine("The horse is racing");

            //int void wrangling (string Large Body)
        }
    }// end class
}// end namespace