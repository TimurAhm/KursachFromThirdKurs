using MySql.Data.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using WpfExampleTimur343.DataBase.Entity;

namespace WpfExampleTimur343.DataBase
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public partial class EfModel : DbContext
    {
        private static EfModel Instance;
        public static EfModel Init()
        {
            if (Instance == null)
                Instance = new EfModel();
            return Instance;
        }
        public EfModel()
            : base("name=EfModel1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<IngridientLevels> IngridientLevels { get; set; }
        public virtual DbSet<Ingridients> Ingridients { get; set; }
        public virtual DbSet<TovarLevelsSummer> TovarLevels { get; set; }
        public virtual DbSet<Tovars> Tovars { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<TovarLevelAutumn> TovarLevelAutumns { get; set; }
        public virtual DbSet<TovarLevelSpring> TovarLevelSprings { get; set; }
        public virtual DbSet<TovarLevelWinter> TovarLevelWinters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C__MigrationHistory>()
                .Property(e => e.MigrationId)
                .IsUnicode(false);

            modelBuilder.Entity<C__MigrationHistory>()
                .Property(e => e.ContextKey)
                .IsUnicode(false);

            modelBuilder.Entity<C__MigrationHistory>()
                .Property(e => e.ProductVersion)
                .IsUnicode(false);

            modelBuilder.Entity<IngridientLevels>()
                .Property(e => e.IngridientName)
                .IsUnicode(false);

            modelBuilder.Entity<Ingridients>()
                .Property(e => e.IngridientName)
                .IsUnicode(false);

            modelBuilder.Entity<TovarLevelsSummer>()
                .Property(e => e.TovarNameLvl)
                .IsUnicode(false);

            modelBuilder.Entity<Tovars>()
                .Property(e => e.TovarName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.UserLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.UserPass)
                .IsUnicode(false);
        }
    }
}
