using System;

/* This class goes over Sandals */
namespace CSharpClass
{
    public class Sandals : Shoes
    {
        int _strapes;
        //string _colorful;
        //string _flats;   

        public int Strapes
        {
          get { return _strapes; } 
          set { _strapes = value; }  
        }
        public string _ColorFul {get; set;}

        public string Flats { get; set; }
    public void protects()
    {
    // end method protects    
    }
    public override void Worn()
    {
        Console.WriteLine("The sandals are worn");
    }
    
    }
}// end class