using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Library.Models
{
    public class contracts
    {
        public const int Contract_number_max_length = 50;

        private contracts(Guid contract_id, string contract_number, DateOnly contract_date, int supplier_id)
        {
            this.contract_id = contract_id;
            this.contract_number = contract_number;
            this.contract_date = contract_date;
            this.supplier_id = supplier_id;
        }

        public Guid contract_id { get; }

        public string contract_number { get; }

        public DateOnly contract_date { get; }
        public int supplier_id { get; }

        public static (contracts contracts, string Error) Create(Guid contract_id, string contract_number, DateOnly contract_date, int supplier_id)
        {
            string error = string.Empty;

            if (string.IsNullOrEmpty(contract_number) || contract_number.Length == Contract_number_max_length)
            {
                error = "Строка пуста или превышает допустимое значение в 50 символов";
            }

            var contract = new contracts(contract_id, contract_number, contract_date, supplier_id);

            return (contract, error);
        }
    }
}
