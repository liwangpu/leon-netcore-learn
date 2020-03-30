﻿// <auto-generated />
using System;
using IDS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace IDS.API.Migrations
{
    [DbContext(typeof(IDSAppContext))]
    partial class IDSAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("idsapp")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("IDS.Domain.AggregateModels.IdentityServerAggregate.IdentityGrant", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ClientId")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Data")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SubjectId")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("IdentityGrant");
                });

            modelBuilder.Entity("IDS.Domain.AggregateModels.UserAggregate.Identity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<long>("CreatedTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Creator")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<long>("ModifiedTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Modifier")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Identity");

                    b.HasData(
                        new
                        {
                            Id = "M8fqzEmNwrzyEFk",
                            CreatedTime = 1585539223000L,
                            Creator = "admin",
                            Email = "bamboo@bamboo.com",
                            ModifiedTime = 1585539223000L,
                            Modifier = "admin",
                            Name = "Admin",
                            Password = "e10adc3949ba59abbe56e057f20f883e",
                            Phone = "157",
                            Username = "admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
