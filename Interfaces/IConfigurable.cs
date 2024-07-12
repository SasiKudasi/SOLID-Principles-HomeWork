namespace SOLID_Principles.Interfaces
{
    public interface IConfigurable
    {
        string UserName { get; set; }
        int NumberOfGuess { get; set; }
        int LowerDiapozon { get; set; }
        int UpperDiapozon { get; set; }

    }
}
