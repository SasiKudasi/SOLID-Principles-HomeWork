using SOLID_Principles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Game
{
    public class StarterGame : IStarterGame
    {
        private IMessageSender _message;
        private IInputHandler _input;

        public StarterGame(IMessageSender messageSender, IInputHandler input)
        {
            _message = messageSender;
            _input = input;
        }

        public void StartGame(int numberOfGuess, int randomNum)
        {
            var userAnswer = 0;
            while (numberOfGuess > 0)
            {
                _message.SendMessage("Введите число");
                userAnswer = _input.InputNum();
                if (userAnswer == randomNum)
                {
                    _message.SendMessage("Число угаданно!");
                    return;
                }
                else
                    numberOfGuess--;
                if (numberOfGuess == 0)
                {
                    _message.SendMessage($"Закончились попытки. Было загаданно число {randomNum}.");
                    return;
                }
            }
        }
    }
}