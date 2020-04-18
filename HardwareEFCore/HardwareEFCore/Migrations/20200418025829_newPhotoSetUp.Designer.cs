﻿// <auto-generated />
using System;
using HardwareEFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HardwareEFCore.Migrations
{
    [DbContext(typeof(HardwareDbContext))]
    [Migration("20200418025829_newPhotoSetUp")]
    partial class newPhotoSetUp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HardwareEFCore.Models.BuildOrder", b =>
                {
                    b.Property<int>("BuildOrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<string>("Line1")
                        .IsRequired();

                    b.Property<string>("Line2");

                    b.Property<string>("Line3");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<bool>("Shipped");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Zip");

                    b.HasKey("BuildOrderId");

                    b.ToTable("BuildOrders");
                });

            modelBuilder.Entity("HardwareEFCore.Models.CartLine", b =>
                {
                    b.Property<int>("CartLineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BuildOrderId");

                    b.Property<int?>("DriveId");

                    b.Property<int>("Quantity");

                    b.HasKey("CartLineId");

                    b.HasIndex("BuildOrderId");

                    b.HasIndex("DriveId");

                    b.ToTable("CartLine");
                });

            modelBuilder.Entity("HardwareEFCore.Models.Computer", b =>
                {
                    b.Property<int>("ComputerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Model");

                    b.Property<string>("Nickname");

                    b.HasKey("ComputerId");

                    b.ToTable("Computers");
                });

            modelBuilder.Entity("HardwareEFCore.Models.CPU", b =>
                {
                    b.Property<int>("CpuId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BaseClock");

                    b.Property<decimal>("BoostClock");

                    b.Property<int>("ComputerId");

                    b.Property<int>("CoreCount");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Model");

                    b.Property<int>("ThreadCount");

                    b.HasKey("CpuId");

                    b.HasIndex("ComputerId");

                    b.ToTable("Cpus");
                });

            modelBuilder.Entity("HardwareEFCore.Models.Drive", b =>
                {
                    b.Property<int>("DriveId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ComputerId");

                    b.Property<string>("Interface")
                        .IsRequired();

                    b.Property<string>("Manufacturer")
                        .IsRequired();

                    b.Property<string>("Model")
                        .IsRequired();

                    b.Property<int>("SizeInGB");

                    b.Property<string>("TransferProtocol")
                        .IsRequired();

                    b.HasKey("DriveId");

                    b.HasIndex("ComputerId");

                    b.ToTable("Drives");
                });

            modelBuilder.Entity("HardwareEFCore.Models.RAM", b =>
                {
                    b.Property<int>("RamId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComputerId");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Model");

                    b.Property<int>("SpeedInMhz");

                    b.Property<string>("Type");

                    b.HasKey("RamId");

                    b.HasIndex("ComputerId");

                    b.ToTable("Ram");
                });

            modelBuilder.Entity("HardwareEFCore.Models.CartLine", b =>
                {
                    b.HasOne("HardwareEFCore.Models.BuildOrder")
                        .WithMany("Lines")
                        .HasForeignKey("BuildOrderId");

                    b.HasOne("HardwareEFCore.Models.Drive", "Drive")
                        .WithMany()
                        .HasForeignKey("DriveId");
                });

            modelBuilder.Entity("HardwareEFCore.Models.CPU", b =>
                {
                    b.HasOne("HardwareEFCore.Models.Computer", "Computer")
                        .WithMany("Cpus")
                        .HasForeignKey("ComputerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HardwareEFCore.Models.Drive", b =>
                {
                    b.HasOne("HardwareEFCore.Models.Computer", "Computer")
                        .WithMany("Drives")
                        .HasForeignKey("ComputerId");
                });

            modelBuilder.Entity("HardwareEFCore.Models.RAM", b =>
                {
                    b.HasOne("HardwareEFCore.Models.Computer", "Computer")
                        .WithMany("Ram")
                        .HasForeignKey("ComputerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
