using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace botUniDubna.Models
{
    public class MessagesSendDefaultParams : MessagesSendParams
    {
        public MessagesSendDefaultParams(Message message)
        {
            PeerId = -(message.UserId);
            ChatId = message.ChatId;
            UserId = message.FromId;
            RandomId = (int)message.Id + 1;
        }
    }
}
