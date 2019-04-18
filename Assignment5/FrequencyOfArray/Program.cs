using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyOfArray
{
    class Program
    {
        public int[] inputArray = new int[10] {3,11,9,11,4,11,5,9,2,1 };

        static void Main(string[] args)  { new Program().Run();  }

        public void Run() { this.InterateOverArray(); }

        public void InterateOverArray()
        {
            int output;
            for (int i = 0; i < inputArray.Length; i++)
            {
                output = inputArray[i];
                Console.WriteLine(Convert.ToString(output)); 
            }
        }
    }
}
