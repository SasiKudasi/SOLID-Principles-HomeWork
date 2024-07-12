using SOLID_Principles.Interfaces;

namespace SOLID_Principles.Settings
{
    internal class Configure : IConfigurable
    {
        public string UserName { get; set; } = "User";
        public int NumberOfGuess { get; set; } = 5;
        public int LowerDiapozon { get; set; } = 0;
        public int UpperDiapozon { get; set; } = 10;
    }
}
