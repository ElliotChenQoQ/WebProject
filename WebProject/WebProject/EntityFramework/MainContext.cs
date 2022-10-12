using WebProject.Model.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WebProject.Core.EntityFramework
{
    public class MainContext : DbContext
    {
        static IConfiguration Configuration { get; set; }
        public DbSet<StationInfo> StationInfo { get; set; }
        public DbSet<UviData> UviData { get; set; }
        public MainContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(Configuration.GetConnectionString("MainDatabase"));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // === 索引 ===
            modelBuilder.Entity<StationInfo>()
             .HasIndex(a => new { a.SiSn })
             .IsClustered(false);

            modelBuilder.Entity<UviData>()
             .HasIndex(a => new { a.UdSn })
             .IsClustered(false);

            // === 預設值 ===
            modelBuilder.Entity<UviData>().Property(a => a.CreateDtm).HasDefaultValueSql("GETDATE()");

            #region 欄位說明
            modelBuilder.Entity<StationInfo>().Property(m => m.SiSn).HasComment("PK, 自動流水號");
            modelBuilder.Entity<StationInfo>().Property(m => m.StationCode).HasComment("測站代號");
            modelBuilder.Entity<StationInfo>().Property(m => m.City).HasComment("城市");
            modelBuilder.Entity<StationInfo>().Property(m => m.StationName).HasComment("測站名稱");
            modelBuilder.Entity<UviData>().Property(m => m.UdSn).HasComment("PK, 自動流水號");
            modelBuilder.Entity<UviData>().Property(m => m.StationCode).HasComment("測站代號");
            modelBuilder.Entity<UviData>().Property(m => m.UviValue).HasComment("紫外線指數最大值");
            modelBuilder.Entity<UviData>().Property(m => m.ObservationDtm).HasComment("觀測時間");
            modelBuilder.Entity<UviData>().Property(m => m.CreateUser).HasComment("建立者");
            modelBuilder.Entity<UviData>().Property(m => m.CreateDtm).HasComment("建立時間");
            #endregion
        }
    }
}