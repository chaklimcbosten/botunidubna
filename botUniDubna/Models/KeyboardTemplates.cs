using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VkNet.Enums.SafetyEnums;
using VkNet.Model.Keyboard;

namespace botUniDubna.Models
{
    public class KeyboardTemplates
    {
        public KeyboardBuilder MainMenu()
        {
            var keyboard = new KeyboardBuilder();

            keyboard.AddButton("Новости", "Новости", KeyboardButtonColor.Primary);
            //keyboard.AddButton("Абитуриенту", "расписание", KeyboardButtonColor.Negative);
            keyboard.AddButton("Расписание", "Расписание", KeyboardButtonColor.Primary);
            keyboard.AddLine();
            keyboard.AddButton("Мои настройки", "Мои настройки");

            return keyboard;
        }

        public KeyboardBuilder Schedule()
        {
            var keyboard = new KeyboardBuilder();

            keyboard.SetOneTime();
            //keyboard.AddButton("Сегодня", "Расписание -> Сегодня", KeyboardButtonColor.Primary);
            keyboard.AddButton("Завтра", "Расписание -> Завтра", KeyboardButtonColor.Primary);
            keyboard.AddButton("Неделя", "Расписание -> Неделя", KeyboardButtonColor.Primary);
            keyboard.AddLine();
            keyboard.AddButton("В главное меню", "Расписание -> Главное меню", KeyboardButtonColor.Default);

            return keyboard;
        }

        public KeyboardBuilder DialogInDevelopment()
        {
            var keyboard = new KeyboardBuilder();

            keyboard.SetOneTime();
            keyboard.AddButton("В главное меню", "Расписание -> Главное меню", KeyboardButtonColor.Default);

            return keyboard;
        }
    }
}
