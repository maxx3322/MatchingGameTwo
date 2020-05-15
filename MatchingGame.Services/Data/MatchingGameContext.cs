using System;
using System.Collections.Generic;
using System.Text;
using MatchingGame.Models;
using Microsoft.EntityFrameworkCore;

namespace MatchingGame.Services.Data
{
    public class MatchingGameContext:DbContext
    {
        public MatchingGameContext(DbContextOptions<MatchingGameContext> options) : base(options)
        { }
        public DbSet<Country> Country { get; set; }
        public DbSet<Continent> Continent { get; set; }
        public DbSet<Capital> Capital { get; set; }
    }
}
