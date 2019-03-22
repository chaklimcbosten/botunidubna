using botUniDubna.Models;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace botUniDubna.Dialogs
{
    public class RootDialog
    {
        public Message Message { get; set; }

        public RootDialog(Message message)
        {
            Message = message;
        }
         
        public MessagesSendParams Response()
        {
            // TODO
            // реализовать проверку последнего входа пользователя и,
            // при долгом его отсутствии, переход в специальный диалог,
            // где его будут приветствовать с удивлением от того, как долго
            // он не подавал никаких сигналов

            switch (Message.Text)
            {
                case "Новости":
                    return new NewsDialog(Message).Response();

                case "Абитуриенту":
                
                case "Расписание":
                    return new ScheduleDialog(Message).Response();

                case "Мои настройки":
                    return new MySettingsDialog(Message).Response();

                case "В главное меню":
                    return new MainMenuDialog(Message).Response();
            }

            return new MessagesSendDefaultParams(Message)
            {
                Message = new IncorrectRequest().RandomIncorrectRequest(),
                Keyboard = new KeyboardTemplates().MainMenu().Build()
            };
        }
    }
}
