﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using militaryApi.Models;

#nullable disable

namespace militaryApi.Migrations
{
    [DbContext(typeof(militaryApiContext))]
    partial class militaryApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("militaryApi.Models.Soldier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rank")
                        .HasColumnType("TEXT");

                    b.Property<string>("SoldierImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("SoldierType")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("SpecialSoldier")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Soldier");
                });

            modelBuilder.Entity("militaryApi.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AmmoCapacity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AmmoType")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Automatic")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("SemiAutomatic")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("SingelFire")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WeaponImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("WeaponName")
                        .HasColumnType("TEXT");

                    b.Property<string>("WeaponType")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Weapon");
                });
#pragma warning restore 612, 618
        }
    }
}
