namespace csharpfundamentals.consoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Prompts the user to enter 10 numbers and stores them in an array. Finds and prints the largest number in the array using a loop.
            //int[] arr = new int[10];
            //Console.WriteLine("Enter Numbers:\n");
            //int max_element = int.MinValue;
            //for(int i = 0; i < 10; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //    if (arr[i] > max_element) max_element = arr[i];
            //}
            //Console.WriteLine($"MAX = {max_element}");
            #endregion
            #region Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant)
            //char c;
            //Console.WriteLine("Enter character:");
            //c = (char)(Console.Read());
            //switch (c)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'I':
            //    case 'o': 
            //    case 'u':
            //        Console.WriteLine("VOWEL");
            //        break;
            //    default:
            //        Console.WriteLine("CONSTANT");
            //        break;
            //}
            #endregion
            #region Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.WriteLine("Enter Number:"); int num=int.Parse(Console.ReadLine());
            //for (int i = 0; i <= 12; i++)
            //{
            //    Console.WriteLine($"{num}*{i}={num * i}");
            //}
            #endregion
            #region Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.WriteLine("Enter num :");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 3 == 0 && num % 4 == 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            #endregion
            #region  Write a program in C# Sharp to convert a decimal number into binary without using an array 
            //Console.WriteLine("Enter number :");
            //short  num = short.Parse(Console.ReadLine());
            //string revbin = " ";
            //while (num != 0)
            //{
            //    revbin += num % 2;
            //    num /= 2;
            //}
            //Console.WriteLine(new string(revbin.Reverse().ToArray()));
            //// i can do newstring and for loop to assign oldstr to newstr 
            #endregion
            #region Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] arr1 = { 4, 2, 6, 9, 0 };
            //int[] arr2 = { 3, 5, 0, 8, 4 };
            //Array.Sort(arr1); Array.Sort(arr2);
            //int[] arr3 = new int[arr1.Length * 2];
            //int i = 0, j = 0;
            //foreach (int ite in arr1)
            //{
            //    arr3[i] = ite;
            //    i++;
            //}
            //foreach (int ite in arr2)
            //{
            //    arr3[i] = ite;
            //    i++;
            //}
            //Array.Sort(arr3);
            //Console.Write("Sorted Merged Array: ");
            //foreach (int item in arr3)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion
            #region Write a program in C# Sharp to find the second largest element in an array.
            //int[] arr = { 5, 6, 2, 1, 4, 5, 2, 1, 4 };
            ////two ways 
            //int max = arr[0]; int prev_max = arr[0];
            //for(int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i]> max)
            //    {
            //        prev_max = max;
            //        max = arr[i];
            //    }
            //}
            //Console.WriteLine($"SMAX={prev_max}");
            //// 2
            //Array.Sort(arr);
            //Console.WriteLine($"MAX={max}  SMAX={prev_max}");


            #endregion
            #region Write a Program to Print One Dimensional Array in Reverse Order
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //for(int i = 0; i < arr.Length; ++i)
            //{
            //    Console.Write(arr[arr.Length - 1 - i] + " ");
            //}

            #endregion


        }
    }
}