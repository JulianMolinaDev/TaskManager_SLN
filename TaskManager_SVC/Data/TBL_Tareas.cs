namespace TaskManager_SVC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SCH_TaskManager.TBL_Tareas")]
    public partial class TBL_Tareas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_Tareas()
        {
            TBL_Tareas1 = new HashSet<TBL_Tareas>();
            TBL_TareasAvisados = new HashSet<TBL_TareasAvisados>();
        }

        public int Id { get; set; }

        public int? IdDivision { get; set; }

        public int IdUsuarioResponsable { get; set; }

        [Required]
        [StringLength(50)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(500)]
        public string Descripcion { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FechaAlta { get; set; }

        public bool EsActivo { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaTermino { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaInicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaTerminoReal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Tareas> TBL_Tareas1 { get; set; }

        public virtual TBL_Tareas TBL_Tareas2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_TareasAvisados> TBL_TareasAvisados { get; set; }
    }
}
