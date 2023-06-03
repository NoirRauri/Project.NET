using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ChoferData : IData<TbChofer>
    {
        private readonly MichaelABdContext _context;

        public ChoferData(MichaelABdContext context)
        {
            _context = context;
        }

        public async Task<bool> actualizar(TbChofer entity)
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

        public async Task<bool> eliminar(TbChofer entity)
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

        public async Task<TbChofer> guardar(TbChofer entity)
        {
            try
            {
                _context.TbChofers.Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<TbChofer> obtenerPorId(TbChofer entity)
        {
            try
            {
                return await _context.TbChofers
                    .Where(x => x.Cedula.Trim() == entity.Cedula.Trim()).Include("TbLicenciaChofers").SingleOrDefaultAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<TbChofer>> obtenerTodos()
        {
            try
            {
                return await _context.TbChofers.Include("TbLicenciaChofers").ToListAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
