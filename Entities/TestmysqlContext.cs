using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Entities;

public partial class TestmysqlContext : DbContext
{
    public TestmysqlContext()
    {
    }

    public TestmysqlContext(DbContextOptions<TestmysqlContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cviky> Cvikies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=;database=testmysql");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cviky>(entity =>
        {
            entity.HasKey(e => e.CvikyId).HasName("PRIMARY");

            entity.ToTable("cviky");

            entity.Property(e => e.CvikyId).HasColumnType("int(11)");
            entity.Property(e => e.CasCviku)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("time");
            entity.Property(e => e.DenCviku)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date");
            entity.Property(e => e.DruhCviku)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
