using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_AulaItla
    {
        //instancia
        D_AulasItla Data = new D_AulasItla();

        //metodo para listar los nombres de las aulas
        public List<E_AulaItla> GetNombreAulas()
        {
            return Data.GetAulas();
        }
        //metodo para listar todas las aulas
        public List<E_AulaItla> GetAulas()
        {
            return Data.GetAulas();
        }
        //metodo para listar un aula por id
        public List<E_AulaItla> GetAulaById(int id)
        {
            return Data.GetAulaById(id);
        }
        //metodo para agregar un nueva aula
        public void AddNewAula(E_AulaItla aula)
        {
            Data.AddNewAula(aula);
        }
        //metodo para editar un aula
        public void UpdateAula(E_AulaItla aula)
        {
            Data.UpdateAula(aula);
        }
        //metodo para eliminar un aula
        public void DeleteAula(E_AulaItla aula)
        {
            Data.DeleteAula(aula);
        }
    }
}
