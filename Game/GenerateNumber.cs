using SOLID_Principles.Interfaces;

namespace SOLID_Principles.Game
{
    public class GenerateNumber : IGenerateNumbers
    {
        public int Number { get; set; }
        public GenerateNumber(int lowerDiaozon, int upperDiapozon)
        {
            Number = GenerateNewNumber(lowerDiaozon, upperDiapozon);
        }

        public int GenerateNewNumber(int lowerDiapozon, int upperDiapozon)
        {
            var r = new Random();
            var randomNum = r.Next(lowerDiapozon, upperDiapozon);
            return randomNum;
        }
    }
}
