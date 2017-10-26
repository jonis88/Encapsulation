using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class DateInputError : UserError
    {
        public override string UEMessage()
        {
            return "Your tried to use a wrong format in a date time only field. This fired an error!";
        }
    }
}
