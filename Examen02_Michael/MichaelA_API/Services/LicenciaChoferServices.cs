using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LicenciaChoferServices : IService<TbLicenciaChofer>
    {
        private readonly IData<TbLicenciaChofer> _licenciaChoferData;

        public LicenciaChoferServices(IData<TbLicenciaChofer> licenciaChoferData)
        {
            _licenciaChoferData = licenciaChoferData;
        }

        public async Task<bool> actualizar(TbLicenciaChofer entity)
        {
            return await _licenciaChoferData.actualizar(entity);
        }

        public async Task<bool> eliminar(TbLicenciaChofer entity)
        {
            return await _licenciaChoferData.eliminar(entity);
        }

        public async Task<TbLicenciaChofer> guardar(TbLicenciaChofer entity)
        {
            return await _licenciaChoferData.guardar(entity);
        }

        public async Task<TbLicenciaChofer> obtenerPorId(TbLicenciaChofer entity)
        {
            return await _licenciaChoferData.obtenerPorId(entity);
        }

        public async Task<List<TbLicenciaChofer>> obtenerTodos()
        {
            return await _licenciaChoferData.obtenerTodos();
        }
    }
}
