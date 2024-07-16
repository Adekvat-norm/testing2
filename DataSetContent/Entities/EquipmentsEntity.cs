using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Content.Library.Models.equipments;

namespace Content.DataSet.Entities
{
    public class EquipmentsEntity
    {
        public Guid equipment_id { get; set; }

        public int contract_id { get; set; }

        public int workplace_id { get; set; }

        public string inventory_number { get; set; }

        public string equipment_name { get; set; }

        public Equipment_status equipment_status { get; set; }

        public DateOnly purchase_date { get; set; }

        public int quantity { get; set; }

        public decimal price { get; set; }
    }
}
