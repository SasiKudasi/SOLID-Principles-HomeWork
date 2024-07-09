namespace SOLID_Principles
{
    public interface ISettingsManager
    {
        void SetUserName(ref IConfigurable configurable);
        void SetNumberOfGuess(ref IConfigurable configurable);
        void SetLowerDiapozon(ref IConfigurable configurable);
        void SetUpperDiapozon(ref IConfigurable configurable);
    }
}
