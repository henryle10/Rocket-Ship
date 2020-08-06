﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RocketShip.Models;

namespace RocketShip.Migrations
{
    [DbContext(typeof(RSContext))]
    partial class RSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RocketShip.Models.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DeckId")
                        .HasColumnType("int");

                    b.Property<string>("StringVal")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Suit")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Val")
                        .HasColumnType("int");

                    b.HasKey("CardId");

                    b.HasIndex("DeckId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("RocketShip.Models.Deck", b =>
                {
                    b.Property<int>("DeckId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("DeckId");

                    b.ToTable("Decks");
                });

            modelBuilder.Entity("RocketShip.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("rdFourCardCardId")
                        .HasColumnType("int");

                    b.Property<int?>("rdOneCardCardId")
                        .HasColumnType("int");

                    b.Property<int?>("rdThreeCardCardId")
                        .HasColumnType("int");

                    b.Property<int?>("rdTwoCardCardId")
                        .HasColumnType("int");

                    b.HasKey("PlayerId");

                    b.HasIndex("rdFourCardCardId");

                    b.HasIndex("rdOneCardCardId");

                    b.HasIndex("rdThreeCardCardId");

                    b.HasIndex("rdTwoCardCardId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("RocketShip.Models.Card", b =>
                {
                    b.HasOne("RocketShip.Models.Deck", null)
                        .WithMany("cards")
                        .HasForeignKey("DeckId");
                });

            modelBuilder.Entity("RocketShip.Models.Player", b =>
                {
                    b.HasOne("RocketShip.Models.Card", "rdFourCard")
                        .WithMany()
                        .HasForeignKey("rdFourCardCardId");

                    b.HasOne("RocketShip.Models.Card", "rdOneCard")
                        .WithMany()
                        .HasForeignKey("rdOneCardCardId");

                    b.HasOne("RocketShip.Models.Card", "rdThreeCard")
                        .WithMany()
                        .HasForeignKey("rdThreeCardCardId");

                    b.HasOne("RocketShip.Models.Card", "rdTwoCard")
                        .WithMany()
                        .HasForeignKey("rdTwoCardCardId");
                });
#pragma warning restore 612, 618
        }
    }
}