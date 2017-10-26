using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a numeric only field. This fired an error!";
        }
    }
}
