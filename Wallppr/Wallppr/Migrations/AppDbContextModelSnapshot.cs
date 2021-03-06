﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wallppr.Data;

namespace Wallppr.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Wallppr.Models.AppSetting.AppSetting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DefaultValue");

                    b.Property<int>("IsEditable");

                    b.Property<string>("SettingName")
                        .IsRequired();

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("AppSettings");
                });

            modelBuilder.Entity("Wallppr.Models.Wallpaper.Entities.Color", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ColorCode");

                    b.Property<long>("WallpaperId");

                    b.HasKey("Id");

                    b.HasIndex("WallpaperId");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Wallppr.Models.Wallpaper.Entities.Wallpaper", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddedDate")
                        .IsRequired();

                    b.Property<int>("DimensionX");

                    b.Property<int>("DimensionY");

                    b.Property<int>("IsFavorite");

                    b.Property<string>("Path");

                    b.Property<string>("Thumbnail");

                    b.Property<string>("UId");

                    b.Property<string>("WallpaperThumbUrl");

                    b.Property<string>("WallpaperType")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<string>("WallpaperUrl");

                    b.HasKey("Id");

                    b.ToTable("Wallpapers");
                });

            modelBuilder.Entity("Wallppr.Models.Wallpaper.Entities.Color", b =>
                {
                    b.HasOne("Wallppr.Models.Wallpaper.Entities.Wallpaper")
                        .WithMany("ColorPalette")
                        .HasForeignKey("WallpaperId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
