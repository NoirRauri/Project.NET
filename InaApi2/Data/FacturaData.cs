using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class FacturaData : IData<TbFactura>
    {
        private readonly IData<TbProducto> _productoData;
        private readonly IData<TbDetalleFactura> _DetalleFacturaData;
        private readonly DbProyectoInaContext _context;
        public FacturaData(IData<TbProducto> productoData, IData<TbDetalleFactura> detalleFacturaData, DbProyectoInaContext context)
        {
            _productoData = productoData;
            _DetalleFacturaData = detalleFacturaData;
            _context = context;
        }

        public async Task<bool> actualizar(TbFactura entity)
        {
            try
            {
                TbProducto producto;
                var detallesConProductos = await _context.TbDetalleFacturas
                                            .Include("IdProductoNavigation")
                                            .Where(df => df.IdFactura == entity.IdFactura)
                                            .ToListAsync();

                foreach (var detalle in entity.TbDetalleFacturas)
                {
                    var actualice = false;
                    producto = await _context.TbProductos
                        .Where(x => x.IdProducto == detalle.IdProducto && x.Estado == true)
                        .SingleOrDefaultAsync();

                    var detalleExistente = detallesConProductos.FirstOrDefault(df => df.IdDetalleFactura == detalle.IdDetalleFactura);

                    if (detalleExistente != null)
                    {
                        if (detalleExistente.Cant > detalle.Cant)
                        {
                            producto.Stock += detalleExistente.Cant - detalle.Cant;
                            actualice = true;
                        }
                        else if (detalleExistente.Cant < detalle.Cant)
                        {
                            producto.Stock -= detalle.Cant - detalleExistente.Cant;
                            actualice = true;
                        }

                        _context.Entry(detalle).State = EntityState.Modified;
                    }
                    else
                    {
                        _context.Entry(detalle).State = EntityState.Added;
                        producto.Stock -= detalle.Cant;
                        actualice = true;
                    }

                    if (actualice)
                    {
                        _context.Entry(producto).State = EntityState.Modified;
                    }
                }

                //// instacias
                //TbDetalleFactura dtf = new TbDetalleFactura();
                //TbProducto producto = new TbProducto();
                //// bandera para actualizar el producto
                //bool actualice;

                //// Modifica y/o agrega detalles a Factura y Modifca el Stock en Productos 
                //foreach (var detalle in entity.TbDetalleFacturas)
                //{
                //    actualice = false; // actualiza si cambia a true

                //    producto = await _context.TbProductos
                //        .Where(x => x.IdProducto == detalle.IdProducto && x.Estado == true).SingleOrDefaultAsync();

                //    if (detalle.IdDetalleFactura!=0) // si el idDetalleFactura es 0 es nuevo
                //    {
                //        // instacia el detalle factura de la BD por el ID
                //        dtf = await _context.TbDetalleFacturas
                //            .Where(x => x.IdDetalleFactura == detalle.IdDetalleFactura && x.Estado == true)
                //            .AsNoTracking().SingleOrDefaultAsync(); // para que ni trakee los nulls

                //        /* compara los datos de la BD con los datos del DTO en cada detalle
                //           si es mayor se le suma al stock, si es menor le resta, de lo contrario queda igual */
                //        if (dtf.Cant > detalle.Cant)
                //        {
                //            producto.Stock = producto.Stock + (dtf.Cant - detalle.Cant);
                //            actualice = true;
                //        }
                //        else if (dtf.Cant < detalle.Cant)
                //        {
                //            producto.Stock = producto.Stock - (detalle.Cant - dtf.Cant);
                //            actualice = true;
                //        }
                //        // modifica el datalleFactura en el contexto
                //        _context.Entry(detalle).State = EntityState.Modified;

                //    }
                //    else // creacion del nuevo detalle
                //    {
                //        _context.Entry(detalle).State = EntityState.Added;
                //        producto.Stock = producto.Stock - detalle.Cant;
                //        actualice = true;
                //    }
                //    if (actualice) // modifica el producto en el contexto
                //    {
                //        _context.Entry(producto).State = EntityState.Modified;
                //    }
                //}

                //// instacia la lista de detalles del ID de la factura
                //var DetalleFacturas = await _context.TbDetalleFacturas.Where(x=>x.IdFactura==entity.IdFactura).AsNoTracking().ToListAsync();
                //// Compara los detalles de la factura de la BD con el DTO,
                //// si no lo encuentra lo elimina en el contexto para actualizar los cambios en la BD
                //foreach (var item in DetalleFacturas)
                //{
                //    // instacia el Id Producto para modificar si el detalla se elimina
                //    producto = await _context.TbProductos
                //        .Where(x => x.IdProducto == item.IdProducto && x.Estado == true).SingleOrDefaultAsync();
                //    // verifica si existe el detallefactura
                //    if (entity.TbDetalleFacturas.Where(x => x.IdDetalleFactura == item.IdDetalleFactura).FirstOrDefault() == null)
                //    {
                //        producto.Stock = producto.Stock + item.Cant;
                //        _context.Entry(producto).State = EntityState.Modified;
                //        _context.Entry(item).State = EntityState.Deleted;
                //    }

                //}

                foreach (var detalle in detallesConProductos)
                {
                    producto = detalle.IdProductoNavigation;
                    if (entity.TbDetalleFacturas.FirstOrDefault(x => x.IdDetalleFactura == detalle.IdDetalleFactura) == null)
                    {
                        producto.Stock += detalle.Cant;
                        _context.Entry(producto).State = EntityState.Modified;
                        _context.Entry(detalle).State = EntityState.Deleted;
                    }
                }
                // modifica en el contexto la factura y manda a guarda todos los cambios
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

        public async Task<bool> eliminar(TbFactura entity)
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

        public async Task<TbFactura> guardar(TbFactura entity)
        {
            try
            {
                _context.TbFacturas.Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<TbFactura> obtenerPorId(TbFactura entity)
        {
            try
            {
                return await _context.TbFacturas.Include("TbDetalleFacturas").Where(x => x.IdFactura == entity.IdFactura && x.Estado==true).AsNoTracking().SingleOrDefaultAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<TbFactura>> obtenerTodos()
        {
            try
            {
                return await _context.TbFacturas.Include("TbDetalleFacturas").Where(x=>x.Estado==true).AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
