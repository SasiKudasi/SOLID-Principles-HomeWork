namespace SOLID_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new Configure();
            var settings = new SettingsManager();

            var settingsMenu = new GetMenu(settings, config);
            settingsMenu.Menu(new SettingsMenu());

            StartGame(config.NumberOfGuess, new GenerateNumber(config.LowerDiapozon, config.UpperDiapozon).Number);

        }

        private static void StartGame(int numberOfGuess, int randomNum)
        {
            var userAnswer = 0;
            while (numberOfGuess > 0)
            {
                Console.WriteLine("Введите число");
                int.TryParse(Console.ReadLine(), out userAnswer);
                if (userAnswer == randomNum)
                {
                    Console.WriteLine("Число угаданно!");
                    break;
                }
                else
                    numberOfGuess--;
                if (numberOfGuess == 0)
                {
                    Console.WriteLine($"Закончились попытки. Было загаданно число {randomNum}.");
                    break;
                }
            }
        }
    }
}
