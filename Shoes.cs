using System;

/* This class goes over Shoes */

namespace CSharpClass

{
    public class Shoes
    {
        //int _eyelets;
        string _heels;
        string _laces;

    public int Eyelets { get; set;}

    public string Heels { get; set ;}
    public string Laces { get; set ;}

        public virtual void Worn()

        {
            Console.WriteLine("The shoes are worn");
        }

        public void Worn(string laces)
        {

        }
    }
    // end method worn

}// end method shoes
 // end class