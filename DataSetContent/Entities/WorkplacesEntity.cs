using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.DataSet.Entities
{
    public class WorkplacesEntity
    {
        public Guid workplace_id { get; set; }

        public string workplace_number { get; set; }

        public string workplace_name { get; set; }

        public int user_id { get; set; }

        public int audience_id { get; set; }
    }
}
