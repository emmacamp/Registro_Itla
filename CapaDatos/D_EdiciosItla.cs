using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D_EdiciosItla
    {
        //Connection String
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        //Metodos CRUD

        //metodo para listar los nombres de los edificios del itla
        public List<E_EdiciosItla> GetNombreEdificios()
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_SELECT_NOMBRE_EDIFICIOS", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                List<E_EdiciosItla> Listar = new List<E_EdiciosItla>();
                SqlDataReader reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    Listar.Add(new E_EdiciosItla
                    {
                        NombreEdificio = reader.GetString(0)
                    });
                }
                reader.Close();
                conexion.Close();
                return Listar;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        //metodo para listar los edificios del itla
        public List<E_EdiciosItla> GetEdificios()
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_SELECT_EDIFICIOS", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                List<E_EdiciosItla> Listar = new List<E_EdiciosItla>();
                SqlDataReader reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    Listar.Add(new E_EdiciosItla
                    {
                        IdEdificio = reader.GetInt32(0),
                        NombreEdificio = reader.GetString(1)
                    });
                }
                reader.Close();
                conexion.Close();
                return Listar;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        //metodo para listar un edificio by id
        public List<E_EdiciosItla> GetEdificioById(int id)
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_SELECT_EDIFICIO_BY_ID", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@ID_EDIFICIO", id);

                List<E_EdiciosItla> Listar = new List<E_EdiciosItla>();
                SqlDataReader reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    Listar.Add(new E_EdiciosItla
                    {
                        IdEdificio = reader.GetInt32(0),
                        NombreEdificio = reader.GetString(1)
                    });
                }
                reader.Close();
                conexion.Close();
                return Listar;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        //metodo para agregar un nuevo edificio
        public void AddNewEdificio(E_EdiciosItla edificio)
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_INSERT_EDIFICIO", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@NOMBRE_EDIFICIO", edificio.NombreEdificio);

                cm.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        //metodo para editar un edificio
        public void UpdateEdificio(E_EdiciosItla edificio)
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_EDITAR_EDIFICIO", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@ID_EDIFICIO", edificio.IdEdificio);
                cm.Parameters.AddWithValue("@NOMBRE_EDIFICIO", edificio.NombreEdificio);

                cm.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        //metodo para eliminar un edifico
        public void DeleteEdificio(E_EdiciosItla edificio)
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_ELIMINAR_EDIFICIO", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@ID_EDIFICIO", edificio.IdEdificio);

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
