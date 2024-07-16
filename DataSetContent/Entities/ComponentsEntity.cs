using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.DataSet.Entities
{
    public class ComponentsEntity
    {
        public Guid component_id { get; set; }

        public int contract_id { get; set; }

        public int equipment_id { get; set; }

        public string nomenclature_number { get; set; }

        public string component_name { get; set; }

        public int quantity { get; set; }

        public decimal price { get; set; }

        public int user_id { get; set; }

        public string compatibility { get; set; }

        public int current_location { get; set; }
    }
}
