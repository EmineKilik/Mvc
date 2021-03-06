// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using finalhazirlik.Models.Context;

namespace finalhazirlik.Migrations
{
    [DbContext(typeof(OgrenciContext))]
    partial class OgrenciContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("finalhazirlik.Models.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OgrenciAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)");

                    b.Property<float>("OgrenciFinal")
                        .HasColumnType("real");

                    b.Property<float>("OgrenciOrtalama")
                        .HasColumnType("real");

                    b.Property<string>("OgrenciSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("OgrenciVize")
                        .HasColumnType("real");

                    b.HasKey("OgrenciId");

                    b.ToTable("tblogrenci");
                });
#pragma warning restore 612, 618
        }
    }
}
