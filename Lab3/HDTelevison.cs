using System;

namespace CSharpClass.Lab3
{
    public class HDTelevision : Television
    {
        public override void TurnOn()
        {
            Console.WriteLine("Turn on with remote");
        }

        public HDTelevision(int size, decimal price, int ports, bool isMountable)
        : base(size, price, ports, isMountable)
        {

        } // end base

        public HDTelevision(int size, decimal price)
            : this(size, price, 4, false)
        {

        } // end this


    } // end class
} // end namespace