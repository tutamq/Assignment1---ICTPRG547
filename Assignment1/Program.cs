using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.WriteLine(person1);

            person1.PersonName = "Tom";
            person1.PersonEmail = "tom@tom.tom";
            person1.PersonPhoneNo = "0412345678";

            Address tomAddress = new Address("12", "Tom Street", "TOM", "1234", "SA");
            person1.PersonAddress = tomAddress;

            Console.WriteLine(person1);

            Console.ReadKey();
        }
    }
}
