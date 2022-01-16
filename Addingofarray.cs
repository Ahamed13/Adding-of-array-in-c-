using System;

namespace AddofArray
{
    class Addingofarray
    {
        static int Addarray(int x, string y)
        {
            int z = 0;
            string[] arr = y.Split(" ");
            if(x == arr.Length)
            {
                foreach(string item in arr)
                {
                    z += Convert.ToInt32(item);

                }
            }
            return z;
            
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the Array : ");
            string y = Console.ReadLine();
            int result = Addarray(x, y);
            Console.WriteLine(result);
        }
    }
}
