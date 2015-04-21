using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wmcb.model.View
{
    public class UserView
    {
        public int? ID { get; set; }
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public string Email { get; set; }
        public string PhotoLink { get; set; }
        public string Phone { get; set; }
        public string TeamName { get; set; }
    }
}
