namespace SOLID_Principles.Interfaces
{
    public interface ISettingsManager
    {
        void SetUserName();
        void SetNumberOfGuess();
        void SetLowerDiapozon();
        void SetUpperDiapozon();
        IConfigurable GetConfigure();
    }
}
