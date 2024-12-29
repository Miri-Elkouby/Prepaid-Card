﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrepaidCard.Data;

#nullable disable

namespace PrepaidCard.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241229203854_RelationShip")]
    partial class RelationShip
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PrepaidCard.Core.Entities.CardEntity", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardId"), 1L, 1);

                    b.Property<DateTime>("CardValidity")
                        .HasColumnType("datetime2");

                    b.Property<string>("ColorCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfPurchase")
                        .HasColumnType("datetime2");

                    b.Property<string>("PurchaseCenter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Sum")
                        .HasColumnType("float");

                    b.HasKey("CardId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Card");
                });

            modelBuilder.Entity("PrepaidCard.Core.Entities.CustomerEntity", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfJoin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("PrepaidCard.Core.Entities.PurchaseCenterEntity", b =>
                {
                    b.Property<int>("PurchaseCenterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchaseCenterId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamePurchasePoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("PurchaseCenterId");

                    b.ToTable("PurchaseCenter");
                });

            modelBuilder.Entity("PrepaidCard.Core.Entities.PurchaseEntity", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchaseId"), 1L, 1);

                    b.Property<int?>("CardEntityCardId")
                        .HasColumnType("int");

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfPurchase")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int?>("PurchaseCenterEntityPurchaseCenterId")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseCenterId")
                        .HasColumnType("int");

                    b.Property<double>("Sum")
                        .HasColumnType("float");

                    b.HasKey("PurchaseId");

                    b.HasIndex("CardEntityCardId");

                    b.HasIndex("PurchaseCenterEntityPurchaseCenterId");

                    b.ToTable("Purchase");
                });

            modelBuilder.Entity("PrepaidCard.Core.Entities.StoreEntity", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteStore")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StoreId");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("PrepaidCard.Core.Entities.CardEntity", b =>
                {
                    b.HasOne("PrepaidCard.Core.Entities.CustomerEntity", "Customer")
                        .WithMany("Cards")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("PrepaidCard.Core.Entities.PurchaseEntity", b =>
                {
                    b.HasOne("PrepaidCard.Core.Entities.CardEntity", null)
                        .WithMany("Purchase")
                        .HasForeignKey("CardEntityCardId");

                    b.HasOne("PrepaidCard.Core.Entities.PurchaseCenterEntity", null)
                        .WithMany("Purchase")
                        .HasForeignKey("PurchaseCenterEntityPurchaseCenterId");
                });

            modelBuilder.Entity("PrepaidCard.Core.Entities.CardEntity", b =>
                {
                    b.Navigation("Purchase");
                });

            modelBuilder.Entity("PrepaidCard.Core.Entities.CustomerEntity", b =>
                {
                    b.Navigation("Cards");
                });

            modelBuilder.Entity("PrepaidCard.Core.Entities.PurchaseCenterEntity", b =>
                {
                    b.Navigation("Purchase");
                });
#pragma warning restore 612, 618
        }
    }
}
