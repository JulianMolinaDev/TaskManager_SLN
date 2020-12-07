namespace TaskManager_SVC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SCH_TaskManager.TBL_TareasAvisados")]
    public partial class TBL_TareasAvisados
    {
        public int Id { get; set; }

        public int IdTarea { get; set; }

        public int IdUsuario { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FechaAlta { get; set; }

        public bool EsActivo { get; set; }

        public bool? EsVisto { get; set; }

        public virtual TBL_Tareas TBL_Tareas { get; set; }

        public virtual TBL_Usuarios TBL_Usuarios { get; set; }
    }
}
