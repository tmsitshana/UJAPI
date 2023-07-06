﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MVCWebAppTestAPI.DBModels
{
    public partial class CandidateContext : DbContext, ICandidateContext
    {
        public CandidateContext()
        {
        }

        public CandidateContext(DbContextOptions<CandidateContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=152.106.4.68; database=Candidate;user id=tmsitshana; password=tmsitshana;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(51)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
