using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Entity_CodeFirst_.Entity
{
    class Context : DbContext  // burada inheritance oluşturduk
    {
        protected override void OnModelCreating(DbModelBuilder _modelBuilder)
        {
            _modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



        public DbSet<Urunler> Urunler { get; set; }
        public DbSet<Kategori> Kategori { get; set; }

        public DbSet<Musteri> Musteri { get; set; }


    }
}
