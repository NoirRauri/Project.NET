using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class LicenciaChoferData : IData<TbLicenciaChofer>
    {
        private readonly MichaelABdContext _context;

        public LicenciaChoferData(MichaelABdContext context)
        {
            _context = context;
        }

        public async Task<bool> actualizar(TbLicenciaChofer entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> eliminar(TbLicenciaChofer entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<TbLicenciaChofer> guardar(TbLicenciaChofer entity)
        {
            try
            {
                _context.TbLicenciaChofers.Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<TbLicenciaChofer> obtenerPorId(TbLicenciaChofer entity)
        {
            try
            {
                return await _context.TbLicenciaChofers
                    .Where(x => x.IdTipoLicencia.Trim() == entity.IdTipoLicencia.Trim()).SingleOrDefaultAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<TbLicenciaChofer>> obtenerTodos()
        {
            try
            {
                return await _context.TbLicenciaChofers.ToListAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
