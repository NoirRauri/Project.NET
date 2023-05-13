using BusinessLayer.Interface;
using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AutomovilBL : IAutomovilBL<tbAutomovil>
    {
        AutomovilDL IAutomovilDL = new AutomovilDL();
        public bool eliminar(tbAutomovil entity)
        {
            try
            {
                return IAutomovilDL.eliminar(entity);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public tbAutomovil guardar(tbAutomovil entity)
        {
            try
            {
                return IAutomovilDL.guardar(entity);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool modificar(tbAutomovil entity)
        {
            try
            {
                return IAutomovilDL.modificar(entity);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public tbAutomovil obtenerPorID(tbAutomovil entity)
        {
            try
            {
                return IAutomovilDL.obtenerPorID(entity);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<tbAutomovil> obtenerTodos()
        {
            try
            {
                return IAutomovilDL.obtenerTodos();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
