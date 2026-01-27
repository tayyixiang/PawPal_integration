using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PawPal_integration.Migrations
{
    /// <inheritdoc />
    public partial class IntegrationLvl2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5605254-3fd4-4679-8263-7513cebfdfd2", "AQAAAAIAAYagAAAAEOBcBnizIk+UbIVtPRKFfn8XpKjAqikA+aSnoiQdsy2JYyP7T3qYsNU9wBtDJUyIuQ==", "293d1a5c-1049-4f34-a303-ae7e5a61963b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2391a3a-2840-4887-976b-1adedc263829", "AQAAAAIAAYagAAAAEIuRXu8rXWEuFDpPinIvyv+hxI5/Kx3BO8uCkbrBr339snHolQbsUp/RxuyevjDIAg==", "d9468a26-b472-4267-945d-05891ff045f4" });
        }
    }
}
