using System;
using System.Linq;

namespace Anzen___Programming_Task
{
    class ArrayMethod
    {
        private int[] numArray;
        private int repeatNum;

        public ArrayMethod(int[] numArray, int repeatNum) //Array Method compiler takes parameter of the array list and the number of repeats. Calls Result method
        {
            this.numArray = numArray;
            this.repeatNum = repeatNum;
        }

        private Tuple<int[], int[]> SplitArray() //Divides the array in two making two seperate arrays, stored in a tuple
        {


            if (numArray.Length % 2 != 0) //If the array length is not divisible by two then an element of value zero is added to the beginning of the array, making the array length even
            {
                var newArray = new int[numArray.Length + 1];
                newArray[0] = 0;
                Array.Copy(numArray, 0, newArray, 1, numArray.Length);
                numArray = newArray;
            }

            int mid = numArray.Length / 2; //As the array length is even, after splitting the array down the centre, both the left and right sides shall have the same number of elements 
            var leftArray = new int[mid];
            var rightArray = new int[mid];

            for (int i = 0; i < numArray.Length; i++)
            {
                if (i < mid)
                {
                    leftArray[i] = numArray[i];
                }
                else
                {
                    rightArray[i - mid] = numArray[i];
                }
            }
            return new Tuple<int[], int[]>(leftArray, rightArray);
        }

        private int[] AddArrays(Tuple<int[], int[]> tuple) // The corresponding elements of the left and right arrays from Split Array are added together
        {
            var overallArray = new int[tuple.Item1.Length];

            for (int i = 0; i < tuple.Item1.Length; i++)
            {
                overallArray[i] = tuple.Item1[i] + tuple.Item2[i];
            }
            return overallArray;
        }

        private void Repeats()
        {
            for (int i = 0; i < repeatNum; i++)
            {
                numArray = AddArrays(SplitArray());
            }           
        }

        public void Result() // The processes carried out in SplitArray and AddArray are repeated for the pre-determined number of repeats
        {
            Repeats();
            Console.WriteLine();
            foreach (int number in numArray.Take((numArray.Length - 1)))
            {
                Console.Write(number + ", ");
            }
            Console.WriteLine(numArray[numArray.Length-1]);
        }
    }
}
