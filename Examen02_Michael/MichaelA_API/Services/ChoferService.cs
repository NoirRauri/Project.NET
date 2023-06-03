using Azure.Messaging;
using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Services
{
    public class ChoferService : IService<TbChofer>
    { 
        private readonly IData<TbChofer> _chofersData;

        public ChoferService(IData<TbChofer> chofersData)
        {
            _chofersData = chofersData;
        }

        public async Task<bool> actualizar(TbChofer entity)
        {
            return await _chofersData.actualizar(entity);
        }

        public async Task<bool> eliminar(TbChofer entity)
        {
            return await _chofersData.eliminar(entity);
        }

        public async Task<TbChofer> guardar(TbChofer entity)
        {
            try
            {
                if (entity.Cedula.Length > 12 || entity.Cedula.Length<5)
                {
                    throw new ArgumentException("La longitud de la cédula es incorrecta");
                }
                else
                {
                    return await _chofersData.guardar(entity);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TbChofer> obtenerPorId(TbChofer entity)
        {
            return await _chofersData.obtenerPorId(entity);
        }

        public async Task<List<TbChofer>> obtenerTodos()
        {
            return await _chofersData.obtenerTodos();
        }
    }
}
