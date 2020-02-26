﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnboardingCorePort.Data;

namespace OnboardingCorePort.Migrations
{
    [DbContext(typeof(OnboardingContext))]
    partial class OnboardingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnboardingCorePort.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("OnboardingCorePort.Models.Component", b =>
                {
                    b.Property<int>("ComponentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LayoutID")
                        .HasColumnType("int");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ComponentID");

                    b.HasIndex("LayoutID");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("OnboardingCorePort.Models.Layout", b =>
                {
                    b.Property<int>("LayoutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Framework")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LayoutID");

                    b.ToTable("Layouts");
                });

            modelBuilder.Entity("OnboardingCorePort.Models.LevelSatisfied", b =>
                {
                    b.Property<int>("LevelSatisfiedID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LevelSatisfiedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LevelSatisfiedID");

                    b.ToTable("LevelsSatisfied");
                });

            modelBuilder.Entity("OnboardingCorePort.Models.Log", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DAERAIntroduction")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("HealthAndSafety")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("InformationSecurity")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NeuedaDAERARelationship")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NeuedaIntroduction")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("OrganisationStructure")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Privacy")
                        .HasColumnType("datetime2");

                    b.HasKey("UserID");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("OnboardingCorePort.Models.Page", b =>
                {
                    b.Property<int>("PageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LayoutID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PageID");

                    b.HasIndex("LayoutID");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("OnboardingCorePort.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OnboardingCorePort.Models.UserFeedback", b =>
                {
                    b.Property<int>("UserFeedbackID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LevelSatisfiedID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserFeedbackID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("LevelSatisfiedID");

                    b.HasIndex("UserID");

                    b.ToTable("UserFeedbacks");
                });

            modelBuilder.Entity("OnboardingCorePort.Models.Component", b =>
                {
                    b.HasOne("OnboardingCorePort.Models.Layout", "Layout")
                        .WithMany("Components")
                        .HasForeignKey("LayoutID");
                });

            modelBuilder.Entity("OnboardingCorePort.Models.Page", b =>
                {
                    b.HasOne("OnboardingCorePort.Models.Layout", "Layout")
                        .WithMany()
                        .HasForeignKey("LayoutID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnboardingCorePort.Models.UserFeedback", b =>
                {
                    b.HasOne("OnboardingCorePort.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnboardingCorePort.Models.LevelSatisfied", "LevelSatisfied")
                        .WithMany()
                        .HasForeignKey("LevelSatisfiedID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnboardingCorePort.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
