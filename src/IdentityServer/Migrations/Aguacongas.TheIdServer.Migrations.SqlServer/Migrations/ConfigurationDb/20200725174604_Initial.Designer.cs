﻿// Project: Aguafrommars/TheIdServer
// Copyright (c) 2022 @Olivier Lefebvre
using System;
using Aguacongas.IdentityServer.EntityFramework.Store;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aguacongas.TheIdServer.SqlServer.Migrations.ConfigurationDb
{
    [DbContext(typeof(ConfigurationDbContext))]
    [Migration("20200725174604_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Aguacongas.IdentityServer.EntityFramework.Store.SchemeDefinition", b =>
                {
                    b.Property<string>("Scheme")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MapDefaultOutboundClaimType")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("SerializedHandlerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerializedOptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("StoreClaims")
                        .HasColumnType("bit");

                    b.HasKey("Scheme");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ApiApiScope", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApiId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApiScopeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ApiId");

                    b.HasIndex("ApiScopeId");

                    b.ToTable("ApiApiScope");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ApiClaim", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApiId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("ApiId", "Type")
                        .IsUnique();

                    b.ToTable("ApiClaims");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ApiLocalizedResource", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApiId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CultureId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ResourceKind")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApiId");

                    b.ToTable("ApiLocalizedResources");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ApiProperty", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApiId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ApiId", "Key")
                        .IsUnique();

                    b.ToTable("ApiProperty");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ApiScope", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("Emphasize")
                        .HasColumnType("bit");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Required")
                        .HasColumnType("bit");

                    b.Property<bool>("ShowInDiscoveryDocument")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ApiScopes");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ApiScopeClaim", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApiScopeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("ApiScopeId", "Type")
                        .IsUnique();

                    b.ToTable("ApiScopeClaims");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ApiScopeLocalizedResource", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApiScopeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CultureId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ResourceKind")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApiScopeId");

                    b.ToTable("ApiScopeLocalizedResources");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ApiScopeProperty", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApiScopeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ApiScopeId", "Key")
                        .IsUnique();

                    b.ToTable("ApiScopeProperty");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ApiSecret", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApiId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApiId");

                    b.ToTable("ApiSecrets");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.Client", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AbsoluteRefreshTokenLifetime")
                        .HasColumnType("int");

                    b.Property<int>("AccessTokenLifetime")
                        .HasColumnType("int");

                    b.Property<int>("AccessTokenType")
                        .HasColumnType("int");

                    b.Property<bool>("AllowAccessTokensViaBrowser")
                        .HasColumnType("bit");

                    b.Property<bool>("AllowOfflineAccess")
                        .HasColumnType("bit");

                    b.Property<bool>("AllowPlainTextPkce")
                        .HasColumnType("bit");

                    b.Property<bool>("AllowRememberConsent")
                        .HasColumnType("bit");

                    b.Property<bool>("AlwaysIncludeUserClaimsInIdToken")
                        .HasColumnType("bit");

                    b.Property<bool>("AlwaysSendClientClaims")
                        .HasColumnType("bit");

                    b.Property<int>("AuthorizationCodeLifetime")
                        .HasColumnType("int");

                    b.Property<bool>("BackChannelLogoutSessionRequired")
                        .HasColumnType("bit");

                    b.Property<string>("BackChannelLogoutUri")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("ClientClaimsPrefix")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientUri")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<int?>("ConsentLifetime")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<int>("DeviceCodeLifetime")
                        .HasColumnType("int");

                    b.Property<bool>("EnableLocalLogin")
                        .HasColumnType("bit");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<bool>("FrontChannelLogoutSessionRequired")
                        .HasColumnType("bit");

                    b.Property<string>("FrontChannelLogoutUri")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<int>("IdentityTokenLifetime")
                        .HasColumnType("int");

                    b.Property<bool>("IncludeJwtId")
                        .HasColumnType("bit");

                    b.Property<string>("LogoUri")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("NonEditable")
                        .HasColumnType("bit");

                    b.Property<string>("PairWiseSubjectSalt")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ProtocolType")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("RefreshTokenExpiration")
                        .HasColumnType("int");

                    b.Property<int>("RefreshTokenUsage")
                        .HasColumnType("int");

                    b.Property<bool>("RequireClientSecret")
                        .HasColumnType("bit");

                    b.Property<bool>("RequireConsent")
                        .HasColumnType("bit");

                    b.Property<bool>("RequirePkce")
                        .HasColumnType("bit");

                    b.Property<int>("SlidingRefreshTokenLifetime")
                        .HasColumnType("int");

                    b.Property<bool>("UpdateAccessTokenClaimsOnRefresh")
                        .HasColumnType("bit");

                    b.Property<string>("UserCodeType")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("UserSsoLifetime")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ClientClaim", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientClaims");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ClientGrantType", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("GrantType")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClientId", "GrantType")
                        .IsUnique();

                    b.ToTable("ClientGrantTypes");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ClientIdpRestriction", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ClientId", "Provider")
                        .IsUnique();

                    b.ToTable("ClientIdpRestriction");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ClientLocalizedResource", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CultureId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ResourceKind")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientLocalizedResources");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ClientProperty", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ClientId", "Key")
                        .IsUnique();

                    b.ToTable("ClientProperties");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ClientScope", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Scope")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ClientId", "Scope")
                        .IsUnique();

                    b.ToTable("ClientScopes");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ClientSecret", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientSecrets");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ClientUri", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Kind")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("SanetizedCorsUri")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("Uri")
                        .IsRequired()
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ClientId", "Uri")
                        .IsUnique();

                    b.ToTable("ClientUris");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.Culture", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cultures");

                    b.HasData(
                        new
                        {
                            Id = "en",
                            CreatedAt = new DateTime(2020, 7, 25, 17, 46, 3, 962, DateTimeKind.Utc).AddTicks(2581)
                        });
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ExternalClaimTransformation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("AsMultipleValues")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FromClaimType")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Scheme")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ToClaimType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Scheme", "FromClaimType")
                        .IsUnique();

                    b.ToTable("ExternalClaimTransformations");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.IdentityClaim", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdentityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("IdentityId", "Type")
                        .IsUnique()
                        .HasFilter("[Type] IS NOT NULL");

                    b.ToTable("IdentityClaims");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.IdentityLocalizedResource", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CultureId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ResourceKind")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentityId");

                    b.ToTable("IdentityLocalizedResources");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.IdentityProperty", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdentityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("IdentityId", "Key")
                        .IsUnique();

                    b.ToTable("IdentityProperties");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.IdentityResource", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("Emphasize")
                        .HasColumnType("bit");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("NonEditable")
                        .HasColumnType("bit");

                    b.Property<bool>("Required")
                        .HasColumnType("bit");

                    b.Property<bool>("ShowInDiscoveryDocument")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Identities");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.LocalizedResource", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BaseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CultureId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CultureId");

                    b.ToTable("LocalizedResources");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ProtectResource", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("NonEditable")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Apis");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ApiApiScope", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.ProtectResource", "Api")
                        .WithMany("ApiScopes")
                        .HasForeignKey("ApiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.ApiScope", "ApiScope")
                        .WithMany("Apis")
                        .HasForeignKey("ApiScopeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ApiClaim", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.ProtectResource", "Api")
                        .WithMany("ApiClaims")
                        .HasForeignKey("ApiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ApiLocalizedResource", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.ProtectResource", "Api")
                        .WithMany("Resources")
                        .HasForeignKey("ApiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ApiProperty", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.ProtectResource", "Api")
                        .WithMany("Properties")
                        .HasForeignKey("ApiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ApiScopeClaim", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.ApiScope", "ApiScope")
                        .WithMany("ApiScopeClaims")
                        .HasForeignKey("ApiScopeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ApiScopeLocalizedResource", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.ApiScope", "ApiScope")
                        .WithMany("Resources")
                        .HasForeignKey("ApiScopeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ApiScopeProperty", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.ApiScope", "ApiScope")
                        .WithMany("Properties")
                        .HasForeignKey("ApiScopeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ApiSecret", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.ProtectResource", "Api")
                        .WithMany("Secrets")
                        .HasForeignKey("ApiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ClientClaim", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.Client", "Client")
                        .WithMany("ClientClaims")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ClientGrantType", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.Client", "Client")
                        .WithMany("AllowedGrantTypes")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ClientIdpRestriction", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.Client", "Client")
                        .WithMany("IdentityProviderRestrictions")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ClientLocalizedResource", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.Client", "Client")
                        .WithMany("Resources")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ClientProperty", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.Client", "Client")
                        .WithMany("Properties")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ClientScope", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.Client", "Client")
                        .WithMany("AllowedScopes")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ClientSecret", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.Client", "Client")
                        .WithMany("ClientSecrets")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ClientUri", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.Client", "Client")
                        .WithMany("RedirectUris")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ExternalClaimTransformation", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.EntityFramework.Store.SchemeDefinition", null)
                        .WithMany("ClaimTransformations")
                        .HasForeignKey("Scheme")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.IdentityClaim", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.IdentityResource", "Identity")
                        .WithMany("IdentityClaims")
                        .HasForeignKey("IdentityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.IdentityLocalizedResource", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.IdentityResource", "Identity")
                        .WithMany("Resources")
                        .HasForeignKey("IdentityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.IdentityProperty", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.IdentityResource", "Identity")
                        .WithMany("Properties")
                        .HasForeignKey("IdentityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.LocalizedResource", b =>
                {
                    b.HasOne("Aguacongas.IdentityServer.Store.Entity.Culture", "Culture")
                        .WithMany("Resources")
                        .HasForeignKey("CultureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
