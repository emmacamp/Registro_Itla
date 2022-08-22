using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_EdificiosItla
    {
        //instancia
        D_EdiciosItla Data = new D_EdiciosItla();

        //metodo para listar los nombres de cada edificio
        public List<E_EdiciosItla> GetNombreEdificios()
        {
            return Data.GetNombreEdificios();
        }

        //metodo para listar todos los edificios
        public List<E_EdiciosItla> GetEdificios()
        {
            return Data.GetEdificios();
        }

        //metodo para listar un edificio por id
        public List<E_EdiciosItla> GetEdificioById(int id)
        {
            return Data.GetEdificioById(id);
        }

        //metodo para agregar un nuevo edificio
        public void AddNewEdificio(E_EdiciosItla edificio)
        {
            Data.AddNewEdificio(edificio);
        }

        //metodo para editar un edifico
        public void UpdateEdificio(E_EdiciosItla edificio)
        {
            Data.UpdateEdificio(edificio);
        }

        //metodo para eliminar un edificio
        public void DeleteEdificio(E_EdiciosItla edificio)
        {
            Data.DeleteEdificio(edificio);
        }
    }
}
