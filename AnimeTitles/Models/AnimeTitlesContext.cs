using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AnimeTitles.Models;

public partial class AnimeTitlesContext : DbContext
{
    public AnimeTitlesContext() { }

    public AnimeTitlesContext(DbContextOptions<AnimeTitlesContext> options) : base(options) { }

    public virtual DbSet<AnimeTitle> AnimeTitles { get; set; }

    public virtual DbSet<AnimeType> AnimeTypes { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=AnimeTitles;Username=postgres;Password=1111");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnimeTitle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("animeTitles_pkey");

            entity.ToTable("animeTitles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountofSeries).HasColumnName("countofSeries");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.IdModerator).HasColumnName("idModerator");
            entity.Property(e => e.IdOfGenre).HasColumnName("idOfGenre");
            entity.Property(e => e.IdOfType).HasColumnName("idOfType");
            entity.Property(e => e.IsComplete).HasColumnName("isComplete");
            entity.Property(e => e.OriginalName).HasColumnName("originalName");
            entity.Property(e => e.Poster).HasColumnName("poster");
            entity.Property(e => e.Studio).HasColumnName("studio");
            entity.Property(e => e.TitleName).HasColumnName("titleName");
            entity.Property(e => e.YearOfRelease).HasColumnName("yearOfRelease");

            entity.HasOne(d => d.IdModeratorNavigation).WithMany(p => p.AnimeTitles)
                .HasForeignKey(d => d.IdModerator)
                .HasConstraintName("fk_titles_users");

            entity.HasOne(d => d.IdOfGenreNavigation).WithMany(p => p.AnimeTitles)
                .HasForeignKey(d => d.IdOfGenre)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_titles_genres");

            entity.HasOne(d => d.IdOfTypeNavigation).WithMany(p => p.AnimeTitles)
                .HasForeignKey(d => d.IdOfType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_titles_types");
        });

        modelBuilder.Entity<AnimeType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("animeTypes_pkey");

            entity.ToTable("animeTypes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TypeOfAnime).HasColumnName("typeOfAnime");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("genres_pkey");

            entity.ToTable("genres");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GenreName).HasColumnName("genreName");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateOfRegistration).HasColumnName("dateOfRegistration");
            entity.Property(e => e.FirstName).HasColumnName("firstName");
            entity.Property(e => e.LastNamr).HasColumnName("lastNamr");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
