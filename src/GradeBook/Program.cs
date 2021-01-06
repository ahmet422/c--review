using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {



            var book = new Book("Math");
            book.AddGrade(12.3);
            book.AddGrade(16.3);
            book.AddGrade(18.3);
            book.AddGrade(80.3);
            book.AddGrade(82.3);
            
            //var numbers = new [] {12.3,45.2,12.7};
            book.displayInfo();     
            
        }
    }
}
