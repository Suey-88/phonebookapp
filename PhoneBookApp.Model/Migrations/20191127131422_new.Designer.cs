﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhoneBookApp.Model;

namespace PhoneBookApp.Model.Migrations
{
    [DbContext(typeof(PhoneBookAppContext))]
    [Migration("20191127131422_new")]
    partial class @new
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PhoneBookApp.Model.Entities.PhoneBook.PHB_PhoneBook", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.ToTable("PHB_PhoneBook","dbo");
                });

            modelBuilder.Entity("PhoneBookApp.Model.Entities.PhoneBook.PHB_PhoneNumber", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("number")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("phonebookid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("phonebookid");

                    b.ToTable("PHB_PhoneNumber","dbo");
                });

            modelBuilder.Entity("PhoneBookApp.Model.Entities.System.SYS_Error", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("StackTrace")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(8000);

                    b.HasKey("id");

                    b.ToTable("SYS_Error","dbo");
                });

            modelBuilder.Entity("PhoneBookApp.Model.Entities.PhoneBook.PHB_PhoneNumber", b =>
                {
                    b.HasOne("PhoneBookApp.Model.Entities.PhoneBook.PHB_PhoneBook", "PhoneBook")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("phonebookid")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}