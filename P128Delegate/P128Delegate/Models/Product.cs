using System;
using System.Collections.Generic;
using System.Text;

namespace P128Delegate.Models
{
    class Product
    {
        public string Name { get; set; }
        public int _count;
        //public int Count 
        //{ 
        //    get=> _count;
        //    set
        //    {
        //        if (value <= 10)
        //        {
        //            Notify = () => Console.WriteLine($"{Name}Say 10 ve ya 10-dan azdir Qalan:{value}");
        //            Notify();
        //        }

        //        if (value > 50)
        //        {
        //            Notify = () => Console.WriteLine($"{Name}Say :{value} Coxdur");
        //            Notify();
        //        }
        //        _count = value;
        //    }
        //}

        public event Action Notify
        {
            add 
            { 
                Console.WriteLine(value.Method); 
            }
            remove { Console.WriteLine(value.Method); }
        }


        public void Sell()
        {
            _count--;
        }
    }


}
