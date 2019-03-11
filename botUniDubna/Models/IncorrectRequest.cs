using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace botUniDubna.Models
{
    public class IncorrectRequest
    {
        private Random rnd;

        public string RandomIncorrectRequest()
        {
            List<string> responses = new List<string>()
            {
                "Прошу прощения, не могу ответить на эту команду... :С",
                "Мне непонятно, что Вы хотели от меня... :(",
                "Кажется, Вы ввели некорректную команду, которую я не понял... :'("
            };

            rnd = new Random();

            return responses[rnd.Next(0, responses.Count() - 1)];
        }
    }
}
