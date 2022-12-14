// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebProject.Core.EntityFramework;

namespace WebProject.Migrations
{
    [DbContext(typeof(MainContext))]
    partial class MainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebProject.Model.DataModel.StationInfo", b =>
                {
                    b.Property<long>("SiSn")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SI_SN")
                        .HasColumnType("BIGINT")
                        .HasComment("PK, 自動流水號")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnName("CITY")
                        .HasColumnType("VARCHAR(20)")
                        .HasComment("城市");

                    b.Property<string>("StationCode")
                        .HasColumnName("STATION_CODE")
                        .HasColumnType("VARCHAR(20)")
                        .HasComment("測站代號");

                    b.Property<string>("StationName")
                        .HasColumnName("STATION_NAME")
                        .HasColumnType("VARCHAR(20)")
                        .HasComment("測站名稱");

                    b.HasKey("SiSn");

                    b.HasIndex("SiSn")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("STATION_INFO");
                });

            modelBuilder.Entity("WebProject.Model.DataModel.UviData", b =>
                {
                    b.Property<long>("UdSn")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UD_SN")
                        .HasColumnType("BIGINT")
                        .HasComment("PK, 自動流水號")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDtm")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CREATE_DTM")
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("建立時間");

                    b.Property<string>("CreateUser")
                        .HasColumnName("CREATE_USER")
                        .HasColumnType("NVARCHAR(20)")
                        .HasComment("建立者");

                    b.Property<string>("ObservationDtm")
                        .HasColumnName("OBSERVATION_DTM")
                        .HasColumnType("VARCHAR(20)")
                        .HasComment("觀測時間");

                    b.Property<string>("StationCode")
                        .HasColumnName("STATION_CODE")
                        .HasColumnType("VARCHAR(20)")
                        .HasComment("測站代號");

                    b.Property<decimal?>("UviValue")
                        .HasColumnName("UVI_VALUE")
                        .HasColumnType("DECIMAL(18, 12)")
                        .HasComment("紫外線指數最大值");

                    b.HasKey("UdSn");

                    b.HasIndex("UdSn")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("UVI_DATA");
                });
#pragma warning restore 612, 618
        }
    }
}
