using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salondefiestas
{
    public class ReservaException:Exception
    {
        private string Motivo;
        public ReservaException(string motivo) { this.Motivo = motivo; }
    }
}
