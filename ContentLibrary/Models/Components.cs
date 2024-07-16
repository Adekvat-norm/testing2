using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace Testing.Models
{
    public class Components
    {

        public const int Nomenclature_number_max_length = 20;
        public const int Component_name_max_length = 100;
        public const int Compatibility_max_length = 200;

        private Components(Guid component_id, int contract_id, int equipment_id, string nomenclature_number, string component_name, int quantity, decimal price, int user_id, string compatibility,
            int current_location)
        {
            this.component_id = component_id;
            this.contract_id = contract_id;
            this.equipment_id = equipment_id;
            this.nomenclature_number = nomenclature_number;
            this.component_name = component_name;
            this.quantity = quantity;
            this.price = price;
            this.user_id = user_id;
            this.compatibility = compatibility;
            this.current_location = current_location;
        } 
        public Guid component_id { get; }

        public int contract_id { get; }

        public int equipment_id { get; }

        public string nomenclature_number {  get; }

        public string component_name { get; }

        public int quantity {  get; }

        public decimal price { get; }

        public int user_id { get; }

        public string compatibility { get; }

        public int current_location { get; }

        public static (Components Component, string Error) Create(Guid component_id, int contract_id, int equipment_id, string nomenclature_number, string component_name, int quantity, decimal price, int user_id, string compatibility,
            int current_location)
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(nomenclature_number) || nomenclature_number.Length == Nomenclature_number_max_length)
            {
                error = "Строка пуста или превышает допустимое значение в 20 символов";
            }
            if (string.IsNullOrEmpty(component_name) || component_name.Length == Component_name_max_length)
            {
                error = "Строка пуста или превышает допустимое значение в 100 символов";
            }
            if (string.IsNullOrEmpty(compatibility) || compatibility.Length == Compatibility_max_length)
            {
                error = "Строка пуста или превышает допустимое значение в 200 символов";
            }

            var components = new Components(component_id, contract_id, equipment_id, nomenclature_number, component_name, quantity, price, user_id, compatibility, current_location);

            return (components, error);
        }
    }
}
