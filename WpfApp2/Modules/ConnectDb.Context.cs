﻿

namespace WpfApp2.Modules
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class prefect_pocrovskoe_streshnegoEntities : DbContext
    {
        public prefect_pocrovskoe_streshnegoEntities()
            : base("name=prefect_pocrovskoe_streshnegoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        

        internal object FirstOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<CancellationReasons> CancellationReasons { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Prefects> Prefects { get; set; }
        public virtual DbSet<Statuses> Statuses { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
