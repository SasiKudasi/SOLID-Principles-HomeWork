namespace SOLID_Principles.Interfaces
{
    public interface IMenuSender
    {
        void SendMenu(IConfigurable configurable, ISettingsManager manager);
    }
}
