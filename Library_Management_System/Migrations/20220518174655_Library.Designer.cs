﻿// <auto-generated />
using Library_Management_System.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Library_Management_System.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20220518174655_Library")]
    partial class Library
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Library_Management_System.DataAccess.Model.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Author_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"), 1L, 1);

                    b.Property<string>("AuthorName")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Author_Name");

                    b.HasKey("AuthorId");

                    b.ToTable("Author_table");
                });

            modelBuilder.Entity("Library_Management_System.DataAccess.Model.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Book_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int")
                        .HasColumnName("Author_Id");

                    b.Property<string>("BookCode")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("BookPrice")
                        .HasColumnType("int")
                        .HasColumnName("Book_Price");

                    b.Property<string>("BookTitle")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Book_Title");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int")
                        .HasColumnName("Publisher_Id");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookCode")
                        .IsUnique()
                        .HasFilter("[BookCode] IS NOT NULL");

                    b.HasIndex("PublisherId");

                    b.ToTable("BookTable");
                });

            modelBuilder.Entity("Library_Management_System.DataAccess.Model.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Publisher_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PublisherId"), 1L, 1);

                    b.Property<string>("PublisherName")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Publisher_Name");

                    b.HasKey("PublisherId");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("Library_Management_System.DataAccess.Model.Book", b =>
                {
                    b.HasOne("Library_Management_System.DataAccess.Model.Author", "author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_Management_System.DataAccess.Model.Publisher", "publisher")
                        .WithMany()
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("author");

                    b.Navigation("publisher");
                });
#pragma warning restore 612, 618
        }
    }
}
