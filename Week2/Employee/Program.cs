namespace Week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int numEmployees;

            while (!int.TryParse(Console.ReadLine(), out numEmployees) || numEmployees <= 0)
            {
                Console.Write("Invalid input! Please enter a valid positive number: ");
            }

            Employee[] employees = new Employee[numEmployees]; 

            for (int i = 0; i < numEmployees; i++)
            {
                Console.WriteLine($"\nEnter details for Employee {i + 1}:");
                employees[i] = new Employee(); 

                Console.Write("Enter Employee ID: ");
                employees[i].ID = int.Parse(Console.ReadLine());

                Console.Write("Enter Employee Name: ");
                employees[i].Name = Console.ReadLine();

                while (true)
                {
                    try
                    {
                        Console.Write("Enter Gender (M/F): ");
                        employees[i].Gender = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"\nError: {ex.Message} Please try again.\n");
                    }
                }

                Console.Write("Enter Security Level (0: Guest, 1: Developer, 2: Secretary, 3: DBA): ");
                employees[i].Security = (SecurityLevel)int.Parse(Console.ReadLine());

                Console.Write("Enter Salary: ");
                employees[i].Salary = double.Parse(Console.ReadLine());

                Console.Write("Enter Hire Date (yyyy-MM-dd): ");
                employees[i].HireDate = DateTime.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nEmployees Details:");
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
