﻿// <auto-generated />
using System;
using Havit.Distiller.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Havit.Distiller.Entity.Migrations
{
    [DbContext(typeof(DistillerDbContext))]
    [Migration("20190129144940_DistillationResponseSetKey")]
    partial class DistillationResponseSetKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Havit.Data.EntityFrameworkCore.Model.DataSeedVersion", b =>
                {
                    b.Property<string>("ProfileName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(250);

                    b.Property<string>("Version");

                    b.HasKey("ProfileName")
                        .HasName("PK_DataSeed");

                    b.ToTable("__DataSeed");
                });

            modelBuilder.Entity("Havit.Distiller.Model.Common.ApplicationSettings", b =>
                {
                    b.Property<int>("Id");

                    b.HasKey("Id");

                    b.ToTable("ApplicationSettings");
                });

            modelBuilder.Entity("Havit.Distiller.Model.DistillationItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("DistillationItem");
                });

            modelBuilder.Entity("Havit.Distiller.Model.DistillationResponseItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DistillationItemId");

                    b.Property<int>("ResponseSetId");

                    b.Property<int>("ResponseValue");

                    b.HasKey("Id");

                    b.HasIndex("DistillationItemId");

                    b.HasIndex("ResponseSetId");

                    b.ToTable("DistillationResponseItem");
                });

            modelBuilder.Entity("Havit.Distiller.Model.DistillationResponseSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comments");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Key")
                        .HasMaxLength(100);

                    b.Property<int>("ScopeId");

                    b.Property<string>("Submitter")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ScopeId");

                    b.ToTable("DistillationResponseSet");
                });

            modelBuilder.Entity("Havit.Distiller.Model.DistillationScope", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("DistillationScope");
                });

            modelBuilder.Entity("Havit.Distiller.Model.Localizations.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Culture")
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<string>("Symbol")
                        .HasMaxLength(50);

                    b.Property<string>("UiCulture")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("Havit.Distiller.Model.Security.LoginAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Username")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("LoginAccount");
                });

            modelBuilder.Entity("Havit.Distiller.Model.DistillationResponseItem", b =>
                {
                    b.HasOne("Havit.Distiller.Model.DistillationItem", "DistillationItem")
                        .WithMany()
                        .HasForeignKey("DistillationItemId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Havit.Distiller.Model.DistillationResponseSet", "ResponseSet")
                        .WithMany("Items")
                        .HasForeignKey("ResponseSetId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Havit.Distiller.Model.DistillationResponseSet", b =>
                {
                    b.HasOne("Havit.Distiller.Model.DistillationScope", "Scope")
                        .WithMany()
                        .HasForeignKey("ScopeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}