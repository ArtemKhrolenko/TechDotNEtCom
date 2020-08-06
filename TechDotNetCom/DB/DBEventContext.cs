using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataGridAX
{
    class DBEventContext : DbContext
    {
        public DBEventContext(string connectionString) : base(connectionString) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            Database.SetInitializer<DBContext>(null);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Убирает добавление буквы s в конец названия таблицы
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<action_en> actionsEng { get; set; }
        public DbSet<actioncode> actionsCodes { get; set; }
        public DbSet<dcs01_po> dcsEvents { get; set; }
        public DbSet<typeofvar> typesOfVars { get; set; }
    }
}
