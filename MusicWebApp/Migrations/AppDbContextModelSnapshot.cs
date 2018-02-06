﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MusicWebApp.Models;
using System;

namespace MusicWebApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusicWebApp.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Biography");

                    b.Property<int>("GenreId");

                    b.Property<string>("Name");

                    b.HasKey("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("MusicWebApp.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageLocation");

                    b.Property<string>("Name");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("MusicWebApp.Models.Playlist", b =>
                {
                    b.Property<int>("PlaylistId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("PlaylistId");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("MusicWebApp.Models.PlaylistTrack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PlaylistId");

                    b.Property<int?>("TrackId");

                    b.HasKey("Id");

                    b.HasIndex("PlaylistId");

                    b.HasIndex("TrackId");

                    b.ToTable("PlaylistTracks");
                });

            modelBuilder.Entity("MusicWebApp.Models.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Album");

                    b.Property<int>("ArtistId");

                    b.Property<int>("Bitrate");

                    b.Property<string>("FolderPath");

                    b.Property<int?>("GenreId");

                    b.Property<string>("ImageLocation");

                    b.Property<string>("ItemType");

                    b.Property<int>("Length");

                    b.Property<string>("Lyrics");

                    b.Property<int>("Rating");

                    b.Property<int>("Size");

                    b.Property<string>("Title");

                    b.Property<string>("TrackSource");

                    b.Property<string>("TrackUrl");

                    b.Property<int>("YearReleased");

                    b.HasKey("TrackId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("MusicWebApp.Models.Artist", b =>
                {
                    b.HasOne("MusicWebApp.Models.Genre", "Genre")
                        .WithMany("Artists")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MusicWebApp.Models.PlaylistTrack", b =>
                {
                    b.HasOne("MusicWebApp.Models.Playlist", "Playlist")
                        .WithMany("PlaylistTracks")
                        .HasForeignKey("PlaylistId");

                    b.HasOne("MusicWebApp.Models.Track", "Track")
                        .WithMany("PlaylistTracks")
                        .HasForeignKey("TrackId");
                });

            modelBuilder.Entity("MusicWebApp.Models.Track", b =>
                {
                    b.HasOne("MusicWebApp.Models.Artist", "Artist")
                        .WithMany("Tracks")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MusicWebApp.Models.Genre", "Genre")
                        .WithMany("Tracks")
                        .HasForeignKey("GenreId");
                });
#pragma warning restore 612, 618
        }
    }
}