using Business.Concrete;
using Entities.Concrete;
using System;

namespace WorkingP
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Person person1 = new Person();
            person1.FirstName = "Erhan";
            person1.LastName = "Can";
            person1.NationalIdentity = 3153135131;
            person1.DateOfBirthYear = 1998;


            Person person2 = new Person();
            person2.FirstName = "Alperen";
            person2.LastName = "Bozkurt";
            person2.NationalIdentity = 11101097684;
            person2.DateOfBirthYear = 1998;

            PttMng pttMng = new PttMng(new PersonMng());
            pttMng.GiveMask(person1);
            pttMng.GiveMask(person2);
            pttMng.GiveMask(person2);
        }

        static void hosgeldin(string isim)
        {
            Console.WriteLine("Merhaba" + isim);
        }
        
    }
}
