using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace jvyx1q.Models;

public partial class Context : DbContext
{
    public Context()
    {
    }

    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

    public virtual DbSet<CrewMember> CrewMembers { get; set; }

    public virtual DbSet<Film> Films { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Mgenre> Mgenres { get; set; }

    public virtual DbSet<Mlanguage> Mlanguages { get; set; }

    public virtual DbSet<MovieCrew> MovieCrews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=szoft2023.database.windows.net;Initial Catalog=JVYX1Q;Persist Security Info=True;User ID=jvyx1q;Password=Magasugras2003;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Hungarian_CI_AI");

        modelBuilder.Entity<CrewMember>(entity =>
        {
            entity.HasKey(e => e.CrewId);

            entity.Property(e => e.CrewId)
                .ValueGeneratedNever()
                .HasColumnName("crew_id");
            entity.Property(e => e.CrewName).HasColumnName("crew_name");
        });

        modelBuilder.Entity<Film>(entity =>
        {
            entity.HasIndex(e => e.Id, "idx_movie_name");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BudgetX).HasColumnName("budget_x");
            entity.Property(e => e.DateX)
                .HasColumnType("date")
                .HasColumnName("date_x");
            entity.Property(e => e.Names)
                .HasMaxLength(100)
                .HasColumnName("names");
            entity.Property(e => e.OrigTitle)
                .HasMaxLength(100)
                .HasColumnName("orig_title");
            entity.Property(e => e.Overview).HasColumnName("overview");
            entity.Property(e => e.Revenue).HasColumnName("revenue");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.ToTable("Genre");

            entity.HasIndex(e => e.GenreName, "un").IsUnique();

            entity.Property(e => e.GenreId)
                .ValueGeneratedNever()
                .HasColumnName("genre_id");
            entity.Property(e => e.GenreName)
                .HasMaxLength(50)
                .HasColumnName("genre_name");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.ToTable("Language");

            entity.Property(e => e.LanguageId)
                .ValueGeneratedNever()
                .HasColumnName("language_id");
            entity.Property(e => e.Language1)
                .HasMaxLength(50)
                .HasColumnName("language");
        });

        modelBuilder.Entity<Mgenre>(entity =>
        {
            entity.ToTable("MGenre");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.GenreId).HasColumnName("genre_id");
            entity.Property(e => e.MovieId).HasColumnName("movie_id");

            entity.HasOne(d => d.Genre).WithMany(p => p.Mgenres)
                .HasForeignKey(d => d.GenreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mg");

            entity.HasOne(d => d.Movie).WithMany(p => p.Mgenres)
                .HasForeignKey(d => d.MovieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_gr");
        });

        modelBuilder.Entity<Mlanguage>(entity =>
        {
            entity.ToTable("MLanguage");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MovieId).HasColumnName("movie_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Mlanguages)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_lg");

            entity.HasOne(d => d.Movie).WithMany(p => p.Mlanguages)
                .HasForeignKey(d => d.MovieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ml");
        });

        modelBuilder.Entity<MovieCrew>(entity =>
        {
            entity.ToTable("MovieCrew");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CrewId).HasColumnName("crew_id");
            entity.Property(e => e.MovieId).HasColumnName("movie_id");

            entity.HasOne(d => d.Crew).WithMany(p => p.MovieCrews)
                .HasForeignKey(d => d.CrewId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cr");

            entity.HasOne(d => d.Movie).WithMany(p => p.MovieCrews)
                .HasForeignKey(d => d.MovieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
