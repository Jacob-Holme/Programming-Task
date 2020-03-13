using System;

namespace Anzen___Programming_Task
{
    class UserInput
    {
        int[] intArray;
        int repeatNumber;

        public UserInput()
        {
            setIntArray();
            setRepeatNumber();
        }

        private void setIntArray() //Recieves user input for a list of numbers
        {
            Console.WriteLine("Please input the array: ");
            string[] userInputArray = Console.ReadLine().Split(new string[] {", ", " ", ","}, StringSplitOptions.None);
            intArray = new int[userInputArray.Length];
            for (int i = 0; i < userInputArray.Length; i++)
            {
                intArray[i] = stringToInt(userInputArray[i]);
            }
        }

        public int[] getIntArray()
        {
            return intArray;
        }

        private void setRepeatNumber() //Receives user input for one number
        {
            Console.WriteLine("Please input the number of repeats: ");
            repeatNumber = stringToInt(Console.ReadLine());
        }

        public int getRepeatNumber()
        {
            return repeatNumber;
        }

        private static int stringToInt(string userInput) //Converts string to an integer, if this cannot be done an exception is thrown
        {
            int numberInt;
            bool isNum = Int32.TryParse(userInput, out numberInt);
            if (isNum)
            {
                return numberInt;
            }
            else
            {
                throw new System.NotFiniteNumberException("Please input only numbers and ensure correct spacing!");
            }
        }
    }
}
