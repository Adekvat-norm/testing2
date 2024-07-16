using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.DataSet.Entities
{
    public class Equipment_movementsEntity
    {
        public Guid movement_id { get; set; }

        public int equipment_id { get; set; }

        public int old_location { get; set; }

        public int new_location { get; set; }

        public DateOnly movement_date { get; set; }

        public string movement_reason { get; set; }
    }
}
