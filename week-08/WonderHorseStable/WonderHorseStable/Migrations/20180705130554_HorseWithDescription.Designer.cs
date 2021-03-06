﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WonderHorseStable.Repositories;

namespace WonderHorseStable.Migrations
{
    [DbContext(typeof(StableContext))]
    [Migration("20180705130554_HorseWithDescription")]
    partial class HorseWithDescription
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WonderHorseStable.Models.Horse", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<bool>("HasPermission");

                    b.Property<string>("ImageSource");

                    b.Property<string>("Name");

                    b.Property<bool>("Trained");

                    b.HasKey("Id");

                    b.ToTable("Horses");
                });
#pragma warning restore 612, 618
        }
    }
}
