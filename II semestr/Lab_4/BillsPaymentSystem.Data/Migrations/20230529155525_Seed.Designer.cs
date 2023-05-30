﻿// <auto-generated />
using System;
using BillsPaymentSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BillsPaymentSystem.Data.Migrations
{
    [DbContext(typeof(BillsPaymentSystemContext))]
    [Migration("20230529155525_Seed")]
    partial class Seed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BillsPaymentSystem.Data.Models.BankAccount", b =>
                {
                    b.Property<int>("BankAccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BankAccountId"));

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SWIFTCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("BankAccountId");

                    b.ToTable("BankAccounts");

                    b.HasData(
                        new
                        {
                            BankAccountId = 1,
                            Balance = 1000.0,
                            BankName = "Bank of Example",
                            SWIFTCode = "EXMPUS1234"
                        },
                        new
                        {
                            BankAccountId = 2,
                            Balance = 2000.0,
                            BankName = "Example Bank",
                            SWIFTCode = "EXBNK5678"
                        },
                        new
                        {
                            BankAccountId = 3,
                            Balance = 3000.0,
                            BankName = "Banking Institution",
                            SWIFTCode = "BNKINST9102"
                        });
                });

            modelBuilder.Entity("BillsPaymentSystem.Data.Models.CreditCard", b =>
                {
                    b.Property<int>("CreditCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CreditCardId"));

                    b.Property<DateTime>("ExparationDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Limit")
                        .HasColumnType("float");

                    b.Property<double>("ModeyOwed")
                        .HasColumnType("float");

                    b.HasKey("CreditCardId");

                    b.ToTable("CreditCards");

                    b.HasData(
                        new
                        {
                            CreditCardId = 1,
                            ExparationDate = new DateTime(2026, 5, 29, 18, 55, 25, 46, DateTimeKind.Local).AddTicks(617),
                            Limit = 5000.0,
                            ModeyOwed = 2500.0
                        },
                        new
                        {
                            CreditCardId = 2,
                            ExparationDate = new DateTime(2025, 5, 29, 18, 55, 25, 46, DateTimeKind.Local).AddTicks(650),
                            Limit = 10000.0,
                            ModeyOwed = 500.0
                        },
                        new
                        {
                            CreditCardId = 3,
                            ExparationDate = new DateTime(2027, 5, 29, 18, 55, 25, 46, DateTimeKind.Local).AddTicks(653),
                            Limit = 2000.0,
                            ModeyOwed = 0.0
                        });
                });

            modelBuilder.Entity("BillsPaymentSystem.Data.Models.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BankAccountId")
                        .HasColumnType("int");

                    b.Property<int?>("CreditCardId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BankAccountId")
                        .IsUnique()
                        .HasFilter("[BankAccountId] IS NOT NULL");

                    b.HasIndex("CreditCardId")
                        .IsUnique()
                        .HasFilter("[CreditCardId] IS NOT NULL");

                    b.HasIndex("UserId");

                    b.ToTable("PaymentMethods", t =>
                        {
                            t.HasCheckConstraint("CK_BankAccountId_AND_CreditCardId_Empty", "(([BankAccountId] IS NULL) AND ([CreditCardId] IS NOT NULL)) OR (([BankAccountId] IS NOT NULL) AND ([CreditCardId] IS NULL))");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreditCardId = 3,
                            Type = 0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            BankAccountId = 2,
                            Type = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreditCardId = 2,
                            Type = 1,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("BillsPaymentSystem.Data.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "johndoe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "password123"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "janesmith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Password = "qwerty"
                        },
                        new
                        {
                            UserId = 3,
                            Email = "alicejohnson@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            Password = "pass1234"
                        });
                });

            modelBuilder.Entity("BillsPaymentSystem.Data.Models.PaymentMethod", b =>
                {
                    b.HasOne("BillsPaymentSystem.Data.Models.BankAccount", "BankAccount")
                        .WithOne("PaymentMethod")
                        .HasForeignKey("BillsPaymentSystem.Data.Models.PaymentMethod", "BankAccountId");

                    b.HasOne("BillsPaymentSystem.Data.Models.CreditCard", "CreditCard")
                        .WithOne("PaymentMethod")
                        .HasForeignKey("BillsPaymentSystem.Data.Models.PaymentMethod", "CreditCardId");

                    b.HasOne("BillsPaymentSystem.Data.Models.User", "User")
                        .WithMany("PaymentMethod")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BankAccount");

                    b.Navigation("CreditCard");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BillsPaymentSystem.Data.Models.BankAccount", b =>
                {
                    b.Navigation("PaymentMethod")
                        .IsRequired();
                });

            modelBuilder.Entity("BillsPaymentSystem.Data.Models.CreditCard", b =>
                {
                    b.Navigation("PaymentMethod")
                        .IsRequired();
                });

            modelBuilder.Entity("BillsPaymentSystem.Data.Models.User", b =>
                {
                    b.Navigation("PaymentMethod");
                });
#pragma warning restore 612, 618
        }
    }
}