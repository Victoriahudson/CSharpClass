﻿using System;
using CSharpClass.Lessons;
using CSharpClass.Labs;
using CSharpClass.Lab3;

namespace CSharpClass
{
    /*This class is the start of my application
    Lesson 3 - My First Application */
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");
            //MyLesson5examples();
            //MyLesson6Examples();
            //MyLesson7Examples();
            //MyLesson8Examples();
            //MyOtherLesson8Examples();
            //MyLesson9Examples();
            //MyLesson10Examples();   
            //MyLesson11Examples();
            //MyBeerSong();
            //MyLesson12Examples();
            //MyOtherLesson12Examples();
            //MyOtherLesson12Examples2();
            //MyLesson13House();
            //MyLesson14Examples();
            //MyLesson15Examples();
            //MyLesson16Examples();
            //MyTelevision();
            //MyFormula();
           // MyHorse();
           //MyLesson17Examples();
           MyDogLab();
        } // End Method Main

        static void MyDogLab()
        {
            DogLab MyDogLab = new DogLab();
            MyDogLab.SmallDogToHumanYears();
            //end method my dog lab
        }

        public delegate void TryOn(string val);

        static void MyLesson17Examples()
        {
              Lesson17 my17 = new Lesson17("Cowboy", 7); 
        
              TryOn theHat = my17.TryOnHat;
              theHat("I tried on a " + my17.HatType + " hat that was size" +
              my17.HatSize);

              Lesson17 myLesson = new Lesson17();

              Lesson17 myFav17 = new Lesson17("Trucker");
              Console.WriteLine(myFav17.myResult);

              Console.WriteLine(myFav17.MyLambdaExample(6));
        }

        static void MyTelevision()
        {
        HDTelevision myTV = new HDTelevision(4, 525m);
        myTV.TurnOn();
        }
            

        static void MyLesson16Examples()
        {
            Lesson16 my16 = new Lesson16();
            my16.MyArrayListExample();
            my16.MyHashtableExample();
            my16.MyListExample();
            my16.MyOtherList();
            my16.MyDictionaryExample();
            my16.myLinqExample();
            my16.MyOtherLinq();
        }

        static void MyLesson15Examples()
        {
                Lesson15 my15 = new Lesson15();
                my15.CheckExternalEnum();
                my15.MyFavoriteFlavor(Lesson15.IceCreamFlavors.Chocolate);

                my15[2] = 17;
                for (int i = 0; i < my15.ConeArrayLength; i++)
                {
                    Console.WriteLine("Value of {0} = {1}", i, my15[i]);   
                }
        }

        static void MyHorse()
        {
            Horse myHorse = new Horse();
            myHorse.Racing();
            Lab2 myLab = new Lab2();
            myLab.Numbers();
            Donkey myDonkey = new Donkey();
            myDonkey.Racing();
        }

            static void MyLesson14Examples()
            {
                Lesson14Static.CelsiusToFahrenheit("34.5");
                Lesson14Static.FahrenheitToCelsius("64");

                Lesson14Derived myLesson14 = new Lesson14Derived(8);
                myLesson14.ShowResultFeet();
                myLesson14.ShowResultMiles();
            }

        static void MyLesson13House()
        {
            House myHouse = new House(36, "granite");
            Console.WriteLine(myHouse.DoorColor);
            myHouse.RoofType = "Steel";

        }

        static void MyOtherLesson12Examples2()
        {
            Radio myRadio = new CarStereo();
            myRadio.PlaysMusic();

            CarStereo myCarStereo = new CarStereo();

            myCarStereo.PlaysMusic();
        }

        static void MyOtherLesson12Examples()
        {
            Shoes myShoes = new Shoes();
            myShoes.Worn();
        }

        static void MyLesson12Examples()
        {
            Condo myCondo = new Condo();
            myCondo.DoorOpenClose();


            House myHouse = new Condo();
            myHouse.DoorOpenClose();
        }

        static void MyBeerSong()
        {
            BottlesOfBeer beer = new BottlesOfBeer();
            Console.WriteLine(beer.LetsSing());
        }

        static void MyLesson11Examples()
        {
            Lesson11 myOtherEleven = new Lesson11(42);
            Lesson11 myEleven = new Lesson11("Happy", 42);
            Lesson11 MyLesson11 = new Lesson11();
            Lesson11Struct myStruct = new Lesson11Struct(9.99m, "King", "The Stand");
            int myValue = 14;
            myEleven.MyBasicRefExample(ref myValue);
            Console.WriteLine(myValue + " from program");

            string first, last;
            MyLesson11.MyBasicOutExample("Foghorn Leghorn", out first, out last);
            Console.WriteLine(first);
            Console.WriteLine(last);

        } // end method my lesson 11 examples

        static void MyLesson10Examples()
        {
            Lesson10 myTen = new Lesson10();
            myTen.BasicPublicMethod();
            Lesson5 myFive = new Lesson5();
            myFive._myLongValue = 12345L; // can see because its internal
        }

        static void MyLesson9Examples()
        {
            Lesson9 myNine = new Lesson9();
            myNine.BasicArray();
            myNine.MultiArraySample();
            myNine.My3DArrayExample();
            myNine.MyJaggedArrayExample();

        }// end method my lesson 9 examples


        static void MyOtherLesson8Examples()
        {
            Lesson8 myLesson8 = new Lesson8();
            myLesson8.BasicWhileLoop();
            myLesson8.BasicDoWhileLoopExample();
            myLesson8.BasicForLoopExample(5);
            myLesson8.BasicForEachLoopExample();
            Console.WriteLine(myLesson8.BasicJumpStatementExample("Sunday"));
            myLesson8.BasicOtherJumpStatements();

        } // end method my other lesson 8 examples

        static void MyLesson8Examples()
        {
            Lesson8 myEight = new Lesson8();
            myEight.BasicIfStatement();
            myEight.BasicIfElseExample();
            myEight.BasicIfElseChainExample();
            Console.WriteLine(myEight.BasicAndConditionExample());
            Console.WriteLine(myEight.BasicOrConditionExample(24));
            myEight.BasicTernaryOperatorExample(42);
            myEight.BasicSwitchExample(3);

        }// end method my lesson 8 examples

        static void MyLesson7Examples()
        {
            Lesson7 mySeven = new Lesson7();
            mySeven.BasicMath();
            mySeven.BasicModulus();
            mySeven.MyCheckOperator1();
            mySeven.MyCheckOperator2();
            mySeven.MyLeftShiftOperator();
            mySeven.MyAndAssignmentOperator();
            mySeven.MyOrAssignmentOperator();
            mySeven.MyXOrAssignmentOperator();
            mySeven.MyIncrementDecrementExample();
        }  // end method my lesson 7 examples
        static void MyLesson6Examples()
        {
            Lesson6 mySix = new Lesson6();
            mySix.MyTrimExample();
            mySix.MyEqualsExample();
            mySix.myLowerUpperExample();
            mySix.MyStringLength();
            string myJoined = mySix.MyJoinedStrings("Happy", "Coding");
            Console.WriteLine(myJoined);
            string myFav = mySix.MyStringBuilder("pizza", 3);
            Console.WriteLine(myFav);

            // end method my lesson 6 example
        }
        static void MyLesson5examples()
        {
            Lesson5 myFive = new Lesson5();
            myFive.ConvertFloatToInt();
            myFive.LongFromInt();
        }// end method my lesson 5 examples

        static void MyFormula()
        {
            Example1 exam1 = new Example1();
            exam1.MyFormula();
        }

    } // End class
} // end namespace
