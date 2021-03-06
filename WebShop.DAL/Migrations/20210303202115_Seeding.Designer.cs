﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebShop.DAL;

namespace WebShop.DAL.Migrations
{
    [DbContext(typeof(WebShopDbContext))]
    [Migration("20210303202115_Seeding")]
    partial class Seeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ItemProofOfPurchase", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.Property<int>("ProofsOfPurchaseId")
                        .HasColumnType("int");

                    b.HasKey("ItemsId", "ProofsOfPurchaseId");

                    b.HasIndex("ProofsOfPurchaseId");

                    b.ToTable("ItemProofOfPurchase");
                });

            modelBuilder.Entity("ItemTag", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.HasKey("ItemsId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("ItemTag");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<int>("RolesId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("WebShop.Model.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<DateTime>("MadeAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Monitor 1 description",
                            Discount = 0.0,
                            MadeAt = new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Monitor 1",
                            Price = 2000.5
                        },
                        new
                        {
                            Id = 2,
                            Description = "Monitor 2 description",
                            Discount = 0.0,
                            MadeAt = new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Monitor 2",
                            Price = 2500.5
                        },
                        new
                        {
                            Id = 3,
                            Description = "Monitor 3 description",
                            Discount = 0.0,
                            MadeAt = new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Monitor 3",
                            Price = 1060.5
                        },
                        new
                        {
                            Id = 4,
                            Description = "Monitor 4 description",
                            Discount = 0.0,
                            MadeAt = new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Monitor 4",
                            Price = 1006.5
                        },
                        new
                        {
                            Id = 5,
                            Description = "Monitor 5 description",
                            Discount = 0.0,
                            MadeAt = new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Monitor 5",
                            Price = 5000.5
                        },
                        new
                        {
                            Id = 6,
                            Description = "Monitor 6 description",
                            Discount = 0.0,
                            MadeAt = new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Monitor 6",
                            Price = 1020.5
                        },
                        new
                        {
                            Id = 7,
                            Description = "Monitor 7 description",
                            Discount = 0.0,
                            MadeAt = new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Monitor 7",
                            Price = 220.5
                        });
                });

            modelBuilder.Entity("WebShop.Model.ProofOfPurchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ProofOfPurchase");
                });

            modelBuilder.Entity("WebShop.Model.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WebShop.Model.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Monitor"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Graphics card"
                        });
                });

            modelBuilder.Entity("WebShop.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ItemProofOfPurchase", b =>
                {
                    b.HasOne("WebShop.Model.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebShop.Model.ProofOfPurchase", null)
                        .WithMany()
                        .HasForeignKey("ProofsOfPurchaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ItemTag", b =>
                {
                    b.HasOne("WebShop.Model.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebShop.Model.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("WebShop.Model.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebShop.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebShop.Model.ProofOfPurchase", b =>
                {
                    b.HasOne("WebShop.Model.User", "User")
                        .WithMany("ProofsOfPurchase")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebShop.Model.User", b =>
                {
                    b.Navigation("ProofsOfPurchase");
                });
#pragma warning restore 612, 618
        }
    }
}
