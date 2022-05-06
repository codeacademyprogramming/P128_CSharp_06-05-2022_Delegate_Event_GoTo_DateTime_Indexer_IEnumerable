using System;
using System.Collections.Generic;
using System.Text;

namespace P128Delegate.Models
{
    class Student
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public byte Age { get; set; }

        public override string ToString()
        {
            return $"{Name} {SurName} {Age}";
        }
    }
}
