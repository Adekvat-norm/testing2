using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.DataSet.Entities
{
    public class UsersEntity
    {
        public Guid user_id { get; set; }

        public string full_name { get; set; }

        public string contact_info { get; set; }
    }
}
