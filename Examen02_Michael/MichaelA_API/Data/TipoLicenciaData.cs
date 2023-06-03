using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class TipoLicenciaData : IData<TbTipoLicencium>
    {
        private readonly MichaelABdContext _context;

        public TipoLicenciaData(MichaelABdContext context)
        {
            _context = context;
        }

        public async Task<bool> actualizar(TbTipoLicencium entity)
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

        public async Task<bool> eliminar(TbTipoLicencium entity)
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

        public async Task<TbTipoLicencium> guardar(TbTipoLicencium entity)
        {
            try
            {
                _context.TbTipoLicencia.Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<TbTipoLicencium> obtenerPorId(TbTipoLicencium entity)
        {
            try
            {
                return await _context.TbTipoLicencia.Where(x => x.IdTipoLicencia.Trim() == entity.IdTipoLicencia.Trim()).Include("TbLicenciaChofers").SingleOrDefaultAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<TbTipoLicencium>> obtenerTodos()
        {
            try
            {
                return await _context.TbTipoLicencia.Include("TbLicenciaChofers").ToListAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
