﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace acme.atena.infra.Migrations
{
    public partial class removendoTelaSistema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tela_Tela_TelaSistemaFilhaId",
                table: "Tela");

            migrationBuilder.DropIndex(
                name: "IX_Tela_TelaSistemaFilhaId",
                table: "Tela");

            migrationBuilder.DropColumn(
                name: "TelaSistemaFilhaId",
                table: "Tela");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "TelaSistemaFilhaId",
                table: "Tela",
                type: "varbinary(16)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.CreateIndex(
                name: "IX_Tela_TelaSistemaFilhaId",
                table: "Tela",
                column: "TelaSistemaFilhaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tela_Tela_TelaSistemaFilhaId",
                table: "Tela",
                column: "TelaSistemaFilhaId",
                principalTable: "Tela",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
