using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PawPal_integration.Migrations
{
    /// <inheritdoc />
    public partial class application_page : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2391a3a-2840-4887-976b-1adedc263829", "AQAAAAIAAYagAAAAEIuRXu8rXWEuFDpPinIvyv+hxI5/Kx3BO8uCkbrBr339snHolQbsUp/RxuyevjDIAg==", "d9468a26-b472-4267-945d-05891ff045f4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a12bfe3-2720-466a-a5d8-fb0d9ecfcda6", "AQAAAAIAAYagAAAAEN4/h/bYwA/p612fBO/TPXLhjbIns7Pcigjk5fKOWx3oyyDevzvv6UF3DElmJ4NUuw==", "e8f47e47-3df4-48ad-b3f9-22da71667ef5" });
        }
    }
}
