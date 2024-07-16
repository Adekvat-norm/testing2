using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.DataSet.Entities
{
    public class SuppliersEntity
    {
        public Guid supplier_id { get; set; }

        public string supplier_name { get; set; }

        public string phone { get; set; }

        public string email { get; set; }
    }
}
