namespace SOLID_Principles
{
    public class GetMenu
    {
        private ISettingsManager _settingsManager;
        private IConfigurable _configurable;
        

        public GetMenu(ISettingsManager settingsManager, IConfigurable configurable)
        {
            _settingsManager = settingsManager;
            _configurable = configurable;
        }

        public void Menu(ISendMenu menu)
        {
            menu.SendMenu(_configurable, _settingsManager);            
        }

    }
}
