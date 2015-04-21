using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wmcb.model.View
{
    public class TeamView
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public UserView Contact1 { get; set; }
        public UserView Contact2 { get; set; }
        public UserView Contact3 { get; set; }
        public string TeamLink { get; set; }        
    }
}
