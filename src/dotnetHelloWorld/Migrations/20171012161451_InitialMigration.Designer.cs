using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using dotnetHelloWorld.Models;

namespace dotnetHelloWorld.Migrations
{
    [DbContext(typeof(VisitorsDbContext))]
    [Migration("20171012161451_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3");

            modelBuilder.Entity("dotnetHelloWorld.Models.Visitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Visitors");
                });
        }
    }
}
