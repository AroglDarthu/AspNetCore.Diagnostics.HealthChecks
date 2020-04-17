﻿// <auto-generated />
using System;
using HealthChecks.UI.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HealthChecks.UI.MySql.Storage.Migrations
{
    [DbContext(typeof(HealthChecksDb))]
    [Migration("20200415105900_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("HealthChecks.UI.Core.Data.HealthCheckConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DiscoveryService")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<string>("Uri")
                        .IsRequired()
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Configurations");
                });

            modelBuilder.Entity("HealthChecks.UI.Core.Data.HealthCheckExecution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DiscoveryService")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<DateTime>("LastExecuted")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<DateTime>("OnStateFrom")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Uri")
                        .IsRequired()
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Executions");
                });

            modelBuilder.Entity("HealthChecks.UI.Core.Data.HealthCheckExecutionEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time(6)");

                    b.Property<int?>("HealthCheckExecutionId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HealthCheckExecutionId");

                    b.ToTable("HealthCheckExecutionEntries");
                });

            modelBuilder.Entity("HealthChecks.UI.Core.Data.HealthCheckExecutionHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("HealthCheckExecutionId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<DateTime>("On")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("HealthCheckExecutionId");

                    b.ToTable("HealthCheckExecutionHistories");
                });

            modelBuilder.Entity("HealthChecks.UI.Core.Data.HealthCheckFailureNotification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("HealthCheckName")
                        .IsRequired()
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<bool>("IsUpAndRunning")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastNotified")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Failures");
                });

            modelBuilder.Entity("HealthChecks.UI.Core.Data.HealthCheckExecutionEntry", b =>
                {
                    b.HasOne("HealthChecks.UI.Core.Data.HealthCheckExecution", null)
                        .WithMany("Entries")
                        .HasForeignKey("HealthCheckExecutionId");
                });

            modelBuilder.Entity("HealthChecks.UI.Core.Data.HealthCheckExecutionHistory", b =>
                {
                    b.HasOne("HealthChecks.UI.Core.Data.HealthCheckExecution", null)
                        .WithMany("History")
                        .HasForeignKey("HealthCheckExecutionId");
                });
#pragma warning restore 612, 618
        }
    }
}
