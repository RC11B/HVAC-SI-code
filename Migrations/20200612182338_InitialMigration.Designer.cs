﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pro11WA.Models;

namespace Pro11WA.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200612182338_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pro11WA.Models.Furnace", b =>
                {
                    b.Property<int>("furnaceid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("companyid")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("modelnumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("serialnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("size")
                        .HasColumnType("int");

                    b.Property<double>("tonnage")
                        .HasColumnType("float");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.HasKey("furnaceid");

                    b.ToTable("Furnaces");
                });
#pragma warning restore 612, 618
        }
    }
}
