namespace Week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PostGraduate[] pg = new PostGraduate[3]; 
            Console.WriteLine("Enter Student Details:");
            for (int i = 0; i < 3; i++)
            {
                pg[i] = new PostGraduate();
                Console.Write($"Enter Name for Student {i + 1}: ");
                pg[i].Name = Console.ReadLine();

                Console.Write($"Enter Age for Student {i + 1}: ");
                pg[i].Age = int.Parse(Console.ReadLine());

                Console.Write($"Enter Grade for Student {i + 1}: ");
                pg[i].Grade = Console.ReadLine();

                Console.Write($"Enter Thesis Topic for Student {i + 1}: ");
                pg[i].ThesisTopic = Console.ReadLine();

                Console.WriteLine();
            }
            Console.WriteLine("\nStudents Details:");
            for (int i = 0; i < 3; i++)
            {
                   pg[i].PrintDetails();
                Console.WriteLine("_________________________________________");
            }
        }
    }
}
