using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Interfaces
{
    public interface IStarterGame
    {
        void StartGame(int numberOfGuess, int randomNum);
    }
}
