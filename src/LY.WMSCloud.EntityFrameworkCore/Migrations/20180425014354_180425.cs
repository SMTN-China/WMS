﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LY.WMSCloud.Migrations
{
    public partial class _180425 : Migration
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
                name: "Name",
                table: "WMSMPN",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Name",
                table: "WMSMPN",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
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
