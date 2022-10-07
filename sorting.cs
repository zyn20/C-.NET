using System;
namespace Task;

class Program
{
    
    static void Main(string[] args)
    {
       
        int[] arr = new int[] {10,9,1,5,21,4};
        Console.WriteLine("Original Array");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("\nPress 1 to sort in Ascending Order");
        Console.WriteLine("Press 2 to sort in Descending Order");
        int option;
        option=Console.Read();
        if(option==1)
        {
            Console.WriteLine("\nSorted array in ASC order");
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        else if(option==2)
        {

            Array.Sort(arr);
            Console.WriteLine("Sorted array in DESCENDING order");
            Array.Reverse(arr);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
        else
        {
            Console.WriteLine("Please Enter the valid input");
        }


    
    }


}
