namespace TaskManager_SVC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SCH_TaskManager.TBL_Divisiones")]
    public partial class TBL_Divisiones
    {
        public int Id { get; set; }

        public int IdProyecto { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FechaAlta { get; set; }

        public bool EsActivo { get; set; }

        public virtual TBL_Proyectos TBL_Proyectos { get; set; }
    }
}
