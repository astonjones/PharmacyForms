﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PharmacyForms.Data;

#nullable disable

namespace PharmacyForms.Migrations.ApplicationDb
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220217231023_ChangeEODReport")]
    partial class ChangeEODReport
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PharmacyForms.Models.EndOfDayModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<double>("AlternativeAdjudications")
                        .HasColumnType("double");

                    b.Property<double>("AlternativeCogs")
                        .HasColumnType("double");

                    b.Property<double>("ApprovedPatientCount")
                        .HasColumnType("double");

                    b.Property<double>("Cogs")
                        .HasColumnType("double");

                    b.Property<double>("DeniedPatientCount")
                        .HasColumnType("double");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("ExistingPatients")
                        .HasColumnType("double");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("HighCopayCount")
                        .HasColumnType("double");

                    b.Property<decimal>("InsuranceAdjudications")
                        .HasColumnType("decimal(65,30)");

                    b.Property<double>("InsuranceErrors")
                        .HasColumnType("double");

                    b.Property<double>("InsuranceTerminatedCount")
                        .HasColumnType("double");

                    b.Property<double>("InternalTransfer")
                        .HasColumnType("double");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("NotContractedCount")
                        .HasColumnType("double");

                    b.Property<string>("OtherExceptions")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("PatientExceptionCount")
                        .HasColumnType("double");

                    b.Property<string>("PharmacyName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("RefillAdjudications")
                        .HasColumnType("double");

                    b.Property<double>("RefillCogs")
                        .HasColumnType("double");

                    b.Property<double>("RxCount")
                        .HasColumnType("double");

                    b.Property<double>("RxRefills")
                        .HasColumnType("double");

                    b.Property<double>("TotalExistingPatients")
                        .HasColumnType("double");

                    b.Property<double>("TransferredPatientCount")
                        .HasColumnType("double");

                    b.Property<double>("WrongDOBCount")
                        .HasColumnType("double");

                    b.Property<double>("WrongLastNameCount")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("EndOfDay");
                });

            modelBuilder.Entity("PharmacyForms.Models.PatientCountModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PatientCount")
                        .HasColumnType("int");

                    b.Property<string>("PharmacyName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TimeOfDay")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PatientCounts");
                });
#pragma warning restore 612, 618
        }
    }
}
