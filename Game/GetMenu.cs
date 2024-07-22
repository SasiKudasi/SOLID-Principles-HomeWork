using SOLID_Principles.Interfaces;

namespace SOLID_Principles.Game
{
    public class GetMenu
    {
        private ISettingsManager _settingsManager;        


        public GetMenu(ISettingsManager settingsManager)
        {
            _settingsManager = settingsManager;
           
        }

        public void OpenMenu(IMenuSender menu)
        {
            menu.SendMenu( _settingsManager);
        }

    }
}
