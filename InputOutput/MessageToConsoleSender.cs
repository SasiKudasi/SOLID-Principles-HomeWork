using SOLID_Principles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.InputOutput
{
    internal class MessageToConsoleSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
