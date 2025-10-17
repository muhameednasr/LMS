using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LMS.Models;

public partial class LmsContext : DbContext
{
    public LmsContext()
    {
    }

    public LmsContext(DbContextOptions<LmsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AuthenticationSystem> AuthenticationSystems { get; set; }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    public virtual DbSet<Reader> Readers { get; set; }

    public virtual DbSet<ReaderBook> ReaderBooks { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseLazyLoadingProxies() // Enable lazy loading
            .UseSqlServer("Server=.;Database=LMS;Trusted_Connection=True;Encrypt=False"); // Replace with your database provider
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuthenticationSystem>(entity =>
        {
            entity.HasKey(e => e.LoginId).HasName("PK__Authenti__4DDA2818BFD4724C");

            entity.ToTable("AuthenticationSystem");

            entity.Property(e => e.Password).HasMaxLength(100);
        });

        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.AuthorId).HasName("PK__Authors__55B9F6DF03D036D4");

            entity.Property(e => e.AuthorId).HasColumnName("Author_ID");
            entity.Property(e => e.AuthorName).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(50);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Isbn).HasName("PK__Books__447D36EBF8B9ECE7");

            entity.Property(e => e.Isbn).HasColumnName("ISBN");
            entity.Property(e => e.AuthorId).HasColumnName("Author_ID");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Edition).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PublisherId).HasColumnName("Publisher_ID");
            entity.Property(e => e.StaffId).HasColumnName("Staff_ID");
            entity.Property(e => e.Title).HasMaxLength(150);

            entity.HasOne(d => d.Author).WithMany(p => p.Books)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("FK__Books__Author_ID__571DF1D5");

            entity.HasOne(d => d.Publisher).WithMany(p => p.Books)
                .HasForeignKey(d => d.PublisherId)
                .HasConstraintName("FK__Books__Publisher__3F466844");

            entity.HasOne(d => d.Staff).WithMany(p => p.Books)
                .HasForeignKey(d => d.StaffId)
                .HasConstraintName("FK__Books__Staff_ID__49C3F6B7");
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.PublisherId).HasName("PK__Publishe__F9F45A64C4349B31");

            entity.ToTable("Publisher");

            entity.Property(e => e.PublisherId).HasColumnName("Publisher_ID");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Reader>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Readers__206D919044C2670A");

            entity.Property(e => e.UserId).HasColumnName("User_ID");
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Name)
                .HasMaxLength(101)
                .HasComputedColumnSql("(([FirstName]+' ')+[LastName])", true);
            entity.Property(e => e.PhoneNo).HasMaxLength(20);
        });

        modelBuilder.Entity<ReaderBook>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ReaderBo__3214EC27A6862DC5");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isbn).HasColumnName("ISBN");
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.IsbnNavigation).WithMany(p => p.ReaderBooks)
                .HasForeignKey(d => d.Isbn)
                .HasConstraintName("FK__ReaderBook__ISBN__48CFD27E");

            entity.HasOne(d => d.User).WithMany(p => p.ReaderBooks)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__ReaderBoo__User___47DBAE45");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.RegNo).HasName("PK__Reports__38E7BF98B6C8007E");

            entity.Property(e => e.RegNo).HasColumnName("Reg_no");
            entity.Property(e => e.BookNo).HasColumnName("Book_No");
            entity.Property(e => e.IssueReturn).HasMaxLength(50);
            entity.Property(e => e.StaffId).HasColumnName("Staff_ID");
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.Staff).WithMany(p => p.Reports)
                .HasForeignKey(d => d.StaffId)
                .HasConstraintName("FK__Reports__Staff_I__4316F928");

            entity.HasOne(d => d.User).WithMany(p => p.Reports)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Reports__User_ID__4222D4EF");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.StaffId).HasName("PK__Staff__32D1F3C3C399C2D9");

            entity.HasIndex(e => e.LoginId, "UQ__Staff__4DDA2819CBEC1237").IsUnique();

            entity.Property(e => e.StaffId).HasColumnName("Staff_ID");
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Login).WithOne(p => p.Staff)
                .HasForeignKey<Staff>(d => d.LoginId)
                .HasConstraintName("FK__Staff__LoginId__44FF419A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
