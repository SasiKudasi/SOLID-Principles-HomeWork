using SOLID_Principles.Interfaces;

namespace SOLID_Principles.Settings
{
    internal class SettingsManager : ISettingsManager
    {
        private IMessageSender _message;
        private IInputHandler _input;
        private IConfigurable _config;
        public SettingsManager(IMessageSender message, IInputHandler input, IConfigurable configurable)
        {
            _message = message;
            _input = input;   
            _config = configurable;
        }

        public void SetLowerDiapozon()
        {
            _message.SendMessage("Нижний диапозон");
            _config.LowerDiapozon = _input.InputNum();
        }

        public void SetNumberOfGuess()
        {
            _message.SendMessage("Введите колличество отгадываний");
            _config.NumberOfGuess = _input.InputNum();

        }

        public void SetUpperDiapozon()
        {
            _message.SendMessage("Введите верхний диапозон");
            _config.UpperDiapozon = _input.InputNum();

        }

        public void SetUserName()
        {
            _message.SendMessage("Введите ваше имя");
            _config.UserName = _input.InputString();
        }
        public IConfigurable GetConfigure()
        {
            return _config;
        }

    }
}

