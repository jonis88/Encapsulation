using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class NullInputError : UserError
    {
        public override string UEMessage()
        {
            return "Your tried to input null or empty value in a requied field. This fired an error!";
        }
    }
}
