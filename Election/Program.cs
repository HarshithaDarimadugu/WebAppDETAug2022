using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace votingelibility
{
    internal class VotingEligibility
    {
        public static void Main()
        {
            VotingEligibilityYear();
        }

        public static void VotingEligibilityYear()
        {
            int presentYear = 2022;
            int[] input;
            int n;
            Console.WriteLine("Enter the number of elements in array");
            n = Convert.ToInt32(Console.ReadLine());

            input = new int[n];
            Console.WriteLine("Enter the elements in array");


            for (int i = 0; i < n; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] output = new int[n];
            for (int i = 0; i < n; i++)
            {
                int age = presentYear - input[i];
                if (age >= 18 && age < 150)
                {
                    output[i] = presentYear;

                    Console.WriteLine("your eligible year " + output[i]);
                    Console.WriteLine("                ");
                }
                else if (age < 18 && age >= 0)
                {
                    output[i] = presentYear + (18 - age);

                    Console.WriteLine($"your  eligible " + output[i]);

                }
                else
                {
                    output[i] = 0;
                }
            }
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(output[i]);
            //}
        }
    }
}