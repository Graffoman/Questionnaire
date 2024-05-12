using Domain.Entities;
using Domain.Entities.BaseClasses;
using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;

namespace Infrastructure.EntityFramework
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Question> Questions { get; init; }
        public DbSet<Questionnaire> Questionnaires { get; init; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Question>().ToCollection("questions");
            modelBuilder.Entity<Questionnaire>().ToCollection("questionnaires");
        }
    }
}
