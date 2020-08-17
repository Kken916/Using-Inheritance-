using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_military
{
    public class CommShop
    {    
        public virtual string JobDesc()
        {
            return "This shop is: ";
        }
        public virtual string MOS()
        {
            return "MOS: ";
        }
        public virtual string Weapons()
        {
            return "weapon: ";
        }
        public virtual string Equipment()
        {
            return "equipment: ";
        }
    }
}
