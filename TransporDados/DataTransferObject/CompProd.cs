using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporDados.DataTransferObject
{
    public class CompProd
    {
        public string Codprod { get; set; } // char(6)
        public string Descricao { get; set; } // varchar(50)
        public double? Precocusto { get; set; } // double precision
        public DateTime? Datacustocalc { get; set; } // timestamp
    }
}
