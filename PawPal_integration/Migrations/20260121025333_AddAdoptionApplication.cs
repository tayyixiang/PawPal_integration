using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PawPal_integration.Migrations
{
    /// <inheritdoc />
    public partial class AddAdoptionApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdoptionApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetId = table.Column<int>(type: "int", nullable: false),
                    AdopterId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewedByAdminId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HousingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasLandlordOrFamilyApproval = table.Column<bool>(type: "bit", nullable: false),
                    AnyoneAllergic = table.Column<bool>(type: "bit", nullable: false),
                    AvgHoursAlone = table.Column<int>(type: "int", nullable: false),
                    CurrentlyOwnPets = table.Column<bool>(type: "bit", nullable: false),
                    CurrentPetsDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PetExperienceDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonForAdoption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryCaregiver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreparedForVetCare = table.Column<bool>(type: "bit", nullable: false),
                    AdminRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdoptionApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdoptionApplications_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a12bfe3-2720-466a-a5d8-fb0d9ecfcda6", "AQAAAAIAAYagAAAAEN4/h/bYwA/p612fBO/TPXLhjbIns7Pcigjk5fKOWx3oyyDevzvv6UF3DElmJ4NUuw==", "e8f47e47-3df4-48ad-b3f9-22da71667ef5" });

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionApplications_PetId",
                table: "AdoptionApplications",
                column: "PetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdoptionApplications");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86ff0092-4282-440a-b513-443987ba0596", "AQAAAAIAAYagAAAAEMMmy68eF15F189xb7z0m99G9wWBm40pVpmVkuG2uygIS5Yh5DaAsFamnp5YWj0IHg==", "f0fec84a-aba5-426d-b692-1d7aa3578196" });
        }
    }
}
