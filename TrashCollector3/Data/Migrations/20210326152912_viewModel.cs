using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector3.Data.Migrations
{
    public partial class viewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e14907f-79db-4fa3-9bca-86b6c8e172e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0da7dc3-091c-4082-8408-620c463bef5c");

            migrationBuilder.AddColumn<int>(
                name: "CustomerPickupViewModelId",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerPickupViewModelId",
                table: "Customer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "customerPickupViewModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerPickupViewModels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6ad54e61-dc63-4170-96af-64350dd5c746", "258e862c-386e-4899-aff7-ef4c67ba67b5", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d85adf4f-f94f-4644-93eb-e7b8f6e57af0", "90497675-cc8f-4d00-b9e8-d83ca4ded1e0", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CustomerPickupViewModelId",
                table: "Employee",
                column: "CustomerPickupViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CustomerPickupViewModelId",
                table: "Customer",
                column: "CustomerPickupViewModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_customerPickupViewModels_CustomerPickupViewModelId",
                table: "Customer",
                column: "CustomerPickupViewModelId",
                principalTable: "customerPickupViewModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_customerPickupViewModels_CustomerPickupViewModelId",
                table: "Employee",
                column: "CustomerPickupViewModelId",
                principalTable: "customerPickupViewModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_customerPickupViewModels_CustomerPickupViewModelId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_customerPickupViewModels_CustomerPickupViewModelId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "customerPickupViewModels");

            migrationBuilder.DropIndex(
                name: "IX_Employee_CustomerPickupViewModelId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Customer_CustomerPickupViewModelId",
                table: "Customer");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ad54e61-dc63-4170-96af-64350dd5c746");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d85adf4f-f94f-4644-93eb-e7b8f6e57af0");

            migrationBuilder.DropColumn(
                name: "CustomerPickupViewModelId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CustomerPickupViewModelId",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0da7dc3-091c-4082-8408-620c463bef5c", "13e17581-0904-4f9a-baf1-6be1f5649e7d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e14907f-79db-4fa3-9bca-86b6c8e172e9", "fc9eabb4-d882-4044-80ca-62ef8c035bc5", "Employee", "EMPLOYEE" });
        }
    }
}
