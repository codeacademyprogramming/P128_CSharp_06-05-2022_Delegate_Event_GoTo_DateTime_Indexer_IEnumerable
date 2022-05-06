using P128Delegate.Models;
using System;

namespace P128Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Func Delegate
            //Return Type void-den ferqli olan ve maksimum 0-dan 16-a qeder parametri olan methodlarin temsilcisi (Delegate)
            //Func<bool, int, double> func1 = Test;
            //Func<int, double> func2 = Test;
            //Func<double> func3 = Test;

            //string a = "test";

            //Func<string, int> func = StrUpper;
            //func += StrGetLength;
            //func += a => 
            //{
            //    Console.WriteLine(a + " Code");
            //    return 1;
            //};

            //StrGetLength(a);
            //StrUpper(a);
            //StrJoin(a);

            //TestDelegate(func, a);
            #endregion

            #region Action Delegate
            //Return Type void olan ve maksimum 0-dan 16-a qeder parametri olan methodlarin temsilcisi (Delegate)
            //Action action = Test;
            //Action<int> action1 = Test;
            //Action<bool, int> action2 = Test;
            #endregion

            #region Predicate
            //Return bool olub ve yalniz bir parametri olan methodlarin Temsilcisi(Delegeta)
            //Predicate<int> predicate = Isodd;
            //Func<int, bool> func = Isodd;
            #endregion

            #region Example Group Student
            //Group group = new Group();
            //group.GetStudents("m");

            //group.Find(CheckName);

            //group.Find(CheckNameAndSurName);

            //group.Find(delegate (Student s)
            //{
            //    return s.Age == 17;
            //});



            //group.Find(s => s.Age > 17 && s.Name == "Hamid");

            //Write<int,object>(5);
            //Write<long>(5);
            //Write<float>(5);
            //Write<string>("Test");
            #endregion

            //Product product = new Product();
            //product.Name = "Zavod Coreyi";
            //product._count = 10;
            //if (product._count >= 10)
            //{
            //    product.Notify += () => Console.WriteLine("Test");
            //    product.Notify -= () => Console.WriteLine("Test");
            //}

            //Product product1 = new Product();
            //product.Name = "Bizon";
            //product._count = 50;
            //if (product1._count < 100)
            //{
            //    product1.Notify += () => Console.WriteLine("Aglima Hecne Gelmir");
            //}
        }

        //static void Write<T,U>(T a) where T: U
        //{
        //    Console.WriteLine(a);
        //}

        //public static bool CheckName(Student student)
        //{
        //    return student.Name.ToLower().Contains("a");
        //}

        //public static bool CheckNameAndSurName(Student student)
        //{
        //    return student.Name == "Hamid" && student.SurName ==  "Mammadov";
        //}

        #region Example
        //public static bool Isodd(int num)
        //{
        //    return num % 2 == 0;
        //}

        //static void TestDelegate(Func<string, int> func, string e)
        //{
        //    func -= StrJoin;
        //    func -= a =>
        //    {
        //        Console.WriteLine(a + " Code");
        //        return 1;
        //    };
        //    func(e);
        //}

        //static int StrUpper(string a)
        //{
        //    Console.WriteLine(a.ToUpper());
        //    return 1;
        //}
        //static int StrGetLength(string a)
        //{
        //    Console.WriteLine(a.Length);
        //    return 1;

        //}

        //static int StrJoin(string a)
        //{
        //    Console.WriteLine(a + " Code");
        //    return 1;

        //}

        //static void Test(bool a, int b)
        //{
        //}

        //static void Test(int a)
        //{
        //}
        //static void Test()
        //{
        //}
        #endregion
    }
}
