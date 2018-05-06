using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo input;
            
            do
            {                
                Console.WriteLine("Enter a number:");
                input = Console.ReadKey();
                Console.WriteLine("\r");
            }
            while (input.Key != ConsoleKey.D1);
            

        }
    }

    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> results = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)                            
                            results.Add(new List<int> { nums[i], nums[j], nums[k] });                        
                    }                       
                }
            }

            results.Distinct();
            if (results.Count > 0)
                return results;
            else
                throw new Exception("no three sum solution");
        }
    }
}
