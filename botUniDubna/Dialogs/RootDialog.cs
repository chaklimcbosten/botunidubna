using botUniDubna.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
