using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.DataSet.Entities
{
    public class ContractsEntity
    {
        public Guid contract_id { get; set; }

        public string contract_number { get; set; }

        public DateOnly contract_date { get; set; }
        public int supplier_id { get; set; }
    }
}
