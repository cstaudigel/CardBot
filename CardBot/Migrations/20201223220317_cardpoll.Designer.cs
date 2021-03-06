﻿// <auto-generated />
using System;
using CardBot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CardBot.Migrations
{
    [DbContext(typeof(CardContext))]
    [Migration("20201223220317_cardpoll")]
    partial class cardpoll
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("CardBot.Models.CardGivings", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CardId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CardReason")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DegenerateId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("GiverId")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("ServerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("DegenerateId");

                    b.HasIndex("GiverId");

                    b.ToTable("CardGivings");
                });

            modelBuilder.Entity("CardBot.Models.Cards", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Emoji")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("FailedId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Poll")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("ServerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Value")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("CardBot.Models.Users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CardBot.Models.CardGivings", b =>
                {
                    b.HasOne("CardBot.Models.Cards", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CardBot.Models.Users", "Degenerate")
                        .WithMany()
                        .HasForeignKey("DegenerateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CardBot.Models.Users", "Giver")
                        .WithMany()
                        .HasForeignKey("GiverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
