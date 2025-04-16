using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBEID.PCBDataTypes
{
    internal class PCBInt : PCBGenericDataType
    {
        public PCBInt(int fieldPos) : base(fieldPos)
        {
        }

        public override bool IsValid()
        {
            bool ret = false;
            if (value != null)
            {
                int charCount = 0;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsNumber(value.ElementAt(i)))
                    {
                        charCount++;
                    }
                }
                ret = (charCount == value.Length) && (value.Length > 0);
            }
            return ret;
        }

        public override string ToString()
        {
            return IsValid() ? value : "0";
        }

    }
}
