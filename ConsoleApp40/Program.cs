using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new Mail("djonich@mail.ru");
            Console.Write(email.Input);
            if (email.IsCorrect)
                Console.WriteLine(" - Верная запись!");
        }
    }
}
