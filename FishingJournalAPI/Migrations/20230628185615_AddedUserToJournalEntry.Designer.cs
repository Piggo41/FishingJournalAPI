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
    [Migration("20230628185615_AddedUserToJournalEntry")]
    partial class AddedUserToJournalEntry
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("FishingJournal.API.Models.JournalEntryModels.FishType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FishTypes");
                });

            modelBuilder.Entity("FishingJournal.API.Models.JournalEntryModels.HookType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("HookTypes");
                });

            modelBuilder.Entity("FishingJournal.API.Models.JournalEntryModels.JournalEntry", b =>
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
                        .HasAnnotation("Relational:JsonPropertyName", "fishTypeId");

                    b.Property<int>("HookTypeId")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "hookTypeId");

                    b.Property<float>("Latitude")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "latitude");

                    b.Property<float>("Length")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "length");

                    b.Property<string>("LocationName")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "locationName");

                    b.Property<float>("Longitude")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "longitude");

                    b.Property<int>("RigTypeId")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "rigTypeId");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "userId");

                    b.Property<int>("WaterCurrentTypeId")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "waterCurrentTypeId");

                    b.Property<int>("WaterSurfaceTypeId")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "waterSurfaceTypeId");

                    b.Property<float>("WaterTemperature")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "waterTemperature");

                    b.Property<int>("WeatherTypeId")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "weatherTypeId");

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

                    b.HasIndex("FishTypeId");

                    b.HasIndex("HookTypeId");

                    b.HasIndex("RigTypeId");

                    b.HasIndex("UserId");

                    b.HasIndex("WaterCurrentTypeId");

                    b.HasIndex("WaterSurfaceTypeId");

                    b.HasIndex("WeatherTypeId");

                    b.ToTable("JournalEntries");
                });

            modelBuilder.Entity("FishingJournal.API.Models.JournalEntryModels.RigType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RigTypes");
                });

            modelBuilder.Entity("FishingJournal.API.Models.JournalEntryModels.WaterCurrentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WaterCurrentTypes");
                });

            modelBuilder.Entity("FishingJournal.API.Models.JournalEntryModels.WaterSurfaceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WaterSurfaceTypes");
                });

            modelBuilder.Entity("FishingJournal.API.Models.JournalEntryModels.WeatherType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WeatherTypes");
                });

            modelBuilder.Entity("FishingJournal.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FishingJournal.API.Models.JournalEntryModels.JournalEntry", b =>
                {
                    b.HasOne("FishingJournal.API.Models.JournalEntryModels.FishType", "FishType")
                        .WithMany("Parents")
                        .HasForeignKey("FishTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FishingJournal.API.Models.JournalEntryModels.HookType", "HookType")
                        .WithMany("Parents")
                        .HasForeignKey("HookTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FishingJournal.API.Models.JournalEntryModels.RigType", "RigType")
                        .WithMany("Parents")
                        .HasForeignKey("RigTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FishingJournal.API.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FishingJournal.API.Models.JournalEntryModels.WaterCurrentType", "WaterCurrentType")
                        .WithMany("Parents")
                        .HasForeignKey("WaterCurrentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FishingJournal.API.Models.JournalEntryModels.WaterSurfaceType", "WaterSurfaceType")
                        .WithMany("Parents")
                        .HasForeignKey("WaterSurfaceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FishingJournal.API.Models.JournalEntryModels.WeatherType", "WeatherType")
                        .WithMany("Parents")
                        .HasForeignKey("WeatherTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FishType");

                    b.Navigation("HookType");

                    b.Navigation("RigType");

                    b.Navigation("User");

                    b.Navigation("WaterCurrentType");

                    b.Navigation("WaterSurfaceType");

                    b.Navigation("WeatherType");
                });

            modelBuilder.Entity("FishingJournal.API.Models.JournalEntryModels.FishType", b =>
                {
                    b.Navigation("Parents");
                });

            modelBuilder.Entity("FishingJournal.API.Models.JournalEntryModels.HookType", b =>
                {
                    b.Navigation("Parents");
                });

            modelBuilder.Entity("FishingJournal.API.Models.JournalEntryModels.RigType", b =>
                {
                    b.Navigation("Parents");
                });

            modelBuilder.Entity("FishingJournal.API.Models.JournalEntryModels.WaterCurrentType", b =>
                {
                    b.Navigation("Parents");
                });

            modelBuilder.Entity("FishingJournal.API.Models.JournalEntryModels.WaterSurfaceType", b =>
                {
                    b.Navigation("Parents");
                });

            modelBuilder.Entity("FishingJournal.API.Models.JournalEntryModels.WeatherType", b =>
                {
                    b.Navigation("Parents");
                });
#pragma warning restore 612, 618
        }
    }
}
