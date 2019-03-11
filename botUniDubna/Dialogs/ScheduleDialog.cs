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
    public class ScheduleDialog
    {
        public Message Message { get; set; }

        public ScheduleDialog(Message message)
        {
            Message = message;
        }

        public MessagesSendParams Response()
        {
            return new MessagesSendDefaultParams(Message)
            {
                Message = "Расписание на сегодня:",
                Keyboard = new KeyboardTemplates().Schedule().Build()
            };
        }
    }
}
