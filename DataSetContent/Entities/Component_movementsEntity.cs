using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.DataSet.Entities
{
    public class Component_movementsEntity
    {
        public Guid movement_id { get; set; }

        public int component_id { get; set; }

        public int old_location { get; set; }

        public int new_location { get; set; }

        public DateOnly movement_date { get; set; }

        public string movement_reason { get; set; }

        public int moved_by { get; set; }
    }
}
