using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LY.WMSCloud.Migrations
{
    public partial class addMoreTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "WMSWorkBillDetailed");

            migrationBuilder.DropTable(
                name: "WMSReceivedReelBill");

            migrationBuilder.DropTable(
                name: "WMSReadyMBillDetailed");

            migrationBuilder.DropTable(
                name: "WMSStorageLocation");

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
        }
    }
}
