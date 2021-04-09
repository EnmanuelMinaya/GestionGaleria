﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GaleriaEntities : DbContext
    {
        public GaleriaEntities()
            : base("name=GaleriaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_DocumentoIdentidad> Tbl_DocumentoIdentidad { get; set; }
        public virtual DbSet<Tbl_Dueno> Tbl_Dueno { get; set; }
        public virtual DbSet<Tbl_Genero> Tbl_Genero { get; set; }
        public virtual DbSet<Tbl_Persona> Tbl_Persona { get; set; }
        public virtual DbSet<Tbl_Pintor> Tbl_Pintor { get; set; }
        public virtual DbSet<Tbl_Pintura> Tbl_Pintura { get; set; }
        public virtual DbSet<Tbl_PinturaGenero> Tbl_PinturaGenero { get; set; }
    
        public virtual int DeleteDueno(Nullable<int> id_Dueno)
        {
            var id_DuenoParameter = id_Dueno.HasValue ?
                new ObjectParameter("Id_Dueno", id_Dueno) :
                new ObjectParameter("Id_Dueno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteDueno", id_DuenoParameter);
        }
    
        public virtual int DeleteGenero(Nullable<int> id_Genero)
        {
            var id_GeneroParameter = id_Genero.HasValue ?
                new ObjectParameter("Id_Genero", id_Genero) :
                new ObjectParameter("Id_Genero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteGenero", id_GeneroParameter);
        }
    
        public virtual int DeletePersona(Nullable<int> id_Persona)
        {
            var id_PersonaParameter = id_Persona.HasValue ?
                new ObjectParameter("Id_Persona", id_Persona) :
                new ObjectParameter("Id_Persona", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePersona", id_PersonaParameter);
        }
    
        public virtual int DeletePintor(Nullable<int> id_Pintor)
        {
            var id_PintorParameter = id_Pintor.HasValue ?
                new ObjectParameter("Id_Pintor", id_Pintor) :
                new ObjectParameter("Id_Pintor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePintor", id_PintorParameter);
        }
    
        public virtual int DeletePintura(Nullable<int> id_Pintura)
        {
            var id_PinturaParameter = id_Pintura.HasValue ?
                new ObjectParameter("Id_Pintura", id_Pintura) :
                new ObjectParameter("Id_Pintura", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePintura", id_PinturaParameter);
        }
    
        public virtual int InsertDueno(Nullable<int> id_Persona)
        {
            var id_PersonaParameter = id_Persona.HasValue ?
                new ObjectParameter("Id_Persona", id_Persona) :
                new ObjectParameter("Id_Persona", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertDueno", id_PersonaParameter);
        }
    
        public virtual int InsertGenero(string nombreGenero)
        {
            var nombreGeneroParameter = nombreGenero != null ?
                new ObjectParameter("NombreGenero", nombreGenero) :
                new ObjectParameter("NombreGenero", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertGenero", nombreGeneroParameter);
        }
    
        public virtual int InsertPersona(string tipoDocumento, string numeroDocumento, string correo, string nombre, string telefono, string direccion, Nullable<System.DateTime> fechaNacimiento, string nacionalidad)
        {
            var tipoDocumentoParameter = tipoDocumento != null ?
                new ObjectParameter("TipoDocumento", tipoDocumento) :
                new ObjectParameter("TipoDocumento", typeof(string));
    
            var numeroDocumentoParameter = numeroDocumento != null ?
                new ObjectParameter("NumeroDocumento", numeroDocumento) :
                new ObjectParameter("NumeroDocumento", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var nacionalidadParameter = nacionalidad != null ?
                new ObjectParameter("Nacionalidad", nacionalidad) :
                new ObjectParameter("Nacionalidad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertPersona", tipoDocumentoParameter, numeroDocumentoParameter, correoParameter, nombreParameter, telefonoParameter, direccionParameter, fechaNacimientoParameter, nacionalidadParameter);
        }
    
        public virtual int InsertPintor(Nullable<int> id_Persona)
        {
            var id_PersonaParameter = id_Persona.HasValue ?
                new ObjectParameter("Id_Persona", id_Persona) :
                new ObjectParameter("Id_Persona", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertPintor", id_PersonaParameter);
        }
    
        public virtual int InsertPintura(Nullable<int> id_Pintura, Nullable<int> id_Pintor, Nullable<int> id_dueno, string nombrePintura, string tamano, Nullable<System.DateTime> fechaCreacion, Nullable<System.DateTime> fechaIngreso, Nullable<System.DateTime> fechaSalida, Nullable<decimal> valor, string estado)
        {
            var id_PinturaParameter = id_Pintura.HasValue ?
                new ObjectParameter("Id_Pintura", id_Pintura) :
                new ObjectParameter("Id_Pintura", typeof(int));
    
            var id_PintorParameter = id_Pintor.HasValue ?
                new ObjectParameter("Id_Pintor", id_Pintor) :
                new ObjectParameter("Id_Pintor", typeof(int));
    
            var id_duenoParameter = id_dueno.HasValue ?
                new ObjectParameter("Id_dueno", id_dueno) :
                new ObjectParameter("Id_dueno", typeof(int));
    
            var nombrePinturaParameter = nombrePintura != null ?
                new ObjectParameter("NombrePintura", nombrePintura) :
                new ObjectParameter("NombrePintura", typeof(string));
    
            var tamanoParameter = tamano != null ?
                new ObjectParameter("Tamano", tamano) :
                new ObjectParameter("Tamano", typeof(string));
    
            var fechaCreacionParameter = fechaCreacion.HasValue ?
                new ObjectParameter("FechaCreacion", fechaCreacion) :
                new ObjectParameter("FechaCreacion", typeof(System.DateTime));
    
            var fechaIngresoParameter = fechaIngreso.HasValue ?
                new ObjectParameter("FechaIngreso", fechaIngreso) :
                new ObjectParameter("FechaIngreso", typeof(System.DateTime));
    
            var fechaSalidaParameter = fechaSalida.HasValue ?
                new ObjectParameter("FechaSalida", fechaSalida) :
                new ObjectParameter("FechaSalida", typeof(System.DateTime));
    
            var valorParameter = valor.HasValue ?
                new ObjectParameter("Valor", valor) :
                new ObjectParameter("Valor", typeof(decimal));
    
            var estadoParameter = estado != null ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertPintura", id_PinturaParameter, id_PintorParameter, id_duenoParameter, nombrePinturaParameter, tamanoParameter, fechaCreacionParameter, fechaIngresoParameter, fechaSalidaParameter, valorParameter, estadoParameter);
        }
    }
}
