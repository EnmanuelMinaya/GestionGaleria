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
    
    public partial class Tbl_PinturaGenero
    {
        public int Id_PinturaGenero { get; set; }
        public int Id_Pintura { get; set; }
        public int Id_Genero { get; set; }
    
        public virtual Tbl_Genero Tbl_Genero { get; set; }
        public virtual Tbl_Pintura Tbl_Pintura { get; set; }
    }
}
