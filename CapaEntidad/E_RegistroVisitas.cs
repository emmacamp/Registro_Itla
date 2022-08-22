using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_RegistroVisitas
    {
        private int _IdVisita;
		private string _Nombre;
		private string _Apellido;
		private string _Carrera;
		private string _Correo;
		private DateTime _HoraEntrada;
		private DateTime _HoraSalida;
	    private string _MotivoVisita;
		private int _IdEdificio;
	    private int _IdAula;

        public int IdVisita { get => _IdVisita; set => _IdVisita = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Carrera { get => _Carrera; set => _Carrera = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public DateTime HoraEntrada { get => _HoraEntrada; set => _HoraEntrada = value; }
        public DateTime HoraSalida { get => _HoraSalida; set => _HoraSalida = value; }
        public string MotivoVisita { get => _MotivoVisita; set => _MotivoVisita = value; }
        public int IdEdificio { get => _IdEdificio; set => _IdEdificio = value; }
        public int IdAula { get => _IdAula; set => _IdAula = value; }
    }
}
