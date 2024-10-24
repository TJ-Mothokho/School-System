﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School_System.Data.Context;

#nullable disable

namespace School_System.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241024062652_StudentGrade")]
    partial class StudentGrade
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("School_System.Data.Models.Domains.Grade", b =>
                {
                    b.Property<string>("GradeID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GradeID");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("School_System.Data.Models.Domains.Record", b =>
                {
                    b.Property<int>("RecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordID"));

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.Property<double>("Term1")
                        .HasColumnType("float");

                    b.Property<double>("Term2")
                        .HasColumnType("float");

                    b.Property<double>("Term3")
                        .HasColumnType("float");

                    b.Property<double>("Term4")
                        .HasColumnType("float");

                    b.HasKey("RecordID");

                    b.HasIndex("StudentID");

                    b.HasIndex("SubjectID");

                    b.ToTable("Record");
                });

            modelBuilder.Entity("School_System.Data.Models.Domains.Subject", b =>
                {
                    b.Property<int>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectID"));

                    b.Property<string>("GradeID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("SubjectID");

                    b.HasIndex("GradeID");

                    b.HasIndex("TeacherID");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("School_System.Data.Models.Domains.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("School_System.Data.Models.Domains.Staff", b =>
                {
                    b.HasBaseType("School_System.Data.Models.Domains.User");

                    b.Property<DateOnly>("DateEnded")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DateStarted")
                        .HasColumnType("date");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("School_System.Data.Models.Domains.Student", b =>
                {
                    b.HasBaseType("School_System.Data.Models.Domains.User");

                    b.Property<string>("GradeID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("GradeID");

                    b.ToTable("Students", (string)null);
                });

            modelBuilder.Entity("School_System.Data.Models.Domains.Admin", b =>
                {
                    b.HasBaseType("School_System.Data.Models.Domains.Staff");

                    b.ToTable("Admins", (string)null);
                });

            modelBuilder.Entity("School_System.Data.Models.Domains.Teacher", b =>
                {
                    b.HasBaseType("School_System.Data.Models.Domains.Staff");

                    b.Property<int>("ClassNumber")
                        .HasColumnType("int");

                    b.ToTable("Teachers", (string)null);
                });

            modelBuilder.Entity("School_System.Data.Models.Domains.Record", b =>
                {
                    b.HasOne("School_System.Data.Models.Domains.Student", "Student")
                        .WithMany("Records")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School_System.Data.Models.Domains.Subject", "Subject")
                        .WithMany("Records")
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("School_System.Data.Models.Domains.Subject", b =>
                {
                    b.HasOne("School_System.Data.Models.Domains.Grade", null)
                        .WithMany("Subjects")
                        .HasForeignKey("GradeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School_System.Data.Models.Domains.Teacher", "Teacher")
                        .WithMany("Subjects")
                        .HasForeignKey("TeacherID");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("School_System.Data.Models.Domains.Staff", b =>
                {
                    b.HasOne("School_System.Data.Models.Domains.User", null)
                        .WithOne()
                        .HasForeignKey("School_System.Data.Models.Domains.Staff", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("School_System.Data.Models.Domains.Student", b =>
                {
                    b.HasOne("School_System.Data.Models.Domains.Grade", "Grade")
                        .WithMany("Students")
                        .HasForeignKey("GradeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School_System.Data.Models.Domains.User", null)
                        .WithOne()
                        .HasForeignKey("School_System.Data.Models.Domains.Student", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("School_System.Data.Models.Domains.Admin", b =>
                {
                    b.HasOne("School_System.Data.Models.Domains.Staff", null)
                        .WithOne()
                        .HasForeignKey("School_System.Data.Models.Domains.Admin", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("School_System.Data.Models.Domains.Teacher", b =>
                {
                    b.HasOne("School_System.Data.Models.Domains.Staff", null)
                        .WithOne()
                        .HasForeignKey("School_System.Data.Models.Domains.Teacher", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("School_System.Data.Models.Domains.Grade", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("School_System.Data.Models.Domains.Subject", b =>
                {
                    b.Navigation("Records");
                });

            modelBuilder.Entity("School_System.Data.Models.Domains.Student", b =>
                {
                    b.Navigation("Records");
                });

            modelBuilder.Entity("School_System.Data.Models.Domains.Teacher", b =>
                {
                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
