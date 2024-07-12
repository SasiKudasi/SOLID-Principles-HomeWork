using SOLID_Principles.Interfaces;

namespace SOLID_Principles.Settings
{
    public class SettingsMenu : IMenuSender
    {
        private IMessageSender _message;
        private IInputHandler _input;

        public SettingsMenu(IMessageSender message, IInputHandler input)
        {
            _message = message;
            _input = input;
        }

        public void SendMenu(IConfigurable configurable, ISettingsManager manager)
        {
            int key = 0;
            while (key != 5)
            {
                _message.SendMessage("\nВведите 1, что бы изменить имя.\n" +
                    "Введите 2, что бы изменить колличество попыток\n" +
                    "Введите 3, что изменить нижний диапозон\n" +
                    "Введите 4, что бы изменить верхний диапозон\n" +
                    "Введите 5, что бы начать игру");
                key = _input.InputNum();

                switch (key)
                {
                    case 1:
                        manager.SetUserName(ref configurable);
                        break;
                    case 2:
                        manager.SetNumberOfGuess(ref configurable);
                        break;
                    case 3:
                        manager.SetLowerDiapozon(ref configurable);
                        break;
                    case 4:
                        manager.SetUpperDiapozon(ref configurable);
                        break;

                }

            }
            _message.SendMessage($"{configurable.UserName}, вы успешно изменили настройки.\n"
                 + $"Колличество попыток на угадывание числа: {configurable.NumberOfGuess}\n" +
                 $"Нижний диапозон: {configurable.LowerDiapozon}\n" +
                 $"Верхний диапозон: {configurable.UpperDiapozon}");
        }
    }
}
