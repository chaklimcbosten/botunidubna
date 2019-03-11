using botUniDubna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace botUniDubna.Dialogs
{
    public class NewsDialog
    {
        public Message Message { get; set; }

        public NewsDialog(Message message)
        {
            Message = message;
        }

        public MessagesSendParams Response()
        {
            return new MessagesSendDefaultParams(Message)
            {
                Message = "Простите, раздел находится в разработке.",
                Keyboard = new KeyboardTemplates().DialogInDevelopment().Build()
            };
        }
    }
}
