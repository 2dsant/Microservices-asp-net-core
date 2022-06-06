﻿// <auto-generated />
using System;
using GeekShopping.OrderApi.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShopping.OrderApi.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeekShopping.OrderApi.Model.OrderDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<int?>("Count")
                        .HasColumnType("int")
                        .HasColumnName("count");

                    b.Property<long?>("OrderHeaderId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.Property<string>("ProducName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("product_name");

                    b.Property<long?>("ProductId")
                        .HasColumnType("bigint")
                        .HasColumnName("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("OrderHeaderId");

                    b.ToTable("order_details");
                });

            modelBuilder.Entity("GeekShopping.OrderApi.Model.OrderHeader", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CVV")
                        .HasColumnType("longtext")
                        .HasColumnName("cvv");

                    b.Property<string>("CardNumber")
                        .HasColumnType("longtext")
                        .HasColumnName("card_number");

                    b.Property<int?>("CartTotalItens")
                        .HasColumnType("int")
                        .HasColumnName("total_itens");

                    b.Property<string>("CouponCode")
                        .HasColumnType("longtext")
                        .HasColumnName("coupon_code");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("purchase_date");

                    b.Property<decimal?>("DiscountAmount")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("discount_amount");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("ExpiryMonthYear")
                        .HasColumnType("longtext")
                        .HasColumnName("expiry_month_year");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<DateTime?>("OrderTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("order_time");

                    b.Property<bool?>("PaymentStatus")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("payment_status");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext")
                        .HasColumnName("phone_number");

                    b.Property<decimal?>("PurchaseAmount")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("purchase_amount");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.ToTable("order_header");
                });

            modelBuilder.Entity("GeekShopping.OrderApi.Model.OrderDetail", b =>
                {
                    b.HasOne("GeekShopping.OrderApi.Model.OrderHeader", "OrderHeader")
                        .WithMany("CartDetails")
                        .HasForeignKey("OrderHeaderId");

                    b.Navigation("OrderHeader");
                });

            modelBuilder.Entity("GeekShopping.OrderApi.Model.OrderHeader", b =>
                {
                    b.Navigation("CartDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
