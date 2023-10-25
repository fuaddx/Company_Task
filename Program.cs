using Task_Company;


Company company1 = new Company("Socar kbr");
Employee e = new Employee("fuad", "xelilov", "fuad123",20);
char option;
do 
{
    Console.WriteLine("1. Create a company");
    Console.WriteLine("2. Create an employee");
    Console.WriteLine("3. Delete employee");
    Console.WriteLine("4. Update employee ");
    Console.WriteLine("5. See all employees");
    Console.WriteLine("6.See employee");
    
    option = Convert.ToChar(Console.ReadLine());

    switch (option)
    {
        case '1':
            company1 = new Company("Socar");
            break;
        case '2':
            e = new Employee("fuad", "xelilov", "fuad123",20);
            company1.AddUser(e);
            break;
        case '3':
            company1.RemoveUser(e.Username);
            break;
        case '4':
            company1.UpdateUser(e.Username);
            break;
        case '5':
            company1.GetAllUser();
            break;
        case '6':
            company1.GetUser(e.Username);
            break;
        default:
            Console.WriteLine("Choose from options");
            break;
    }
} while (option != 'q');
