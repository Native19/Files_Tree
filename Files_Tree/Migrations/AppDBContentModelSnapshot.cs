﻿// <auto-generated />
using System;
using Files_Tree.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Files_Tree.Migrations
{
    [DbContext(typeof(AppDBContent))]
    partial class AppDBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Files_Tree.Data.Models.File", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("fileName");

                    b.Property<int?>("parentNodeid");

                    b.HasKey("id");

                    b.HasIndex("parentNodeid");

                    b.ToTable("File");
                });

            modelBuilder.Entity("Files_Tree.Data.Models.Node", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nodeName");

                    b.Property<int?>("parentNodeid");

                    b.Property<int>("status");

                    b.HasKey("id");

                    b.HasIndex("parentNodeid");

                    b.ToTable("Node");
                });

            modelBuilder.Entity("Files_Tree.Data.Models.File", b =>
                {
                    b.HasOne("Files_Tree.Data.Models.Node", "parentNode")
                        .WithMany("files")
                        .HasForeignKey("parentNodeid");
                });

            modelBuilder.Entity("Files_Tree.Data.Models.Node", b =>
                {
                    b.HasOne("Files_Tree.Data.Models.Node", "parentNode")
                        .WithMany("subNodes")
                        .HasForeignKey("parentNodeid");
                });
#pragma warning restore 612, 618
        }
    }
}