using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Company
{
    public class Company
    {
        string _name;
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                
                if (!string.IsNullOrWhiteSpace(value))
                {
                    value = value.Trim();
                    this._name = value.ToUpper()[0] + value.Substring(1);
                }
            }
        }
        public Employee[] Employees; //new Employee[0]

        public Company(string name)
        {
            Name = name;
            Employees = new Employee[0];
        }

        public void  AddUser(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length+1);
            Employees[Employees.Length-1] = employee;
            Console.WriteLine("Successfully added!");
        }
        public Employee GetUser(string username) 
        { 
            foreach (Employee emp in Employees)
            {
                if (emp.Username == username) {  return emp; }
            }
            Console.WriteLine("Employee with given username not found");
            return null; 
        }

        public Employee UpdateUser(string username)
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].Username == username)
                {
                    Console.WriteLine($"What you want uptade in {username}?\n");
                    Console.WriteLine("1. Update Name");
                    Console.WriteLine("2. Update Surname");
                    Console.WriteLine("3. Update Age");
                }
            }

            Console.WriteLine($"Username {username} didnt find");
            return null;
        }


        public void GetAllUser()
        {
            foreach ( Employee users in Employees)
            {
                Console.WriteLine(users);
            }
            
        }

        public void RemoveUser(string username)
        {
            int indexToRemove = -1;
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].Username == username)
                {
                    indexToRemove = i;
                    break;
                }
            }

            if (indexToRemove != -1)
            {
                for (int i = indexToRemove; i < Employees.Length - 1; i++)
                {
                    Employees[i] = Employees[i + 1];
                }
                Array.Resize(ref Employees, Employees.Length - 1);
                Console.WriteLine($"Employee {username} has been removed successfully.");
            }
            else
            {
                Console.WriteLine($"Employee with username {username} not found.");
            }
        }
    }
}

