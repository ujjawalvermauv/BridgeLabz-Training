using FundooNotes.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FundooNotes.Repository.Data;

public class FundooDbContext : DbContext
{
    public FundooDbContext(DbContextOptions<FundooDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Note> Notes { get; set; }

    public DbSet<Label> Labels { get; set; }

    public DbSet<Reminder> Reminders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();

        modelBuilder.Entity<User>()
            .HasMany(u => u.Notes)
            .WithOne(n => n.User)
            .HasForeignKey(n => n.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<User>()
            .HasMany(u => u.Labels)
            .WithOne(l => l.User)
            .HasForeignKey(l => l.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Note>()
            .HasMany(n => n.Labels)
            .WithMany(l => l.Notes)
            .UsingEntity<Dictionary<string, object>>(
                "NoteLabels",
                j => j.HasOne<Label>().WithMany().HasForeignKey("LabelsId").OnDelete(DeleteBehavior.NoAction),
                j => j.HasOne<Note>().WithMany().HasForeignKey("NotesId").OnDelete(DeleteBehavior.Cascade));

        modelBuilder.Entity<Reminder>()
            .HasOne(r => r.User)
            .WithMany()
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Reminder>()
            .HasOne(r => r.Note)
            .WithMany()
            .HasForeignKey(r => r.NoteId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}