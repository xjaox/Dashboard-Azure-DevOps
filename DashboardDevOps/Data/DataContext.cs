using DashboardDevOps.Business;
using DashboardDevOps.Models;
using Microsoft.EntityFrameworkCore;


namespace DashboardDevOps.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<TB_FUNCAO> Funcao { get; set; }
        public DbSet<TB_PERFIL_FUNCAO> PerfilFuncao { get; set; }
        public DbSet<TB_PERFIL> Perfil { get; set; }
        public DbSet<TB_PROCESSO> Processo { get; set; }
        public DbSet<TB_SITE_PROCESSO> SiteProcesso { get; set; }
        public DbSet<TB_USUARIO> Usuario { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TB_FUNCAO>(entity =>
            {
                entity.ToTable("TB_FUNCAO");

                entity.HasNoKey();
            });

            modelBuilder.Entity<TB_PERFIL_FUNCAO>(entity =>
            {
                entity.ToTable("TB_PERFIL_FUNCAO");

                entity.HasNoKey();
            });

            modelBuilder.Entity<TB_PERFIL>(entity =>
            {
                entity.ToTable("TB_PERFIL");

                entity.HasNoKey();
            });

            modelBuilder.Entity<TB_PROCESSO>(entity =>
            {
                entity.ToTable("TB_PROCESSO");

                entity.HasNoKey();
            });

            modelBuilder.Entity<TB_SITE_PROCESSO>(entity =>
            {
                entity.ToTable("TB_SITE_PROCESSO");

                entity.HasNoKey();
            });
            
            modelBuilder.Entity<TB_USUARIO>(entity =>
            {
                entity.ToTable("TB_USUARIO");

                entity.HasNoKey();
            });
        }
    }
}