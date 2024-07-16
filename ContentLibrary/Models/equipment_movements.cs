using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ContentLibrary.Models.equipments;

namespace ContentLibrary.Models
{
    public class equipment_movements
    {
        public equipment_movements(Guid movement_id, int equipment_id, int old_location, int new_location, DateOnly movement_date, string movement_reason)
        {
            this.movement_id = movement_id;
            this.equipment_id = equipment_id;
            this.old_location = old_location;
            this.new_location = new_location;
            this.movement_date = movement_date;
            this.movement_reason = movement_reason;
        }

        public Guid movement_id { get; }

        public int equipment_id { get; }

        public int old_location { get; }

        public int new_location { get; }

        public DateOnly movement_date { get; }

        public string movement_reason { get; }

        
    }
}
