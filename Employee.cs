using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task_Company
{
    public class Employee
    {
        private string _name;
        private string _surName;
        private string _username;
        private byte _age;

        public string Name 
        { 
            get => _name;
            set => _name = FormatName(value);
        }
        public string Surname
        {
            get => _surName;
            set => _surName = FormatName(value);
        }
        public string Username { get ; set ; }
        public byte Age
        {
            get => _age;
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age must be greater than 0.");
                }
            }
        }
        public Employee(string name, string surname, string username,byte age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Username = username;
            this.Age = age;
        }

        public string FormatName(string name)
        {
            char[] charArray = name.ToCharArray();
            charArray[0] = Char.ToUpper(charArray[0]);
            return new string(charArray);
        }

        
    }



}
