﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentSystem.Data;

#nullable disable

namespace StudentSystem.Migrations
{
    [DbContext(typeof(StudentSystemContext))]
    partial class StudentSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentSystem.Data.Model.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("Description")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(80)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            Description = "Description 1",
                            EndDate = new DateTime(2023, 6, 5, 14, 35, 24, 694, DateTimeKind.Local).AddTicks(9742),
                            Name = "Course 1",
                            Price = 9.9900000000000002,
                            StartDate = new DateTime(2023, 5, 29, 14, 35, 24, 694, DateTimeKind.Local).AddTicks(9703)
                        },
                        new
                        {
                            CourseId = 2,
                            Description = "Description 2",
                            EndDate = new DateTime(2023, 6, 12, 14, 35, 24, 694, DateTimeKind.Local).AddTicks(9748),
                            Name = "Course 2",
                            Price = 19.989999999999998,
                            StartDate = new DateTime(2023, 5, 29, 14, 35, 24, 694, DateTimeKind.Local).AddTicks(9746)
                        },
                        new
                        {
                            CourseId = 3,
                            EndDate = new DateTime(2023, 6, 19, 14, 35, 24, 694, DateTimeKind.Local).AddTicks(9753),
                            Name = "Course 3",
                            Price = 29.989999999999998,
                            StartDate = new DateTime(2023, 5, 29, 14, 35, 24, 694, DateTimeKind.Local).AddTicks(9751)
                        });
                });

            modelBuilder.Entity("StudentSystem.Data.Model.HomeworkSubmission", b =>
                {
                    b.Property<int>("HomeworkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HomeworkId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("ContentType")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubmissionTime")
                        .HasColumnType("datetime2");

                    b.HasKey("HomeworkId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("HomeworkSubmissions");

                    b.HasData(
                        new
                        {
                            HomeworkId = 1,
                            Content = "Homework content 1",
                            ContentType = 0,
                            CourseId = 1,
                            StudentId = 1,
                            SubmissionTime = new DateTime(2023, 5, 29, 14, 35, 24, 695, DateTimeKind.Local).AddTicks(8597)
                        },
                        new
                        {
                            HomeworkId = 2,
                            Content = "Homework content 2",
                            ContentType = 1,
                            CourseId = 1,
                            StudentId = 2,
                            SubmissionTime = new DateTime(2023, 5, 29, 14, 35, 24, 695, DateTimeKind.Local).AddTicks(8612)
                        },
                        new
                        {
                            HomeworkId = 3,
                            Content = "Homework content 3",
                            ContentType = 2,
                            CourseId = 2,
                            StudentId = 3,
                            SubmissionTime = new DateTime(2023, 5, 29, 14, 35, 24, 695, DateTimeKind.Local).AddTicks(8614)
                        });
                });

            modelBuilder.Entity("StudentSystem.Data.Model.Resource", b =>
                {
                    b.Property<int>("ResourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResourceId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ResourceType")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResourceId");

                    b.HasIndex("CourseId");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            ResourceId = 1,
                            CourseId = 1,
                            Name = "Resource 1",
                            ResourceType = 0,
                            Url = "http://example.com/resource1"
                        },
                        new
                        {
                            ResourceId = 2,
                            CourseId = 2,
                            Name = "Resource 2",
                            ResourceType = 1,
                            Url = "http://example.com/resource2"
                        },
                        new
                        {
                            ResourceId = 3,
                            CourseId = 2,
                            Name = "Resource 3",
                            ResourceType = 2,
                            Url = "http://example.com/resource3"
                        });
                });

            modelBuilder.Entity("StudentSystem.Data.Model.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<bool>("RegisteredOn")
                        .HasColumnType("bit");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Birthday = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John Doe",
                            PhoneNumber = "1234567890",
                            RegisteredOn = true
                        },
                        new
                        {
                            StudentId = 2,
                            Birthday = new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Jane Smith",
                            RegisteredOn = false
                        },
                        new
                        {
                            StudentId = 3,
                            Birthday = new DateTime(1998, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bob Johnson",
                            PhoneNumber = "9876543210",
                            RegisteredOn = true
                        });
                });

            modelBuilder.Entity("StudentSystem.Data.Model.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourses");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            CourseId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            CourseId = 1
                        },
                        new
                        {
                            StudentId = 3,
                            CourseId = 2
                        });
                });

            modelBuilder.Entity("StudentSystem.Data.Model.HomeworkSubmission", b =>
                {
                    b.HasOne("StudentSystem.Data.Model.Course", "Course")
                        .WithMany("HomeworkSubmissions")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentSystem.Data.Model.Student", "Student")
                        .WithMany("HomeworkSubmissions")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentSystem.Data.Model.Resource", b =>
                {
                    b.HasOne("StudentSystem.Data.Model.Course", "Course")
                        .WithMany("Resources")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("StudentSystem.Data.Model.StudentCourse", b =>
                {
                    b.HasOne("StudentSystem.Data.Model.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentSystem.Data.Model.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentSystem.Data.Model.Course", b =>
                {
                    b.Navigation("HomeworkSubmissions");

                    b.Navigation("Resources");

                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("StudentSystem.Data.Model.Student", b =>
                {
                    b.Navigation("HomeworkSubmissions");

                    b.Navigation("StudentCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
