namespace CodeFirst
{
    using CodeFirst.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Roster : DbContext
    {
        public DbSet<Swimmer> Swimmers { get; set; }

    }
}