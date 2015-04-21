using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wmcb.model.Data;

namespace wmcb.repo
{
    public class GroundRepo
    {
        public List<Ground> GetGrounds()
        {
            using (var context = new wmcbContext())
            {
                return context.Grounds
                        .Where(g=>g.Active==true)
                        .OrderBy(g=>g.Name).ToList();                
            }
        }
    }
}
