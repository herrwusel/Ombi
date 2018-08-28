﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ombi.Store.Context;

namespace Ombi.Store.Migrations
{
    [DbContext(typeof(OmbiContext))]
    [Migration("20180828083219_MusicIssues")]
    partial class MusicIssues
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Ombi.Store.Entities.ApplicationConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Type");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("ApplicationConfiguration");
                });

            modelBuilder.Entity("Ombi.Store.Entities.Audit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuditArea");

                    b.Property<int>("AuditType");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Description");

                    b.Property<string>("User");

                    b.HasKey("Id");

                    b.ToTable("Audit");
                });

            modelBuilder.Entity("Ombi.Store.Entities.CouchPotatoCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TheMovieDbId");

                    b.HasKey("Id");

                    b.ToTable("CouchPotatoCache");
                });

            modelBuilder.Entity("Ombi.Store.Entities.EmbyContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedAt");

                    b.Property<string>("EmbyId")
                        .IsRequired();

                    b.Property<string>("ImdbId");

                    b.Property<string>("ProviderId");

                    b.Property<string>("TheMovieDbId");

                    b.Property<string>("Title");

                    b.Property<string>("TvDbId");

                    b.Property<int>("Type");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("EmbyContent");
                });

            modelBuilder.Entity("Ombi.Store.Entities.EmbyEpisode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedAt");

                    b.Property<string>("EmbyId");

                    b.Property<int>("EpisodeNumber");

                    b.Property<string>("ImdbId");

                    b.Property<string>("ParentId");

                    b.Property<string>("ProviderId");

                    b.Property<int>("SeasonNumber");

                    b.Property<string>("TheMovieDbId");

                    b.Property<string>("Title");

                    b.Property<string>("TvDbId");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("EmbyEpisode");
                });

            modelBuilder.Entity("Ombi.Store.Entities.GlobalSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<string>("SettingsName");

                    b.HasKey("Id");

                    b.ToTable("GlobalSettings");
                });

            modelBuilder.Entity("Ombi.Store.Entities.LidarrAlbumCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedAt");

                    b.Property<int>("ArtistId");

                    b.Property<string>("ForeignAlbumId");

                    b.Property<bool>("Monitored");

                    b.Property<decimal>("PercentOfTracks");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title");

                    b.Property<int>("TrackCount");

                    b.HasKey("Id");

                    b.ToTable("LidarrAlbumCache");
                });

            modelBuilder.Entity("Ombi.Store.Entities.LidarrArtistCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArtistId");

                    b.Property<string>("ArtistName");

                    b.Property<string>("ForeignArtistId");

                    b.Property<bool>("Monitored");

                    b.HasKey("Id");

                    b.ToTable("LidarrArtistCache");
                });

            modelBuilder.Entity("Ombi.Store.Entities.NotificationTemplates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Agent");

                    b.Property<bool>("Enabled");

                    b.Property<string>("Message");

                    b.Property<int>("NotificationType");

                    b.Property<string>("Subject");

                    b.HasKey("Id");

                    b.ToTable("NotificationTemplates");
                });

            modelBuilder.Entity("Ombi.Store.Entities.NotificationUserId", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedAt");

                    b.Property<string>("PlayerId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("NotificationUserId");
                });

            modelBuilder.Entity("Ombi.Store.Entities.OmbiUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Alias");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("EmbyConnectUserId");

                    b.Property<int?>("EpisodeRequestLimit");

                    b.Property<DateTime?>("LastLoggedIn");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<int?>("MovieRequestLimit");

                    b.Property<int?>("MusicRequestLimit");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ProviderUserId");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserAccessToken");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int>("UserType");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Ombi.Store.Entities.PlexEpisode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EpisodeNumber");

                    b.Property<int>("GrandparentKey");

                    b.Property<int>("Key");

                    b.Property<int>("ParentKey");

                    b.Property<int>("SeasonNumber");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("GrandparentKey");

                    b.ToTable("PlexEpisode");
                });

            modelBuilder.Entity("Ombi.Store.Entities.PlexSeasonsContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ParentKey");

                    b.Property<int>("PlexContentId");

                    b.Property<int?>("PlexServerContentId");

                    b.Property<int>("SeasonKey");

                    b.Property<int>("SeasonNumber");

                    b.HasKey("Id");

                    b.HasIndex("PlexServerContentId");

                    b.ToTable("PlexSeasonsContent");
                });

            modelBuilder.Entity("Ombi.Store.Entities.PlexServerContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedAt");

                    b.Property<string>("ImdbId");

                    b.Property<int>("Key");

                    b.Property<string>("Quality");

                    b.Property<string>("ReleaseYear");

                    b.Property<string>("TheMovieDbId");

                    b.Property<string>("Title");

                    b.Property<string>("TvDbId");

                    b.Property<int>("Type");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("PlexServerContent");
                });

            modelBuilder.Entity("Ombi.Store.Entities.RadarrCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("HasFile");

                    b.Property<int>("TheMovieDbId");

                    b.HasKey("Id");

                    b.ToTable("RadarrCache");
                });

            modelBuilder.Entity("Ombi.Store.Entities.RecentlyAddedLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedAt");

                    b.Property<string>("AlbumId");

                    b.Property<int>("ContentId");

                    b.Property<int>("ContentType");

                    b.Property<int?>("EpisodeNumber");

                    b.Property<int?>("SeasonNumber");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("RecentlyAddedLog");
                });

            modelBuilder.Entity("Ombi.Store.Entities.Requests.AlbumRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Approved");

                    b.Property<string>("ArtistName");

                    b.Property<bool>("Available");

                    b.Property<string>("Cover");

                    b.Property<bool?>("Denied");

                    b.Property<string>("DeniedReason");

                    b.Property<string>("Disk");

                    b.Property<string>("ForeignAlbumId");

                    b.Property<string>("ForeignArtistId");

                    b.Property<DateTime>("MarkedAsApproved");

                    b.Property<DateTime?>("MarkedAsAvailable");

                    b.Property<DateTime>("MarkedAsDenied");

                    b.Property<decimal>("Rating");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<int>("RequestType");

                    b.Property<DateTime>("RequestedDate");

                    b.Property<string>("RequestedUserId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("RequestedUserId");

                    b.ToTable("AlbumRequests");
                });

            modelBuilder.Entity("Ombi.Store.Entities.Requests.ChildRequests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Approved");

                    b.Property<bool>("Available");

                    b.Property<bool?>("Denied");

                    b.Property<string>("DeniedReason");

                    b.Property<int?>("IssueId");

                    b.Property<DateTime>("MarkedAsApproved");

                    b.Property<DateTime?>("MarkedAsAvailable");

                    b.Property<DateTime>("MarkedAsDenied");

                    b.Property<int>("ParentRequestId");

                    b.Property<int>("RequestType");

                    b.Property<DateTime>("RequestedDate");

                    b.Property<string>("RequestedUserId");

                    b.Property<int>("SeriesType");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ParentRequestId");

                    b.HasIndex("RequestedUserId");

                    b.ToTable("ChildRequests");
                });

            modelBuilder.Entity("Ombi.Store.Entities.Requests.IssueCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("IssueCategory");
                });

            modelBuilder.Entity("Ombi.Store.Entities.Requests.IssueComments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("IssuesId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("IssuesId");

                    b.HasIndex("UserId");

                    b.ToTable("IssueComments");
                });

            modelBuilder.Entity("Ombi.Store.Entities.Requests.Issues", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("IssueCategoryId");

                    b.Property<int?>("IssueId");

                    b.Property<string>("ProviderId");

                    b.Property<int?>("RequestId");

                    b.Property<int>("RequestType");

                    b.Property<DateTime?>("ResovledDate");

                    b.Property<int>("Status");

                    b.Property<string>("Subject");

                    b.Property<string>("Title");

                    b.Property<string>("UserReportedId");

                    b.HasKey("Id");

                    b.HasIndex("IssueCategoryId");

                    b.HasIndex("IssueId");

                    b.HasIndex("UserReportedId");

                    b.ToTable("Issues");
                });

            modelBuilder.Entity("Ombi.Store.Entities.Requests.MovieRequests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Approved");

                    b.Property<bool>("Available");

                    b.Property<string>("Background");

                    b.Property<bool?>("Denied");

                    b.Property<string>("DeniedReason");

                    b.Property<DateTime?>("DigitalReleaseDate");

                    b.Property<string>("ImdbId");

                    b.Property<int?>("IssueId");

                    b.Property<DateTime>("MarkedAsApproved");

                    b.Property<DateTime?>("MarkedAsAvailable");

                    b.Property<DateTime>("MarkedAsDenied");

                    b.Property<string>("Overview");

                    b.Property<string>("PosterPath");

                    b.Property<int>("QualityOverride");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<int>("RequestType");

                    b.Property<DateTime>("RequestedDate");

                    b.Property<string>("RequestedUserId");

                    b.Property<int>("RootPathOverride");

                    b.Property<string>("Status");

                    b.Property<int>("TheMovieDbId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("RequestedUserId");

                    b.ToTable("MovieRequests");
                });

            modelBuilder.Entity("Ombi.Store.Entities.Requests.RequestLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EpisodeCount");

                    b.Property<DateTime>("RequestDate");

                    b.Property<int>("RequestId");

                    b.Property<int>("RequestType");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RequestLog");
                });

            modelBuilder.Entity("Ombi.Store.Entities.Requests.TvRequests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Background");

                    b.Property<string>("ImdbId");

                    b.Property<string>("Overview");

                    b.Property<string>("PosterPath");

                    b.Property<int?>("QualityOverride");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<int?>("RootFolder");

                    b.Property<string>("Status");

                    b.Property<string>("Title");

                    b.Property<int>("TvDbId");

                    b.HasKey("Id");

                    b.ToTable("TvRequests");
                });

            modelBuilder.Entity("Ombi.Store.Entities.RequestSubscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RequestId");

                    b.Property<int>("RequestType");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RequestSubscription");
                });

            modelBuilder.Entity("Ombi.Store.Entities.SickRageCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TvDbId");

                    b.HasKey("Id");

                    b.ToTable("SickRageCache");
                });

            modelBuilder.Entity("Ombi.Store.Entities.SickRageEpisodeCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EpisodeNumber");

                    b.Property<int>("SeasonNumber");

                    b.Property<int>("TvDbId");

                    b.HasKey("Id");

                    b.ToTable("SickRageEpisodeCache");
                });

            modelBuilder.Entity("Ombi.Store.Entities.SonarrCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TvDbId");

                    b.HasKey("Id");

                    b.ToTable("SonarrCache");
                });

            modelBuilder.Entity("Ombi.Store.Entities.SonarrEpisodeCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EpisodeNumber");

                    b.Property<bool>("HasFile");

                    b.Property<int>("SeasonNumber");

                    b.Property<int>("TvDbId");

                    b.HasKey("Id");

                    b.ToTable("SonarrEpisodeCache");
                });

            modelBuilder.Entity("Ombi.Store.Entities.Tokens", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Token");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("Ombi.Store.Repository.Requests.EpisodeRequests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AirDate");

                    b.Property<bool>("Approved");

                    b.Property<bool>("Available");

                    b.Property<int>("EpisodeNumber");

                    b.Property<bool>("Requested");

                    b.Property<int>("SeasonId");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("SeasonId");

                    b.ToTable("EpisodeRequests");
                });

            modelBuilder.Entity("Ombi.Store.Repository.Requests.SeasonRequests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ChildRequestId");

                    b.Property<int>("SeasonNumber");

                    b.HasKey("Id");

                    b.HasIndex("ChildRequestId");

                    b.ToTable("SeasonRequests");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Ombi.Store.Entities.OmbiUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Ombi.Store.Entities.OmbiUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ombi.Store.Entities.OmbiUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Ombi.Store.Entities.OmbiUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ombi.Store.Entities.EmbyEpisode", b =>
                {
                    b.HasOne("Ombi.Store.Entities.EmbyContent", "Series")
                        .WithMany("Episodes")
                        .HasForeignKey("ParentId")
                        .HasPrincipalKey("EmbyId");
                });

            modelBuilder.Entity("Ombi.Store.Entities.NotificationUserId", b =>
                {
                    b.HasOne("Ombi.Store.Entities.OmbiUser", "User")
                        .WithMany("NotificationUserIds")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Ombi.Store.Entities.PlexEpisode", b =>
                {
                    b.HasOne("Ombi.Store.Entities.PlexServerContent", "Series")
                        .WithMany("Episodes")
                        .HasForeignKey("GrandparentKey")
                        .HasPrincipalKey("Key")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ombi.Store.Entities.PlexSeasonsContent", b =>
                {
                    b.HasOne("Ombi.Store.Entities.PlexServerContent")
                        .WithMany("Seasons")
                        .HasForeignKey("PlexServerContentId");
                });

            modelBuilder.Entity("Ombi.Store.Entities.Requests.AlbumRequest", b =>
                {
                    b.HasOne("Ombi.Store.Entities.OmbiUser", "RequestedUser")
                        .WithMany()
                        .HasForeignKey("RequestedUserId");
                });

            modelBuilder.Entity("Ombi.Store.Entities.Requests.ChildRequests", b =>
                {
                    b.HasOne("Ombi.Store.Entities.Requests.TvRequests", "ParentRequest")
                        .WithMany("ChildRequests")
                        .HasForeignKey("ParentRequestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ombi.Store.Entities.OmbiUser", "RequestedUser")
                        .WithMany()
                        .HasForeignKey("RequestedUserId");
                });

            modelBuilder.Entity("Ombi.Store.Entities.Requests.IssueComments", b =>
                {
                    b.HasOne("Ombi.Store.Entities.Requests.Issues", "Issues")
                        .WithMany("Comments")
                        .HasForeignKey("IssuesId");

                    b.HasOne("Ombi.Store.Entities.OmbiUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Ombi.Store.Entities.Requests.Issues", b =>
                {
                    b.HasOne("Ombi.Store.Entities.Requests.IssueCategory", "IssueCategory")
                        .WithMany()
                        .HasForeignKey("IssueCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ombi.Store.Entities.Requests.ChildRequests")
                        .WithMany("Issues")
                        .HasForeignKey("IssueId");

                    b.HasOne("Ombi.Store.Entities.Requests.MovieRequests")
                        .WithMany("Issues")
                        .HasForeignKey("IssueId");

                    b.HasOne("Ombi.Store.Entities.OmbiUser", "UserReported")
                        .WithMany()
                        .HasForeignKey("UserReportedId");
                });

            modelBuilder.Entity("Ombi.Store.Entities.Requests.MovieRequests", b =>
                {
                    b.HasOne("Ombi.Store.Entities.OmbiUser", "RequestedUser")
                        .WithMany()
                        .HasForeignKey("RequestedUserId");
                });

            modelBuilder.Entity("Ombi.Store.Entities.Requests.RequestLog", b =>
                {
                    b.HasOne("Ombi.Store.Entities.OmbiUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Ombi.Store.Entities.RequestSubscription", b =>
                {
                    b.HasOne("Ombi.Store.Entities.OmbiUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Ombi.Store.Entities.Tokens", b =>
                {
                    b.HasOne("Ombi.Store.Entities.OmbiUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Ombi.Store.Repository.Requests.EpisodeRequests", b =>
                {
                    b.HasOne("Ombi.Store.Repository.Requests.SeasonRequests", "Season")
                        .WithMany("Episodes")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ombi.Store.Repository.Requests.SeasonRequests", b =>
                {
                    b.HasOne("Ombi.Store.Entities.Requests.ChildRequests", "ChildRequest")
                        .WithMany("SeasonRequests")
                        .HasForeignKey("ChildRequestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
