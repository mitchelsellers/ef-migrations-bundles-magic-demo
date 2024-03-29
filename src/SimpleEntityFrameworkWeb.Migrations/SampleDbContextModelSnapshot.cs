﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleEntityFrameworkWeb;

#nullable disable

namespace SimpleEntityFrameworkWeb.Migrations
{
    [DbContext(typeof(SampleDbContext))]
    partial class SampleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SimpleEntityFrameworkWeb.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"));

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("PersonTypeId")
                        .HasColumnType("int");

                    b.HasKey("PersonId");

                    b.HasIndex("EmailAddress")
                        .IsUnique();

                    b.HasIndex("PersonTypeId");

                    b.ToTable("CrazyTable", (string)null);
                });

            modelBuilder.Entity("SimpleEntityFrameworkWeb.Models.PersonType", b =>
                {
                    b.Property<int>("PersonTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonTypeId"));

                    b.Property<string>("PersonTypeDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("PersonTypeId");

                    b.ToTable("PersonTypes");
                });

            modelBuilder.Entity("SimpleEntityFrameworkWeb.Models.Person", b =>
                {
                    b.HasOne("SimpleEntityFrameworkWeb.Models.PersonType", "PersonType")
                        .WithMany("Persons")
                        .HasForeignKey("PersonTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonType");
                });

            modelBuilder.Entity("SimpleEntityFrameworkWeb.Models.PersonType", b =>
                {
                    b.Navigation("Persons");
                });
#pragma warning restore 612, 618
        }
    }
}
