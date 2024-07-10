namespace MusicLibary.Data
{
    using Microsoft.EntityFrameworkCore;
    using MusicLibary.Models;

    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options) : base(options) { }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
            modelBuilder.Entity<Album>().HasData(
                new Album { AlbumId = 1, Title = "Album 1", Artist = "Artist 1", ReleaseDate = new DateTime(2024, 1, 1), Genre = "Genre 1" },
                new Album { AlbumId = 2, Title = "Album 2", Artist = "Artist 2", ReleaseDate = new DateTime(2025, 1, 1), Genre = "Genre 2" }
            );

            modelBuilder.Entity<Song>().HasData(
                new Song { SongId = 1, Title = "Song 1", Duration = new TimeSpan(0, 3, 45), AlbumId = 1, Artist = "Artist 1" },
                new Song { SongId = 2, Title = "Song 2", Duration = new TimeSpan(0, 4, 15), AlbumId = 1, Artist = "Artist 1" },
                new Song { SongId = 3, Title = "Song 3", Duration = new TimeSpan(0, 2, 30), AlbumId = 2, Artist = "Artist 2" }
            );
        }
    }

}