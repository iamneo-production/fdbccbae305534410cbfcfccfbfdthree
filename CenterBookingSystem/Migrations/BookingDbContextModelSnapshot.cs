﻿// <auto-generated />
using System;
using CenterBookingSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CenterBookingSystem.Migrations
{
    [DbContext(typeof(BookingDbContext))]
    partial class BookingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CenterBookingSystem.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"), 1L, 1);

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EventSpaceSpaceID")
                        .HasColumnType("int");

                    b.Property<int>("OrgaizerID")
                        .HasColumnType("int");

                    b.Property<int>("SpaceID")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("TimeSlot")
                        .HasColumnType("time");

                    b.HasKey("BookingID");

                    b.HasIndex("EventSpaceSpaceID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("CenterBookingSystem.Models.EventSpace", b =>
                {
                    b.Property<int>("SpaceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpaceID"), 1L, 1);

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("SpaceID");

                    b.ToTable("EventSpaces");
                });

            modelBuilder.Entity("CenterBookingSystem.Models.Booking", b =>
                {
                    b.HasOne("CenterBookingSystem.Models.EventSpace", null)
                        .WithMany("Bookings")
                        .HasForeignKey("EventSpaceSpaceID");
                });

            modelBuilder.Entity("CenterBookingSystem.Models.EventSpace", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
