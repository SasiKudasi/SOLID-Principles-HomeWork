using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    public class BaseGenerateNumber : IGenerateNumbers
    {  

        public int GenerateNewNuber(int lowerDiapozon, int upperDiapozon)
        {
            var r = new Random();
            var randomNum = r.Next(lowerDiapozon, upperDiapozon);
            return randomNum;
        }
    }
}
