using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void DigitalRoot(string RootThis)
        {
            var redirect = new List<int>();
            for (var i = 0; i < RootThis.Length; i++)
            {
                redirect.Add(Convert.ToInt32(RootThis[i].ToString()));
            }
            int preOutput = 0;
            foreach (var item in redirect)
            {
                preOutput = preOutput + item;
            }

            var laneChange = new List<int>();
            for (var i = 0; i < preOutput.ToString().Length; i++)
            {
                laneChange.Add(Convert.ToInt32(preOutput.ToString()[i].ToString()));
            }
            int output = 0;
            foreach (var item in laneChange)
            {
                output = output + item;
            }

            if (output.ToString().Length > 1)
            {
                var again = new List<int>();
                for (var i = 0; i < output.ToString().Length; i++)
                {
                    again.Add(Convert.ToInt32(output.ToString()[i].ToString()));
                }
                int outputFinal = 0;
                foreach (var item in again)
                {
                    outputFinal = outputFinal + item;
                }
                Console.WriteLine("Input: " + RootThis);
                Console.WriteLine("Became --> " + preOutput);
                Console.WriteLine("Became --> " + output);
                Console.WriteLine("Output: " + outputFinal);
            }
            else
            {
                Console.WriteLine("Input: " + RootThis);
                Console.WriteLine("Became --> " + preOutput);
                Console.WriteLine("Output: " + output);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a set of numbers.(no spaces please)");
            var number = Console.ReadLine();
            Console.Clear();
            DigitalRoot(number);

            Console.ReadKey();
        }
    }
}
