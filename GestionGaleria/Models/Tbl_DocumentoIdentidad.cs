//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionGaleria.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_DocumentoIdentidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_DocumentoIdentidad()
        {
            this.Tbl_Persona = new HashSet<Tbl_Persona>();
        }
    
        public int Id_DocumentoIdentidad { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Persona> Tbl_Persona { get; set; }
    }
}
