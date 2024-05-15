﻿// <auto-generated />
using DbTarpinisAtsiskaitymas.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DbTarpinisAtsiskaitymas.Migrations
{
    [DbContext(typeof(UniversityContext))]
    [Migration("20240514144445_AddSeededData")]
    partial class AddSeededData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DbTarpinisAtsiskaitymas.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DbTarpinisAtsiskaitymas.Models.DepartmentLecture", b =>
                {
                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("LectureId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentId", "LectureId");

                    b.HasIndex("LectureId");

                    b.ToTable("DepartmentLecture");
                });

            modelBuilder.Entity("DbTarpinisAtsiskaitymas.Models.Lecture", b =>
                {
                    b.Property<int>("LectureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LectureId"));

                    b.Property<string>("LectureName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("LectureId");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("DbTarpinisAtsiskaitymas.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("StudentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DbTarpinisAtsiskaitymas.Models.StudentLecture", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("LectureId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "LectureId");

                    b.HasIndex("LectureId");

                    b.ToTable("StudentLecture");
                });

            modelBuilder.Entity("DbTarpinisAtsiskaitymas.Models.DepartmentLecture", b =>
                {
                    b.HasOne("DbTarpinisAtsiskaitymas.Models.Department", "Department")
                        .WithMany("DepartmentLectures")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbTarpinisAtsiskaitymas.Models.Lecture", "Lecture")
                        .WithMany("DepartmentLectures")
                        .HasForeignKey("LectureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Lecture");
                });

            modelBuilder.Entity("DbTarpinisAtsiskaitymas.Models.Student", b =>
                {
                    b.HasOne("DbTarpinisAtsiskaitymas.Models.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("DbTarpinisAtsiskaitymas.Models.StudentLecture", b =>
                {
                    b.HasOne("DbTarpinisAtsiskaitymas.Models.Lecture", "Lecture")
                        .WithMany("StudentLectures")
                        .HasForeignKey("LectureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbTarpinisAtsiskaitymas.Models.Student", "Student")
                        .WithMany("StudentLectures")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lecture");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("DbTarpinisAtsiskaitymas.Models.Department", b =>
                {
                    b.Navigation("DepartmentLectures");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("DbTarpinisAtsiskaitymas.Models.Lecture", b =>
                {
                    b.Navigation("DepartmentLectures");

                    b.Navigation("StudentLectures");
                });

            modelBuilder.Entity("DbTarpinisAtsiskaitymas.Models.Student", b =>
                {
                    b.Navigation("StudentLectures");
                });
#pragma warning restore 612, 618
        }
    }
}
