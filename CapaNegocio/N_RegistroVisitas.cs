using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad.Modelos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_RegistroVisitas
    {
        //instancia
        D_RegistroVisitas Data = new D_RegistroVisitas();
        

        //metodo para listar todas las visitas
        public List<ModeloVisitas> GetVisitas()
        {
            return Data.GetVisitas();
        }
        //metodo para listar las visitas por id
        public List<E_RegistroVisitas> GetVisitasById(int id)
        {
            return Data.GetVisitasById(id);
        }

        //metodo para listar las visitas por edificio
        public List<ModeloVisitas> GetVisitasByEdificio(int edificio)
        {
            return Data.GetVisitasByEdificio(edificio);
        }
        //metodo para agregar una nueva visita
        public void AddVisita(E_RegistroVisitas visita)
        {
            Data.AddVisita(visita);
        }
        //metodo para editar una visita
        public void UpdateVisita(E_RegistroVisitas visita)
        {
            Data.UpdateVisita(visita);
        }
        //metodo para eliminar una visita
        public void DeleteVisita(E_RegistroVisitas visita)
        {
            Data.DeleteVisita(visita);
        }
    }
}
