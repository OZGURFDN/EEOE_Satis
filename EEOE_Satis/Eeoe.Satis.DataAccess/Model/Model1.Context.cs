namespace EEOE_Satis.Eeoe.Satis.DataAccess.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EeoeDbEntities : DbContext
    {
        public EeoeDbEntities()
            : base("name=EeoeDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Urun> Urun { get; set; }
    }
}
