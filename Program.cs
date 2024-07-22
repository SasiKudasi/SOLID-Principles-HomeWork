using SOLID_Principles.Game;
using SOLID_Principles.InputOutput;
using SOLID_Principles.Interfaces;
using SOLID_Principles.Settings;

namespace SOLID_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var msg = new MessageToConsoleSender();
            var input = new ConsoleInput();
            IConfigurable config = new Configure();
            var settings = new SettingsManager(msg, input, config);
            var settingsMenu = new GetMenu(settings);
            settingsMenu.OpenMenu(new SettingsMenu(msg, input));
            config = settings.GetConfigure();
            var game = new StarterGame(msg, input);
            game.StartGame(config.NumberOfGuess, new GenerateNumber(config.LowerDiapozon, config.UpperDiapozon).Number);
        }
    }
}
