using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.Models
{
    public partial class EMIASContext : DbContext
    {
        public EMIASContext()
        {
        }

        public EMIASContext(DbContextOptions<EMIASContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminAdmin> AdminAdmins { get; set; } = null!;
        public virtual DbSet<AnalysDocument> AnalysDocuments { get; set; } = null!;
        public virtual DbSet<Appointment> Appointments { get; set; } = null!;
        public virtual DbSet<AppointmentDocument> AppointmentDocuments { get; set; } = null!;
        public virtual DbSet<Direction> Directions { get; set; } = null!;
        public virtual DbSet<Doctor> Doctors { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<ResearchDocument> ResearchDocuments { get; set; } = null!;
        public virtual DbSet<Specialty> Specialties { get; set; } = null!;
        public virtual DbSet<StatusStatus> StatusStatuses { get; set; } = null!;

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminAdmin>(entity =>
            {
                entity.HasKey(e => e.IdAdmin)
                    .HasName("PK__AdminAdm__69F5676603729C67");

                entity.ToTable("AdminAdmin");

                entity.Property(e => e.IdAdmin).HasColumnName("ID_Admin");

                entity.Property(e => e.Aname)
                    .HasMaxLength(50)
                    .HasColumnName("AName");

                entity.Property(e => e.EnterPassword).HasMaxLength(50);

                entity.Property(e => e.Patronymic).HasMaxLength(50);

                entity.Property(e => e.Surname).HasMaxLength(50);
            });

            modelBuilder.Entity<AnalysDocument>(entity =>
            {
                entity.HasKey(e => e.IdAnalysDocument)
                    .HasName("PK__AnalysDo__11B957641B2D5834");

                entity.ToTable("AnalysDocument");

                entity.Property(e => e.IdAnalysDocument)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_AnalysDocument");

                
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.IdAppointment)
                    .HasName("PK__Appointm__CE24CCCC7990B806");

                entity.Property(e => e.IdAppointment).HasColumnName("ID_Appointment");

                entity.Property(e => e.AppointmentDate).HasColumnType("date");

                entity.Property(e => e.IdDirection).HasColumnName("ID_Direction");

                entity.Property(e => e.IdDoctor).HasColumnName("ID_Doctor");

                entity.Property(e => e.IdPatient).HasColumnName("ID_Patient");

                entity.Property(e => e.IdStatus).HasColumnName("ID_Status");

                
            });

            modelBuilder.Entity<AppointmentDocument>(entity =>
            {
                entity.HasKey(e => e.IdAppointmentDocument)
                    .HasName("PK__Appointm__077DCD835F27B677");

                entity.ToTable("AppointmentDocument");

                entity.Property(e => e.IdAppointmentDocument)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_AppointmentDocument");

                
            });

            modelBuilder.Entity<Direction>(entity =>
            {
                entity.HasKey(e => e.IdDirection)
                    .HasName("PK__Directio__59A79AAF62233C2E");

                entity.Property(e => e.IdDirection).HasColumnName("ID_Direction");

                entity.Property(e => e.IdSpecialty).HasColumnName("ID_Specialty");

                entity.Property(e => e.Oms)
                    .HasMaxLength(50)
                    .HasColumnName("OMS");

                
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.IdDoctor)
                    .HasName("PK__Doctor__3246951C35BA54DD");

                entity.ToTable("Doctor");

                entity.Property(e => e.IdDoctor).HasColumnName("ID_Doctor");

                entity.Property(e => e.Dname)
                    .HasMaxLength(50)
                    .HasColumnName("DName");

                entity.Property(e => e.EnterPassword).HasMaxLength(50);

                entity.Property(e => e.IdSpecialty).HasColumnName("ID_Specialty");

                entity.Property(e => e.Patronymic).HasMaxLength(50);

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.WorkAddress).HasMaxLength(255);

               
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.IdPatient)
                    .HasName("PK__Patient__EE3EFF6876050F94");

                entity.ToTable("Patient");

                entity.Property(e => e.IdPatient).HasColumnName("ID_Patient");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.LivingAddress).HasMaxLength(255);

                entity.Property(e => e.Paddress)
                    .HasMaxLength(255)
                    .HasColumnName("PAddress");

                entity.Property(e => e.Patronymic).HasMaxLength(30);

                entity.Property(e => e.Phone).HasMaxLength(10);

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .HasColumnName("PName");

                entity.Property(e => e.Surname).HasMaxLength(50);
            });

            modelBuilder.Entity<ResearchDocument>(entity =>
            {
                entity.HasKey(e => e.IdResearchDocument)
                    .HasName("PK__Research__117811C6C5A3991B");

                entity.ToTable("ResearchDocument");

                entity.Property(e => e.IdResearchDocument)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_ResearchDocument");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(1)
                    .IsFixedLength();

               
            });

            modelBuilder.Entity<Specialty>(entity =>
            {
                entity.HasKey(e => e.IdSpecialty)
                    .HasName("PK__Specialt__0BE09D9326BF7EBA");

                entity.Property(e => e.IdSpecialty).HasColumnName("ID_Specialty");

                entity.Property(e => e.IName)
                    .HasMaxLength(50)
                    .HasColumnName("iName");
            });

            modelBuilder.Entity<StatusStatus>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("PK__StatusSt__5AC2A7345175D0D6");

                entity.ToTable("StatusStatus");

                entity.Property(e => e.IdStatus).HasColumnName("ID_Status");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
