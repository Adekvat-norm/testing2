using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentLibrary.Models
{
    public class suppliers
    {
        public const int Supplier_name_max_length = 100;
        public const int Phone_max_length = 20;
        public const int Email_max_length = 50;
        private suppliers(Guid supplier_id, string supplier_name, string phone, string email)
        {
            this.supplier_id = supplier_id;
            this.supplier_name = supplier_name;
            this.phone = phone;
            this.email = email;
        }

        public Guid supplier_id { get; }

        public string supplier_name { get; }

        public string phone { get; }

        public string email { get; }

        public static (suppliers supplier, string Error) Create(Guid supplier_id, string supplier_name, string phone, string email)
        {
            string error = string.Empty;

            var supplier = new suppliers(supplier_id, supplier_name, phone, email);

            if (string.IsNullOrEmpty(supplier_name) || supplier_name.Length == Supplier_name_max_length)
            {
                error = "Строка пуста или превышает допустимое значение в 100 символов";
            }
            if (string.IsNullOrEmpty(phone) || phone.Length == Phone_max_length)
            {
                error = "Строка пуста или превышает допустимое значение в 20 символов";
            }
            if (string.IsNullOrEmpty(email) || email.Length == Email_max_length)
            {
                error = "Строка пуста или превышает допустимое значение в 50 символов";
            }
            return (supplier, error);
        }
    }
}
