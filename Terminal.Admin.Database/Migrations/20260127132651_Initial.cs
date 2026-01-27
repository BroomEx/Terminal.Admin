using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Terminal.Admin.Database.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AggregationBlocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ControlSystemId = table.Column<string>(type: "TEXT", nullable: false),
                    CepsId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cepsname = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    TimeZoneId = table.Column<string>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    PowerDivider = table.Column<double>(type: "REAL", nullable: false),
                    ProviderEAN = table.Column<string>(type: "TEXT", nullable: false),
                    BaselineSupport = table.Column<bool>(type: "INTEGER", nullable: false),
                    ExternalOperationPlanSource = table.Column<bool>(type: "INTEGER", nullable: false),
                    InsCallUrl = table.Column<string>(type: "TEXT", nullable: false),
                    CepsDisconnected = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AggregationBlocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Message = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<string>(type: "TEXT", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Exception = table.Column<string>(type: "TEXT", nullable: false),
                    LogEvent = table.Column<string>(type: "TEXT", nullable: false),
                    Component = table.Column<string>(type: "TEXT", nullable: false),
                    ErrorCode = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PowerUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ControlSystemId = table.Column<string>(type: "TEXT", nullable: false),
                    CepsId = table.Column<int>(type: "INTEGER", nullable: false),
                    PowerUnitCode = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Power = table.Column<double>(type: "REAL", nullable: false),
                    FcrProvisioning = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeviceCategory = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GuidStr = table.Column<string>(type: "TEXT", nullable: false),
                    MimeType = table.Column<string>(type: "TEXT", nullable: false),
                    AbId = table.Column<int>(type: "INTEGER", nullable: false),
                    FromTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ToTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    Finished = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReportType = table.Column<int>(type: "INTEGER", nullable: false),
                    Folder = table.Column<string>(type: "TEXT", nullable: false),
                    Suffix = table.Column<string>(type: "TEXT", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportFiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupportService",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Service = table.Column<int>(type: "INTEGER", nullable: false),
                    ServiceName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportService", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaselineValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    Value = table.Column<double>(type: "REAL", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AggregationBlockId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaselineValues_AggregationBlocks_AggregationBlockId",
                        column: x => x.AggregationBlockId,
                        principalTable: "AggregationBlocks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CepsRequiredPowers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AggregationBlockId = table.Column<int>(type: "INTEGER", nullable: false),
                    ServiceType = table.Column<int>(type: "INTEGER", nullable: false),
                    Power = table.Column<double>(type: "REAL", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastDirectionChange = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CepsRequiredPowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CepsRequiredPowers_AggregationBlocks_AggregationBlockId",
                        column: x => x.AggregationBlockId,
                        principalTable: "AggregationBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstructionCalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AggregationBlockId = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Pdg_trend = table.Column<double>(type: "REAL", nullable: false),
                    mFRR_act = table.Column<double>(type: "REAL", nullable: false),
                    mFRR5_act = table.Column<double>(type: "REAL", nullable: false),
                    Psetp_del = table.Column<double>(type: "REAL", nullable: false),
                    P_lowbnd = table.Column<double>(type: "REAL", nullable: false),
                    P_uppbnd = table.Column<double>(type: "REAL", nullable: false),
                    mFRR_DAP = table.Column<double>(type: "REAL", nullable: false),
                    mFRR_DAM = table.Column<double>(type: "REAL", nullable: false),
                    mFRR_SAP = table.Column<double>(type: "REAL", nullable: false),
                    mFRR_SAM = table.Column<double>(type: "REAL", nullable: false),
                    aFRR = table.Column<double>(type: "REAL", nullable: false),
                    aFRR_act = table.Column<double>(type: "REAL", nullable: false),
                    FinalPowerChanged = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActiveAns = table.Column<string>(type: "TEXT", nullable: true),
                    ActivePowerUnits = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructionCalls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstructionCalls_AggregationBlocks_AggregationBlockId",
                        column: x => x.AggregationBlockId,
                        principalTable: "AggregationBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperationPlanSlots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Slot = table.Column<int>(type: "INTEGER", nullable: false),
                    AggregationBlockId = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FromDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ToDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Pdg = table.Column<double>(type: "REAL", nullable: false),
                    Afrr_positive = table.Column<double>(type: "REAL", nullable: false),
                    Afrr_negative = table.Column<double>(type: "REAL", nullable: false),
                    Mfrr_12_positive = table.Column<double>(type: "REAL", nullable: false),
                    Mfrr_12_positive_mb = table.Column<double>(type: "REAL", nullable: false),
                    Mfrr_12_negative = table.Column<double>(type: "REAL", nullable: false),
                    Mfrr_12_negative_mb = table.Column<double>(type: "REAL", nullable: false),
                    Mfrr_5 = table.Column<double>(type: "REAL", nullable: false),
                    UseBaseline = table.Column<bool>(type: "INTEGER", nullable: false),
                    PowerUnitsActivity = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationPlanSlots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationPlanSlots_AggregationBlocks_AggregationBlockId",
                        column: x => x.AggregationBlockId,
                        principalTable: "AggregationBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    P104Address = table.Column<int>(type: "INTEGER", nullable: false),
                    DeviceType = table.Column<int>(type: "INTEGER", nullable: false),
                    MessageType = table.Column<int>(type: "INTEGER", nullable: false),
                    AddressValueType = table.Column<int>(type: "INTEGER", nullable: false),
                    Direction = table.Column<int>(type: "INTEGER", nullable: false),
                    Multiplicator = table.Column<int>(type: "INTEGER", nullable: false),
                    Decimals = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    AggregationBlockId = table.Column<int>(type: "INTEGER", nullable: true),
                    PowerUnitId = table.Column<int>(type: "INTEGER", nullable: true),
                    SendAlways = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_AggregationBlocks_AggregationBlockId",
                        column: x => x.AggregationBlockId,
                        principalTable: "AggregationBlocks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Addresses_PowerUnits_PowerUnitId",
                        column: x => x.PowerUnitId,
                        principalTable: "PowerUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AggregationBlockPowerUnit",
                columns: table => new
                {
                    AggregationBlocksId = table.Column<int>(type: "INTEGER", nullable: false),
                    PowerUnitsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AggregationBlockPowerUnit", x => new { x.AggregationBlocksId, x.PowerUnitsId });
                    table.ForeignKey(
                        name: "FK_AggregationBlockPowerUnit_AggregationBlocks_AggregationBlocksId",
                        column: x => x.AggregationBlocksId,
                        principalTable: "AggregationBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AggregationBlockPowerUnit_PowerUnits_PowerUnitsId",
                        column: x => x.PowerUnitsId,
                        principalTable: "PowerUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TelemetryLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MessageType = table.Column<int>(type: "INTEGER", nullable: false),
                    MessageTypeName = table.Column<string>(type: "TEXT", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Value = table.Column<double>(type: "REAL", nullable: false),
                    AggregationBlockId = table.Column<int>(type: "INTEGER", nullable: true),
                    P104Address = table.Column<int>(type: "INTEGER", nullable: false),
                    PowerUnitId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelemetryLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelemetryLogs_AggregationBlocks_AggregationBlockId",
                        column: x => x.AggregationBlockId,
                        principalTable: "AggregationBlocks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TelemetryLogs_PowerUnits_PowerUnitId",
                        column: x => x.PowerUnitId,
                        principalTable: "PowerUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OfflineTelemetryReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AggregationBlockId = table.Column<int>(type: "INTEGER", nullable: true),
                    ArchiveCreated = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ArchiveUploaded = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ArchiveConfirmedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ArchiveUploadAttempts = table.Column<int>(type: "INTEGER", nullable: false),
                    CompositionCreated = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CompositionUploaded = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CompositionConfirmedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CompositionUploadAttempts = table.Column<int>(type: "INTEGER", nullable: false),
                    ArchiveRequestId = table.Column<string>(type: "TEXT", nullable: false),
                    CompositionRequestId = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    Position = table.Column<int>(type: "INTEGER", nullable: false),
                    Error = table.Column<string>(type: "TEXT", nullable: false),
                    ArchiveFileId = table.Column<int>(type: "INTEGER", nullable: false),
                    AbCompositionFileId = table.Column<int>(type: "INTEGER", nullable: false),
                    CepsUrl = table.Column<string>(type: "TEXT", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfflineTelemetryReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfflineTelemetryReports_AggregationBlocks_AggregationBlockId",
                        column: x => x.AggregationBlockId,
                        principalTable: "AggregationBlocks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OfflineTelemetryReports_ReportFiles_AbCompositionFileId",
                        column: x => x.AbCompositionFileId,
                        principalTable: "ReportFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OfflineTelemetryReports_ReportFiles_ArchiveFileId",
                        column: x => x.ArchiveFileId,
                        principalTable: "ReportFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AggregationBlockSupportService",
                columns: table => new
                {
                    AggregationBlocksId = table.Column<int>(type: "INTEGER", nullable: false),
                    SupportServicesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AggregationBlockSupportService", x => new { x.AggregationBlocksId, x.SupportServicesId });
                    table.ForeignKey(
                        name: "FK_AggregationBlockSupportService_AggregationBlocks_AggregationBlocksId",
                        column: x => x.AggregationBlocksId,
                        principalTable: "AggregationBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AggregationBlockSupportService_SupportService_SupportServicesId",
                        column: x => x.SupportServicesId,
                        principalTable: "SupportService",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CertificationTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AggregationBlockId = table.Column<int>(type: "INTEGER", nullable: false),
                    SupportServiceId = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    CertificationStart = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CertificationEnd = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ReportFileId = table.Column<int>(type: "INTEGER", nullable: true),
                    Pdg = table.Column<double>(type: "REAL", nullable: false),
                    ActivationPower = table.Column<double>(type: "REAL", nullable: false),
                    Trend = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificationTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CertificationTests_AggregationBlocks_AggregationBlockId",
                        column: x => x.AggregationBlockId,
                        principalTable: "AggregationBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CertificationTests_ReportFiles_ReportFileId",
                        column: x => x.ReportFileId,
                        principalTable: "ReportFiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CertificationTests_SupportService_SupportServiceId",
                        column: x => x.SupportServiceId,
                        principalTable: "SupportService",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinishedChanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AggregationBlockId = table.Column<int>(type: "INTEGER", nullable: true),
                    SupportServiceId = table.Column<int>(type: "INTEGER", nullable: false),
                    Value = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinishedChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinishedChanges_AggregationBlocks_AggregationBlockId",
                        column: x => x.AggregationBlockId,
                        principalTable: "AggregationBlocks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinishedChanges_SupportService_SupportServiceId",
                        column: x => x.SupportServiceId,
                        principalTable: "SupportService",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaselineCalculations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RealResidualPower = table.Column<double>(type: "REAL", nullable: false),
                    UpperLimit = table.Column<double>(type: "REAL", nullable: false),
                    LowerLimit = table.Column<double>(type: "REAL", nullable: false),
                    BaselineValue = table.Column<double>(type: "REAL", nullable: false),
                    BaselineId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineCalculations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaselineCalculations_BaselineValues_BaselineId",
                        column: x => x.BaselineId,
                        principalTable: "BaselineValues",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PowerCalculations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AggregationBlockId = table.Column<int>(type: "INTEGER", nullable: false),
                    ServiceType = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TrendedPower = table.Column<double>(type: "REAL", nullable: false),
                    UpperLimit = table.Column<double>(type: "REAL", nullable: false),
                    LowerLimit = table.Column<double>(type: "REAL", nullable: false),
                    AllowedDeviation = table.Column<double>(type: "REAL", nullable: false),
                    ReportedPower = table.Column<double>(type: "REAL", nullable: false),
                    OfferedPowerMax = table.Column<double>(type: "REAL", nullable: false),
                    OfferedPowerMin = table.Column<double>(type: "REAL", nullable: false),
                    CepsRequiredPowerId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerCalculations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PowerCalculations_AggregationBlocks_AggregationBlockId",
                        column: x => x.AggregationBlockId,
                        principalTable: "AggregationBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PowerCalculations_CepsRequiredPowers_CepsRequiredPowerId",
                        column: x => x.CepsRequiredPowerId,
                        principalTable: "CepsRequiredPowers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AggregationBlockPowerStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AggregationBlockId = table.Column<int>(type: "INTEGER", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RealPower = table.Column<double>(type: "REAL", nullable: false),
                    PdgTrend = table.Column<double>(type: "REAL", nullable: false),
                    PVS = table.Column<double>(type: "REAL", nullable: false),
                    BaselineCalculationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AggregationBlockPowerStates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AggregationBlockPowerStates_AggregationBlocks_AggregationBlockId",
                        column: x => x.AggregationBlockId,
                        principalTable: "AggregationBlocks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AggregationBlockPowerStates_BaselineCalculations_BaselineCalculationId",
                        column: x => x.BaselineCalculationId,
                        principalTable: "BaselineCalculations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AggregationBlockPowerStatePowerCalculation",
                columns: table => new
                {
                    AggregationBlockPowerStatesId = table.Column<int>(type: "INTEGER", nullable: false),
                    CalculationsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AggregationBlockPowerStatePowerCalculation", x => new { x.AggregationBlockPowerStatesId, x.CalculationsId });
                    table.ForeignKey(
                        name: "FK_AggregationBlockPowerStatePowerCalculation_AggregationBlockPowerStates_AggregationBlockPowerStatesId",
                        column: x => x.AggregationBlockPowerStatesId,
                        principalTable: "AggregationBlockPowerStates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AggregationBlockPowerStatePowerCalculation_PowerCalculations_CalculationsId",
                        column: x => x.CalculationsId,
                        principalTable: "PowerCalculations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AggregationBlockId",
                table: "Addresses",
                column: "AggregationBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PowerUnitId",
                table: "Addresses",
                column: "PowerUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AggregationBlockPowerStatePowerCalculation_CalculationsId",
                table: "AggregationBlockPowerStatePowerCalculation",
                column: "CalculationsId");

            migrationBuilder.CreateIndex(
                name: "IX_AggregationBlockPowerStates_AggregationBlockId",
                table: "AggregationBlockPowerStates",
                column: "AggregationBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_AggregationBlockPowerStates_BaselineCalculationId",
                table: "AggregationBlockPowerStates",
                column: "BaselineCalculationId");

            migrationBuilder.CreateIndex(
                name: "IX_AggregationBlockPowerStates_TimeStamp",
                table: "AggregationBlockPowerStates",
                column: "TimeStamp");

            migrationBuilder.CreateIndex(
                name: "IX_AggregationBlockPowerUnit_PowerUnitsId",
                table: "AggregationBlockPowerUnit",
                column: "PowerUnitsId");

            migrationBuilder.CreateIndex(
                name: "IX_AggregationBlockSupportService_SupportServicesId",
                table: "AggregationBlockSupportService",
                column: "SupportServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaselineCalculations_BaselineId",
                table: "BaselineCalculations",
                column: "BaselineId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineValues_AggregationBlockId",
                table: "BaselineValues",
                column: "AggregationBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineValues_TimeStamp",
                table: "BaselineValues",
                column: "TimeStamp");

            migrationBuilder.CreateIndex(
                name: "IX_CepsRequiredPowers_AggregationBlockId",
                table: "CepsRequiredPowers",
                column: "AggregationBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_CepsRequiredPowers_TimeStamp",
                table: "CepsRequiredPowers",
                column: "TimeStamp");

            migrationBuilder.CreateIndex(
                name: "IX_CertificationTests_AggregationBlockId",
                table: "CertificationTests",
                column: "AggregationBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_CertificationTests_ReportFileId",
                table: "CertificationTests",
                column: "ReportFileId");

            migrationBuilder.CreateIndex(
                name: "IX_CertificationTests_SupportServiceId",
                table: "CertificationTests",
                column: "SupportServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_FinishedChanges_AggregationBlockId",
                table: "FinishedChanges",
                column: "AggregationBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_FinishedChanges_SupportServiceId",
                table: "FinishedChanges",
                column: "SupportServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InstructionCalls_AggregationBlockId",
                table: "InstructionCalls",
                column: "AggregationBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_InstructionCalls_TimeStamp",
                table: "InstructionCalls",
                column: "TimeStamp");

            migrationBuilder.CreateIndex(
                name: "IX_OfflineTelemetryReports_AbCompositionFileId",
                table: "OfflineTelemetryReports",
                column: "AbCompositionFileId");

            migrationBuilder.CreateIndex(
                name: "IX_OfflineTelemetryReports_AggregationBlockId",
                table: "OfflineTelemetryReports",
                column: "AggregationBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_OfflineTelemetryReports_ArchiveFileId",
                table: "OfflineTelemetryReports",
                column: "ArchiveFileId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationPlanSlots_AggregationBlockId",
                table: "OperationPlanSlots",
                column: "AggregationBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationPlanSlots_FromDate_ToDate",
                table: "OperationPlanSlots",
                columns: new[] { "FromDate", "ToDate" });

            migrationBuilder.CreateIndex(
                name: "IX_PowerCalculations_AggregationBlockId",
                table: "PowerCalculations",
                column: "AggregationBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_PowerCalculations_CepsRequiredPowerId",
                table: "PowerCalculations",
                column: "CepsRequiredPowerId");

            migrationBuilder.CreateIndex(
                name: "IX_PowerCalculations_TimeStamp",
                table: "PowerCalculations",
                column: "TimeStamp");

            migrationBuilder.CreateIndex(
                name: "IX_TelemetryLogs_AggregationBlockId",
                table: "TelemetryLogs",
                column: "AggregationBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_TelemetryLogs_MessageType",
                table: "TelemetryLogs",
                column: "MessageType");

            migrationBuilder.CreateIndex(
                name: "IX_TelemetryLogs_PowerUnitId",
                table: "TelemetryLogs",
                column: "PowerUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_TelemetryLogs_TimeStamp",
                table: "TelemetryLogs",
                column: "TimeStamp");

            migrationBuilder.CreateIndex(
                name: "IX_TelemetryLogs_TimeStamp_AggregationBlockId",
                table: "TelemetryLogs",
                columns: new[] { "TimeStamp", "AggregationBlockId" });

            migrationBuilder.CreateIndex(
                name: "IX_TelemetryLogs_TimeStamp_PowerUnitId",
                table: "TelemetryLogs",
                columns: new[] { "TimeStamp", "PowerUnitId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AggregationBlockPowerStatePowerCalculation");

            migrationBuilder.DropTable(
                name: "AggregationBlockPowerUnit");

            migrationBuilder.DropTable(
                name: "AggregationBlockSupportService");

            migrationBuilder.DropTable(
                name: "ApplicationLogs");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CertificationTests");

            migrationBuilder.DropTable(
                name: "FinishedChanges");

            migrationBuilder.DropTable(
                name: "InstructionCalls");

            migrationBuilder.DropTable(
                name: "OfflineTelemetryReports");

            migrationBuilder.DropTable(
                name: "OperationPlanSlots");

            migrationBuilder.DropTable(
                name: "TelemetryLogs");

            migrationBuilder.DropTable(
                name: "AggregationBlockPowerStates");

            migrationBuilder.DropTable(
                name: "PowerCalculations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SupportService");

            migrationBuilder.DropTable(
                name: "ReportFiles");

            migrationBuilder.DropTable(
                name: "PowerUnits");

            migrationBuilder.DropTable(
                name: "BaselineCalculations");

            migrationBuilder.DropTable(
                name: "CepsRequiredPowers");

            migrationBuilder.DropTable(
                name: "BaselineValues");

            migrationBuilder.DropTable(
                name: "AggregationBlocks");
        }
    }
}
