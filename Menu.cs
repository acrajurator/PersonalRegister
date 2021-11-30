using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    class Menu
    {
        bool run = true;
        string name;
        string answer;

        string salaryString;
        int salaryInt;
        List<Personal> employees = new List<Personal>();
        internal void runMenu()
        {

            while (run)
            {

                Console.WriteLine("Hej! Vad vill du göra?\n1. Lägga till personal\n2. Skriva ut lista på personal\n3. Avsluta");
                answer = Console.ReadLine();
                if (answer.Equals("1"))
                {
                    addPersonMenu();

                }
                else if (answer.Equals("2"))
                {
                    printPersonList();

                }
                else if (answer.Equals("3"))
                {
                    Console.WriteLine("Hej då!");
                    run = false;
                }

                else
                {
                    Console.WriteLine("Vänligen skriv bara \"1\" eller \"2\"");
                }
            }
        }

        private void printPersonList()
        {
            foreach (var Personal in employees)
            {
                Console.WriteLine("Namn: " + Personal.name() + " Lön: " + Personal.salary());
            }
        }

        private void addPersonMenu()
        {
            Console.WriteLine("Vem vill du lägga till? Skriv för och efternamn");
            name = Console.ReadLine();
            Console.WriteLine("Är " + name + " korrekt namn?\n1. Ja\n2. Nej");
            answer = Console.ReadLine();
            answer = answer.ToLower();
            if (answer.Equals("1") || answer.Equals("ja"))
            {


                Console.WriteLine("Hur mycket har " + name + " i lön?");
                salaryString = Console.ReadLine();
                try
                {
                    salaryInt = int.Parse(salaryString);
                    employees.Add(new Personal(name, salaryInt));
                    Console.WriteLine("Du har lagt till en person i systemet!");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"'{salaryString}' är inte en giltig lön!");
                }
            }



            else
            {
                Console.WriteLine("Börja om!");
            }

        }
    }
}
        
    

