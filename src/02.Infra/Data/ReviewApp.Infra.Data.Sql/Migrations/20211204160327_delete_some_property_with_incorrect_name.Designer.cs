﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewApp.Infra.Data.Sql;

namespace ReviewApp.Infra.Data.Sql.Migrations
{
    [DbContext(typeof(ReviewAppContext))]
    [Migration("20211204160327_delete_some_property_with_incorrect_name")]
    partial class delete_some_property_with_incorrect_name
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ReviewApp.Core.Domain.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ReviewApp.Core.Domain.Entity.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Is_Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ReviewApp.Core.Domain.Entity.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Is_Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("ReviewApp.Core.Domain.Entity.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId")
                        .IsUnique();

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("ReviewApp.Core.Domain.Entity.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PicAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("ReviewApp.Core.Domain.Entity.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Caption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("ReviewApp.Core.Domain.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Password")
                        .HasColumnType("bigint");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ReviewApp.Core.Domain.Entity.Comment", b =>
                {
                    b.HasOne("ReviewApp.Core.Domain.Entity.Post", "Post")
                        .WithMany("comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("ReviewApp.Core.Domain.Entity.Like", b =>
                {
                    b.HasOne("ReviewApp.Core.Domain.Entity.Post", "Post")
                        .WithMany("likes")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("ReviewApp.Core.Domain.Entity.Location", b =>
                {
                    b.HasOne("ReviewApp.Core.Domain.Entity.Post", "Post")
                        .WithOne("location")
                        .HasForeignKey("ReviewApp.Core.Domain.Entity.Location", "PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("ReviewApp.Core.Domain.Entity.Picture", b =>
                {
                    b.HasOne("ReviewApp.Core.Domain.Entity.Post", "post")
                        .WithMany("Pictures")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("post");
                });

            modelBuilder.Entity("ReviewApp.Core.Domain.Entity.Post", b =>
                {
                    b.HasOne("ReviewApp.Core.Domain.Entity.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReviewApp.Core.Domain.Entity.User", "User")
                        .WithMany("posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ReviewApp.Core.Domain.Entity.Category", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("ReviewApp.Core.Domain.Entity.Post", b =>
                {
                    b.Navigation("comments");

                    b.Navigation("likes");

                    b.Navigation("location");

                    b.Navigation("Pictures");
                });

            modelBuilder.Entity("ReviewApp.Core.Domain.Entity.User", b =>
                {
                    b.Navigation("posts");
                });
#pragma warning restore 612, 618
        }
    }
}
