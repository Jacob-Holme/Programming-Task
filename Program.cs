using System;

namespace Anzen___Programming_Task
{
    class Program
    {
   
        static void Main(string[] args)
        {
            var Input = new UserInput();
            var MethodResult = new ArrayMethod(Input.getIntArray(), Input.getRepeatNumber());
            MethodResult.Result();

            Console.ReadLine();
        }
    }
}
