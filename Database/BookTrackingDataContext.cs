using System;
using manibooktrack.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace manibooktrack.Database
{
    public class BookTrackingDataContext : DbContext
    {
        public BookTrackingDataContext(DbContextOptions options)
        : base(options)
        { }

        public DbSet<booksmodel> Book { get; set; }
        public DbSet<categorymodel> Category { get; set; }
        public DbSet<categorytypemodel> CategoryType { get; set; }
    }
}
