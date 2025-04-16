using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBEID.Exceptions
{
    public class IncorectDokValueException
    {
        private readonly string[] FieldNames = { "idkontrah", "data", "nazwadok", "nrdok",
            "termin", "platnosc", "suma", "ilepoz", "gotowka", "dot_data", "dot_nazwadok",
            "dot_nrdok", "anulowany", "uwagi", "nrzlec", "cecha_1", "cecha_2", "cecha_3",
            "idkontrahodb", "dataobow", "cecha_4", "cecha_5", "idkontrahdost", "magazyn",
            "wydrukowany", "zafiskalizowany" };

        public int FieldPosition { get; set; }
        
    }
}
