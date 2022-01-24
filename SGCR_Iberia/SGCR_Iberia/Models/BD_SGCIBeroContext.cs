using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SGCR_Iberia.Models
{
    public partial class BD_SGCIBeroContext : DbContext
    {
        public BD_SGCIBeroContext()
        {
        }

        public BD_SGCIBeroContext(DbContextOptions<BD_SGCIBeroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAsignacion> TblAsignacions { get; set; }
        public virtual DbSet<TblCurso> TblCursos { get; set; }
        public virtual DbSet<TblDocente> TblDocentes { get; set; }
        public virtual DbSet<TblEspacio> TblEspacios { get; set; }
        public virtual DbSet<TblReserva> TblReservas { get; set; }
        public virtual DbSet<TblUsuario> TblUsuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=BD_SGCIBero;Integrated Security=SSPI; User ID=sa;Password=********;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<TblAsignacion>(entity =>
            {
                entity.HasKey(e => e.IdAsignacion)
                    .HasName("PK__tbl_Asig__C3F7F966D2CEDC87");

                entity.ToTable("tbl_Asignacion");

                entity.Property(e => e.IdAsignacion).HasColumnName("id_asignacion");

                entity.Property(e => e.IdReserva).HasColumnName("id_reserva");

                entity.Property(e => e.Novedades)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("novedades");

                entity.HasOne(d => d.IdReservaNavigation)
                    .WithMany(p => p.TblAsignacions)
                    .HasForeignKey(d => d.IdReserva)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Asign__id_re__45F365D3");
            });

            modelBuilder.Entity<TblCurso>(entity =>
            {
                entity.HasKey(e => e.IdCurso)
                    .HasName("PK__tbl_Curs__5D3F75028705349B");

                entity.ToTable("tbl_Curso");

                entity.Property(e => e.IdCurso).HasColumnName("id_curso");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TblDocente>(entity =>
            {
                entity.HasKey(e => e.IdDocente)
                    .HasName("PK__tbl_Doce__300DB211C0F674CD");

                entity.ToTable("tbl_Docente");

                entity.Property(e => e.IdDocente).HasColumnName("id_docente");

                entity.Property(e => e.ApellidoM)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("apellido_m");

                entity.Property(e => e.ApellidoP)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("apellido_p");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.IdCurso).HasColumnName("id_curso");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.TblDocentes)
                    .HasForeignKey(d => d.IdCurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Docen__id_cu__4316F928");
            });

            modelBuilder.Entity<TblEspacio>(entity =>
            {
                entity.HasKey(e => e.IdEspacio)
                    .HasName("PK__tbl_Espa__33F920B5FDA87AFA");

                entity.ToTable("tbl_Espacio");

                entity.Property(e => e.IdEspacio).HasColumnName("id_espacio");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TblReserva>(entity =>
            {
                entity.HasKey(e => e.IdReserva)
                    .HasName("PK__tbl_Rese__423CBE5DFA840116");

                entity.ToTable("tbl_Reserva");

                entity.Property(e => e.IdReserva).HasColumnName("id_reserva");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_fin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_inicio");

                entity.Property(e => e.IdDocente).HasColumnName("id_docente");

                entity.Property(e => e.IdEspacio).HasColumnName("id_espacio");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.TituloEvento)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("titulo_evento");

                entity.HasOne(d => d.IdDocenteNavigation)
                    .WithMany(p => p.TblReservas)
                    .HasForeignKey(d => d.IdDocente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Reser__id_do__46E78A0C");

                entity.HasOne(d => d.IdEspacioNavigation)
                    .WithMany(p => p.TblReservas)
                    .HasForeignKey(d => d.IdEspacio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Reser__id_es__44FF419A");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TblReservas)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Reser__id_us__440B1D61");
            });

            modelBuilder.Entity<TblUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__tbl_Usua__4E3E04ADFBB4BC52");

                entity.ToTable("tbl_Usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("contrasena");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Users)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
