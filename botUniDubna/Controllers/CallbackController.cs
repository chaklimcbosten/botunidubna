using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using VkNet;
using VkNet.Model;
using VkNet.Model.Keyboard;
using VkNet.Model.Attachments;
using VkNet.Model.RequestParams;
using VkNet.Enums.SafetyEnums;
using botUniDubna.Models;
using botUniDubna.Dialogs;

namespace botUniDubna.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallbackController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public static string MyAppToken => "5230ec93f6f58f2e8b190e0fc9cd1e4b810ee0889d240be2f3f1885fc3fb4177aa33e8ee525dc726bb7b5";
        public static ulong MyGroupId => 162749513;

        public CallbackController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public IActionResult Callback([FromBody] Updates updates)
        {
            // TODO
            // реализовать проверку security-key

            // Тип события
            switch (updates.Type)
            {
                // Ключ-подтверждение
                case "confirmation":

                    //return new OkObjectResult(_configuration["Config:Confirmation"]);
                    return new OkObjectResult("dcf06e03");

                // Новое сообщение
                case "message_new":

                    var api = new VkApi();

                    api.Authorize(new ApiAuthParams() { AccessToken = MyAppToken });

                    var dialog = new RootDialog(JsonConvert.DeserializeObject<Message>(updates.Object.ToString()));

                    api.Messages.Send(dialog.Response());

                    return new OkObjectResult("ok");

                    //// Десериализация
                    //var msg = JsonConvert.DeserializeObject<Message>(updates.Object.ToString());

                    //var api = new VkApi();

                    //api.Authorize(new ApiAuthParams() { AccessToken = MyAppToken });


                    ////var keyboard = new KeyboardBuilder(/*"text", false*/).AddButton("Расписание", "расписание", KeyboardButtonColor.Positive);
                    ////keyboard.AddButton("Расписание", "расписание", KeyboardButtonColor.Negative);
                    ////keyboard.AddLine();
                    ////keyboard.AddButton("Расписание", "расписание", KeyboardButtonColor.Primary);
                    ////keyboard.AddButton("Расписание", "расписание");

                    //api.Messages.Send(new MessagesSendParams()
                    //{
                    //    PeerId = -(long)(MyGroupId),
                    //    ChatId = msg.ChatId,
                    //    UserId = msg.FromId,
                    //    //StickerId = a.Message.
                    //    Message = msg.Text,
                    //    RandomId = (int)msg.Id + 1,
                    //    //StickerId = msg.
                    //    //Keyboard = keyboard.Build()
                    //});
            }

            return new OkObjectResult("ok");
        }
    }
}