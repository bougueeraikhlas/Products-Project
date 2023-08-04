﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistance.Data;

#nullable disable

namespace Persistance.Migrations
{
    [DbContext(typeof(TrackingContext))]
    partial class TrackingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Navigator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("CreatedById")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("ModifiedById")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Navigators");
                });

            modelBuilder.Entity("Domain.Entities.Shipment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("CreatedById")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DestinationAdr")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Destination_X")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Destination_Y")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("ModifiedById")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("NavigatorId")
                        .HasColumnType("uuid");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StartAdr")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Start_X")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Start_Y")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("VehiculeId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("NavigatorId");

                    b.HasIndex("VehiculeId");

                    b.ToTable("Shipments");
                });

            modelBuilder.Entity("Domain.Entities.ShipmentHighlight", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("CreatedById")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CurrentDensity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CurrentHumidity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CurrentPosition_X")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CurrentPosition_Y")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CurrentTemperature")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("ModifiedById")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("ShimpentId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("ShipmentHighlights");
                });

            modelBuilder.Entity("Domain.Entities.Vehicule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("CreatedById")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("ModifiedById")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("VIN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VRN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Vehicules");
                });

            modelBuilder.Entity("Domain.Entities.Shipment", b =>
                {
                    b.HasOne("Domain.Entities.Navigator", "Navigator")
                        .WithMany()
                        .HasForeignKey("NavigatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Vehicule", "Vehicule")
                        .WithMany()
                        .HasForeignKey("VehiculeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Navigator");

                    b.Navigation("Vehicule");
                });
#pragma warning restore 612, 618
        }
    }
}
