using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            string a = "s3cr3t!P@ssw0rd";

            if (pass == a)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!"); 
            }


        }
    }
}
