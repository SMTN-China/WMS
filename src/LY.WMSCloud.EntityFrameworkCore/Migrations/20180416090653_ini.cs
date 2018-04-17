using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LY.WMSCloud.Migrations
{
    public partial class ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbpAuditLogs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BrowserInfo = table.Column<string>(maxLength: 256, nullable: true),
                    ClientIpAddress = table.Column<string>(maxLength: 64, nullable: true),
                    ClientName = table.Column<string>(maxLength: 128, nullable: true),
                    CustomData = table.Column<string>(maxLength: 2000, nullable: true),
                    Exception = table.Column<string>(maxLength: 2000, nullable: true),
                    ExecutionDuration = table.Column<int>(nullable: false),
                    ExecutionTime = table.Column<DateTime>(nullable: false),
                    ImpersonatorTenantId = table.Column<int>(nullable: true),
                    ImpersonatorUserId = table.Column<long>(nullable: true),
                    MethodName = table.Column<string>(maxLength: 256, nullable: true),
                    Parameters = table.Column<string>(maxLength: 1024, nullable: true),
                    ServiceName = table.Column<string>(maxLength: 256, nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpAuditLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpBackgroundJobs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    IsAbandoned = table.Column<bool>(nullable: false),
                    JobArgs = table.Column<string>(maxLength: 1048576, nullable: false),
                    JobType = table.Column<string>(maxLength: 512, nullable: false),
                    LastTryTime = table.Column<DateTime>(nullable: true),
                    NextTryTime = table.Column<DateTime>(nullable: false),
                    Priority = table.Column<byte>(nullable: false),
                    TryCount = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpBackgroundJobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpEditions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    DisplayName = table.Column<string>(maxLength: 64, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpEditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpEntityChangeSets",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BrowserInfo = table.Column<string>(maxLength: 256, nullable: true),
                    ClientIpAddress = table.Column<string>(maxLength: 64, nullable: true),
                    ClientName = table.Column<string>(maxLength: 128, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    ExtensionData = table.Column<string>(nullable: true),
                    ImpersonatorTenantId = table.Column<int>(nullable: true),
                    ImpersonatorUserId = table.Column<long>(nullable: true),
                    Reason = table.Column<string>(maxLength: 256, nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpEntityChangeSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    DisplayName = table.Column<string>(maxLength: 64, nullable: false),
                    Icon = table.Column<string>(maxLength: 128, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsDisabled = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 10, nullable: false),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpLanguages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpLanguageTexts",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    Key = table.Column<string>(maxLength: 256, nullable: false),
                    LanguageName = table.Column<string>(maxLength: 10, nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Source = table.Column<string>(maxLength: 128, nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    Value = table.Column<string>(maxLength: 67108864, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpLanguageTexts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpNotifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    Data = table.Column<string>(maxLength: 1048576, nullable: true),
                    DataTypeName = table.Column<string>(maxLength: 512, nullable: true),
                    EntityId = table.Column<string>(maxLength: 96, nullable: true),
                    EntityTypeAssemblyQualifiedName = table.Column<string>(maxLength: 512, nullable: true),
                    EntityTypeName = table.Column<string>(maxLength: 250, nullable: true),
                    ExcludedUserIds = table.Column<string>(maxLength: 131072, nullable: true),
                    NotificationName = table.Column<string>(maxLength: 96, nullable: false),
                    Severity = table.Column<byte>(nullable: false),
                    TenantIds = table.Column<string>(maxLength: 131072, nullable: true),
                    UserIds = table.Column<string>(maxLength: 131072, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpNotifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpNotificationSubscriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    EntityId = table.Column<string>(maxLength: 96, nullable: true),
                    EntityTypeAssemblyQualifiedName = table.Column<string>(maxLength: 512, nullable: true),
                    EntityTypeName = table.Column<string>(maxLength: 250, nullable: true),
                    NotificationName = table.Column<string>(maxLength: 96, nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpNotificationSubscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpOrganizationUnits",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 95, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    ParentId = table.Column<long>(nullable: true),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpOrganizationUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
                        column: x => x.ParentId,
                        principalTable: "AbpOrganizationUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AbpTenantNotifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    Data = table.Column<string>(maxLength: 1048576, nullable: true),
                    DataTypeName = table.Column<string>(maxLength: 512, nullable: true),
                    EntityId = table.Column<string>(maxLength: 96, nullable: true),
                    EntityTypeAssemblyQualifiedName = table.Column<string>(maxLength: 512, nullable: true),
                    EntityTypeName = table.Column<string>(maxLength: 250, nullable: true),
                    NotificationName = table.Column<string>(maxLength: 96, nullable: false),
                    Severity = table.Column<byte>(nullable: false),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpTenantNotifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserAccounts",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 256, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastLoginTime = table.Column<DateTime>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: false),
                    UserLinkId = table.Column<long>(nullable: true),
                    UserName = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserLoginAttempts",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BrowserInfo = table.Column<string>(maxLength: 256, nullable: true),
                    ClientIpAddress = table.Column<string>(maxLength: 64, nullable: true),
                    ClientName = table.Column<string>(maxLength: 128, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Result = table.Column<byte>(nullable: false),
                    TenancyName = table.Column<string>(maxLength: 64, nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: true),
                    UserNameOrEmailAddress = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserLoginAttempts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserNotifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    TenantNotificationId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserNotifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserOrganizationUnits",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    OrganizationUnitId = table.Column<long>(nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserOrganizationUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpUsers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    AuthenticationSource = table.Column<string>(maxLength: 64, nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 256, nullable: false),
                    EmailConfirmationCode = table.Column<string>(maxLength: 328, nullable: true),
                    HomeAddress = table.Column<string>(maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsEmailConfirmed = table.Column<bool>(nullable: false),
                    IsLockoutEnabled = table.Column<bool>(nullable: false),
                    IsPhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    IsTwoFactorEnabled = table.Column<bool>(nullable: false),
                    LastLoginTime = table.Column<DateTime>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LockoutEndDateUtc = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    NormalizedEmailAddress = table.Column<string>(maxLength: 256, nullable: false),
                    NormalizedUserName = table.Column<string>(maxLength: 32, nullable: false),
                    Password = table.Column<string>(maxLength: 128, nullable: false),
                    PasswordResetCode = table.Column<string>(maxLength: 328, nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    Sex = table.Column<bool>(nullable: false),
                    Surname = table.Column<string>(maxLength: 32, nullable: false),
                    Telephone = table.Column<string>(maxLength: 15, nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    UserName = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpUsers_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbpUsers_AbpUsers_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbpUsers_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SysMenu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Acl = table.Column<string>(maxLength: 30, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    ExternalLink = table.Column<string>(maxLength: 255, nullable: true),
                    Group = table.Column<bool>(nullable: false),
                    I18n = table.Column<string>(maxLength: 50, nullable: true),
                    Icon = table.Column<string>(maxLength: 30, nullable: true),
                    Index = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Link = table.Column<string>(maxLength: 255, nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    Target = table.Column<string>(maxLength: 10, nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    Text = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysMenu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysMenu_SysMenu_ParentId",
                        column: x => x.ParentId,
                        principalTable: "SysMenu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SysOrg",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 30, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysOrg", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysOrg_SysOrg_ParentId",
                        column: x => x.ParentId,
                        principalTable: "SysOrg",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSBarCodeAnalysis",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    ClassName = table.Column<string>(maxLength: 30, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsReplace = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    PropertyName = table.Column<string>(maxLength: 30, nullable: true),
                    RegEX = table.Column<string>(maxLength: 2000, nullable: true),
                    TenantId = table.Column<int>(nullable: false),
                    Test = table.Column<string>(maxLength: 1000, nullable: true),
                    TestValue = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSBarCodeAnalysis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WMSCustomer",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 30, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSCustomer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WMSStorageArea",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 30, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSStorageArea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WMSStorageLocationType",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 30, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    MoreMateriel = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSStorageLocationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpFeatures",
                columns: table => new
                {
                    EditionId = table.Column<int>(nullable: true),
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    Value = table.Column<string>(maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpFeatures_AbpEditions_EditionId",
                        column: x => x.EditionId,
                        principalTable: "AbpEditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpEntityChanges",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ChangeTime = table.Column<DateTime>(nullable: false),
                    ChangeType = table.Column<byte>(nullable: false),
                    EntityChangeSetId = table.Column<long>(nullable: false),
                    EntityId = table.Column<string>(maxLength: 48, nullable: true),
                    EntityTypeFullName = table.Column<string>(maxLength: 192, nullable: true),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpEntityChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpEntityChanges_AbpEntityChangeSets_EntityChangeSetId",
                        column: x => x.EntityChangeSetId,
                        principalTable: "AbpEntityChangeSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpSettings",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: true),
                    Value = table.Column<string>(maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpSettings_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AbpTenants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ConnectionString = table.Column<string>(maxLength: 1024, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    EditionId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    TenancyName = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpTenants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpTenants_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbpTenants_AbpUsers_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbpTenants_AbpEditions_EditionId",
                        column: x => x.EditionId,
                        principalTable: "AbpEditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbpTenants_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserClaims",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(maxLength: 256, nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpUserClaims_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserLogins",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 256, nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserLogins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpUserLogins_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserRoles",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpUserRoles_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserTokens",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpUserTokens_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WMSStorage",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 30, nullable: false),
                    AboutUserId = table.Column<int>(nullable: true),
                    AboutUserId1 = table.Column<long>(nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    IncomingMethod = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSStorage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSStorage_AbpUsers_AboutUserId1",
                        column: x => x.AboutUserId1,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AbpRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(maxLength: 5000, nullable: true),
                    DisplayName = table.Column<string>(maxLength: 64, nullable: false),
                    Grade = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsStatic = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    NormalizedName = table.Column<string>(maxLength: 32, nullable: false),
                    OrgId = table.Column<int>(nullable: true),
                    Remark = table.Column<string>(maxLength: 2000, nullable: true),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpRoles_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbpRoles_AbpUsers_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbpRoles_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbpRoles_SysOrg_OrgId",
                        column: x => x.OrgId,
                        principalTable: "SysOrg",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AbpEntityPropertyChanges",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EntityChangeId = table.Column<long>(nullable: false),
                    NewValue = table.Column<string>(maxLength: 512, nullable: true),
                    OriginalValue = table.Column<string>(maxLength: 512, nullable: true),
                    PropertyName = table.Column<string>(maxLength: 96, nullable: true),
                    PropertyTypeFullName = table.Column<string>(maxLength: 192, nullable: true),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpEntityPropertyChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId",
                        column: x => x.EntityChangeId,
                        principalTable: "AbpEntityChanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WMSLine",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 30, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    ForCustomerMStorageId = table.Column<string>(maxLength: 36, nullable: true),
                    ForSelfMStorageId = table.Column<string>(maxLength: 36, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSLine_WMSStorage_ForCustomerMStorageId",
                        column: x => x.ForCustomerMStorageId,
                        principalTable: "WMSStorage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSLine_WMSStorage_ForSelfMStorageId",
                        column: x => x.ForSelfMStorageId,
                        principalTable: "WMSStorage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSMPN",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 30, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CustomerId = table.Column<string>(maxLength: 36, nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    IncomingMethod = table.Column<int>(nullable: false),
                    Info = table.Column<string>(maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    MPNHierarchy = table.Column<int>(nullable: false),
                    MPNLevel = table.Column<int>(nullable: false),
                    MPNType = table.Column<int>(nullable: false),
                    MPQs = table.Column<string>(maxLength: 50, nullable: true),
                    MSDLevel = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    RegisterStorageId = table.Column<string>(maxLength: 36, nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    ShelfLife = table.Column<double>(nullable: false),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSMPN", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSMPN_WMSCustomer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "WMSCustomer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSMPN_WMSStorage_RegisterStorageId",
                        column: x => x.RegisterStorageId,
                        principalTable: "WMSStorage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSReelMoveMethod",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 30, nullable: false),
                    AllocationTypesStr = table.Column<string>(maxLength: 100, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    InStorageId = table.Column<string>(maxLength: 36, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSReelMoveMethod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSReelMoveMethod_WMSStorage_InStorageId",
                        column: x => x.InStorageId,
                        principalTable: "WMSStorage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSStorageLocation",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 30, nullable: false),
                    BrightColor = table.Column<int>(nullable: false),
                    BrightState = table.Column<int>(nullable: false),
                    Code = table.Column<string>(maxLength: 30, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    MainBoardId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    PositionId = table.Column<int>(nullable: false),
                    ReelId = table.Column<string>(maxLength: 100, nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    StorageAreaId = table.Column<string>(maxLength: 36, nullable: true),
                    StorageId = table.Column<string>(maxLength: 36, nullable: true),
                    StorageLocationTypeId = table.Column<string>(maxLength: 36, nullable: true),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSStorageLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSStorageLocation_WMSStorageArea_StorageAreaId",
                        column: x => x.StorageAreaId,
                        principalTable: "WMSStorageArea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSStorageLocation_WMSStorage_StorageId",
                        column: x => x.StorageId,
                        principalTable: "WMSStorage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSStorageLocation_WMSStorageLocationType_StorageLocationTypeId",
                        column: x => x.StorageLocationTypeId,
                        principalTable: "WMSStorageLocationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AbpPermissions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    IsGranted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    RoleId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpPermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpPermissions_AbpRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AbpRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbpPermissions_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpRoleClaims",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(maxLength: 256, nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpRoleClaims_AbpRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AbpRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WMSBOM",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    AllowableMoreSend = table.Column<bool>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    MoreSendPercentage = table.Column<double>(nullable: false),
                    PartNoId = table.Column<string>(maxLength: 36, nullable: true),
                    ProductId = table.Column<string>(maxLength: 36, nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    TenantId = table.Column<int>(nullable: false),
                    Version = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSBOM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSBOM_WMSMPN_PartNoId",
                        column: x => x.PartNoId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSBOM_WMSMPN_ProductId",
                        column: x => x.ProductId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSMPNStorageAreaMap",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    MPNId = table.Column<string>(maxLength: 36, nullable: true),
                    StorageAreaId = table.Column<string>(maxLength: 36, nullable: true),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSMPNStorageAreaMap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSMPNStorageAreaMap_WMSMPN_MPNId",
                        column: x => x.MPNId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSMPNStorageAreaMap_WMSStorageArea_StorageAreaId",
                        column: x => x.StorageAreaId,
                        principalTable: "WMSStorageArea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSReceivedReelBill",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    IQCCheckId = table.Column<string>(maxLength: 30, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    PartNoId = table.Column<string>(maxLength: 36, nullable: true),
                    PoId = table.Column<string>(maxLength: 200, nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    ReceivedQty = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSReceivedReelBill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSReceivedReelBill_WMSMPN_PartNoId",
                        column: x => x.PartNoId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSSlot",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    BoardSide = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    Feeder = table.Column<string>(maxLength: 50, nullable: true),
                    Index = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LineId = table.Column<string>(maxLength: 30, nullable: true),
                    LineSide = table.Column<int>(nullable: false),
                    Location = table.Column<string>(maxLength: 1000, nullable: true),
                    Machine = table.Column<string>(maxLength: 30, nullable: true),
                    MachineType = table.Column<string>(maxLength: 30, nullable: true),
                    PartNoId = table.Column<string>(maxLength: 36, nullable: true),
                    ProductId = table.Column<string>(maxLength: 36, nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    Side = table.Column<int>(nullable: false),
                    SlotName = table.Column<string>(maxLength: 30, nullable: true),
                    Table = table.Column<string>(maxLength: 10, nullable: true),
                    TenantId = table.Column<int>(nullable: false),
                    Version = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSSlot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSSlot_WMSLine_LineId",
                        column: x => x.LineId,
                        principalTable: "WMSLine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSSlot_WMSMPN_PartNoId",
                        column: x => x.PartNoId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSSlot_WMSMPN_ProductId",
                        column: x => x.ProductId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSUPH",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LineId = table.Column<string>(maxLength: 36, nullable: true),
                    Meter = table.Column<int>(nullable: false),
                    Pin = table.Column<int>(nullable: false),
                    ProductId = table.Column<string>(maxLength: 36, nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSUPH", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSUPH_WMSLine_LineId",
                        column: x => x.LineId,
                        principalTable: "WMSLine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSUPH_WMSMPN_ProductId",
                        column: x => x.ProductId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSWorkBill",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 30, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: false),
                    ExtensionData = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LineId = table.Column<string>(maxLength: 36, nullable: true),
                    PlanEndTime = table.Column<DateTime>(nullable: false),
                    PlanStartTime = table.Column<DateTime>(nullable: false),
                    ProductId = table.Column<string>(maxLength: 36, nullable: true),
                    ProductionQty = table.Column<int>(nullable: false),
                    Qty = table.Column<int>(nullable: false),
                    ReadyMQty = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
                    TenantId = table.Column<int>(nullable: false),
                    WorkBillStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSWorkBill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSWorkBill_WMSLine_LineId",
                        column: x => x.LineId,
                        principalTable: "WMSLine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSWorkBill_WMSMPN_ProductId",
                        column: x => x.ProductId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSReadyMBill",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 30, nullable: false),
                    ConsumingTime = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    DeliverObject = table.Column<DateTime>(nullable: false),
                    DeliverTime = table.Column<DateTime>(nullable: false),
                    ExtensionData = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Linestr = table.Column<string>(maxLength: 50, nullable: true),
                    MakeDetailsType = table.Column<int>(nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    Productstr = table.Column<string>(maxLength: 100, nullable: true),
                    ReReadyMBillId = table.Column<string>(maxLength: 36, nullable: true),
                    ReadyMType = table.Column<int>(nullable: false),
                    ReelMoveMethodId = table.Column<string>(maxLength: 30, nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    TenantId = table.Column<int>(nullable: false),
                    WorkBilQtys = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSReadyMBill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSReadyMBill_WMSReadyMBill_ReReadyMBillId",
                        column: x => x.ReReadyMBillId,
                        principalTable: "WMSReadyMBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReadyMBill_WMSReelMoveMethod_ReelMoveMethodId",
                        column: x => x.ReelMoveMethodId,
                        principalTable: "WMSReelMoveMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSRMMStorageMap",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    ReelMoveMethodId = table.Column<string>(maxLength: 36, nullable: true),
                    StorageId = table.Column<string>(maxLength: 36, nullable: true),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSRMMStorageMap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSRMMStorageMap_WMSReelMoveMethod_ReelMoveMethodId",
                        column: x => x.ReelMoveMethodId,
                        principalTable: "WMSReelMoveMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSRMMStorageMap_WMSStorage_StorageId",
                        column: x => x.StorageId,
                        principalTable: "WMSStorage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSWorkBillDetailed",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    BOMId = table.Column<string>(maxLength: 36, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    PartNoId = table.Column<string>(maxLength: 36, nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    ReturnQty = table.Column<int>(nullable: false),
                    SendQty = table.Column<int>(nullable: false),
                    SlotId = table.Column<string>(nullable: true),
                    TenantId = table.Column<int>(nullable: false),
                    WorkBillId = table.Column<string>(maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSWorkBillDetailed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSWorkBillDetailed_WMSBOM_BOMId",
                        column: x => x.BOMId,
                        principalTable: "WMSBOM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSWorkBillDetailed_WMSMPN_PartNoId",
                        column: x => x.PartNoId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSWorkBillDetailed_WMSSlot_SlotId",
                        column: x => x.SlotId,
                        principalTable: "WMSSlot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSWorkBillDetailed_WMSWorkBill_WorkBillId",
                        column: x => x.WorkBillId,
                        principalTable: "WMSWorkBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSReadyMBillDetailed",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    BOMId = table.Column<string>(maxLength: 36, nullable: true),
                    BatchCodes = table.Column<string>(maxLength: 50, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    DemandQty = table.Column<int>(nullable: false),
                    ExtensionData = table.Column<string>(nullable: true),
                    FollowQty = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsCut = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    PartNoId = table.Column<string>(maxLength: 36, nullable: true),
                    PriorityReplacePN = table.Column<bool>(nullable: false),
                    Qty = table.Column<int>(nullable: false),
                    ReadyMBillId = table.Column<string>(maxLength: 36, nullable: true),
                    ReelMoveMethodId = table.Column<string>(maxLength: 36, nullable: true),
                    ReplacePNs = table.Column<string>(maxLength: 50, nullable: true),
                    ReturnQty = table.Column<int>(nullable: false),
                    SendQty = table.Column<int>(nullable: false),
                    Suppliers = table.Column<string>(maxLength: 50, nullable: true),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSReadyMBillDetailed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSReadyMBillDetailed_WMSBOM_BOMId",
                        column: x => x.BOMId,
                        principalTable: "WMSBOM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReadyMBillDetailed_WMSMPN_PartNoId",
                        column: x => x.PartNoId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReadyMBillDetailed_WMSReadyMBill_ReadyMBillId",
                        column: x => x.ReadyMBillId,
                        principalTable: "WMSReadyMBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReadyMBillDetailed_WMSReelMoveMethod_ReelMoveMethodId",
                        column: x => x.ReelMoveMethodId,
                        principalTable: "WMSReelMoveMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSReadyMBillWorkBillMap",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    ReadyMBillId = table.Column<string>(nullable: true),
                    TenantId = table.Column<int>(nullable: false),
                    WorkBillId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSReadyMBillWorkBillMap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSReadyMBillWorkBillMap_WMSReadyMBill_ReadyMBillId",
                        column: x => x.ReadyMBillId,
                        principalTable: "WMSReadyMBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReadyMBillWorkBillMap_WMSWorkBill_WorkBillId",
                        column: x => x.WorkBillId,
                        principalTable: "WMSWorkBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSReadySlot",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    BoardSide = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    DemandQty = table.Column<int>(nullable: false),
                    ExtensionData = table.Column<string>(nullable: true),
                    Feeder = table.Column<string>(maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LineId = table.Column<string>(maxLength: 36, nullable: true),
                    LineSide = table.Column<int>(nullable: false),
                    Location = table.Column<string>(maxLength: 1000, nullable: true),
                    Machine = table.Column<string>(maxLength: 30, nullable: true),
                    MachineType = table.Column<string>(maxLength: 30, nullable: true),
                    PartNoId = table.Column<string>(maxLength: 36, nullable: true),
                    ProductId = table.Column<string>(maxLength: 36, nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    ReReadyMBillId = table.Column<string>(maxLength: 36, nullable: true),
                    ReadyMBillDetailedId = table.Column<string>(maxLength: 36, nullable: true),
                    SendPartNoId = table.Column<string>(maxLength: 36, nullable: true),
                    SendQty = table.Column<int>(nullable: false),
                    Side = table.Column<int>(nullable: false),
                    SlotId = table.Column<string>(nullable: true),
                    SlotName = table.Column<string>(maxLength: 30, nullable: true),
                    Table = table.Column<string>(maxLength: 10, nullable: true),
                    TenantId = table.Column<int>(nullable: false),
                    Version = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSReadySlot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSReadySlot_WMSLine_LineId",
                        column: x => x.LineId,
                        principalTable: "WMSLine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReadySlot_WMSMPN_PartNoId",
                        column: x => x.PartNoId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReadySlot_WMSMPN_ProductId",
                        column: x => x.ProductId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReadySlot_WMSReadyMBill_ReReadyMBillId",
                        column: x => x.ReReadyMBillId,
                        principalTable: "WMSReadyMBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReadySlot_WMSReadyMBillDetailed_ReadyMBillDetailedId",
                        column: x => x.ReadyMBillDetailedId,
                        principalTable: "WMSReadyMBillDetailed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReadySlot_WMSMPN_SendPartNoId",
                        column: x => x.SendPartNoId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReadySlot_WMSSlot_SlotId",
                        column: x => x.SlotId,
                        principalTable: "WMSSlot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSReel",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 60, nullable: false),
                    BatchCode = table.Column<string>(maxLength: 30, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DateCode = table.Column<string>(maxLength: 15, nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtendShelfLife = table.Column<double>(nullable: false),
                    ExtensionData = table.Column<string>(nullable: true),
                    IQCCheckId = table.Column<string>(maxLength: 30, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsUseed = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LotCode = table.Column<string>(maxLength: 50, nullable: true),
                    MakeDate = table.Column<DateTime>(nullable: false),
                    PartNoId = table.Column<string>(maxLength: 36, nullable: true),
                    PoId = table.Column<string>(maxLength: 30, nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    ReadyMBillDetailedId = table.Column<string>(maxLength: 36, nullable: true),
                    ReadyMBillId = table.Column<string>(maxLength: 30, nullable: true),
                    ReceivedReelBillId = table.Column<string>(maxLength: 36, nullable: true),
                    SlotId = table.Column<string>(nullable: true),
                    StorageId = table.Column<string>(maxLength: 36, nullable: true),
                    StorageLocationId = table.Column<string>(maxLength: 36, nullable: true),
                    StorageLocationId1 = table.Column<string>(nullable: true),
                    Supplier = table.Column<string>(maxLength: 30, nullable: true),
                    TenantId = table.Column<int>(nullable: false),
                    WorkBillDetailedId = table.Column<string>(maxLength: 36, nullable: true),
                    WorkBillId = table.Column<string>(maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSReel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSReel_WMSMPN_PartNoId",
                        column: x => x.PartNoId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReel_WMSReadyMBillDetailed_ReadyMBillDetailedId",
                        column: x => x.ReadyMBillDetailedId,
                        principalTable: "WMSReadyMBillDetailed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReel_WMSReadyMBill_ReadyMBillId",
                        column: x => x.ReadyMBillId,
                        principalTable: "WMSReadyMBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReel_WMSReceivedReelBill_ReceivedReelBillId",
                        column: x => x.ReceivedReelBillId,
                        principalTable: "WMSReceivedReelBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReel_WMSStorage_StorageId",
                        column: x => x.StorageId,
                        principalTable: "WMSStorage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReel_WMSStorageLocation_StorageLocationId1",
                        column: x => x.StorageLocationId1,
                        principalTable: "WMSStorageLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReel_WMSWorkBillDetailed_WorkBillDetailedId",
                        column: x => x.WorkBillDetailedId,
                        principalTable: "WMSWorkBillDetailed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReel_WMSWorkBill_WorkBillId",
                        column: x => x.WorkBillId,
                        principalTable: "WMSWorkBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSReelMoveMethodLog",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    PartNoId = table.Column<string>(maxLength: 36, nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    ReadyMBillDetailedId = table.Column<string>(maxLength: 36, nullable: true),
                    ReadyMBillId = table.Column<string>(maxLength: 36, nullable: true),
                    ReceivedReelBillId = table.Column<string>(maxLength: 36, nullable: true),
                    ReelId = table.Column<string>(maxLength: 100, nullable: true),
                    ReelMoveMethodId = table.Column<string>(maxLength: 36, nullable: true),
                    SlotId = table.Column<string>(nullable: true),
                    StorageLocationId = table.Column<string>(maxLength: 36, nullable: true),
                    TenantId = table.Column<int>(nullable: false),
                    WorkBillId = table.Column<string>(maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSReelMoveMethodLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSReelMoveMethodLog_WMSMPN_PartNoId",
                        column: x => x.PartNoId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelMoveMethodLog_WMSReadyMBillDetailed_ReadyMBillDetailedId",
                        column: x => x.ReadyMBillDetailedId,
                        principalTable: "WMSReadyMBillDetailed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelMoveMethodLog_WMSReadyMBill_ReadyMBillId",
                        column: x => x.ReadyMBillId,
                        principalTable: "WMSReadyMBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelMoveMethodLog_WMSReceivedReelBill_ReceivedReelBillId",
                        column: x => x.ReceivedReelBillId,
                        principalTable: "WMSReceivedReelBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelMoveMethodLog_WMSReelMoveMethod_ReelMoveMethodId",
                        column: x => x.ReelMoveMethodId,
                        principalTable: "WMSReelMoveMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelMoveMethodLog_WMSSlot_SlotId",
                        column: x => x.SlotId,
                        principalTable: "WMSSlot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelMoveMethodLog_WMSStorageLocation_StorageLocationId",
                        column: x => x.StorageLocationId,
                        principalTable: "WMSStorageLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelMoveMethodLog_WMSWorkBill_WorkBillId",
                        column: x => x.WorkBillId,
                        principalTable: "WMSWorkBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSReelSendTemp",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 60, nullable: false),
                    BOMId = table.Column<string>(maxLength: 36, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DemandQty = table.Column<int>(nullable: false),
                    DemandSendQty = table.Column<int>(nullable: false),
                    FisrtStorageLocationId = table.Column<string>(maxLength: 36, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsCut = table.Column<bool>(nullable: false),
                    IsSend = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    PartNoId = table.Column<string>(maxLength: 36, nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    ReReadyMBillId = table.Column<string>(maxLength: 36, nullable: true),
                    ReadyMBillDetailedId = table.Column<string>(maxLength: 36, nullable: true),
                    ReelMoveMethodId = table.Column<string>(maxLength: 36, nullable: true),
                    SelectQty = table.Column<int>(nullable: false),
                    SendQty = table.Column<int>(nullable: false),
                    SlotId = table.Column<string>(nullable: true),
                    StorageLocationId = table.Column<string>(maxLength: 36, nullable: true),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSReelSendTemp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSReelSendTemp_WMSBOM_BOMId",
                        column: x => x.BOMId,
                        principalTable: "WMSBOM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelSendTemp_WMSMPN_PartNoId",
                        column: x => x.PartNoId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelSendTemp_WMSReadyMBill_ReReadyMBillId",
                        column: x => x.ReReadyMBillId,
                        principalTable: "WMSReadyMBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelSendTemp_WMSReadyMBillDetailed_ReadyMBillDetailedId",
                        column: x => x.ReadyMBillDetailedId,
                        principalTable: "WMSReadyMBillDetailed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelSendTemp_WMSReelMoveMethod_ReelMoveMethodId",
                        column: x => x.ReelMoveMethodId,
                        principalTable: "WMSReelMoveMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelSendTemp_WMSSlot_SlotId",
                        column: x => x.SlotId,
                        principalTable: "WMSSlot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelSendTemp_WMSStorageLocation_StorageLocationId",
                        column: x => x.StorageLocationId,
                        principalTable: "WMSStorageLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSReelShortTemp",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    BOMId = table.Column<string>(maxLength: 36, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DemandQty = table.Column<int>(nullable: false),
                    DemandSendQty = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    PartNoId = table.Column<string>(maxLength: 36, nullable: true),
                    ReReadyMBillId = table.Column<string>(maxLength: 36, nullable: true),
                    ReadyMBillDetailedId = table.Column<string>(maxLength: 36, nullable: true),
                    SelectQty = table.Column<int>(nullable: false),
                    ShortQty = table.Column<int>(nullable: false),
                    SlotId = table.Column<string>(nullable: true),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSReelShortTemp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSReelShortTemp_WMSBOM_BOMId",
                        column: x => x.BOMId,
                        principalTable: "WMSBOM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelShortTemp_WMSMPN_PartNoId",
                        column: x => x.PartNoId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelShortTemp_WMSReadyMBill_ReReadyMBillId",
                        column: x => x.ReReadyMBillId,
                        principalTable: "WMSReadyMBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelShortTemp_WMSReadyMBillDetailed_ReadyMBillDetailedId",
                        column: x => x.ReadyMBillDetailedId,
                        principalTable: "WMSReadyMBillDetailed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelShortTemp_WMSSlot_SlotId",
                        column: x => x.SlotId,
                        principalTable: "WMSSlot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMSReelSupplyTemp",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 60, nullable: false),
                    BOMId = table.Column<string>(maxLength: 36, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    DemandQty = table.Column<int>(nullable: false),
                    DemandSendQty = table.Column<int>(nullable: false),
                    ExtensionData = table.Column<string>(nullable: true),
                    FisrtStorageLocationId = table.Column<string>(maxLength: 36, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsCut = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsSend = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    PartNoId = table.Column<string>(maxLength: 36, nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    ReReadyMBillId = table.Column<string>(maxLength: 36, nullable: true),
                    ReadyMBillDetailedId = table.Column<string>(maxLength: 36, nullable: true),
                    ReelMoveMethodId = table.Column<string>(maxLength: 36, nullable: true),
                    SelectQty = table.Column<int>(nullable: false),
                    SendQty = table.Column<int>(nullable: false),
                    SlotId = table.Column<string>(nullable: true),
                    StorageLocationId = table.Column<string>(maxLength: 36, nullable: true),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSReelSupplyTemp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSReelSupplyTemp_WMSBOM_BOMId",
                        column: x => x.BOMId,
                        principalTable: "WMSBOM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelSupplyTemp_WMSMPN_PartNoId",
                        column: x => x.PartNoId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelSupplyTemp_WMSReadyMBill_ReReadyMBillId",
                        column: x => x.ReReadyMBillId,
                        principalTable: "WMSReadyMBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelSupplyTemp_WMSReadyMBillDetailed_ReadyMBillDetailedId",
                        column: x => x.ReadyMBillDetailedId,
                        principalTable: "WMSReadyMBillDetailed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelSupplyTemp_WMSReelMoveMethod_ReelMoveMethodId",
                        column: x => x.ReelMoveMethodId,
                        principalTable: "WMSReelMoveMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelSupplyTemp_WMSSlot_SlotId",
                        column: x => x.SlotId,
                        principalTable: "WMSSlot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSReelSupplyTemp_WMSStorageLocation_StorageLocationId",
                        column: x => x.StorageLocationId,
                        principalTable: "WMSStorageLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionDuration",
                table: "AbpAuditLogs",
                columns: new[] { "TenantId", "ExecutionDuration" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionTime",
                table: "AbpAuditLogs",
                columns: new[] { "TenantId", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogs_TenantId_UserId",
                table: "AbpAuditLogs",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime",
                table: "AbpBackgroundJobs",
                columns: new[] { "IsAbandoned", "NextTryTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityChanges_EntityChangeSetId",
                table: "AbpEntityChanges",
                column: "EntityChangeSetId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityChanges_EntityTypeFullName_EntityId",
                table: "AbpEntityChanges",
                columns: new[] { "EntityTypeFullName", "EntityId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityChangeSets_TenantId_CreationTime",
                table: "AbpEntityChangeSets",
                columns: new[] { "TenantId", "CreationTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityChangeSets_TenantId_Reason",
                table: "AbpEntityChangeSets",
                columns: new[] { "TenantId", "Reason" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityChangeSets_TenantId_UserId",
                table: "AbpEntityChangeSets",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityPropertyChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges",
                column: "EntityChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpFeatures_EditionId_Name",
                table: "AbpFeatures",
                columns: new[] { "EditionId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpFeatures_TenantId_Name",
                table: "AbpFeatures",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpLanguages_TenantId_Name",
                table: "AbpLanguages",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpLanguageTexts_TenantId_Source_LanguageName_Key",
                table: "AbpLanguageTexts",
                columns: new[] { "TenantId", "Source", "LanguageName", "Key" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                columns: new[] { "NotificationName", "EntityTypeName", "EntityId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                columns: new[] { "TenantId", "NotificationName", "EntityTypeName", "EntityId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpOrganizationUnits_TenantId_Code",
                table: "AbpOrganizationUnits",
                columns: new[] { "TenantId", "Code" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpPermissions_TenantId_Name",
                table: "AbpPermissions",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpPermissions_RoleId",
                table: "AbpPermissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpPermissions_UserId",
                table: "AbpPermissions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpRoleClaims_RoleId",
                table: "AbpRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpRoleClaims_TenantId_ClaimType",
                table: "AbpRoleClaims",
                columns: new[] { "TenantId", "ClaimType" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpRoles_CreatorUserId",
                table: "AbpRoles",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpRoles_DeleterUserId",
                table: "AbpRoles",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpRoles_LastModifierUserId",
                table: "AbpRoles",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpRoles_OrgId",
                table: "AbpRoles",
                column: "OrgId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpRoles_TenantId_NormalizedName",
                table: "AbpRoles",
                columns: new[] { "TenantId", "NormalizedName" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpSettings_UserId",
                table: "AbpSettings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpSettings_TenantId_Name",
                table: "AbpSettings",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenantNotifications_TenantId",
                table: "AbpTenantNotifications",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_CreatorUserId",
                table: "AbpTenants",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_DeleterUserId",
                table: "AbpTenants",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_EditionId",
                table: "AbpTenants",
                column: "EditionId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_LastModifierUserId",
                table: "AbpTenants",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_TenancyName",
                table: "AbpTenants",
                column: "TenancyName");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserAccounts_EmailAddress",
                table: "AbpUserAccounts",
                column: "EmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserAccounts_UserName",
                table: "AbpUserAccounts",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserAccounts_TenantId_EmailAddress",
                table: "AbpUserAccounts",
                columns: new[] { "TenantId", "EmailAddress" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserAccounts_TenantId_UserId",
                table: "AbpUserAccounts",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserAccounts_TenantId_UserName",
                table: "AbpUserAccounts",
                columns: new[] { "TenantId", "UserName" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserClaims_UserId",
                table: "AbpUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserClaims_TenantId_ClaimType",
                table: "AbpUserClaims",
                columns: new[] { "TenantId", "ClaimType" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserLoginAttempts_UserId_TenantId",
                table: "AbpUserLoginAttempts",
                columns: new[] { "UserId", "TenantId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result",
                table: "AbpUserLoginAttempts",
                columns: new[] { "TenancyName", "UserNameOrEmailAddress", "Result" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserLogins_UserId",
                table: "AbpUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserLogins_TenantId_UserId",
                table: "AbpUserLogins",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserLogins_TenantId_LoginProvider_ProviderKey",
                table: "AbpUserLogins",
                columns: new[] { "TenantId", "LoginProvider", "ProviderKey" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserNotifications_UserId_State_CreationTime",
                table: "AbpUserNotifications",
                columns: new[] { "UserId", "State", "CreationTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserOrganizationUnits_TenantId_OrganizationUnitId",
                table: "AbpUserOrganizationUnits",
                columns: new[] { "TenantId", "OrganizationUnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserOrganizationUnits_TenantId_UserId",
                table: "AbpUserOrganizationUnits",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserRoles_UserId",
                table: "AbpUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserRoles_TenantId_RoleId",
                table: "AbpUserRoles",
                columns: new[] { "TenantId", "RoleId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserRoles_TenantId_UserId",
                table: "AbpUserRoles",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_CreatorUserId",
                table: "AbpUsers",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_DeleterUserId",
                table: "AbpUsers",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_LastModifierUserId",
                table: "AbpUsers",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_TenantId_NormalizedEmailAddress",
                table: "AbpUsers",
                columns: new[] { "TenantId", "NormalizedEmailAddress" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_TenantId_NormalizedUserName",
                table: "AbpUsers",
                columns: new[] { "TenantId", "NormalizedUserName" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserTokens_UserId",
                table: "AbpUserTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserTokens_TenantId_UserId",
                table: "AbpUserTokens",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_SysMenu_ParentId",
                table: "SysMenu",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_SysOrg_ParentId",
                table: "SysOrg",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSBOM_PartNoId",
                table: "WMSBOM",
                column: "PartNoId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSBOM_ProductId",
                table: "WMSBOM",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSLine_ForCustomerMStorageId",
                table: "WMSLine",
                column: "ForCustomerMStorageId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSLine_ForSelfMStorageId",
                table: "WMSLine",
                column: "ForSelfMStorageId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSMPN_CustomerId",
                table: "WMSMPN",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSMPN_RegisterStorageId",
                table: "WMSMPN",
                column: "RegisterStorageId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSMPNStorageAreaMap_MPNId",
                table: "WMSMPNStorageAreaMap",
                column: "MPNId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSMPNStorageAreaMap_StorageAreaId",
                table: "WMSMPNStorageAreaMap",
                column: "StorageAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReadyMBill_ReReadyMBillId",
                table: "WMSReadyMBill",
                column: "ReReadyMBillId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReadyMBill_ReelMoveMethodId",
                table: "WMSReadyMBill",
                column: "ReelMoveMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReadyMBillDetailed_BOMId",
                table: "WMSReadyMBillDetailed",
                column: "BOMId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReadyMBillDetailed_PartNoId",
                table: "WMSReadyMBillDetailed",
                column: "PartNoId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReadyMBillDetailed_ReadyMBillId",
                table: "WMSReadyMBillDetailed",
                column: "ReadyMBillId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReadyMBillDetailed_ReelMoveMethodId",
                table: "WMSReadyMBillDetailed",
                column: "ReelMoveMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReadyMBillWorkBillMap_ReadyMBillId",
                table: "WMSReadyMBillWorkBillMap",
                column: "ReadyMBillId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReadyMBillWorkBillMap_WorkBillId",
                table: "WMSReadyMBillWorkBillMap",
                column: "WorkBillId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReadySlot_LineId",
                table: "WMSReadySlot",
                column: "LineId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReadySlot_PartNoId",
                table: "WMSReadySlot",
                column: "PartNoId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReadySlot_ProductId",
                table: "WMSReadySlot",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReadySlot_ReReadyMBillId",
                table: "WMSReadySlot",
                column: "ReReadyMBillId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReadySlot_ReadyMBillDetailedId",
                table: "WMSReadySlot",
                column: "ReadyMBillDetailedId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReadySlot_SendPartNoId",
                table: "WMSReadySlot",
                column: "SendPartNoId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReadySlot_SlotId",
                table: "WMSReadySlot",
                column: "SlotId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReceivedReelBill_PartNoId",
                table: "WMSReceivedReelBill",
                column: "PartNoId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReel_PartNoId",
                table: "WMSReel",
                column: "PartNoId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReel_ReadyMBillDetailedId",
                table: "WMSReel",
                column: "ReadyMBillDetailedId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReel_ReadyMBillId",
                table: "WMSReel",
                column: "ReadyMBillId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReel_ReceivedReelBillId",
                table: "WMSReel",
                column: "ReceivedReelBillId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReel_StorageId",
                table: "WMSReel",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReel_StorageLocationId",
                table: "WMSReel",
                column: "StorageLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReel_StorageLocationId1",
                table: "WMSReel",
                column: "StorageLocationId1");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReel_WorkBillDetailedId",
                table: "WMSReel",
                column: "WorkBillDetailedId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReel_WorkBillId",
                table: "WMSReel",
                column: "WorkBillId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelMoveMethod_InStorageId",
                table: "WMSReelMoveMethod",
                column: "InStorageId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelMoveMethodLog_PartNoId",
                table: "WMSReelMoveMethodLog",
                column: "PartNoId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelMoveMethodLog_ReadyMBillDetailedId",
                table: "WMSReelMoveMethodLog",
                column: "ReadyMBillDetailedId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelMoveMethodLog_ReadyMBillId",
                table: "WMSReelMoveMethodLog",
                column: "ReadyMBillId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelMoveMethodLog_ReceivedReelBillId",
                table: "WMSReelMoveMethodLog",
                column: "ReceivedReelBillId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelMoveMethodLog_ReelMoveMethodId",
                table: "WMSReelMoveMethodLog",
                column: "ReelMoveMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelMoveMethodLog_SlotId",
                table: "WMSReelMoveMethodLog",
                column: "SlotId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelMoveMethodLog_StorageLocationId",
                table: "WMSReelMoveMethodLog",
                column: "StorageLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelMoveMethodLog_WorkBillId",
                table: "WMSReelMoveMethodLog",
                column: "WorkBillId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelSendTemp_BOMId",
                table: "WMSReelSendTemp",
                column: "BOMId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelSendTemp_PartNoId",
                table: "WMSReelSendTemp",
                column: "PartNoId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelSendTemp_ReReadyMBillId",
                table: "WMSReelSendTemp",
                column: "ReReadyMBillId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelSendTemp_ReadyMBillDetailedId",
                table: "WMSReelSendTemp",
                column: "ReadyMBillDetailedId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelSendTemp_ReelMoveMethodId",
                table: "WMSReelSendTemp",
                column: "ReelMoveMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelSendTemp_SlotId",
                table: "WMSReelSendTemp",
                column: "SlotId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelSendTemp_StorageLocationId",
                table: "WMSReelSendTemp",
                column: "StorageLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelShortTemp_BOMId",
                table: "WMSReelShortTemp",
                column: "BOMId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelShortTemp_PartNoId",
                table: "WMSReelShortTemp",
                column: "PartNoId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelShortTemp_ReReadyMBillId",
                table: "WMSReelShortTemp",
                column: "ReReadyMBillId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelShortTemp_ReadyMBillDetailedId",
                table: "WMSReelShortTemp",
                column: "ReadyMBillDetailedId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelShortTemp_SlotId",
                table: "WMSReelShortTemp",
                column: "SlotId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelSupplyTemp_BOMId",
                table: "WMSReelSupplyTemp",
                column: "BOMId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelSupplyTemp_PartNoId",
                table: "WMSReelSupplyTemp",
                column: "PartNoId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelSupplyTemp_ReReadyMBillId",
                table: "WMSReelSupplyTemp",
                column: "ReReadyMBillId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelSupplyTemp_ReadyMBillDetailedId",
                table: "WMSReelSupplyTemp",
                column: "ReadyMBillDetailedId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelSupplyTemp_ReelMoveMethodId",
                table: "WMSReelSupplyTemp",
                column: "ReelMoveMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelSupplyTemp_SlotId",
                table: "WMSReelSupplyTemp",
                column: "SlotId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelSupplyTemp_StorageLocationId",
                table: "WMSReelSupplyTemp",
                column: "StorageLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSRMMStorageMap_ReelMoveMethodId",
                table: "WMSRMMStorageMap",
                column: "ReelMoveMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSRMMStorageMap_StorageId",
                table: "WMSRMMStorageMap",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSSlot_LineId",
                table: "WMSSlot",
                column: "LineId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSSlot_PartNoId",
                table: "WMSSlot",
                column: "PartNoId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSSlot_ProductId",
                table: "WMSSlot",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSStorage_AboutUserId1",
                table: "WMSStorage",
                column: "AboutUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_WMSStorageLocation_ReelId",
                table: "WMSStorageLocation",
                column: "ReelId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSStorageLocation_StorageAreaId",
                table: "WMSStorageLocation",
                column: "StorageAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSStorageLocation_StorageId",
                table: "WMSStorageLocation",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSStorageLocation_StorageLocationTypeId",
                table: "WMSStorageLocation",
                column: "StorageLocationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSUPH_LineId",
                table: "WMSUPH",
                column: "LineId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSUPH_ProductId",
                table: "WMSUPH",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSWorkBill_LineId",
                table: "WMSWorkBill",
                column: "LineId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSWorkBill_ProductId",
                table: "WMSWorkBill",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSWorkBillDetailed_BOMId",
                table: "WMSWorkBillDetailed",
                column: "BOMId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSWorkBillDetailed_PartNoId",
                table: "WMSWorkBillDetailed",
                column: "PartNoId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSWorkBillDetailed_SlotId",
                table: "WMSWorkBillDetailed",
                column: "SlotId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSWorkBillDetailed_WorkBillId",
                table: "WMSWorkBillDetailed",
                column: "WorkBillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbpAuditLogs");

            migrationBuilder.DropTable(
                name: "AbpBackgroundJobs");

            migrationBuilder.DropTable(
                name: "AbpEntityPropertyChanges");

            migrationBuilder.DropTable(
                name: "AbpFeatures");

            migrationBuilder.DropTable(
                name: "AbpLanguages");

            migrationBuilder.DropTable(
                name: "AbpLanguageTexts");

            migrationBuilder.DropTable(
                name: "AbpNotifications");

            migrationBuilder.DropTable(
                name: "AbpNotificationSubscriptions");

            migrationBuilder.DropTable(
                name: "AbpOrganizationUnits");

            migrationBuilder.DropTable(
                name: "AbpPermissions");

            migrationBuilder.DropTable(
                name: "AbpRoleClaims");

            migrationBuilder.DropTable(
                name: "AbpSettings");

            migrationBuilder.DropTable(
                name: "AbpTenantNotifications");

            migrationBuilder.DropTable(
                name: "AbpTenants");

            migrationBuilder.DropTable(
                name: "AbpUserAccounts");

            migrationBuilder.DropTable(
                name: "AbpUserClaims");

            migrationBuilder.DropTable(
                name: "AbpUserLoginAttempts");

            migrationBuilder.DropTable(
                name: "AbpUserLogins");

            migrationBuilder.DropTable(
                name: "AbpUserNotifications");

            migrationBuilder.DropTable(
                name: "AbpUserOrganizationUnits");

            migrationBuilder.DropTable(
                name: "AbpUserRoles");

            migrationBuilder.DropTable(
                name: "AbpUserTokens");

            migrationBuilder.DropTable(
                name: "SysMenu");

            migrationBuilder.DropTable(
                name: "WMSBarCodeAnalysis");

            migrationBuilder.DropTable(
                name: "WMSMPNStorageAreaMap");

            migrationBuilder.DropTable(
                name: "WMSReadyMBillWorkBillMap");

            migrationBuilder.DropTable(
                name: "WMSReadySlot");

            migrationBuilder.DropTable(
                name: "WMSReel");

            migrationBuilder.DropTable(
                name: "WMSReelMoveMethodLog");

            migrationBuilder.DropTable(
                name: "WMSReelSendTemp");

            migrationBuilder.DropTable(
                name: "WMSReelShortTemp");

            migrationBuilder.DropTable(
                name: "WMSReelSupplyTemp");

            migrationBuilder.DropTable(
                name: "WMSRMMStorageMap");

            migrationBuilder.DropTable(
                name: "WMSUPH");

            migrationBuilder.DropTable(
                name: "AbpEntityChanges");

            migrationBuilder.DropTable(
                name: "AbpRoles");

            migrationBuilder.DropTable(
                name: "AbpEditions");

            migrationBuilder.DropTable(
                name: "WMSWorkBillDetailed");

            migrationBuilder.DropTable(
                name: "WMSReceivedReelBill");

            migrationBuilder.DropTable(
                name: "WMSReadyMBillDetailed");

            migrationBuilder.DropTable(
                name: "WMSStorageLocation");

            migrationBuilder.DropTable(
                name: "AbpEntityChangeSets");

            migrationBuilder.DropTable(
                name: "SysOrg");

            migrationBuilder.DropTable(
                name: "WMSSlot");

            migrationBuilder.DropTable(
                name: "WMSWorkBill");

            migrationBuilder.DropTable(
                name: "WMSBOM");

            migrationBuilder.DropTable(
                name: "WMSReadyMBill");

            migrationBuilder.DropTable(
                name: "WMSStorageArea");

            migrationBuilder.DropTable(
                name: "WMSStorageLocationType");

            migrationBuilder.DropTable(
                name: "WMSLine");

            migrationBuilder.DropTable(
                name: "WMSMPN");

            migrationBuilder.DropTable(
                name: "WMSReelMoveMethod");

            migrationBuilder.DropTable(
                name: "WMSCustomer");

            migrationBuilder.DropTable(
                name: "WMSStorage");

            migrationBuilder.DropTable(
                name: "AbpUsers");
        }
    }
}
