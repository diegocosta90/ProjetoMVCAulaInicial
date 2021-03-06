using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CursoMVC.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Produto> produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security = True");
        }
    }
}
