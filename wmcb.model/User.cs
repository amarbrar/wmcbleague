using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wmcb.model
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? PhotoID { get; set; }
        public string Phone { get; set; }
        public int? TeamID { get; set; }
    }
}
