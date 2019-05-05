﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewTestSix.Models;

namespace NewTestSix.Migrations
{
    [DbContext(typeof(NewTestSixContext))]
    partial class NewTestSixContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewTestSix.Models.FormData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CheckboxData");

                    b.Property<int>("TextBoxIntData");

                    b.Property<string>("TextBoxStringData");

                    b.HasKey("Id");

                    b.ToTable("FormData");
                });

            modelBuilder.Entity("NewTestSix.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AcidStables");

                    b.Property<string>("ClientSampleID");

                    b.Property<string>("Genre");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("NewTestSix.Models.SubmitFormV2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AcidStables");

                    b.Property<string>("AdditionalComments");

                    b.Property<string>("ClientSampleID")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<bool>("FAAs");

                    b.Property<bool>("Sulfurs");

                    b.Property<bool>("Trp");

                    b.Property<int>("_sampleMatrix");

                    b.HasKey("Id");

                    b.ToTable("SubmitFormV2");
                });

            modelBuilder.Entity("NewTestSix.Models.TableForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcidStables");

                    b.Property<string>("AdditionalComments");

                    b.Property<string>("ClientSampleID")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<bool>("FAAs");

                    b.Property<bool>("Sulfurs");

                    b.Property<bool>("Trp");

                    b.Property<int>("_sampleMatrix");

                    b.HasKey("Id");

                    b.ToTable("TableForm");
                });
#pragma warning restore 612, 618
        }
    }
}
