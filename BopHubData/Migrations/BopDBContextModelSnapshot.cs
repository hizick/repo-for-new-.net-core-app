﻿// <auto-generated />
using System;
using BopHubData.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BopHubData.Migrations
{
    [DbContext(typeof(BopDBContext))]
    partial class BopDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BopHubData.Model.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("BopHubData.Model.Attendance", b =>
                {
                    b.Property<int>("BopId");

                    b.Property<int>("AttendeeId");

                    b.HasKey("BopId", "AttendeeId");

                    b.HasIndex("AttendeeId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("BopHubData.Model.Bop", b =>
                {
                    b.Property<int>("BopId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArtisteId");

                    b.Property<string>("BopName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<byte>("GenreId");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("ReleaseVenue")
                        .IsRequired();

                    b.HasKey("BopId");

                    b.HasIndex("ArtisteId");

                    b.HasIndex("GenreId");

                    b.ToTable("Bops");
                });

            modelBuilder.Entity("BopHubData.Model.Genre", b =>
                {
                    b.Property<byte>("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("BopHubData.Model.Attendance", b =>
                {
                    b.HasOne("BopHubData.Model.Account", "Attendee")
                        .WithMany()
                        .HasForeignKey("AttendeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BopHubData.Model.Bop", "Bop")
                        .WithMany()
                        .HasForeignKey("BopId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BopHubData.Model.Bop", b =>
                {
                    b.HasOne("BopHubData.Model.Account", "Artiste")
                        .WithMany()
                        .HasForeignKey("ArtisteId");

                    b.HasOne("BopHubData.Model.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
