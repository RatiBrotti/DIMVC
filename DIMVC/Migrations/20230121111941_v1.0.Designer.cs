﻿// <auto-generated />
using System;
using DIMVC.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DIMVC.Migrations
{
    [DbContext(typeof(ShContext))]
    [Migration("20230121111941_v1.0")]
    partial class v10
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("ContactIDSequence")
                .StartsAt(0L)
                .IncrementsBy(10);

            modelBuilder.HasSequence("D")
                .StartsAt(0L);

            modelBuilder.HasSequence("val");

            modelBuilder.Entity("DIMVC.DbClasses.ActivatedAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("AcaountStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("DeactivationComment")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserLevel")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.ToTable("ActivatedAccount", (string)null);
                });

            modelBuilder.Entity("DIMVC.DbClasses.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CountryRegion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("StateProvince")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("DIMVC.DbClasses.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryName")
                        .IsUnique();

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("DIMVC.DbClasses.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int?>("BillToAddressId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime>("OrderDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("OrderNumber")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1000);

                    b.Property<bool?>("PaymentStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ShipDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("ShipMethod")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("ShipToAddressId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("BillToAddressId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("DIMVC.DbClasses.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("DIMVC.DbClasses.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Describtion")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("PhotoFileName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ProductNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("ShippingDimensions")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<decimal>("ShippingPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(10,2)")
                        .HasDefaultValue(0m);

                    b.Property<decimal?>("ShippingWeight")
                        .HasColumnType("decimal(6,1)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("DIMVC.DbClasses.ShoppingBag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("ProductID");

                    b.ToTable("ShoppingBag", (string)null);
                });

            modelBuilder.Entity("DIMVC.DbClasses.UnactivatedAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActivationToken")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("UnactivatedAccount", (string)null);
                });

            modelBuilder.Entity("DIMVC.DbClasses.Address", b =>
                {
                    b.HasOne("DIMVC.DbClasses.ActivatedAccount", "ActivatedAccount")
                        .WithMany("Addresses")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ActivatedAccount");
                });

            modelBuilder.Entity("DIMVC.DbClasses.Category", b =>
                {
                    b.HasOne("DIMVC.DbClasses.Category", "ParentCategory")
                        .WithMany("ChildCategories")
                        .HasForeignKey("ParentCategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("DIMVC.DbClasses.Order", b =>
                {
                    b.HasOne("DIMVC.DbClasses.ActivatedAccount", "ActivatedAccount")
                        .WithMany("Orders")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DIMVC.DbClasses.Address", "Address")
                        .WithMany("Orders")
                        .HasForeignKey("BillToAddressId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .HasConstraintName("FK_Orders_BillToAddressId_Addresses");

                    b.Navigation("ActivatedAccount");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("DIMVC.DbClasses.OrderItem", b =>
                {
                    b.HasOne("DIMVC.DbClasses.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("DIMVC.DbClasses.Product", b =>
                {
                    b.HasOne("DIMVC.DbClasses.ActivatedAccount", "ActivatedAccount")
                        .WithMany("Products")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DIMVC.DbClasses.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("ActivatedAccount");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DIMVC.DbClasses.ShoppingBag", b =>
                {
                    b.HasOne("DIMVC.DbClasses.ActivatedAccount", "ActivatedAccount")
                        .WithMany("ShoppingBags")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DIMVC.DbClasses.Product", "Product")
                        .WithMany("ShoppingBags")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ActivatedAccount");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DIMVC.DbClasses.ActivatedAccount", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Orders");

                    b.Navigation("Products");

                    b.Navigation("ShoppingBags");
                });

            modelBuilder.Entity("DIMVC.DbClasses.Address", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DIMVC.DbClasses.Category", b =>
                {
                    b.Navigation("ChildCategories");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("DIMVC.DbClasses.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("DIMVC.DbClasses.Product", b =>
                {
                    b.Navigation("ShoppingBags");
                });
#pragma warning restore 612, 618
        }
    }
}
