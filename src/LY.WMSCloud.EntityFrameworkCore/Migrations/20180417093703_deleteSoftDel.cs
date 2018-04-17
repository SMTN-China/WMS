using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LY.WMSCloud.Migrations
{
    public partial class deleteSoftDel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSWorkBillDetailed");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSWorkBillDetailed");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSWorkBillDetailed");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSWorkBill");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSWorkBill");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSWorkBill");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSUPH");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSUPH");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSUPH");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSStorageLocationType");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSStorageLocationType");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSStorageLocationType");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSStorageLocation");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSStorageLocation");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSStorageLocation");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSStorageArea");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSStorageArea");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSStorageArea");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSStorage");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSStorage");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSStorage");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSSlot");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSSlot");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSSlot");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSRMMStorageMap");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSRMMStorageMap");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSRMMStorageMap");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSReelSupplyTemp");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSReelSupplyTemp");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSReelSupplyTemp");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSReelMoveMethodLog");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSReelMoveMethodLog");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSReelMoveMethodLog");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSReelMoveMethod");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSReelMoveMethod");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSReelMoveMethod");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSReel");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSReel");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSReel");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSReceivedReelBill");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSReceivedReelBill");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSReceivedReelBill");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSReadySlot");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSReadySlot");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSReadySlot");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSReadyMBillWorkBillMap");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSReadyMBillWorkBillMap");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSReadyMBillWorkBillMap");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSReadyMBillDetailed");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSReadyMBillDetailed");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSReadyMBillDetailed");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSReadyMBill");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSReadyMBill");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSReadyMBill");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSMPNStorageAreaMap");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSMPNStorageAreaMap");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSMPNStorageAreaMap");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSMPN");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSMPN");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSMPN");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSLine");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSLine");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSLine");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSCustomer");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSCustomer");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSCustomer");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSBOM");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSBOM");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSBOM");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WMSBarCodeAnalysis");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WMSBarCodeAnalysis");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WMSBarCodeAnalysis");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "SysOrg");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "SysOrg");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SysOrg");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "SysMenu");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "SysMenu");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SysMenu");

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

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSWorkBillDetailed",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSWorkBillDetailed",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSWorkBillDetailed",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSWorkBill",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSWorkBill",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSWorkBill",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSUPH",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSUPH",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSUPH",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSStorageLocationType",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSStorageLocationType",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSStorageLocationType",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSStorageLocation",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSStorageLocation",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSStorageLocation",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSStorageArea",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSStorageArea",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSStorageArea",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSStorage",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSStorage",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSStorage",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSSlot",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSSlot",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSSlot",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "ReelMoveMethodId",
                table: "WMSRMMStorageMap",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSRMMStorageMap",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSRMMStorageMap",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSRMMStorageMap",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSReelSupplyTemp",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSReelSupplyTemp",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSReelSupplyTemp",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSReelMoveMethodLog",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSReelMoveMethodLog",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSReelMoveMethodLog",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSReelMoveMethod",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSReelMoveMethod",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSReelMoveMethod",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSReel",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSReel",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSReel",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSReel",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "PartNoId",
                table: "WMSReceivedReelBill",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSReceivedReelBill",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSReceivedReelBill",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSReceivedReelBill",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSReadySlot",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSReadySlot",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSReadySlot",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSReadyMBillWorkBillMap",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSReadyMBillWorkBillMap",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSReadyMBillWorkBillMap",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSReadyMBillDetailed",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSReadyMBillDetailed",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSReadyMBillDetailed",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "ReReadyMBillId",
                table: "WMSReadyMBill",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSReadyMBill",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSReadyMBill",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSReadyMBill",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "MPNId",
                table: "WMSMPNStorageAreaMap",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSMPNStorageAreaMap",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSMPNStorageAreaMap",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSMPNStorageAreaMap",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "WMSMPN",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSMPN",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSMPN",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSMPN",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSLine",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSLine",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSLine",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSCustomer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSCustomer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSCustomer",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSBOM",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSBOM",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSBOM",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WMSBarCodeAnalysis",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WMSBarCodeAnalysis",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WMSBarCodeAnalysis",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "SysOrg",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "SysOrg",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SysOrg",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "SysMenu",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "SysMenu",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SysMenu",
                nullable: false,
                defaultValue: false);
        }
    }
}
