//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_cantidad_cuotas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_cantidad_cuotas()
        {
            this.tb_intereses = new HashSet<tb_intereses>();
            this.tb_prestamos = new HashSet<tb_prestamos>();
        }
    
        public int id_cantidad_cuota { get; set; }
        public int Cantidad_Cuotas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_intereses> tb_intereses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_prestamos> tb_prestamos { get; set; }
    }
}
