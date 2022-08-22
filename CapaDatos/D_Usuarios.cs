using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;
using CapaEntidad.Modelos;
using System.Configuration;

namespace CapaDatos
{
    public class D_Usuarios
    {
        //Connection String
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        //methods crud of user

        //method para validar los usuarios
        public string[] ValidateUser(E_Usuarios user)
        {
            try
            {
                string[] userDetails = new string[3];
                SqlCommand cm = new SqlCommand("SP_VALIDATE_USER", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@USUARIO", user.Usuario);
                cm.Parameters.AddWithValue("@CONTRASEÑA", user.Contraseña);

                SqlDataReader reader = cm.ExecuteReader();
                if (reader.Read())
                {
                    userDetails[0] = reader.GetString(0);
                    userDetails[1] = reader.GetString(1);
                    userDetails[2] = Convert.ToString(reader.GetInt32(2));
                }
                reader.Close();
                conexion.Close();
                return userDetails;
            }
            catch (Exception err)
            {

                throw err;
            }
        }
        //Metodo para seleccionar los roles de usuario
        public List<E_RolUsuario> GetRoles()
        {
            SqlCommand cm = new SqlCommand("SP_SELECT_ROL", conexion);
            cm.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            List<E_RolUsuario> Listar = new List<E_RolUsuario>();
            SqlDataReader reader = cm.ExecuteReader();
            while(reader.Read())
            {
                Listar.Add(new E_RolUsuario
                {
                    RolUsuario = reader.GetString(0)
                });
            }
            reader.Close();
            conexion.Close();
            return Listar;

        }
        //metodo para listar todos los usuarios
        public List<ModeloUsuarios> GetUsuarios()
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_SELECT_USUARIOS", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                List<ModeloUsuarios> Lista = new List<ModeloUsuarios>();
                SqlDataReader reader = cm.ExecuteReader();
                while(reader.Read())
                {
                    Lista.Add(new ModeloUsuarios
                    {
                        IdUser = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Fecha_Nacimiento = reader.GetDateTime(3),
                        Usuario = reader.GetString(4),
                        Contraseña = reader.GetString(5),
                        RolUsuario = reader.GetString(6)
                    });
                }
                reader.Close();
                conexion.Close();
                return Lista;
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        //metodo para listar un solo usuario por id
        public List<E_Usuarios> GetUsuario(int id)
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_SELECT_USUARIO", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@Id", id);

                List<E_Usuarios> Lista = new List<E_Usuarios>();
                SqlDataReader reader = cm.ExecuteReader();
                if (reader.Read())
                {
                    Lista.Add(new E_Usuarios
                    {
                        IdUser = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Fecha_Nacimiento = reader.GetDateTime(3),
                        Usuario = reader.GetString(4),
                        Contraseña = reader.GetString(5),
                        IdRolUsuario = reader.GetInt32(6)
                    });
                }
                reader.Close();
                conexion.Close();
                return Lista;
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        //metodo para listar un solo usuario por usuario
        public List<ModeloUsuarios> GetUsuarioByUsuario(string usuario)
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_SELECT_BY_USUARIO", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@USUARIO", usuario);

                List<ModeloUsuarios> Lista = new List<ModeloUsuarios>();
                SqlDataReader reader = cm.ExecuteReader();
                while(reader.Read())
                {
                    Lista.Add(new ModeloUsuarios
                    {
                        IdUser = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Fecha_Nacimiento = reader.GetDateTime(3),
                        Usuario = reader.GetString(4),
                        Contraseña = reader.GetString(5),
                        RolUsuario = reader.GetString(6)
                    });
                }
                reader.Close();
                conexion.Close();
                return Lista;
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        //metodo para agregar un nuevo usuario
        public void AddNewUser(E_Usuarios usuario)
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_INSERT_USUARIO", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@NOMBRE", usuario.Nombre);
                cm.Parameters.AddWithValue("@APELLIDO", usuario.Apellido);
                cm.Parameters.AddWithValue("@FECHA_NACIMIENTO", usuario.Fecha_Nacimiento);
                cm.Parameters.AddWithValue("@USUARIO", usuario.Usuario);
                cm.Parameters.AddWithValue("@CONTRASEÑA", usuario.Contraseña);
                cm.Parameters.AddWithValue("@ID_ROL_USUARIO", usuario.IdRolUsuario);

                cm.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        //metodo para editar un usuario
        public void UpdateUser(E_Usuarios usuario)
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_EDITAR_USUARIO", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@ID_USUARIO", usuario.IdUser);
                cm.Parameters.AddWithValue("@NOMBRE", usuario.Nombre);
                cm.Parameters.AddWithValue("@APELLIDO", usuario.Apellido);
                cm.Parameters.AddWithValue("@FECHA_NACIMIENTO", usuario.Fecha_Nacimiento);
                cm.Parameters.AddWithValue("@USUARIO", usuario.Usuario);
                cm.Parameters.AddWithValue("@CONTRASEÑA", usuario.Contraseña);
                cm.Parameters.AddWithValue("@ID_ROL_USUARIO", usuario.IdRolUsuario);

                cm.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }
        //metodo para eliminar un usuario
        public void DeleteUser(E_Usuarios usuario)
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_ELIMINAR_USUARIO", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@ID_USUARIO", usuario.IdUser);

                cm.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }
    }
}
