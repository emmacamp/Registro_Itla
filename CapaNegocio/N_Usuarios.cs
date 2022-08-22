using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using CapaEntidad.Modelos;

namespace CapaNegocio
{
    public class N_Usuarios
    {
        //instancia de la clase usuario de la capa categoria
        D_Usuarios dataUser = new D_Usuarios();

        //method for validate de user
        public string[] ValidateUser(E_Usuarios user)
        {
            return dataUser.ValidateUser(user);
        }
        //metodo para listar los roles de usuario
        public List<E_RolUsuario> GetRoles()
        {
            return dataUser.GetRoles();
        }
        //metodo para listar todos los usuarios
        public List<ModeloUsuarios> GetUsuarios()
        {
            return dataUser.GetUsuarios();
        }

        //metodo para listar un solo usuario por id
        public List<E_Usuarios> GetUsuario(int id)
        {
            return dataUser.GetUsuario(id);
        }

        //metodo para listar un solo usuario por usuario
        public List<ModeloUsuarios> GetUsuarioByUsuario(string usuario)
        {
            return dataUser.GetUsuarioByUsuario(usuario);
        }

        //metodo para agregar un nuevo usuario
        public void AddNewUser(E_Usuarios usuario)
        {
            dataUser.AddNewUser(usuario);
        }

        //metodo para editar un usuario
        public void UpdateUser(E_Usuarios usuario)
        {
            dataUser.UpdateUser(usuario);
        }

        //metodo para eliminar un usuario
        public void DeleteUser(E_Usuarios usuario)
        {
            dataUser.DeleteUser(usuario);
        }
    }
}
