using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_AulaItla
    {
        private int _IdAula;
        private string _NombreAula;

        public int IdAula { get => _IdAula; set => _IdAula = value; }
        public string NombreAula { get => _NombreAula; set => _NombreAula = value; }
    }
}
