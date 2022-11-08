﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Loading_Related_Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221107095305_mig_1")]
    partial class mig_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 1,
                            OrderDate = new DateTime(2022, 11, 7, 12, 53, 5, 545, DateTimeKind.Local).AddTicks(7505)
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 1,
                            OrderDate = new DateTime(2022, 11, 7, 12, 53, 5, 545, DateTimeKind.Local).AddTicks(7519)
                        },
                        new
                        {
                            Id = 3,
                            EmployeeId = 2,
                            OrderDate = new DateTime(2022, 11, 7, 12, 53, 5, 545, DateTimeKind.Local).AddTicks(7520)
                        },
                        new
                        {
                            Id = 4,
                            EmployeeId = 2,
                            OrderDate = new DateTime(2022, 11, 7, 12, 53, 5, 545, DateTimeKind.Local).AddTicks(7521)
                        },
                        new
                        {
                            Id = 5,
                            EmployeeId = 3,
                            OrderDate = new DateTime(2022, 11, 7, 12, 53, 5, 545, DateTimeKind.Local).AddTicks(7521)
                        },
                        new
                        {
                            Id = 6,
                            EmployeeId = 3,
                            OrderDate = new DateTime(2022, 11, 7, 12, 53, 5, 545, DateTimeKind.Local).AddTicks(7524)
                        },
                        new
                        {
                            Id = 7,
                            EmployeeId = 3,
                            OrderDate = new DateTime(2022, 11, 7, 12, 53, 5, 545, DateTimeKind.Local).AddTicks(7524)
                        },
                        new
                        {
                            Id = 8,
                            EmployeeId = 4,
                            OrderDate = new DateTime(2022, 11, 7, 12, 53, 5, 545, DateTimeKind.Local).AddTicks(7526)
                        },
                        new
                        {
                            Id = 9,
                            EmployeeId = 4,
                            OrderDate = new DateTime(2022, 11, 7, 12, 53, 5, 545, DateTimeKind.Local).AddTicks(7526)
                        },
                        new
                        {
                            Id = 10,
                            EmployeeId = 1,
                            OrderDate = new DateTime(2022, 11, 7, 12, 53, 5, 545, DateTimeKind.Local).AddTicks(7528)
                        },
                        new
                        {
                            Id = 11,
                            EmployeeId = 2,
                            OrderDate = new DateTime(2022, 11, 7, 12, 53, 5, 545, DateTimeKind.Local).AddTicks(7529)
                        });
                });

            modelBuilder.Entity("Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ankara"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Yozgat"
                        });
                });

            modelBuilder.Entity("Employee", b =>
                {
                    b.HasBaseType("Person");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("RegionId");

                    b.HasDiscriminator().HasValue("Employee");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Gençay",
                            RegionId = 1,
                            Salary = 1500,
                            Surname = "Yıldız"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mahmut",
                            RegionId = 2,
                            Salary = 1500,
                            Surname = "Yıldız"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rıfkı",
                            RegionId = 1,
                            Salary = 1500,
                            Surname = "Yıldız"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Cüneyt",
                            RegionId = 2,
                            Salary = 1500,
                            Surname = "Yıldız"
                        });
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.HasOne("Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Employee", b =>
                {
                    b.HasOne("Region", "Region")
                        .WithMany("Employees")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("Region", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Employee", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
