using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_military
{
    public class Radio : CommShop
    {
        public override string JobDesc()
        {
            return "Radio";
        }
        public override string MOS()
        {
            return "0621";
        }
        public override string Weapons()
        {
            return "M4A1";
        }
        public override string Equipment()
        {
            return "prc - 117f";
        }
    }
}
