using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_military
{
    public class Techs : CommShop
    {
        public override string JobDesc()
        {
            return "Techs";
        }
        public override string MOS()
        {
            return "2841";
        }
        public override string Weapons()
        {
            return "Glocks";
        }
        public override string Equipment()
        {
            return "Tool box";
        }
    }
}
