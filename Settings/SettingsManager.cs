using SOLID_Principles.Interfaces;

namespace SOLID_Principles.Settings
{
    internal class SettingsManager : ISettingsManager
    {
        private IMessageSender _message;
        private IInputHandler _input;

        public SettingsManager(IMessageSender message, IInputHandler input)
        {
            _message = message;
            _input = input;
        }

        public void SetLowerDiapozon(ref IConfigurable configurable)
        {
            _message.SendMessage("Нижний диапозон");
            configurable.LowerDiapozon = _input.InputNum();
        }

        public void SetNumberOfGuess(ref IConfigurable configurable)
        {
            _message.SendMessage("Введите колличество отгадываний");
            configurable.NumberOfGuess = _input.InputNum();

        }

        public void SetUpperDiapozon(ref IConfigurable configurable)
        {
            _message.SendMessage("Введите верхний диапозон");
            configurable.UpperDiapozon = _input.InputNum();

        }

        public void SetUserName(ref IConfigurable configurable)
        {
            _message.SendMessage("Введите ваше имя");
            configurable.UserName = _input.InputString();
        }


    }
}

