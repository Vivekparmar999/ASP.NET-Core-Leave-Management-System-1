using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Migrations
{
    public partial class AddedLeaveAllocationCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocations");

            migrationBuilder.DropIndex(
                name: "IX_LeaveAllocations_LeaveTypeId",
                table: "LeaveAllocations");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "LeaveTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "LeaveTypeId",
                table: "LeaveAllocations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67aa2cf7-7951-4ffe-b1f0-76f8705e6461",
                column: "ConcurrencyStamp",
                value: "4929443b-c05a-49b7-ba6b-0abc1b41775d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67cb2cf7-7950-4ffe-b1f0-75f8705e6461",
                column: "ConcurrencyStamp",
                value: "0e4f73cf-8edb-43ad-b2aa-0eef417f48f2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67bi2cf3-2950-4ffe-b1f0-75f8705e2469",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b12c2b9e-aa11-47ff-bd23-6dd845bde35a", "AQAAAAEAACcQAAAAEKG42NyruzEyqeCwgzAISH+EESblFDQp6e9e7cg4qtl3dXorDvywCS43NSFtOAWw4w==", "033a4cf0-3128-4167-bada-5289ec716cba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67bq2cb3-1955-4sfe-b1f7-73f8705e2469",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcaf76d5-618e-435f-86fc-8e62782e569e", "AQAAAAEAACcQAAAAECIukk344E8s4+kJQLlmI+JA4YEOLNFYWDDq19C7CbsPG9F8BQEs5mZPaKtpLpPjSA==", "4447ed86-2752-4881-afcc-2cf98bc24858" });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveTypes_LeaveAllocations_Id",
                table: "LeaveTypes",
                column: "Id",
                principalTable: "LeaveAllocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveTypes_LeaveAllocations_Id",
                table: "LeaveTypes");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "LeaveTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "LeaveTypeId",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67aa2cf7-7951-4ffe-b1f0-76f8705e6461",
                column: "ConcurrencyStamp",
                value: "fb04635f-0d20-4670-9c94-722fdcabb9fd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67cb2cf7-7950-4ffe-b1f0-75f8705e6461",
                column: "ConcurrencyStamp",
                value: "d30f4382-b05f-41da-be23-a1a52c9f4506");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67bi2cf3-2950-4ffe-b1f0-75f8705e2469",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5cb1f27-0a4f-4cf2-ad9a-c10a3a4507ea", "AQAAAAEAACcQAAAAELCGrrLUkNCxt5lSEHmanCFLZyCefnF277omhZyMRruhw8z5to9Yycb7QvCPTY1VrA==", "f8e3d1d0-8b4b-4627-a76a-2d9ba520b577" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67bq2cb3-1955-4sfe-b1f7-73f8705e2469",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f461f74e-5f46-4939-a6ff-e3fbfc0c1ef2", "AQAAAAEAACcQAAAAECSbhJtOfRu9s5YTIJKDpz/tC7QnLTYKhzS8kPxZPcdeT6EB1VwE1YbmrQQBNfpS/A==", "8c156caf-447b-4036-9dca-591e8095fb3c" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
