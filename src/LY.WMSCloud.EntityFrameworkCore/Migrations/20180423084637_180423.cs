using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LY.WMSCloud.Migrations
{
    public partial class _180423 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WorkBillId",
                table: "WMSWorkBillDetailed",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSWorkBillDetailed",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "WMSWorkBill",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LineId",
                table: "WMSWorkBill",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "WMSUPH",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LineId",
                table: "WMSUPH",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StorageId",
                table: "WMSStorageLocation",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StorageAreaId",
                table: "WMSStorageLocation",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "WMSSlot",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSSlot",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReelMoveMethodId",
                table: "WMSRMMStorageMap",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReelMoveMethodId",
                table: "WMSReelSupplyTemp",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReReadyMBillId",
                table: "WMSReelSupplyTemp",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSReelSupplyTemp",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReReadyMBillId",
                table: "WMSReelShortTemp",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSReelShortTemp",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReelMoveMethodId",
                table: "WMSReelSendTemp",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReReadyMBillId",
                table: "WMSReelSendTemp",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSReelSendTemp",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReadyMBillId",
                table: "WMSReelMoveMethodLog",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSReelMoveMethodLog",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSReel",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSReceivedReelBill",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SendPartNoId",
                table: "WMSReadySlot",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "WMSReadySlot",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSReadySlot",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LineId",
                table: "WMSReadySlot",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReadyMBillId",
                table: "WMSReadyMBillDetailed",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSReadyMBillDetailed",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReReadyMBillId",
                table: "WMSReadyMBill",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MPNId",
                table: "WMSMPNStorageAreaMap",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "WMSMPN",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "WMSPrintReel",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 30, nullable: false),
                    BatchCode = table.Column<string>(maxLength: 30, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DateCode = table.Column<string>(maxLength: 15, nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    IQCCheckId = table.Column<string>(maxLength: 30, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LotCode = table.Column<string>(maxLength: 50, nullable: true),
                    MakeDate = table.Column<DateTime>(nullable: false),
                    PartNoId = table.Column<string>(maxLength: 36, nullable: true),
                    PoId = table.Column<string>(maxLength: 30, nullable: true),
                    PrintIndex = table.Column<int>(nullable: false),
                    PrintStr = table.Column<string>(maxLength: 36, nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    ReceivedReelBillId = table.Column<string>(maxLength: 36, nullable: true),
                    Supplier = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WMSPrintReel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WMSPrintReel_WMSMPN_PartNoId",
                        column: x => x.PartNoId,
                        principalTable: "WMSMPN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WMSPrintReel_WMSReceivedReelBill_ReceivedReelBillId",
                        column: x => x.ReceivedReelBillId,
                        principalTable: "WMSReceivedReelBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WMSPrintReel_PartNoId",
                table: "WMSPrintReel",
                column: "PartNoId");

            migrationBuilder.CreateIndex(
                name: "IX_WMSPrintReel_ReceivedReelBillId",
                table: "WMSPrintReel",
                column: "ReceivedReelBillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WMSPrintReel");

            migrationBuilder.AlterColumn<string>(
                name: "WorkBillId",
                table: "WMSWorkBillDetailed",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSWorkBillDetailed",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "WMSWorkBill",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LineId",
                table: "WMSWorkBill",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "WMSUPH",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LineId",
                table: "WMSUPH",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StorageId",
                table: "WMSStorageLocation",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StorageAreaId",
                table: "WMSStorageLocation",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "WMSSlot",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSSlot",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReelMoveMethodId",
                table: "WMSRMMStorageMap",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReelMoveMethodId",
                table: "WMSReelSupplyTemp",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReReadyMBillId",
                table: "WMSReelSupplyTemp",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSReelSupplyTemp",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReReadyMBillId",
                table: "WMSReelShortTemp",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSReelShortTemp",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReelMoveMethodId",
                table: "WMSReelSendTemp",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReReadyMBillId",
                table: "WMSReelSendTemp",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSReelSendTemp",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReadyMBillId",
                table: "WMSReelMoveMethodLog",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSReelMoveMethodLog",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSReel",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSReceivedReelBill",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SendPartNoId",
                table: "WMSReadySlot",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "WMSReadySlot",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSReadySlot",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LineId",
                table: "WMSReadySlot",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReadyMBillId",
                table: "WMSReadyMBillDetailed",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSReadyMBillDetailed",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReReadyMBillId",
                table: "WMSReadyMBill",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MPNId",
                table: "WMSMPNStorageAreaMap",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "WMSMPN",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);
        }
    }
}
