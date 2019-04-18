using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyOfArray
{
    class Program
    {
        public int[] inputArray = new int[10] { 3, 11, 9, 11, 4, 11, 5, 9, 2, 1 };
        public int[,] frequencyOfOccuranceArray = new int[10,2] ;

        static void Main(string[] args)  { new Program().Run();  }

        public void Run() { this.InterateOverArray(); }

        public void InterateOverArray()
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                CountFrequencyOfOccurance(inputArray[i]);
                
            }
        }

        public void CountFrequencyOfOccurance(int inputValue)
        {
            // get a handle on inputArray
            // find out if inputValue is in INPUT ARRAY
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == inputValue)
                {
                    
                }
            }

            // if I got through the entire array WITHOUT finding the INPUT VALUE
            // then I must ADD IT
        }
    }
}
