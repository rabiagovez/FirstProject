using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoutubeBlog.Data.Migrations
{
    public partial class UserCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5a9aa585-153c-4cd3-9a5d-82ae6f3bdef1"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d28be444-84c9-48ea-9862-31bb17c4c81a"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("7a0ec460-1800-4e62-a7a4-819f46f17c9f"), new Guid("9d79512d-f19c-4872-982e-fc982916df52"), "Lorem ipsum odor amet, consectetuer adipiscing elit. Magna donec nec inceptos luctus non. Hac dis nascetur facilisi orci risus iaculis. Sem dapibus aliquet sollicitudin dapibus pellentesque tortor mus. Netus duis sodales eu fermentum porttitor velit aptent vitae. Odio metus elementum phasellus tellus mi volutpat mi. Posuere ultricies convallis; class pulvinar nullam pharetra curabitur egestas. Aliquet eros eget eleifend etiam felis eu himenaeos. Interdum condimentum magnis iaculis viverra sociosqu et adipiscing lorem senectus.\r\n\r\nUltrices senectus iaculis lectus ut nisi potenti risus curae euismod. Iaculis scelerisque ad bibendum tellus mi nostra sed dis condimentum. Libero at quam aenean penatibus hac primis varius. Rhoncus velit venenatis dui natoque sodales lacinia ultrices. Vulputate fusce cursus nisi mi nam class cras. Parturient sed inceptos aliquet donec conubia elementum, ex venenatis ullamcorper. Tincidunt himenaeos tortor; metus cubilia volutpat congue vitae id. Cras mollis dis tempus quisque molestie auctor ultrices nascetur. Nunc laoreet varius, finibus diam hendrerit faucibus.\r\n\r\nEst eleifend faucibus purus class amet. Sodales ex rutrum nunc semper aliquet cubilia viverra ante. Interdum habitant primis primis varius mus felis nulla diam potenti. Sed dolor magnis mus quis litora. Et mattis amet nulla sapien finibus aptent. Sollicitudin suspendisse himenaeos commodo fermentum dis faucibus fringilla lectus. Fames integer urna tristique penatibus bibendum nostra. Sed primis erat efficitur ad hendrerit tincidunt felis egestas.", "Admin Test", new DateTime(2024, 10, 21, 9, 55, 0, 733, DateTimeKind.Local).AddTicks(6565), null, null, new Guid("b3ccaf0f-5b84-4600-9374-d0cb16fbaa28"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 },
                    { new Guid("83f5b0ff-c2dd-40df-b86d-0ab9867388e3"), new Guid("7dbd3759-a9d3-49dc-9c99-974e69ac9b92"), "Lorem ipsum odor amet, consectetuer adipiscing elit. Magna donec nec inceptos luctus non. Hac dis nascetur facilisi orci risus iaculis. Sem dapibus aliquet sollicitudin dapibus pellentesque tortor mus. Netus duis sodales eu fermentum porttitor velit aptent vitae. Odio metus elementum phasellus tellus mi volutpat mi. Posuere ultricies convallis; class pulvinar nullam pharetra curabitur egestas. Aliquet eros eget eleifend etiam felis eu himenaeos. Interdum condimentum magnis iaculis viverra sociosqu et adipiscing lorem senectus.\r\n\r\nUltrices senectus iaculis lectus ut nisi potenti risus curae euismod. Iaculis scelerisque ad bibendum tellus mi nostra sed dis condimentum. Libero at quam aenean penatibus hac primis varius. Rhoncus velit venenatis dui natoque sodales lacinia ultrices. Vulputate fusce cursus nisi mi nam class cras. Parturient sed inceptos aliquet donec conubia elementum, ex venenatis ullamcorper. Tincidunt himenaeos tortor; metus cubilia volutpat congue vitae id. Cras mollis dis tempus quisque molestie auctor ultrices nascetur. Nunc laoreet varius, finibus diam hendrerit faucibus.\r\n\r\nEst eleifend faucibus purus class amet. Sodales ex rutrum nunc semper aliquet cubilia viverra ante. Interdum habitant primis primis varius mus felis nulla diam potenti. Sed dolor magnis mus quis litora. Et mattis amet nulla sapien finibus aptent. Sollicitudin suspendisse himenaeos commodo fermentum dis faucibus fringilla lectus. Fames integer urna tristique penatibus bibendum nostra. Sed primis erat efficitur ad hendrerit tincidunt felis egestas.", "Admin Test", new DateTime(2024, 10, 21, 9, 55, 0, 733, DateTimeKind.Local).AddTicks(6570), null, null, new Guid("4eb578f7-2d83-4832-b0b6-483f12c5a5cc"), false, null, null, "Visual Studio Deneme Makalesi 2", 15 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("3c25d1ee-c548-4ad1-a002-3aefeaac6037"), "e6fa48bf-2573-459e-91d5-4cfb31c85634", "User", "USER" },
                    { new Guid("8de3b7c6-5c8b-43ce-b764-1451667b4e5e"), "8bd64081-ab1b-46aa-b467-cef59fb71539", "Superadmin", "SUPERADMIN" },
                    { new Guid("e59db774-f8e0-49af-a700-ab4dc816b6ed"), "5c959984-2bfe-476b-b658-9a9a4555a264", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("12ec1a48-7faa-43a0-afa3-e438928e5983"), 0, "5cc1b310-44b2-4a53-b7f4-c1710f169b59", "admin@gmail.com", true, "Admin", "User", false, null, "ADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEI6hPuM91s/0HyHDs/W2ySwjzDqmfCZBffP+P2kkfJFkqfM5LpwiKZ1T3KKK489uhw==", "+905435876588", true, "1a9d7637-ca97-41fe-84df-ba8e1e8d7dda", false, "admin@gmail.com" },
                    { new Guid("897010e5-b0c4-4776-8630-c4fca38bfad7"), 0, "148a16d0-b48e-4b8d-a174-0a922bb9172f", "superadmin@gmail.com", true, "Rabia", "Gövez", false, null, "SUPERADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEM2MR8Xl5YyK2QzbF8HUuiyWgzOYAfBwcz8ByVjgyzB7UCL0Dq7S/K48gUlnIwmd4Q==", "+905435876554", true, "2d5c69c4-4163-41d3-b809-a11122de673c", false, "superadmin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7dbd3759-a9d3-49dc-9c99-974e69ac9b92"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 21, 9, 55, 0, 733, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d79512d-f19c-4872-982e-fc982916df52"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 21, 9, 55, 0, 733, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4eb578f7-2d83-4832-b0b6-483f12c5a5cc"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 21, 9, 55, 0, 733, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b3ccaf0f-5b84-4600-9374-d0cb16fbaa28"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 21, 9, 55, 0, 733, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("e59db774-f8e0-49af-a700-ab4dc816b6ed"), new Guid("12ec1a48-7faa-43a0-afa3-e438928e5983") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8de3b7c6-5c8b-43ce-b764-1451667b4e5e"), new Guid("897010e5-b0c4-4776-8630-c4fca38bfad7") });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7a0ec460-1800-4e62-a7a4-819f46f17c9f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("83f5b0ff-c2dd-40df-b86d-0ab9867388e3"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("5a9aa585-153c-4cd3-9a5d-82ae6f3bdef1"), new Guid("7dbd3759-a9d3-49dc-9c99-974e69ac9b92"), "Lorem ipsum odor amet, consectetuer adipiscing elit. Magna donec nec inceptos luctus non. Hac dis nascetur facilisi orci risus iaculis. Sem dapibus aliquet sollicitudin dapibus pellentesque tortor mus. Netus duis sodales eu fermentum porttitor velit aptent vitae. Odio metus elementum phasellus tellus mi volutpat mi. Posuere ultricies convallis; class pulvinar nullam pharetra curabitur egestas. Aliquet eros eget eleifend etiam felis eu himenaeos. Interdum condimentum magnis iaculis viverra sociosqu et adipiscing lorem senectus.\r\n\r\nUltrices senectus iaculis lectus ut nisi potenti risus curae euismod. Iaculis scelerisque ad bibendum tellus mi nostra sed dis condimentum. Libero at quam aenean penatibus hac primis varius. Rhoncus velit venenatis dui natoque sodales lacinia ultrices. Vulputate fusce cursus nisi mi nam class cras. Parturient sed inceptos aliquet donec conubia elementum, ex venenatis ullamcorper. Tincidunt himenaeos tortor; metus cubilia volutpat congue vitae id. Cras mollis dis tempus quisque molestie auctor ultrices nascetur. Nunc laoreet varius, finibus diam hendrerit faucibus.\r\n\r\nEst eleifend faucibus purus class amet. Sodales ex rutrum nunc semper aliquet cubilia viverra ante. Interdum habitant primis primis varius mus felis nulla diam potenti. Sed dolor magnis mus quis litora. Et mattis amet nulla sapien finibus aptent. Sollicitudin suspendisse himenaeos commodo fermentum dis faucibus fringilla lectus. Fames integer urna tristique penatibus bibendum nostra. Sed primis erat efficitur ad hendrerit tincidunt felis egestas.", "Admin Test", new DateTime(2024, 10, 13, 10, 45, 18, 130, DateTimeKind.Local).AddTicks(6693), null, null, new Guid("4eb578f7-2d83-4832-b0b6-483f12c5a5cc"), false, null, null, "Visual Studio Deneme Makalesi 2", 15 },
                    { new Guid("d28be444-84c9-48ea-9862-31bb17c4c81a"), new Guid("9d79512d-f19c-4872-982e-fc982916df52"), "Lorem ipsum odor amet, consectetuer adipiscing elit. Magna donec nec inceptos luctus non. Hac dis nascetur facilisi orci risus iaculis. Sem dapibus aliquet sollicitudin dapibus pellentesque tortor mus. Netus duis sodales eu fermentum porttitor velit aptent vitae. Odio metus elementum phasellus tellus mi volutpat mi. Posuere ultricies convallis; class pulvinar nullam pharetra curabitur egestas. Aliquet eros eget eleifend etiam felis eu himenaeos. Interdum condimentum magnis iaculis viverra sociosqu et adipiscing lorem senectus.\r\n\r\nUltrices senectus iaculis lectus ut nisi potenti risus curae euismod. Iaculis scelerisque ad bibendum tellus mi nostra sed dis condimentum. Libero at quam aenean penatibus hac primis varius. Rhoncus velit venenatis dui natoque sodales lacinia ultrices. Vulputate fusce cursus nisi mi nam class cras. Parturient sed inceptos aliquet donec conubia elementum, ex venenatis ullamcorper. Tincidunt himenaeos tortor; metus cubilia volutpat congue vitae id. Cras mollis dis tempus quisque molestie auctor ultrices nascetur. Nunc laoreet varius, finibus diam hendrerit faucibus.\r\n\r\nEst eleifend faucibus purus class amet. Sodales ex rutrum nunc semper aliquet cubilia viverra ante. Interdum habitant primis primis varius mus felis nulla diam potenti. Sed dolor magnis mus quis litora. Et mattis amet nulla sapien finibus aptent. Sollicitudin suspendisse himenaeos commodo fermentum dis faucibus fringilla lectus. Fames integer urna tristique penatibus bibendum nostra. Sed primis erat efficitur ad hendrerit tincidunt felis egestas.", "Admin Test", new DateTime(2024, 10, 13, 10, 45, 18, 130, DateTimeKind.Local).AddTicks(6688), null, null, new Guid("b3ccaf0f-5b84-4600-9374-d0cb16fbaa28"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7dbd3759-a9d3-49dc-9c99-974e69ac9b92"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 10, 45, 18, 130, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d79512d-f19c-4872-982e-fc982916df52"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 10, 45, 18, 130, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4eb578f7-2d83-4832-b0b6-483f12c5a5cc"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 10, 45, 18, 130, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b3ccaf0f-5b84-4600-9374-d0cb16fbaa28"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 10, 45, 18, 130, DateTimeKind.Local).AddTicks(6931));
        }
    }
}
