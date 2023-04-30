using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDTask_8
{
    class ZeroToBack
    {
        public static List<int> ZeroDeleter(List<int> arr)
        {
            int zeroCount = 0;
            List<int> list = new List<int> {};
            for (int i = 0; i < arr.Count; i++) 
            {
                if (arr[i] == 0) 
                {
                    zeroCount++;
                    continue;
                }

                list.Add(arr[i]);
            }
            for (int i = 0; i < zeroCount; i++) 
            {
                list.Add(0);
            }

            return list;
        }
        public static int[] ZeroDeleter(int[] input) 
        {
            return ZeroDeleter(input.ToList()).ToArray();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            arr = ZeroToBack.ZeroDeleter(arr);
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.Write(arr[i]);
                Console.Write(' ');
            }
            Console.ReadKey();
        }
    }
}
