//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Final.tbd
{
    using System;
    using System.Collections.Generic;
    
    public partial class Entradas
    {
        public int Id_Folio { get; set; }
        public int Id_Producto_FK { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public System.DateTime Fecha { get; set; }
    
        public virtual Producto Producto { get; set; }
    }
}
