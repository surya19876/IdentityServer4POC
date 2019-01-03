using IdentityServerPOC3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServerPOC3.Context
{
    public class UserContext:DbContext
    {
        public const string ConnectionString = "Server=D-LADYDAY-XXX-001.legalzoom.com;Database=LZData;Trusted_Connection=False;User ID=LZWebUser; Password=c@l14n1a; MultipleActiveResultSets=true;";
        public DbSet<UserEntity> User { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().ToTable("UserTable", "dbo");
            modelBuilder.Entity<UserEntity>().Property(p => p.pkUserTable).HasColumnName("pkUserTable");
            modelBuilder.Entity<UserEntity>().Property(p => p.sLogin).HasColumnName("sLogin").HasColumnType("varchar(200)");
            modelBuilder.Entity<UserEntity>().Property(p => p.sPWD).HasColumnName("sPWD").HasColumnType("varchar(200)");
            modelBuilder.Entity<UserEntity>().Property(p => p.sQuestion).HasColumnName("sQuestion").HasColumnType("varchar(355)");
            modelBuilder.Entity<UserEntity>().Property(p => p.sRefer).HasColumnName("sRefer").HasColumnType("varchar(550)");
            modelBuilder.Entity<UserEntity>().Property(p => p.nRebate).HasColumnName("nRebate").HasColumnType("numeric");
            modelBuilder.Entity<UserEntity>().Property(p => p.iNoMail).HasColumnName("iNoMail");
            modelBuilder.Entity<UserEntity>().Property(p => p.iSplit).HasColumnName("iSplit");
            modelBuilder.Entity<UserEntity>().Property(p => p.iSessionKey).HasColumnName("iSessionKey");
            modelBuilder.Entity<UserEntity>().Property(p => p.fkAffiliateID).HasColumnName("fkAffiliateID");
            modelBuilder.Entity<UserEntity>().Property(p => p.fkUserContactInfo).HasColumnName("fkUserContactInfo");
            modelBuilder.Entity<UserEntity>().Property(p => p.sPassword).HasColumnName("sPassword").HasColumnType("varchar(1024)");
            modelBuilder.Entity<UserEntity>().Property(p => p.sSalt).HasColumnName("sSalt").HasColumnType("varchar(150)");
            modelBuilder.Entity<UserEntity>().Ignore(p => p.sCreatedBy);
            modelBuilder.Entity<UserEntity>().Ignore(p => p.dtLastUpdated);
            modelBuilder.Entity<UserEntity>().Ignore(p => p.dtCreated);
            modelBuilder.Entity<UserEntity>().HasKey(p => p.pkUserTable);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
