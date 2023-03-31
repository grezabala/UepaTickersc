using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UepaTicksWeb.Dominio.Entity;

namespace UepaTicksWeb.Dominio.Context
{
    public class UepaTicksWebDbContext : DbContext
    {
        public UepaTicksWebDbContext(DbContextOptions<UepaTicksWebDbContext> optionsBuilder) : base(optionsBuilder)
        {

        }

        public virtual DbSet<Eventos> Eventos { get; set; }
        public virtual DbSet<Taquillas> Taquillas { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
    }
}
