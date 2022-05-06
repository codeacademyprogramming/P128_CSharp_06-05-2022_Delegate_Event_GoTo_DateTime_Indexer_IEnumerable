using System;
using System.Collections.Generic;
using System.Threading;

namespace P128GoToDateTimeIndexerIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            #region GoTo DateTime
            //    Console.WriteLine(DateTime.Now.AddYears(5).Year);
            //testc:
            //    Console.WriteLine("Yasinizi Daxil Et");
            //    int.TryParse(Console.ReadLine(), out int age);
            //step2:

            //    Console.WriteLine("Ili Daxil Et");
            //    int.TryParse(Console.ReadLine(), out int year);

            //    if ((DateTime.Now.AddYears(5).Year - year) != age)
            //    {
            //        Console.WriteLine("duzgun Daxil:");
            //        goto testc;
            //    }

            //    if (age < 18)
            //    {
            //        goto step2;
            //    }

            //    //Console.WriteLine(DateTime.Now.AddMonths(5).ToString("dddd - MMMM - yyyy  HH:mm"));
            #endregion

            List<string> list = new List<string>();

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0; i < list.Count; i++)
            {

            }
            //list.Add("World");


            //list[0] = "Hello";
            //Console.WriteLine(list[0]);

            //Queue<string> queue = new Queue<string>();
            ////queue[0] = "Test";

            MyCollection<string> myCollection = new MyCollection<string>();

            myCollection.Add("Test");
            myCollection.Add("Test");

            myCollection[1] = "Hello";
            Console.WriteLine(myCollection[1]);

            Console.WriteLine("----------------------");

            foreach (var item in myCollection)
            {
                Console.WriteLine(item);
            }


            for (int i = 0; i < myCollection.MyCount; i++)
            {

            }
        }
    }
}
