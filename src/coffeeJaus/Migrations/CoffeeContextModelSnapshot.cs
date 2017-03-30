using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using coffeeJaus.Models;

namespace coffeeJaus.Migrations
{
    [DbContext(typeof(CoffeeContext))]
    partial class CoffeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("coffeeJaus.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("ImgName");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<int>("Size");

                    b.Property<int?>("UnitId");

                    b.HasKey("Id");

                    b.HasIndex("UnitId");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("coffeeJaus.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abrev");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("coffeeJaus.Models.Stock", b =>
                {
                    b.HasOne("coffeeJaus.Models.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId");
                });
        }
    }
}
