﻿using Cactus_API.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cactus_API.DAL.DbContexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<HelpCall> HelpCalls { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)  
        { }
    }
}
