namespace SOLID_Principles
{
    public interface IConfigurable
    {
        string UserName { get; set; }
        int NumberOfGuess { get; set; }
        int LowerDiapozon { get; set; }
        int UpperDiapozon { get; set; }

    }
}
