using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ContactUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Options_OptionId",
                table: "Contacts");

            migrationBuilder.AlterColumn<int>(
                name: "OptionId",
                table: "Contacts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "HiddenSelectInput",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Options_OptionId",
                table: "Contacts",
                column: "OptionId",
                principalTable: "Options",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Options_OptionId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "HiddenSelectInput",
                table: "Contacts");

            migrationBuilder.AlterColumn<int>(
                name: "OptionId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Options_OptionId",
                table: "Contacts",
                column: "OptionId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
