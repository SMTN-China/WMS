using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LY.WMSCloud.Migrations
{
    public partial class _18042602 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrightColor",
                table: "WMSStorageLocation");

            migrationBuilder.DropColumn(
                name: "BrightState",
                table: "WMSStorageLocation");

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

            migrationBuilder.AddColumn<int>(
                name: "LightColor",
                table: "WMSStorageLocation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LightState",
                table: "WMSStorageLocation",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddColumn<string>(
                name: "BOMId",
                table: "WMSReelMoveMethodLog",
                nullable: true);

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
                name: "SlotId",
                table: "WMSReadyMBillDetailed",
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
                name: "PartNoId",
                table: "WMSPrintReel",
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

            migrationBuilder.CreateIndex(
                name: "IX_WMSReelMoveMethodLog_BOMId",
                table: "WMSReelMoveMethodLog",
                column: "BOMId");

            migrationBuilder.AddForeignKey(
                name: "FK_WMSReelMoveMethodLog_WMSBOM_BOMId",
                table: "WMSReelMoveMethodLog",
                column: "BOMId",
                principalTable: "WMSBOM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WMSReelMoveMethodLog_WMSBOM_BOMId",
                table: "WMSReelMoveMethodLog");

            migrationBuilder.DropIndex(
                name: "IX_WMSReelMoveMethodLog_BOMId",
                table: "WMSReelMoveMethodLog");

            migrationBuilder.DropColumn(
                name: "LightColor",
                table: "WMSStorageLocation");

            migrationBuilder.DropColumn(
                name: "LightState",
                table: "WMSStorageLocation");

            migrationBuilder.DropColumn(
                name: "BOMId",
                table: "WMSReelMoveMethodLog");

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

            migrationBuilder.AddColumn<int>(
                name: "BrightColor",
                table: "WMSStorageLocation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrightState",
                table: "WMSStorageLocation",
                nullable: false,
                defaultValue: 0);

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
                name: "SlotId",
                table: "WMSReadyMBillDetailed",
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
                name: "PartNoId",
                table: "WMSPrintReel",
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
