﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkIt.Models;

namespace ParkIt.Migrations
{
    [DbContext(typeof(ParkItContext))]
    partial class ParkItContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParkIt.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("ParkType")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Name = "Crater Lake",
                            ParkType = "National",
                            State = "Oregon"
                        },
                        new
                        {
                            ParkId = 2,
                            Name = "Grand Canyon",
                            ParkType = "National",
                            State = "Arizona"
                        },
                        new
                        {
                            ParkId = 3,
                            Name = "Yosemite",
                            ParkType = "National",
                            State = "California"
                        },
                        new
                        {
                            ParkId = 4,
                            Name = "Redwood",
                            ParkType = "National",
                            State = "California"
                        },
                        new
                        {
                            ParkId = 5,
                            Name = "Silver Falls",
                            ParkType = "State",
                            State = "Oregon"
                        },
                        new
                        {
                            ParkId = 6,
                            Name = "Fort Stevens",
                            ParkType = "State",
                            State = "Oregon"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
