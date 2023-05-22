﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PandaStore.Data;

#nullable disable

namespace PandaStore.Migrations
{
    [DbContext(typeof(PandaStoreContext))]
    [Migration("20230522140544_Last try, cross our fingers, we give up, reidar where are u")]
    partial class Lasttrycrossourfingerswegiveupreidarwhereareu
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PandaStore.Models.Campaign", b =>
                {
                    b.Property<int>("CampaignID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CampaignID"));

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FK_PandaUserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("FK_ProductID")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CampaignID");

                    b.HasIndex("FK_PandaUserID");

                    b.HasIndex("FK_ProductID");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("PandaStore.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryTitel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("PandaStore.Models.CustomerProduct", b =>
                {
                    b.Property<int>("CustomerProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerProductID"));

                    b.Property<string>("FK_PandaUserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("FK_ProductID")
                        .HasColumnType("int");

                    b.Property<int>("FK_ReceiptID")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ReceiptNumber")
                        .HasColumnType("int");

                    b.HasKey("CustomerProductID");

                    b.HasIndex("FK_PandaUserID");

                    b.HasIndex("FK_ProductID");

                    b.HasIndex("FK_ReceiptID");

                    b.ToTable("CustomerProducts");
                });

            modelBuilder.Entity("PandaStore.Models.CustomerRate", b =>
                {
                    b.Property<int>("CustomerRateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerRateID"));

                    b.Property<int>("FK_ProductID")
                        .HasColumnType("int");

                    b.Property<string>("RateDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerRateID");

                    b.HasIndex("FK_ProductID");

                    b.ToTable("CustomerRates");
                });

            modelBuilder.Entity("PandaStore.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<double>("OrderTotalPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PandaStore.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailID"));

                    b.Property<int>("FK_OrderID")
                        .HasColumnType("int");

                    b.Property<int>("FK_OrderStatus")
                        .HasColumnType("int");

                    b.Property<string>("FK_PandaUserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("FK_ReceiptID")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailID");

                    b.HasIndex("FK_OrderID");

                    b.HasIndex("FK_OrderStatus");

                    b.HasIndex("FK_PandaUserID");

                    b.HasIndex("FK_ReceiptID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("PandaStore.Models.OrderStatus", b =>
                {
                    b.Property<int>("OrderStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderStatusID"));

                    b.Property<bool>("Delivered")
                        .HasColumnType("bit");

                    b.Property<bool>("Shipped")
                        .HasColumnType("bit");

                    b.Property<string>("StatusTitel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("OrderStatusID");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("PandaStore.Models.PandaUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PandaUserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegistreredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("PandaStore.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("FK_CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("InventoryQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("NextDelivery")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<bool>("ProductIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ProductTitel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Specification")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ProductID");

                    b.HasIndex("FK_CategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("PandaStore.Models.Receipt", b =>
                {
                    b.Property<int>("ReceiptID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReceiptID"));

                    b.Property<bool>("PaymentSucceeded")
                        .HasColumnType("bit");

                    b.Property<int>("ReceiptNumber")
                        .HasColumnType("int");

                    b.HasKey("ReceiptID");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PandaStore.Models.PandaUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PandaStore.Models.PandaUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PandaStore.Models.PandaUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PandaStore.Models.PandaUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PandaStore.Models.Campaign", b =>
                {
                    b.HasOne("PandaStore.Models.PandaUser", "PandaUsers")
                        .WithMany("Campaigns")
                        .HasForeignKey("FK_PandaUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PandaStore.Models.Product", "Products")
                        .WithMany("Campaigns")
                        .HasForeignKey("FK_ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PandaUsers");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("PandaStore.Models.CustomerProduct", b =>
                {
                    b.HasOne("PandaStore.Models.PandaUser", "PandaUsers")
                        .WithMany("CustomerProducts")
                        .HasForeignKey("FK_PandaUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PandaStore.Models.Product", "Products")
                        .WithMany()
                        .HasForeignKey("FK_ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PandaStore.Models.Receipt", "Receipts")
                        .WithMany()
                        .HasForeignKey("FK_ReceiptID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PandaUsers");

                    b.Navigation("Products");

                    b.Navigation("Receipts");
                });

            modelBuilder.Entity("PandaStore.Models.CustomerRate", b =>
                {
                    b.HasOne("PandaStore.Models.Product", "Products")
                        .WithMany("CustomerRates")
                        .HasForeignKey("FK_ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");
                });

            modelBuilder.Entity("PandaStore.Models.OrderDetail", b =>
                {
                    b.HasOne("PandaStore.Models.Order", "Orders")
                        .WithMany("OrderDetails")
                        .HasForeignKey("FK_OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PandaStore.Models.OrderStatus", "OrderStatuses")
                        .WithMany("OrderDetails")
                        .HasForeignKey("FK_OrderStatus")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PandaStore.Models.PandaUser", "PandaUsers")
                        .WithMany("OrderDetails")
                        .HasForeignKey("FK_PandaUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PandaStore.Models.Receipt", "Receipts")
                        .WithMany("OrderDetails")
                        .HasForeignKey("FK_ReceiptID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderStatuses");

                    b.Navigation("Orders");

                    b.Navigation("PandaUsers");

                    b.Navigation("Receipts");
                });

            modelBuilder.Entity("PandaStore.Models.Product", b =>
                {
                    b.HasOne("PandaStore.Models.Category", "Categorys")
                        .WithMany("Products")
                        .HasForeignKey("FK_CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorys");
                });

            modelBuilder.Entity("PandaStore.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("PandaStore.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("PandaStore.Models.OrderStatus", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("PandaStore.Models.PandaUser", b =>
                {
                    b.Navigation("Campaigns");

                    b.Navigation("CustomerProducts");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("PandaStore.Models.Product", b =>
                {
                    b.Navigation("Campaigns");

                    b.Navigation("CustomerRates");
                });

            modelBuilder.Entity("PandaStore.Models.Receipt", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
