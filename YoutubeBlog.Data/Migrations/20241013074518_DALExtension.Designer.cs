﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YoutubeBlog.Data.Context;

#nullable disable

namespace YoutubeBlog.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241013074518_DALExtension")]
    partial class DALExtension
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d28be444-84c9-48ea-9862-31bb17c4c81a"),
                            CategoryId = new Guid("9d79512d-f19c-4872-982e-fc982916df52"),
                            Content = "Lorem ipsum odor amet, consectetuer adipiscing elit. Magna donec nec inceptos luctus non. Hac dis nascetur facilisi orci risus iaculis. Sem dapibus aliquet sollicitudin dapibus pellentesque tortor mus. Netus duis sodales eu fermentum porttitor velit aptent vitae. Odio metus elementum phasellus tellus mi volutpat mi. Posuere ultricies convallis; class pulvinar nullam pharetra curabitur egestas. Aliquet eros eget eleifend etiam felis eu himenaeos. Interdum condimentum magnis iaculis viverra sociosqu et adipiscing lorem senectus.\r\n\r\nUltrices senectus iaculis lectus ut nisi potenti risus curae euismod. Iaculis scelerisque ad bibendum tellus mi nostra sed dis condimentum. Libero at quam aenean penatibus hac primis varius. Rhoncus velit venenatis dui natoque sodales lacinia ultrices. Vulputate fusce cursus nisi mi nam class cras. Parturient sed inceptos aliquet donec conubia elementum, ex venenatis ullamcorper. Tincidunt himenaeos tortor; metus cubilia volutpat congue vitae id. Cras mollis dis tempus quisque molestie auctor ultrices nascetur. Nunc laoreet varius, finibus diam hendrerit faucibus.\r\n\r\nEst eleifend faucibus purus class amet. Sodales ex rutrum nunc semper aliquet cubilia viverra ante. Interdum habitant primis primis varius mus felis nulla diam potenti. Sed dolor magnis mus quis litora. Et mattis amet nulla sapien finibus aptent. Sollicitudin suspendisse himenaeos commodo fermentum dis faucibus fringilla lectus. Fames integer urna tristique penatibus bibendum nostra. Sed primis erat efficitur ad hendrerit tincidunt felis egestas.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 10, 13, 10, 45, 18, 130, DateTimeKind.Local).AddTicks(6688),
                            ImageId = new Guid("b3ccaf0f-5b84-4600-9374-d0cb16fbaa28"),
                            IsDeleted = false,
                            Title = "Visual Studio Deneme Makalesi 1",
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("5a9aa585-153c-4cd3-9a5d-82ae6f3bdef1"),
                            CategoryId = new Guid("7dbd3759-a9d3-49dc-9c99-974e69ac9b92"),
                            Content = "Lorem ipsum odor amet, consectetuer adipiscing elit. Magna donec nec inceptos luctus non. Hac dis nascetur facilisi orci risus iaculis. Sem dapibus aliquet sollicitudin dapibus pellentesque tortor mus. Netus duis sodales eu fermentum porttitor velit aptent vitae. Odio metus elementum phasellus tellus mi volutpat mi. Posuere ultricies convallis; class pulvinar nullam pharetra curabitur egestas. Aliquet eros eget eleifend etiam felis eu himenaeos. Interdum condimentum magnis iaculis viverra sociosqu et adipiscing lorem senectus.\r\n\r\nUltrices senectus iaculis lectus ut nisi potenti risus curae euismod. Iaculis scelerisque ad bibendum tellus mi nostra sed dis condimentum. Libero at quam aenean penatibus hac primis varius. Rhoncus velit venenatis dui natoque sodales lacinia ultrices. Vulputate fusce cursus nisi mi nam class cras. Parturient sed inceptos aliquet donec conubia elementum, ex venenatis ullamcorper. Tincidunt himenaeos tortor; metus cubilia volutpat congue vitae id. Cras mollis dis tempus quisque molestie auctor ultrices nascetur. Nunc laoreet varius, finibus diam hendrerit faucibus.\r\n\r\nEst eleifend faucibus purus class amet. Sodales ex rutrum nunc semper aliquet cubilia viverra ante. Interdum habitant primis primis varius mus felis nulla diam potenti. Sed dolor magnis mus quis litora. Et mattis amet nulla sapien finibus aptent. Sollicitudin suspendisse himenaeos commodo fermentum dis faucibus fringilla lectus. Fames integer urna tristique penatibus bibendum nostra. Sed primis erat efficitur ad hendrerit tincidunt felis egestas.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 10, 13, 10, 45, 18, 130, DateTimeKind.Local).AddTicks(6693),
                            ImageId = new Guid("4eb578f7-2d83-4832-b0b6-483f12c5a5cc"),
                            IsDeleted = false,
                            Title = "Visual Studio Deneme Makalesi 2",
                            ViewCount = 15
                        });
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9d79512d-f19c-4872-982e-fc982916df52"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 10, 13, 10, 45, 18, 130, DateTimeKind.Local).AddTicks(6847),
                            IsDeleted = false,
                            Name = "ASP .NET Core"
                        },
                        new
                        {
                            Id = new Guid("7dbd3759-a9d3-49dc-9c99-974e69ac9b92"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 10, 13, 10, 45, 18, 130, DateTimeKind.Local).AddTicks(6850),
                            IsDeleted = false,
                            Name = "Visual Studio 2022"
                        });
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b3ccaf0f-5b84-4600-9374-d0cb16fbaa28"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 10, 13, 10, 45, 18, 130, DateTimeKind.Local).AddTicks(6931),
                            FileName = "images/testimage",
                            FileType = "jpg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("4eb578f7-2d83-4832-b0b6-483f12c5a5cc"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 10, 13, 10, 45, 18, 130, DateTimeKind.Local).AddTicks(6934),
                            FileName = "images/vstest",
                            FileType = "png",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Article", b =>
                {
                    b.HasOne("YoutubeBlog.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YoutubeBlog.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
