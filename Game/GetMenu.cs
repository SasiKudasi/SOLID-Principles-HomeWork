using SOLID_Principles.Interfaces;

namespace SOLID_Principles.Game
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

        public void OpenMenu(IMenuSender menu)
        {
            menu.SendMenu(_configurable, _settingsManager);
        }

    }
}
