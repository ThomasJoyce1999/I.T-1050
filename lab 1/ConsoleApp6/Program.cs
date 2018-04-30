using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name?");
            string firstname = Console.ReadLine();
            Console.Write("Your first name is" +  firstname);
            Console.ReadKey();
            Console.Write("What is your middle name?");
            string middlename = System.Console.ReadLine();
            Console.Write("your middle name is" +  middlename);
            Console.ReadKey();
            Console.Write("What is your last name?");
            string lastname = Console.ReadLine();
            Console.Write("Your last name is" + lastname);
            Console.ReadKey();
            Console.Write("Your full name is" + firstname + middlename + lastname);
            Console.ReadKey();
            Console.Write("Height in feet");
            int heightFeet = int.Parse(Console.ReadLine());
            Console.Write("Height in Inches:");
            double heightInches = double.Parse(Console.ReadLine());
            Double heightCentimeters = (heightFeet * 12 + heightInches) * 2.54;
            Console.Write("you are" + heightCentimeters + "Centimeters tall");
            Console.ReadKey();
            Console.Write("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("You are" + age + "Years old");
            Console.ReadKey();
            Console.Write("Are you a U.S Citizen?");
            bool yes;
            yes = true;
            bool no;
            no = false;
            Console.WriteLine("Please enter either"  +yes+ "or"+ no);
            bool isCitizen = Console.ReadLine().ToLower().StartsWith(yes);
            bool isCitizen = bool.Parse(Console.ReadLine());
            bool canVote = isCitizen && age >= 18;
           
            canVote = true;
           
            
            Console.ReadKey();

            

            

         






          



            



            

           
        }
    }
}
