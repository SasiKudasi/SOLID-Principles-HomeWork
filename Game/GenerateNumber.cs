using SOLID_Principles.Interfaces;

namespace SOLID_Principles.Game
{
    public class GenerateNumber : BaseGenerateNumber
    {
        public int Number { get; set; }
        public GenerateNumber(int lowerDiaozon, int upperDiapozon)
        {
            Number = GenerateNewNuber(lowerDiaozon, upperDiapozon);
        }
    }
}
