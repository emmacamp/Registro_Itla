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
    public class D_AulasItla
    {
        //Connection String
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        //Metodos CRUD

        //metodo para listar los nombres de las aulas del itla
        public List<E_AulaItla> GetNombreAulas()
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_SELECT_NOMBRE_AULAS", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                List<E_AulaItla> Listar = new List<E_AulaItla>();
                SqlDataReader reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    Listar.Add(new E_AulaItla
                    {
                        NombreAula = reader.GetString(0)
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

        //metodo para listar las aulas del itla
        public List<E_AulaItla> GetAulas()
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_SELECT_AULAS", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                List<E_AulaItla> Listar = new List<E_AulaItla>();
                SqlDataReader reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    Listar.Add(new E_AulaItla
                    {
                        IdAula = reader.GetInt32(0),
                        NombreAula = reader.GetString(1)
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
        //metodo para listar un aula del itla por id
        public List<E_AulaItla> GetAulaById(int id)
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_SELECT_AULA_BY_ID", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@ID", id);

                List<E_AulaItla> Listar = new List<E_AulaItla>();
                SqlDataReader reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    Listar.Add(new E_AulaItla
                    {
                        IdAula = reader.GetInt32(0),
                        NombreAula = reader.GetString(1)
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

        //metodo para agregar un nueva aula
        public void AddNewAula(E_AulaItla aula)
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_INSERT_AULA", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@NOMBRE_AULA", aula.NombreAula);

                cm.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        //metodo para editar un aula
        public void UpdateAula(E_AulaItla aula)
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_EDITAR_AULA", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@ID_AULA", aula.IdAula);
                cm.Parameters.AddWithValue("@NOMBRE_AULA", aula.NombreAula);

                cm.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        //metodo para eliminar un aula
        public void DeleteAula(E_AulaItla aula)
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_ELIMINAR_AULA", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@ID_AULA", aula.IdAula);

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
