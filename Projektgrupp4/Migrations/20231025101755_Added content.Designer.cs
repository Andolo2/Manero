﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projektgrupp4.Contexts;

#nullable disable

namespace Projektgrupp4.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231025101755_Added content")]
    partial class Addedcontent
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AddressEntityUserEntity", b =>
                {
                    b.Property<Guid>("UserAddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserAddressId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("AddressEntityUserEntity");
                });

            modelBuilder.Entity("Projektgrupp4.Models.Entities.AddressEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StreetNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Adresses");
                });

            modelBuilder.Entity("Projektgrupp4.Models.Entities.CategoryEntity", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Men"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Women"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Kids"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Accessories"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Shoes"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Dresses"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Pants"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Bestsellers"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Featured"
                        });
                });

            modelBuilder.Entity("Projektgrupp4.Models.Entities.ColorEntity", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorId"));

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorId");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            ColorId = 1,
                            ColorName = "White"
                        },
                        new
                        {
                            ColorId = 2,
                            ColorName = "Black"
                        },
                        new
                        {
                            ColorId = 3,
                            ColorName = "Red"
                        },
                        new
                        {
                            ColorId = 4,
                            ColorName = "Green"
                        },
                        new
                        {
                            ColorId = 5,
                            ColorName = "Blue"
                        },
                        new
                        {
                            ColorId = 6,
                            ColorName = "Beige"
                        },
                        new
                        {
                            ColorId = 7,
                            ColorName = "LightBlue"
                        },
                        new
                        {
                            ColorId = 8,
                            ColorName = "DarkBlue"
                        },
                        new
                        {
                            ColorId = 9,
                            ColorName = "Orange"
                        },
                        new
                        {
                            ColorId = 10,
                            ColorName = "Yellow"
                        });
                });

            modelBuilder.Entity("Projektgrupp4.Models.Entities.ProductCategoriesEntity", b =>
                {
                    b.Property<int>("ProductCategoryRowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductCategoryRowId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductCategoryRowId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("Projektgrupp4.Models.Entities.ProductEntity", b =>
                {
                    b.Property<int>("ArticleNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleNumber"));

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ProductOfferPrice")
                        .HasColumnType("money");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("money");

                    b.Property<bool>("ProductPriceOrOffer")
                        .HasColumnType("bit");

                    b.Property<string>("ProductTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArticleNumber");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ArticleNumber = 1,
                            ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.",
                            ProductImageUrl = "#",
                            ProductOfferPrice = 0m,
                            ProductPrice = 29.80m,
                            ProductPriceOrOffer = false,
                            ProductTitle = "Black sneakers"
                        });
                });

            modelBuilder.Entity("Projektgrupp4.Models.Entities.ProductItemEntity", b =>
                {
                    b.Property<int>("ProductEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductEntryId"));

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.HasKey("ProductEntryId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SizeId");

                    b.ToTable("ProductItem");
                });

            modelBuilder.Entity("Projektgrupp4.Models.Entities.ReviewEntity", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Projektgrupp4.Models.Entities.SizeEntity", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SizeId"));

                    b.Property<string>("SizeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SizeId");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            SizeId = 1,
                            SizeName = "XS"
                        },
                        new
                        {
                            SizeId = 2,
                            SizeName = "S"
                        },
                        new
                        {
                            SizeId = 3,
                            SizeName = "M"
                        },
                        new
                        {
                            SizeId = 4,
                            SizeName = "L"
                        },
                        new
                        {
                            SizeId = 5,
                            SizeName = "XL"
                        },
                        new
                        {
                            SizeId = 6,
                            SizeName = "XXL"
                        });
                });

            modelBuilder.Entity("Projektgrupp4.Models.Entities.UserEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AddressEntityUserEntity", b =>
                {
                    b.HasOne("Projektgrupp4.Models.Entities.AddressEntity", null)
                        .WithMany()
                        .HasForeignKey("UserAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projektgrupp4.Models.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Projektgrupp4.Models.Entities.ProductCategoriesEntity", b =>
                {
                    b.HasOne("Projektgrupp4.Models.Entities.CategoryEntity", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projektgrupp4.Models.Entities.ProductEntity", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Projektgrupp4.Models.Entities.ProductItemEntity", b =>
                {
                    b.HasOne("Projektgrupp4.Models.Entities.ColorEntity", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projektgrupp4.Models.Entities.ProductEntity", "Product")
                        .WithMany("ProductEntries")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projektgrupp4.Models.Entities.SizeEntity", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Product");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("Projektgrupp4.Models.Entities.ReviewEntity", b =>
                {
                    b.HasOne("Projektgrupp4.Models.Entities.ProductEntity", "Product")
                        .WithMany("ProductReviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Projektgrupp4.Models.Entities.ProductEntity", b =>
                {
                    b.Navigation("ProductCategories");

                    b.Navigation("ProductEntries");

                    b.Navigation("ProductReviews");
                });
#pragma warning restore 612, 618
        }
    }
}
