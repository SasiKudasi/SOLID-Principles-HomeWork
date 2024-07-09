namespace SOLID_Principles
{
    internal class SettingsManager : ISettingsManager
    {
        public void SetLowerDiapozon(ref IConfigurable configurable)
        {
            Console.WriteLine("Нижний диапозон");
            var lowerDiapozon = 0;
            var isValid = int.TryParse(Console.ReadLine(), out lowerDiapozon);
            if (isValid)
            {
                configurable.LowerDiapozon = lowerDiapozon;
            }
        }

        public void SetNumberOfGuess(ref IConfigurable configurable)
        {
            Console.WriteLine("Введите колличество отгадываний");

            var numberOfGuess = 0;
            var isValid = int.TryParse(Console.ReadLine(), out numberOfGuess);
            if (isValid)
            {
                configurable.NumberOfGuess = numberOfGuess;
            }
        }

        public void SetUpperDiapozon(ref IConfigurable configurable)
        {
            Console.WriteLine("Введите верхний диапозон");
            var upperDiaozon = 0;
            var isValid = int.TryParse(Console.ReadLine(), out upperDiaozon);
            if (isValid)
            {
                configurable.UpperDiapozon = upperDiaozon;
            }
        }

        public void SetUserName(ref IConfigurable configurable)
        {
            Console.WriteLine("Введите ваше имя");
            var userName = Console.ReadLine();
            if (userName != null)
            {
                configurable.UserName = userName;
            }


        }
    }
}
