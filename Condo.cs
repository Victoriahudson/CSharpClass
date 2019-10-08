using System;

/*This class is a child class of House
Lesson 12 Inheritance */
namespace CSharpClass
{
    public class Condo : House
    {
        public Condo()
            :this(" second floor") { }

        public Condo(string balcony) 
        : base(32, "concrete")

        {
            Balcony = balcony;
        }
      
        string _balcony;

        public void Maintenance() { base.DoorOpenClose(); }

        public string Balcony
        {
            get { return _balcony; }
            set { _balcony = value; }
        }

        public override void DoorOpenClose()
        {
            base.DoorOpenClose();
            Console.WriteLine("This condo door is closed");

        }
    }
}