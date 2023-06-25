﻿// <auto-generated />
using System;
using FishingJournal.API.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FishingJournal.API.Migrations
{
    [DbContext(typeof(FishingJournalDbContext))]
    [Migration("20230625200910_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("FishingJournal.API.Models.FishType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FishTypes");
                });

            modelBuilder.Entity("FishingJournal.API.Models.HookType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("HookTypes");
                });

            modelBuilder.Entity("FishingJournal.API.Models.JournalEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<string>("AdditionalInfo")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "additionalInfo");

                    b.Property<float>("AirPressure")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "airPressure");

                    b.Property<int>("AirPressureTendency")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "airPressureTendency");

                    b.Property<float>("AirTemperature")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "airTemperature");

                    b.Property<string>("BaitInfo")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "baitInfo");

                    b.Property<string>("CatchPlaceImagePath")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "dateTime");

                    b.Property<short>("FeedDuration")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "feedDuration");

                    b.Property<string>("FeedInfo")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "hookInfo");

                    b.Property<string>("FishImagePath")
                        .HasColumnType("TEXT");

                    b.Property<string>("FishNickname")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "fishNickname");

                    b.Property<int>("FishTypeId")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "fishType");

                    b.Property<int>("HookTypeId")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "hookType");

                    b.Property<float>("Length")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "length");

                    b.Property<string>("LocationName")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "locationName");

                    b.Property<int>("RigTypeId")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "rigType");

                    b.Property<int>("WaterCurrentTypeId")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "waterCurrentType");

                    b.Property<int>("WaterSurfaceTypeId")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "waterSurfaceType");

                    b.Property<float>("WaterTemperature")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "waterTemperature");

                    b.Property<int>("WeatherTypeId")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "weatherType");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "weight");

                    b.Property<int>("WindDirection")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "windDirection");

                    b.Property<byte>("WindStrength")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "windStrength");

                    b.HasKey("Id");

                    b.ToTable("JournalEntries");
                });

            modelBuilder.Entity("FishingJournal.API.Models.RigType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RigTypes");
                });

            modelBuilder.Entity("FishingJournal.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("Id", "Name");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FishingJournal.API.Models.WaterCurrentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WaterCurrentTypes");
                });

            modelBuilder.Entity("FishingJournal.API.Models.WaterSurfaceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WaterSurfaceTypes");
                });

            modelBuilder.Entity("FishingJournal.API.Models.WeatherType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WeatherTypes");
                });
#pragma warning restore 612, 618
        }
    }
}