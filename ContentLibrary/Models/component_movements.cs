using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Library.Models
{
    public class component_movements
    {

        public component_movements(Guid movement_id, int component_id, int old_location, int new_location, DateOnly movement_date, string movement_reason, int moved_by)
        {
            this.movement_id = movement_id;
            this.component_id = component_id;
            this.old_location = old_location;
            this.new_location = new_location;
            this.movement_date = movement_date;
            this.movement_reason = movement_reason;
            this.moved_by = moved_by;
        }

        public Guid movement_id { get; }

        public int component_id { get; }

        public int old_location { get; }

        public int new_location { get; }

        public DateOnly movement_date { get; }

        public string movement_reason { get; }

        public int moved_by { get; }
    }
}
