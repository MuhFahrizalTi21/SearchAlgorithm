using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm_126_D
{
    class Program
    {
        // array to be searched
        int[] arr = new int [20];
        // Number of elements in the array 
        int n;
        //Get the number of elements to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\n Array Should Have Minimum 1 and Maximum 20 elements.\n");
            }
            //accept array elements
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine("Enter Array  Elements ");
            Console.WriteLine("----------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" +(i + 1) +  ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                //accept the number to be searched
                Console.Write("\n Enter element want you to search : ");
                int item = Convert.ToInt32(Console.ReadLine());

                // apply binary search 
                int lowerbound = 0;
                int upperbound = n - 1;

                //obtain the index of the middle elemets 
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //loop to search for the elements in the array 
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;

                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n " + item.ToString() + "Found at posisition " + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "not found at posisition in the array\\n");
                Console.WriteLine("\nNumber of comparasion : " + ctr);

                Console.Write("\nContinue search (y/n) : ");
                ch = char.Parse(Console.ReadLine());

            } while ((ch == 'y') || (ch == 'Y'));
        }
        public void LinearSearch()
        {
            char ch;
            //search for number to be comparison
            int ctr;
            do
            {
                //Accept the number to be searched
                Console.Write("\n Enter the element you want to search: ");
                int item = Convert.ToInt32(Console.ReadLine());

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n " + item.ToString() + "Found st position " + (i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                    Console.WriteLine("\n" + item.ToString() + "not found in the array ");
                Console.WriteLine("\nNumber of Comparison : " + ctr);
                Console.Write("\nContinue search (y/n) : ");
                ch = Char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu; 
        }
    }
}
