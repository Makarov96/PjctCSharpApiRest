//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_pagos
    {
        public int id_pago { get; set; }
        public System.DateTime Fecha_pag { get; set; }
        public Nullable<int> id_cuota { get; set; }
        public string tarjeta_credito { get; set; }
    
        public virtual tb_cuotas tb_cuotas { get; set; }
    }
}