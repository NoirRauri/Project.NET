using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TipoLicenciaService : IService<TbTipoLicencium>
    {
        private readonly IData<TbTipoLicencium> _tipoLicenciaData;

        public TipoLicenciaService(IData<TbTipoLicencium> tipoLicenciaData)
        {
            _tipoLicenciaData = tipoLicenciaData;
        }

        public async Task<bool> actualizar(TbTipoLicencium entity)
        {
            return await _tipoLicenciaData.actualizar(entity);
        }

        public async Task<bool> eliminar(TbTipoLicencium entity)
        {
            return await _tipoLicenciaData.eliminar(entity);
        }

        public async Task<TbTipoLicencium> guardar(TbTipoLicencium entity)
        {
            return await _tipoLicenciaData.guardar(entity);
        }

        public async Task<TbTipoLicencium> obtenerPorId(TbTipoLicencium entity)
        {
            return await _tipoLicenciaData.obtenerPorId(entity);
        }

        public async Task<List<TbTipoLicencium>> obtenerTodos()
        {
            return await _tipoLicenciaData.obtenerTodos();
        }
    }
}
