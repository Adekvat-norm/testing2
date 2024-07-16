using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Library.Models
{
    public class audiences
    {
        public const int Audience_number_max_length = 10;
        private audiences(Guid audience_id, string audience_number)
        {
            this.audience_id = audience_id;
            this.audience_number = audience_number;
        }

        public Guid audience_id { get; }
        public string audience_number { get; }

        public static (audiences audiences, string Error) Create(Guid audience_id, string audience_number)
        {
            string error = string.Empty;

            var audience = new audiences(audience_id, audience_number);

            if (string.IsNullOrEmpty(audience_number) || audience_number.Length == Audience_number_max_length)
            {
                error = "Строка пуста или превышает допустимое значение в 10 символов";
            }

            return (audience, error);
        }
    }
}
