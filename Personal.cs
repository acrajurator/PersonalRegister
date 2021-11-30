using System;
namespace PersonalRegister
{
	public class Personal
	{
        private string namePerson;
        private int salaryPerson;

        public Personal(string name, int salary)
        {
             namePerson = name;
             salaryPerson = salary;
        }

        internal string name()
        {
           return namePerson;
        }

        internal int salary()
        {
            return salaryPerson;
        }
    }
}