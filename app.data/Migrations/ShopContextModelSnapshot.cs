﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using app.data.Concrete.EfCore;

namespace app.data.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("app.entity.Body", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Body");
                });

            modelBuilder.Entity("app.entity.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("app.entity.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CartId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ManProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ManProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("app.entity.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("Like")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Post")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("WomanProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("WomanProductId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("app.entity.Genders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("app.entity.ManProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("GendersId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MansBrandsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MansCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GendersId");

                    b.HasIndex("MansBrandsId");

                    b.HasIndex("MansCategoryId");

                    b.ToTable("ManProducts");
                });

            modelBuilder.Entity("app.entity.ManProductBody", b =>
                {
                    b.Property<int>("ManProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BodyId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ManProductId", "BodyId");

                    b.HasIndex("BodyId");

                    b.ToTable("ManProductBodies");
                });

            modelBuilder.Entity("app.entity.MansBrands", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GendersId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MansCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GendersId");

                    b.HasIndex("MansCategoryId");

                    b.ToTable("MansBrands");
                });

            modelBuilder.Entity("app.entity.MansCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GendersId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GendersId");

                    b.ToTable("MansCategories");
                });

            modelBuilder.Entity("app.entity.WomanProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("GendersId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<int>("WomansBrandsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WomansCategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GendersId");

                    b.HasIndex("WomansBrandsId");

                    b.HasIndex("WomansCategoryId");

                    b.ToTable("WomanProducts");
                });

            modelBuilder.Entity("app.entity.WomanProductBody", b =>
                {
                    b.Property<int>("WomanProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BodyId")
                        .HasColumnType("INTEGER");

                    b.HasKey("WomanProductId", "BodyId");

                    b.HasIndex("BodyId");

                    b.ToTable("WomanProductBodies");
                });

            modelBuilder.Entity("app.entity.WomansBrands", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GendersId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<int>("WomansCategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GendersId");

                    b.HasIndex("WomansCategoryId");

                    b.ToTable("WomansBrands");
                });

            modelBuilder.Entity("app.entity.WomansCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GendersId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GendersId");

                    b.ToTable("WomansCategories");
                });

            modelBuilder.Entity("app.entity.CartItem", b =>
                {
                    b.HasOne("app.entity.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.entity.ManProduct", "ManProduct")
                        .WithMany()
                        .HasForeignKey("ManProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("ManProduct");
                });

            modelBuilder.Entity("app.entity.Comments", b =>
                {
                    b.HasOne("app.entity.ManProduct", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.entity.WomanProduct", null)
                        .WithMany("Comments")
                        .HasForeignKey("WomanProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("app.entity.ManProduct", b =>
                {
                    b.HasOne("app.entity.Genders", "Genders")
                        .WithMany("ManProducts")
                        .HasForeignKey("GendersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.entity.MansBrands", "MansBrands")
                        .WithMany("ManProduct")
                        .HasForeignKey("MansBrandsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.entity.MansCategory", "MansCategory")
                        .WithMany("ManProducts")
                        .HasForeignKey("MansCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genders");

                    b.Navigation("MansBrands");

                    b.Navigation("MansCategory");
                });

            modelBuilder.Entity("app.entity.ManProductBody", b =>
                {
                    b.HasOne("app.entity.Body", "Body")
                        .WithMany("ManProductBodies")
                        .HasForeignKey("BodyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.entity.ManProduct", "ManProduct")
                        .WithMany("ManProductBodies")
                        .HasForeignKey("ManProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Body");

                    b.Navigation("ManProduct");
                });

            modelBuilder.Entity("app.entity.MansBrands", b =>
                {
                    b.HasOne("app.entity.Genders", "Genders")
                        .WithMany("MansBrands")
                        .HasForeignKey("GendersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.entity.MansCategory", "MansCategory")
                        .WithMany("MansBrands")
                        .HasForeignKey("MansCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genders");

                    b.Navigation("MansCategory");
                });

            modelBuilder.Entity("app.entity.MansCategory", b =>
                {
                    b.HasOne("app.entity.Genders", "Genders")
                        .WithMany("ManCategory")
                        .HasForeignKey("GendersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genders");
                });

            modelBuilder.Entity("app.entity.WomanProduct", b =>
                {
                    b.HasOne("app.entity.Genders", "Genders")
                        .WithMany("WomanProducts")
                        .HasForeignKey("GendersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.entity.WomansBrands", "WomansBrand")
                        .WithMany("WomanProducts")
                        .HasForeignKey("WomansBrandsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.entity.WomansCategory", "WomansCategory")
                        .WithMany("WomanProducts")
                        .HasForeignKey("WomansCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genders");

                    b.Navigation("WomansBrand");

                    b.Navigation("WomansCategory");
                });

            modelBuilder.Entity("app.entity.WomanProductBody", b =>
                {
                    b.HasOne("app.entity.Body", "Body")
                        .WithMany("WomanProductBodies")
                        .HasForeignKey("BodyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.entity.WomanProduct", "WomanProduct")
                        .WithMany("WomanProductBodies")
                        .HasForeignKey("WomanProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Body");

                    b.Navigation("WomanProduct");
                });

            modelBuilder.Entity("app.entity.WomansBrands", b =>
                {
                    b.HasOne("app.entity.Genders", "Genders")
                        .WithMany("WomansBrands")
                        .HasForeignKey("GendersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.entity.WomansCategory", "WomansCategory")
                        .WithMany("WomansBrands")
                        .HasForeignKey("WomansCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genders");

                    b.Navigation("WomansCategory");
                });

            modelBuilder.Entity("app.entity.WomansCategory", b =>
                {
                    b.HasOne("app.entity.Genders", "Genders")
                        .WithMany("WomansCategories")
                        .HasForeignKey("GendersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genders");
                });

            modelBuilder.Entity("app.entity.Body", b =>
                {
                    b.Navigation("ManProductBodies");

                    b.Navigation("WomanProductBodies");
                });

            modelBuilder.Entity("app.entity.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("app.entity.Genders", b =>
                {
                    b.Navigation("ManCategory");

                    b.Navigation("ManProducts");

                    b.Navigation("MansBrands");

                    b.Navigation("WomanProducts");

                    b.Navigation("WomansBrands");

                    b.Navigation("WomansCategories");
                });

            modelBuilder.Entity("app.entity.ManProduct", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("ManProductBodies");
                });

            modelBuilder.Entity("app.entity.MansBrands", b =>
                {
                    b.Navigation("ManProduct");
                });

            modelBuilder.Entity("app.entity.MansCategory", b =>
                {
                    b.Navigation("ManProducts");

                    b.Navigation("MansBrands");
                });

            modelBuilder.Entity("app.entity.WomanProduct", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("WomanProductBodies");
                });

            modelBuilder.Entity("app.entity.WomansBrands", b =>
                {
                    b.Navigation("WomanProducts");
                });

            modelBuilder.Entity("app.entity.WomansCategory", b =>
                {
                    b.Navigation("WomanProducts");

                    b.Navigation("WomansBrands");
                });
#pragma warning restore 612, 618
        }
    }
}
