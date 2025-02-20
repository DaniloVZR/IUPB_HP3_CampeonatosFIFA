using CampeonatosFIFA.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CampeonatoFIFA.Persistencia.Contexto
{
    public class CampeonatoFIFAContext : DbContext
    {
        public DbSet<Campeonato> Campeonatos{ get; set; }
        public DbSet<Ciudad> Ciudades {  get; set; }
        public DbSet<Encuentro> Encuentros { get; set; }
        public DbSet<Estadio> Estadios { get; set; }
        public DbSet<Fase> Fases { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<GrupoPais> GruposPaises { get; set; }        
        public DbSet<Pais> Paises { get; set; }

        public CampeonatoFIFAContext(DbContextOptions<CampeonatoFIFAContext> options): base(options)
        {

        }

        void onModelCreate(ModelBuilder builder)
        {
            // Modelo País

            builder.Entity<Pais>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            // Modelo Campeonato

            builder.Entity<Campeonato>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            // Modelo Campeonato - Foreign Key

            builder.Entity<Campeonato>()
                .HasOne(e => e.PaisOrganizador)
                .WithMany()
                .HasForeignKey(e => e.IdSeleccion);

            // Modelo Ciudad

            builder.Entity<Ciudad>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            // Modelo Ciudad - Foreign Key

            builder.Entity<Ciudad>()
                .HasOne(e => e.Pais)
                .WithMany()
                .HasForeignKey(e => e.IdPais);

            // Modelo Estadio

            builder.Entity<Estadio>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            // Modelo Estadio - Foreign Key

            builder.Entity<Estadio>()
                .HasOne(e => e.Ciudad)
                .WithMany()
                .HasForeignKey(e => e.IdCiudad);

            // Modelo Grupo

            builder.Entity<Grupo>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            // Modelo Grupo - Foreign Key

            builder.Entity<Grupo>()
                .HasOne(e => e.Campeonato)
                .WithMany()
                .HasForeignKey(e => e.IdCampeonato);

            // Modelo GrupoPais

            builder.Entity<GrupoPais>(entidad =>
            {
                entidad.HasKey(e => new { e.IdGrupo, e.IdPais});                
            });

            // Modelo GrupoPais - Foreign Keys

            builder.Entity<GrupoPais>()
                .HasOne(e => e.Pais)
                .WithMany()
                .HasForeignKey(e => e.IdPais);

            builder.Entity<GrupoPais>()
                .HasOne(e => e.Grupo)
                .WithMany()
                .HasForeignKey(e => e.IdGrupo);

            // Modelo Fase

            builder.Entity<Fase>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            // Modelo Encuentro

            builder.Entity<Encuentro>(entidad =>
            {
                entidad.HasKey(e => e.Id);
            });

            // Modelo Encuentro - Foreign Keys

            builder.Entity<Encuentro>()
                .HasOne(e => e.Pais1)
                .WithMany()
                .HasForeignKey(e => e.IdPais1);

            builder.Entity<Encuentro>()
                .HasOne(e => e.Pais2)
                .WithMany()
                .HasForeignKey(e => e.IdPais2);

            builder.Entity<Encuentro>()
                .HasOne(e => e.Estadio)
                .WithMany()
                .HasForeignKey(e => e.IdEstadio);

            builder.Entity<Encuentro>()
                .HasOne(e => e.Fase)
                .WithMany()
                .HasForeignKey(e => e.IdFase);

            builder.Entity<Encuentro>()
                .HasOne(e => e.Campeonato)
                .WithMany()
                .HasForeignKey(e => e.IdCampeonato);
        }
    }
}