using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using Npgsql;


namespace DataGridAX
{
    [DbConfigurationType(typeof(NpgsqlConfiguration))]
    public class DBContext : DbContext
    {        
        public DBContext(string connectionString) : base(connectionString) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            Database.SetInitializer<DBContext>(null);            
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Убирает добавление буквы s в конец названия таблицы
            base.OnModelCreating(modelBuilder);           
        }
    }



    // провайдер Npgsql сервер
    class NpgsqlConfiguration : DbConfiguration
    {
        public NpgsqlConfiguration()
        {
            SetProviderServices("Npgsql", NpgsqlServices.Instance);
            SetProviderFactory("Npgsql", NpgsqlFactory.Instance);
            SetDefaultConnectionFactory(new NpgsqlConnectionFactory());
        }
    }

}
