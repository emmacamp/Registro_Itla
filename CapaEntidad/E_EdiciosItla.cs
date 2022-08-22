using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_EdiciosItla
    {
        private int _IdEdificio;
        private string _NombreEdificio;

        public int IdEdificio { get => _IdEdificio; set => _IdEdificio = value; }
        public string NombreEdificio { get => _NombreEdificio; set => _NombreEdificio = value; }
    }
}
