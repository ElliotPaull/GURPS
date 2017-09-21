using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuipsSheet
{
    class Attributes
    {
        public int Wrap30(int attributeValue)
        {
            if (attributeValue > 30)
            {
                return 1;
            }

            if (attributeValue == 0)
            {
                return 30;
            }

            return attributeValue;
        }
    }
}
