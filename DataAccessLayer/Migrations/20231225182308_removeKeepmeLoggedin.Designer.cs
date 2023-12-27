﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231225182308_removeKeepmeLoggedin")]
    partial class removeKeepmeLoggedin
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concrete.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminID"));

                    b.Property<string>("AdminEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("AdminPassword")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("AdminRole")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("AdminSurname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CustomerPassword")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CustomerPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerSurname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Plane", b =>
                {
                    b.Property<int>("PlaneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlaneID"));

                    b.Property<string>("PlaneName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("RouteID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("SeatNum")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<int>("TakenSeat")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<int>("UntakenSeat")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.HasKey("PlaneID");

                    b.HasIndex("RouteID");

                    b.ToTable("Planes");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Route", b =>
                {
                    b.Property<int>("RouteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RouteID"));

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Landing")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("RouteName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("TakeOff")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("RouteID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Plane", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Route", "Route")
                        .WithMany("Planes")
                        .HasForeignKey("RouteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Route");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Route", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Customer", "Customer")
                        .WithMany("Routes")
                        .HasForeignKey("CustomerID");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Customer", b =>
                {
                    b.Navigation("Routes");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Route", b =>
                {
                    b.Navigation("Planes");
                });
#pragma warning restore 612, 618
        }
    }
}
