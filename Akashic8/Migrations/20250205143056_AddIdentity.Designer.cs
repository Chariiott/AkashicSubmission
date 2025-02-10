﻿// <auto-generated />
using System;
using Akashic8.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Akashic8.Migrations
{
    [DbContext(typeof(Akashic8Context))]
    [Migration("20250205143056_AddIdentity")]
    partial class AddIdentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Akashic8.Data.Akashic8User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Akashic8.Domain.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(303),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(315),
                            Name = "Harper Lee",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(318),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(318),
                            Name = "J.R.R. Tolkien",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(320),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(320),
                            Name = "Herman Melville",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(321),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(322),
                            Name = "J.K. Rowling",
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("Akashic8.Domain.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(804),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(805),
                            Description = "A novel by Harper Lee",
                            GenreId = 1,
                            ISBN = "978-0-06-112008-4",
                            ImageUrl = "/images/To Kill A Mockingbird.jpg",
                            LanguageId = 1,
                            Name = "To Kill A Mockingbird",
                            Price = 12.99,
                            Quantity = 10,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(808),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(809),
                            Description = "A novel by J.R.R. Tolkien",
                            GenreId = 9,
                            ISBN = "978-0-21-102080-4",
                            ImageUrl = "/images/The Hobbit.jpg",
                            LanguageId = 1,
                            Name = "The Hobbit",
                            Price = 15.99,
                            Quantity = 3,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(811),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(811),
                            Description = "A novel by Herman Melville",
                            GenreId = 1,
                            ISBN = "978-0-43-265346-1",
                            ImageUrl = "/images/Moby Dick.jpg",
                            LanguageId = 1,
                            Name = "Moby-Dick",
                            Price = 11.5,
                            Quantity = 17,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 4,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(814),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(814),
                            Description = "A novel by J.K. Rowling",
                            GenreId = 9,
                            ISBN = "978-0-43-265346-1",
                            ImageUrl = "/images/Harry Potter and The Sorcerer's Stone.jpg",
                            LanguageId = 1,
                            Name = "Harry Potter and the Sorcerer's Stone",
                            Price = 18.989999999999998,
                            Quantity = 34,
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("Akashic8.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Akashic8.Domain.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(563),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(564),
                            Name = "Fiction",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(566),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(567),
                            Name = "Romance",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(568),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(568),
                            Name = "Mystery",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(570),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(570),
                            Name = "Horror",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(571),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(572),
                            Name = "Cereal Killer Thriller",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 6,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(573),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(574),
                            Name = "Non-fiction",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 7,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(575),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(575),
                            Name = "Graphic Novel",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 8,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(577),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(577),
                            Name = "Crime",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 9,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(578),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(579),
                            Name = "Fantasy",
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("Akashic8.Domain.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Language");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(697),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(698),
                            Name = "English",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(700),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(701),
                            Name = "Chinese",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(702),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(702),
                            Name = "Malay",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(703),
                            DateUpdated = new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(704),
                            Name = "Tamil",
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("Akashic8.Domain.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Akashic8.Data.Akashic8User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Akashic8.Data.Akashic8User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Akashic8.Data.Akashic8User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Akashic8.Data.Akashic8User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
