using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Builder.Model
{
    public sealed class TelefoneModel
    {
        public Int32 Codigo { get; set; }

        public String DDD { get; set; }

        public String Numero { get; set; }

        public String Operadora { get; set; }
    }
}
