    using Microsoft.EntityFrameworkCore;
    using web_APIS.Models;

    namespace web_APIS.Contex
    {
        public class Contexto : DbContext
        {
            public Contexto(DbContextOptions<Contexto> options) : base(options)
            {
                // El cuerpo del constructor puede estar vacío si no necesitas inicialización adicional aquí.
            }

            public DbSet<Usuario> Usuario { get; set; }
            public DbSet<Videos> Videos { get; set; }
            
            public DbSet<LIkes> Likes { get; set; }
        public DbSet<visual> visuals { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relación Uno a Muchos: Usuario (Uno) a Videos (Muchos)
            modelBuilder.Entity<Videos>() // La entidad 'muchos'
                .HasOne(v => v.Usuario) // Un Video tiene UN Usuario
                .WithMany(u => u.Videos) // Un Usuario tiene MUCHOS Videos
                .HasForeignKey(v => v.UsuarioID).OnDelete(DeleteBehavior.Restrict); // La clave foránea en la tabla 'Videos'

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Videos)
                .WithOne(v => v.Usuario)
                .HasForeignKey(v => v.UsuarioID).OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<LIkes>()
                .HasOne(l => l.Video)
                .WithMany(v => v.LIkes)
                .HasForeignKey(l => l.VideoID).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<visual>()
                .HasOne(v => v.Video)
                .WithMany(vid => vid.visuals)
                .HasForeignKey(v => v.VideoID).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Videos>()
                .HasMany(v => v.Comentarios)
                .WithOne(c => c.video)
                .HasForeignKey(c => c.VideoID);






        }
    }
    }