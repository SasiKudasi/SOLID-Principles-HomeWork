using SOLID_Principles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.InputOutput
{
    internal class ConsoleImput : IInputHandler
    {
        public int InputNum()
        {
            var inputedNum = 0;
            var isValid = int.TryParse(Console.ReadLine(), out inputedNum);

            return inputedNum;
        }

        public string InputString()
        {
            return Console.ReadLine();
        }
    }
}
