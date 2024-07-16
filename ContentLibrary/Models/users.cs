using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Library.Models
{
    public class users
    {
        public const int Full_name_max_length = 100;
        public const int Contact_info_max_length = 100;
        private users(Guid user_id, string full_name, string contact_info)
        {
            this.user_id = user_id;
            this.full_name = full_name;
            this.contact_info = contact_info;
        }

        public Guid user_id { get; }

        public string full_name { get; }

        public string contact_info { get; }

        public static (users user, string Error) Create(Guid user_id, string full_name, string contact_info)
        {
            string error = string.Empty;

            var users = new users(user_id, full_name, contact_info);

            if (string.IsNullOrEmpty(full_name) || full_name.Length == Full_name_max_length)
            {
                error = "Строка пуста или превышает допустимое значение в 100 символов";
            }
            if (string.IsNullOrEmpty(contact_info) || contact_info.Length == Contact_info_max_length)
            {
                error = "Строка пуста или превышает допустимое значение в 100 символов";
            }
            return (users, error);
        }
    }
}
