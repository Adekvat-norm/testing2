using System.ComponentModel.DataAnnotations;

namespace ContentLibrary.Models
{
    public class equipments
    {
        public const int Inventory_number_max_length = 50;
        public const int Equipment_name_max_length = 100;

        private equipments(Guid equipment_id, int contract_id, int workplace_id, string inventory_number, string equipment_name, Equipment_status equipment_status, DateOnly purchase_date, int quantity, decimal price)
        {
            this.equipment_id = equipment_id;
            this.contract_id = contract_id;
            this.workplace_id = workplace_id;
            this.inventory_number = inventory_number;
            this.equipment_name = equipment_name;
            this.equipment_status = equipment_status;
            this.purchase_date = purchase_date;
            this.quantity = quantity;
            this.price = price;
        }

        public enum Equipment_status
        {
            Готовое,
            Сборное
        }

        public Guid equipment_id { get; }

        public int contract_id {  get; }

        public int workplace_id {  get; }

        public string inventory_number { get; }

        public string equipment_name { get; }

        public Equipment_status equipment_status {  get; }

        public DateOnly purchase_date { get; }

        public int quantity {  get; }

        public decimal price {  get; }

        public static (equipments Equipment, string Error) Create(Guid equipment_id, int contract_id, int workplace_id, string inventory_number, string equipment_name, Equipment_status equipment_status, DateOnly purchase_date, int quantity, decimal price)
        {
            string error = string.Empty;

            var equipment = new equipments(equipment_id, contract_id, workplace_id, inventory_number, equipment_name, equipment_status, purchase_date, quantity, price);

            if (string.IsNullOrEmpty(inventory_number) || inventory_number.Length == Inventory_number_max_length)
            {
                error = "Строка пуста или превышает допустимое значение в 50 символов";
            }
            if (string.IsNullOrEmpty(equipment_name) || equipment_name.Length == Equipment_name_max_length)
            {
                error = "Строка пуста или превышает допустимое значение в 100 символов";
            }
            return(equipment, error);
        }
    }
}
