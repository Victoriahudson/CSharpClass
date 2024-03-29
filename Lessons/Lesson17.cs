using System;

/*This class goes over the Lesson Content
Delegates, Events & Lambdas */
namespace CSharpClass.Lessons
{
    public class Lesson17
    {
        public string HatType { get; private set; }
        public int HatSize { get; private set; }
        public string myResult {get; private set;}

        private string _prop;
        public string MyProperty
        {
            // (parameters) => expression-or-statement-block
            get => _prop;
            set => _prop = value;


        }
        
        public delegate void TryOnAnotherHat( string hat);
        public delegate string TryFavoriteHat(string fav);
        delegate int del(int beta);
        public event TryFavoriteHat MyEventHat;

        public Lesson17()
        {
            TryOnAnotherHat otherHat = TryOnHat;
            TryALargerHat("fadora", 7, otherHat);
        }

        public Lesson17(string type, int size)
        {
            HatType = type;
            HatSize = size;
        }

        public Lesson17(string type)
        {
            MyEventHat += new TryFavoriteHat(myFavoriteHat);
            myResult = MyEventHat(type);
        }

        public string myFavoriteHat (string message)
        {
            return "My favorite hat is"  + message;
        }

        public void TryALargerHat(string type, int oldSize, TryOnAnotherHat another)
        {
            another("I tried on a " + type + "hat at size" + (++oldSize));
        }

        public void TryOnHat(string message)
        {
            Console.WriteLine(message);
        }

        public int MyLambdaExample(int value)
        {
            //(parameters) => expression-or-statement-block
            del myDelegate = x => x * x;
            return myDelegate(value);
        }

    }
}