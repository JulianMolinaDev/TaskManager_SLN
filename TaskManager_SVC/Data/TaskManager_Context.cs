namespace TaskManager_SVC.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TaskManager_Context : DbContext
    {
        public TaskManager_Context()
            : base("name=TaskManager_Context")
        {
        }

        public virtual DbSet<TBL_Divisiones> TBL_Divisiones { get; set; }
        public virtual DbSet<TBL_Empresas> TBL_Empresas { get; set; }
        public virtual DbSet<TBL_Proyectos> TBL_Proyectos { get; set; }
        public virtual DbSet<TBL_Tareas> TBL_Tareas { get; set; }
        public virtual DbSet<TBL_TareasAvisados> TBL_TareasAvisados { get; set; }
        public virtual DbSet<TBL_Usuarios> TBL_Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBL_Divisiones>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Empresas>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Empresas>()
                .Property(e => e.UrlImagen)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Empresas>()
                .HasMany(e => e.TBL_Proyectos)
                .WithRequired(e => e.TBL_Empresas)
                .HasForeignKey(e => e.IdEmpresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_Empresas>()
                .HasMany(e => e.TBL_Usuarios)
                .WithRequired(e => e.TBL_Empresas)
                .HasForeignKey(e => e.IdEmpresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_Proyectos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Proyectos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Proyectos>()
                .HasMany(e => e.TBL_Divisiones)
                .WithRequired(e => e.TBL_Proyectos)
                .HasForeignKey(e => e.IdProyecto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_Tareas>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Tareas>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Tareas>()
                .HasMany(e => e.TBL_Tareas1)
                .WithOptional(e => e.TBL_Tareas2)
                .HasForeignKey(e => e.IdDivision);

            modelBuilder.Entity<TBL_Tareas>()
                .HasMany(e => e.TBL_TareasAvisados)
                .WithRequired(e => e.TBL_Tareas)
                .HasForeignKey(e => e.IdTarea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_Usuarios>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Usuarios>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Usuarios>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Usuarios>()
                .HasMany(e => e.TBL_TareasAvisados)
                .WithRequired(e => e.TBL_Usuarios)
                .HasForeignKey(e => e.IdUsuario)
                .WillCascadeOnDelete(false);
        }
    }
}
