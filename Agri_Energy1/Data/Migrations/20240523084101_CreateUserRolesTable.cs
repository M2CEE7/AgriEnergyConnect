﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agri_Energy1.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateUserRolesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
             name: "AspNetUserRoles",
             columns: table => new
             {
                 UserId = table.Column<string>(nullable: false),
                 RoleId = table.Column<string>(nullable: false)
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


            migrationBuilder.CreateIndex(
               name: "IX_AspNetUserRoles_RoleId",
               table: "AspNetUserRoles",
               column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
              name: "AspNetUserRoles");
        }
    }
}
