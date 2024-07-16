using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Library.Models
{
    public class workplaces
    {
        public const int Workplace_number_max_length = 50;
        public const int Workplace_name_max_length = 100;
        private workplaces(Guid workplace_id, string workplace_number, string workplace_name, int user_id, int audience_id)
        {
            this.workplace_id = workplace_id;
            this.workplace_number = workplace_number;
            this.workplace_name = workplace_name;
            this.user_id = user_id;
            this.audience_id = audience_id;
        }

        public Guid workplace_id { get; }

        public string workplace_number { get; }

        public string workplace_name { get; }

        public int user_id { get; }

        public int audience_id { get; }

        public static (workplaces workplace, string Error) Create(Guid workplace_id, string workplace_number, string workplace_name, int user_id, int audience_id)
        {
            string error = string.Empty;

            var workplaces = new workplaces(workplace_id, workplace_number, workplace_name, user_id, audience_id);

            if (string.IsNullOrEmpty(workplace_number) || workplace_number.Length == Workplace_number_max_length)
            {
                error = "Строка пуста или превышает допустимое значение в 50 символов";
            }
            if (string.IsNullOrEmpty(workplace_name) || workplace_number.Length == Workplace_number_max_length)
            {
                error = "Строка пуста или превышает допустимое значение в 100 символов";
            }
            return (workplaces, error);
        }
    }
}
