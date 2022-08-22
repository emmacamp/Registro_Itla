using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Modelos
{
    public class ModeloUsuarios
    {
        private int _IdUser;
        private string _Nombre;
        private string _Apellido;
        private DateTime _Fecha_Nacimiento;
        private string _Usuario;
        private string _Contraseña;
        private string _RolUsuario;

        public int IdUser { get => _IdUser; set => _IdUser = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public DateTime Fecha_Nacimiento { get => _Fecha_Nacimiento; set => _Fecha_Nacimiento = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Contraseña { get => _Contraseña; set => _Contraseña = value; }
        public string RolUsuario { get => _RolUsuario; set => _RolUsuario = value; }
    }
}
