using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class EmailInputError : UserError
    {
        public override string UEMessage()
        {
            return "Your tried to input wrong format in an email requied field. This fired an error!";
        }
    }
}
