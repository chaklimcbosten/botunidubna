using botUniDubna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VkNet.Enums.SafetyEnums;
using VkNet.Model;
using VkNet.Model.Keyboard;
using VkNet.Model.RequestParams;

namespace botUniDubna.Dialogs
{
    public class MainMenuDialog
    {
        public Message Message { get; set; }

        public MainMenuDialog(Message message)
        {
            Message = message;
        }

        public MessagesSendParams Response()
        {
            return new MessagesSendDefaultParams(Message)
            {
                Message = "Главное меню:",
                Keyboard = new KeyboardTemplates().MainMenu().Build()
            };
        }
    }
}
