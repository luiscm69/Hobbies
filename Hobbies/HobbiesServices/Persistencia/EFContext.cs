using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HobbiesServices.Dominio;

namespace HobbiesServices.Persistencia
{
    public class EFContext : DbContext
    {
        public EFContext(string cadenaConexion)
            : base(cadenaConexion)
        {
            Database.SetInitializer<EFContext>(null);
        }

        public DbSet<Hobbie> HobbieDbSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}