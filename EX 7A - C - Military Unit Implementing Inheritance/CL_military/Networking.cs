using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_military
{
    public class Networking : CommShop
    {
        public override string JobDesc()
        {
            return "Networking";
        }
        public override string MOS()
        {
            return "0631";
        }
        public override string Weapons()
        {
            return "M4";
        }
        public override string Equipment()
        {
            return "routers";
        }
    }
}
