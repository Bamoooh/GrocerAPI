﻿// <auto-generated />
using GrocerAPI.DbSettings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GrocerAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220714131447_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GrocerAPI.Models.Family", b =>
                {
                    b.Property<int>("FamilyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FamilyId"), 1L, 1);

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FamilyId");

                    b.ToTable("Families");
                });

            modelBuilder.Entity("GrocerAPI.Models.FamilyMember", b =>
                {
                    b.Property<int>("FamilyMemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FamilyMemberId"), 1L, 1);

                    b.Property<int>("FamilyId")
                        .HasColumnType("int");

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FamilyMemberId");

                    b.HasIndex("FamilyId");

                    b.ToTable("FamilyMembers");
                });

            modelBuilder.Entity("GrocerAPI.Models.Grocery", b =>
                {
                    b.Property<int>("GroceryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroceryId"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("GroceryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MarketId")
                        .HasColumnType("int");

                    b.HasKey("GroceryId");

                    b.HasIndex("MarketId");

                    b.ToTable("Groceries");
                });

            modelBuilder.Entity("GrocerAPI.Models.Market", b =>
                {
                    b.Property<int>("MarketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarketId"), 1L, 1);

                    b.Property<int>("FamilyId")
                        .HasColumnType("int");

                    b.Property<string>("MarketName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarketId");

                    b.HasIndex("FamilyId");

                    b.ToTable("Markets");
                });

            modelBuilder.Entity("GrocerAPI.Models.FamilyMember", b =>
                {
                    b.HasOne("GrocerAPI.Models.Family", null)
                        .WithMany("FamilyMembers")
                        .HasForeignKey("FamilyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GrocerAPI.Models.Grocery", b =>
                {
                    b.HasOne("GrocerAPI.Models.Market", null)
                        .WithMany("Groceries")
                        .HasForeignKey("MarketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GrocerAPI.Models.Market", b =>
                {
                    b.HasOne("GrocerAPI.Models.Family", null)
                        .WithMany("Markets")
                        .HasForeignKey("FamilyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GrocerAPI.Models.Family", b =>
                {
                    b.Navigation("FamilyMembers");

                    b.Navigation("Markets");
                });

            modelBuilder.Entity("GrocerAPI.Models.Market", b =>
                {
                    b.Navigation("Groceries");
                });
#pragma warning restore 612, 618
        }
    }
}