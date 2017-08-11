using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApp.Data;

namespace WebApp.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20170811190334_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApp.Models.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Platforms");
                });

            modelBuilder.Entity("WebApp.Models.VideoGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PlatformId");

                    b.Property<DateTime>("PublishedOn");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("PlatformId");

                    b.ToTable("VideoGames");
                });

            modelBuilder.Entity("WebApp.Models.VideoGame", b =>
                {
                    b.HasOne("WebApp.Models.Platform", "Platform")
                        .WithMany("VideoGames")
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
