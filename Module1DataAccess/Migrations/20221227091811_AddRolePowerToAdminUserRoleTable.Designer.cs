﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Module1DataAccess.Data;

#nullable disable

namespace Module1DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221227091811_AddRolePowerToAdminUserRoleTable")]
    partial class AddRolePowerToAdminUserRoleTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Module1Model.Models.AdminUser", b =>
                {
                    b.Property<int>("adminUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("adminUserId"));

                    b.Property<int?>("adminUserRoleId")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("adminUserId");

                    b.HasIndex("adminUserRoleId");

                    b.ToTable("AdminUsers");
                });

            modelBuilder.Entity("Module1Model.Models.AdminUserRole", b =>
                {
                    b.Property<int>("adminUserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("adminUserRoleId"));

                    b.Property<string>("roleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("rolePower")
                        .HasColumnType("int");

                    b.HasKey("adminUserRoleId");

                    b.ToTable("AdminUserRoles");
                });

            modelBuilder.Entity("Module1Model.Models.Screen", b =>
                {
                    b.Property<int>("screenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("screenId"));

                    b.Property<string>("screenName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("screenId");

                    b.ToTable("Screens");
                });

            modelBuilder.Entity("Module1Model.Models.AdminUser", b =>
                {
                    b.HasOne("Module1Model.Models.AdminUserRole", null)
                        .WithMany("Books")
                        .HasForeignKey("adminUserRoleId");
                });

            modelBuilder.Entity("Module1Model.Models.AdminUserRole", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
