using SOLID_Principles.Game;
using SOLID_Principles.InputOutput;
using SOLID_Principles.Settings;

namespace SOLID_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var msg = new MessageToConsoleSender();
            var input = new ConsoleImput();
            var config = new Configure();
            var settings = new SettingsManager(msg, input);
            var settingsMenu = new GetMenu(settings, config);

            settingsMenu.OpenMenu(new SettingsMenu(msg, input));
            var game = new StarterGame(msg, input);
            game.StartGame(config.NumberOfGuess, new GenerateNumber(config.LowerDiapozon, config.UpperDiapozon).Number);
        }
    }
}
