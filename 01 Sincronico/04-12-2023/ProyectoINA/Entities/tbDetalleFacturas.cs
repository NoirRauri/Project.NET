//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbDetalleFacturas
    {
        public int idDetalleFactura { get; set; }
        public int idFactura { get; set; }
        public string idProducto { get; set; }
        public int cant { get; set; }
        public decimal precio { get; set; }
    
        public virtual tbFacturas tbFacturas { get; set; }
        public virtual tbProductos tbProductos { get; set; }
    }
}
