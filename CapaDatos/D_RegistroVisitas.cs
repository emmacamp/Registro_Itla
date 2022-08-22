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
    public class D_RegistroVisitas
    {
        //Connection String
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        //Metodos CRUD

        //metodo traer todas las visitas.
        public List<ModeloVisitas> GetVisitas()
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_SELECT_VISITAS", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                List<ModeloVisitas> Listar = new List<ModeloVisitas>();
                SqlDataReader reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    Listar.Add(new ModeloVisitas
                    {
                        Id_Visita = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Carrera = reader.GetString(3),
                        Correo = reader.GetString(4),
                        Hora_Entrada = reader.GetDateTime(5),
                        Hora_Salida = reader.GetDateTime(6),
                        Motivo_Visita = reader.GetString(7),
                        Nombre_Edificio = reader.GetString(8),
                        Nombre_Aula = reader.GetString(9)
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
        //metodo para listar las visitas por id
        public List<E_RegistroVisitas> GetVisitasById(int id)
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_SELECT_VISITAS_BY_ID", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@ID_VISITA", id);

                List<E_RegistroVisitas> Listar = new List<E_RegistroVisitas>();
                SqlDataReader reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    Listar.Add(new E_RegistroVisitas
                    {
                        IdVisita = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Carrera = reader.GetString(3),
                        Correo = reader.GetString(4),
                        HoraEntrada = reader.GetDateTime(5),
                        HoraSalida = reader.GetDateTime(6),
                        MotivoVisita = reader.GetString(7),
                        IdEdificio = reader.GetInt32(8),
                        IdAula = reader.GetInt32(9)
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
        //metodo para listar las visitas por edificio
        public List<ModeloVisitas> GetVisitasByEdificio(int edificio)
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_SELECT_VISITAS_BY_EDIFICIO", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@EDIFICIO", edificio);

                List<ModeloVisitas> Listar = new List<ModeloVisitas>();
                SqlDataReader reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    Listar.Add(new ModeloVisitas
                    {
                        Id_Visita = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Carrera = reader.GetString(3),
                        Correo = reader.GetString(4),
                        Hora_Entrada = reader.GetDateTime(5),
                        Hora_Salida = reader.GetDateTime(6),
                        Motivo_Visita = reader.GetString(7),
                        Nombre_Edificio = reader.GetString(8),
                        Nombre_Aula = reader.GetString(9)
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
        //metodo para registrar una nueva visita
        public void AddVisita(E_RegistroVisitas visita)
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_INSERT_VISITA", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@Nombre", visita.Nombre);
                cm.Parameters.AddWithValue("@Apellido", visita.Apellido);
                cm.Parameters.AddWithValue("@Carrera", visita.Carrera);
                cm.Parameters.AddWithValue("@Correo", visita.Correo);
                cm.Parameters.AddWithValue("@Hora_Entrada", visita.HoraEntrada);
                cm.Parameters.AddWithValue("@Hora_Salida", visita.HoraSalida);
                cm.Parameters.AddWithValue("@Motivo_Visita", visita.MotivoVisita);
                cm.Parameters.AddWithValue("Id_Edificio", visita.IdEdificio);
                cm.Parameters.AddWithValue("Id_Aula", visita.IdAula);

                cm.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        //metodo para editar una visita
        public void UpdateVisita(E_RegistroVisitas visita)
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_EDITAR_VISITA", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@ID_VISITA", visita.IdVisita);
                cm.Parameters.AddWithValue("@Nombre", visita.Nombre);
                cm.Parameters.AddWithValue("@Apellido", visita.Apellido);
                cm.Parameters.AddWithValue("@Carrera", visita.Carrera);
                cm.Parameters.AddWithValue("@Correo", visita.Correo);
                cm.Parameters.AddWithValue("@Hora_Entrada", visita.HoraEntrada);
                cm.Parameters.AddWithValue("@Hora_Salida", visita.HoraSalida);
                cm.Parameters.AddWithValue("@Motivo_Visita", visita.MotivoVisita);
                cm.Parameters.AddWithValue("Id_Edificio", visita.IdEdificio);
                cm.Parameters.AddWithValue("Id_Aula", visita.IdAula);

                cm.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        //metodo para eliminar una visita
        public void DeleteVisita(E_RegistroVisitas visita)
        {
            try
            {
                SqlCommand cm = new SqlCommand("SP_ELIMINAR_VISITA", conexion);
                cm.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cm.Parameters.AddWithValue("@ID_VISITA", visita.IdVisita);

                cm.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception er)
            {

                throw er;
            }
        }
    }
}
