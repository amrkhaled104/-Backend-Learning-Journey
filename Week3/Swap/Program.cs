using System.Collections.Generic;
namespace Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two elements you want to swap");
            #region if integer 
            //int elem1=int.Parse(Console.ReadLine()), elem2= int.Parse(Console.ReadLine());
            #endregion
            #region if Strings 
            string elem1 = Console.ReadLine(), elem2 = Console.ReadLine();
            #endregion
            Console.WriteLine(string.Format("Before Swaping \nElem1 : {0}\nElem2 : {1}", elem1, elem2));

            Swap(ref elem1,ref elem2);

            Console.WriteLine($"After Swapping \nElem1 : {elem1}\nElem2 : {elem2}");


        }
        public  static void Swap<T>(ref T val1, ref T val2)
        {
            T Temp = val1;
            val1 = val2;
            val2 = Temp;
        }
    }
}
