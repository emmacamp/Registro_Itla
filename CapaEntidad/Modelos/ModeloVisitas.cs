using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Modelos
{
    public class ModeloVisitas
    {
        private int _Id_Visita;
        private string _Nombre;
        private string _Apellido;
        private string _Carrera;
        private string _Correo;
        private DateTime _Hora_Entrada;
        private DateTime _Hora_Salida;
        private string _Motivo_Visita;
        private string _Nombre_Edificio;
        private string _Nombre_Aula;

        public int Id_Visita { get => _Id_Visita; set => _Id_Visita = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Carrera { get => _Carrera; set => _Carrera = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public DateTime Hora_Entrada { get => _Hora_Entrada; set => _Hora_Entrada = value; }
        public DateTime Hora_Salida { get => _Hora_Salida; set => _Hora_Salida = value; }
        public string Motivo_Visita { get => _Motivo_Visita; set => _Motivo_Visita = value; }
        public string Nombre_Edificio { get => _Nombre_Edificio; set => _Nombre_Edificio = value; }
        public string Nombre_Aula { get => _Nombre_Aula; set => _Nombre_Aula = value; }
    }
}

