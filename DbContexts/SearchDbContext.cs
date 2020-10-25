using System;
using ExerciseAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExerciseAPI.DbContexts
{
    public class SearchDbContext : DbContext
    {
        public SearchDbContext(DbContextOptions <SearchDbContext> options) : base(options)
        {
        }
        public DbSet<Search> Search { get; set; }
    }
}
